using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>()
            {
                new Computer(){Code=1, Brand="ACER", ProcessorType="Intel Core i7",ProcessorFrequency=2.5,RAMSize=16,HDSize=256,VideoSize=8,Cost=150,Count=30 },
                new Computer(){Code=2, Brand="ACER", ProcessorType="AMD Ryzen 3",ProcessorFrequency=3,RAMSize=8,HDSize=1000,VideoSize=4,Cost=50,Count=10 },
                new Computer(){Code=3, Brand="LENOVO", ProcessorType="AMD Ryzen 7",ProcessorFrequency=3.8,RAMSize=8,HDSize=512,VideoSize=4,Cost=75,Count=60 },
                new Computer(){Code=4, Brand="MSI", ProcessorType="ntel Core i5",ProcessorFrequency=2.5,RAMSize=32,HDSize=1000,VideoSize=8,Cost=110,Count=12 },
                new Computer(){Code=5, Brand="MSI", ProcessorType="Intel Pentium Gold G6405",ProcessorFrequency=4.1,RAMSize=4,HDSize=100,VideoSize=2,Cost=20,Count=10 },
                new Computer(){Code=6, Brand="APPLE", ProcessorType="Apple M1 Max 10 core",ProcessorFrequency=4,RAMSize=32,HDSize=512,VideoSize=32,Cost=300,Count=100 },
                
            };
            Console.WriteLine("Введите тип процессора:");
            string  processorType = Console.ReadLine();
            List<Computer> computers1 = computers.Where(x => x.ProcessorType == processorType).ToList();
            Print(computers1);

            Console.WriteLine("Введите ОЗУ:");
            int sizeRAM = Convert.ToInt32(Console.ReadLine());
            List<Computer> computers2 = computers.Where(x => x.RAMSize >= sizeRAM).ToList();
            Print(computers2);

            Console.WriteLine("список, отсортированный по увеличению стоимости");
            List<Computer> computers3 = computers.OrderBy(x => x.Cost).ToList();
            Print(computers3);

            Console.WriteLine("список, сгруппированный по типу процессора");
            IEnumerable<IGrouping<string, Computer>> computers4 = computers.GroupBy(x => x.ProcessorType);
            foreach (IGrouping<string, Computer> gr in computers4)
            {
                Console.WriteLine(gr.Key);
                foreach (Computer e in gr)
                {
                    Console.WriteLine($"{e.Code} {e.Brand} {e.ProcessorType} {e.ProcessorFrequency}Ггц {e.RAMSize}Гб {e.HDSize}Гб {e.VideoSize}Гб {e.Cost}тыс.руб. {e.Count}шт");
                }
            }
           
            Computer min = computers.OrderBy(x=>x.Cost).First();
            Computer max = computers.OrderBy(x => x.Cost).Last();
            Console.WriteLine($"самый дорогой - {max.Code} {max.Brand} {max.ProcessorType} {max.ProcessorFrequency}Ггц {max.RAMSize}Гб {max.HDSize}Гб {max.VideoSize}Гб {max.Cost}тыс.руб. {max.Count}шт и самый бюджетный компьютер - {min.Code} {min.Brand} {min.ProcessorType} {min.ProcessorFrequency}Ггц {min.RAMSize}Гб {min.HDSize}Гб {min.VideoSize}Гб {min.Cost}тыс.руб. {min.Count}шт");


            Console.WriteLine("есть ли хотя бы один компьютер в количестве не менее 30 штук?");
            Console.WriteLine(computers.Any(x => x.Count > 20));

            Console.ReadKey();
           
        }
        static void Print(List<Computer> computers)
        {
            foreach (Computer e in computers)
            {
                Console.WriteLine($"{e.Code} {e.Brand} {e.ProcessorType} {e.ProcessorFrequency}Ггц {e.RAMSize}Гб {e.HDSize}Гб {e.VideoSize}Гб {e.Cost}тыс.руб. {e.Count}шт");
            }
            Console.WriteLine();
        }
    }

}
