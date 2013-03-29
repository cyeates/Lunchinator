
using Lunchinator.Data.Entities;
using Lunchinator.Domain;
using Lunchinator.Domain.BusinessApi;
using Lunchinator.Domain.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunchinator.Data
{
    public class LunchinatorInitializer : DropCreateDatabaseIfModelChanges<LunchinatorContext>
    {
       
        protected override void Seed(LunchinatorContext context)
        {
            //var eventService = new LunchService(new YelpProvider(), new UnitOfWork(new LunchinatorContext()), new AverageOfRatings(new Recommendation(new PearsonCorrelation())));
            //var lunch = eventService.CreateLunch(new SearchParameters {
            //    Latitude = 32.7302197,
            //    Longitude = -97.81433
            //});

            //var users = new List<User> {
            //    new User{UserId=1, FullName = "Chad"},
            //    new User{UserId=2, FullName="Caleb"}
            //};
            //var lunch = new Event 
            //                { 
                               
            //                    Businesses = new List<Business> {
            //                        new Business{Id="1", Address=new[] {"123 anywhere", "weatherford", "tx", "76086"}, Name="Pizza Place"},
            //                        new Business{Id="2", Address=new[] {"123 anywhere", "weatherford", "tx", "76086"}, Name="Golden Moon"},
            //                        new Business{Id="3", Address=new[] {"123 anywhere", "weatherford", "tx", "76086"}, Name="Buffalo Wild Wings"},
            //                        new Business{Id="4", Address=new[] {"123 anywhere", "weatherford", "tx", "76086"}, Name="Antonios"},
            //                        new Business{Id="5", Address=new[] {"123 anywhere", "weatherford", "tx", "76086"}, Name="Cici's"},
            //                        new Business{Id="6", Address=new[] {"123 anywhere", "weatherford", "tx", "76086"}, Name="McAllisters"},
            //                        new Business{Id="7", Address=new[] {"123 anywhere", "weatherford", "tx", "76086"}, Name="Kincaid's"},
            //                        new Business{Id="8", Address=new[] {"123 anywhere", "weatherford", "tx", "76086"}, Name="Malt Shop"},
            //                        new Business{Id="9", Address=new[] {"123 anywhere", "weatherford", "tx", "76086"}, Name="Alvin Ord's"},
            //                        new Business{Id="10", Address=new[] {"123 anywhere", "weatherford", "tx", "76086"}, Name="Panda Express"}

            //                    } };

            //lunch.Users.AddRange(users);
            //users.ForEach(u => context.Users.Add(u));
            ////context.Events.Add(lunch);

            //context.SaveChanges();
            
        }
    }
}
