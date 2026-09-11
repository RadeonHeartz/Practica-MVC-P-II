namespace CapaVista_Prototipoumg2k26
{
    partial class FormularioPeliculas
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
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.p_ingresoDatos = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_clasificacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.txt_duracion = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_director = new System.Windows.Forms.TextBox();
            this.txt_trailer = new System.Windows.Forms.TextBox();
            this.dtp_estreno = new System.Windows.Forms.DateTimePicker();
            this.dgv_peliculas = new System.Windows.Forms.DataGridView();
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.p_ingresoDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_peliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(12, 12);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(725, 22);
            this.txt_buscar.TabIndex = 0;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_buscar.Location = new System.Drawing.Point(757, 12);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 34);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // p_ingresoDatos
            // 
            this.p_ingresoDatos.Controls.Add(this.button1);
            this.p_ingresoDatos.Controls.Add(this.dtp_estreno);
            this.p_ingresoDatos.Controls.Add(this.txt_trailer);
            this.p_ingresoDatos.Controls.Add(this.txt_director);
            this.p_ingresoDatos.Controls.Add(this.txt_descripcion);
            this.p_ingresoDatos.Controls.Add(this.txt_duracion);
            this.p_ingresoDatos.Controls.Add(this.txt_titulo);
            this.p_ingresoDatos.Controls.Add(this.txt_estado);
            this.p_ingresoDatos.Controls.Add(this.label8);
            this.p_ingresoDatos.Controls.Add(this.label7);
            this.p_ingresoDatos.Controls.Add(this.label6);
            this.p_ingresoDatos.Controls.Add(this.label5);
            this.p_ingresoDatos.Controls.Add(this.label4);
            this.p_ingresoDatos.Controls.Add(this.label3);
            this.p_ingresoDatos.Controls.Add(this.label2);
            this.p_ingresoDatos.Controls.Add(this.txt_clasificacion);
            this.p_ingresoDatos.Controls.Add(this.label1);
            this.p_ingresoDatos.Location = new System.Drawing.Point(838, 12);
            this.p_ingresoDatos.Name = "p_ingresoDatos";
            this.p_ingresoDatos.Size = new System.Drawing.Size(265, 519);
            this.p_ingresoDatos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clasificacion";
            // 
            // txt_clasificacion
            // 
            this.txt_clasificacion.Location = new System.Drawing.Point(22, 48);
            this.txt_clasificacion.Name = "txt_clasificacion";
            this.txt_clasificacion.Size = new System.Drawing.Size(219, 22);
            this.txt_clasificacion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "titulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "duracion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "director";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "descripcion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "trailer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Fecha de estreno";
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(22, 104);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(219, 22);
            this.txt_estado.TabIndex = 9;
            // 
            // txt_titulo
            // 
            this.txt_titulo.Location = new System.Drawing.Point(22, 168);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(219, 22);
            this.txt_titulo.TabIndex = 10;
            // 
            // txt_duracion
            // 
            this.txt_duracion.Location = new System.Drawing.Point(22, 217);
            this.txt_duracion.Name = "txt_duracion";
            this.txt_duracion.Size = new System.Drawing.Size(219, 22);
            this.txt_duracion.TabIndex = 11;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(22, 316);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(219, 22);
            this.txt_descripcion.TabIndex = 12;
            // 
            // txt_director
            // 
            this.txt_director.Location = new System.Drawing.Point(22, 265);
            this.txt_director.Name = "txt_director";
            this.txt_director.Size = new System.Drawing.Size(219, 22);
            this.txt_director.TabIndex = 13;
            // 
            // txt_trailer
            // 
            this.txt_trailer.Location = new System.Drawing.Point(22, 360);
            this.txt_trailer.Name = "txt_trailer";
            this.txt_trailer.Size = new System.Drawing.Size(219, 22);
            this.txt_trailer.TabIndex = 14;
            // 
            // dtp_estreno
            // 
            this.dtp_estreno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_estreno.Location = new System.Drawing.Point(22, 417);
            this.dtp_estreno.Name = "dtp_estreno";
            this.dtp_estreno.Size = new System.Drawing.Size(219, 22);
            this.dtp_estreno.TabIndex = 15;
            // 
            // dgv_peliculas
            // 
            this.dgv_peliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_peliculas.Location = new System.Drawing.Point(12, 71);
            this.dgv_peliculas.Name = "dgv_peliculas";
            this.dgv_peliculas.RowHeadersWidth = 51;
            this.dgv_peliculas.RowTemplate.Height = 24;
            this.dgv_peliculas.Size = new System.Drawing.Size(820, 355);
            this.dgv_peliculas.TabIndex = 3;
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_ayuda.Location = new System.Drawing.Point(12, 450);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(75, 40);
            this.btn_ayuda.TabIndex = 4;
            this.btn_ayuda.Text = "ayuda";
            this.btn_ayuda.UseVisualStyleBackColor = false;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_imprimir.Location = new System.Drawing.Point(117, 450);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(75, 40);
            this.btn_imprimir.TabIndex = 5;
            this.btn_imprimir.Text = "imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = false;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_nuevo.Location = new System.Drawing.Point(228, 452);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(75, 38);
            this.btn_nuevo.TabIndex = 6;
            this.btn_nuevo.Text = "nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_editar.Location = new System.Drawing.Point(330, 452);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 38);
            this.btn_editar.TabIndex = 7;
            this.btn_editar.Text = "editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_borrar.Location = new System.Drawing.Point(426, 452);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(75, 38);
            this.btn_borrar.TabIndex = 8;
            this.btn_borrar.Text = "borrar";
            this.btn_borrar.UseVisualStyleBackColor = false;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Location = new System.Drawing.Point(62, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 49);
            this.button1.TabIndex = 16;
            this.button1.Text = "Grabar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 543);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.dgv_peliculas);
            this.Controls.Add(this.p_ingresoDatos);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_buscar);
            this.Name = "txt_search";
            this.Text = "Mantenimiento Peliculas - Prototipo V 0.5.0";
            this.Load += new System.EventHandler(this.FrmPeliculas_Load);
            this.p_ingresoDatos.ResumeLayout(false);
            this.p_ingresoDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_peliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Panel p_ingresoDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_clasificacion;
        private System.Windows.Forms.DateTimePicker dtp_estreno;
        private System.Windows.Forms.TextBox txt_trailer;
        private System.Windows.Forms.TextBox txt_director;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_duracion;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.DataGridView dgv_peliculas;
        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button button1;
    }
}