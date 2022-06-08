using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HomeStayManagement.Model
{
    public class Bill
    {
        [Key, DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int? ID { get; set; }
        public String? Customer { get; set; }
        public int? PhoneNumber { get; set; }
        public Homestay[]? reserved { get; set; }
        public int? TotalCost { get; set; }
    }
}
