namespace Timer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            main = new TabControl();
            tabMinutnik = new TabPage();
            Czas = new Label();
            Sectext = new Label();
            Mintext = new Label();
            Minpis = new TextBox();
            Secpis = new TextBox();
            Startbtn = new Button();
            Stopbtn = new Button();
            tabStoper = new TabPage();
            Czas2 = new Label();
            Startbtn2 = new Button();
            Stopbtn2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            Resetbtn = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            main.SuspendLayout();
            tabMinutnik.SuspendLayout();
            tabStoper.SuspendLayout();
            SuspendLayout();
            // 
            // main
            // 
            main.Controls.Add(tabMinutnik);
            main.Controls.Add(tabStoper);
            main.ItemSize = new Size(60, 20);
            main.Location = new Point(-1, 1);
            main.Name = "main";
            main.SelectedIndex = 0;
            main.Size = new Size(801, 453);
            main.TabIndex = 0;
            // 
            // tabMinutnik
            // 
            tabMinutnik.Controls.Add(Czas);
            tabMinutnik.Controls.Add(Sectext);
            tabMinutnik.Controls.Add(Mintext);
            tabMinutnik.Controls.Add(Minpis);
            tabMinutnik.Controls.Add(Secpis);
            tabMinutnik.Controls.Add(Startbtn);
            tabMinutnik.Controls.Add(Stopbtn);
            tabMinutnik.Location = new Point(4, 24);
            tabMinutnik.Name = "tabMinutnik";
            tabMinutnik.Padding = new Padding(3);
            tabMinutnik.Size = new Size(793, 425);
            tabMinutnik.TabIndex = 0;
            tabMinutnik.Text = "Minutnik";
            tabMinutnik.UseVisualStyleBackColor = true;
            // 
            // Czas
            // 
            Czas.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Czas.Location = new Point(276, 287);
            Czas.Name = "Czas";
            Czas.Size = new Size(208, 60);
            Czas.TabIndex = 6;
            Czas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Sectext
            // 
            Sectext.AutoSize = true;
            Sectext.Location = new Point(477, 107);
            Sectext.Name = "Sectext";
            Sectext.Size = new Size(52, 15);
            Sectext.TabIndex = 5;
            Sectext.Text = "Sekundy";
            // 
            // Mintext
            // 
            Mintext.AutoSize = true;
            Mintext.Location = new Point(245, 107);
            Mintext.Name = "Mintext";
            Mintext.Size = new Size(45, 15);
            Mintext.TabIndex = 4;
            Mintext.Text = "Minuty";
            Mintext.Click += label1_Click;
            // 
            // Minpis
            // 
            Minpis.Location = new Point(187, 125);
            Minpis.Name = "Minpis";
            Minpis.Size = new Size(171, 23);
            Minpis.TabIndex = 3;
            // 
            // Secpis
            // 
            Secpis.Location = new Point(426, 125);
            Secpis.Name = "Secpis";
            Secpis.Size = new Size(171, 23);
            Secpis.TabIndex = 2;
            // 
            // Startbtn
            // 
            Startbtn.Location = new Point(239, 205);
            Startbtn.Name = "Startbtn";
            Startbtn.Size = new Size(119, 36);
            Startbtn.TabIndex = 1;
            Startbtn.Text = "Start";
            Startbtn.UseVisualStyleBackColor = true;
            // 
            // Stopbtn
            // 
            Stopbtn.Location = new Point(426, 205);
            Stopbtn.Name = "Stopbtn";
            Stopbtn.Size = new Size(119, 36);
            Stopbtn.TabIndex = 0;
            Stopbtn.Text = "Stop";
            Stopbtn.UseVisualStyleBackColor = true;
            Stopbtn.Click += button1_Click;
            // 
            // tabStoper
            // 
            tabStoper.Controls.Add(Resetbtn);
            tabStoper.Controls.Add(Czas2);
            tabStoper.Controls.Add(Startbtn2);
            tabStoper.Controls.Add(Stopbtn2);
            tabStoper.Location = new Point(4, 24);
            tabStoper.Name = "tabStoper";
            tabStoper.Padding = new Padding(3);
            tabStoper.Size = new Size(793, 425);
            tabStoper.TabIndex = 1;
            tabStoper.Text = "Stoper";
            tabStoper.UseVisualStyleBackColor = true;
            // 
            // Czas2
            // 
            Czas2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Czas2.Location = new Point(284, 129);
            Czas2.Name = "Czas2";
            Czas2.Size = new Size(204, 60);
            Czas2.TabIndex = 13;
            Czas2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Startbtn2
            // 
            Startbtn2.Location = new Point(174, 192);
            Startbtn2.Name = "Startbtn2";
            Startbtn2.Size = new Size(115, 36);
            Startbtn2.TabIndex = 8;
            Startbtn2.Text = "Start";
            Startbtn2.UseVisualStyleBackColor = true;
            // 
            // Stopbtn2
            // 
            Stopbtn2.Location = new Point(331, 192);
            Stopbtn2.Name = "Stopbtn2";
            Stopbtn2.Size = new Size(115, 36);
            Stopbtn2.TabIndex = 7;
            Stopbtn2.Text = "Stop";
            Stopbtn2.UseVisualStyleBackColor = true;
            // 
            // Resetbtn
            // 
            Resetbtn.Location = new Point(482, 192);
            Resetbtn.Name = "Resetbtn";
            Resetbtn.Size = new Size(115, 36);
            Resetbtn.TabIndex = 14;
            Resetbtn.Text = "Reset";
            Resetbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(main);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            main.ResumeLayout(false);
            tabMinutnik.ResumeLayout(false);
            tabMinutnik.PerformLayout();
            tabStoper.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl main;
        private TabPage tabMinutnik;
        private TabPage tabStoper;
        private Label Czas;
        private Label Sectext;
        private Label Mintext;
        private TextBox Minpis;
        private TextBox Secpis;
        private Button Startbtn;
        private Button Stopbtn;
        private System.Windows.Forms.Timer timer1;
        private Label Czas2;
        private Button Startbtn2;
        private Button Stopbtn2;
        private Button Resetbtn;
        private System.Windows.Forms.Timer timer2;
    }
}
