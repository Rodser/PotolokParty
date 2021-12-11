using PotolokPartyAPI.Models;

namespace PotolokPartyAPI.Service
{
    public class Repository : IRepository
    {
        private List<string> _news;

        private List<Order> _orderList;

        public Repository()
        {
            InitializeData();
        }

        public IEnumerable<Order> All
        {
            get { return _orderList; }
        }

        public IEnumerable<string> AllNews
        {
            get { return _news; }
        }

        public bool DoesItemExist(int id)
        {
            return _orderList.Any(item => item.Id == id);
        }

        public Order Find(int id)
        {
            return _orderList.FirstOrDefault(item => item.Id == id);
        }

        public void Insert(Order item)
        {
            _orderList.Add(item);
        }

        public void Update(Order item)
        {
            var order = this.Find(item.Id);
            var index = _orderList.IndexOf(order);
            _orderList.RemoveAt(index);
            _orderList.Insert(index, item);
        }

        public void Delete(int id)
        {
            _orderList.Remove(this.Find(id));
        }

        private void InitializeData()
        {
            _news = new List<string> { "Rest API", "News! News! News!", "Today Open", "Add View for News" };
            _orderList = new List<Order>
            {
                new Order
                {
                    Id = 1,
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
                new Order
                {
                    Id = 2,
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
