using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression a = new ArithProgression();
           
            for (int i = 0; i < 10; i++)
                Console.Write(" {0}", a.GetNext());
            a.Reset();
            Console.WriteLine();
            GeomProgression g = new GeomProgression();
           
            for (int i = 0; i < 10; i++)
                Console.Write(" {0}", g.GetNext());
            g.Reset();

            Console.ReadKey();
        }
    }
    public interface ISeries
    {
        void SetStart(int x);
        int GetNext();
        void Reset();

    }
    class ArithProgression : ISeries
    {
        int a;
        int an;
        public int d;
        public ArithProgression()
        {
            a = 0;
            an = 0;
            Console.Write("Ведите шаг арифметической прогрессии - ");
            d = Convert.ToInt32(Console.ReadLine());

        }
        public void SetStart(int x)
        {
            a = x;
            an = a;

        }
        public int GetNext()
        {
            return an += d;

        }

        public void Reset()
        {
            an = a;
        }
    }
    class GeomProgression : ISeries
    {
        int g;
        int gn;
        
        public int q;
        public GeomProgression()
        {
            g = 1;
            gn = 0;
           
            Console.Write("Ведите знаминатель геометрической прогрессии - ");
            q = Convert.ToInt32(Console.ReadLine());

        }
        public void SetStart(int x)
        {
            g = x;
            gn=g;


        }
        public int GetNext()
        {
             gn = g * q;
            
            g = gn;
            return gn;

        }

        public void Reset()
        {
            gn = g;
        }

    }
}

