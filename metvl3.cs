using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tinh
{
    class metvl3
    {
        int i, n, sum;
        public void nhap(){
        Console.Writeline("Nhap n:");
        this.n=Convert.ToInt32(Console.Readline());
    }
    public void tong(){
        for (i = 1; i <= n; i++) sum = sum + i;
        return sum;
}
    public void xuat()
    {
        Console.WriteLine("Tong sum{1}:", this.tong);
    }
    }
}
