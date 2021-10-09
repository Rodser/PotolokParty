using PotolokParty.Models;
using System.Collections.Generic;

namespace PotolokParty.Service
{
    internal class RepositoryAlpha
    {
        public IList<Application> Applications { get; }
        public IList<string> News { get; set; }

        public RepositoryAlpha()
        {
            News = new List<string> { "News! News! News!", "Today Open", "Add View for News"};
            Applications = new List<Application>
            {
                new Application
                {
                    Client = new Client
                    {
                        Name = "Vasia",
                        Discont = 5.0,
                        Pnone = "+79370702223"
                    },
                    Amount = 30600,
                    Date = "12.12.21",
                    Status = Status.active,
                    Address = new Address 
                    {
                        City = "Kuibeshev",
                        Street = "ulica",
                        House = 99,
                        Apartment = 4
                    },
                    Ceilings = new List<Ceiling> 
                    {
                        new Ceiling { Amount = 6000, Square = 20, Perimeter = 55 },
                        new Ceiling { Amount = 5000, Square = 14, Perimeter = 26 },
                        new Ceiling { Amount = 12000, Square = 34, Perimeter = 86 }
                    }
                },
                new Application
                {
                    Client = new Client
                    {
                        Name = "Petiy",
                        Discont = 8.0,
                        Pnone = "+79370702121"
                    },
                    Amount = 55500,
                    Date = "21.12.21",
                    Status = Status.processing,
                    Address = new Address
                    {
                        City = "gorod",
                        Street = "ulica2",
                        House = 7,
                        Apartment = 14
                    },
                    Ceilings = new List<Ceiling>
                    {
                        new Ceiling { Amount = 16000, Square = 20, Perimeter = 55 },
                        new Ceiling { Amount = 15000, Square = 14, Perimeter = 26 },
                        new Ceiling { Amount = 22000, Square = 34, Perimeter = 86 }
                    }
                },
            };
        }
    }
}
