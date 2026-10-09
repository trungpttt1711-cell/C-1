using System;
using System.Collections.Generic;
using System.Text;
namespace ExampleCAdvance.Hinh
{
    public abstract class Hinh
    {
        public abstract double TinhDienTich();
        public abstract double TinhChuVi();
    }
    public class Hinhtron : Hinh
    {
        private double bankinh;
        public double BanKinh
        {
            get { return bankinh; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ban kinh hinh tron ko dc am");
                }
                bankinh = value;
            }
        }
        public Hinhtron(double bankinh)
        {
            BanKinh = bankinh;
        }
        public override double TinhDienTich()
        {
            return Math.PI * BanKinh * BanKinh;
        }
        public override double TinhChuVi()
        {
            return 2 * Math.PI * BanKinh;
        }
    }
}
