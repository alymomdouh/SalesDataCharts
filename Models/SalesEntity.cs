using System.ComponentModel.DataAnnotations;

namespace SalesDataCharts.Models
{
    public class SalesEntity
    {
        [Key]
        public int Id { get; set; }
        public string MonthName { get; set; }
        public int TotalSales { get; set; }
    }
}
