using System.Collections.Generic;

namespace meetingplanner.Models
{
    public class OrderDetail
    {
        public int Id {get;set;}

        public int EventId {get;set;}

        public Event Event {get;set;}

        public Order Order {get;set;}

        public int OrderId{get;set;}

    }
}