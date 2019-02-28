using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace thongtin
{
    class doantau
    {
        String MaDT;
        int SLkhach;
    }
    public void nhaptt(){
    Console.Writeline("Nhap MaDT:");
    this.MaDT = Console.Readline();
    Console.Writeline("Nhap so luong khach:");
    this.SLkhach=convert.ToInt32(Console.Readline());
}
 public int tongtien(){ 
    int tt;
    if (this.SLkhach<100)
    tt=(this.SLkhach*100000);
    else
    tt =(this.SLkhach*80000);
    return tt;
}
    public void intong(){
    Console.Writeline("Ma DT {0} va tongtien{1}",this.MaDT,this.tongtien);
}
}
