namespace Timer
{
    public partial class Form1 : Form
    {
        int stoperM = 0, stoperS = 0;
        int minutnikM = 0, minutnikS = 0;
 
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer2.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer2.Tick += timer2_Tick;
 
            Startbtn.Click += Startbtn_Click;
            Stopbtn.Click += Stopbtn_Click;
            Startbtn2.Click += Startbtn2_Click;
            Stopbtn2.Click += Stopbtn2_Click;
            Resetbtn.Click += Resetbtn_Click;
        }
 
        private void Startbtn2_Click(object sender, EventArgs e) => timer1.Start();
 
        private void Stopbtn2_Click(object sender, EventArgs e) => timer1.Stop();
 
        private void Resetbtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            stoperM = 0;
            stoperS = 0;
            Czas2.Text = "00:00";
        }
 
        private void timer1_Tick(object sender, EventArgs e)
        {
            stoperS++;
            if (stoperS >= 60) { stoperM++; stoperS = 0; }
            Czas2.Text = string.Format("{0:D2}:{1:D2}", stoperM, stoperS);
        }
 
        private void Startbtn_Click(object sender, EventArgs e)
        {
            int.TryParse(Minpis.Text, out minutnikM);
            int.TryParse(Secpis.Text, out minutnikS);
            if (minutnikM > 0 || minutnikS > 0) timer2.Start();
            else timer2.Stop();
        }
 
        private void Stopbtn_Click(object sender, EventArgs e) => timer2.Stop();
 
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (minutnikS <= 0)
            {
                if (minutnikM > 0) { minutnikM--; minutnikS = 59; }
                else { timer2.Stop(); MessageBox.Show("gg"); return; }
            }
            else { minutnikS--; }
            Czas.Text = string.Format("{0:D2}:{1:D2}", minutnikM, minutnikS);
        }
 
        private void Form1_Load(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }
}
