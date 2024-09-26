namespace Task_Lg.Models
{
    public class RouterProduct : ProductBase
    {
        public RouterProduct() : base() 
        {
            ProductType = "Router";
        }
        public string Model { get; set; }
        public string ip { get; set; }
        public string Speed { get; set; }
        public int NumberOfPorts { get; set; }


    }

}
