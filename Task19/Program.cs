using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Comp
{
    public int Code { get; set; }
    public string Mark { get; set; }
    public string Proc { get; set; }
    public int Freq { get; set; }
    public int MemV { get; set; }
    public int HardV { get; set; }
    public int GPUV { get; set; }
    public int Price { get; set; }
    public int Count { get; set; }


}
namespace Task19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Comp> listComp = new List<Comp>()
            {
            new Comp() { Code = 1, Mark = "ASUS", Proc = "Intel", Freq = 3300, MemV = 16, HardV = 512, GPUV = 4, Price = 90000, Count = 3 },
            new Comp() { Code = 2, Mark = "HP", Proc = "Intel", Freq = 2900, MemV = 16, HardV = 512, GPUV = 2, Price = 70000, Count = 2 },
            new Comp() { Code = 3, Mark = "MSI", Proc = "Intel", Freq = 3900, MemV = 32, HardV = 2048, GPUV = 12, Price = 260000, Count = 1 },
            new Comp() { Code = 4, Mark = "ASUS", Proc = "AMD", Freq = 2500, MemV = 8, HardV = 256, GPUV = 2, Price = 50000, Count = 35 },
            new Comp() { Code = 5, Mark = "MSI", Proc = "AMD", Freq = 3000, MemV = 16, HardV = 512, GPUV = 8, Price = 200000, Count = 3 },
            new Comp() { Code = 6, Mark = "HP", Proc = "AMD", Freq = 2600, MemV = 8, HardV = 512, GPUV = 4, Price = 130000, Count = 14 },
            new Comp() { Code = 7, Mark = "ASUS", Proc = "Intel", Freq = 3100, MemV = 32, HardV = 1024, GPUV = 8, Price = 180000, Count = 6 },
            new Comp() { Code = 8, Mark = "iRU", Proc = "Intel", Freq = 2500, MemV = 8, HardV = 512, GPUV = 4, Price = 60000, Count = 24 },
            new Comp() { Code = 9, Mark = "iRU", Proc = "Intel", Freq = 2500, MemV = 8, HardV = 1024, GPUV = 4, Price = 70000, Count = 12 },
            new Comp() { Code = 10, Mark = "iRU", Proc = "Intel", Freq = 2500, MemV = 8, HardV = 1024, GPUV = 8, Price = 90000, Count = 8 },
            };

            Console.WriteLine("Введите название процессора");
            string pn = Console.ReadLine();
            List<Comp> proc = (from c in listComp
                               where c.Proc == pn
                               select c).ToList();
            foreach (Comp c in proc)
                Console.WriteLine($"{c.Code} {c.Mark} {c.Freq} {c.MemV} {c.HardV} {c.GPUV} {c.Price} {c.Count}");

            Console.WriteLine("Введите объем ОЗУ");

            int memv = Convert.ToInt32(Console.ReadLine());
            List<Comp> mem = (from c in listComp
                              where c.MemV >= memv
                              select c).ToList();
            foreach (Comp c in mem)
                Console.WriteLine($"{c.Code} {c.Mark} {c.Proc} {c.Freq} {c.HardV} {c.GPUV} {c.Price} {c.Count}");
            Console.WriteLine();

            List<Comp> sort = (from c in listComp
                               orderby c.Price
                               select c).ToList();
            foreach (Comp c in sort)
                Console.WriteLine($"{c.Code} {c.Mark} {c.Proc} {c.Freq} {c.MemV} {c.HardV} {c.GPUV} {c.Price} {c.Count}");
            Console.WriteLine();

            List<string> group = listComp
                .Select(c => c.Proc)
                .Distinct()
                .ToList();
            foreach (string c in group)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();

            Console.WriteLine("Самый дешевый компьютер:");
            Comp cheap = sort
                .First();
            Console.WriteLine($"{cheap.Code} {cheap.Mark} {cheap.Proc} {cheap.Freq} {cheap.MemV} {cheap.HardV} {cheap.GPUV} {cheap.Price} {cheap.Count}");
            Console.WriteLine();

            Console.WriteLine("Самый дорогой компьютер:");
            Comp exp = sort
                .Last();
            Console.WriteLine($"{exp.Code} {exp.Mark} {exp.Proc} {exp.Freq} {exp.MemV} {exp.HardV} {exp.GPUV} {exp.Price} {exp.Count}");
            Console.WriteLine();

            Console.WriteLine("Не менее 30 штук:");
            List<Comp> count = (from c in listComp
                                where c.Count >= 30
                                select c).ToList();
            foreach (Comp c in count)
                Console.WriteLine($"{c.Code} {c.Mark} {c.Proc} {c.Freq} {c.HardV} {c.GPUV} {c.Price} {c.Count}");

            Console.ReadKey();
        }
    }
}
