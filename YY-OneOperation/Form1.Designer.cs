namespace YY_OneOperation
{
    partial class Form1
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
            this.xuıObjectEllipse1 = new XanderUI.XUIObjectEllipse();
            this.xuıFormDesign1 = new XanderUI.XUIFormDesign();
            this.xuıBanner1 = new XanderUI.XUIBanner();
            this.Rnd_btn = new XanderUI.XUIButton();
            this.Secim_btn = new XanderUI.XUIButton();
            this.xuıFormDesign1.WorkingArea.SuspendLayout();
            this.xuıFormDesign1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xuıObjectEllipse1
            // 
            this.xuıObjectEllipse1.CornerRadius = 10;
            this.xuıObjectEllipse1.EffectedControl = this;
            this.xuıObjectEllipse1.EffectedForm = this;
            // 
            // xuıFormDesign1
            // 
            this.xuıFormDesign1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuıFormDesign1.ExitApplication = true;
            this.xuıFormDesign1.FormStyle = XanderUI.XUIFormDesign.Style.MacOS;
            this.xuıFormDesign1.Location = new System.Drawing.Point(0, 0);
            this.xuıFormDesign1.MaterialBackColor = System.Drawing.Color.DodgerBlue;
            this.xuıFormDesign1.MaterialForeColor = System.Drawing.Color.White;
            this.xuıFormDesign1.Name = "xuıFormDesign1";
            this.xuıFormDesign1.ShowMaximize = true;
            this.xuıFormDesign1.ShowMinimize = true;
            this.xuıFormDesign1.Size = new System.Drawing.Size(800, 450);
            this.xuıFormDesign1.TabIndex = 0;
            this.xuıFormDesign1.TitleText = "Main Menu";
            // 
            // xuıFormDesign1.WorkingArea
            // 
            this.xuıFormDesign1.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(172)))));
            this.xuıFormDesign1.WorkingArea.BackgroundImage = global::YY_OneOperation.Properties.Resources.calculator;
            this.xuıFormDesign1.WorkingArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.xuıFormDesign1.WorkingArea.Controls.Add(this.xuıBanner1);
            this.xuıFormDesign1.WorkingArea.Controls.Add(this.Rnd_btn);
            this.xuıFormDesign1.WorkingArea.Controls.Add(this.Secim_btn);
            this.xuıFormDesign1.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuıFormDesign1.WorkingArea.Location = new System.Drawing.Point(0, 39);
            this.xuıFormDesign1.WorkingArea.Name = "WorkingArea";
            this.xuıFormDesign1.WorkingArea.Size = new System.Drawing.Size(800, 411);
            this.xuıFormDesign1.WorkingArea.TabIndex = 0;
            // 
            // xuıBanner1
            // 
            this.xuıBanner1.BackColor = System.Drawing.Color.Transparent;
            this.xuıBanner1.BannerColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.xuıBanner1.BorderColor = System.Drawing.Color.White;
            this.xuıBanner1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xuıBanner1.ForeColor = System.Drawing.Color.White;
            this.xuıBanner1.Location = new System.Drawing.Point(0, 0);
            this.xuıBanner1.Name = "xuıBanner1";
            this.xuıBanner1.Size = new System.Drawing.Size(800, 70);
            this.xuıBanner1.TabIndex = 3;
            this.xuıBanner1.Text = "One Operation";
            // 
            // Rnd_btn
            // 
            this.Rnd_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Rnd_btn.ButtonImage = global::YY_OneOperation.Properties.Resources.desktop_classic__2_;
            this.Rnd_btn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.Rnd_btn.ButtonText = "I Trust My PC";
            this.Rnd_btn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.Rnd_btn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.Rnd_btn.CornerRadius = 5;
            this.Rnd_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Rnd_btn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.Rnd_btn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.Rnd_btn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.Rnd_btn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.Rnd_btn.Location = new System.Drawing.Point(475, 232);
            this.Rnd_btn.Name = "Rnd_btn";
            this.Rnd_btn.Size = new System.Drawing.Size(257, 81);
            this.Rnd_btn.TabIndex = 2;
            this.Rnd_btn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.Rnd_btn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.Rnd_btn.Click += new System.EventHandler(this.Rnd_btn_Click);
            // 
            // Secim_btn
            // 
            this.Secim_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Secim_btn.ButtonImage = global::YY_OneOperation.Properties.Resources.human__1_;
            this.Secim_btn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.Secim_btn.ButtonText = "I\'ll Do It";
            this.Secim_btn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.Secim_btn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.Secim_btn.CornerRadius = 5;
            this.Secim_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Secim_btn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.Secim_btn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.Secim_btn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.Secim_btn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.Secim_btn.Location = new System.Drawing.Point(63, 232);
            this.Secim_btn.Name = "Secim_btn";
            this.Secim_btn.Size = new System.Drawing.Size(257, 81);
            this.Secim_btn.TabIndex = 1;
            this.Secim_btn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.Secim_btn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.Secim_btn.Click += new System.EventHandler(this.Secim_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.xuıFormDesign1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.xuıFormDesign1.WorkingArea.ResumeLayout(false);
            this.xuıFormDesign1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIObjectEllipse xuıObjectEllipse1;
        private XanderUI.XUIFormDesign xuıFormDesign1;
        private XanderUI.XUIButton Rnd_btn;
        private XanderUI.XUIButton Secim_btn;
        private XanderUI.XUIBanner xuıBanner1;
    }
}

