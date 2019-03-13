using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Inspirtrip.Models;

namespace Inspirtrip.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            // Generate users
            var users = new List<User>
            {
            new User{Firstname="Andrie",Lastname="Ochtman",Username="aochtman",Email="an3_13@hotmail.com",Password="andrie1234"},
            new User{Firstname="Andrie2",Lastname="Ochtman2",Username="aochtman2",Email="an3_13@hotmail.com",Password="andrie1234"},
            new User{Firstname="Test",Lastname="1",Username="test1",Email="test1@hotmail.com",Password="test123"},
            new User{Firstname="Test",Lastname="2",Username="test2",Email="test2@hotmail.com",Password="test123"},
            new User{Firstname="Test",Lastname="3",Username="test3",Email="test3@hotmail.com",Password="test123"}
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            // Generate itineraries
            var itineraries = new List<Itinerary>
            {
            new Itinerary{Title="Bali",Cost=1000.42,CoverPage="Coverpage",UserID=1},
            new Itinerary{Title="Singapore",Cost=999.35,CoverPage="Coverpage",UserID=1},
            new Itinerary{Title="Sydney",Cost=2134.35,CoverPage="Coverpage",UserID=2},
            new Itinerary{Title="Amsterdam",Cost=1338.52,CoverPage="Coverpage",UserID=2}
            };
            itineraries.ForEach(s => context.Itineraries.Add(s));
            context.SaveChanges();

            // Generate subscriptions
            //var subscriptions = new List<Subscription>
            //{
            //new Subscription{UserID=3,ItineraryID=1},
            //new Subscription{UserID=3,ItineraryID=2},
            //new Subscription{UserID=3,ItineraryID=3},
            //new Subscription{UserID=3,ItineraryID=4},
            //new Subscription{UserID=4,ItineraryID=1},
            //new Subscription{UserID=4,ItineraryID=3}
            //};
            //subscriptions.ForEach(s => context.Subscriptions.Add(s));
            //context.SaveChanges();
        }
    }
}