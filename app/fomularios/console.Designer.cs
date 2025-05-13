namespace app.fomularios
{
    partial class console
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
            this.MultConsol = new System.Windows.Forms.RichTextBox();
            this.ViewActi = new System.Windows.Forms.Button();
            this.Admdelreg = new System.Windows.Forms.Button();
            this.reportesView = new System.Windows.Forms.Button();
            this.delREports = new System.Windows.Forms.Button();
            this.leave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MultConsol
            // 
            this.MultConsol.Location = new System.Drawing.Point(0, -1);
            this.MultConsol.Name = "MultConsol";
            this.MultConsol.ReadOnly = true;
            this.MultConsol.Size = new System.Drawing.Size(513, 416);
            this.MultConsol.TabIndex = 0;
            this.MultConsol.Text = "";
            // 
            // ViewActi
            // 
            this.ViewActi.Location = new System.Drawing.Point(12, 421);
            this.ViewActi.Name = "ViewActi";
            this.ViewActi.Size = new System.Drawing.Size(110, 26);
            this.ViewActi.TabIndex = 1;
            this.ViewActi.Text = "Mostrar actividad";
            this.ViewActi.UseVisualStyleBackColor = true;
            this.ViewActi.Click += new System.EventHandler(this.ViewActi_Click);
            // 
            // Admdelreg
            // 
            this.Admdelreg.Location = new System.Drawing.Point(380, 421);
            this.Admdelreg.Name = "Admdelreg";
            this.Admdelreg.Size = new System.Drawing.Size(122, 26);
            this.Admdelreg.TabIndex = 2;
            this.Admdelreg.Text = "Eliminar Registros";
            this.Admdelreg.UseVisualStyleBackColor = true;
            this.Admdelreg.Click += new System.EventHandler(this.Admdelreg_Click);
            // 
            // reportesView
            // 
            this.reportesView.Location = new System.Drawing.Point(12, 421);
            this.reportesView.Name = "reportesView";
            this.reportesView.Size = new System.Drawing.Size(110, 26);
            this.reportesView.TabIndex = 3;
            this.reportesView.Text = "Ver reportes";
            this.reportesView.UseVisualStyleBackColor = true;
            this.reportesView.Click += new System.EventHandler(this.reportesView_Click);
            // 
            // delREports
            // 
            this.delREports.Location = new System.Drawing.Point(380, 421);
            this.delREports.Name = "delREports";
            this.delREports.Size = new System.Drawing.Size(122, 26);
            this.delREports.TabIndex = 4;
            this.delREports.Text = "Eliminar Reportes";
            this.delREports.UseVisualStyleBackColor = true;
            this.delREports.Click += new System.EventHandler(this.delREports_Click);
            // 
            // leave
            // 
            this.leave.Location = new System.Drawing.Point(180, 421);
            this.leave.Name = "leave";
            this.leave.Size = new System.Drawing.Size(110, 26);
            this.leave.TabIndex = 5;
            this.leave.Text = "Salir ";
            this.leave.UseVisualStyleBackColor = true;
            this.leave.Click += new System.EventHandler(this.leave_Click);
            // 
            // console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 449);
            this.Controls.Add(this.leave);
            this.Controls.Add(this.delREports);
            this.Controls.Add(this.reportesView);
            this.Controls.Add(this.Admdelreg);
            this.Controls.Add(this.ViewActi);
            this.Controls.Add(this.MultConsol);
            this.Name = "console";
            this.Text = "console";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox MultConsol;
        private System.Windows.Forms.Button ViewActi;
        private System.Windows.Forms.Button Admdelreg;
        private System.Windows.Forms.Button reportesView;
        private System.Windows.Forms.Button delREports;
        private System.Windows.Forms.Button leave;
    }
}