using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*---------------------------Calculadora para practicar Singleton-----------------
 * ---------------------------Jorge Carrazco--------------------------------------
 * ---------------------------utiliza clase singleton para llamar operaciones-----
 * -----------------------------12 - Marzo - 19----------------------------------
 */
namespace CalcForm
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
            Txb_In.Text = "";
            // Instanciamos el Singleton
            ClaseSingleton Operador = ClaseSingleton.Instance;
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            Txb_In.Text = Txb_In.Text + "1";
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            Txb_In.Text = Txb_In.Text + "2";
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            Txb_In.Text = Txb_In.Text + "3";
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            Txb_In.Text = Txb_In.Text + "4";
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            Txb_In.Text = Txb_In.Text + "5";
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            Txb_In.Text = Txb_In.Text + "6";
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            Txb_In.Text = Txb_In.Text + "7";
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            Txb_In.Text = Txb_In.Text + "8";
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            Txb_In.Text = Txb_In.Text + "9";
        }

        private void Btn_dot_Click(object sender, EventArgs e)
        {
            Txb_In.Text = Txb_In.Text + ".";
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            Txb_In.Text = Txb_In.Text + " + ";
        }

        private void Btn_res_Click(object sender, EventArgs e)
        {
            Txb_In.Text = Txb_In.Text + " - ";
        }

        private void Btn_mult_Click(object sender, EventArgs e)
        {
            Txb_In.Text = Txb_In.Text + " * ";
        }

        private void Btn_div_Click(object sender, EventArgs e)
        {
            Txb_In.Text = Txb_In.Text + " / ";
        }

        private void Btn_pow_Click(object sender, EventArgs e)
        {
            Txb_In.Text = Txb_In.Text + " P ";
        }

        private void Btn_equal_Click(object sender, EventArgs e)
        {
            string[] Op = Txb_In.Text.Split(' ');
            char _Opr;
            double _v1, _v2;
            _v1 = Convert.ToDouble(Op[0]);
            _Opr = Convert.ToChar(Op[1]);
            _v2 = Convert.ToDouble(Op[2]);
            switch (_Opr)
            {
                case '+':
                    Txb_In.Text = Convert.ToString(ClaseSingleton.Instance.suma(_v1, _v2));
                    break;
                case '-':
                    Txb_In.Text = Convert.ToString(ClaseSingleton.Instance.Resta(_v1, _v2));
                    break;
                case '*':
                    Txb_In.Text = Convert.ToString(ClaseSingleton.Instance.Mult(_v1, _v2));
                    break;
                case '/':
                    Txb_In.Text = Convert.ToString(ClaseSingleton.Instance.Div(_v1, _v2));
                    break;
                case 'P':
                    Txb_In.Text = Convert.ToString(ClaseSingleton.Instance.Pow(_v1, _v2));
                    break;
            }
            



        }

        private void Btn_Sqr_Click(object sender, EventArgs e)
        {
            // Instanciamos el Singleton
            double _v1 = Convert.ToDouble(Txb_In.Text);
            Txb_In.Text = Convert.ToString(ClaseSingleton.Instance.Sqr(_v1));

        }

        private void Btn_zero_Click(object sender, EventArgs e)
        {
            Txb_In.Text = Txb_In.Text + "0";
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            Txb_In.Text = "";
        }

        private void Btn_Formas_Click(object sender, EventArgs e)
        {
            Formss formas = new Formss();
            formas.Show();
            this.Hide();
        }

        private void Btn_Convert_Click(object sender, EventArgs e)
        {
            Convertidor Converter = new Convertidor();
            Converter.Show();
            this.Hide();
        }
    }
}
