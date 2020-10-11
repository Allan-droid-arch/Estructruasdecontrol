namespace Estructurasdecontrol_Allan_Fuentes.Formularios
{
    partial class FrmCompra_de_10_Productos
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
            this.btncalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.total1 = new System.Windows.Forms.TextBox();
            this.uni1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listname = new System.Windows.Forms.ListBox();
            this.listuni = new System.Windows.Forms.ListBox();
            this.listpre = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(159, 400);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 30);
            this.btncalcular.TabIndex = 0;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese los Productos";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(37, 38);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(167, 25);
            this.name.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(433, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "Ingrese el Precio";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(437, 38);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(113, 25);
            this.p1.TabIndex = 23;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(261, 400);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 30);
            this.btncancelar.TabIndex = 33;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(367, 400);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 30);
            this.btnsalir.TabIndex = 34;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(257, 349);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 20);
            this.label13.TabIndex = 35;
            this.label13.Text = "Total aPagar";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // total1
            // 
            this.total1.Location = new System.Drawing.Point(367, 349);
            this.total1.Name = "total1";
            this.total1.ReadOnly = true;
            this.total1.Size = new System.Drawing.Size(113, 25);
            this.total1.TabIndex = 36;
            this.total1.Text = "0.00";
            this.total1.TextChanged += new System.EventHandler(this.textBox21_TextChanged);
            // 
            // uni1
            // 
            this.uni1.Location = new System.Drawing.Point(261, 38);
            this.uni1.Name = "uni1";
            this.uni1.Size = new System.Drawing.Size(67, 25);
            this.uni1.TabIndex = 37;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(257, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 20);
            this.label14.TabIndex = 38;
            this.label14.Text = "Unidades";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 39;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listname
            // 
            this.listname.AllowDrop = true;
            this.listname.ColumnWidth = 5;
            this.listname.FormattingEnabled = true;
            this.listname.ItemHeight = 20;
            this.listname.Location = new System.Drawing.Point(71, 168);
            this.listname.Name = "listname";
            this.listname.Size = new System.Drawing.Size(163, 164);
            this.listname.TabIndex = 40;
            this.listname.SelectedIndexChanged += new System.EventHandler(this.listname_SelectedIndexChanged);
            // 
            // listuni
            // 
            this.listuni.FormattingEnabled = true;
            this.listuni.ItemHeight = 20;
            this.listuni.Location = new System.Drawing.Point(226, 168);
            this.listuni.Name = "listuni";
            this.listuni.Size = new System.Drawing.Size(63, 164);
            this.listuni.TabIndex = 41;
            // 
            // listpre
            // 
            this.listpre.FormattingEnabled = true;
            this.listpre.ItemHeight = 20;
            this.listpre.Location = new System.Drawing.Point(286, 168);
            this.listpre.Name = "listpre";
            this.listpre.Size = new System.Drawing.Size(168, 164);
            this.listpre.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Unidades";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Total";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 46;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmCompra_de_10_Productos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(589, 447);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listpre);
            this.Controls.Add(this.listuni);
            this.Controls.Add(this.listname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.uni1);
            this.Controls.Add(this.total1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncalcular);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCompra_de_10_Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra_de_10_Productos";
            this.Load += new System.EventHandler(this.FrmCompra_de_10_Productos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox p1;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox total1;
        private System.Windows.Forms.TextBox uni1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listname;
        private System.Windows.Forms.ListBox listuni;
        private System.Windows.Forms.ListBox listpre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}