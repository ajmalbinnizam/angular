using System;
using Newtonsoft.Json;
using Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account
            {
                Email = "james@example.com",
                Active = true,
                CreatedDate = new DateTime(2013, 1, 20, 0, 0, 0, DateTimeKind.Utc),
                Roles = new List<details>
                {
                    new details{ name = "aju", number = 23412},
                    new details{ name = "niz", number = 234123}
                }
            };
            // string json = JsonConvert.SerializeObject(account, Formatting.Indented); Console.WriteLine(json);
            Guitars guitars = new Guitars
            {
                brands = new List<string> { "ibanez", "gibson" },
             
            };

            string serialized = JsonConvert.SerializeObject(guitars, Formatting.Indented);
            Console.WriteLine(serialized);


        }
    }

    public class Guitars
    {
        public List<string> brands { get; set; }
        private int no { get; set; }
    }
    public class Account
    {
        public string? Email { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<details> Roles { get; set; }
    }

    public class details
    {
        public string name { get; set; }
        public int number { get; set; }
    }

}
