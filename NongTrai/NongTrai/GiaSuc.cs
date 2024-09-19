using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongTrai
{
    abstract class GiaSuc
    {
        public int SoLuong {  get; set; }
        public abstract string TiengKeu();
        public abstract int SinhCon();
        public abstract int ChoSua();
    }

    class Bo : GiaSuc
    {
        public override int ChoSua()
        {
            return new Random().Next(0, 21);
        }

        public override int SinhCon()
        {
            return new Random().Next(1, 3);
        }

        public override string TiengKeu()
        {
            return "Bò: Ò...Ò...";
        }
    }

    class Cuu : GiaSuc
    {
        public override int ChoSua()
        {
            return new Random().Next(0, 6);
        }

        public override int SinhCon()
        {
            return new Random().Next(1, 3);
        }

        public override string TiengKeu()
        {
            return "Cừu: Bê... Bê...";
        }
    }

    class De : GiaSuc
    {
        public override int ChoSua()
        {
            return new Random().Next(0, 11);
        }

        public override int SinhCon()
        {
            return new Random().Next(1, 3);
        }

        public override string TiengKeu()
        {
            return "Dê: E... E...";
        }
    }
}
