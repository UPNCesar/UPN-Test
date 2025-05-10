namespace app.fomularios
{
    partial class aplicacionadmin
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
            this.button1 = new System.Windows.Forms.Button();
            this.consoleAdmin = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Eliminar database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // consoleAdmin
            // 
            this.consoleAdmin.Location = new System.Drawing.Point(382, 12);
            this.consoleAdmin.Name = "consoleAdmin";
            this.consoleAdmin.ReadOnly = true;
            this.consoleAdmin.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.consoleAdmin.Size = new System.Drawing.Size(393, 405);
            this.consoleAdmin.TabIndex = 1;
            this.consoleAdmin.Text = "";
            // 
            // aplicacionadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.consoleAdmin);
            this.Controls.Add(this.button1);
            this.Name = "aplicacionadmin";
            this.Text = "aplicacionadmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox consoleAdmin;
    }
}