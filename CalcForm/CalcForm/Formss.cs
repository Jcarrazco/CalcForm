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
    public partial class Formss : Form
    {
        public int State = 0;
        public Formss()
        {
            InitializeComponent();
        }

        private void Formss_Load(object sender, EventArgs e)
        {
            
            Cbx_Shape.Items.Add("Triangulo");
            Cbx_Shape.Items.Add("Rectangulo");
            Cbx_Shape.Items.Add("Circulo");
            Cbx_Shape.Items.Add("Cuadrado");
            Txb_Altura.Text = "0";
            Txb_Base.Text = "0";
        }

        private void Cbx_Shape_SelectedIndexChanged(object sender, EventArgs e)
        {   //Inicializa las condiciones normales
            Lbl_Base.Text = "Base";
            Lbl_Altura.Show();
            Txb_Altura.Enabled = true;
            //lee la seleccion 
            string result = Cbx_Shape.Text;
            //compara y coloca un indicador para saber cual fue la eleccion 
            if (Cbx_Shape.Text == "Triangulo")
            {
                State = 1;
            }
            if (Cbx_Shape.Text == "Rectangulo")
            {
                State = 2;
            }
            if (Cbx_Shape.Text == "Circulo")
            {
                State = 3;
                Lbl_Base.Text = "Radio";
                Lbl_Altura.Hide();
                Txb_Altura.Enabled = false;
            }
            if (Cbx_Shape.Text == "Cuadrado")
            {
                State = 4;
            }

        }

        private void Btn_calc_Click(object sender, EventArgs e)
        {
            Calculadora newf = new Calculadora();
            newf.Show();
            this.Close();

        }

        private void Btn_Area_Click(object sender, EventArgs e)
        {
            CalcularArea CA = new CalcularArea();//instancia del metodo con strategys

            if (Txb_Altura.Text != "" && Txb_Base.Text != "") {//validar que haya valores
                Double _v1 = Convert.ToDouble(Txb_Base.Text);
                Double _v2 = Convert.ToDouble(Txb_Altura.Text);
                switch (State)//usa una variable global para indicar que forma calculara
                {
                    case 1:
                        //se indica que estrategia usara
                        CA.SetFormasStrategy(new AreaTriangulo());
                        //se llama al metodo con la estrategia seleccionada
                        Txb_Result.Text = Convert.ToString(CA.CalcularAreas(_v1, _v2));
                        break;
                    case 2:
                        CA.SetFormasStrategy(new AreaRectangulo());
                        Txb_Result.Text = Convert.ToString(CA.CalcularAreas(_v1, _v2));
                        break;
                    case 3:
                        CA.SetFormasStrategy(new AreaCirculo());
                        Txb_Result.Text = Convert.ToString(CA.CalcularAreas(_v1, 0));
                        break;
                    case 4:
                        CA.SetFormasStrategy(new AreaCuadrado());
                        Txb_Result.Text = Convert.ToString(CA.CalcularAreas(_v1, _v2));
                        break;
                }  
            }
            

        }
    }
}
