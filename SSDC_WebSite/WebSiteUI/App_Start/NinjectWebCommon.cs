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
    using ClassLibrary.Concrate;
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
                new Person { Fname = "abdulrahman" , Mname = "amin",Lname = "shalash",ID=1,Password="123"},
                new Person { Fname = "nasser" , Mname = "bin",Lname = "abeed",ID=2,Password="123"}
                 });
            Mock<IEventRepository> mockEvent = new Mock<IEventRepository>();
            mockEvent.Setup(m => m.Events).Returns(new List<Event> {
                new Event {ID = 1 , eventDescription = "this is evrn one" , EvName = "event 1" },
                new Event {ID = 2 , eventDescription = "this is evrn two" , EvName = "event 2" },
                new Event {ID = 3 , eventDescription = "this is evrn three" , EvName = "event 3" }

            });
            Mock<IFacilityRepository> mockFacility = new Mock<IFacilityRepository>();
            mockFacility.Setup(m => m.facilities).Returns(new List<Facility> {
                new Facility {ID = 1 , FaDescription = "this is Facility one" , FaName = "Facility 1" },
                new Facility {ID = 2 , FaDescription = "this is Facility two" , FaName = "Facility 2" }

            });
            kernel.Bind<IPersonRepository>().ToConstant(mock.Object);
            kernel.Bind<IEventRepository>().ToConstant(mockEvent.Object);
            kernel.Bind<IFacilityRepository>().ToConstant(mockFacility.Object);
            kernel.Bind<IAuthentication>().To<FormsAuthenticationProvider>();

            // use this bind when implimenting the full database otherwise you will get injection error
            // kernel.Bind<IPersonRepository>().To<EF_PersonRepository>();  
        }
    }
}
