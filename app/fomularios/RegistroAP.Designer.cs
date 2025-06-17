namespace app.fomularios
{
    partial class RegistroAP
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
            this.LBalums = new System.Windows.Forms.ListBox();
            this.LBpadres = new System.Windows.Forms.ListBox();
            this.LBprofesores = new System.Windows.Forms.ListBox();
            this.Btnaddest = new System.Windows.Forms.Button();
            this.BtnEliminarest = new System.Windows.Forms.Button();
            this.BtnEditest = new System.Windows.Forms.Button();
            this.BtnMenuPrincipal = new System.Windows.Forms.Button();
            this.Lbinstrucc = new System.Windows.Forms.Label();
            this.RbEstudiante = new System.Windows.Forms.RadioButton();
            this.RbProfesor = new System.Windows.Forms.RadioButton();
            this.RbPadres = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GbEstudiante = new System.Windows.Forms.GroupBox();
            this.GbProfes = new System.Windows.Forms.GroupBox();
            this.BtnAddProfe = new System.Windows.Forms.Button();
            this.BtnEliminarPRofe = new System.Windows.Forms.Button();
            this.BtnEditProfe = new System.Windows.Forms.Button();
            this.Gbpadres = new System.Windows.Forms.GroupBox();
            this.BtnAddPadre = new System.Windows.Forms.Button();
            this.BtnEliminarPadre = new System.Windows.Forms.Button();
            this.BtnEditPadre = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.GbEstudiante.SuspendLayout();
            this.GbProfes.SuspendLayout();
            this.Gbpadres.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBalums
            // 
            this.LBalums.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LBalums.FormattingEnabled = true;
            this.LBalums.Location = new System.Drawing.Point(25, 38);
            this.LBalums.Name = "LBalums";
            this.LBalums.Size = new System.Drawing.Size(529, 381);
            this.LBalums.TabIndex = 1;
            // 
            // LBpadres
            // 
            this.LBpadres.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBpadres.FormattingEnabled = true;
            this.LBpadres.Location = new System.Drawing.Point(25, 55);
            this.LBpadres.Name = "LBpadres";
            this.LBpadres.Size = new System.Drawing.Size(529, 381);
            this.LBpadres.TabIndex = 2;
            // 
            // LBprofesores
            // 
            this.LBprofesores.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LBprofesores.FormattingEnabled = true;
            this.LBprofesores.Location = new System.Drawing.Point(25, 68);
            this.LBprofesores.Name = "LBprofesores";
            this.LBprofesores.Size = new System.Drawing.Size(529, 381);
            this.LBprofesores.TabIndex = 3;
            // 
            // Btnaddest
            // 
            this.Btnaddest.Location = new System.Drawing.Point(32, 50);
            this.Btnaddest.Name = "Btnaddest";
            this.Btnaddest.Size = new System.Drawing.Size(141, 23);
            this.Btnaddest.TabIndex = 4;
            this.Btnaddest.Text = "Agregar Estudiante";
            this.Btnaddest.UseVisualStyleBackColor = true;
            this.Btnaddest.Click += new System.EventHandler(this.Btnaddest_Click);
            // 
            // BtnEliminarest
            // 
            this.BtnEliminarest.Location = new System.Drawing.Point(32, 92);
            this.BtnEliminarest.Name = "BtnEliminarest";
            this.BtnEliminarest.Size = new System.Drawing.Size(141, 23);
            this.BtnEliminarest.TabIndex = 7;
            this.BtnEliminarest.Text = "Eliminar Estudiante";
            this.BtnEliminarest.UseVisualStyleBackColor = true;
            // 
            // BtnEditest
            // 
            this.BtnEditest.Location = new System.Drawing.Point(32, 138);
            this.BtnEditest.Name = "BtnEditest";
            this.BtnEditest.Size = new System.Drawing.Size(141, 23);
            this.BtnEditest.TabIndex = 8;
            this.BtnEditest.Text = "Editar Estudante";
            this.BtnEditest.UseVisualStyleBackColor = true;
            // 
            // BtnMenuPrincipal
            // 
            this.BtnMenuPrincipal.Location = new System.Drawing.Point(647, 415);
            this.BtnMenuPrincipal.Name = "BtnMenuPrincipal";
            this.BtnMenuPrincipal.Size = new System.Drawing.Size(141, 23);
            this.BtnMenuPrincipal.TabIndex = 9;
            this.BtnMenuPrincipal.Text = "Menú Principal";
            this.BtnMenuPrincipal.UseVisualStyleBackColor = true;
            // 
            // Lbinstrucc
            // 
            this.Lbinstrucc.AutoSize = true;
            this.Lbinstrucc.Location = new System.Drawing.Point(22, 9);
            this.Lbinstrucc.Name = "Lbinstrucc";
            this.Lbinstrucc.Size = new System.Drawing.Size(90, 13);
            this.Lbinstrucc.TabIndex = 10;
            this.Lbinstrucc.Text = "Instrucciones text";
            // 
            // RbEstudiante
            // 
            this.RbEstudiante.AutoSize = true;
            this.RbEstudiante.Checked = true;
            this.RbEstudiante.Location = new System.Drawing.Point(15, 22);
            this.RbEstudiante.Name = "RbEstudiante";
            this.RbEstudiante.Size = new System.Drawing.Size(80, 17);
            this.RbEstudiante.TabIndex = 11;
            this.RbEstudiante.TabStop = true;
            this.RbEstudiante.Text = "Estudiantes";
            this.RbEstudiante.UseVisualStyleBackColor = true;
            this.RbEstudiante.CheckedChanged += new System.EventHandler(this.RbEstudiante_CheckedChanged);
            // 
            // RbProfesor
            // 
            this.RbProfesor.AutoSize = true;
            this.RbProfesor.Location = new System.Drawing.Point(15, 68);
            this.RbProfesor.Name = "RbProfesor";
            this.RbProfesor.Size = new System.Drawing.Size(75, 17);
            this.RbProfesor.TabIndex = 12;
            this.RbProfesor.Text = "Profesores";
            this.RbProfesor.UseVisualStyleBackColor = true;
            this.RbProfesor.CheckedChanged += new System.EventHandler(this.RbProfesor_CheckedChanged);
            // 
            // RbPadres
            // 
            this.RbPadres.AutoSize = true;
            this.RbPadres.Location = new System.Drawing.Point(15, 45);
            this.RbPadres.Name = "RbPadres";
            this.RbPadres.Size = new System.Drawing.Size(58, 17);
            this.RbPadres.TabIndex = 13;
            this.RbPadres.Text = "Padres";
            this.RbPadres.UseVisualStyleBackColor = true;
            this.RbPadres.CheckedChanged += new System.EventHandler(this.RbPadres_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbProfesor);
            this.groupBox1.Controls.Add(this.RbPadres);
            this.groupBox1.Controls.Add(this.RbEstudiante);
            this.groupBox1.Location = new System.Drawing.Point(572, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categorias";
            // 
            // GbEstudiante
            // 
            this.GbEstudiante.Controls.Add(this.Btnaddest);
            this.GbEstudiante.Controls.Add(this.BtnEliminarest);
            this.GbEstudiante.Controls.Add(this.BtnEditest);
            this.GbEstudiante.Location = new System.Drawing.Point(572, 188);
            this.GbEstudiante.Name = "GbEstudiante";
            this.GbEstudiante.Size = new System.Drawing.Size(201, 184);
            this.GbEstudiante.TabIndex = 15;
            this.GbEstudiante.TabStop = false;
            this.GbEstudiante.Text = "Panel editor";
            // 
            // GbProfes
            // 
            this.GbProfes.Controls.Add(this.BtnAddProfe);
            this.GbProfes.Controls.Add(this.BtnEliminarPRofe);
            this.GbProfes.Controls.Add(this.BtnEditProfe);
            this.GbProfes.Location = new System.Drawing.Point(325, 29);
            this.GbProfes.Name = "GbProfes";
            this.GbProfes.Size = new System.Drawing.Size(201, 184);
            this.GbProfes.TabIndex = 16;
            this.GbProfes.TabStop = false;
            this.GbProfes.Text = "Panel editor";
            // 
            // BtnAddProfe
            // 
            this.BtnAddProfe.Location = new System.Drawing.Point(32, 50);
            this.BtnAddProfe.Name = "BtnAddProfe";
            this.BtnAddProfe.Size = new System.Drawing.Size(141, 23);
            this.BtnAddProfe.TabIndex = 4;
            this.BtnAddProfe.Text = "Agregar Profesor";
            this.BtnAddProfe.UseVisualStyleBackColor = true;
            this.BtnAddProfe.Click += new System.EventHandler(this.BtnAddProfe_Click);
            // 
            // BtnEliminarPRofe
            // 
            this.BtnEliminarPRofe.Location = new System.Drawing.Point(32, 92);
            this.BtnEliminarPRofe.Name = "BtnEliminarPRofe";
            this.BtnEliminarPRofe.Size = new System.Drawing.Size(141, 23);
            this.BtnEliminarPRofe.TabIndex = 7;
            this.BtnEliminarPRofe.Text = "Eliminar Profesor";
            this.BtnEliminarPRofe.UseVisualStyleBackColor = true;
            // 
            // BtnEditProfe
            // 
            this.BtnEditProfe.Location = new System.Drawing.Point(32, 138);
            this.BtnEditProfe.Name = "BtnEditProfe";
            this.BtnEditProfe.Size = new System.Drawing.Size(141, 23);
            this.BtnEditProfe.TabIndex = 8;
            this.BtnEditProfe.Text = "Editar Profesor";
            this.BtnEditProfe.UseVisualStyleBackColor = true;
            // 
            // Gbpadres
            // 
            this.Gbpadres.Controls.Add(this.BtnAddPadre);
            this.Gbpadres.Controls.Add(this.BtnEliminarPadre);
            this.Gbpadres.Controls.Add(this.BtnEditPadre);
            this.Gbpadres.Location = new System.Drawing.Point(334, 238);
            this.Gbpadres.Name = "Gbpadres";
            this.Gbpadres.Size = new System.Drawing.Size(201, 184);
            this.Gbpadres.TabIndex = 17;
            this.Gbpadres.TabStop = false;
            this.Gbpadres.Text = "Panel editor";
            // 
            // BtnAddPadre
            // 
            this.BtnAddPadre.Location = new System.Drawing.Point(32, 50);
            this.BtnAddPadre.Name = "BtnAddPadre";
            this.BtnAddPadre.Size = new System.Drawing.Size(141, 23);
            this.BtnAddPadre.TabIndex = 4;
            this.BtnAddPadre.Text = "Agregar Padre";
            this.BtnAddPadre.UseVisualStyleBackColor = true;
            this.BtnAddPadre.Click += new System.EventHandler(this.BtnAddPadre_Click);
            // 
            // BtnEliminarPadre
            // 
            this.BtnEliminarPadre.Location = new System.Drawing.Point(32, 92);
            this.BtnEliminarPadre.Name = "BtnEliminarPadre";
            this.BtnEliminarPadre.Size = new System.Drawing.Size(141, 23);
            this.BtnEliminarPadre.TabIndex = 7;
            this.BtnEliminarPadre.Text = "Eliminar Padre";
            this.BtnEliminarPadre.UseVisualStyleBackColor = true;
            // 
            // BtnEditPadre
            // 
            this.BtnEditPadre.Location = new System.Drawing.Point(32, 138);
            this.BtnEditPadre.Name = "BtnEditPadre";
            this.BtnEditPadre.Size = new System.Drawing.Size(141, 23);
            this.BtnEditPadre.TabIndex = 8;
            this.BtnEditPadre.Text = "Editar Padre";
            this.BtnEditPadre.UseVisualStyleBackColor = true;
            // 
            // RegistroAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Gbpadres);
            this.Controls.Add(this.GbProfes);
            this.Controls.Add(this.GbEstudiante);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Lbinstrucc);
            this.Controls.Add(this.BtnMenuPrincipal);
            this.Controls.Add(this.LBprofesores);
            this.Controls.Add(this.LBpadres);
            this.Controls.Add(this.LBalums);
            this.Name = "RegistroAP";
            this.Text = "RegistroAP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GbEstudiante.ResumeLayout(false);
            this.GbProfes.ResumeLayout(false);
            this.Gbpadres.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox LBalums;
        private System.Windows.Forms.ListBox LBpadres;
        private System.Windows.Forms.ListBox LBprofesores;
        private System.Windows.Forms.Button Btnaddest;
        private System.Windows.Forms.Button BtnEliminarest;
        private System.Windows.Forms.Button BtnEditest;
        private System.Windows.Forms.Button BtnMenuPrincipal;
        private System.Windows.Forms.Label Lbinstrucc;
        private System.Windows.Forms.RadioButton RbEstudiante;
        private System.Windows.Forms.RadioButton RbProfesor;
        private System.Windows.Forms.RadioButton RbPadres;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox GbEstudiante;
        private System.Windows.Forms.GroupBox GbProfes;
        private System.Windows.Forms.Button BtnAddProfe;
        private System.Windows.Forms.Button BtnEliminarPRofe;
        private System.Windows.Forms.Button BtnEditProfe;
        private System.Windows.Forms.GroupBox Gbpadres;
        private System.Windows.Forms.Button BtnAddPadre;
        private System.Windows.Forms.Button BtnEliminarPadre;
        private System.Windows.Forms.Button BtnEditPadre;
    }
}