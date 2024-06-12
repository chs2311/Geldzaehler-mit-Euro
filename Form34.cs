using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geldzähler_mit_Euro
{
    public partial class Form34 : Form
    {
        public Form34()
        {
            InitializeComponent();
        }

        
        #region Main
        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ladenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        #region Monate
        private void januarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label19.Text = "Januar";   
        }

        private void februarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label19.Text = "Februar";
        }

        private void märzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label19.Text = "März";
        }

        private void aprilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label19.Text = "April";
        }

        private void maiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label19.Text = "Mai";
        }

        private void juniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label19.Text = "Juni";
        }

        private void juliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label19.Text = "Juli";
        }

        private void augustToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label19.Text = "August";
        }

        private void septemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label19.Text = "September";
        }

        private void oktoberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label19.Text = "Oktober";
        }

        private void novemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label19.Text = "November";
        }

        private void dezemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label19.Text = "Dezember";
        }

        #endregion
        /*
        #region Speichern und Laden
        private static void Save()
        {
            Form1 io = new Form1();

            Taschengeldplanner_Userdaten T = new Taschengeldplanner_Userdaten();

            #region Zu speichernde Werte

            T.jan = jan.Text;
            T.feb = feb.Text;
            T.mar = mar.Text;
            T.apr = apr.Text;
            T.may = may.Text;
            T.jun = jun.Text;
            T.jul = jul.Text;
            T.aug = aug.Text;
            T.sep = sep.Text;
            T.okt = okt.Text;
            T.nov = nov.Text;
            T.dez = dez.Text;

            T.name1 = aa1.Text;
            T.name2 = aa2.Text;
            T.name3 = aa3.Text;
            T.name4 = aa4.Text;
            T.name5 = aa5.Text;
            T.name6 = aa6.Text;
            T.name7 = aa7.Text;
            T.name8 = aa8.Text;
            T.name9 = aa9.Text;
            T.name10 = aa10.Text;
            T.name11 = aa11.Text;
            T.name12 = aa12.Text;

            T.name1a = ma1.Text;
            T.name2a = ma2.Text;
            T.name3a = ma3.Text;
            T.name4a = ma4.Text;
            T.name5a = ma5.Text;
            T.name6a = ma6.Text;
            T.name7a = ma7.Text;
            T.name8a = ma8.Text;
            T.name9a = ma9.Text;
            T.name10a = ma10.Text;
            T.name11a = ma11.Text;
            T.name12a = ma12.Text;

            T.anzahl1 = (int)numericUpDown1.Value;
            T.anzahl2 = (int)numericUpDown2.Value;
            T.anzahl3 = (int)numericUpDown3.Value;
            T.anzahl4 = (int)numericUpDown4.Value;
            T.anzahl5 = (int)numericUpDown5.Value;
            T.anzahl6 = (int)numericUpDown6.Value;
            T.anzahl7 = (int)numericUpDown7.Value;
            T.anzahl8 = (int)numericUpDown8.Value;
            T.anzahl9 = (int)numericUpDown9.Value;
            T.anzahl10 = (int)numericUpDown10.Value;
            T.anzahl11 = (int)numericUpDown11.Value;
            T.anzahl12 = (int)numericUpDown12.Value;

            T.anzahl1a = (int)numericUpDown13.Value;
            T.anzahl2a = (int)numericUpDown14.Value;
            T.anzahl3a = (int)numericUpDown15.Value;
            T.anzahl4a = (int)numericUpDown16.Value;
            T.anzahl5a = (int)numericUpDown17.Value;
            T.anzahl6a = (int)numericUpDown18.Value;
            T.anzahl7a = (int)numericUpDown19.Value;
            T.anzahl8a = (int)numericUpDown20.Value;
            T.anzahl9a = (int)numericUpDown21.Value;
            T.anzahl10a = (int)numericUpDown23.Value;
            T.anzahl12a = (int)numericUpDown24.Value;

            T.price1 = p1.Text;
            T.price2 = p2.Text;
            T.price3 = p3.Text;
            T.price4 = p4.Text;
            T.price5 = p5.Text;
            T.price6 = p6.Text;
            T.price7 = p7.Text;
            T.price8 = p8.Text;
            T.price9 = p9.Text;
            T.price10 = p10.Text;
            T.price11 = p11.Text;
            T.price12 = p12.Text;

            T.price1a = p13.Text;
            T.price2a = p14.Text;
            T.price3a = p15.Text;
            T.price4a = p16.Text;
            T.price5a = p17.Text;
            T.price6a = p18.Text;
            T.price7a = p19.Text;
            T.price8a = p20.Text;
            T.price9a = p21.Text;
            T.price10a = p22.Text;
            T.price11a = p23.Text;
            T.price12a = p24.Text;

            #endregion

            T.Save(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "Taschengeldplaner_" + io.user + "_" + label19.Text + ".cash.planer");
        }
        private static void Load()
        {
            Form1 io = new Form1(); 
            
            Taschengeldplanner_Userdaten T = new Taschengeldplanner_Userdaten();
            T = T.Load(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Taschengeldplaner_" + io.user + "_" + label19.Text + ".cash.planer");

            #region Zu ladende Werte

            jan.Text = T.jan;
            feb.Text = T.feb;
            mar.Text = T.mar;
            apr.Text = T.apr;
            may.Text = T.may;
            jun.Text = T.jun;
            jul.Text = T.jul;
            aug.Text = T.aug;
            sep.Text = T.sep;
            okt.Text = T.okt;
            nov.Text = T.nov;
            dez.Text = T.dez;

            aa1.Text = T.name1;
            aa2.Text = T.name2;
            aa3.Text = T.name3;
            aa4.Text = T.name4;
            aa5.Text = T.name5;
            aa6.Text = T.name6;
            aa7.Text = T.name7;
            aa8.Text = T.name8;
            aa9.Text = T.name9;
            aa10.Text = T.name10;
            aa11.Text = T.name11;
            aa12.Text = T.name12;

            ma1.Text = T.name1a;
            ma2.Text = T.name2a;
            ma3.Text = T.name3a;
            ma4.Text = T.name4a;
            ma5.Text = T.name5a;
            ma6.Text = T.name6a;
            ma7.Text = T.name7a;
            ma8.Text = T.name8a;
            ma9.Text = T.name9a;
            ma10.Text = T.name10a;
            ma11.Text = T.name11a;
            ma12.Text = T.name12a;

            numericUpDown1.Value = T.anzahl1;
            numericUpDown2.Value = T.anzahl2;
            numericUpDown3.Value = T.anzahl3;
            numericUpDown4.Value = T.anzahl4;
            numericUpDown5.Value = T.anzahl5;
            numericUpDown6.Value = T.anzahl6;
            numericUpDown7.Value = T.anzahl7;
            numericUpDown8.Value = T.anzahl8;
            numericUpDown9.Value = T.anzahl9;
            numericUpDown10.Value = T.anzahl10;
            numericUpDown11.Value = T.anzahl11;
            numericUpDown12.Value = T.anzahl12;

            numericUpDown13.Value = T.anzahl1a;
            numericUpDown14.Value = T.anzahl2a;
            numericUpDown15.Value = T.anzahl3a;
            numericUpDown16.Value = T.anzahl4a;
            numericUpDown17.Value = T.anzahl5a;
            numericUpDown18.Value = T.anzahl6a; 
            numericUpDown19.Value = T.anzahl7a;
            numericUpDown20.Value = T.anzahl8a;
            numericUpDown21.Value = T.anzahl9a;
            numericUpDown22.Value = T.anzahl10a;
            numericUpDown23.Value = T.anzahl11a;
            numericUpDown24.Value = T.anzahl12a;

            p1.Text = T.price1;
            p2.Text = T.price2;
            p3.Text = T.price3;
            p4.Text = T.price4;
            p5.Text = T.price5;
            p6.Text = T.price6;
            p7.Text = T.price7;
            p8.Text = T.price8;
            p9.Text = T.price9;
            p10.Text = T.price10;
            p11.Text = T.price11;
            p12.Text = T.price12;

            p13.Text = T.price1a;
            p14.Text = T.price2a;
            p15.Text = T.price3a;
            p16.Text = T.price4a;
            p17.Text = T.price5a;
            p18.Text = T.price6a;
            p19.Text = T.price7a;
            p20.Text = T.price8a;
            p21.Text = T.price9a;
            p22.Text = T.price10a;
            p23.Text = T.price11a;
            p24.Text = T.price12a;

            #endregion
        }


        #endregion
*/
    }
}