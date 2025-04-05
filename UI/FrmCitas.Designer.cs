namespace UI
{
    partial class FrmCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCitas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEstilista = new System.Windows.Forms.ComboBox();
            this.cmbClienteId = new System.Windows.Forms.ComboBox();
            this.cmbServicio = new System.Windows.Forms.ComboBox();
            this.dtpCitas = new System.Windows.Forms.DateTimePicker();
            this.cmbHoraInicio = new System.Windows.Forms.ComboBox();
            this.cmbHoraFin = new System.Windows.Forms.ComboBox();
            this.gridCitas = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridCitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTIONES CITAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ESTILISTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "CLIENTE ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "SERVICIO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(422, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "HORA FIN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(402, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "HORA INICIO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(422, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "FECHA";
            // 
            // cmbEstilista
            // 
            this.cmbEstilista.FormattingEnabled = true;
            this.cmbEstilista.Location = new System.Drawing.Point(161, 166);
            this.cmbEstilista.Name = "cmbEstilista";
            this.cmbEstilista.Size = new System.Drawing.Size(121, 28);
            this.cmbEstilista.TabIndex = 7;
            // 
            // cmbClienteId
            // 
            this.cmbClienteId.FormattingEnabled = true;
            this.cmbClienteId.Location = new System.Drawing.Point(161, 214);
            this.cmbClienteId.Name = "cmbClienteId";
            this.cmbClienteId.Size = new System.Drawing.Size(121, 28);
            this.cmbClienteId.TabIndex = 8;
            // 
            // cmbServicio
            // 
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Location = new System.Drawing.Point(149, 260);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(240, 28);
            this.cmbServicio.TabIndex = 9;
            // 
            // dtpCitas
            // 
            this.dtpCitas.Location = new System.Drawing.Point(508, 164);
            this.dtpCitas.Name = "dtpCitas";
            this.dtpCitas.Size = new System.Drawing.Size(200, 26);
            this.dtpCitas.TabIndex = 10;
            // 
            // cmbHoraInicio
            // 
            this.cmbHoraInicio.FormattingEnabled = true;
            this.cmbHoraInicio.Items.AddRange(new object[] {
            "7:00",
            "7:30",
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00"});
            this.cmbHoraInicio.Location = new System.Drawing.Point(517, 214);
            this.cmbHoraInicio.Name = "cmbHoraInicio";
            this.cmbHoraInicio.Size = new System.Drawing.Size(121, 28);
            this.cmbHoraInicio.TabIndex = 11;
            // 
            // cmbHoraFin
            // 
            this.cmbHoraFin.FormattingEnabled = true;
            this.cmbHoraFin.Items.AddRange(new object[] {
            "7:00",
            "7:30",
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00"});
            this.cmbHoraFin.Location = new System.Drawing.Point(517, 260);
            this.cmbHoraFin.Name = "cmbHoraFin";
            this.cmbHoraFin.Size = new System.Drawing.Size(121, 28);
            this.cmbHoraFin.TabIndex = 12;
            // 
            // gridCitas
            // 
            this.gridCitas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCitas.Location = new System.Drawing.Point(12, 405);
            this.gridCitas.Name = "gridCitas";
            this.gridCitas.Size = new System.Drawing.Size(1032, 150);
            this.gridCitas.TabIndex = 13;
            this.gridCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCitas_CellContentClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Navy;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(759, 356);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 38);
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Navy;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(853, 356);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(98, 38);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.Color.Navy;
            this.btnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.ForeColor = System.Drawing.Color.White;
            this.btnAnular.Location = new System.Drawing.Point(957, 356);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(87, 38);
            this.btnAnular.TabIndex = 16;
            this.btnAnular.Text = "ANULAR";
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.Navy;
            this.btnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.ForeColor = System.Drawing.Color.White;
            this.btnValidar.Location = new System.Drawing.Point(12, 324);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(213, 42);
            this.btnValidar.TabIndex = 17;
            this.btnValidar.Text = "VALIDAR DISPONIBILIDAD";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 92);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(380, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(362, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(738, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(314, 92);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // FrmCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 583);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gridCitas);
            this.Controls.Add(this.cmbHoraFin);
            this.Controls.Add(this.cmbHoraInicio);
            this.Controls.Add(this.dtpCitas);
            this.Controls.Add(this.cmbServicio);
            this.Controls.Add(this.cmbClienteId);
            this.Controls.Add(this.cmbEstilista);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmCitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GESTIONES CITAS";
            this.Load += new System.EventHandler(this.FrmCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbEstilista;
        private System.Windows.Forms.ComboBox cmbClienteId;
        private System.Windows.Forms.ComboBox cmbServicio;
        private System.Windows.Forms.DateTimePicker dtpCitas;
        private System.Windows.Forms.ComboBox cmbHoraInicio;
        private System.Windows.Forms.ComboBox cmbHoraFin;
        private System.Windows.Forms.DataGridView gridCitas;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}