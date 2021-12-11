using System.Collections.Generic;
using System.Drawing;

namespace PotolokParty.Models
{
    /// <summary>
    /// Потолок
    /// </summary>
    public class Ceiling
    {
        public int id { get; set; }
        public double Square { get; set; }
        public double Perimeter { get; set; }
        public decimal Amount { get; set; }
        public List<Item> Items { get; set; }
        public List<Point> Points { get; set; }
    }
}
