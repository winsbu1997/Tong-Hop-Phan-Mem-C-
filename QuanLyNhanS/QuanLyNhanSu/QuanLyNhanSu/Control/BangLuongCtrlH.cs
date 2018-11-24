using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanSu.Model;
using System.Data;

namespace QuanLyNhanSu.Control
{
    class BangLuongCtrlH
    {
        BangLuongModH bang = new BangLuongModH();
        public DataTable GetData(string s)
        {
            return bang.GetData(s);
        }
        public bool ThucHienLenh(string s)
        {
            return bang.ThucHienLenh(s);
        }
    }
}
