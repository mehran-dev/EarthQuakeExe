using System;
using System.Drawing;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;



namespace ErthQuakeIn2800
{







    public partial class frmExp : Form
    {

        bool proccessing = false;



        public frmExp()
        {
            InitializeComponent();
        }

        public frmExp(double[] Calculating, string[] Enterance)


        {
            InitializeComponent();

        }






        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {



        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void exCrystal_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void exCrystal_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("CrystalReport is Not Available \nUse Excel Export Instead \nIts More Beautiful And Profesional", "در دسترس نیست", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            MessageBox.Show("از خروجی اکسل استفاده کنید ");


        }

        private void frmExp_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.IsDarkMood)
            {
                this.BackColor = Properties.Settings.Default.DarkColor;
                btnExit.BackColor = Properties.Settings.Default.DarkColor;
                label3.ForeColor = Color.White;
                btnExit.ForeColor = Color.White;
                lblColor.BackColor = lblColor2.BackColor = lblColor3.BackColor = Color.White;

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exXlsx_Click(object sender, EventArgs e)
        {

            if (proccessing) return;
            proccessing = true;
            epplus();
            proccessing = false;
        }



























        private void epplus()
        {

            string f1, f2;
            FileDialog fd;

            if (Properties.Settings.Default.isDefPath)
            {

                var desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

                bool weFound = false;
                int i = 1;

                string a = desktopFolder + @"\ErthQuakeReport\ErthQuake2800.xlsx";

                if (File.Exists(a))
                {
                    weFound = true;
                    while (File.Exists(desktopFolder + @"\ErthQuakeReport\ErthQuake2800(" + i.ToString() + ").xlsx"))
                    {
                        i++;
                    }


                }



                if (weFound)
                {
                    f1 = Path.Combine(desktopFolder, @"ErthQuakeReport\ErthQuake2800(" + i.ToString() + ").xlsx");

                }
                else
                {
                    f1 = Path.Combine(desktopFolder, @"ErthQuakeReport\ErthQuake2800.xlsx");
                }

                f2 = Path.Combine(desktopFolder, @"ErthQuakeReport");

                if (!Directory.Exists(f2)) Directory.CreateDirectory(f2);
            }
            else
            {
                fd = new SaveFileDialog();
                fd.AddExtension = false;
                fd.AutoUpgradeEnabled = true;
                fd.FileName = "ErthQuake2800.xlsx";
                fd.Title = "Save Excel Format(*.xlax)";
                fd.Filter = "ExcelFile|*.xlsx";



                fd.ShowDialog();

                f1 = fd.FileName;

            }





            FileInfo finfo = new FileInfo(f1);


            //Environment.SpecialFolder.DesktopDirectory+@"\ErthQueck2800.xlsx"); 
            // FileInfo f2 = new FileInfo(@"C:\");


            bool isExcelInstalled = Type.GetTypeFromProgID("Excel.Application") != null ? true : false;

            if (!isExcelInstalled)
            {
                MessageBox.Show("نرم افزار اکسل برروی سیستم شما نصب نشده است ");

                return;
            }
            try
            {
                using (ExcelPackage exl = new ExcelPackage())
                {

                    exl.Workbook.Worksheets.Add("Earthquake coefficient");
                    exl.Workbook.Worksheets.Add("Contact_Us");
                    //  exl.Workbook.Worksheets.Add("هذا پیج الثالث");

                    var ws = exl.Workbook.Worksheets["Earthquake coefficient"];




                  


                    ws.Cells["A2"].Value = "خطر نسبی زلزله";
                    ws.Cells["B2"].Value = Global.KhatarNesbi;

                    ws.Cells["A3"].Value = "تیپ خاک";
                    ws.Cells["B3"].Value = Global.TipKhak;

                    ws.Cells["A4"].Value = "درجه اهمیت سازه";
                    ws.Cells["B4"].Value = Global.DrajeAhammeyatSaze;

                    ws.Cells["A5"].Value = "ارتفاع محاسباتی";
                    ws.Cells["B5"].Value = Global.ErtefaSaze;

                    ws.Cells["A5"].Value = "سیستم مهاربند در جهت" + "x";
                    ws.Cells["B5"].Value = Global.MaharBandX;

                    ws.Cells["A6"].Value = "سیستم مهار بند در جهت" + "y";
                    ws.Cells["B6"].Value = Global.MaharBandY;

                    ws.Cells["A7"].Value = "سیستم مقاوم در جهت" + "x";
                    ws.Cells["B7"].Value = Global.MoghavemX1 + " " + Global.MoghavemX2;

                    ws.Cells["A8"].Value = "سیستم مقاوم در جهت" + "y";
                    ws.Cells["B8"].Value = Global.MoghavemY1 + " " + Global.MoghavemY2;


                    ws.Cells["A9"].Value = "T Dynamic";
                    ws.Cells["B9"].Value = Global.TDynamicy;


                    ws.Cells["A10"].Value = "جداگر میانقابی";
                    ws.Cells["B10"].Value = Global.AyyaMianghabMoneAst;

                    ws.Cells["A11"].Value = "نوع سازه";
                    ws.Cells["B11"].Value = Global.AyyaSazeMotearef;




                    ws.Cells["A1:B11"].Style.Font.Bold = true;
                    ws.Cells["A1:B11"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;



                    /////////////   ws.Cells["B:B"].AutoFitColumns();
                    ws.Column(2).AutoFit();
                

                    
                    ws.Cells["A1:B1"].Merge = true;
                    ws.Cells["A1:B1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    ws.Cells["A1"].Value = "اطلاعات ورودی توسط کاربر";
                    ws.Cells["A1:B1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    ws.Cells["A1:B1"].Style.Fill.BackgroundColor.SetColor(Color.Yellow);
                    ws.Cells["A2:B16"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    ws.Cells["A2:B16"].Style.Fill.BackgroundColor.SetColor(Color.DeepSkyBlue);
                    ws.Cells["A2:B16"].Style.Font.Color.SetColor(Color.WhiteSmoke);



                    //////////////////////////////////////////////////////////////////////////


                    ws.Cells["E1:F1"].Merge = true;
                    ws.Cells["E1:F1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    ws.Cells["E1"].Value = "محاسبات انجام شده";

                    ws.Cells["E1:F1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    ws.Cells["E1:F1"].Style.Fill.BackgroundColor.SetColor(Color.Yellow);




                    ws.Cells["E2:F13"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    ws.Cells["E2:F13"].Style.Fill.BackgroundColor.SetColor(Color.LightSkyBlue);


                    ws.Cells["E2"].Value = "A";
                    ws.Cells["F2"].Value = Global.A;

                    ws.Cells["E3"].Value = "I";
                    ws.Cells["F3"].Value = Global.I;

                    ws.Cells["E4"].Value = "Rx";
                    ws.Cells["F4"].Value = Global.Rx;

                    ws.Cells["E5"].Value = "Ry";
                    ws.Cells["F5"].Value = Global.Ry;


                    ws.Cells["E6"].Value = "T0";
                    ws.Cells["F6"].Value = Global.T0;



                    ws.Cells["E7"].Value = "Ts";
                    ws.Cells["F7"].Value = Global.Ts;

                    ws.Cells["E8"].Value = "S";
                    ws.Cells["F8"].Value = Global.S;

                    ws.Cells["E9"].Value = "S0";
                    ws.Cells["F9"].Value = Global.S0;


                    ws.Cells["E10"].Value = "T";
                    ws.Cells["F10"].Value = Global.T;

                    ws.Cells["E11"].Value = "B1";
                    ws.Cells["F11"].Value = Global.B1;


                    ws.Cells["E12"].Value = "N";
                    ws.Cells["F12"].Value = Global.N;

                    ws.Cells["E13"].Value = "B";
                    ws.Cells["E13"].Value = Global.B;




                    /////////
                    /////////
                    /////////

                    ws.Cells["H5:I7"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    ws.Cells["H5:I7"].Style.Fill.BackgroundColor.SetColor(Color.LawnGreen);

                    ws.Cells["H5"].Value = "Cx";
                    ws.Cells["I5"].Value = Global.Cx;
                    ws.Cells["H6"].Value = "Cy";
                    ws.Cells["I6"].Value = Global.Cy;
                    ws.Cells["H7"].Value = "K";
                    ws.Cells["I7"].Value = Global.K;



                    //exl.Workbook.Worksheets["2"].Cells["A2"].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(255, 50, 50));




                    // ws.Cells["B1:B1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    //ws.Cells["B1:B1"].Style.Fill.BackgroundColor.SetColor(Color.Gray);



                    // var couleur = System.Drawing.Color.FromArgb(24, 67, 189);
                    //ws.Cells["A6"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    // ws.Cells["A6"].Style.Fill.BackgroundColor.SetColor(couleur);


                    //make the borders of cell F6 thick
                    ws.Cells[6, 6].Style.Border.Top.Style = ExcelBorderStyle.Thick;
                    ws.Cells[6, 6].Style.Border.Right.Style = ExcelBorderStyle.Thick;
                    ws.Cells[6, 6].Style.Border.Bottom.Style = ExcelBorderStyle.Thick;
                    ws.Cells[6, 6].Style.Border.Left.Style = ExcelBorderStyle.Thick;

                    //make the borders of cells A18 - J18 double and with a purple color
                    ws.Cells["A18:J18"].Merge=true;
                    ws.Cells["A18:J18"].Value = "مهران ثاقبی فرد";
                    ws.Cells["A18:J18"].Style.HorizontalAlignment =ExcelHorizontalAlignment.Center;
                    ws.Cells["A18:J18"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    ws.Cells["A18:J18"].Style.Border.Top.Style = ExcelBorderStyle.Double;
                    ws.Cells["A18:J18"].Style.Border.Bottom.Style = ExcelBorderStyle.Double;
                    ws.Cells["A18:J18"].Style.Border.Top.Color.SetColor(Color.Purple);
                    ws.Cells["A18:J18"].Style.Border.Bottom.Color.SetColor(Color.Purple);




                    ws.Cells["A:A"].AutoFitColumns();
                    // ws.Column(2).Width =  100;
                    //ws.Column(2).Width = ws.Column(1).Width / 2;








                    ws.Cells["A1:A25"].Style.Numberformat.Format = "@";




                    var worksheet = ws;

                    //By range address
                    worksheet.Cells["A12:B12"].Merge = true;

                    //By indexes
                    //??? // worksheet.Cells[1, 1, 5, 2].Merge = true;




                    Bitmap bm = new Bitmap(exCrystal.Image, new Size(25, 40));

                    var excelImage = worksheet.Drawings.AddPicture("My Logo", bm);

                    //add the image to row 20, column E
                    excelImage.SetPosition(20, 0, 5, 0);


                    exl.SaveAs(finfo);






                    if (Properties.Settings.Default.isDefPath)
                    {



                        MessageBox.Show("فایل اکسل شما در دسکتاپ ایجاد شد");
                    }
                    else
                    {

                        MessageBox.Show("فایل اکسل ذخیره شد ");

                    }


                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void exText_Click(object sender, EventArgs e)
        {

            MessageBox.Show("از خروجی اکسل استفاده کنید");
            return;

            if (proccessing) return;

            proccessing = true;

            SuperTexter();

            proccessing = false;


        }






        private void SuperTexter()
        {
            FileInfo fi = null;
            string f1, f2;

            StreamWriter writer;


            if (Properties.Settings.Default.isDefPath)
            {
                fi = null;


                var desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

                bool weFound = false;
                int i = 1;

                string a = desktopFolder + @"\ErthQuakeReport\ErthQuake2800.txt";

                if (File.Exists(a))
                {
                    weFound = true;
                    while (File.Exists(desktopFolder + @"\ErthQuakeReport\ErthQuake2800(" + i.ToString() + ").txt"))
                    {
                        i++;
                    }


                }



                if (weFound)
                {
                    f1 = Path.Combine(desktopFolder, @"ErthQuakeReport\ErthQuake2800(" + i.ToString() + ").txt");

                }
                else
                {
                    f1 = Path.Combine(desktopFolder, @"ErthQuakeReport\ErthQuake2800.txt");
                }

                f2 = Path.Combine(desktopFolder, @"ErthQuakeReport");

                if (!Directory.Exists(f2)) Directory.CreateDirectory(f2);




                fi = new FileInfo(f1);


                writer = new StreamWriter(fi.ToString());
            }
            else
            {

                FileDialog fd = new SaveFileDialog();



                fd.AddExtension = false;

                fd.Filter = "TextFile|.txt";
                fd.FileName = "Mytest.txt";

                if (fd.ShowDialog() != DialogResult.OK) return;

                fi = new FileInfo(fd.FileName);
                writer = new StreamWriter(fi.ToString());
            }




            writer.Write("شرح اطلاعات وارده:");
            /////////////////////////////////////////////////////////
            writer.Write("\r\n نوع خاک" + "=");
            writer.Write("\r\n ");
            writer.Write("\r\n ");
            writer.Write("\r\n ");
            writer.Write("\r\n ");
            writer.Write("\r\n ");
            writer.Write("\r\n ");
            writer.Write("\r\n ");
            writer.Write("\r\n ");
            writer.Write("\r\n ");
            writer.Write("\r\n ");











            ///////////////////////////////////////////////////////////
            writer.Write("محاسبات انجام شده");











            ///////////////////////////////////////////////////////////
            writer.Write("نتایج نهایی");









            ////////////////////////////////////////////////////////////
            writer.Close();


            if (Properties.Settings.Default.isDefPath)
            {
                MessageBox.Show("   خروجی متن در دسکتاپ  ذخیره شد  ");

            }
            else
            {
                MessageBox.Show("خروجی متن در ذخیره شد ");

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Global.KhatarNesbi);

            Application.Exit();

        }

        private void exXlsx_MouseMove(object sender, MouseEventArgs e)
        {
            lblColor3.Visible=true;
        }

        private void exXlsx_MouseLeave(object sender, EventArgs e)
        {
            lblColor3.Visible = false;
        }

        private void exText_MouseMove(object sender, MouseEventArgs e)
        {
            lblColor2.Visible = true;
        }

        private void exText_MouseLeave(object sender, EventArgs e)
        {
            lblColor2.Visible = false;
        }

        private void exCrystal_MouseMove(object sender, MouseEventArgs e)
        {
            lblColor.Visible = true;
        }

        private void exCrystal_MouseLeave(object sender, EventArgs e)
        {
            lblColor.Visible= false;
        }
    }
}
