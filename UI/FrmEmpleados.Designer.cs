using System;

namespace UI
{

  
    partial class FrmEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleados));
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtVacaciones = new System.Windows.Forms.TextBox();
            this.gridEmpleados = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.dtpFingreso = new System.Windows.Forms.DateTimePicker();
            this.cmbCHorario = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTIONES EMPLEADOS";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(85, 96);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(72, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "APELLIDO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(412, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "CORREO ELECTRONICO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(412, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "NUMERO TELEFONICO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "FECHA DE INGRESO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(389, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "VACACIONES ACUMULADAS";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(170, 96);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(143, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(170, 168);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(143, 20);
            this.txtApellido.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(599, 91);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(143, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(599, 154);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(143, 20);
            this.txtTelefono.TabIndex = 11;
            // 
            // txtVacaciones
            // 
            this.txtVacaciones.Location = new System.Drawing.Point(605, 232);
            this.txtVacaciones.Name = "txtVacaciones";
            this.txtVacaciones.Size = new System.Drawing.Size(143, 20);
            this.txtVacaciones.TabIndex = 12;
            // 
            // gridEmpleados
            // 
            this.gridEmpleados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpleados.Location = new System.Drawing.Point(48, 362);
            this.gridEmpleados.Name = "gridEmpleados";
            this.gridEmpleados.Size = new System.Drawing.Size(725, 150);
            this.gridEmpleados.TabIndex = 13;
            this.gridEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEmpleados_CellContentClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Navy;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(450, 326);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(93, 30);
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Navy;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(559, 326);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(93, 30);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.Color.Navy;
            this.btnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.ForeColor = System.Drawing.Color.White;
            this.btnAnular.Location = new System.Drawing.Point(670, 326);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(93, 30);
            this.btnAnular.TabIndex = 16;
            this.btnAnular.Text = "ANULAR";
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // dtpFingreso
            // 
            this.dtpFingreso.Location = new System.Drawing.Point(170, 229);
            this.dtpFingreso.Name = "dtpFingreso";
            this.dtpFingreso.Size = new System.Drawing.Size(200, 20);
            this.dtpFingreso.TabIndex = 17;
            // 
            // cmbCHorario
            // 
            this.cmbCHorario.FormattingEnabled = true;
            this.cmbCHorario.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbCHorario.Location = new System.Drawing.Point(605, 272);
            this.cmbCHorario.Name = "cmbCHorario";
            this.cmbCHorario.Size = new System.Drawing.Size(121, 21);
            this.cmbCHorario.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(503, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "ID HORARIO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbCHorario);
            this.Controls.Add(this.dtpFingreso);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gridEmpleados);
            this.Controls.Add(this.txtVacaciones);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label1);
            this.Name = "FrmEmpleados";
            this.Text = "FrmEmpleados";
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtVacaciones;
        private System.Windows.Forms.DataGridView gridEmpleados;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.DateTimePicker dtpFingreso;
        private System.Windows.Forms.ComboBox cmbCHorario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}