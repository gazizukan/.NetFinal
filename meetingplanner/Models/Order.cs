using System;
using System.Collections.Generic;

namespace meetingplanner.Models
{
    public class Order
    {
        public int Id {get;set;}
        public DateTime OrderTime {get;set;}
        public List<OrderDetail> OrderDetails {get;set;}
        public int ClientId {get;set;}

        public Client Client {get;set;}
    }
}