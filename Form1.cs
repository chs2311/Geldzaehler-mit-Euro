//Programmed by Christian
//Geldrechner mit Euro
namespace Geldzähler_mit_Euro_3._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Gesamt7.Text = " You found a secret! ";
        }

        
        private void plus1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            if (frm2.ShowDialog() == DialogResult.OK)
            {
                long result1 = Convert.ToInt64(1) * frm2.cent1;
                string OneCent = result1.ToString();
                Gesamt1.Text = OneCent;
            }
        }

        private void plus2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            if(frm3.ShowDialog() == DialogResult.OK)
            {
                long result2 = Convert.ToInt64(2) * frm3.cent2;
                string TwoCent = result2.ToString();
                Gesamt2.Text = TwoCent;
            }
        }

        private void plus3_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            if (frm4.ShowDialog() == DialogResult.OK)
            {
                long result3 = Convert.ToInt64(5) * frm4.cent5;
                string FiveCent = result3.ToString();
                Gesamt3.Text = FiveCent;
            }
        }

        private void plus4_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            if (frm5.ShowDialog() == DialogResult.OK)
            {
                long result4 = Convert.ToInt64(10) * frm5.cent10;
                string TenCent = result4.ToString();
                Gesamt4.Text = TenCent;
            }
        }

        private void plus5_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            if (frm6.ShowDialog() == DialogResult.OK)
            {
                long result5 = Convert.ToInt64(20) * frm6.cent20;
                string TwentyCent = result5.ToString();
                Gesamt5.Text = TwentyCent;
            }
        }

        private void plus6_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            if (frm7.ShowDialog() == DialogResult.OK)
            {
                long result6 = Convert.ToInt64(50) * frm7.cent50;
                string FiftyCent = result6.ToString();
                Gesamt6.Text = FiftyCent;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

     
            Gesamt1.Text = "0";
            Gesamt2.Text = "0";
            Gesamt3.Text = "0";
            Gesamt4.Text = "0";
            Gesamt5.Text = "0";
            Gesamt6.Text = "0";
            Gesamt7.Text = "0";
            Gesamt8.Text = "0";
            Gesamt9.Text = "0";
            Gesamt10.Text = "0";
            Gesamt11.Text = "0";
            Gesamt12.Text = "0";
            Gesamt13.Text = "0";
            Gesamt14.Text = "0";
            Summe.Text = "0";
        }

        private void plus7_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            if (frm8.ShowDialog() == DialogResult.OK)
            {
                long result7 = Convert.ToInt64(100) * frm8.euro1;
                string OneEuro = result7.ToString();
                Gesamt7.Text = OneEuro;
            }
        }

        private void plus8_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            if (frm9.ShowDialog() == DialogResult.OK)
            {
                long result8 = Convert.ToInt64(200) * frm9.euro2;
                string TwoEuro = result8.ToString();
                Gesamt8.Text = TwoEuro;
            }
        }

        private void plus9_Click(object sender, EventArgs e)
        {
            Form10 frm10 = new Form10();
            if (frm10.ShowDialog() == DialogResult.OK)
            {
                long result9 = Convert.ToInt64(500) * frm10.euro5;
                string FiveEuro = result9.ToString();
                Gesamt9.Text = FiveEuro;
            }
        }

        private void plus10_Click(object sender, EventArgs e)
        {
            Form11 frm11 = new Form11();
            if (frm11.ShowDialog() == DialogResult.OK)
            {
                long result10 = Convert.ToInt64(1000) * frm11.euro10;
                string TenEuro = result10.ToString();
                Gesamt10.Text = TenEuro;
            }
        }

        private void plus11_Click(object sender, EventArgs e)
        {
            Form12 frm12 = new Form12();
            if (frm12.ShowDialog() == DialogResult.OK)
            {
                long result11 = Convert.ToInt64(2000) * frm12.euro20;
                string TwentyEuro = result11.ToString();
                Gesamt11.Text = TwentyEuro;
            }
        }

        private void plus12_Click(object sender, EventArgs e)
        {
            Form13 frm13 = new Form13();
            if (frm13.ShowDialog() == DialogResult.OK)
            {
                long result12 = Convert.ToInt64(5000) * frm13.euro50;
                string FiftyEuro = result12.ToString();
                Gesamt12.Text = FiftyEuro;
            }
        }

        private void plus13_Click(object sender, EventArgs e)
        {
            Form14 frm14 = new Form14();
            if (frm14.ShowDialog() == DialogResult.OK)
            {
                long result13 = Convert.ToInt64(10000) * frm14.euro100;
                string HundredEuro = result13.ToString();
                Gesamt13.Text = HundredEuro;
            }
        }

        private void plus14_Click(object sender, EventArgs e)
        {
            Form15 frm15 = new Form15();
            if (frm15.ShowDialog() == DialogResult.OK)
            {
                long result14 = Convert.ToInt64(20000) * frm15.euro200;
                string TwoHundredEuro = result14.ToString();
                Gesamt14.Text = TwoHundredEuro;
            }
        }

        private void berechnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //EINZELWERTE
            string a = Gesamt1.Text;
            string b = Gesamt2.Text;
            string c = Gesamt3.Text;
            string d = Gesamt4.Text;
            string f = Gesamt5.Text;
            string g = Gesamt6.Text;
            string h = Gesamt7.Text;
            string i = Gesamt8.Text;
            string j = Gesamt9.Text;
            string k = Gesamt10.Text;
            string l = Gesamt11.Text;
            string m = Gesamt12.Text;
            string n = Gesamt13.Text;
            string o = Gesamt14.Text;

            //GESAMTWERT
            Int64 result1 = Convert.ToInt64(a) + Convert.ToInt64(b) + Convert.ToInt64(c) + Convert.ToInt64(d) + Convert.ToInt64(f) + Convert.ToInt64(g) + Convert.ToInt64(h) + Convert.ToInt64(i) + Convert.ToInt64(j);
            Int64 result2 = Convert.ToInt64(k) + Convert.ToInt64(l) + Convert.ToInt64(m) + Convert.ToInt64(n) + Convert.ToInt64(o);
            Int64 result = Convert.ToInt64(result1) + Convert.ToInt64(result2);
            string summe = result.ToString();
            Summe.Text = summe;
        }

        private void informationenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form16 frm16 = new Form16();
            if (frm16.ShowDialog() == DialogResult.OK)
            {
                //NOTHING
            }
        }

        private void hilfeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form17 frm17 = new Form17();
            if (frm17.ShowDialog() == DialogResult.OK)
            {
                //NOTHING
            }
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ladenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void geldstand1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Userdaten US = new Userdaten();

            US.cash1 = Gesamt1.Text;
            US.cash2 = Gesamt2.Text;
            US.cash3 = Gesamt3.Text;
            US.cash4 = Gesamt4.Text;
            US.cash5 = Gesamt5.Text;
            US.cash6 = Gesamt6.Text;
            US.cash7 = Gesamt7.Text;
            US.cash8 = Gesamt8.Text;
            US.cash9 = Gesamt9.Text;
            US.cash10 = Gesamt10.Text;
            US.cash11 = Gesamt11.Text;
            US.cash12 = Gesamt12.Text;
            US.cash13 = Gesamt13.Text;
            US.cash14 = Gesamt14.Text;
            US.Geldstand = Summe.Text;

            US.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Geldstand1.cash");
        }

        private void geldstand2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Userdaten US = new Userdaten();

            US.cash1 = Gesamt1.Text;
            US.cash2 = Gesamt2.Text;
            US.cash3 = Gesamt3.Text;
            US.cash4 = Gesamt4.Text;
            US.cash5 = Gesamt5.Text;
            US.cash6 = Gesamt6.Text;
            US.cash7 = Gesamt7.Text;
            US.cash8 = Gesamt8.Text;
            US.cash9 = Gesamt9.Text;
            US.cash10 = Gesamt10.Text;
            US.cash11 = Gesamt11.Text;
            US.cash12 = Gesamt12.Text;
            US.cash13 = Gesamt13.Text;
            US.cash14 = Gesamt14.Text;
            US.Geldstand = Summe.Text;

            US.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Geldstand2.cash");
        }

        private void geldstand3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Userdaten US = new Userdaten();

            US.cash1 = Gesamt1.Text;
            US.cash2 = Gesamt2.Text;
            US.cash3 = Gesamt3.Text;
            US.cash4 = Gesamt4.Text;
            US.cash5 = Gesamt5.Text;
            US.cash6 = Gesamt6.Text;
            US.cash7 = Gesamt7.Text;
            US.cash8 = Gesamt8.Text;
            US.cash9 = Gesamt9.Text;
            US.cash10 = Gesamt10.Text;
            US.cash11 = Gesamt11.Text;
            US.cash12 = Gesamt12.Text;
            US.cash13 = Gesamt13.Text;
            US.cash14 = Gesamt14.Text;
            US.Geldstand = Summe.Text;

            US.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Geldstand3.cash");
        }

        private void geldstand1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Userdaten US = new Userdaten();
            US = US.Load(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Geldstand1.cash");

            Gesamt1.Text = US.cash1;
            Gesamt2.Text = US.cash2;
            Gesamt3.Text = US.cash3;
            Gesamt4.Text = US.cash4;
            Gesamt5.Text = US.cash5;
            Gesamt6.Text = US.cash6;
            Gesamt7.Text = US.cash7;
            Gesamt8.Text = US.cash8;
            Gesamt9.Text = US.cash9;
            Gesamt10.Text = US.cash10;
            Gesamt11.Text = US.cash11;
            Gesamt12.Text = US.cash12;
            Gesamt13.Text = US.cash13;
            Gesamt14.Text = US.cash14;
            Summe.Text = US.Geldstand;
        }

        private void geldstand2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Userdaten US = new Userdaten();
            US = US.Load(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Geldstand2.cash");

            Gesamt1.Text = US.cash1;
            Gesamt2.Text = US.cash2;
            Gesamt3.Text = US.cash3;
            Gesamt4.Text = US.cash4;
            Gesamt5.Text = US.cash5;
            Gesamt6.Text = US.cash6;
            Gesamt7.Text = US.cash7;
            Gesamt8.Text = US.cash8;
            Gesamt9.Text = US.cash9;
            Gesamt10.Text = US.cash10;
            Gesamt11.Text = US.cash11;
            Gesamt12.Text = US.cash12;
            Gesamt13.Text = US.cash13;
            Gesamt14.Text = US.cash14;
            Summe.Text = US.Geldstand;
        }

        private void geldstand3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Userdaten US = new Userdaten();
            US = US.Load(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Geldstand3.cash");

            Gesamt1.Text = US.cash1;
            Gesamt2.Text = US.cash2;
            Gesamt3.Text = US.cash3;
            Gesamt4.Text = US.cash4;
            Gesamt5.Text = US.cash5;
            Gesamt6.Text = US.cash6;
            Gesamt7.Text = US.cash7;
            Gesamt8.Text = US.cash8;
            Gesamt9.Text = US.cash9;
            Gesamt10.Text = US.cash10;
            Gesamt11.Text = US.cash11;
            Gesamt12.Text = US.cash12;
            Gesamt13.Text = US.cash13;
            Gesamt14.Text = US.cash14;
            Summe.Text = US.Geldstand;
        }
    }
}