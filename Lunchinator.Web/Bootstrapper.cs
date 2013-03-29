using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc3;
using System.Web.Http;
using Lunchinator.Data;
using Lunchinator.Domain;
using Lunchinator.Domain.Services;
using Lunchinator.Domain.BusinessApi;
using Lunchinator.Data.Contracts;

namespace Lunchinator.Web
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>(); 
            //data
            container.RegisterType<LunchinatorContext,LunchinatorContext>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();

            //recommendation engine
            container.RegisterType<IGroupRecommendationAlgorithm,AverageOfRatings>();
            container.RegisterType<ISimilarityAlgorithm,PearsonCorrelation>();
            container.RegisterType<Recommendation,Recommendation>();

            //service
            container.RegisterType<LunchService,LunchService>();
            container.RegisterType<UserService,UserService>();

            //restaurant api
            container.RegisterType<IBusinessApiProvider,YelpProvider>();

            return container;
        }
    }
}