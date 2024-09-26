namespace Task_Lg.Models
{
    public class PrinterProduct : ProductBase
    {
        public PrinterProduct() : base() 
        {
            ProductType = "Printer";
        }
        public string Model { get; set; }
        public string ip { get; set; }
        public string Brand { get; set; }
    }

}
