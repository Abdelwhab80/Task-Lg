using System.ComponentModel.DataAnnotations;

namespace Task_Lg.Models
{
    public class LabtopProduct : ProductBase
    {
        public LabtopProduct() : base() 
        {
            ProductType = "Labtop";
        }
        [Required]

        public string Model { get; set; }
        public string Type { get; set; }
        public string Ram { get; set; }
        public string Prossecor { get; set; }


    }
}
