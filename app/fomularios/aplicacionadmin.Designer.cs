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
            this.ClearConsole = new System.Windows.Forms.Button();
            this.addAdmin = new System.Windows.Forms.Button();
            this.DeleteAdmin = new System.Windows.Forms.Button();
            this.ListInst = new System.Windows.Forms.Button();
            this.ListUsers = new System.Windows.Forms.Button();
            this.BugandClaim = new System.Windows.Forms.Button();
            this.ActivityAdmin = new System.Windows.Forms.Button();
            this.EditListUsers = new System.Windows.Forms.Button();
            this.EditListInst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 403);
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
            this.consoleAdmin.Size = new System.Drawing.Size(393, 313);
            this.consoleAdmin.TabIndex = 1;
            this.consoleAdmin.Text = "";
            // 
            // ClearConsole
            // 
            this.ClearConsole.BackColor = System.Drawing.Color.Red;
            this.ClearConsole.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ClearConsole.Location = new System.Drawing.Point(607, 315);
            this.ClearConsole.Name = "ClearConsole";
            this.ClearConsole.Size = new System.Drawing.Size(137, 36);
            this.ClearConsole.TabIndex = 2;
            this.ClearConsole.Text = "Limpiar consola";
            this.ClearConsole.UseVisualStyleBackColor = false;
            this.ClearConsole.Click += new System.EventHandler(this.ClearConsole_Click);
            // 
            // addAdmin
            // 
            this.addAdmin.BackColor = System.Drawing.Color.Lime;
            this.addAdmin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addAdmin.Location = new System.Drawing.Point(33, 242);
            this.addAdmin.Name = "addAdmin";
            this.addAdmin.Size = new System.Drawing.Size(158, 36);
            this.addAdmin.TabIndex = 3;
            this.addAdmin.Text = "Agregar Administrador";
            this.addAdmin.UseVisualStyleBackColor = false;
            this.addAdmin.Click += new System.EventHandler(this.addAdmin_Click);
            // 
            // DeleteAdmin
            // 
            this.DeleteAdmin.BackColor = System.Drawing.Color.Lime;
            this.DeleteAdmin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteAdmin.Location = new System.Drawing.Point(33, 191);
            this.DeleteAdmin.Name = "DeleteAdmin";
            this.DeleteAdmin.Size = new System.Drawing.Size(158, 36);
            this.DeleteAdmin.TabIndex = 4;
            this.DeleteAdmin.Text = "Eliminar administrador";
            this.DeleteAdmin.UseVisualStyleBackColor = false;
            this.DeleteAdmin.Click += new System.EventHandler(this.DeleteAdmin_Click);
            // 
            // ListInst
            // 
            this.ListInst.Location = new System.Drawing.Point(33, 139);
            this.ListInst.Name = "ListInst";
            this.ListInst.Size = new System.Drawing.Size(158, 35);
            this.ListInst.TabIndex = 5;
            this.ListInst.Text = "Ver Instituciones creadas";
            this.ListInst.UseVisualStyleBackColor = true;
            this.ListInst.Click += new System.EventHandler(this.ListInst_Click);
            // 
            // ListUsers
            // 
            this.ListUsers.Location = new System.Drawing.Point(33, 88);
            this.ListUsers.Name = "ListUsers";
            this.ListUsers.Size = new System.Drawing.Size(158, 35);
            this.ListUsers.TabIndex = 6;
            this.ListUsers.Text = "Ver usuarios registrados";
            this.ListUsers.UseVisualStyleBackColor = true;
            this.ListUsers.Click += new System.EventHandler(this.ListUsers_Click);
            // 
            // BugandClaim
            // 
            this.BugandClaim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BugandClaim.Location = new System.Drawing.Point(33, 36);
            this.BugandClaim.Name = "BugandClaim";
            this.BugandClaim.Size = new System.Drawing.Size(158, 35);
            this.BugandClaim.TabIndex = 7;
            this.BugandClaim.Text = "Reportes y reclamos";
            this.BugandClaim.UseVisualStyleBackColor = false;
            this.BugandClaim.Click += new System.EventHandler(this.BugandClaim_Click);
            // 
            // ActivityAdmin
            // 
            this.ActivityAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ActivityAdmin.Location = new System.Drawing.Point(33, 298);
            this.ActivityAdmin.Name = "ActivityAdmin";
            this.ActivityAdmin.Size = new System.Drawing.Size(158, 35);
            this.ActivityAdmin.TabIndex = 8;
            this.ActivityAdmin.Text = "Ver actividad de administradores";
            this.ActivityAdmin.UseVisualStyleBackColor = false;
            this.ActivityAdmin.Click += new System.EventHandler(this.ActivityAdmin_Click);
            // 
            // EditListUsers
            // 
            this.EditListUsers.Location = new System.Drawing.Point(197, 88);
            this.EditListUsers.Name = "EditListUsers";
            this.EditListUsers.Size = new System.Drawing.Size(158, 35);
            this.EditListUsers.TabIndex = 10;
            this.EditListUsers.Text = "Editar usuarios registrados";
            this.EditListUsers.UseVisualStyleBackColor = true;
            this.EditListUsers.Click += new System.EventHandler(this.EditListUsers_Click);
            // 
            // EditListInst
            // 
            this.EditListInst.Location = new System.Drawing.Point(197, 139);
            this.EditListInst.Name = "EditListInst";
            this.EditListInst.Size = new System.Drawing.Size(158, 35);
            this.EditListInst.TabIndex = 9;
            this.EditListInst.Text = "Editar Instituciones creadas";
            this.EditListInst.UseVisualStyleBackColor = true;
            this.EditListInst.Click += new System.EventHandler(this.EditListInst_Click);
            // 
            // aplicacionadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditListUsers);
            this.Controls.Add(this.EditListInst);
            this.Controls.Add(this.ActivityAdmin);
            this.Controls.Add(this.BugandClaim);
            this.Controls.Add(this.ListUsers);
            this.Controls.Add(this.ListInst);
            this.Controls.Add(this.DeleteAdmin);
            this.Controls.Add(this.addAdmin);
            this.Controls.Add(this.ClearConsole);
            this.Controls.Add(this.consoleAdmin);
            this.Controls.Add(this.button1);
            this.Name = "aplicacionadmin";
            this.Text = "aplicacionadmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox consoleAdmin;
        private System.Windows.Forms.Button ClearConsole;
        private System.Windows.Forms.Button addAdmin;
        private System.Windows.Forms.Button DeleteAdmin;
        private System.Windows.Forms.Button ListInst;
        private System.Windows.Forms.Button ListUsers;
        private System.Windows.Forms.Button BugandClaim;
        private System.Windows.Forms.Button ActivityAdmin;
        private System.Windows.Forms.Button EditListUsers;
        private System.Windows.Forms.Button EditListInst;
    }
}