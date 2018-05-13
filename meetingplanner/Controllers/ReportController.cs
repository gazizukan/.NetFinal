using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using meetingplanner.Models;

namespace meetingplanner.Controllers
{
    [Produces("application/json")]
    [Route("api/Report")]
    public class ReportController : Controller
    {
        private readonly EverntContext _context;

        public ReportController(EventContext context)
        {
            _context = context;
        }

        // GET: api/Reports
        [HttpGet]

        public IEnumerable<Report> GetReport()
        {
            var orders = _context.Orders;
            var events = _context.Events;
            var orderDetails = _context.OrderDetails;
            var cities = _context.Cities;

            var evcl = cities
               .Join(events, x => x.Id, y => y.CityId, (x, y) => new
               { x, y }).ToList();

            var det = evcl
                .Join(orderDetails, a => a.y.Id, b => b.EventId, (a, b) => new
                { a, b }).ToList();

            var gr = det
              .Join(orders, c => c.b.OrderId, d => d.Id, (c,d) => new
              { c, d }).ToList();

              var ordtime = ot.Select(d=>new
                        {
                            d.DateTime.Year,
                            d.DateTime.Month,
                            FormattedDate = d.DateTime.ToString("yyyy-MMM")
                        }
                    ).Distinct()
                    .OrderByDescending(d => d.Year)
                    .ThenByDescending(d => d.Month)
                    .Select(d => d.FormattedDate)

            var countOrders = orderDetails.Count();
            var group = gr
                .GroupBy(x => x.c.e.x.CityName)
                .Select(f=> new Report
                {
                    City = f.Key,
                    TotalAmountOfAllOrders = f.Sum(x => x.c.e.y.Price),
                    PercentageFromAllOrders = 100 * s.Select
                                                    (sel => sel.c.j.Id).Count() / countOrders ,
                });

            return group.ToList();
        }   
    }
}