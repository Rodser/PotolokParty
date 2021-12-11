namespace PotolokParty.Models
{
    /// <summary>
    /// Элемент Потолка
    /// </summary>
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; }
        public string Spending { get; set; }
    }
}
