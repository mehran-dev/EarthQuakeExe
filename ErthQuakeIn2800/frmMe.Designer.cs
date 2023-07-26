namespace ErthQuakeIn2800
{
    partial class frmMe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMe));
            this.btnBack = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblBg = new System.Windows.Forms.Label();
            this.lblthis = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblMyName = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.imgResume = new System.Windows.Forms.PictureBox();
            this.imgMypic = new System.Windows.Forms.PictureBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblGmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgResume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMypic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblBg
            // 
            this.lblBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.lblBg, "lblBg");
            this.lblBg.Name = "lblBg";
            this.lblBg.Click += new System.EventHandler(this.lblBg_Click);
            // 
            // lblthis
            // 
            this.lblthis.BackColor = System.Drawing.Color.DarkGoldenrod;
            resources.ApplyResources(this.lblthis, "lblthis");
            this.lblthis.Name = "lblthis";
            this.lblthis.Click += new System.EventHandler(this.lblthis_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.BackColor = System.Drawing.Color.DarkGoldenrod;
            resources.ApplyResources(this.lblNumber, "lblNumber");
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Click += new System.EventHandler(this.lblthis_Click);
            // 
            // lblMyName
            // 
            this.lblMyName.BackColor = System.Drawing.Color.DarkGoldenrod;
            resources.ApplyResources(this.lblMyName, "lblMyName");
            this.lblMyName.ForeColor = System.Drawing.Color.Black;
            this.lblMyName.Name = "lblMyName";
            this.lblMyName.Click += new System.EventHandler(this.lblMyName_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.btn1, "btn1");
            this.btn1.Name = "btn1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // imgResume
            // 
            this.imgResume.BackColor = System.Drawing.Color.Yellow;
            this.imgResume.Image = global::ErthQuakeIn2800.Properties.Resources.download;
            resources.ApplyResources(this.imgResume, "imgResume");
            this.imgResume.Name = "imgResume";
            this.imgResume.TabStop = false;
            // 
            // imgMypic
            // 
            this.imgMypic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.imgMypic, "imgMypic");
            this.imgMypic.Name = "imgMypic";
            this.imgMypic.TabStop = false;
            this.imgMypic.Click += new System.EventHandler(this.imgMypic_Click);
            // 
            // lblTel
            // 
            resources.ApplyResources(this.lblTel, "lblTel");
            this.lblTel.Name = "lblTel";
            this.lblTel.Click += new System.EventHandler(this.lblTel_Click);
            // 
            // lblGmail
            // 
            resources.ApplyResources(this.lblGmail, "lblGmail");
            this.lblGmail.Name = "lblGmail";
            this.lblGmail.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmMe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.lblGmail);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblMyName);
            this.Controls.Add(this.imgResume);
            this.Controls.Add(this.imgMypic);
            this.Controls.Add(this.lblBg);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblthis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "frmMe";
            this.ShowIcon = false;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.frmMe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgResume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMypic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox imgMypic;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblBg;
        private System.Windows.Forms.PictureBox imgResume;
        private System.Windows.Forms.Label lblthis;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblMyName;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblGmail;
    }
}