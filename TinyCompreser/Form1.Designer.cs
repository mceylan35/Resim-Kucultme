namespace TinyCompreser
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
            this.xuiFormDesign1 = new XanderUI.XUIFormDesign();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.indirilenDosyaListBox = new System.Windows.Forms.ListBox();
            this.dosyaListBox = new System.Windows.Forms.ListBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.klasorAcBtn = new XanderUI.XUIButton();
            this.openFileBtn = new XanderUI.XUIButton();
            this.durumLabel = new MetroFramework.Controls.MetroLabel();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.ToplamDurumProgressBar = new XanderUI.XUICircleProgressBar();
            this.CompresserBtn = new XanderUI.XUIButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.xuiFormDesign1.WorkingArea.SuspendLayout();
            this.xuiFormDesign1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xuiFormDesign1
            // 
            this.xuiFormDesign1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.xuiFormDesign1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.xuiFormDesign1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.ExitApplication = true;
            this.xuiFormDesign1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.xuiFormDesign1.FormStyle = XanderUI.XUIFormDesign.Style.MacOS;
            this.xuiFormDesign1.Location = new System.Drawing.Point(0, 0);
            this.xuiFormDesign1.MaterialBackColor = System.Drawing.Color.DodgerBlue;
            this.xuiFormDesign1.MaterialForeColor = System.Drawing.Color.White;
            this.xuiFormDesign1.Name = "xuiFormDesign1";
            this.xuiFormDesign1.ShowMaximize = true;
            this.xuiFormDesign1.ShowMinimize = true;
            this.xuiFormDesign1.Size = new System.Drawing.Size(800, 450);
            this.xuiFormDesign1.TabIndex = 0;
            this.xuiFormDesign1.TitleText = "Toplu Resim Sıkıştırma - V1.0.0";
            // 
            // xuiFormDesign1.WorkingArea
            // 
            this.xuiFormDesign1.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.xuiFormDesign1.WorkingArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.xuiFormDesign1.WorkingArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.metroLabel2);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.indirilenDosyaListBox);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.dosyaListBox);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.metroLabel1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.metroTextBox1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.klasorAcBtn);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.openFileBtn);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.durumLabel);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.progressPanel1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.ToplamDurumProgressBar);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.CompresserBtn);
            this.xuiFormDesign1.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.WorkingArea.Location = new System.Drawing.Point(0, 39);
            this.xuiFormDesign1.WorkingArea.Name = "WorkingArea";
            this.xuiFormDesign1.WorkingArea.Size = new System.Drawing.Size(796, 407);
            this.xuiFormDesign1.WorkingArea.TabIndex = 0;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(495, 47);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(148, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Sıkıştırılmış Dosyalar";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
            this.metroLabel2.UseWaitCursor = true;
            // 
            // indirilenDosyaListBox
            // 
            this.indirilenDosyaListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.indirilenDosyaListBox.FormattingEnabled = true;
            this.indirilenDosyaListBox.ItemHeight = 20;
            this.indirilenDosyaListBox.Location = new System.Drawing.Point(497, 73);
            this.indirilenDosyaListBox.Name = "indirilenDosyaListBox";
            this.indirilenDosyaListBox.Size = new System.Drawing.Size(274, 264);
            this.indirilenDosyaListBox.TabIndex = 13;
            // 
            // dosyaListBox
            // 
            this.dosyaListBox.BackColor = System.Drawing.Color.White;
            this.dosyaListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dosyaListBox.FormattingEnabled = true;
            this.dosyaListBox.ItemHeight = 20;
            this.dosyaListBox.Location = new System.Drawing.Point(29, 73);
            this.dosyaListBox.Name = "dosyaListBox";
            this.dosyaListBox.Size = new System.Drawing.Size(274, 264);
            this.dosyaListBox.TabIndex = 12;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(429, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(61, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "API KEY";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            this.metroLabel1.UseWaitCursor = true;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(253, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(496, 13);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.ShowButton = true;
            this.metroTextBox1.Size = new System.Drawing.Size(275, 23);
            this.metroTextBox1.TabIndex = 10;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.metroTextBox1_KeyUp);
            // 
            // klasorAcBtn
            // 
            this.klasorAcBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.klasorAcBtn.ButtonImage = null;
            this.klasorAcBtn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.klasorAcBtn.ButtonText = "Klasörü Aç";
            this.klasorAcBtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.klasorAcBtn.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.klasorAcBtn.CornerRadius = 7;
            this.klasorAcBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.klasorAcBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.klasorAcBtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.klasorAcBtn.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.klasorAcBtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.klasorAcBtn.Location = new System.Drawing.Point(497, 349);
            this.klasorAcBtn.Name = "klasorAcBtn";
            this.klasorAcBtn.Size = new System.Drawing.Size(275, 50);
            this.klasorAcBtn.TabIndex = 9;
            this.klasorAcBtn.TextColor = System.Drawing.Color.DodgerBlue;
            this.klasorAcBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.klasorAcBtn.Click += new System.EventHandler(this.klasorAcBtn_Click);
            // 
            // openFileBtn
            // 
            this.openFileBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.openFileBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openFileBtn.ButtonImage = null;
            this.openFileBtn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.openFileBtn.ButtonText = "Dosya Seç";
            this.openFileBtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.openFileBtn.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.openFileBtn.CornerRadius = 7;
            this.openFileBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFileBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.openFileBtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.openFileBtn.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.openFileBtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.openFileBtn.Location = new System.Drawing.Point(29, 7);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(275, 50);
            this.openFileBtn.TabIndex = 6;
            this.openFileBtn.TextColor = System.Drawing.Color.DodgerBlue;
            this.openFileBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // durumLabel
            // 
            this.durumLabel.BackColor = System.Drawing.Color.Transparent;
            this.durumLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.durumLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.durumLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.durumLabel.Location = new System.Drawing.Point(368, 95);
            this.durumLabel.Name = "durumLabel";
            this.durumLabel.Size = new System.Drawing.Size(141, 28);
            this.durumLabel.TabIndex = 5;
            this.durumLabel.Text = "Durum";
            this.durumLabel.UseCustomBackColor = true;
            this.durumLabel.UseCustomForeColor = true;
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.BarAnimationElementThickness = 2;
            this.progressPanel1.Caption = "Lütfen Bekleyiniz";
            this.progressPanel1.Description = "Resim Sıkıştırılıyor";
            this.progressPanel1.Location = new System.Drawing.Point(324, 290);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(167, 53);
            this.progressPanel1.TabIndex = 4;
            this.progressPanel1.Text = "progressPanel1";
            this.progressPanel1.Click += new System.EventHandler(this.progressPanel1_Click);
            // 
            // ToplamDurumProgressBar
            // 
            this.ToplamDurumProgressBar.AnimationSpeed = 5;
            this.ToplamDurumProgressBar.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(220)))), ((int)(((byte)(210)))));
            this.ToplamDurumProgressBar.FilledColorAlpha = 130;
            this.ToplamDurumProgressBar.FilledThickness = 40;
            this.ToplamDurumProgressBar.IsAnimated = false;
            this.ToplamDurumProgressBar.Location = new System.Drawing.Point(333, 135);
            this.ToplamDurumProgressBar.Name = "ToplamDurumProgressBar";
            this.ToplamDurumProgressBar.Percentage = 100;
            this.ToplamDurumProgressBar.ShowText = true;
            this.ToplamDurumProgressBar.Size = new System.Drawing.Size(144, 138);
            this.ToplamDurumProgressBar.TabIndex = 1;
            this.ToplamDurumProgressBar.TextColor = System.Drawing.Color.Gray;
            this.ToplamDurumProgressBar.TextSize = 16;
            this.ToplamDurumProgressBar.UnFilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.ToplamDurumProgressBar.UnfilledThickness = 24;
            // 
            // CompresserBtn
            // 
            this.CompresserBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CompresserBtn.ButtonImage = null;
            this.CompresserBtn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.CompresserBtn.ButtonText = "Tümünü Sıkıştır";
            this.CompresserBtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.CompresserBtn.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.CompresserBtn.CornerRadius = 7;
            this.CompresserBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CompresserBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.CompresserBtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.CompresserBtn.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.CompresserBtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.CompresserBtn.Location = new System.Drawing.Point(29, 349);
            this.CompresserBtn.Name = "CompresserBtn";
            this.CompresserBtn.Size = new System.Drawing.Size(275, 50);
            this.CompresserBtn.TabIndex = 0;
            this.CompresserBtn.TextColor = System.Drawing.Color.DodgerBlue;
            this.CompresserBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.CompresserBtn.Click += new System.EventHandler(this.CompresserBtn_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(0, 8);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(119, 23);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.ReadOnlyChecked = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.xuiFormDesign1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.xuiFormDesign1.WorkingArea.ResumeLayout(false);
            this.xuiFormDesign1.WorkingArea.PerformLayout();
            this.xuiFormDesign1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFormDesign xuiFormDesign1;
        private XanderUI.XUIButton CompresserBtn;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
        private XanderUI.XUICircleProgressBar ToplamDurumProgressBar;
        private MetroFramework.Controls.MetroLabel durumLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private XanderUI.XUIButton openFileBtn;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private XanderUI.XUIButton klasorAcBtn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ListBox indirilenDosyaListBox;
        private System.Windows.Forms.ListBox dosyaListBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}

