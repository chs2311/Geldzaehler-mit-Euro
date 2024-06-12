using System;
using System.Diagnostics;
using System.ComponentModel;

namespace Geldzähler_mit_Euro_4._0
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form23 login = new Form23();
            if (login.ShowDialog() == DialogResult.OK)
            {
                label19.Text = login.Pin;
            }  

            Summe.Text = "0";
            ausgabe.Text = "0";
            kontostand.Text = "0";

            wert1.Text = "0";
            wert2.Text = "0";
            wert3.Text = "0";
            wert4.Text = "0";
            wert5.Text = "0";
            wert6.Text = "0";
            wert7.Text = "0";
            wert8.Text = "0";
            wert9.Text = "0";
            wert10.Text = "0";
            wert11.Text = "0";
            wert12.Text = "0";
            wert13.Text = "0";
            wert14.Text = "0";

            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void ausgabenHinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ausgaben.Visible = true;
            ausgabe.Visible = true;
            cent1.Visible = true;
            ausgabe.Text = "0";

        }

        private void kontostandHinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            konto.Visible = true;
            kontostand.Visible = true;
            cent2.Visible = true;
            kontostand.Text = "0";
            
        }

        private void informationenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            if(frm2.ShowDialog() == DialogResult.OK)
            {
                //NOTHING
            }
        }

        private void hilfeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            if (frm3.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void nachDickeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 dicke = new Form4();
            if (dicke.ShowDialog() == DialogResult.OK)
            {
                Int64 nachdicke1 = Convert.ToInt64(dicke.dicke1) / Convert.ToInt64(1);
                Int64 nachdicke2 = Convert.ToInt64(dicke.dicke2) / Convert.ToInt64(1);
                Int64 nachdicke3 = Convert.ToInt64(dicke.dicke3) / Convert.ToInt64(1);
                Int64 nachdicke4 = Convert.ToInt64(dicke.dicke4) / Convert.ToInt64(2);
                Int64 nachdicke5 = Convert.ToInt64(dicke.dicke5) / Convert.ToInt64(2);
                Int64 nachdicke6 = Convert.ToInt64(dicke.dicke6) / Convert.ToInt64(2);
                Int64 nachdicke7 = Convert.ToInt64(dicke.dicke7) / Convert.ToInt64(2);
                Int64 nachdicke8 = Convert.ToInt64(dicke.dicke8) / Convert.ToInt64(2);

                Int64 anzahlinwert1 = Convert.ToInt64(nachdicke1) * Convert.ToInt64(1);
                Int64 anzahlinwert2 = Convert.ToInt64(nachdicke2) * Convert.ToInt64(2);
                Int64 anzahlinwert3 = Convert.ToInt64(nachdicke3) * Convert.ToInt64(5);
                Int64 anzahlinwert4 = Convert.ToInt64(nachdicke4) * Convert.ToInt64(10);
                Int64 anzahlinwert5 = Convert.ToInt64(nachdicke5) * Convert.ToInt64(20);
                Int64 anzahlinwert6 = Convert.ToInt64(nachdicke6) * Convert.ToInt64(50);
                Int64 anzahlinwert7 = Convert.ToInt64(nachdicke7) * Convert.ToInt64(100);
                Int64 anzahlinwert8 = Convert.ToInt64(nachdicke8) * Convert.ToInt64(200);

                string ausgabedicke1 = anzahlinwert1 + "";
                string ausgabedicke2 = anzahlinwert2 + "";
                string ausgabedicke3 = anzahlinwert3 + "";
                string ausgabedicke4 = anzahlinwert4 + "";
                string ausgabedicke5 = anzahlinwert5 + "";
                string ausgabedicke6 = anzahlinwert6 + "";
                string ausgabedicke7 = anzahlinwert7 + "";
                string ausgabedicke8 = anzahlinwert8 + "";

                wert1.Text = ausgabedicke1;
                wert2.Text = ausgabedicke2;
                wert3.Text = ausgabedicke3;
                wert4.Text = ausgabedicke4;
                wert5.Text = ausgabedicke5;
                wert6.Text = ausgabedicke6;
                wert7.Text = ausgabedicke7;
                wert8.Text = ausgabedicke8;
            }
        }

        private void nachGewichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 gewicht = new Form5();
            if(gewicht.ShowDialog() == DialogResult.OK)
            {
                Int64 nachgewicht1 = Convert.ToInt64(gewicht.gewicht1) / Convert.ToInt64(2);
                Int64 nachgewicht2 = Convert.ToInt64(gewicht.gewicht2) / Convert.ToInt64(3);
                Int64 nachgewicht3 = Convert.ToInt64(gewicht.gewicht3) / Convert.ToInt64(4);
                Int64 nachgewicht4 = Convert.ToInt64(gewicht.gewicht4) / Convert.ToInt64(4);
                Int64 nachgewicht5 = Convert.ToInt64(gewicht.gewicht5) / Convert.ToInt64(5);
                Int64 nachgewicht6 = Convert.ToInt64(gewicht.gewicht6) / Convert.ToInt64(8);
                Int64 nachgewicht7 = Convert.ToInt64(gewicht.gewicht7) / Convert.ToInt64(7);
                Int64 nachgewicht8 = Convert.ToInt64(gewicht.gewicht8) / Convert.ToInt64(8);

                Int64 anzahlzuwert1 = Convert.ToInt64(nachgewicht1) * Convert.ToInt64(1);
                Int64 anzahlzuwert2 = Convert.ToInt64(nachgewicht2) * Convert.ToInt64(2);
                Int64 anzahlzuwert3 = Convert.ToInt64(nachgewicht3) * Convert.ToInt64(5);
                Int64 anzahlzuwert4 = Convert.ToInt64(nachgewicht4) * Convert.ToInt64(10);
                Int64 anzahlzuwert5 = Convert.ToInt64(nachgewicht5) * Convert.ToInt64(20);
                Int64 anzahlzuwert6 = Convert.ToInt64(nachgewicht6) * Convert.ToInt64(50);
                Int64 anzahlzuwert7 = Convert.ToInt64(nachgewicht7) * Convert.ToInt64(100);
                Int64 anzahlzuwert8 = Convert.ToInt64(nachgewicht8) * Convert.ToInt64(200);

                string ausgabegewicht1 = anzahlzuwert1 + "";
                string ausgabegewicht2 = anzahlzuwert2 + "";
                string ausgabegewicht3 = anzahlzuwert3 + "";
                string ausgabegewicht4 = anzahlzuwert4 + "";
                string ausgabegewicht5 = anzahlzuwert5 + "";
                string ausgabegewicht6 = anzahlzuwert6 + "";
                string ausgabegewicht7 = anzahlzuwert7 + "";
                string ausgabegewicht8 = anzahlzuwert8 + "";

                wert1.Text = ausgabegewicht1;
                wert2.Text = ausgabegewicht2;
                wert3.Text = ausgabegewicht3;
                wert4.Text = ausgabegewicht4;
                wert5.Text = ausgabegewicht5;
                wert6.Text = ausgabegewicht6;
                wert7.Text = ausgabegewicht7;
                wert8.Text = ausgabegewicht8;

            }
        }

        private void euroZuDollarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void euroDollarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 dollar = new Form6();
            if (dollar.ShowDialog() == DialogResult.OK)
            {
                
            }
           
        }

        private void euroYenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 pfund = new Form7();
            if (pfund.ShowDialog() == DialogResult.OK)
            {
               
            }
           
        }

        private void berechnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cent1 = wert1.Text;
            string cent2 = wert2.Text;
            string cent5 = wert3.Text;
            string cent10 = wert4.Text;
            string cent20 = wert5.Text;
            string cent50 = wert6.Text;
            string cent100 = wert7.Text;
            string cent200 = wert8.Text;
            string euro5 = wert9.Text;
            string euro10 = wert10.Text;
            string euro20 = wert11.Text;
            string euro50 = wert12.Text;
            string euro100 = wert13.Text;
            string euro200 = wert14.Text;

            long result1 = Convert.ToInt64(cent1) + Convert.ToInt64(cent2) + Convert.ToInt64(cent5) + Convert.ToInt64(cent10) + Convert.ToInt64(cent20) + Convert.ToInt64(cent50) + Convert.ToInt64(cent100) + Convert.ToInt64(cent200);
            long result2 = Convert.ToInt64(euro5) + Convert.ToInt64(euro10) + Convert.ToInt64(euro20) + Convert.ToInt64(euro50) + Convert.ToInt64(euro100) + Convert.ToInt64(euro200);
            long summe = Convert.ToInt64(result1) + Convert.ToInt64(result2);

            string Gesamtsumme = summe.ToString();
            Summe.Text = Gesamtsumme;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            if(frm9.ShowDialog() == DialogResult.OK)
            {
                Int64 centOne = Convert.ToInt64(frm9.geld) * Convert.ToInt64(1);
                string ct1 = centOne + "";
                wert1.Text = ct1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 frm10 = new Form10();
            if (frm10.ShowDialog() == DialogResult.OK)
            {
                Int64 centTwo = Convert.ToInt64(frm10.geld) * Convert.ToInt64(2);
                string ct2 = centTwo + "";
                wert2.Text = ct2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form11 frm11 = new Form11();
            if (frm11.ShowDialog() == DialogResult.OK)
            {
                Int64 centFive = Convert.ToInt64(frm11.geld) * Convert.ToInt64(15);
                string ct5 = centFive + "";
                wert3.Text = ct5;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form12 frm12 = new Form12();
            if (frm12.ShowDialog() == DialogResult.OK)
            {
                Int64 centTen = Convert.ToInt64(frm12.geld) * Convert.ToInt64(10);
                string ct10 = centTen + "";
                wert4.Text = ct10;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form13 frm13 = new Form13();
            if (frm13.ShowDialog() == DialogResult.OK)
            {
                Int64 centTwenty = Convert.ToInt64(frm13.geld) * Convert.ToInt64(20);
                string ct20 = centTwenty + "";
                wert5.Text = ct20;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form14 frm14 = new Form14();
            if (frm14.ShowDialog() == DialogResult.OK)
            {
                Int64 centFifty = Convert.ToInt64(frm14.geld) * Convert.ToInt64(50);
                string ct50 = centFifty + "";
                wert6.Text = ct50;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form15 frm15 = new Form15();
            if (frm15.ShowDialog() == DialogResult.OK)
            {
                Int64 euroOne = Convert.ToInt64(frm15.geld) * Convert.ToInt64(100);
                string eu1 = euroOne + "";
                wert7.Text = eu1;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form16 frm16 = new Form16();
            if (frm16.ShowDialog() == DialogResult.OK)
            {
                Int64 euroTwo = Convert.ToInt64(frm16.geld) * Convert.ToInt64(200);
                string eu2 = euroTwo + "";
                wert8.Text = eu2;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form17 frm17 = new Form17();
            if (frm17.ShowDialog() == DialogResult.OK)
            {
                Int64 euroFive = Convert.ToInt64(frm17.geld) * Convert.ToInt64(500);
                string eu5 = euroFive + "";
                wert9.Text = eu5;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form18 frm18 = new Form18();
            if (frm18.ShowDialog() == DialogResult.OK)
            {
                Int64 euroTen = Convert.ToInt64(frm18.geld) * Convert.ToInt64(1000);
                string eu10 = euroTen + "";
                wert10.Text = eu10;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form19 frm19 = new Form19();
            if (frm19.ShowDialog() == DialogResult.OK)
            {
                Int64 euroTwenty = Convert.ToInt64(frm19.geld) * Convert.ToInt64(2000);
                string eu20 = euroTwenty + "";
                wert11.Text = eu20;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form20 frm20 = new Form20();
            if (frm20.ShowDialog() == DialogResult.OK)
            {
                Int64 euroFifty = Convert.ToInt64(frm20.geld) * Convert.ToInt64(5000);
                string eu50 = euroFifty + "";
                wert12.Text = eu50;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form21 frm21 = new Form21();
            if (frm21.ShowDialog() == DialogResult.OK)
            {
                Int64 euroHundred = Convert.ToInt64(frm21.geld) * Convert.ToInt64(10000);
                string eu100 = euroHundred + "";
                wert13.Text = eu100;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form22 frm22 = new Form22();
            if (frm22.ShowDialog() == DialogResult.OK)
            {
                Int64 euroTwoHundred = Convert.ToInt64(frm22.geld) * Convert.ToInt64(20000);
                string eu200 = euroTwoHundred + "";
                wert14.Text = eu200;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
 

            
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void geldstand1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Userdaten US = new Userdaten();

            US.cent1 = wert1.Text;
            US.cent2 = wert2.Text;
            US.cent5 = wert3.Text;
            US.cent10 = wert4.Text;
            US.cent20 = wert5.Text;
            US.cent50 = wert6.Text;
            US.euro1 = wert7.Text;
            US.euro2 = wert8.Text;
            US.euro5 = wert9.Text;
            US.euro10 = wert10.Text;
            US.euro20 = wert11.Text;
            US.euro50 = wert12.Text;
            US.euro100 = wert13.Text;
            US.euro200 = wert14.Text;
            US.Alles = Summe.Text;

            US.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Geldstand1chs.cash");
        }

        private void geldstand2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Userdaten US = new Userdaten();

            US.cent1 = wert1.Text;
            US.cent2 = wert2.Text;
            US.cent5 = wert3.Text;
            US.cent10 = wert4.Text;
            US.cent20 = wert5.Text;
            US.cent50 = wert6.Text;
            US.euro1 = wert7.Text;
            US.euro2 = wert8.Text;
            US.euro5 = wert9.Text;
            US.euro10 = wert10.Text;
            US.euro20 = wert11.Text;
            US.euro50 = wert12.Text;
            US.euro100 = wert13.Text;
            US.euro200 = wert14.Text;
            US.Alles = Summe.Text;

            US.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Geldstand2chs.cash");
        }
    

        private void geldstand3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Userdaten US = new Userdaten();

            US.cent1 = wert1.Text;
            US.cent2 = wert2.Text;
            US.cent5 = wert3.Text;
            US.cent10 = wert4.Text;
            US.cent20 = wert5.Text;
            US.cent50 = wert6.Text;
            US.euro1 = wert7.Text;
            US.euro2 = wert8.Text;
            US.euro5 = wert9.Text;
            US.euro10 = wert10.Text;
            US.euro20 = wert11.Text;
            US.euro50 = wert12.Text;
            US.euro100 = wert13.Text;
            US.euro200 = wert14.Text;
            US.Alles = Summe.Text;

            US.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Geldstand3chs.cash");
        }

        private void geldstand1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Userdaten US = new Userdaten();
            US = US.Load(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Geldstand1chs.cash");

            wert1.Text = US.cent1;
            wert2.Text = US.cent2;
            wert3.Text = US.cent5;
            wert4.Text = US.cent10;
            wert5.Text = US.cent20;
            wert6.Text = US.cent50;
            wert7.Text = US.euro1;
            wert8.Text = US.euro2;
            wert9.Text = US.euro5;
            wert10.Text = US.euro10;
            wert11.Text = US.euro20;
            wert12.Text = US.euro50;
            wert13.Text = US.euro100;
            wert14.Text = US.euro200;
        }

        private void geldstand2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Userdaten US = new Userdaten();
            US = US.Load(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Geldstand2chs.cash");

            wert1.Text = US.cent1;
            wert2.Text = US.cent2;
            wert3.Text = US.cent5;
            wert4.Text = US.cent10;
            wert5.Text = US.cent20;
            wert6.Text = US.cent50;
            wert7.Text = US.euro1;
            wert8.Text = US.euro2;
            wert9.Text = US.euro5;
            wert10.Text = US.euro10;
            wert11.Text = US.euro20;
            wert12.Text = US.euro50;
            wert13.Text = US.euro100;
            wert14.Text = US.euro200;
        }

        private void geldstand3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Userdaten US = new Userdaten();
            US = US.Load(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Geldstand3chs.cash");

            wert1.Text = US.cent1;
            wert2.Text = US.cent2;
            wert3.Text = US.cent5;
            wert4.Text = US.cent10;
            wert5.Text = US.cent20;
            wert6.Text = US.cent50;
            wert7.Text = US.euro1;
            wert8.Text = US.euro2;
            wert9.Text = US.euro5;
            wert10.Text = US.euro10;
            wert11.Text = US.euro20;
            wert12.Text = US.euro50;
            wert13.Text = US.euro100;
            wert14.Text = US.euro200;
        }

        private void ergänzungenEinberechnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string plus = kontostand.Text;
            string minus = ausgabe.Text;
            string davor = Summe.Text;
            Int64 mitkram = (Convert.ToInt64(davor) + Convert.ToInt64(plus)) - Convert.ToInt64(minus);
            string res1 = mitkram.ToString();
            Summe.Text = res1;
        }

        private void ergänzungenEntfernenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string kon = kontostand.Text;
            string aus = ausgabe.Text;
            string sum = Summe.Text;
            Int64 entf = (Convert.ToInt64(sum) - Convert.ToInt64(kon)) + Convert.ToInt64(aus);
            string res2 = entf.ToString();
            Summe.Text = res2;
        }
    }
}