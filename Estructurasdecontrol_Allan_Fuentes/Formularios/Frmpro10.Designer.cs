namespace Estructurasdecontrol_Allan_Fuentes.Formularios
{
    partial class Frmpro10
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
            this.btnagregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.alumno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nota = new System.Windows.Forms.TextBox();
            this.listnombre = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listnota = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listobsevacion = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.aprobado = new System.Windows.Forms.TextBox();
            this.reprobado = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(284, 58);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 0;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de alumno";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // alumno
            // 
            this.alumno.Location = new System.Drawing.Point(183, 23);
            this.alumno.Name = "alumno";
            this.alumno.Size = new System.Drawing.Size(216, 20);
            this.alumno.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nota";
            // 
            // nota
            // 
            this.nota.Location = new System.Drawing.Point(183, 60);
            this.nota.Name = "nota";
            this.nota.Size = new System.Drawing.Size(86, 20);
            this.nota.TabIndex = 4;
            // 
            // listnombre
            // 
            this.listnombre.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listnombre.FormattingEnabled = true;
            this.listnombre.ItemHeight = 20;
            this.listnombre.Location = new System.Drawing.Point(26, 121);
            this.listnombre.Name = "listnombre";
            this.listnombre.Size = new System.Drawing.Size(153, 144);
            this.listnombre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(179, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nota";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listnota
            // 
            this.listnota.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listnota.FormattingEnabled = true;
            this.listnota.ItemHeight = 20;
            this.listnota.Location = new System.Drawing.Point(174, 121);
            this.listnota.Name = "listnota";
            this.listnota.Size = new System.Drawing.Size(63, 144);
            this.listnota.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(233, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Obserbacion";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listobsevacion
            // 
            this.listobsevacion.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listobsevacion.FormattingEnabled = true;
            this.listobsevacion.ItemHeight = 20;
            this.listobsevacion.Location = new System.Drawing.Point(237, 121);
            this.listobsevacion.Name = "listobsevacion";
            this.listobsevacion.Size = new System.Drawing.Size(90, 144);
            this.listobsevacion.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(351, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total Aprobado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(351, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total Reprobado";
            // 
            // aprobado
            // 
            this.aprobado.Location = new System.Drawing.Point(461, 130);
            this.aprobado.Name = "aprobado";
            this.aprobado.Size = new System.Drawing.Size(41, 20);
            this.aprobado.TabIndex = 13;
            // 
            // reprobado
            // 
            this.reprobado.Location = new System.Drawing.Point(461, 168);
            this.reprobado.Name = "reprobado";
            this.reprobado.Size = new System.Drawing.Size(41, 20);
            this.reprobado.TabIndex = 14;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(355, 216);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 15;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // Frmpro10
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(576, 280);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.reprobado);
            this.Controls.Add(this.aprobado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listobsevacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listnota);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listnombre);
            this.Controls.Add(this.nota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.alumno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnagregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmpro10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promedio 10 estudiantes";
            this.Load += new System.EventHandler(this.Frmpro10_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox alumno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nota;
        private System.Windows.Forms.ListBox listnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listnota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listobsevacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox aprobado;
        private System.Windows.Forms.TextBox reprobado;
        private System.Windows.Forms.Button btncancelar;
    }
}