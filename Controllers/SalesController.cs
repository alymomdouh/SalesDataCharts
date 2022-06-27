using Microsoft.AspNetCore.Mvc;

namespace SalesDataCharts.Controllers
{
    public class SalesController : Controller
    {
        private readonly SalesDbContext dbContext;
        public SalesController(SalesDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        // this example one print static data 
        public IActionResult ShowSalesData()
        {
            return View();
        }
        public IActionResult ShowSalesDataDB()
        {
            return View();
        }
        [HttpPost]
        public List<object> getSalesData()
        {
            List<object> data = new List<object>();
            List<string> labels = dbContext.salesEntities.Select(c=>c.MonthName).ToList();
            data.Add(labels);
            List<int> salesNumbers = dbContext.salesEntities.Select(c => c.TotalSales).ToList();
            data.Add(salesNumbers);
            return data;
        }
    }
}
