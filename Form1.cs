using System.Diagnostics;

namespace Geldzähler_mit_Euro           //C#, (c) Christian Schlei
{
    public partial class Form1 : Form
    {
        public string user { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        #region Main
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void bachgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vordergrundfarbenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            if (frm2.ShowDialog() == DialogResult.OK)
            {
                //Einzelwerte
                textBox1.Text = "0";
                textBox2.Text = "0";
                textBox3.Text = "0";
                textBox4.Text = "0";
                textBox5.Text = "0";
                textBox6.Text = "0";
                textBox7.Text = "0";
                textBox8.Text = "0";
                textBox9.Text = "0";
                textBox10.Text = "0";
                textBox11.Text = "0";
                textBox12.Text = "0";
                textBox13.Text = "0";
                textBox14.Text = "0";

                //Sonstige und Summe
                Summe.Text = "0";
                ausgaben.Text = "0";
                kontostand.Text = "0";

                Form14 login = new Form14();
                if (login.ShowDialog() == DialogResult.OK)
                {
                    label19.Text = login.name;
                    abmeldenToolStripMenuItem.Text = "Abmelden";
                    user = label19.Text;
                    Privatemode();
                }
                else
                {
                    label19.Text = "XXX";
                    user = label19.Text;
                    Publicmode();
                }

                if (label19.Text == "XXX")
                {
                    abmeldenToolStripMenuItem.Text = "Anmelden";
                    user = label19.Text;
                    Publicmode();
                }
            }
            else
            {
                //Einzelwerte
                textBox1.Text = "0";
                textBox2.Text = "0";
                textBox3.Text = "0";
                textBox4.Text = "0";
                textBox5.Text = "0";
                textBox6.Text = "0";
                textBox7.Text = "0";
                textBox8.Text = "0";
                textBox9.Text = "0";
                textBox10.Text = "0";
                textBox11.Text = "0";
                textBox12.Text = "0";
                textBox13.Text = "0";
                textBox14.Text = "0";

                //Sonstige und Summe
                Summe.Text = "0";
                ausgaben.Text = "0";
                kontostand.Text = "0";
            }


        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form35 areyousure = new Form35();
            
            if(areyousure.ShowDialog() == DialogResult.OK)
            {
                Speichern(sender, e);
                this.Close();
            }
            if (areyousure.ShowDialog() == DialogResult.Continue)
            {
                this.Close();
            }
            if (areyousure.ShowDialog() == DialogResult.Cancel)
            {
                
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Einzelwerte
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";
            textBox12.Text = "0";
            textBox13.Text = "0";
            textBox14.Text = "0";

            //Sonstige und Summe
            Summe.Text = "0";
            ausgaben.Text = "0";
            kontostand.Text = "0";
        }

        private void abmeldenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 login = new Form14(); 
            if (login.ShowDialog() == DialogResult.OK)
            {
                label19.Text = login.name;
                abmeldenToolStripMenuItem.Text = "Abmelden";
                resetToolStripMenuItem_Click(sender, e);
                user = label19.Text;
                Privatemode();

            }
            else
            {
                label19.Text = "XXX";
                user = label19.Text;
                Publicmode();
            }

            if (label19.Text == "XXX")
            {
                abmeldenToolStripMenuItem.Text = "Anmelden";
                user = label19.Text;
                Publicmode();
            }
        }

        private void Publicmode()
        {
            starteProgrammToolStripMenuItem.Visible = false;
            toolsToolStripMenuItem.Visible = false;
            umrechnerToolStripMenuItem.Visible = false;
            backcolor.Visible = false;
            forecolor.Visible = false;
            load.Visible = false;
        }

        private void Privatemode()
        {
            starteProgrammToolStripMenuItem.Visible = true;
            toolsToolStripMenuItem.Visible = true;
            umrechnerToolStripMenuItem.Visible = true;
            backcolor.Visible = true;
            forecolor.Visible = true;
            load.Visible = true;

            if(label19.Text != "Christian Schlei")
            {
                starteProgrammToolStripMenuItem.Visible = false;
            }

        }

        private void berechnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Werte aufnehmen
            string Calculate1 = textBox1.Text;
            string Calculate2 = textBox2.Text;
            string Calculate3 = textBox3.Text;
            string Calculate4 = textBox4.Text;
            string Calculate5 = textBox5.Text;
            string Calculate6 = textBox6.Text;
            string Calculate7 = textBox7.Text;
            string Calculate8 = textBox8.Text;
            string Calculate9 = textBox9.Text;
            string Calculate10 = textBox10.Text;
            string Calculate11 = textBox11.Text;
            string Calculate12 = textBox12.Text;
            string Calculate13 = textBox13.Text;
            string Calculate14 = textBox14.Text;

            //Calculating
            double res1 = Convert.ToDouble(Calculate1) + Convert.ToDouble(Calculate2) + Convert.ToDouble(Calculate3);
            double res2 = Convert.ToDouble(Calculate4) + Convert.ToDouble(Calculate5) + Convert.ToDouble(Calculate6);
            double res3 = Convert.ToDouble(Calculate7) + Convert.ToDouble(Calculate8) + Convert.ToDouble(Calculate9);
            double res4 = Convert.ToDouble(Calculate10) + Convert.ToDouble(Calculate11) + Convert.ToDouble(Calculate12);
            double res5 = Convert.ToDouble(Calculate13) + Convert.ToDouble(Calculate14);

            double sum = res1 + res2 + res3 + res4 + res5;

            //zu string, ausgabe
            string summe = sum + "";
            Summe.Text = summe;
        }

        #endregion

        #region Speichern und Laden
        private void Speichern(object sender, EventArgs e)
        {
            if(abmeldenToolStripMenuItem.Text == "Abmelden")
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = "Geldstand_" + DateTime.Now.ToString("dd.MM.yyyy");
                sfd.Filter = "Geldstand-Savefile |*.cash|Geldstand-Savefile |*.geldstand|Textdatei |*.txt|Alle Dateien |*.*";
                sfd.Title = "Geldstand speichern";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Userdaten US = new Userdaten();

                    US.gesamt = Summe.Text;
                    US.ausgaben = ausgaben.Text;
                    US.mykonto = kontostand.Text;
                    US.cent1 = textBox1.Text;
                    US.cent2 = textBox2.Text;
                    US.cent5 = textBox3.Text;
                    US.cent10 = textBox4.Text;
                    US.cent20 = textBox5.Text;
                    US.cent50 = textBox6.Text;
                    US.euro1 = textBox7.Text;
                    US.euro2 = textBox8.Text;
                    US.euro5 = textBox9.Text;
                    US.euro10 = textBox10.Text;
                    US.euro20 = textBox11.Text;
                    US.euro50 = textBox12.Text;
                    US.euro100 = textBox13.Text;
                    US.euro200 = textBox14.Text;
                    US.FARBE = label20.Text;
                    US.color = label21.Text;

                    US.Save(sfd.FileName);
                }
            }

            else if(abmeldenToolStripMenuItem.Text == "Anmelden")
            {
                Userdaten US = new Userdaten();

                US.gesamt = Summe.Text;
                US.ausgaben = ausgaben.Text;
                US.mykonto = kontostand.Text;
                US.cent1 = textBox1.Text;
                US.cent2 = textBox2.Text;
                US.cent5 = textBox3.Text;
                US.cent10 = textBox4.Text;
                US.cent20 = textBox5.Text;
                US.cent50 = textBox6.Text;
                US.euro1 = textBox7.Text;
                US.euro2 = textBox8.Text;
                US.euro5 = textBox9.Text;
                US.euro10 = textBox10.Text;
                US.euro20 = textBox11.Text;
                US.euro50 = textBox12.Text;
                US.euro100 = textBox13.Text;
                US.euro200 = textBox14.Text;
                US.FARBE = label20.Text;
                US.color = label21.Text;

                US.Save(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Geldstand_Public.cash");
            }
        }
            
        private void Laden(object sender, EventArgs e)
        {
            if(abmeldenToolStripMenuItem.Text == "Abmelden")
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.FileName = "";
                ofd.Filter = "Geldstand-Savefile | *.cash|Geldstand-Savefile | *.geldstand|Textdatei | *.txt|Alle Dateien | *.*";
                ofd.Title = "Geldstand laden";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Userdaten US = new Userdaten();
                    US = US.Load(ofd.FileName);

                    Summe.Text = US.gesamt;
                    ausgaben.Text = US.ausgaben;
                    kontostand.Text = US.mykonto;

                    textBox1.Text = US.cent1;
                    textBox2.Text = US.cent2;
                    textBox3.Text = US.cent5;
                    textBox4.Text = US.cent10;
                    textBox5.Text = US.cent20;
                    textBox6.Text = US.cent50;
                    textBox7.Text = US.euro1;
                    textBox8.Text = US.euro2;
                    textBox9.Text = US.euro5;
                    textBox10.Text = US.euro10;
                    textBox11.Text = US.euro20;
                    textBox12.Text = US.euro50;
                    textBox13.Text = US.euro100;
                    textBox12.Text = US.euro200;
                }
            }

            else if(abmeldenToolStripMenuItem.Text == "Anmelden")
            {
                Userdaten US = new Userdaten();
                US = US.Load(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Geldstand_Public.cash");

                Summe.Text = US.gesamt;
                ausgaben.Text = US.ausgaben;
                kontostand.Text = US.mykonto;

                textBox1.Text = US.cent1;
                textBox2.Text = US.cent2;
                textBox3.Text = US.cent5;
                textBox4.Text = US.cent10;
                textBox5.Text = US.cent20;
                textBox6.Text = US.cent50;
                textBox7.Text = US.euro1;
                textBox8.Text = US.euro2;
                textBox9.Text = US.euro5;
                textBox10.Text = US.euro10;
                textBox11.Text = US.euro20;
                textBox12.Text = US.euro50;
                textBox13.Text = US.euro100;
                textBox12.Text = US.euro200;
            }
            
        }

        #endregion

        #region Werte hinzufügen
        private void button1_Click(object sender, EventArgs e)
        {
            Form15 frm15 = new Form15();
            if (frm15.ShowDialog() == DialogResult.OK)
            {
                double res = Convert.ToDouble(1) * Convert.ToDouble(frm15.cash);
                res = res / 100;
                string ausg = "" + res;
                textBox1.Text = ausg;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form16 frm16 = new Form16();
            if (frm16.ShowDialog() == DialogResult.OK)
            {
                double res = Convert.ToDouble(2) * Convert.ToDouble(frm16.cash);
                res = res / 100;
                string ausg = "" + res;
                textBox2.Text = ausg;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form17 frm17 = new Form17();
            if (frm17.ShowDialog() == DialogResult.OK)
            {
                double res = Convert.ToDouble(5) * Convert.ToDouble(frm17.cash);
                res = res / 100;
                string ausg = "" + res;
                textBox3.Text = ausg;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form18 frm18 = new Form18();
            if (frm18.ShowDialog() == DialogResult.OK)
            {
                double res = Convert.ToDouble(10) * Convert.ToDouble(frm18.cash);
                res = res / 100;
                string ausg = "" + res;
                textBox4.Text = ausg;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form19 frm19 = new Form19();
            if (frm19.ShowDialog() == DialogResult.OK)
            {
                double res = Convert.ToDouble(20) * Convert.ToDouble(frm19.cash);
                res = res / 100;
                string ausg = "" + res;
                textBox5.Text = ausg;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form20 frm20 = new Form20();
            if (frm20.ShowDialog() == DialogResult.OK)
            {
                double res = Convert.ToDouble(50) * Convert.ToDouble(frm20.cash);
                res = res / 100;
                string ausg = "" + res;
                textBox6.Text = ausg;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form21 frm21 = new Form21();
            if (frm21.ShowDialog() == DialogResult.OK)
            {
                double res = Convert.ToDouble(100) * Convert.ToDouble(frm21.cash);
                res = res / 100;
                string ausg = "" + res;
                textBox7.Text = ausg;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form22 frm22 = new Form22();
            if (frm22.ShowDialog() == DialogResult.OK)
            {
                double res = Convert.ToDouble(200) * Convert.ToDouble(frm22.cash);
                res = res / 100;
                string ausg = "" + res;
                textBox8.Text = ausg;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form23 frm23 = new Form23();
            if (frm23.ShowDialog() == DialogResult.OK)
            {
                double res = Convert.ToDouble(500) * Convert.ToDouble(frm23.cash);
                res = res / 100;
                string ausg = "" + res;
                textBox9.Text = ausg;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form24 frm24 = new Form24();
            if (frm24.ShowDialog() == DialogResult.OK)
            {
                double res = Convert.ToDouble(1000) * Convert.ToDouble(frm24.cash);
                res = res / 100;
                string ausg = "" + res;
                textBox10.Text = ausg;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form25 frm25 = new Form25();
            if (frm25.ShowDialog() == DialogResult.OK)
            {
                double res = Convert.ToDouble(2000) * Convert.ToDouble(frm25.cash);
                res = res / 100;
                string ausg = "" + res;
                textBox11.Text = ausg;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form26 frm26 = new Form26();
            if (frm26.ShowDialog() == DialogResult.OK)
            {
                double res = Convert.ToDouble(5000) * Convert.ToDouble(frm26.cash);
                res = res / 100;
                string ausg = "" + res;
                textBox12.Text = ausg;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form27 frm27 = new Form27();
            if (frm27.ShowDialog() == DialogResult.OK)
            {
                double res = Convert.ToDouble(10000) * Convert.ToDouble(frm27.cash);
                res = res / 100;
                string ausg = "" + res;
                textBox13.Text = ausg;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form28 frm28 = new Form28();
            if (frm28.ShowDialog() == DialogResult.OK)
            {
                double res = Convert.ToDouble(20000) * Convert.ToDouble(frm28.cash);
                res = res / 100;
                string ausg = "" + res;
                textBox14.Text = ausg;
            }
        }

        #endregion

        #region Umrechner
        private void eigenerWechselkursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form33 ab = new Form33();
            if (ab.ShowDialog() == DialogResult.OK)
            {
                //IO
            }
        }

        private void euroDollarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 dollar = new Form3();
            if (dollar.ShowDialog() == DialogResult.OK)
            {
                string vor = Summe.Text;
                double resdann = Convert.ToDouble(vor) + Convert.ToDouble(dollar.doltoeuro);
                string dann = resdann + "";
                Summe.Text = dann;

                //else = nothing_to.do
            }
        }

        private void euroPfundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 pound = new Form4();
            if (pound.ShowDialog() == DialogResult.OK)
            {
                string avor = Summe.Text;
                double aresdann = Convert.ToDouble(avor) + Convert.ToDouble(pound.poundtoeuro);
                string adann = aresdann + "";
                Summe.Text = adann;

                //else = nothing_to.do
            }
        }

        private void euroRubbelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 rubel = new Form5();
            if (rubel.ShowDialog() == DialogResult.OK)
            {
                string avor = Summe.Text;
                double aresdann = Convert.ToDouble(avor) + Convert.ToDouble(rubel.rubltoeuro);
                string adann = aresdann + "";
                Summe.Text = adann;

                //else = nothing_to.do
            }
        }

        private void euroKunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 kuna = new Form6();
            if (kuna.ShowDialog() == DialogResult.OK)
            {
                string aavor = Summe.Text;
                double aaresdann = Convert.ToDouble(aavor) + Convert.ToDouble(kuna.kunetoeuro);
                string aadann = aaresdann + "";
                Summe.Text = aadann;

                //else = nothing_to.do
            }
        }

        private void euroYenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 yen = new Form7();
            if (yen.ShowDialog() == DialogResult.OK)
            {
                string aavor = Summe.Text;
                double aaresdann = Convert.ToDouble(aavor) + Convert.ToDouble(yen.yentoeuro);
                string aadann = aaresdann + "";
                Summe.Text = aadann;

                //else = nothing_to.do
            }
        }

        #endregion

        #region Tools
        private void nachDickeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 dicke = new Form8();
            if (dicke.ShowDialog() == DialogResult.OK)
            {
                Int32 nachdicke1 = Convert.ToInt32(dicke.fett1) / Convert.ToInt32(1);
                Int32 nachdicke2 = Convert.ToInt32(dicke.fett2) / Convert.ToInt32(1);
                Int32 nachdicke3 = Convert.ToInt32(dicke.fett3) / Convert.ToInt32(1);
                Int32 nachdicke4 = Convert.ToInt32(dicke.fett4) / Convert.ToInt32(2);
                Int32 nachdicke5 = Convert.ToInt32(dicke.fett5) / Convert.ToInt32(2);
                Int32 nachdicke6 = Convert.ToInt32(dicke.fett6) / Convert.ToInt32(2);
                Int32 nachdicke7 = Convert.ToInt32(dicke.fett7) / Convert.ToInt32(2);
                Int32 nachdicke8 = Convert.ToInt32(dicke.fett8) / Convert.ToInt32(2);

                double anzahlinwert1 = Convert.ToDouble(nachdicke1) * Convert.ToDouble(0.01);
                double anzahlinwert2 = Convert.ToDouble(nachdicke2) * Convert.ToDouble(0.02);
                double anzahlinwert3 = Convert.ToDouble(nachdicke3) * Convert.ToDouble(0.05);
                double anzahlinwert4 = Convert.ToDouble(nachdicke4) * Convert.ToDouble(0.10);
                double anzahlinwert5 = Convert.ToDouble(nachdicke5) * Convert.ToDouble(0.20);
                double anzahlinwert6 = Convert.ToDouble(nachdicke6) * Convert.ToDouble(0.50);
                double anzahlinwert7 = Convert.ToDouble(nachdicke7) * Convert.ToDouble(1);
                double anzahlinwert8 = Convert.ToDouble(nachdicke8) * Convert.ToDouble(2);

                string ausgabedicke1 = anzahlinwert1 + "";
                string ausgabedicke2 = anzahlinwert2 + "";
                string ausgabedicke3 = anzahlinwert3 + "";
                string ausgabedicke4 = anzahlinwert4 + "";
                string ausgabedicke5 = anzahlinwert5 + "";
                string ausgabedicke6 = anzahlinwert6 + "";
                string ausgabedicke7 = anzahlinwert7 + "";
                string ausgabedicke8 = anzahlinwert8 + "";

                textBox1.Text = ausgabedicke1;
                textBox2.Text = ausgabedicke2;
                textBox3.Text = ausgabedicke3;
                textBox4.Text = ausgabedicke4;
                textBox5.Text = ausgabedicke5;
                textBox6.Text = ausgabedicke6;
                textBox7.Text = ausgabedicke7;
                textBox8.Text = ausgabedicke8;
            }
        }

        private void nachGewichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 gewicht = new Form9();
            if (gewicht.ShowDialog() == DialogResult.OK)
            {
                Int32 nachgewicht1 = Convert.ToInt32(gewicht.gewicht1) / Convert.ToInt32(2);
                Int32 nachgewicht2 = Convert.ToInt32(gewicht.gewicht2) / Convert.ToInt32(3);
                Int32 nachgewicht3 = Convert.ToInt32(gewicht.gewicht3) / Convert.ToInt32(4);
                Int32 nachgewicht4 = Convert.ToInt32(gewicht.gewicht4) / Convert.ToInt32(4);
                Int32 nachgewicht5 = Convert.ToInt32(gewicht.gewicht5) / Convert.ToInt32(5);
                Int32 nachgewicht6 = Convert.ToInt32(gewicht.gewicht6) / Convert.ToInt32(8);
                Int32 nachgewicht7 = Convert.ToInt32(gewicht.gewicht7) / Convert.ToInt32(7);
                Int32 nachgewicht8 = Convert.ToInt32(gewicht.gewicht8) / Convert.ToInt32(8);

                double anzahlzuwert1 = Convert.ToDouble(nachgewicht1) * Convert.ToDouble(0.01);
                double anzahlzuwert2 = Convert.ToDouble(nachgewicht2) * Convert.ToDouble(0.02);
                double anzahlzuwert3 = Convert.ToDouble(nachgewicht3) * Convert.ToDouble(0.05);
                double anzahlzuwert4 = Convert.ToDouble(nachgewicht4) * Convert.ToDouble(0.10);
                double anzahlzuwert5 = Convert.ToDouble(nachgewicht5) * Convert.ToDouble(0.20);
                double anzahlzuwert6 = Convert.ToDouble(nachgewicht6) * Convert.ToDouble(0.50);
                double anzahlzuwert7 = Convert.ToDouble(nachgewicht7) * Convert.ToDouble(1);
                double anzahlzuwert8 = Convert.ToDouble(nachgewicht8) * Convert.ToDouble(2);

                string ausgabegewicht1 = anzahlzuwert1 + "";
                string ausgabegewicht2 = anzahlzuwert2 + "";
                string ausgabegewicht3 = anzahlzuwert3 + "";
                string ausgabegewicht4 = anzahlzuwert4 + "";
                string ausgabegewicht5 = anzahlzuwert5 + "";
                string ausgabegewicht6 = anzahlzuwert6 + "";
                string ausgabegewicht7 = anzahlzuwert7 + "";
                string ausgabegewicht8 = anzahlzuwert8 + "";

                textBox1.Text = ausgabegewicht1;
                textBox2.Text = ausgabegewicht2;
                textBox3.Text = ausgabegewicht3;
                textBox4.Text = ausgabegewicht4;
                textBox5.Text = ausgabegewicht5;
                textBox6.Text = ausgabegewicht6;
                textBox7.Text = ausgabegewicht7;
                textBox8.Text = ausgabegewicht8;
            }
        }

        private void ausgabenHinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ausgabenlb.Visible = true;
            ausgaben.Visible = true;
            centa1.Visible = true;
        }

        private void koToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lontolb.Visible = true;
            kontostand.Visible = true;
            centa2.Visible = true;
        }

        private void kontostandAusblendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kontostand.Visible = false;
            lontolb.Visible = false;
            centa2.Visible = false;
        }

        private void ausgabenAusblendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ausgaben.Visible = false;
            ausgabenlb.Visible = false;
            centa1.Visible = false;
        }

        private void ergänzungenHinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string kon = kontostand.Text;
            string aus = ausgaben.Text;
            string zuvor = Summe.Text;

            double danach = Convert.ToDouble(zuvor) + Convert.ToDouble(kon) - Convert.ToDouble(aus);
            string full = danach + "";
            Summe.Text = full;

        }

        private void ergänzungenEntfernenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string kon = kontostand.Text;
            string aus = ausgaben.Text;
            string danach = Summe.Text;

            double zuvor = Convert.ToDouble(danach) - Convert.ToDouble(kon) + Convert.ToDouble(aus);
            string full = zuvor + "";
            Summe.Text = full;
        }

        #endregion

        #region Ältere Versionen
        private void starteProgrammToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void geldzählerMitEuro10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form31 warning = new Form31();
            if (warning.ShowDialog() == DialogResult.Continue)
            {
                Close();
                Process.Start(@"C:\Users\chris\Desktop\Geldzähler\Terminal_StartApplication\Terminal_StartApplication (1 I 5)\bin\Debug\net6.0\Terminal_StartApplication.exe");
            }
        }

        private void geldzählerMitEuro11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form31 warning = new Form31();
            if (warning.ShowDialog() == DialogResult.Continue)
            {
                Close();
                Process.Start(@"C:\Users\chris\Desktop\Geldzähler\Terminal_StartApplication\Terminal_StartApplication (2 I 5)\bin\Debug\net6.0\Terminal_StartApplication.exe");
            }
        }

        private void geldzählerMitEuro20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form31 warning = new Form31();
            if (warning.ShowDialog() == DialogResult.Continue)
            {
                Close();
                Process.Start(@"C:\Users\chris\Desktop\Geldzähler\Terminal_StartApplication\Terminal_StartApplication (3 I 5)\bin\Debug\net6.0\Terminal_StartApplication.exe");
            }
        }

        private void geldzählerMitEuro30ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form31 warning = new Form31();
            if (warning.ShowDialog() == DialogResult.Continue)
            {
                Close();
                Process.Start(@"C:\Users\chris\Desktop\Geldzähler\Terminal_StartApplication\Terminal_StartApplication (4 I 5)\bin\Debug\net6.0\Terminal_StartApplication.exe");
            }
        }

        private void geldzählerMitEuro40ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form31 warning = new Form31();
            if (warning.ShowDialog() == DialogResult.Continue)
            {
                Close();
                Process.Start(@"C:\Users\chris\Desktop\Geldzähler\Terminal_StartApplication\Terminal_StartApplication (5 I 5)\bin\Debug\net6.0\Terminal_StartApplication.exe");
            }
        }

        #endregion

        #region Informationen
        private void überDasProgrammToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 info = new Form12();
            if (info.ShowDialog() == DialogResult.OK)
            {
                //NICHTS WIRD PASSIEREN
            }
        }

        private void hilfeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 help = new Form13();
            if (help.ShowDialog() == DialogResult.OK)
            {
                //  samesame
            }
        }

        #endregion

        #region Hintergrundfarben
        private void BackColorStandard(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            label20.Text = "COLOR";
        }

        private void BackColorRed(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            label20.Text = "RED";
        }

        private void BackColorOrange(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(1)))));
            label20.Text = "ORANGE";
        }

        private void BackColorYellow(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(1)))));
            label20.Text = "YELLOW";
        }

        private void BackColorHellGreen(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            label20.Text = "HELLGREEN";
        }

        private void BackColorGreen(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(180)))), ((int)(((byte)(1)))));
            label20.Text = "GREEN";
        }

        private void BackColorHellBlue(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            label20.Text = "HELLBLUE";
        }

        private void BackColorBlue(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(1)))), ((int)(((byte)(250)))));
            label20.Text = "BLUE";
        }

        private void BackColorPink(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            label20.Text = "PINK";
        }

        private void BackColorBrown(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            label20.Text = "BROWN";
        }

        #endregion

        #region Vordergrundfarben
        private void ForeColorStandard(object sender, EventArgs e)
        {
            Summe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            kontostand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            ausgaben.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));

            textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            textBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            textBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));

            label21.Text = "COLOR";
        }

        private void ForeColorRed(object sender, EventArgs e)
        {
            Summe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            kontostand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            ausgaben.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));

            textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            textBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            textBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));

            label21.Text = "RED";
        }

        private void ForeColorOrange(object sender, EventArgs e)
        {
            Summe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(1)))));
            kontostand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(1)))));
            ausgaben.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(1)))));

            textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(1)))));
            textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(1)))));
            textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(1)))));
            textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(1)))));
            textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(1)))));
            textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(1)))));
            textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(1)))));
            textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(1)))));
            textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(1)))));
            textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(1)))));
            textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(1)))));
            textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(1)))));
            textBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(1)))));
            textBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(1)))));

            label21.Text = "ORANGE";
        }

        private void ForeColorYellow(object sender, EventArgs e)
        {
            Summe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(1)))));
            kontostand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(1)))));
            ausgaben.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(1)))));

            textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(1)))));
            textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(1)))));
            textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(1)))));
            textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(1)))));
            textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(1)))));
            textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(1)))));
            textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(1)))));
            textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(1)))));
            textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(1)))));
            textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(1)))));
            textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(1)))));
            textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(1)))));
            textBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(1)))));
            textBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(1)))));

            label21.Text = "YELLOW";
        }

        private void ForeColorHellGreen(object sender, EventArgs e)
        {
            Summe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            kontostand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            ausgaben.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));

            textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            textBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            textBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));

            label21.Text = "HELLGREEN";
        }

        private void ForeColorGreen(object sender, EventArgs e)
        {
            Summe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(180)))), ((int)(((byte)(1)))));
            kontostand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(180)))), ((int)(((byte)(1)))));
            ausgaben.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(180)))), ((int)(((byte)(1)))));

            textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(180)))), ((int)(((byte)(1)))));
            textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(180)))), ((int)(((byte)(1)))));
            textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(180)))), ((int)(((byte)(1)))));
            textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(180)))), ((int)(((byte)(1)))));
            textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(180)))), ((int)(((byte)(1)))));
            textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(180)))), ((int)(((byte)(1)))));
            textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(180)))), ((int)(((byte)(1)))));
            textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(180)))), ((int)(((byte)(1)))));
            textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(180)))), ((int)(((byte)(1)))));
            textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(180)))), ((int)(((byte)(1)))));
            textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(180)))), ((int)(((byte)(1)))));
            textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(180)))), ((int)(((byte)(1)))));
            textBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(180)))), ((int)(((byte)(1)))));
            textBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(180)))), ((int)(((byte)(1)))));

            label21.Text = "GREEN";
        }

        private void ForeColorHellBlue(object sender, EventArgs e)
        {
            Summe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            kontostand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            ausgaben.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));

            textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            textBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            textBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));

            label21.Text = "HELLBLUE";
        }

        private void ForeColorBlue(object sender, EventArgs e)
        {
            Summe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(1)))), ((int)(((byte)(250)))));
            kontostand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(1)))), ((int)(((byte)(250)))));
            ausgaben.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(1)))), ((int)(((byte)(250)))));

            textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(1)))), ((int)(((byte)(250)))));
            textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(1)))), ((int)(((byte)(250)))));
            textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(1)))), ((int)(((byte)(250)))));
            textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(1)))), ((int)(((byte)(250)))));
            textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(1)))), ((int)(((byte)(250)))));
            textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(1)))), ((int)(((byte)(250)))));
            textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(1)))), ((int)(((byte)(250)))));
            textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(1)))), ((int)(((byte)(250)))));
            textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(1)))), ((int)(((byte)(250)))));
            textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(1)))), ((int)(((byte)(250)))));
            textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(1)))), ((int)(((byte)(250)))));
            textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(1)))), ((int)(((byte)(250)))));
            textBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(1)))), ((int)(((byte)(250)))));
            textBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(1)))), ((int)(((byte)(250)))));

            label21.Text = "BLUE";
        }

        private void ForeColorPink(object sender, EventArgs e)
        {
            Summe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            kontostand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            ausgaben.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));

            textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            textBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            textBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));

            label21.Text = "PINK";
        }

        private void ForeColorBrown(object sender, EventArgs e)
        {
            Summe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            kontostand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            ausgaben.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));

            textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            textBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            textBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));

            label21.Text = "BROWN";
        }

        #endregion

        #region Color_Load

        private void Farbkombination_laden(object sender, EventArgs e)
        {
            OpenFileDialog colorload = new OpenFileDialog();
            colorload.Title = "Farbkombination laden";
            colorload.FileName = "";
            colorload.Filter = "Geldstand-Savefile | *.cash|Geldstand-Savefile | *.geldstand|Textdatei | *.txt|Alle Dateien | *.*";

            if (colorload.ShowDialog() == DialogResult.OK)
            {
                Userdaten US = new Userdaten();
                US = US.Load(colorload.FileName);

                label20.Text = US.FARBE;
                label21.Text = US.color;

                if (label20.Text == "COLOR")
                {
                    BackColorStandard(sender, e);
                }
                if (label20.Text == "RED")
                {
                    BackColorRed(sender, e);
                }
                if (label20.Text == "ORANGE")
                {
                    BackColorOrange(sender, e);
                }
                if (label20.Text == "YELLOW")
                {
                    BackColorYellow(sender, e);
                }
                if (label20.Text == "HELLGREEN")
                {
                    BackColorHellGreen(sender, e);
                }
                if (label20.Text == "GREEN")
                {
                    BackColorGreen(sender, e);
                }
                if (label20.Text == "HELLBLUE")
                {
                    BackColorHellBlue(sender, e);
                }
                if (label20.Text == "BLUE")
                {
                    BackColorBlue(sender, e);
                }
                if (label20.Text == "PINK")
                {
                    BackColorPink(sender, e);
                }
                if (label20.Text == "BROWN")
                {
                    BackColorBrown(sender, e);
                }



                if (label21.Text == "COLOR")
                {
                    ForeColorStandard(sender, e);
                }
                if (label21.Text == "RED")
                {
                    ForeColorRed(sender, e);
                }
                if (label21.Text == "ORANGE")
                {
                    ForeColorOrange(sender, e);
                }
                if (label21.Text == "YELLOW")
                {
                    ForeColorYellow(sender, e);
                }
                if (label21.Text == "HELLGREEN")
                {
                    ForeColorHellGreen(sender, e);
                }
                if (label21.Text == "GREEN")
                {
                    ForeColorGreen(sender, e);
                }
                if (label21.Text == "HELLBLUE")
                {
                    ForeColorHellBlue(sender, e);
                }
                if (label21.Text == "BLUE")
                {
                    ForeColorBlue(sender, e);
                }
                if (label21.Text == "PINK")
                {
                    ForeColorPink(sender, e);
                }
                if (label21.Text == "BROWN")
                {
                    ForeColorBrown(sender, e);
                }
            }
        }
        #endregion

        #region Extras
        private void Binary(object sender, EventArgs e)
        {
            Form10 binary = new Form10();
            if (binary.ShowDialog() == DialogResult.OK)
            {

            }
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            berechnenToolStripMenuItem_Click(sender, e);
        }
    }
}