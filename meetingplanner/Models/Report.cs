using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace meetingplanner.Models
{
    public class Report
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int NumberOfOrders { get; set; }

        public int PercentageBetweenCities { get; set; }


    }
}

