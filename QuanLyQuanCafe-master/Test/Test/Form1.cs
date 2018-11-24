using DevExpress.XtraSpreadsheet.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
            workbook.Unit = DevExpress.Office.DocumentUnit.Millimeter;
            workbook.LoadDocument("F:/Grid.xls");
            //workbook.Worksheets.ActiveWorksheet.DefaultRowHeight = 20;
            //workbook.Worksheets.ActiveWorksheet.DefaultColumnWidth = 20;

            //workbook.BeginUpdate();
            /*try
            {
                Worksheet worksheet = workbook.Worksheets[0];
                // Insert pictures.
                Picture pic = worksheet.Pictures.AddPicture("Pictures\\x-spreadsheet.png", worksheet.Cells["A1"]);
                worksheet.Pictures.AddPicture("Pictures\\x-spreadsheet.png", worksheet.Cells["A1"]);
                // Specify picture name.
                pic.Name = "Logo";
                pic.AlternativeText = "Spreadsheet logo";
                // Move a picture.
                pic.Move(30, 50);
                // Move and size the picture with underlying cells. 
                pic.Placement = Placement.MoveAndSize;
                worksheet.Rows[1].Height += 20;
                worksheet.Columns["D"].Width += 20;
                // Move another picture to illustrate OffsetX, OffsetY properties.
                worksheet.Pictures[1].Move(pic.OffsetY, pic.OffsetX);
            }
            finally
            {
                workbook.EndUpdate();
            }*/
        }

    }
}
