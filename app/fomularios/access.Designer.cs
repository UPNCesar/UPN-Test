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
            this.cancel = new System.Windows.Forms.Button();
            this.Create_institucion = new System.Windows.Forms.Button();
            this.password3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // acceso
            // 
            this.acceso.Location = new System.Drawing.Point(181, 195);
            this.acceso.Name = "acceso";
            this.acceso.Size = new System.Drawing.Size(75, 23);
            this.acceso.TabIndex = 1;
            this.acceso.Text = ">";
            this.acceso.UseVisualStyleBackColor = true;
            this.acceso.Click += new System.EventHandler(this.acceso_Click);
            // 
            // password2
            // 
            this.password2.Location = new System.Drawing.Point(172, 102);
            this.password2.Name = "password2";
            this.password2.Size = new System.Drawing.Size(100, 20);
            this.password2.TabIndex = 2;
            // 
            // password1
            // 
            this.password1.Location = new System.Drawing.Point(172, 63);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(100, 20);
            this.password1.TabIndex = 3;
            // 
            // user_n
            // 
            this.user_n.Location = new System.Drawing.Point(172, 24);
            this.user_n.Name = "user_n";
            this.user_n.Size = new System.Drawing.Size(100, 20);
            this.user_n.TabIndex = 4;
            this.user_n.UseWaitCursor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(172, 8);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(35, 13);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label1";
            // 
            // registrarse
            // 
            this.registrarse.Location = new System.Drawing.Point(181, 195);
            this.registrarse.Name = "registrarse";
            this.registrarse.Size = new System.Drawing.Size(75, 23);
            this.registrarse.TabIndex = 8;
            this.registrarse.Text = ">";
            this.registrarse.UseVisualStyleBackColor = true;
            this.registrarse.Click += new System.EventHandler(this.registrarse_Click);
            // 
            // invitado
            // 
            this.invitado.Location = new System.Drawing.Point(150, 195);
            this.invitado.Name = "invitado";
            this.invitado.Size = new System.Drawing.Size(142, 23);
            this.invitado.TabIndex = 9;
            this.invitado.Text = ">";
            this.invitado.UseVisualStyleBackColor = true;
            this.invitado.Click += new System.EventHandler(this.invitado_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(381, 192);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(74, 28);
            this.cancel.TabIndex = 10;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Create_institucion
            // 
            this.Create_institucion.Location = new System.Drawing.Point(150, 182);
            this.Create_institucion.Name = "Create_institucion";
            this.Create_institucion.Size = new System.Drawing.Size(142, 23);
            this.Create_institucion.TabIndex = 11;
            this.Create_institucion.Text = "inst";
            this.Create_institucion.UseVisualStyleBackColor = true;
            this.Create_institucion.Click += new System.EventHandler(this.Create_institucion_Click);
            // 
            // password3
            // 
            this.password3.Location = new System.Drawing.Point(172, 146);
            this.password3.Name = "password3";
            this.password3.Size = new System.Drawing.Size(100, 20);
            this.password3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "label1";
            // 
            // access
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 232);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.password3);
            this.Controls.Add(this.Create_institucion);
            this.Controls.Add(this.cancel);
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
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button Create_institucion;
        private System.Windows.Forms.TextBox password3;
        private System.Windows.Forms.Label label4;
    }
}