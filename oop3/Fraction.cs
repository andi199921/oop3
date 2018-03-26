using System;

namespace oop3
{
    class FractionWork
    {
        int m, n, Nod, p, Q;
        public int Enter()
        {
            Console.WriteLine("Введите первый числитель");
            m = int.Parse(Console.ReadLine());
            return m;
            Console.WriteLine("Введите первый знаменатель");
            n = int.Parse(Console.ReadLine());
            return n;
            Console.WriteLine("Введите второй числитель");
            p = int.Parse(Console.ReadLine());
            return p;
            Console.WriteLine("Введите второй знаменатель");
            Q = int.Parse(Console.ReadLine());
            return Q;
            
        }

        public int Reduction()
        {
            Enter();
            n = int.Parse(Console.ReadLine());
            while (Math.Abs(m)!=Math.Abs(n))
            {
                if (m>n)
                {
                    m -= n;
                }
                else n -= m;
            }
            Nod = m;
            return m;

        }
        public void Spar()
        {
            int a = p;
            int b = Q;
            p = p / Reduction();
            Q = Q / Reduction();
            Console.WriteLine("Исходная дробь {0}/{1}, сокращённая {2}/{3}",a,b,p,Q);
        }
        public int Multiplication()
        {
            Enter();
            int a = m * p;
            int b = n * Q;
            Console.WriteLine("Дробь {0}/{1} умножим на {2}/{3} равна {4}/{5}", m,n,p,Q,a,b);
            return a / b;
        }
        public int Division()
        {
            Enter();
            int a = m * Q;
            int b = n * p;
            Console.WriteLine("Дробь {0}/{1} разделим на {2}/{3} равна {4}/{5}", m, n, p, Q, a, b);
            return a / b;
        }
    }
}
