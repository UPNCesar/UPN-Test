namespace app
{
    partial class access
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
            this.acceso = new System.Windows.Forms.Button();
            this.password2 = new System.Windows.Forms.TextBox();
            this.password1 = new System.Windows.Forms.TextBox();
            this.user_n = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.registrarse = new System.Windows.Forms.Button();
            this.invitado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // acceso
            // 
            this.acceso.Location = new System.Drawing.Point(179, 175);
            this.acceso.Name = "acceso";
            this.acceso.Size = new System.Drawing.Size(75, 23);
            this.acceso.TabIndex = 1;
            this.acceso.Text = ">";
            this.acceso.UseVisualStyleBackColor = true;
            this.acceso.Click += new System.EventHandler(this.acceso_Click);
            // 
            // password2
            // 
            this.password2.Location = new System.Drawing.Point(168, 124);
            this.password2.Name = "password2";
            this.password2.Size = new System.Drawing.Size(100, 20);
            this.password2.TabIndex = 2;
            // 
            // password1
            // 
            this.password1.Location = new System.Drawing.Point(168, 85);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(100, 20);
            this.password1.TabIndex = 3;
            // 
            // user_n
            // 
            this.user_n.Location = new System.Drawing.Point(168, 46);
            this.user_n.Name = "user_n";
            this.user_n.Size = new System.Drawing.Size(100, 20);
            this.user_n.TabIndex = 4;
            this.user_n.UseWaitCursor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(168, 30);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(35, 13);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label1";
            // 
            // registrarse
            // 
            this.registrarse.Location = new System.Drawing.Point(179, 175);
            this.registrarse.Name = "registrarse";
            this.registrarse.Size = new System.Drawing.Size(75, 23);
            this.registrarse.TabIndex = 8;
            this.registrarse.Text = ">";
            this.registrarse.UseVisualStyleBackColor = true;
            this.registrarse.Click += new System.EventHandler(this.registrarse_Click);
            // 
            // invitado
            // 
            this.invitado.Location = new System.Drawing.Point(148, 175);
            this.invitado.Name = "invitado";
            this.invitado.Size = new System.Drawing.Size(142, 23);
            this.invitado.TabIndex = 9;
            this.invitado.Text = ">";
            this.invitado.UseVisualStyleBackColor = true;
            this.invitado.Click += new System.EventHandler(this.invitado_Click);
            // 
            // access
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 232);
            this.Controls.Add(this.invitado);
            this.Controls.Add(this.registrarse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.user_n);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.password2);
            this.Controls.Add(this.acceso);
            this.Name = "access";
            this.Text = "access";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button acceso;
        private System.Windows.Forms.TextBox password2;
        private System.Windows.Forms.TextBox password1;
        private System.Windows.Forms.TextBox user_n;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registrarse;
        private System.Windows.Forms.Button invitado;
    }
}