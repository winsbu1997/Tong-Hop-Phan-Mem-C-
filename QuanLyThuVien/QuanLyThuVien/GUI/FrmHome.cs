using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using QuanLyThuVien.DAO;

namespace QuanLyThuVien
{
    public partial class FrmHome : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private fLogin fLg;
        private string tdn;
        public FrmHome(fLogin _flg, string _tdn)
        {
            InitializeComponent();
            tdn = _tdn;
            fLg = _flg;
            DataProvider _dt = new DataProvider();
            DataTable dt = _dt.GetData("select * from ACCOUNT where ACCOUNT.TenDangNhap = '" + tdn + "'");
            string gt = dt.Rows[0]["Quyen"].ToString();
            if (gt == "1")
            {
                ribbonTrangChu.Visible = false;
                ribbonThongKe.Visible = false;
                barBtnQLSach.Enabled = false;
                barBtnQLPM.Enabled = false;
                barBtnQLPT.Enabled = false;
                nBG_QL.Visible = false;
                nBG_TK.Visible = false;
            }
            else
            {
                bar_SachDangMuon.Enabled = false;
                bar_LichSu.Enabled = false;
                nBG_LSMS.Visible = false;
                rbpG_TK.Visible = false;
            }
            //lb_ChayChu.Text = "Phần mềm được\n   thực hiện bởi\nPhạm Ngọc Hải\n        và     \nPhạm Minh Hoàng";
            //lb_ChayChu.Text = "Welcome";
            //lb_ChayChu.Top = 1;
            DevExpress.UserSkins.BonusSkins.Register();
            OfficeSkins.Register();
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(skinRibbonGalleryBarItem1, true);

            panelCha.Controls.Clear();
            ucIntroduce frm = new ucIntroduce();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }
        

        private void barBtnUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            usMemberManagements frm = new usMemberManagements();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

       
        private void barBtnQLSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmQLSach frm = new ucFrmQLSach();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmQLPhieuMuon frm = new ucFrmQLPhieuMuon();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            usMemberManagement frm = new usMemberManagement();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void barBtbDXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            fLg.Show();
        }

        private void fTableManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            fLg.Close();
        }

        private void barBtnTimKiemSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFindBook frm = new ucFindBook();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void barbtnThanhVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucMember frm = new ucMember(tdn);
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void barBtnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucChangePassword frm = new ucChangePassword(tdn);
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }
        private void bar_SachDangMuon_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucBookIsBorrowing frm = new ucBookIsBorrowing(tdn);
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void bar_LichSu_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmSachDaTra frm = new ucFrmSachDaTra(tdn);
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }
        private void barBtnDangMuon_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucBorrowing frm = new ucBorrowing();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void barBtnDaMuon_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucPaid frm = new ucPaid();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }
        private int i = 1;
        private bool ck = true;
       
        private void timer_Tick(object sender, EventArgs e)
        {
            //if (ck == true)
            //    lb_ChayChu.Top += i;
            //else
            //    lb_ChayChu.Top -= i;
            //if (lb_ChayChu.Top > 400 || lb_ChayChu.Top <= 0)
            //    ck = !ck;


        }

        private void nBI_TTCN_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelCha.Controls.Clear();
            ucMember frm = new ucMember(tdn);
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void nBI_DMK_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelCha.Controls.Clear();
            ucChangePassword frm = new ucChangePassword(tdn);
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void nBI_SDM_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelCha.Controls.Clear();
            ucBookIsBorrowing frm = new ucBookIsBorrowing(tdn);
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void nBI_SDT_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmSachDaTra frm = new ucFrmSachDaTra(tdn);
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void nBI_QLTV_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelCha.Controls.Clear();
            usMemberManagements frm = new usMemberManagements();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void nBI_QLS_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmQLSach frm = new ucFrmQLSach();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void nBI_QLPM_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmQLPhieuMuon frm = new ucFrmQLPhieuMuon();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void nBI_QLPT_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelCha.Controls.Clear();
            usMemberManagement frm = new usMemberManagement();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void nBI_TKDM_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelCha.Controls.Clear();
            ucBorrowing frm = new ucBorrowing();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void nBI_TKDT_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelCha.Controls.Clear();
            ucPaid frm = new ucPaid();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void barbtn_About_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucIntroduce frm = new ucIntroduce();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void barBtnHDSD_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucGuidelines frm = new ucGuidelines();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void fTableManage_Load(object sender, EventArgs e)
        {
            barTextHello.Caption = "Xin Chào " + tdn;
        }

      
        

      

        

        

       

        

        

        


    }
}
