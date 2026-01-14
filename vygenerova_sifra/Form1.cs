using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace vygenerova_sifra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEncode_Click(object sender, EventArgs e)
        {
            //dis
            textIn.Text = textIn.Text.ToLower().Replace(" ", "");
            textKey.Text = textKey.Text.ToLower().Replace(" ", "");


            String Key = textKey.Text;
            String textOriginal = textIn.Text;
            String textZakodovano = "";
            int znak;
            int kod;


            for (int i = 0; i < textOriginal.Length; i++)
            {
                int o =+ 1;
                if(Key.Length <= o) { o =  0; };
                int kolikposun = Convert.ToInt32(Key[o]) - 96;
                znak = Convert.ToInt32(textOriginal[i]);
                kod = znak + kolikposun;
                if (kod > 122) { kod = kod - 26; };
                textZakodovano += Convert.ToChar(kod);
            }
            textOut.Text = textZakodovano;
        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {
            textIn.Text = textIn.Text.ToLower().Replace(" ", "");
            textKey.Text = textKey.Text.ToLower().Replace(" ", "");


            String Key = textKey.Text;
            String textOriginal = textIn.Text;
            String textZakodovano = "";
            int znak;
            int kod;


            for (int i = 0; i < textOriginal.Length; i++)
            {
                int o = +1;
                if (Key.Length <= o) { o = 0; }; ;
                int kolikposun = Convert.ToInt32(Key[o]) - 96;
                znak = Convert.ToInt32(textOriginal[i]);
                kod = znak - kolikposun;
                if (kod > 122) { kod += 26; };
                textZakodovano += Convert.ToChar(kod);
            }
            textOut.Text = textZakodovano;
        }
    }
}
