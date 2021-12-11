using System.Collections.Generic;

namespace PotolokPartyAPI.Models
{
    /// <summary>
    /// Заказчик
    /// </summary>
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pnone { get; set; }
        public double Discont { get; set; }
        public List<Order> Applications { get; set; }
    }
}
