using System.Collections.Generic;

namespace PotolokParty.Models
{
    /// <summary>
    /// Заявка
    /// </summary>
    internal class Application
    {
        public int Id { get; set; }
        public Address Address {  get; set; }
        public Client Client { get; set; }
        public string Date { get; set; }
        public decimal Amount { get; set; }
        public List<Ceiling> Ceilings { get; set; }
        public Status Status { get; set; }
    }
}
