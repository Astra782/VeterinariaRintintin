namespace VeterinariaRintintin
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.EtiquetaEncabezado = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_ajustes = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_report = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_registro = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_consultas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EtiquetaEncabezado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 56);
            this.panel1.TabIndex = 0;
            // 
            // EtiquetaEncabezado
            // 
            this.EtiquetaEncabezado.AutoSize = true;
            this.EtiquetaEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.EtiquetaEncabezado.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiquetaEncabezado.Location = new System.Drawing.Point(0, 0);
            this.EtiquetaEncabezado.Name = "EtiquetaEncabezado";
            this.EtiquetaEncabezado.Size = new System.Drawing.Size(207, 25);
            this.EtiquetaEncabezado.TabIndex = 0;
            this.EtiquetaEncabezado.Text = "RinTinTin Vet Center";
            this.EtiquetaEncabezado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EtiquetaEncabezado.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 344);
            this.panel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_ajustes);
            this.panel6.Location = new System.Drawing.Point(14, 256);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(416, 74);
            this.panel6.TabIndex = 3;
            // 
            // btn_ajustes
            // 
            this.btn_ajustes.BackColor = System.Drawing.Color.LightCyan;
            this.btn_ajustes.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.btn_ajustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajustes.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajustes.Location = new System.Drawing.Point(14, 7);
            this.btn_ajustes.Name = "btn_ajustes";
            this.btn_ajustes.Size = new System.Drawing.Size(389, 60);
            this.btn_ajustes.TabIndex = 3;
            this.btn_ajustes.Text = "Ajustes";
            this.btn_ajustes.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_report);
            this.panel5.Location = new System.Drawing.Point(14, 176);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(416, 74);
            this.panel5.TabIndex = 2;
            // 
            // btn_report
            // 
            this.btn_report.BackColor = System.Drawing.Color.LightCyan;
            this.btn_report.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_report.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.Location = new System.Drawing.Point(14, 7);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(389, 60);
            this.btn_report.TabIndex = 2;
            this.btn_report.Text = "Reportes y Facturacion";
            this.btn_report.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_registro);
            this.panel4.Location = new System.Drawing.Point(14, 96);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(416, 74);
            this.panel4.TabIndex = 1;
            // 
            // btn_registro
            // 
            this.btn_registro.BackColor = System.Drawing.Color.LightCyan;
            this.btn_registro.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.btn_registro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registro.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registro.Location = new System.Drawing.Point(14, 8);
            this.btn_registro.Name = "btn_registro";
            this.btn_registro.Size = new System.Drawing.Size(389, 60);
            this.btn_registro.TabIndex = 1;
            this.btn_registro.Text = "Registros";
            this.btn_registro.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_consultas);
            this.panel3.Location = new System.Drawing.Point(14, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 74);
            this.panel3.TabIndex = 0;
            // 
            // btn_consultas
            // 
            this.btn_consultas.BackColor = System.Drawing.Color.LightCyan;
            this.btn_consultas.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.btn_consultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultas.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultas.Location = new System.Drawing.Point(13, 7);
            this.btn_consultas.Name = "btn_consultas";
            this.btn_consultas.Size = new System.Drawing.Size(389, 60);
            this.btn_consultas.TabIndex = 0;
            this.btn_consultas.Text = "Consultas";
            this.btn_consultas.UseVisualStyleBackColor = false;
            this.btn_consultas.Click += new System.EventHandler(this.button1_Click);
            this.btn_consultas.MouseHover += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(444, 406);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "RinTinTin Vet Center";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label EtiquetaEncabezado;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_ajustes;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_registro;
        private System.Windows.Forms.Button btn_consultas;
    }
}

