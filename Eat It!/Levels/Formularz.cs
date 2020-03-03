using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eat_It_
{
    public partial class Formularz : Form
    {
        public Formularz()
        {
            InitializeComponent();
            this.FormClosed +=
           new System.Windows.Forms.FormClosedEventHandler(this.Formularz_FormClosed);
        }

        public static int wiek;
        public static int waga;
        public static int wzrost;
        public static string plec;
        public static string akt;


        private void Formularz_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void comboBox_Akt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isCheck;
            int.TryParse(textBox_Wiek.Text, out wiek);
            int.TryParse(textBox_Waga.Text, out waga);
            int.TryParse(textBox_Wzrost.Text, out wzrost);
            akt = comboBox_Akt.Text;
            if (radioButton_Men.Checked || radioButton_Kob.Checked)
            {
                isCheck = true;
            }
            else
            {
                isCheck = false;
            }
            if (wiek > 0 && wiek < 120 && waga > 30 && waga < 200 && wzrost>110 && wzrost<230 && akt != null && isCheck)
            {
                if (radioButton_Men.Checked)
                    plec = radioButton_Men.Text;
                else
                    plec = radioButton_Kob.Text;

                this.Close();
                (new EatIt()).Show();
            }
            else
            {
                MessageBox.Show("Błędne dane!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox_Wiek_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Waga_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_Kob_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_Men_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Formularz_Load(object sender, EventArgs e)
        {

        }
    }
}
