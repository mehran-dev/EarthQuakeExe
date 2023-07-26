using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ErthQuakeIn2800
{
    public partial class frmMe : Form
    {
        public frmMe()
        {
            InitializeComponent();
        }


 
      
    private void timer1_Tick(object sender, EventArgs e)
        {



            if (!Properties.Settings.Default.IsDarkMood)
            {
                if (lblthis.BackColor == Color.FromArgb(255,255,128,0))
                {
                    lblBg.BackColor=lblthis.BackColor = lblMyName.BackColor =lblNumber.BackColor= Color.FromArgb(255, 255, 120, 0);
                    
                }
                else
                {
                    lblBg.BackColor=lblthis.BackColor = lblMyName.BackColor = lblNumber.BackColor = Color.FromArgb(255,255,128,0);
                }
            }
            else
            {
                if (lblthis.BackColor == Color.FromArgb(255,255,128,0))
                {
                   lblBg.BackColor= lblthis.BackColor = lblMyName.BackColor = lblNumber.BackColor  = Color.FromArgb(255, 255, 255, 255);
                }
                else
                {
                    lblBg.BackColor = lblthis.BackColor = lblMyName.BackColor = lblNumber.BackColor =  Color.FromArgb(255,255,128,0);
                }



            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmMe_Load(object sender, EventArgs e)
        {
            //if (Properties.Settings.Default.IsDarkMood)
            //{
            //    lblBg.BackColor = lblMyName.BackColor = lblthis.BackColor = lblNumber.BackColor =Color.White;
            //    btnBack.BackColor = Properties.Settings.Default.DarkColor;

                
            //}

          

        }

        private void lblthis_Click(object sender, EventArgs e)
        {
            
        }

        private void lblMyName_Click(object sender, EventArgs e)
        {

        }

        private void imgMypic_Click(object sender, EventArgs e)
        {

        }

        private void lblBg_Click(object sender, EventArgs e)
        {

        }

        private void lblTel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblTel.Visible = lblGmail.Visible = true;
        }
    }
}
