namespace clase8
{
    partial class Principal
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
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnCursos = new System.Windows.Forms.Button();
            this.pbxProfesores = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfesores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.Location = new System.Drawing.Point(283, 147);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(248, 36);
            this.btnAlumnos.TabIndex = 0;
            this.btnAlumnos.Text = "alumnos";
            this.btnAlumnos.UseVisualStyleBackColor = true;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(283, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(248, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "profesores";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(283, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(248, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "carreras";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(283, 320);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(248, 36);
            this.button4.TabIndex = 3;
            this.button4.Text = "materias";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCursos
            // 
            this.btnCursos.Location = new System.Drawing.Point(283, 376);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(248, 36);
            this.btnCursos.TabIndex = 4;
            this.btnCursos.Text = "cursos";
            this.btnCursos.UseVisualStyleBackColor = true;
            this.btnCursos.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbxProfesores
            // 
            this.pbxProfesores.Image = global::clase8.Properties.Resources.profe;
            this.pbxProfesores.Location = new System.Drawing.Point(73, 247);
            this.pbxProfesores.Name = "pbxProfesores";
            this.pbxProfesores.Size = new System.Drawing.Size(100, 94);
            this.pbxProfesores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProfesores.TabIndex = 6;
            this.pbxProfesores.TabStop = false;
            this.pbxProfesores.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::clase8.Properties.Resources.salir;
            this.pictureBox1.Location = new System.Drawing.Point(684, 354);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxProfesores);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCursos);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAlumnos);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfesores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbxProfesores;
    }
}