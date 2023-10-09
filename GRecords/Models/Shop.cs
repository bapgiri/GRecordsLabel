using GRecords.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace GRecords.Models
{
    public class Shop
    {
        [Key]
        public int Id { get; set; }
  
        public string ItemName { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public string ItemPicture { get; set; }

        public DateTime StartDate  { get; set; }

        public DateTime EndDate { get; set; }

        public ShopCategory ShopCategory { get; set; }
    }
}
