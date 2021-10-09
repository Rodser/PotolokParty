using PotolokParty.Models;
using System.Collections.Generic;

namespace PotolokParty.ViewModels
{
    internal class ApplicationViewModel
    {
        public Application Application { get; set; }
        public Address Address { get; set; }
        public List<Ceiling> Ceilings { get; set; }


        public ApplicationViewModel()
        {
            Application = App.repository.Applications[0];
            Address = Application.Address;
            Ceilings = Application.Ceilings;
        }
    }
}
