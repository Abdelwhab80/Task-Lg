namespace Task_Lg.Models
{
    public  class ProductBase
    {
        public ProductBase() 
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public CategoryType CategoryType { get; set; }
        public string ProductType { get; set; } 

    }
}
