using System.Collections.Generic;

namespace meetingplanner.Models
{
    public class Client
    {
        public int Id {get;set;}
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public List<Order> Orders {get;set;}
    }
}