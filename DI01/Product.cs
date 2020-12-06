namespace DI01
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return $"{Name} -- {Description}";
        }
    }
}