using System;
using System.Drawing;
//using System.Threading.Tasks;
using System.Windows.Forms;



namespace ErthQuakeIn2800
{


    public partial class frmMain : Form
    {


        double A = 0; //{ get; set ; }
        double I = 0;
        double B = 0;
        double Rx = 0;
        double Ry = 0;
        double Cx = 0;
        double Cy = 0;
        double T = 0;
        double T0 = 0;
        double Ts = 0;
        double S = 0;
        double S0 = 0;
        double B1 = 0;
        double N = 0;
        double K = 0;

        ////////////////////  private bool calculated =false;

        private bool Calculated { get; set; }





        public frmMain()
        {
            InitializeComponent();
        }
        bool missing = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbKhatarNesbi.Items.Add("خطر نسبی خیلی زیاد");
            cmbKhatarNesbi.Items.Add("خطر نسبی زیاد");
            cmbKhatarNesbi.Items.Add("خطر نسبی متوسط");
            cmbKhatarNesbi.Items.Add("خطر نسبی کم");

            cmbTipKhak.Items.Add("I");
            cmbTipKhak.Items.Add("II");
            cmbTipKhak.Items.Add("III");
            cmbTipKhak.Items.Add("IV");

            cmbDastebandiSaze.Items.Add("گروه 1");
            cmbDastebandiSaze.Items.Add("گروه 2");
            cmbDastebandiSaze.Items.Add("گروه 3");
            cmbDastebandiSaze.Items.Add("گروه 4");


            cmbMaharX.Items.Add("قاب خمشي (جداگر ميانقابي مانع حرکت قاب ها نيست ");
            cmbMaharX.Items.Add("قاب خمشي (جداگر ميانقابي مانع حرکت قاب ها است ");
            cmbMaharX.Items.Add("قاب ساده با مهار بند واگرا");
            cmbMaharX.Items.Add("ساير سيستم هاي ساختماني");


            cmbMaharY.Items.Add("قاب خمشي (جداگر ميانقابي مانع حرکت قاب ها نيست ");
            cmbMaharY.Items.Add("قاب خمشي (جداگر ميانقابي مانع حرکت قاب ها است ");
            cmbMaharY.Items.Add("قاب ساده با مهار بند واگرا");
            cmbMaharY.Items.Add("ساير سيستم هاي ساختماني");

            cmbRxCas1.Items.Add("الف-سیستم دیوار های باربر");
            cmbRxCas1.Items.Add("ب-سیستم قاب ساختمانی");
            cmbRxCas1.Items.Add("پ-سیستم قاب خمشی");
            cmbRxCas1.Items.Add("ت-سیستم دوگانه یا ترکیبی");
            cmbRxCas1.Items.Add("ث-سیستم کنسولی ");


            cmbRyCas1.Items.Add("الف-سیستم دیوار های باربر");
            cmbRyCas1.Items.Add("ب-سیستم قاب ساختمانی");
            cmbRyCas1.Items.Add("پ-سیستم قاب خمشی");
            cmbRyCas1.Items.Add("ت-سیستم دوگانه یا ترکیبی");
            cmbRyCas1.Items.Add("ث-سیستم کنسولی ");






            ////-------------------------------------------------------------------------------------------------///
            cmbSazeHaeMotaaref.Items.Add("الف-ساختمان باسیستم قاب خمشی");
            cmbSazeHaeMotaaref.Items.Add("ب-ساختمان باسیستممهاربندی واگرا ، مشابه قاب فولادی");
            cmbSazeHaeMotaaref.Items.Add("پ-ساختمان با سایر سیستم های مندرج در" + " جدول(5-3)" + "به غیر از سیستم کنسولی");
            // cmbSazeHaeMotaaref.Items.Add("بتنی - سایر سیستم ها ی مندرج در جدول (5-3) به جز کنسولی");





            cmbConcreteOrSteel.Items.Add("بتن");
            cmbConcreteOrSteel.Items.Add("فولاد");




            rdoMotearef.Checked = true;






            readPreSet();


            //foreach (Control i in gbData.Controls)
            //{

            //    if (i is ComboBox)
            //    {


            //        if ((i as ComboBox).Name != "cmbRxCas2" && (i as ComboBox).Name != "cmbRyCas2")

            //            (i as ComboBox).SelectedIndex = 1;
            //    }

            //}



            //txtHeight.Text = "10";



            /*
            var color = Color.FromArgb(2,60,60);
            groupBox1.BackColor = color;
            groupBox4.BackColor = color;
            groupBox5.BackColor = color;


            this.BackColor = Color.FromArgb(2,30,20);*/
            if (Properties.Settings.Default.IsDarkMood) DarkMood();

            //button1_Click(null,null);
            //button5_Click(null,null);
        }

        private void cmbRxCas1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRxCas2.Items.Clear();

            CasFiller(cmbRxCas1.SelectedIndex, true);



        }



        private void CasFiller(int switcher, bool XCas)
        {



            ComboBox CasIN = new ComboBox();
            if (XCas)
                CasIN = cmbRxCas2;
            else
                CasIN = cmbRyCas2;


            switch (switcher)
            {

                case 0:
                    CasIN.Items.Add("1-دیواربرشی بتن آرمه ویژه");
                    CasIN.Items.Add("2-دیواربرشی بتن آرمه متوسط");
                    CasIN.Items.Add("3-دیوار های بتن آرمه برشی معمولی[1]");
                    CasIN.Items.Add("4-دیواربرشی با مصالح بنایی مسلح");
                    CasIN.Items.Add("5- دیوار های متشکل از قاب سبک فولادی سردنورد و مهار های تسمه ای فولادی ");
                    CasIN.Items.Add("6-دیوار های متشکل از قاب های سبک فولادی سرد نورد و صفحات پوشش فولادی");
                    CasIN.Items.Add("7-دیوار های بتنی پاششی سه بعدی ");

                    break;
                case 1:
                    CasIN.Items.Add("1-دیوار های برشی بتن آرمه ویژه [2]");
                    CasIN.Items.Add("2-دیواربرشی بتن آرمه متوسط ");
                    CasIN.Items.Add("3-دیوار های برشی بتن آرمه معمولی [1]");
                    CasIN.Items.Add("4-دیوار برشی با مصالح بنایی مسلح ");
                    CasIN.Items.Add("5-مهار بندی واگرای ویژه فولادی [2]  و [3]");
                    CasIN.Items.Add("6-مهاربندی کمانش تاب");
                    CasIN.Items.Add("7-مهاربنذی همگرای معمولی فولادی");
                    CasIN.Items.Add("8-مهاربندی همگرای ویژه فولادی [2]");



                    break;

                case 2:

                    CasIN.Items.Add("1- " + "قاب خمشی بتن آرمه ویژه " + " [4] ");
                    CasIN.Items.Add("2- " + "قاب خمشی بتن آرمه متوسط" + "  [4] ");
                    CasIN.Items.Add("3-" + "قاب خمشی بتن آرمه معمولی " + "[4]  و  [1]");
                    CasIN.Items.Add("4-" + "قاب خمشی فولادی ویژه ");
                    CasIN.Items.Add("5-" + "قاب خمشی فولادی متوسط ");
                    CasIN.Items.Add("6-" + "قاب خمشی فولادی معمولی" + " [1] ");


                    break;

                case 3:

                    CasIN.Items.Add("1-" + " قاب خمشی ویژه" + " (فولادی یا بتنی ) " + "+ دیوار برشی بتن آرمه ویژه");
                    CasIN.Items.Add("2-" + "قاب خمشی بتن آرمه متوسط " + " + دیوار برشی بتن آرمه ویژه");
                    CasIN.Items.Add("3-" + "قاب خمشی بتن آرمه متوسط " + " + دیوار برشی بتن آرمه متوسط ");
                    CasIN.Items.Add("4-" + "قاب خمشی فولادی متوسط " + " + دیوار برشی بتن آرمه متوسط ");
                    CasIN.Items.Add("5-" + "قاب خمشی فولادی ویژه " + " + مهاربندی واگرای ویژه فولادی");
                    CasIN.Items.Add("6-" + "قاب خمشی فولادی متوسط" + " + مهاربنی واگرای ویژه فولادی");
                    CasIN.Items.Add("7-" + "قاب خمشی فولادی ویژه" + " + مهاربندی همگرای ویژه فولادی");
                    CasIN.Items.Add("8-" + "قاب خمشی فولادی متوسط " + " + مهاربندی همگرای ویژه فولادی");


                    break;


                case 4:
                    CasIN.Items.Add("سازه فولادی یا بتن آرمه ویژه ");

                    break;










                default:


                    break;

            }
        }

        private void cmbRyCas1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRyCas2.Items.Clear();
            CasFiller(cmbRyCas1.SelectedIndex, false);


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {



            //if (Checker(Mode.IsOkHeight))
            //{
            //    txtHeight.BackColor = Color.Red;
            //}
            //else
            //{
            //    txtHeight.BackColor = Color.White;
            //}


        }

        private bool IsOkHeight()
        {

            bool Ok = false;

            double limitheight = 0;
            double limitx = 0, limity = 0;
            limitx = LHeight(true);
            limity = LHeight(false);
            limitheight = Math.Min(limitx, limity);


            if (Convert.ToDouble(txtHeight.Text) <= limitheight)
            {
                Ok = true;

            }
            else
            {

                Ok = false;
                Err.SetError(txtHeight, "ارتفاع مجاز نیست");
                MessageBox.Show("ارتفاع ساختمان از حد اکثر ارتفاع در آیین نامه بیشتر است " + Environment.NewLine + "یا ارتفاع از 2000 متر بیشتر وارد شده ", "عدم رعایت حداکثر ارتفاع سازه ");

            }

            return Ok;




        }

        private bool IsMissing()
        {
            missing = false;

            ///////////////////////////////////////////////////////////////////////////////
            //                                      بررسی gbData                        //   
            ///////////////////////////////////////////////////////////////////////////////

            foreach (Control ctr in gbData.Controls)
            {

                if (ctr.GetType().Name == "TextBox")
                {
                    if (ctr.Text.Trim() == String.Empty)
                    {
                        missing = true;
                        Err.SetError(ctr, "فیلد الزامی");

                    }
                }
                if (ctr is ComboBox)

                {

                    if ((ctr as ComboBox).SelectedIndex == -1)
                    {
                        missing = true;
                        Err.SetError(ctr, "فیلد الزامی");
                    }
                }
            }




            ///////////////////////////////////////////////////////////////////
            ////                                بررسی T
            ////////////////////////////////////////////////////////////////


            if (rdoNaMotearef.Checked && txtTDynamic.Text.Trim() == string.Empty)
            {
                missing = true;
                Err.SetError(txtTDynamic, "فیلد الزامی");
            }


            if (rdoMotearef.Checked)
            {
                if (cmbSazeHaeMotaaref.SelectedIndex == -1)
                {
                    missing = true;
                    Err.SetError(cmbSazeHaeMotaaref, "فیلد الزامی");

                }
                if (cmbSazeHaeMotaaref.SelectedIndex == 0 && cmbConcreteOrSteel.SelectedIndex == -1)
                {
                    missing = true;
                    Err.SetError(cmbConcreteOrSteel, "فیلد الزامی");

                }
            }




            if (missing)
            {
                MessageBox.Show("مقادیر مورد نیاز وارد نشده اند تمامی");
            }
            else
            {

            }

            return missing;
        }
        enum Locking
        {
            LockIt,
            UnLockIt,
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Err.Dispose();

            if (IsMissing()) return;
            if (!IsOkHeight()) return;

            UnLocker(Locking.LockIt);



            A = calcA(cmbKhatarNesbi.SelectedIndex);
            I = calcI(cmbDastebandiSaze.SelectedIndex);
            Rx = calcR(cmbRxCas1.SelectedIndex, cmbRxCas2.SelectedIndex);
            Ry = calcR(cmbRyCas1.SelectedIndex, cmbRyCas2.SelectedIndex);
            T0 = calcT0();
            Ts = calcTs();
            S = calcS();
            S0 = calcS0();

            T = calcT();
            B1 = calcB1();
            N = calcN();
            B = calcB();
            K = calcK();

            Cx = A * B * I / Rx;
            Cy = A * B * I / Ry;
            showResult();

            Globaller();

            Calculated = true;


        }

        private void Globaller()
        {
            ///////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////                     ورودی های کاربر           ///////////////
            //////////////////////////////////////////////////////////////////////////////////////
            Global.KhatarNesbi = cmbKhatarNesbi.Text;
            Global.TipKhak = cmbTipKhak.Text;
            Global.DrajeAhammeyatSaze = cmbDastebandiSaze.Text;
            Global.ErtefaSaze = txtHeight.Text;
            Global.MaharBandX = cmbMaharX.Text;
            Global.MaharBandY = cmbMaharY.Text;
            Global.MoghavemX1 = cmbRxCas1.Text;
            Global.MoghavemX2 = cmbRxCas2.Text;
            Global.MoghavemY1 = cmbRyCas1.Text;
            Global.MoghavemY2 = cmbRyCas2.Text;
            ////////////////           T           \\\\\\\\\\\\\\\\\\\\\\
            Global.AyyaSazeMotearef = rdoMotearef.Checked.ToString(); Global.NoeSazeMotearef = cmbConcreteOrSteel.Text;
            Global.NoasazeMotearef1 = cmbSazeHaeMotaaref.Text;
            Global.TDynamicy = txtTDynamic.Text;
            Global.AyyaMianghabMoneAst = chkMianghabiManeAst.Checked.ToString();






            ///////////////////////////////////////////////////////////////////////////////////
            //////////////////////               محاسبات              ///////////////////////
            //////////////////////////////////////////////////////////////////////////////////




            Global.A = A.ToString();
            Global.I = I.ToString();
            Global.Rx = Rx.ToString();
            Global.Ry = Ry.ToString();
            Global.T0 = T0.ToString();
            Global.Ts = Ts.ToString();
            Global.S = S.ToString();
            Global.S0 = S0.ToString();
            Global.T = T.ToString();
            Global.B1 = B1.ToString();
            Global.N = N.ToString();
            Global.B = B.ToString();




            ///////////////////////////////////////////////////////////////////////////////////
            //////////////////////               نتایج              ///////////////////////
            //////////////////////////////////////////////////////////////////////////////////

            Global.Cx = Cx.ToString();
            Global.Cy = Cy.ToString();
            Global.K = K.ToString();




        }

        private void showResult()
        {
            lblCx.Text = Math.Round(Cx, 3).ToString();
            lblCy.Text = Math.Round(Cy, 3).ToString();
            lblK.Text = Math.Round(K, 3).ToString();

        }






        private void btnCalc_Click(object sender, EventArgs e)
        {

            ClearMe();

        }



        private void ClearMe()
        {
            foreach (Control ctr in gbData.Controls)
            {

                if (ctr.GetType().Name == "TextBox")
                {
                    ctr.Text = String.Empty;
                }
                if (ctr is ComboBox)

                {
                    //Get controls By Name ::::::  // if (ctr.Name == "cmbPahne") MessageBox.Show("پهنه "); 
                    (ctr as ComboBox).SelectedIndex = -1;
                }
                cmbSazeHaeMotaaref.SelectedIndex = -1;
                cmbConcreteOrSteel.SelectedIndex = -1;
                txtTDynamic.Text = String.Empty;
                chkMianghabiManeAst.Checked = false;
                lblCx.Text = string.Empty;
                lblCy.Text = string.Empty;
                lblK.Text = string.Empty;

            }


        }




        private void UnLocker(Locking? lck)
        {
            bool UnLoking = true;
            if (lck == Locking.LockIt) UnLoking = false;

            Calculated = !UnLoking;
            gbData.Enabled = gbT.Enabled = UnLoking;
        }




        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult R;

            R = MessageBox.Show("اطلاعات وارد شده پاک شوند ؟", "پاک کردن؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (R == DialogResult.Yes)
            {
                ClearMe();
                UnLocker(Locking.UnLockIt);
                Err.Clear();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Form frm2 = new frmSettiung();

            if (frm2.ShowDialog() == DialogResult.OK) Application.Restart();  // if (Properties.Settings.Default.IsDarkMood) DarkMood();










            ////////////////
            //////////////
            ///کد جدید قبلا بلد نبودم 
            ///////////////////

            //for (int i = 0; i < this.Controls.Count; i++)
            //{
            //    this.Controls[i].ResetText();
            //}



        }

        private void button3_Click(object sender, EventArgs e)
        {
            try

            {


                System.Diagnostics.Process.Start("Calc.exe");


            }
            catch (Exception ex)
            {
                MessageBox.Show("                                                                            " + "به خطا زیر بر خوردیم " + Environment.NewLine + "___________________________________________________________________________________" + Environment.NewLine + ex.ToString());
            }



        }

        private void btnUnLock_Click(object sender, EventArgs e)
        {




            if (!gbData.Enabled == true)
            {
                gbData.Enabled = true;
                gbT.Enabled = true;
            }
            else
            {

                MessageBox.Show("اطلاعات ساختمان قفل نیست " + Environment.NewLine + "پس از محاسبه اطلاعات ساختمان قفل خواهد شد ", "باز کردن ورودی اطلاعات ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }



        }

        private double calcA(int ComboIndex)

        {
            switch (ComboIndex)
            {
                case 0:
                    return 0.35;
                case 1:
                    return 0.3;
                case 2:
                    return 0.25;
                case 3:
                    return 0.2;
                default:
                    return 0;

            }



        }

        private double calcI(int ComboIndex)
        {
            switch (ComboIndex)
            {
                case 0:

                    return 1.4;

                case 1:

                    return 1.2;
                case 2:

                    return 1;
                case 3:

                    return 0.8;
                default:
                    return 0;

            }

        }
        private double calcR(int Cas1, int Cas2)
        {
            double returner = 0;

            string Chk = string.Empty;
            Chk = Cas1.ToString() + "/" + Cas2.ToString();

            if (Chk == "0/0") returner = 5;
            if (Chk == "0/1") returner = 4;
            if (Chk == "0/2") returner = 3.5;
            if (Chk == "0/3") returner = 3;
            if (Chk == "0/4") returner = 4;
            if (Chk == "0/5") returner = 5.5;
            if (Chk == "0/6") returner = 3;
            if (Chk == "1/0") returner = 6;
            if (Chk == "1/1") returner = 5;
            if (Chk == "1/2") returner = 4;
            if (Chk == "1/3") returner = 3;
            if (Chk == "1/4") returner = 7;
            if (Chk == "1/5") returner = 7;
            if (Chk == "1/6") returner = 3.5;
            if (Chk == "1/7") returner = 5.5;
            if (Chk == "2/0") returner = 7.5;
            if (Chk == "2/1") returner = 5;
            if (Chk == "2/2") returner = 3;
            if (Chk == "2/3") returner = 7.5;
            if (Chk == "2/4") returner = 5;
            if (Chk == "2/5") returner = 3.5;
            if (Chk == "3/0") returner = 7.5;
            if (Chk == "3/1") returner = 6.5;
            if (Chk == "3/2") returner = 6;
            if (Chk == "3/3") returner = 6;
            if (Chk == "3/4") returner = 7.5;
            if (Chk == "3/5") returner = 6;
            if (Chk == "3/6") returner = 7;
            if (Chk == "3/7") returner = 6;
            if (Chk == "4/0") returner = 2;

            return returner;


        }



        private double calcB1()
        {
            double tempB1 = 0;

            if (0 < T && T < T0)
            {
                tempB1 = S0 + (S - S0 + 1) * (T / T0);
            }

            if (T0 < T && T < Ts)
            {
                tempB1 = S + 1;
            }

            if (T > Ts)
            {
                tempB1 = (S + 1) * (Ts / T);

            }





            return tempB1;

        }


        private double calcN()
        {
            double tempN = 0;

            if (cmbKhatarNesbi.SelectedIndex <= 1)
            {

                if (T < Ts) tempN = 1;
                if (Ts < T && T < 4) tempN = (0.7 / (4 - Ts)) * (T - Ts) + 1;
                if (T > 4) tempN = 1.7;
            }
            if (cmbKhatarNesbi.SelectedIndex >= 2)
            {

                if (T < Ts) tempN = 1;
                if (Ts < T && T < 4) tempN = (0.4 / (4 - Ts)) * (T - Ts) + 1;
                if (T > 4) tempN = 1.4;

            }


            return tempN;
        }


        private double calcB()
        {
            double tempB = 0;
            tempB = B1 * N;
            return tempB;
        }








        private double calcT()
        {
            //tt===T temp!     :-)
            //ttj=== t tajrobi   :-)
            double tt = 0;
            double ttD = 0;

            if (!string.IsNullOrEmpty(txtTDynamic.Text)) ttD = Convert.ToDouble(txtTDynamic.Text);


            if (rdoNaMotearef.Checked)
            {

                if (chkMianghabiManeAst.Checked)
                {

                    tt = Convert.ToDouble(txtTDynamic.Text);
                }
                else
                {
                    tt = 0.8 * Convert.ToDouble(txtTDynamic.Text);


                }


            }

            //===========================================================================================//
            else if (rdoMotearef.Checked)
            {
                //A

                if (cmbSazeHaeMotaaref.SelectedIndex == 0)
                {
                    if (cmbConcreteOrSteel.SelectedIndex == 0)
                    {
                        tt = 0.05 * Math.Pow(Convert.ToDouble(txtHeight.Text), 0.75);
                    }
                    if (cmbConcreteOrSteel.SelectedIndex == 1)
                    {
                        tt = 0.08 * Math.Pow(Convert.ToDouble(txtHeight.Text), 0.75);
                    }

                }





                //B

                if (cmbSazeHaeMotaaref.SelectedIndex == 1)
                {
                    tt = 0.08 * Math.Pow(Convert.ToDouble(txtHeight.Text), 0.75);
                }

                //C

                if (cmbSazeHaeMotaaref.SelectedIndex == 2)
                {
                    tt = 0.05 * Math.Pow(Convert.ToDouble(txtHeight.Text), 0.75);
                }


            }







            //Tasbareh!!
            if (chkMianghabiManeAst.Checked) tt = tt * 0.8;

            //Tabsareh!
            if (ttD != 0) if (ttD <= 1.25 * tt) tt = ttD;
            return tt;

        }





        private double calcK()
        {
            double kk = 0;


            if (T <= 0.5) kk = 1;
            if (T >= 2.5) kk = kk = 2;
            if (T < 2.5 && T > 0.5) kk = 0.5 * T + 0.75;

            return kk;
        }









        private double LHeight(bool IsX)
        {

            double returner = 0;

            string Chk = string.Empty;


            if (IsX) Chk = cmbRxCas1.SelectedIndex.ToString() + "/" + cmbRxCas2.SelectedIndex.ToString();
            if (!IsX) Chk = cmbRyCas1.SelectedIndex.ToString() + "/" + cmbRyCas2.SelectedIndex.ToString();

            if (Chk == "0/0") returner = 50;
            if (Chk == "0/1") returner = 50;
            if (Chk == "0/2") returner = 5000;
            if (Chk == "0/3") returner = 15;
            if (Chk == "0/4") returner = 15;
            if (Chk == "0/5") returner = 15;
            if (Chk == "0/6") returner = 10;
            if (Chk == "1/0") returner = 50;
            if (Chk == "1/1") returner = 35;
            if (Chk == "1/2") returner = 5000;
            if (Chk == "1/3") returner = 15;
            if (Chk == "1/4") returner = 50;
            if (Chk == "1/5") returner = 50;
            if (Chk == "1/6") returner = 15;
            if (Chk == "1/7") returner = 50;
            if (Chk == "2/0") returner = 200;
            if (Chk == "2/1") returner = 35;
            if (Chk == "2/2") returner = 5000;
            if (Chk == "2/3") returner = 200;
            if (Chk == "2/4") returner = 50;
            if (Chk == "2/5") returner = 5000;
            if (Chk == "3/0") returner = 200;
            if (Chk == "3/1") returner = 70;
            if (Chk == "3/2") returner = 50;
            if (Chk == "3/3") returner = 50;
            if (Chk == "3/4") returner = 200;
            if (Chk == "3/5") returner = 70;
            if (Chk == "3/6") returner = 200;
            if (Chk == "3/7") returner = 70;
            if (Chk == "4/0") returner = 10;

            return returner;





        }



        private double calcT0()
        {

            switch (cmbTipKhak.SelectedIndex)
            {
                case 0: return 0.1;
                case 1: return 0.1;
                case 2: return 0.15;
                case 3: return 0.15;
                default: return 0;
            }


        }




        private double calcTs()
        {

            switch (cmbTipKhak.SelectedIndex)
            {
                case 0: return 0.4;
                case 1: return 0.5;
                case 2: return 0.7;
                case 3: return 1;
                default: return 0;
            }


        }







        private double calcS()
        {

            switch (cmbTipKhak.SelectedIndex)
            {
                case 0: return 1.5;
                case 1: return 1.5;
                case 2: return 1.75;
                case 3:
                    if (cmbKhatarNesbi.SelectedIndex == 0 || cmbKhatarNesbi.SelectedIndex == 1)
                        return 2.25;
                    if (cmbKhatarNesbi.SelectedIndex == 2 || cmbKhatarNesbi.SelectedIndex == 3)
                        return 1.75;
                    else return 0;
                default: return 0;
            }


        }





        private double calcS0()
        {

            switch (cmbTipKhak.SelectedIndex)
            {
                case 0: return 1;
                case 1: return 1;
                case 2: return 1.1;
                case 3:
                    if (cmbKhatarNesbi.SelectedIndex == 0 || cmbKhatarNesbi.SelectedIndex == 1)
                        return 1.3;
                    if (cmbKhatarNesbi.SelectedIndex == 2 || cmbKhatarNesbi.SelectedIndex == 3)
                        return 1.1;
                    else return 0;
                default: return 0;
            }


        }
























        private void cmbSazeHaeMotaaref_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSazeHaeMotaaref.SelectedIndex == 0)
            {

                cmbConcreteOrSteel.Enabled = true;
                chkMianghabiManeAst.Enabled = true;
                // chkMianghabiManeAst.Checked =false;
            }
            else
            {

                cmbConcreteOrSteel.Enabled = false;
                chkMianghabiManeAst.Enabled = false;
                chkMianghabiManeAst.Checked = false;
                cmbConcreteOrSteel.SelectedIndex = -1;

            }





        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            double fail = 0;
            String Str = txtHeight.Text.Trim() + e.KeyChar;


            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Left || e.KeyChar == (char)Keys.Right)
            {

            }
            else if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = !double.TryParse(Str, out fail);
            }

        }

        private void txtTDynamic_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTDynamic_KeyPress(object sender, KeyPressEventArgs e)
        {
            double fail = 0;
            String Str = txtTDynamic.Text.Trim() + e.KeyChar;


            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Left || e.KeyChar == (char)Keys.Right)
            {

            }
            else if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = !double.TryParse(Str, out fail);
            }

        }

        private void btnTamas_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("گمنامان جهانیم - خیلی هم شاخ هستیم :-)");

            new frmMe().ShowDialog();
        }





        Size xl = new Size(50, 50);
        Size s = new Size(40, 40);
        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            btnUnLock.Size = xl;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            btnUnLock.Size = s;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.Size = xl;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {

            button3.Size = s;
        }

        private void btnClear_MouseMove(object sender, MouseEventArgs e)
        {

            btnClear.Size = xl;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {

            btnClear.Size = s;
        }

        private void btnSetting_MouseMove(object sender, MouseEventArgs e)
        {
            btnSetting.Size = xl;
        }

        private void btnSetting_MouseLeave(object sender, EventArgs e)
        {
            btnSetting.Size = s;
        }

        private void btnTamas_MouseMove(object sender, MouseEventArgs e)
        {
            btnTamas.Size = xl;
        }

        private void btnTamas_MouseLeave(object sender, EventArgs e)
        {
            btnTamas.Size = s;
        }

        private void rdoNamotearef_CheckedChanged(object sender, EventArgs e)
        {


            label9.Visible = !rdoNaMotearef.Checked;
            label11.Visible = !rdoNaMotearef.Checked;
            cmbConcreteOrSteel.Visible = !rdoNaMotearef.Checked;
            cmbSazeHaeMotaaref.Visible = !rdoNaMotearef.Checked;

            cmbConcreteOrSteel.SelectedIndex = cmbSazeHaeMotaaref.SelectedIndex = -1;



        }

        private void rdoMotearef_CheckedChanged(object sender, EventArgs e)
        {
            label9.Visible = rdoMotearef.Checked;
            cmbSazeHaeMotaaref.Visible = rdoMotearef.Checked;




            label11.Visible = false;//rdoMotearef.Checked;
            cmbConcreteOrSteel.Visible = false;// rdoMotearef.Checked;
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void cmbSazeHaeMotaaref_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbSazeHaeMotaaref.SelectedIndex == 0)
            {

                cmbConcreteOrSteel.Visible = true;
                label11.Visible = true;
            }
            else
            {
                cmbConcreteOrSteel.Visible = false;
                cmbConcreteOrSteel.SelectedIndex = -1;
                label11.Visible = false;
            }


        }

        private void cmbConcreteOrSteel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbKhatarNesbi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            button5.Size = xl;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.Size = s;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {



            if (Calculated)
            {
                new frmExp().ShowDialog();

            }
            else
            {
                MessageBox.Show("ابتدا محاسبه را بزنید", "ورودی ها قفل نیستند ");
            }




        }
        public void DarkMood()
        {
            this.BackColor = Properties.Settings.Default.DarkColor;
            foreach (var b in this.Controls)
                if (b.GetType() == typeof(Button)) (b as Button).BackColor = Properties.Settings.Default.DarkColor;
            foreach (Control ct in this.Controls)
            {
                ct.BackColor = Properties.Settings.Default.DarkColor;
                ct.ForeColor = Properties.Settings.Default.FontDark;
                foreach (Control cr in ct.Controls)
                {
                    cr.ForeColor = Properties.Settings.Default.FontDark;
                    cr.BackColor = Properties.Settings.Default.DarkColor;
                }
            }
            foreach (Control bt in gbButtons.Controls)
            {
                (bt as Button).FlatAppearance.BorderColor = Color.White;
                (bt as Button).FlatAppearance.MouseOverBackColor = Color.Gray;
                (bt as Button).FlatAppearance.MouseDownBackColor = Color.DarkGray;


            }
        }


        private void button1_Click_2(object sender, EventArgs e)
        {
            DarkMood();
        }

        private void frm1_Activated(object sender, EventArgs e)
        {


        }

        private void btnUnLock_Click_1(object sender, EventArgs e)
        {

            if (Calculated)
            {
                DialogResult r;
                r = MessageBox.Show("قفل باز شود؟", "قفل باز می شود.", MessageBoxButtons.YesNo);

                if (r == DialogResult.Yes)
                {
                    UnLocker(Locking.UnLockIt);
                    lblCx.Text = string.Empty;
                    lblCy.Text = string.Empty;
                    lblK.Text = string.Empty;
                    MessageBox.Show("ورودی ها باز شدند ");
                }
            }
            else
            {
                MessageBox.Show("ورودی ها قفل نیستند . ");
            }

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void PreSets()
        {
            Properties.Settings.Default.preset_IsHavebeenSet = true;




            Properties.Settings.Default.cmbKhatarNesbi = cmbKhatarNesbi.SelectedIndex;
            Properties.Settings.Default.cmbTipKhak = cmbTipKhak.SelectedIndex;
            Properties.Settings.Default.cmbDastebandiSsaze = cmbDastebandiSaze.SelectedIndex;
            Properties.Settings.Default.cmbRxCas1 = cmbRxCas1.SelectedIndex;
            Properties.Settings.Default.cmbRxCas2 = cmbRxCas2.SelectedIndex;
            Properties.Settings.Default.cmbRyCas1 = cmbRyCas1.SelectedIndex;
            Properties.Settings.Default.cmbRyCas2 = cmbRyCas2.SelectedIndex;
            Properties.Settings.Default.txtHeight = txtHeight.Text;
            Properties.Settings.Default.cmbMaharX = cmbMaharX.SelectedIndex;
            Properties.Settings.Default.cmbMaharY = cmbMaharY.SelectedIndex;
            Properties.Settings.Default.rdoMotearef = rdoMotearef.Checked;
            Properties.Settings.Default.rdoNaMotearef = rdoNaMotearef.Checked;
            Properties.Settings.Default.cmbSazeHaeMotearef = cmbSazeHaeMotaaref.SelectedIndex;
            Properties.Settings.Default.cmbConcOrSteel = cmbConcreteOrSteel.SelectedIndex;
            Properties.Settings.Default.txtTDynamic = txtTDynamic.Text;
            Properties.Settings.Default.chkMianghabimaneAst = chkMianghabiManeAst.Checked;

            Properties.Settings.Default.Save();

            MessageBox.Show("مقادیر اولیه برای ورودی ها ثبت گردید");
        }

        private void readPreSet()
        {
            if (Properties.Settings.Default.preset_IsHavebeenSet == true)
            {

                cmbKhatarNesbi.SelectedIndex = Properties.Settings.Default.cmbKhatarNesbi;
                cmbTipKhak.SelectedIndex = Properties.Settings.Default.cmbTipKhak;
                cmbDastebandiSaze.SelectedIndex = Properties.Settings.Default.cmbDastebandiSsaze;
                cmbRxCas1.SelectedIndex = Properties.Settings.Default.cmbRxCas1;
                cmbRxCas2.SelectedIndex = Properties.Settings.Default.cmbRxCas2;
                cmbRyCas1.SelectedIndex = Properties.Settings.Default.cmbRyCas1;
                cmbRyCas2.SelectedIndex = Properties.Settings.Default.cmbRyCas2;
                txtHeight.Text = Properties.Settings.Default.txtHeight;
                cmbMaharX.SelectedIndex = Properties.Settings.Default.cmbMaharX;
                cmbMaharY.SelectedIndex = Properties.Settings.Default.cmbMaharY;
                rdoMotearef.Checked = Properties.Settings.Default.rdoMotearef;
                rdoNaMotearef.Checked = Properties.Settings.Default.rdoNaMotearef;
                cmbSazeHaeMotaaref.SelectedIndex = Properties.Settings.Default.cmbSazeHaeMotearef;
                cmbConcreteOrSteel.SelectedIndex = Properties.Settings.Default.cmbConcOrSteel;
                txtTDynamic.Text = Properties.Settings.Default.txtTDynamic;
                chkMianghabiManeAst.Checked = Properties.Settings.Default.chkMianghabimaneAst;

                Properties.Settings.Default.Save();

            }

        }

        private void btnPreset_Click(object sender, EventArgs e)
        {
            DialogResult r = DialogResult.No;

            r = MessageBox.Show("مقادیر وارد شده به عنوان مقادیر پیش فرض انتخاب شوند ؟", "ثبت مقادیر پیش فرض", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {

                PreSets();

            }



        }

        private void btnPreset_MouseMove(object sender, MouseEventArgs e)
        {
            btnPreset.Size = xl;
        }

        private void btnPreset_MouseLeave(object sender, EventArgs e)
        {
            btnPreset.Size = s;
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            PreSets();
        }
    }
}


