using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Final.Models;
namespace meetingplanner
{
    public class Database
    {
        public static void Initialize(EventContext context)
        {
            
            context.Database.EnsureCreated();
            if (context.Cities.Any()) { return; }

            var cities = new City[]
            {
                new City {Name="Orda"},
                new City {Name="Almaty"},
                new City {Name="Astana"},
            };
            foreach (City c in cities)
            {
                context.Cities.Add(c);
            }
            context.SaveChanges();

            var clients = new Client[]
            {
                new Client {Name="Gaziz", LastName="Ukan"},
                new Client {Name="Nurzhaysyn", LastName="Maksat"},
                new Client {Name="Nurbek", LastName="Kabylbai"},
            };

            foreach (Client cl in clients)
            {
                context.Clients.Add(cl);
            }
            context.SaveChanges();

            var events = new Event[]
           {
                new Event {Name="DavidGuetta", Price=10000, CityId=1},
                new Event {Name="Toregali", Price=5000, CityId=2},
                new Event {Name="KN", Price=3000, CityId=3}
           };
            foreach (Event ev in events)
            {
                context.Events.Add(ev);
            }
            context.SaveChanges();

            var orders = new Order[]
           {
                new Order {OrderDate=DateTime.Now, ClientId=1},
           };
            foreach (Order r in orders)
            {
                context.Orders.Add(r);
            }
            context.SaveChanges();

            var orderDetails = new OrderDetail[]
            {
                new OrderDetail { EventId=1 , OrderId=1 }
            };
            foreach (OrderDetail od in orderDetails)
            {
                context.OrderDetails.Add(od);
            }
            context.SaveChanges();
        }
    }
}