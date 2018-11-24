using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaHang.Controller
{
    class NhomMonCtr
    {
        public static int btnHeight = 80;
        public static int btnWidth = 160;
        
        public static int InsertNhomMon(string _MaNM,string _TenNM)
        {
            try
            {
                Model.NhomMonMod nm = new Model.NhomMonMod(_MaNM,_TenNM);
                return nm.InsertNhomMon();
            }
            catch { return 0; }
        }
        public static int UpdateNhomMon(string _MaNM,string _TenNM)
        {
            try
            {
                Model.NhomMonMod nm = new Model.NhomMonMod(_MaNM,_TenNM);
                return nm.UpdateNhomMon();
            }
            catch { return 0; }
        }
        public static int DeleteNhomMon(string _MaNM)
        {
            try
            {
                Model.NhomMonMod nm = new Model.NhomMonMod(_MaNM);
                return nm.DeleteNhomMon();
            }
            catch { return 0; }
        }
        public static DataSet SearchNhomMonByMaNM(string _MaNM)
        {
            try
            {
                Model.NhomMonMod nm = new Model.NhomMonMod(_MaNM);
                return nm.SearchNhomMonByMaNM();
                
            }
            catch
            {
                return null;
            }
        }
        public static List<Model.NhomMonMod> DanhSachNhomMon()
        {
            List<Model.NhomMonMod> listNM = new List<Model.NhomMonMod>();
            DataTable dt = Model.NhomMonMod.FillDataSetNhomMon().Tables[0];
            foreach(DataRow item in dt.Rows)
            {
                Model.NhomMonMod groupFood = new Model.NhomMonMod(item);
                listNM.Add(groupFood);
            }
            return listNM;
        }
        
    }
}
