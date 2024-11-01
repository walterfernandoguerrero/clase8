namespace clase8.formularios
{
    partial class frmMateria
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
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboProfe = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCarrera = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.btnGrabarMateria = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.pbxGuardar = new System.Windows.Forms.PictureBox();
            this.pbxEditar = new System.Windows.Forms.PictureBox();
            this.pbxExit = new System.Windows.Forms.PictureBox();
            this.pbxAtras = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Location = new System.Drawing.Point(40, 12);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterias.Size = new System.Drawing.Size(642, 150);
            this.dgvMaterias.TabIndex = 0;
            this.dgvMaterias.DoubleClick += new System.EventHandler(this.dgvMaterias_DoubleClick);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(40, 205);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(49, 20);
            this.txtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NOMBRE MATERIA:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(130, 205);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // cboProfe
            // 
            this.cboProfe.FormattingEnabled = true;
            this.cboProfe.Location = new System.Drawing.Point(286, 203);
            this.cboProfe.Name = "cboProfe";
            this.cboProfe.Size = new System.Drawing.Size(173, 21);
            this.cboProfe.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "PROFESOR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CARRERA:";
            // 
            // cboCarrera
            // 
            this.cboCarrera.FormattingEnabled = true;
            this.cboCarrera.Location = new System.Drawing.Point(465, 203);
            this.cboCarrera.Name = "cboCarrera";
            this.cboCarrera.Size = new System.Drawing.Size(217, 21);
            this.cboCarrera.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ESTADO:";
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cboEstado.Location = new System.Drawing.Point(130, 257);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(121, 21);
            this.cboEstado.TabIndex = 9;
            // 
            // btnGrabarMateria
            // 
            this.btnGrabarMateria.Location = new System.Drawing.Point(705, 31);
            this.btnGrabarMateria.Name = "btnGrabarMateria";
            this.btnGrabarMateria.Size = new System.Drawing.Size(161, 23);
            this.btnGrabarMateria.TabIndex = 11;
            this.btnGrabarMateria.Text = "grabarMateria";
            this.btnGrabarMateria.UseVisualStyleBackColor = true;
            this.btnGrabarMateria.Click += new System.EventHandler(this.btnGrabarMateria_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(705, 75);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(161, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(705, 117);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(161, 23);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // pbxGuardar
            // 
            this.pbxGuardar.Image = global::clase8.Properties.Resources.disco_flexible;
            this.pbxGuardar.Location = new System.Drawing.Point(40, 340);
            this.pbxGuardar.Name = "pbxGuardar";
            this.pbxGuardar.Size = new System.Drawing.Size(84, 74);
            this.pbxGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxGuardar.TabIndex = 17;
            this.pbxGuardar.TabStop = false;
            this.pbxGuardar.Click += new System.EventHandler(this.pbxGuardar_Click);
            // 
            // pbxEditar
            // 
            this.pbxEditar.Image = global::clase8.Properties.Resources.EditarLapiz;
            this.pbxEditar.Location = new System.Drawing.Point(151, 340);
            this.pbxEditar.Name = "pbxEditar";
            this.pbxEditar.Size = new System.Drawing.Size(84, 74);
            this.pbxEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEditar.TabIndex = 16;
            this.pbxEditar.TabStop = false;
            this.pbxEditar.Click += new System.EventHandler(this.pbxEditar_Click);
            // 
            // pbxExit
            // 
            this.pbxExit.Image = global::clase8.Properties.Resources.salir;
            this.pbxExit.Location = new System.Drawing.Point(795, 340);
            this.pbxExit.Name = "pbxExit";
            this.pbxExit.Size = new System.Drawing.Size(84, 74);
            this.pbxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxExit.TabIndex = 15;
            this.pbxExit.TabStop = false;
            this.pbxExit.Click += new System.EventHandler(this.pbxExit_Click);
            // 
            // pbxAtras
            // 
            this.pbxAtras.Image = global::clase8.Properties.Resources.volverMenu;
            this.pbxAtras.Location = new System.Drawing.Point(705, 340);
            this.pbxAtras.Name = "pbxAtras";
            this.pbxAtras.Size = new System.Drawing.Size(84, 74);
            this.pbxAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAtras.TabIndex = 14;
            this.pbxAtras.TabStop = false;
            this.pbxAtras.Click += new System.EventHandler(this.pbxAtras_Click);
            // 
            // frmMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pbxGuardar);
            this.Controls.Add(this.pbxEditar);
            this.Controls.Add(this.pbxExit);
            this.Controls.Add(this.pbxAtras);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGrabarMateria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboCarrera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboProfe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dgvMaterias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMateria";
            this.Text = "frmMateria";
            this.Load += new System.EventHandler(this.frmMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboProfe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboCarrera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Button btnGrabarMateria;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.PictureBox pbxAtras;
        private System.Windows.Forms.PictureBox pbxExit;
        private System.Windows.Forms.PictureBox pbxEditar;
        private System.Windows.Forms.PictureBox pbxGuardar;
    }
}