namespace UI
{
    partial class AdmonCatalogoHorario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbNombreHorario = new System.Windows.Forms.ComboBox();
            this.cmbDinicio = new System.Windows.Forms.ComboBox();
            this.cmbDfin = new System.Windows.Forms.ComboBox();
            this.cmbHinicio = new System.Windows.Forms.ComboBox();
            this.cmbHfin = new System.Windows.Forms.ComboBox();
            this.cmbDlibre = new System.Windows.Forms.ComboBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestionar Horarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Horario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dia Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dia Fin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hora Inicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Hora Fin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Dia Libre";
            // 
            // cmbNombreHorario
            // 
            this.cmbNombreHorario.FormattingEnabled = true;
            this.cmbNombreHorario.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Mixto"});
            this.cmbNombreHorario.Location = new System.Drawing.Point(131, 97);
            this.cmbNombreHorario.Name = "cmbNombreHorario";
            this.cmbNombreHorario.Size = new System.Drawing.Size(121, 21);
            this.cmbNombreHorario.TabIndex = 13;
            // 
            // cmbDinicio
            // 
            this.cmbDinicio.FormattingEnabled = true;
            this.cmbDinicio.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"});
            this.cmbDinicio.Location = new System.Drawing.Point(131, 145);
            this.cmbDinicio.Name = "cmbDinicio";
            this.cmbDinicio.Size = new System.Drawing.Size(121, 21);
            this.cmbDinicio.TabIndex = 14;
            // 
            // cmbDfin
            // 
            this.cmbDfin.FormattingEnabled = true;
            this.cmbDfin.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"});
            this.cmbDfin.Location = new System.Drawing.Point(131, 196);
            this.cmbDfin.Name = "cmbDfin";
            this.cmbDfin.Size = new System.Drawing.Size(121, 21);
            this.cmbDfin.TabIndex = 15;
            // 
            // cmbHinicio
            // 
            this.cmbHinicio.FormattingEnabled = true;
            this.cmbHinicio.Items.AddRange(new object[] {
            "1:00",
            "2:00",
            "3:00",
            "4:00",
            "5:00",
            "6:00",
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00"});
            this.cmbHinicio.Location = new System.Drawing.Point(360, 94);
            this.cmbHinicio.Name = "cmbHinicio";
            this.cmbHinicio.Size = new System.Drawing.Size(121, 21);
            this.cmbHinicio.TabIndex = 16;
            // 
            // cmbHfin
            // 
            this.cmbHfin.FormattingEnabled = true;
            this.cmbHfin.Items.AddRange(new object[] {
            "1:00",
            "2:00",
            "3:00",
            "4:00",
            "5:00",
            "6:00",
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00"});
            this.cmbHfin.Location = new System.Drawing.Point(360, 145);
            this.cmbHfin.Name = "cmbHfin";
            this.cmbHfin.Size = new System.Drawing.Size(121, 21);
            this.cmbHfin.TabIndex = 17;
            // 
            // cmbDlibre
            // 
            this.cmbDlibre.FormattingEnabled = true;
            this.cmbDlibre.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"});
            this.cmbDlibre.Location = new System.Drawing.Point(360, 204);
            this.cmbDlibre.Name = "cmbDlibre";
            this.cmbDlibre.Size = new System.Drawing.Size(121, 21);
            this.cmbDlibre.TabIndex = 18;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(104, 256);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 19;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(216, 256);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(331, 256);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(75, 23);
            this.btnAnular.TabIndex = 21;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(435, 139);
            this.dataGridView1.TabIndex = 22;
            // 
            // AdmonCatalogoHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.cmbDlibre);
            this.Controls.Add(this.cmbHfin);
            this.Controls.Add(this.cmbHinicio);
            this.Controls.Add(this.cmbDfin);
            this.Controls.Add(this.cmbDinicio);
            this.Controls.Add(this.cmbNombreHorario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdmonCatalogoHorario";
            this.Text = "AdmonCatalogoHorario";
            this.Load += new System.EventHandler(this.AdmonCatalogoHorario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbNombreHorario;
        private System.Windows.Forms.ComboBox cmbDinicio;
        private System.Windows.Forms.ComboBox cmbDfin;
        private System.Windows.Forms.ComboBox cmbHinicio;
        private System.Windows.Forms.ComboBox cmbHfin;
        private System.Windows.Forms.ComboBox cmbDlibre;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}