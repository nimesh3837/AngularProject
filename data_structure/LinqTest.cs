using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public long Salary { get; set; }

        public int Age { get; set; }

        public string Department { get; set; }
    }

    public class LinqTest
    {
        public static void Test()
        {

            var list = new List<Customer>(){
            new Customer()
                    {
                        Id = 100,
                        Age = 30,
                        Name = "Dipak",
                        Salary = 30000,
                        Department = "A"

                    },
            new Customer()
                    {
                        Id = 101,
                        Age = 35,
                        Name = "Palash",
                        Salary = 40000,
                        Department = "B"

                    },
            new Customer()
                    {
                        Id = 103,
                        Age = 40,
                        Name = "Den",
                        Salary = 50000,
                        Department = "A"

                    }
            };
            var maxsalary = list.Where(x => x.Salary == 50000).ToList();
            var maxsalar = list.Max(x => x.Salary);
            var minsal = list.Min(x => x.Salary);
            var orderSalary = list.OrderBy(x=>x.Salary).ToList();
            list.ForEach(x =>
            {
                x.Salary = 100000;
            });
           var groupbytest= list.GroupBy(x=>x.Department).ToList();
            var maxSalary = list.Max(o => o.Salary);
            Console.WriteLine("Max Salary :" + maxSalary);
            var minSalary = list.Min(o => o.Salary);
            Console.WriteLine("Min Salary :" + minSalary);

            var OrderSalary = list.OrderBy(o=>o.Salary).ToList();
            OrderSalary.ForEach(o => Console.WriteLine("Order :" + o.Salary));

            list.GroupBy(o => o.Department).ToList().ForEach(o=> {

                o.ToList().ForEach(m => Console.WriteLine("Dept :" + m.Department));

            });


        }
    }
}
