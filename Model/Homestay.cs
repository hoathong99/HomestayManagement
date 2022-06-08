using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeStayManagement.Model
{
    public class Homestay
    {
        [Key, DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string? Name { get; set; }
        public int? Price { get; set; }
        public int Status { get; set; }             // Customizable status code
        public string? Summary { get; set; }
        public string? IMG { get; set; }
        public DateTime? entry { get; set; }
        public DateTime? checkout { get; set; }
    }
}
