namespace Laboratorioderepaso
{
    partial class FormAsistencia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxEmpleados = new System.Windows.Forms.ComboBox();
            this.numericMes = new System.Windows.Forms.NumericUpDown();
            this.numericHorasxMes = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarAsistencia = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHorasxMes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "No, de Empleado ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Horas x Mes";
            // 
            // comboBoxEmpleados
            // 
            this.comboBoxEmpleados.FormattingEnabled = true;
            this.comboBoxEmpleados.Location = new System.Drawing.Point(211, 56);
            this.comboBoxEmpleados.Name = "comboBoxEmpleados";
            this.comboBoxEmpleados.Size = new System.Drawing.Size(210, 24);
            this.comboBoxEmpleados.TabIndex = 4;
            this.comboBoxEmpleados.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmpleados_SelectedIndexChanged);
            // 
            // numericMes
            // 
            this.numericMes.Location = new System.Drawing.Point(211, 96);
            this.numericMes.Name = "numericMes";
            this.numericMes.Size = new System.Drawing.Size(120, 22);
            this.numericMes.TabIndex = 5;
            this.numericMes.ValueChanged += new System.EventHandler(this.numericMes_ValueChanged);
            // 
            // numericHorasxMes
            // 
            this.numericHorasxMes.Location = new System.Drawing.Point(211, 138);
            this.numericHorasxMes.Name = "numericHorasxMes";
            this.numericHorasxMes.Size = new System.Drawing.Size(120, 22);
            this.numericHorasxMes.TabIndex = 6;
            this.numericHorasxMes.ValueChanged += new System.EventHandler(this.numericHorasxMes_ValueChanged);
            // 
            // btnAgregarAsistencia
            // 
            this.btnAgregarAsistencia.Location = new System.Drawing.Point(61, 225);
            this.btnAgregarAsistencia.Name = "btnAgregarAsistencia";
            this.btnAgregarAsistencia.Size = new System.Drawing.Size(122, 45);
            this.btnAgregarAsistencia.TabIndex = 7;
            this.btnAgregarAsistencia.Text = "Agregar Asistencia";
            this.btnAgregarAsistencia.UseVisualStyleBackColor = true;
            this.btnAgregarAsistencia.Click += new System.EventHandler(this.btnAgregarAsistencia_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(211, 225);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(115, 45);
            this.btnReporte.TabIndex = 8;
            this.btnReporte.Text = "Ir a Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(61, 305);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(122, 42);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // FormAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 433);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnAgregarAsistencia);
            this.Controls.Add(this.numericHorasxMes);
            this.Controls.Add(this.numericMes);
            this.Controls.Add(this.comboBoxEmpleados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAsistencia";
            this.Text = "FormAsistencia";
            this.Load += new System.EventHandler(this.FormAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHorasxMes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxEmpleados;
        private System.Windows.Forms.NumericUpDown numericMes;
        private System.Windows.Forms.NumericUpDown numericHorasxMes;
        private System.Windows.Forms.Button btnAgregarAsistencia;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnCerrar;
    }
}