namespace app.fomularios
{
    partial class DateRegistre
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
            this.Lb1 = new System.Windows.Forms.Label();
            this.LB2 = new System.Windows.Forms.Label();
            this.TXB1 = new System.Windows.Forms.TextBox();
            this.TXB2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lb1
            // 
            this.Lb1.AutoSize = true;
            this.Lb1.Location = new System.Drawing.Point(58, 39);
            this.Lb1.Name = "Lb1";
            this.Lb1.Size = new System.Drawing.Size(35, 13);
            this.Lb1.TabIndex = 0;
            this.Lb1.Text = "label1";
            // 
            // LB2
            // 
            this.LB2.AutoSize = true;
            this.LB2.Location = new System.Drawing.Point(58, 109);
            this.LB2.Name = "LB2";
            this.LB2.Size = new System.Drawing.Size(35, 13);
            this.LB2.TabIndex = 1;
            this.LB2.Text = "label2";
            // 
            // TXB1
            // 
            this.TXB1.Location = new System.Drawing.Point(61, 67);
            this.TXB1.Name = "TXB1";
            this.TXB1.Size = new System.Drawing.Size(196, 20);
            this.TXB1.TabIndex = 2;
            // 
            // TXB2
            // 
            this.TXB2.Location = new System.Drawing.Point(61, 143);
            this.TXB2.Name = "TXB2";
            this.TXB2.Size = new System.Drawing.Size(196, 20);
            this.TXB2.TabIndex = 3;
            // 
            // DateRegistre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 239);
            this.Controls.Add(this.TXB2);
            this.Controls.Add(this.TXB1);
            this.Controls.Add(this.LB2);
            this.Controls.Add(this.Lb1);
            this.Name = "DateRegistre";
            this.Text = "DateRegistre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb1;
        private System.Windows.Forms.Label LB2;
        private System.Windows.Forms.TextBox TXB1;
        private System.Windows.Forms.TextBox TXB2;
    }
}