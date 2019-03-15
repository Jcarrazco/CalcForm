using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcForm
{
    
    public partial class Convertidor : Form
    {
        public int U = 0;
        public Convertidor()
        {
            InitializeComponent();
        }

        private void Btn_Calc_Click(object sender, EventArgs e)
        {
            Calculadora newf = new Calculadora();
            newf.Show();
            this.Close();
        }

        private void Convertidor_Load(object sender, EventArgs e)
        {
            Cbx_In.Items.Add("1 - Kilometro");
            Cbx_In.Items.Add("2 - Metro");
            Cbx_In.Items.Add("3 - Centrimetro");
            Cbx_In.Items.Add("4 - Milimetro");
            Cbx_In.Items.Add("5 - Milla");
            Cbx_In.Items.Add("6 - Yarda");
            Cbx_In.Items.Add("7 - Pie");
            Cbx_In.Items.Add("8 - Pulgada");

            Cbx_Out.Items.Add("Kilometro");
            Cbx_Out.Items.Add("Metro");
            Cbx_Out.Items.Add("Centrimetro");
            Cbx_Out.Items.Add("Milimetro");
            Cbx_Out.Items.Add("Milla");
            Cbx_Out.Items.Add("Yarda");
            Cbx_Out.Items.Add("Pie");
            Cbx_Out.Items.Add("Pulgada");
        }

        private void Btn_Convertir_Click(object sender, EventArgs e)
        {

            char _in = Convert.ToChar(Cbx_In.Text[0]);
            string _out = Cbx_Out.Text;
            double Base = Convert.ToDouble(Txb_In.Text);
            switch (_in)
            {
                case '1':
                    metros res = new metros();
                    Txb_Out.Text = Convert.ToString( res.Conv(Base, _out));
                    break;
                case '2':
                    kilometro res1 = new kilometro();
                    Txb_Out.Text = Convert.ToString(res1.Conv(Base, _out));
                    break;
                case '3':
                    milimetro res2 = new milimetro();
                    Txb_Out.Text = Convert.ToString(res2.Conv(Base, _out));
                    break;
                case '4':
                    centimetro res3 = new centimetro();
                    Txb_Out.Text = Convert.ToString(res3.Conv(Base, _out));
                    break;
                case '5':
                    milla res4 = new milla();
                    Txb_Out.Text = Convert.ToString(res4.Conv(Base, _out));
                    break;
                case '6':
                    yarda res5 = new yarda();
                    Txb_Out.Text = Convert.ToString(res5.Conv(Base, _out));
                    break;
                case '7':
                    pie res6 = new pie();
                    Txb_Out.Text = Convert.ToString(res6.Conv(Base, _out));
                    break;
                case '8':
                    pulgada res7 = new pulgada();
                    Txb_Out.Text = Convert.ToString(res7.Conv(Base, _out));
                    break;
            }
        }

        private void Cbx_Out_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
