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
            kernel.Bind<IAuthentication>().To<LoginAuthenticationProvider>();


            kernel.Bind<IPersonRepository>().To<EF_PersonRepository>();
            //Mock<IPersonRepository> mockPerson = new Mock<IPersonRepository>();
            //mockPerson.Setup(m => m.People).Returns(new List<Person> {
            //    new Person { Fname = "abdulrahman", Mname = "amin", Lname = "shalash", ID=1, Password="123", Username="abd"},
            //    new Person { Fname = "nasser", Mname = "bin", Lname = "obied", ID=2, Password="123", Username="nasser@pnu.edu"}
            //     });
            //kernel.Bind<IPersonRepository>().ToConstant(mockPerson.Object);


            kernel.Bind<IEventRepository>().To<EF_EventRepository>();
            //Mock<IEventRepository> mockEvent = new Mock<IEventRepository>();
            //mockEvent.Setup(m => m.Events).Returns(new List<Event> {
            //new Event { ID = 1, eventDescription = "this is evrn one", eventName = "event 1" },
            //    new Event { ID = 2, eventDescription = "this is evrn two", eventName = "event 2" },
            //    new Event { ID = 3, eventDescription = "this is evrn three", eventName = "event 3" }
            //      });
            //kernel.Bind<IEventRepository>().ToConstant(mockEvent.Object);


            kernel.Bind<IFacilityRepository>().To<EF_FacilityRepository>();
            //Mock<IFacilityRepository> mockFacility = new Mock<IFacilityRepository>();
            //mockFacility.Setup(m => m.facilities).Returns(new List<Facility> {
            //    new Facility {ID = 1 , FaDescription = "this is Facility one" , FaName = "Facility 1" },
            //    new Facility {ID = 2 , FaDescription = "this is Facility two" , FaName = "Facility 2" },
            //    new Facility {ID = 3 , FaDescription = "this is Facility three" , FaName = "Facility 3" },
            //    new Facility {ID = 4 , FaDescription = "this is Facility fore" , FaName = "Facility 4" }
            //});
            //kernel.Bind<IFacilityRepository>().ToConstant(mockFacility.Object);
            kernel.Bind<Iadditional_serviceRepo>().To<EF_additional_serviceRepo>();

            kernel.Bind<Ibooking_assigned_userRepo>().To<EF_booking_assigned_userRepo>();

            kernel.Bind<Ibooking_objectRepo>().To<EF_booking_objectRepo>();

            kernel.Bind<IbookingRepo>().To<EF_bookingRepo>();

            kernel.Bind<IdepartmentRepo>().To<EF_departmentRepo>();

      //      kernel.Bind<IEventRepository>().To<EF_EventRepository>();

       //     kernel.Bind<IFacilityRepository>().To<EF_FacilityRepository>();

            kernel.Bind<Ifield_optionRepo>().To<EF_field_optionRepo>();

            kernel.Bind<Ifield_resultRepo>().To<EF_field_resultRepo>();

            kernel.Bind<IfieldRepo>().To<EF_fieldRepo>();

            kernel.Bind<IformRepo>().To<EF_formRepo>();

            kernel.Bind<IgroupRepo>().To<EF_groupRepo>();

            kernel.Bind<Iobject_propertyRepo>().To<EF_object_propertyRepo>();

            kernel.Bind<Iobject_typeRepo>().To<EF_object_typeRepo>();

            kernel.Bind<IobjecttRepo>().To<EF_objecttRepo>();

            kernel.Bind<IoperationRepo>().To<EF_operationRepo>();

            kernel.Bind<Iorganization_typeRepo>().To<EF_organization_typeRepo>();

            kernel.Bind<IorganizationRepo>().To<EF_organizationRepo>();

            kernel.Bind<Iparticipant_levelRepo>().To<EF_participant_levelRepo>();

          //  kernel.Bind<IPersonRepository>().To<EF_PersonRepository>();

            kernel.Bind<IpositionRepo>().To<EF_positionRepo>();

            kernel.Bind<Iproperty_typeRepo>().To<EF_property_typeRepo>();

            kernel.Bind<IpropertyRepo>().To<EF_propertyRepo>();

            kernel.Bind<Iservice_costRepo>().To<EF_service_costRepo>();

            kernel.Bind<ItemplateRepo>().To<EF_templateRepo>();

            kernel.Bind<Iuser_groupRepo>().To<EF_user_groupRepo>();

            kernel.Bind<IuserRepo>().To<EF_userRepo>();

            kernel.Bind<ItemplateRepo>().To<EF_templateRepo>();


        }
    }
}