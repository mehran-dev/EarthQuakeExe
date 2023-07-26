using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;


namespace ErthQuakeIn2800
{
    public partial class frmSettiung : Form
    {
        public frmSettiung()
        {
            InitializeComponent();
        }

        private void frm2_Load(object sender, EventArgs e)
        {
            bool isDark = Properties.Settings.Default.IsDarkMood;
            bool isDef = Properties.Settings.Default.isDefPath;
            bool isPreset = Properties.Settings.Default.preset_IsHavebeenSet;
          
            if (isDark)
            {
                DarkMood();
                rdoThemeBlack.Checked = true;
            }
            else
            {

                rdotheneYellow.Checked = true;
            }

            if (isDef)
            {
                rdoExDeskTop.Checked = true;
            }
            else
            {
                rdoExAsk.Checked = true;
            }

            if (isPreset)
            {
                rdoApplyPreset.Checked = true;
            }
            else
            {
                rdoDelPreset.Checked = true;
            }



        }



        private void button2_Click(object sender, EventArgs e)
        {
            rdoExDeskTop.Checked = true;
            rdotheneYellow.Checked = true;
            rdoApplyPreset.Checked = true;
            

        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
         
                
            Properties.Settings.Default.IsDarkMood = rdoThemeBlack.Checked;
            Properties.Settings.Default.isDefPath = rdoExDeskTop.Checked;
            Properties.Settings.Default.preset_IsHavebeenSet = rdoApplyPreset.Checked;
            Properties.Settings.Default.Save();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }







        public void DarkMood()
        {
            this.BackColor = Properties.Settings.Default.DarkColor;
            foreach (var b in this.Controls)
                if (b.GetType() == typeof(Button)) (b as Button).BackColor = Properties.Settings.Default.DarkColor;
            foreach (Control ct in this.Controls)
            {
                ct.ForeColor = Properties.Settings.Default.FontDark;
                foreach (Control cr in ct.Controls)
                {
                    cr.ForeColor = Properties.Settings.Default.FontDark;

                }
            }
        }

        public void NormalMood()
        {
            var yel = Color.FromArgb(255,255, 255, 128);
            this.BackColor = yel;
            foreach (var b in this.Controls)
                if (b.GetType() == typeof(Button)) (b as Button).BackColor = Color.Yellow;// Properties.Settings.Default.DarkColor;
            foreach (Control ct in this.Controls)
            {
                ct.ForeColor =Color.Black ;//Properties.Settings.Default.FontDark;
                foreach (Control cr in ct.Controls)
                {
                    cr.ForeColor =Color.Black ;// Properties.Settings.Default.FontDark;

                }
            }
        }

        private void rdoThemeBlack_CheckedChanged(object sender, EventArgs e)
        {
            DarkMood();
        }

        private void rdotheneYellow_CheckedChanged(object sender, EventArgs e)
        {
            NormalMood();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rdoDelPreset_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoApplyPreset_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoExDeskTop_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoExAsk_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
