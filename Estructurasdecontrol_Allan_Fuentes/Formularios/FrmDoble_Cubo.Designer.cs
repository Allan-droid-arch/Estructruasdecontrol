namespace Estructurasdecontrol_Allan_Fuentes.Formularios
{
    partial class FrmDoble_Cubo
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
            this.textCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textDouble = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textResp = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textCalcular
            // 
            this.textCalcular.Location = new System.Drawing.Point(45, 161);
            this.textCalcular.Name = "textCalcular";
            this.textCalcular.Size = new System.Drawing.Size(75, 27);
            this.textCalcular.TabIndex = 0;
            this.textCalcular.Text = "Calcular";
            this.textCalcular.UseVisualStyleBackColor = true;
            this.textCalcular.Click += new System.EventHandler(this.textCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese un Numero";
            // 
            // textDouble
            // 
            this.textDouble.Location = new System.Drawing.Point(162, 57);
            this.textDouble.Name = "textDouble";
            this.textDouble.Size = new System.Drawing.Size(130, 25);
            this.textDouble.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resultado";
            // 
            // textResp
            // 
            this.textResp.BackColor = System.Drawing.Color.White;
            this.textResp.Location = new System.Drawing.Point(138, 110);
            this.textResp.Name = "textResp";
            this.textResp.ReadOnly = true;
            this.textResp.Size = new System.Drawing.Size(227, 25);
            this.textResp.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(153, 161);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 27);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(407, 235);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 27);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmDoble_Cubo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(515, 319);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.textResp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textDouble);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textCalcular);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmDoble_Cubo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doble_Cubo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button textCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textDouble;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textResp;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
    }
}