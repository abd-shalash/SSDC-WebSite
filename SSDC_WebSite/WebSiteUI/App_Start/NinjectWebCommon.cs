[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(WebSiteUI.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(WebSiteUI.App_Start.NinjectWebCommon), "Stop")]

namespace WebSiteUI.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Moq;
    using ClassLibrary.Abstract;
    using ClassLibrary.Entities;
    using System.Collections.Generic;
    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            Mock<IPersonRepository> mock = new Mock<IPersonRepository>();
            mock.Setup(m => m.People).Returns(new List<Person> { 
                new Person { Fname = "abdulrahman" , Mname = "amin",Lname = "shalash",id=1,password="123"},
                new Person { Fname = "nasser" , Mname = "bin",Lname = "abeed",id=2,password="123"}
                 });
            kernel.Bind<IPersonRepository>().ToConstant(mock.Object);
                    
                
        }        
    }
}