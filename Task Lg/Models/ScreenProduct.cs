namespace Task_Lg.Models
{
    public class ScreenProduct : ProductBase
    {
        public ScreenProduct() : base()
        {
            ProductType = "Screen";
        }
        public string Color { get; set; }
        public string Quality { get; set; }
        public string Size { get; set; }
    }

}
