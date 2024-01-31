using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace rettangolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rettangolo rettangolo = new Rettangolo(7,9);
            Rettangolo s=Rettangolo.Parse(rettangolo.ToString());
            Console.WriteLine("il rettangolo ha dati {0}", s);
            Console.ReadLine();

            
        }
    }
}
