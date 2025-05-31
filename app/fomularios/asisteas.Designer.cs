namespace app.fomularios
{
    partial class asisteas
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
            this.Boton_asistencias = new System.Windows.Forms.Button();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Boton_asistencias
            // 
            this.Boton_asistencias.Location = new System.Drawing.Point(111, 56);
            this.Boton_asistencias.Name = "Boton_asistencias";
            this.Boton_asistencias.Size = new System.Drawing.Size(161, 47);
            this.Boton_asistencias.TabIndex = 0;
            this.Boton_asistencias.Text = "button1";
            this.Boton_asistencias.UseVisualStyleBackColor = true;
            this.Boton_asistencias.Click += new System.EventHandler(this.Boton_asistencias_Click);
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(345, 67);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(290, 22);
            this.Txt1.TabIndex = 1;
            // 
            // asisteas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txt1);
            this.Controls.Add(this.Boton_asistencias);
            this.Name = "asisteas";
            this.Text = "asisteas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton_asistencias;
        private System.Windows.Forms.TextBox Txt1;
    }
}