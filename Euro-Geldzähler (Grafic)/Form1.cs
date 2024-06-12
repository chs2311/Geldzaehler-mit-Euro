namespace Euro_Geldzähler__Grafic_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cent1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void berechnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //X = EinzelWert, Y = GesamtWert, V = im String-Format

            //Anzahl_der_Münzen_oder_Scheine
            int a = (int)Cent1.Value;
            int b = (int)Cent2.Value;
            int c = (int)Cent5.Value;
            int d = (int)Cent10.Value;
            int f = (int)Cent20.Value;
            int g = (int)Cent50.Value;
            int h = (int)Cent100.Value;
            int i = (int)Cent200.Value;
            int j = (int)euro5.Value;
            int k = (int)euro10.Value;
            int l = (int)euro20.Value;
            int m = (int)euro50.Value;
            int n = (int)euro100.Value;
            int o = (int)euro200.Value;

            //Wert_der_Münzen_oder_Scheine
            int xa = 1;
            int xb = 2;
            int xc = 5;
            int xd = 10;
            int xf = 20;
            int xg = 50;
            int xh = 100;
            int xi = 200;
            int xj = 500;
            int xk = 1000;
            int xl = 2000;
            int xm = 5000;
            int xn = 10000;
            int xo = 20000;

            //Gesamtwert_eines_Scheines_oder_einer_Münze
            int ya = a * xa;
            int yb = b * xb;
            int yc = c * xc;
            int yd = d * xd;
            int yf = f * xf;
            int yg = g * xg;
            int yh = h * xh;
            int yi = i * xi;
            int yj = j * xj;
            int yk = k * xk;
            int yl = l * xl;
            int ym = m * xm;
            int yn = n * xn;
            int yo = o * xo;

            //Umwandlung_von_int_zu_string
            string vya = ya + "";
            string vyb = yb + "";
            string vyc = yc + "";
            string vyd = yd + "";
            string vyf = yf + "";
            string vyg = yg + "";
            string vyh = yh + "";
            string vyi = yi + "";
            string vyj = yj + "";
            string vyk = yk + "";
            string vyl = yl + "";
            string vym = ym + "";
            string vyn = yn + "";
            string vyo = yo + "";

            //Ausgabe_der_Münz-_und_Scheinwerte
            text1.Text = vya;
            text2.Text = vyb;
            text3.Text = vyc;
            text4.Text = vyd;
            text5.Text = vyf;
            text6.Text = vyg;
            text7.Text = vyh;
            text8.Text = vyi;
            text9.Text = vyj;
            text10.Text = vyk;
            text11.Text = vyl;
            text12.Text = vym;
            text13.Text = vyn;
            text14.Text = vyo;

            //Gesamtsumme_aller_Scheine_und_Münzen
            int za = ya + yb + yc + yd + yf + yg + yh + yi;
            int zb = yj + yk + yl + ym + yn + yo;
            int z = za + zb;
            string summe = z + "";
            Summe.Text = summe;
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Userdaten US = new Userdaten();

            US.centOne = (int)Cent1.Value;
            US.centTwo = (int)Cent2.Value;
            US.centFive = (int)Cent5.Value;
            US.centTen = (int)Cent10.Value;
            US.centTwenty = (int)Cent20.Value;
            US.centFifty = (int)Cent50.Value;
            US.euroOne = (int)Cent100.Value;
            US.euroTwo = (int)Cent200.Value;
            US.euroFive = (int)euro5.Value;
            US.euroTen = (int)euro10.Value;
            US.euroTwenty = (int)euro20.Value;
            US.euroFifty = (int)euro50.Value;
            US.eurohundred = (int)euro100.Value;
            US.euroTwoHundred = (int)euro200.Value;

            US.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Geldstand.cash");
        }

        private void ladenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Userdaten US = new Userdaten();
            US = US.Load(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Geldstand.cash");

            US.centOne = (int)Cent1.Value;
            US.centTwo = (int)Cent2.Value;
            US.centFive = (int)Cent5.Value;
            US.centTen = (int)Cent10.Value;
            US.centTwenty = (int)Cent20.Value;
            US.centFifty = (int)Cent50.Value;
            US.euroOne = (int)Cent100.Value;
            US.euroTwo = (int)Cent200.Value;
            US.euroFive = (int)euro5.Value;
            US.euroTen = (int)euro10.Value;
            US.euroTwenty = (int)euro20.Value;
            US.euroFifty = (int)euro50.Value;
            US.eurohundred = (int)euro100.Value;
            US.euroTwoHundred = (int)euro200.Value;

        }

        private void informationenToolStripMenuItem_Click(object sender, EventArgs e)
        {


            TEXTFELD.Text = "Geldzähler (Grafic) wurde programmiert von Christian Schlei.    Geldzähler 2.0 - Windows Forms App";
        }

        private void hilfeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TEXTFELD.Text = "Geben Sie die Anzahl ihrer Münzen/Scheine an und dieses Programm berechnet ihrer Gesamtsumme, nachdem sie 'BERECHNEN' auswählten.";
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}