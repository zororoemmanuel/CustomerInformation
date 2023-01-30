using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer(){Id = 1, Name = "Zororo", DateOfBirth = new DateTime(1988,01,14),Gender ="M"},
                new Customer(){Id = 1, Name = "Edson", DateOfBirth = new DateTime(1982,10,10), Gender = "M"},
                new Customer(){Id = 1, Name = "Peter", DateOfBirth = new DateTime(1987,02,07), Gender = "F"},
                new Customer(){Id = 1, Name = "Marry", DateOfBirth = new DateTime(1990,07,25), Gender = "F"},
                new Customer(){Id = 1, Name = "Basi", DateOfBirth = new DateTime(2000,02,19), Gender = "M"},
                new Customer(){Id = 1, Name = "Joice", DateOfBirth = new DateTime(1997,12,01), Gender = "M"},
            };

             int overal_Average = ComputeAverageAge(customers);

            Console.WriteLine("Overal Customer Average Age: " + overal_Average);

            var males = customers.Where(c => c.Gender == "M").ToList();

            int average_age_M = ComputeAverageAge(males);

            Console.WriteLine("Male Customers Average Age: " + average_age_M);

            var females = customers.Where(c => c.Gender == "F").ToList();

            int average_age_F = ComputeAverageAge(females);

            Console.WriteLine("Female Customers Average Age: " + average_age_F);

            Console.Read();
        }

        private static int ComputeAverageAge(List<Customer> customers)
        {
            int sumages = 0; 

            if(customers != null)
            {
                foreach (var cust in customers)
                {

                        int yrs = GetYears(cust.DateOfBirth);
                        sumages = sumages + yrs;                   

                }

                if (sumages > 0)
                {
                    return sumages / customers.Count();
                }
                else
                    return 0;               
            }
            else
            {
                return 0;
            }

        }

        public static int GetYears(DateTime dob)
        {
            int age = 0;
            age = DateTime.Now.Year - dob.Year;
            return age;
        }
    }
}
