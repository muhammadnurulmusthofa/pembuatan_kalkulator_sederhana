using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_pbo_2
{
    class Kalkulator : IHitung
    {
        double a, b; 

        public Kalkulator() { }

        public Kalkulator(double a, double b)
        {
            this.A = a;
            this.B = b;
        }

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }

        public double Tambah(double A, double B)
        {
            return A - B;
        }
        public double Kurang(double A, double B)
        {
            return A - B;
        }

    }
}
