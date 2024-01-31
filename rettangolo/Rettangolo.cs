using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rettangolo
{
    internal class Rettangolo
    {
        public Rettangolo() { }

        public Rettangolo(double l1, double l2)
        {
            this.l1 = l1;
            this.l2 = l2;
        }

        public double l1 {  get; set; }
        public double l2 { get; set; }
        public static Rettangolo Parse(string s)
        {
            Rettangolo rettangolo = new Rettangolo(0,0);
            rettangolo.l1 = double.Parse(s.Substring(0,1));
            rettangolo.l2= double.Parse(s.Substring(2,1));
            return rettangolo;
        }
        public override string ToString()
        {
            return string.Format("{0},{1}",l1,l2);
        }
        public double Area()
        {
            return l1 * l2;
        }
    }
}
