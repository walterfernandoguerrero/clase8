namespace clase8
{
    partial class frmProfesores
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
            this.pbxExit = new System.Windows.Forms.PictureBox();
            this.dgvProfesores = new System.Windows.Forms.DataGridView();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pbxVolver = new System.Windows.Forms.PictureBox();
            this.pbxEditar = new System.Windows.Forms.PictureBox();
            this.pbxGrabar = new System.Windows.Forms.PictureBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGrabar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxExit
            // 
            this.pbxExit.Image = global::clase8.Properties.Resources.salir;
            this.pbxExit.Location = new System.Drawing.Point(712, 424);
            this.pbxExit.Name = "pbxExit";
            this.pbxExit.Size = new System.Drawing.Size(76, 78);
            this.pbxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxExit.TabIndex = 0;
            this.pbxExit.TabStop = false;
            this.pbxExit.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dgvProfesores
            // 
            this.dgvProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesores.Location = new System.Drawing.Point(26, 42);
            this.dgvProfesores.Name = "dgvProfesores";
            this.dgvProfesores.Size = new System.Drawing.Size(621, 215);
            this.dgvProfesores.TabIndex = 1;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(678, 42);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(110, 39);
            this.btnGrabar.TabIndex = 2;
            this.btnGrabar.Text = "AgregarProfesor";
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(678, 113);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(110, 37);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(678, 181);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 37);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // pbxVolver
            // 
            this.pbxVolver.Image = global::clase8.Properties.Resources.volverMenu;
            this.pbxVolver.Location = new System.Drawing.Point(616, 424);
            this.pbxVolver.Name = "pbxVolver";
            this.pbxVolver.Size = new System.Drawing.Size(76, 78);
            this.pbxVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxVolver.TabIndex = 5;
            this.pbxVolver.TabStop = false;
            this.pbxVolver.Click += new System.EventHandler(this.pbxVolver_Click);
            // 
            // pbxEditar
            // 
            this.pbxEditar.Image = global::clase8.Properties.Resources.EditarLapiz;
            this.pbxEditar.Location = new System.Drawing.Point(129, 424);
            this.pbxEditar.Name = "pbxEditar";
            this.pbxEditar.Size = new System.Drawing.Size(76, 78);
            this.pbxEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEditar.TabIndex = 6;
            this.pbxEditar.TabStop = false;
            // 
            // pbxGrabar
            // 
            this.pbxGrabar.Image = global::clase8.Properties.Resources.disco_flexible;
            this.pbxGrabar.Location = new System.Drawing.Point(26, 424);
            this.pbxGrabar.Name = "pbxGrabar";
            this.pbxGrabar.Size = new System.Drawing.Size(76, 78);
            this.pbxGrabar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxGrabar.TabIndex = 7;
            this.pbxGrabar.TabStop = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(26, 298);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(40, 20);
            this.txtId.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 298);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 20);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(101, 282);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 13);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(23, 279);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "ID:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(319, 279);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(62, 13);
            this.lblApellido.TabIndex = 13;
            this.lblApellido.Text = "APELLIDO:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(322, 298);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(201, 20);
            this.txtApellido.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(23, 339);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 13);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "EMAIL:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(26, 355);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(210, 339);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(67, 13);
            this.lblTelefono.TabIndex = 17;
            this.lblTelefono.Text = "TELEFONO:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(213, 355);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(150, 20);
            this.txtTelefono.TabIndex = 16;
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(402, 353);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(121, 21);
            this.cboEstado.TabIndex = 18;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(399, 337);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(54, 13);
            this.lblEstado.TabIndex = 19;
            this.lblEstado.Text = "ESTADO:";
            // 
            // frmProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.pbxGrabar);
            this.Controls.Add(this.pbxEditar);
            this.Controls.Add(this.pbxVolver);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.dgvProfesores);
            this.Controls.Add(this.pbxExit);
            this.Name = "frmProfesores";
            this.Text = "frmProfesores";
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGrabar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxExit;
        private System.Windows.Forms.DataGridView dgvProfesores;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox pbxVolver;
        private System.Windows.Forms.PictureBox pbxEditar;
        private System.Windows.Forms.PictureBox pbxGrabar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label lblEstado;
    }
}