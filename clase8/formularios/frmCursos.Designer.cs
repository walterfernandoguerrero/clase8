namespace clase8.formularios
{
    partial class frmCursos
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
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboAlumno = new System.Windows.Forms.ComboBox();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gbxBuscar = new System.Windows.Forms.GroupBox();
            this.rbtAlumno = new System.Windows.Forms.RadioButton();
            this.rbtMateria = new System.Windows.Forms.RadioButton();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCursos
            // 
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Location = new System.Drawing.Point(62, 86);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.Size = new System.Drawing.Size(664, 209);
            this.dgvCursos.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::clase8.Properties.Resources.salir;
            this.pictureBox1.Location = new System.Drawing.Point(728, 417);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cboAlumno
            // 
            this.cboAlumno.FormattingEnabled = true;
            this.cboAlumno.Location = new System.Drawing.Point(62, 341);
            this.cboAlumno.Name = "cboAlumno";
            this.cboAlumno.Size = new System.Drawing.Size(302, 21);
            this.cboAlumno.TabIndex = 3;
            this.cboAlumno.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cboMateria
            // 
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(381, 341);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(263, 21);
            this.cboMateria.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Alumno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Materia:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(661, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "CargarMateria";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbxBuscar
            // 
            this.gbxBuscar.Controls.Add(this.txtFiltrar);
            this.gbxBuscar.Controls.Add(this.rbtMateria);
            this.gbxBuscar.Controls.Add(this.rbtAlumno);
            this.gbxBuscar.Location = new System.Drawing.Point(62, 13);
            this.gbxBuscar.Name = "gbxBuscar";
            this.gbxBuscar.Size = new System.Drawing.Size(664, 67);
            this.gbxBuscar.TabIndex = 8;
            this.gbxBuscar.TabStop = false;
            this.gbxBuscar.Text = "Filtrar";
            this.gbxBuscar.Enter += new System.EventHandler(this.gbxBuscar_Enter);
            // 
            // rbtAlumno
            // 
            this.rbtAlumno.AutoSize = true;
            this.rbtAlumno.Location = new System.Drawing.Point(394, 34);
            this.rbtAlumno.Name = "rbtAlumno";
            this.rbtAlumno.Size = new System.Drawing.Size(59, 17);
            this.rbtAlumno.TabIndex = 0;
            this.rbtAlumno.TabStop = true;
            this.rbtAlumno.Text = "alumno";
            this.rbtAlumno.UseVisualStyleBackColor = true;
            // 
            // rbtMateria
            // 
            this.rbtMateria.AutoSize = true;
            this.rbtMateria.Location = new System.Drawing.Point(523, 34);
            this.rbtMateria.Name = "rbtMateria";
            this.rbtMateria.Size = new System.Drawing.Size(59, 17);
            this.rbtMateria.TabIndex = 1;
            this.rbtMateria.TabStop = true;
            this.rbtMateria.Text = "materia";
            this.rbtMateria.UseVisualStyleBackColor = true;
            this.rbtMateria.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(33, 19);
            this.txtFiltrar.Multiline = true;
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(306, 32);
            this.txtFiltrar.TabIndex = 2;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.gbxBuscar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(this.cboAlumno);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvCursos);
            this.Name = "frmCursos";
            this.Text = "frmCursos";
            this.Load += new System.EventHandler(this.frmCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxBuscar.ResumeLayout(false);
            this.gbxBuscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboAlumno;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbxBuscar;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.RadioButton rbtMateria;
        private System.Windows.Forms.RadioButton rbtAlumno;
    }
}