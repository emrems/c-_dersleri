using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_ifadelerin_interface_ile_kullnimi
{
    public class Program
    {
        static void Main(string[] args)
        {
            Repository<User> repos1 = new Repository<User>();
            Repository<Dealer> repos2 = new Repository<Dealer>();

            User user1 = new User
            {
                UserName = "suna",
                Password = "53233"
            };

            User user2 = new User
            {
                UserName = "emre",
                Password = "232323"
            };


            Dealer dealer1 = new Dealer
            {
                DealerName = "vodafone"
            };

            Dealer dealer2 = new Dealer
            {
                DealerName = "turkcell"
            };


            repos1.Add(user1);
            repos1.Add(user2);

            repos2.Add(dealer1);
            repos2.Add(dealer2);


            foreach(var item  in repos1.GetAll())
            {
                Console.WriteLine(item.UserName);
                Console.WriteLine(item.Password);
            }

            foreach(var item in repos2.GetAll())
            {
                Console.WriteLine(item.DealerName);
            }


            
        }

    }

    class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    class Dealer
    {
        public string DealerName { get; set; }
    }

    interface IRepository<T>
    {
        void Add(T item);
        IEnumerable<T> GetAll();
    }

   

    class Repository<T> : IRepository<T>
    {
        private List<T> items = new List<T>();
        public void Add(T item)
        {
            items.Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            return items;
        }
    }

   

}
