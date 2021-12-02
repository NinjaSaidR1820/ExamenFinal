namespace ExamenFinal
{
    partial class Form1
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
            this.btnAgregarEstudiante = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.carnet = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbAsignatura = new System.Windows.Forms.ComboBox();
            this.lblNameStudent = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTarea = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtparcialii = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtParciali = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSistematico = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.listViewnotas = new System.Windows.Forms.ListView();
            this.nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.apellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.municipio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.depart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.asig = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sistem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Iparcial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IIParcial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.home = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.notafinal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarEstudiante
            // 
            this.btnAgregarEstudiante.Location = new System.Drawing.Point(149, 104);
            this.btnAgregarEstudiante.Name = "btnAgregarEstudiante";
            this.btnAgregarEstudiante.Size = new System.Drawing.Size(118, 34);
            this.btnAgregarEstudiante.TabIndex = 0;
            this.btnAgregarEstudiante.Text = "AgregarEstudiante";
            this.btnAgregarEstudiante.UseVisualStyleBackColor = true;
            this.btnAgregarEstudiante.Click += new System.EventHandler(this.BtnAgregarEstudiante_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(710, 104);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(108, 34);
            this.btncancelar.TabIndex = 1;
            this.btncancelar.Text = "cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.Btncancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registro De Notas De Estudiantes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(728, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(774, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(44, 13);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "lblfecha";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDepartamento);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMunicipio);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCarnet);
            this.groupBox1.Controls.Add(this.carnet);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.cbAsignatura);
            this.groupBox1.Controls.Add(this.lblNameStudent);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(42, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1045, 82);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "info. Estudiante";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(826, 37);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(168, 20);
            this.txtDepartamento.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(839, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Departamento";
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Location = new System.Drawing.Point(677, 37);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(129, 20);
            this.txtMunicipio.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(694, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Municipio";
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(521, 36);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(129, 20);
            this.txtCarnet.TabIndex = 7;
            // 
            // carnet
            // 
            this.carnet.AutoSize = true;
            this.carnet.Location = new System.Drawing.Point(537, 20);
            this.carnet.Name = "carnet";
            this.carnet.Size = new System.Drawing.Size(38, 13);
            this.carnet.TabIndex = 6;
            this.carnet.Text = "Carnet";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(377, 36);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(129, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(227, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(129, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // cbAsignatura
            // 
            this.cbAsignatura.FormattingEnabled = true;
            this.cbAsignatura.Items.AddRange(new object[] {
            "Contabilidad",
            "Sociologia",
            "Matematica II",
            "Ingles II",
            "AlgebraLineal",
            "Programacion I"});
            this.cbAsignatura.Location = new System.Drawing.Point(17, 36);
            this.cbAsignatura.Name = "cbAsignatura";
            this.cbAsignatura.Size = new System.Drawing.Size(200, 21);
            this.cbAsignatura.TabIndex = 2;
            // 
            // lblNameStudent
            // 
            this.lblNameStudent.AutoSize = true;
            this.lblNameStudent.Location = new System.Drawing.Point(224, 20);
            this.lblNameStudent.Name = "lblNameStudent";
            this.lblNameStudent.Size = new System.Drawing.Size(44, 13);
            this.lblNameStudent.TabIndex = 1;
            this.lblNameStudent.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Asignatura";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1012, 654);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTarea);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtparcialii);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtParciali);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtSistematico);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(50, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(738, 82);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "info notas";
            // 
            // txtTarea
            // 
            this.txtTarea.Location = new System.Drawing.Point(550, 39);
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.Size = new System.Drawing.Size(129, 20);
            this.txtTarea.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(567, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tarea";
            // 
            // txtparcialii
            // 
            this.txtparcialii.Location = new System.Drawing.Point(394, 38);
            this.txtparcialii.Name = "txtparcialii";
            this.txtparcialii.Size = new System.Drawing.Size(129, 20);
            this.txtparcialii.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(410, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "II parcial";
            // 
            // txtParciali
            // 
            this.txtParciali.Location = new System.Drawing.Point(250, 38);
            this.txtParciali.Name = "txtParciali";
            this.txtParciali.Size = new System.Drawing.Size(129, 20);
            this.txtParciali.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(263, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "I parcial";
            // 
            // txtSistematico
            // 
            this.txtSistematico.Location = new System.Drawing.Point(100, 38);
            this.txtSistematico.Name = "txtSistematico";
            this.txtSistematico.Size = new System.Drawing.Size(129, 20);
            this.txtSistematico.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(97, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Sistematico";
            // 
            // listViewnotas
            // 
            this.listViewnotas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nombre,
            this.apellido,
            this.columnHeader3,
            this.municipio,
            this.depart,
            this.asig,
            this.sistem,
            this.Iparcial,
            this.IIParcial,
            this.home,
            this.notafinal,
            this.prom});
            this.listViewnotas.GridLines = true;
            this.listViewnotas.HideSelection = false;
            this.listViewnotas.Location = new System.Drawing.Point(27, 357);
            this.listViewnotas.Name = "listViewnotas";
            this.listViewnotas.Size = new System.Drawing.Size(990, 201);
            this.listViewnotas.TabIndex = 9;
            this.listViewnotas.UseCompatibleStateImageBehavior = false;
            this.listViewnotas.View = System.Windows.Forms.View.Details;
            // 
            // nombre
            // 
            this.nombre.Text = "nombre";
            this.nombre.Width = 80;
            // 
            // apellido
            // 
            this.apellido.Text = "apellido";
            this.apellido.Width = 84;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "carnet";
            this.columnHeader3.Width = 102;
            // 
            // municipio
            // 
            this.municipio.Text = "municipio";
            this.municipio.Width = 74;
            // 
            // depart
            // 
            this.depart.Text = "depart.";
            this.depart.Width = 71;
            // 
            // asig
            // 
            this.asig.Text = "asig.";
            this.asig.Width = 105;
            // 
            // sistem
            // 
            this.sistem.Text = "sistem.";
            this.sistem.Width = 100;
            // 
            // Iparcial
            // 
            this.Iparcial.Text = "Iparcial";
            this.Iparcial.Width = 113;
            // 
            // IIParcial
            // 
            this.IIParcial.Text = "IIParcial";
            this.IIParcial.Width = 89;
            // 
            // home
            // 
            this.home.Text = "tarea";
            this.home.Width = 63;
            // 
            // notafinal
            // 
            this.notafinal.Text = "NotaFinal";
            this.notafinal.Width = 59;
            // 
            // prom
            // 
            this.prom.Text = "prom";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 726);
            this.Controls.Add(this.listViewnotas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnAgregarEstudiante);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarEstudiante;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbAsignatura;
        private System.Windows.Forms.Label lblNameStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.Label carnet;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTarea;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtparcialii;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtParciali;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSistematico;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView listViewnotas;
        private System.Windows.Forms.ColumnHeader nombre;
        private System.Windows.Forms.ColumnHeader apellido;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader municipio;
        private System.Windows.Forms.ColumnHeader depart;
        private System.Windows.Forms.ColumnHeader asig;
        private System.Windows.Forms.ColumnHeader sistem;
        private System.Windows.Forms.ColumnHeader Iparcial;
        private System.Windows.Forms.ColumnHeader IIParcial;
        private System.Windows.Forms.ColumnHeader home;
        private System.Windows.Forms.ColumnHeader notafinal;
        private System.Windows.Forms.ColumnHeader prom;
    }
}

