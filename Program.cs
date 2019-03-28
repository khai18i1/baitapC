using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sach
{
    class Program
    {
        static void Main(string[] args)
        {
            SachGiaoKhoa xd = new SachGiaoKhoa();
            xd.nhap();
            xd.In();
            xd.tinhtien();
            Console.ReadLine();
        }
    }
}
