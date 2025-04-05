namespace UI
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnServicios = new System.Windows.Forms.Button();
            this.btnHorarios = new System.Windows.Forms.Button();
            this.btnAdmon = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU";
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.MediumBlue;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClientes.Location = new System.Drawing.Point(24, 222);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(119, 50);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnServicios
            // 
            this.btnServicios.BackColor = System.Drawing.Color.Green;
            this.btnServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnServicios.Location = new System.Drawing.Point(24, 299);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Size = new System.Drawing.Size(119, 50);
            this.btnServicios.TabIndex = 2;
            this.btnServicios.Text = "SERVICIOS";
            this.btnServicios.UseVisualStyleBackColor = false;
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);
            // 
            // btnHorarios
            // 
            this.btnHorarios.BackColor = System.Drawing.Color.Navy;
            this.btnHorarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHorarios.Location = new System.Drawing.Point(487, 197);
            this.btnHorarios.Name = "btnHorarios";
            this.btnHorarios.Size = new System.Drawing.Size(119, 38);
            this.btnHorarios.TabIndex = 3;
            this.btnHorarios.Text = "HORARIOS";
            this.btnHorarios.UseVisualStyleBackColor = false;
            this.btnHorarios.Click += new System.EventHandler(this.btnHorarios_Click);
            // 
            // btnAdmon
            // 
            this.btnAdmon.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAdmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdmon.Location = new System.Drawing.Point(624, 197);
            this.btnAdmon.Name = "btnAdmon";
            this.btnAdmon.Size = new System.Drawing.Size(119, 38);
            this.btnAdmon.TabIndex = 4;
            this.btnAdmon.Text = "ADMINISTRADOR";
            this.btnAdmon.UseVisualStyleBackColor = false;
            this.btnAdmon.Click += new System.EventHandler(this.btnAdmon_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCitas.Location = new System.Drawing.Point(24, 364);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(119, 50);
            this.btnCitas.TabIndex = 5;
            this.btnCitas.Text = "AGENDAR CITA";
            this.btnCitas.UseVisualStyleBackColor = false;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(765, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCitas);
            this.Controls.Add(this.btnAdmon);
            this.Controls.Add(this.btnHorarios);
            this.Controls.Add(this.btnServicios);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnServicios;
        private System.Windows.Forms.Button btnHorarios;
        private System.Windows.Forms.Button btnAdmon;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}