using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tinh{
    class metvl
    {
        static void Main(string[] args)
        {
             Double  sum = 0.0;
         int i;
         int n;
        public void nhap(){
            
            Console.WriteLine("Nhap n:");
            this.n = Convert.ToInt32(Console.ReadLine());
        }
        public double sumtong(){
            for (i = 1; i <= n; i++)
                if (i % 2 == 0)
                    sum -= i;
                else
                    sum += i;
            return sum;
        }
        public void intong(){
            Console.WriteLine("tong so sum {0}:", this.sumtong());
        }
        }
}
}
