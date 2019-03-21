namespace CalcForm
{
    partial class Convertidor
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
            this.Btn_Convertir = new System.Windows.Forms.Button();
            this.Txb_In = new System.Windows.Forms.TextBox();
            this.Cbx_In = new System.Windows.Forms.ComboBox();
            this.Btn_Calc = new System.Windows.Forms.Button();
            this.Txb_Out = new System.Windows.Forms.TextBox();
            this.Cbx_Out = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Btn_Convertir
            // 
            this.Btn_Convertir.Location = new System.Drawing.Point(348, 85);
            this.Btn_Convertir.Name = "Btn_Convertir";
            this.Btn_Convertir.Size = new System.Drawing.Size(114, 49);
            this.Btn_Convertir.TabIndex = 0;
            this.Btn_Convertir.Text = "Convertir";
            this.Btn_Convertir.UseVisualStyleBackColor = true;
            this.Btn_Convertir.Click += new System.EventHandler(this.Btn_Convertir_Click);
            // 
            // Txb_In
            // 
            this.Txb_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_In.Location = new System.Drawing.Point(43, 52);
            this.Txb_In.Name = "Txb_In";
            this.Txb_In.Size = new System.Drawing.Size(100, 29);
            this.Txb_In.TabIndex = 1;
            // 
            // Cbx_In
            // 
            this.Cbx_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbx_In.FormattingEnabled = true;
            this.Cbx_In.Location = new System.Drawing.Point(200, 51);
            this.Cbx_In.Name = "Cbx_In";
            this.Cbx_In.Size = new System.Drawing.Size(121, 32);
            this.Cbx_In.TabIndex = 2;
            // 
            // Btn_Calc
            // 
            this.Btn_Calc.Location = new System.Drawing.Point(348, 216);
            this.Btn_Calc.Name = "Btn_Calc";
            this.Btn_Calc.Size = new System.Drawing.Size(114, 49);
            this.Btn_Calc.TabIndex = 4;
            this.Btn_Calc.Text = "Calculadora";
            this.Btn_Calc.UseVisualStyleBackColor = true;
            this.Btn_Calc.Click += new System.EventHandler(this.Btn_Calc_Click);
            // 
            // Txb_Out
            // 
            this.Txb_Out.Enabled = false;
            this.Txb_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Out.Location = new System.Drawing.Point(43, 138);
            this.Txb_Out.Name = "Txb_Out";
            this.Txb_Out.Size = new System.Drawing.Size(100, 29);
            this.Txb_Out.TabIndex = 5;
            // 
            // Cbx_Out
            // 
            this.Cbx_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbx_Out.FormattingEnabled = true;
            this.Cbx_Out.Location = new System.Drawing.Point(200, 135);
            this.Cbx_Out.Name = "Cbx_Out";
            this.Cbx_Out.Size = new System.Drawing.Size(121, 32);
            this.Cbx_Out.TabIndex = 6;
            this.Cbx_Out.SelectedIndexChanged += new System.EventHandler(this.Cbx_Out_SelectedIndexChanged);
            // 
            // Convertidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 277);
            this.Controls.Add(this.Cbx_Out);
            this.Controls.Add(this.Txb_Out);
            this.Controls.Add(this.Btn_Calc);
            this.Controls.Add(this.Cbx_In);
            this.Controls.Add(this.Txb_In);
            this.Controls.Add(this.Btn_Convertir);
            this.Name = "Convertidor";
            this.Text = "Conversiones";
            this.Load += new System.EventHandler(this.Convertidor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Convertir;
        private System.Windows.Forms.TextBox Txb_In;
        private System.Windows.Forms.ComboBox Cbx_In;
        private System.Windows.Forms.Button Btn_Calc;
        private System.Windows.Forms.TextBox Txb_Out;
        private System.Windows.Forms.ComboBox Cbx_Out;
    }
}