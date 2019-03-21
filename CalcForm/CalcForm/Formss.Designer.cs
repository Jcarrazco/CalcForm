namespace CalcForm
{
    partial class Formss
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txb_Base = new System.Windows.Forms.TextBox();
            this.Txb_Altura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Base = new System.Windows.Forms.Label();
            this.Lbl_Altura = new System.Windows.Forms.Label();
            this.Cbx_Shape = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Area = new System.Windows.Forms.Button();
            this.Btn_calc = new System.Windows.Forms.Button();
            this.Txb_Result = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txb_Base
            // 
            this.Txb_Base.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Base.Location = new System.Drawing.Point(12, 71);
            this.Txb_Base.Name = "Txb_Base";
            this.Txb_Base.Size = new System.Drawing.Size(100, 26);
            this.Txb_Base.TabIndex = 0;
            // 
            // Txb_Altura
            // 
            this.Txb_Altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Altura.Location = new System.Drawing.Point(12, 119);
            this.Txb_Altura.Name = "Txb_Altura";
            this.Txb_Altura.Size = new System.Drawing.Size(100, 26);
            this.Txb_Altura.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Calcular Area de Formas";
            // 
            // Lbl_Base
            // 
            this.Lbl_Base.AutoSize = true;
            this.Lbl_Base.Location = new System.Drawing.Point(13, 52);
            this.Lbl_Base.Name = "Lbl_Base";
            this.Lbl_Base.Size = new System.Drawing.Size(31, 13);
            this.Lbl_Base.TabIndex = 3;
            this.Lbl_Base.Text = "Base";
            // 
            // Lbl_Altura
            // 
            this.Lbl_Altura.AutoSize = true;
            this.Lbl_Altura.Location = new System.Drawing.Point(13, 103);
            this.Lbl_Altura.Name = "Lbl_Altura";
            this.Lbl_Altura.Size = new System.Drawing.Size(34, 13);
            this.Lbl_Altura.TabIndex = 4;
            this.Lbl_Altura.Text = "Altura";
            // 
            // Cbx_Shape
            // 
            this.Cbx_Shape.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbx_Shape.FormattingEnabled = true;
            this.Cbx_Shape.Location = new System.Drawing.Point(239, 84);
            this.Cbx_Shape.Name = "Cbx_Shape";
            this.Cbx_Shape.Size = new System.Drawing.Size(121, 32);
            this.Cbx_Shape.TabIndex = 5;
            this.Cbx_Shape.SelectedIndexChanged += new System.EventHandler(this.Cbx_Shape_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Forma a Calcular";
            // 
            // Btn_Area
            // 
            this.Btn_Area.Location = new System.Drawing.Point(264, 152);
            this.Btn_Area.Name = "Btn_Area";
            this.Btn_Area.Size = new System.Drawing.Size(83, 45);
            this.Btn_Area.TabIndex = 7;
            this.Btn_Area.Text = "Calcular Area";
            this.Btn_Area.UseVisualStyleBackColor = true;
            this.Btn_Area.Click += new System.EventHandler(this.Btn_Area_Click);
            // 
            // Btn_calc
            // 
            this.Btn_calc.Location = new System.Drawing.Point(352, 237);
            this.Btn_calc.Name = "Btn_calc";
            this.Btn_calc.Size = new System.Drawing.Size(83, 45);
            this.Btn_calc.TabIndex = 8;
            this.Btn_calc.Text = "Calculadora";
            this.Btn_calc.UseVisualStyleBackColor = true;
            this.Btn_calc.Click += new System.EventHandler(this.Btn_calc_Click);
            // 
            // Txb_Result
            // 
            this.Txb_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Result.Location = new System.Drawing.Point(16, 219);
            this.Txb_Result.Name = "Txb_Result";
            this.Txb_Result.Size = new System.Drawing.Size(100, 29);
            this.Txb_Result.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Resultado:  en m^2";
            // 
            // Formss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 294);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txb_Result);
            this.Controls.Add(this.Btn_calc);
            this.Controls.Add(this.Btn_Area);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cbx_Shape);
            this.Controls.Add(this.Lbl_Altura);
            this.Controls.Add(this.Lbl_Base);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txb_Altura);
            this.Controls.Add(this.Txb_Base);
            this.Name = "Formss";
            this.Text = "Formas Geometricas";
            this.Load += new System.EventHandler(this.Formss_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txb_Base;
        private System.Windows.Forms.TextBox Txb_Altura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Base;
        private System.Windows.Forms.Label Lbl_Altura;
        private System.Windows.Forms.ComboBox Cbx_Shape;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Area;
        private System.Windows.Forms.Button Btn_calc;
        private System.Windows.Forms.TextBox Txb_Result;
        private System.Windows.Forms.Label label2;
    }
}