namespace Autodromo.UI.Catalogos
{
    partial class frmCarrera
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
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarrera));
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.dgvCorredor1 = new System.Windows.Forms.DataGridView();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.dgvCorredor2 = new System.Windows.Forms.DataGridView();
         this.Milisegundos1 = new System.Windows.Forms.Timer(this.components);
         this.lblTiempo1 = new System.Windows.Forms.Label();
         this.lblTiempo2 = new System.Windows.Forms.Label();
         this.groupBox3 = new System.Windows.Forms.GroupBox();
         this.Milisegundos2 = new System.Windows.Forms.Timer(this.components);
         this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
         this.btnFinalizar = new System.Windows.Forms.Button();
         this.btnPosicion = new System.Windows.Forms.Button();
         this.pbAdelanto2 = new System.Windows.Forms.PictureBox();
         this.pbAdelanto1 = new System.Windows.Forms.PictureBox();
         this.btnIniciar = new System.Windows.Forms.Button();
         this.pbRojo2 = new System.Windows.Forms.PictureBox();
         this.pbRojo1 = new System.Windows.Forms.PictureBox();
         this.pbVerde1 = new System.Windows.Forms.PictureBox();
         this.pbVerde2 = new System.Windows.Forms.PictureBox();
         this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
         this.groupBox1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dgvCorredor1)).BeginInit();
         this.groupBox2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dgvCorredor2)).BeginInit();
         this.groupBox3.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pbAdelanto2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pbAdelanto1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pbRojo2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pbRojo1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pbVerde1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pbVerde2)).BeginInit();
         this.SuspendLayout();
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.dgvCorredor1);
         this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.groupBox1.ForeColor = System.Drawing.Color.Navy;
         this.groupBox1.Location = new System.Drawing.Point(12, 12);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(773, 227);
         this.groupBox1.TabIndex = 0;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Corredor 1";
         // 
         // dgvCorredor1
         // 
         this.dgvCorredor1.AllowUserToAddRows = false;
         this.dgvCorredor1.AllowUserToDeleteRows = false;
         this.dgvCorredor1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvCorredor1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.dgvCorredor1.Location = new System.Drawing.Point(3, 16);
         this.dgvCorredor1.Name = "dgvCorredor1";
         this.dgvCorredor1.ReadOnly = true;
         this.dgvCorredor1.Size = new System.Drawing.Size(767, 208);
         this.dgvCorredor1.TabIndex = 0;
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.dgvCorredor2);
         this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.groupBox2.ForeColor = System.Drawing.Color.Red;
         this.groupBox2.Location = new System.Drawing.Point(15, 245);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(773, 227);
         this.groupBox2.TabIndex = 1;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Corredor 2";
         // 
         // dgvCorredor2
         // 
         this.dgvCorredor2.AllowUserToAddRows = false;
         this.dgvCorredor2.AllowUserToDeleteRows = false;
         this.dgvCorredor2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvCorredor2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.dgvCorredor2.Location = new System.Drawing.Point(3, 16);
         this.dgvCorredor2.Name = "dgvCorredor2";
         this.dgvCorredor2.ReadOnly = true;
         this.dgvCorredor2.Size = new System.Drawing.Size(767, 208);
         this.dgvCorredor2.TabIndex = 0;
         // 
         // Milisegundos1
         // 
         this.Milisegundos1.Interval = 1;
         this.Milisegundos1.Tick += new System.EventHandler(this.Milisegundos1_Tick);
         // 
         // lblTiempo1
         // 
         this.lblTiempo1.AutoSize = true;
         this.lblTiempo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTiempo1.ForeColor = System.Drawing.Color.Navy;
         this.lblTiempo1.Location = new System.Drawing.Point(13, 32);
         this.lblTiempo1.Name = "lblTiempo1";
         this.lblTiempo1.Size = new System.Drawing.Size(24, 25);
         this.lblTiempo1.TabIndex = 3;
         this.lblTiempo1.Text = "0";
         // 
         // lblTiempo2
         // 
         this.lblTiempo2.AutoSize = true;
         this.lblTiempo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTiempo2.ForeColor = System.Drawing.Color.Red;
         this.lblTiempo2.Location = new System.Drawing.Point(13, 133);
         this.lblTiempo2.Name = "lblTiempo2";
         this.lblTiempo2.Size = new System.Drawing.Size(24, 25);
         this.lblTiempo2.TabIndex = 4;
         this.lblTiempo2.Text = "0";
         // 
         // groupBox3
         // 
         this.groupBox3.Controls.Add(this.lblTiempo1);
         this.groupBox3.Controls.Add(this.lblTiempo2);
         this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.groupBox3.Location = new System.Drawing.Point(924, 241);
         this.groupBox3.Name = "groupBox3";
         this.groupBox3.Size = new System.Drawing.Size(135, 177);
         this.groupBox3.TabIndex = 5;
         this.groupBox3.TabStop = false;
         this.groupBox3.Text = "Tiempos";
         // 
         // Milisegundos2
         // 
         this.Milisegundos2.Interval = 1;
         this.Milisegundos2.Tick += new System.EventHandler(this.Milisegundos2_Tick);
         // 
         // SerialPort1
         // 
         this.SerialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
         // 
         // btnFinalizar
         // 
         this.btnFinalizar.AutoSize = true;
         this.btnFinalizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.btnFinalizar.Enabled = false;
         this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
         this.btnFinalizar.Location = new System.Drawing.Point(917, 183);
         this.btnFinalizar.Name = "btnFinalizar";
         this.btnFinalizar.Size = new System.Drawing.Size(174, 34);
         this.btnFinalizar.TabIndex = 16;
         this.btnFinalizar.Text = "Finalizar Carrera";
         this.btnFinalizar.UseVisualStyleBackColor = true;
         this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
         // 
         // btnPosicion
         // 
         this.btnPosicion.Location = new System.Drawing.Point(932, 139);
         this.btnPosicion.Name = "btnPosicion";
         this.btnPosicion.Size = new System.Drawing.Size(113, 23);
         this.btnPosicion.TabIndex = 17;
         this.btnPosicion.Text = "Verificar Posiciones";
         this.btnPosicion.UseVisualStyleBackColor = true;
         this.btnPosicion.Click += new System.EventHandler(this.btnPosicion_Click);
         // 
         // pbAdelanto2
         // 
         this.pbAdelanto2.Image = global::Autodromo.Properties.Resources.adelanto;
         this.pbAdelanto2.Location = new System.Drawing.Point(847, 328);
         this.pbAdelanto2.Name = "pbAdelanto2";
         this.pbAdelanto2.Size = new System.Drawing.Size(55, 50);
         this.pbAdelanto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pbAdelanto2.TabIndex = 20;
         this.pbAdelanto2.TabStop = false;
         this.toolTip1.SetToolTip(this.pbAdelanto2, "¡Vehículo adelantado!");
         this.pbAdelanto2.Visible = false;
         // 
         // pbAdelanto1
         // 
         this.pbAdelanto1.Image = global::Autodromo.Properties.Resources.adelanto;
         this.pbAdelanto1.Location = new System.Drawing.Point(847, 26);
         this.pbAdelanto1.Name = "pbAdelanto1";
         this.pbAdelanto1.Size = new System.Drawing.Size(55, 50);
         this.pbAdelanto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pbAdelanto1.TabIndex = 19;
         this.pbAdelanto1.TabStop = false;
         this.toolTip1.SetToolTip(this.pbAdelanto1, "¡Vehículo adelantado!");
         this.pbAdelanto1.Visible = false;
         // 
         // btnIniciar
         // 
         this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnIniciar.Image = global::Autodromo.Properties.Resources.Banderas1;
         this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
         this.btnIniciar.Location = new System.Drawing.Point(917, 28);
         this.btnIniciar.Name = "btnIniciar";
         this.btnIniciar.Size = new System.Drawing.Size(142, 83);
         this.btnIniciar.TabIndex = 15;
         this.btnIniciar.Text = "COMENZAR CARERA";
         this.btnIniciar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         this.btnIniciar.UseVisualStyleBackColor = true;
         this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
         // 
         // pbRojo2
         // 
         this.pbRojo2.Image = global::Autodromo.Properties.Resources.semaforo_rojo;
         this.pbRojo2.Location = new System.Drawing.Point(791, 332);
         this.pbRojo2.Name = "pbRojo2";
         this.pbRojo2.Size = new System.Drawing.Size(41, 41);
         this.pbRojo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pbRojo2.TabIndex = 12;
         this.pbRojo2.TabStop = false;
         // 
         // pbRojo1
         // 
         this.pbRojo1.Image = global::Autodromo.Properties.Resources.semaforo_rojo;
         this.pbRojo1.Location = new System.Drawing.Point(791, 28);
         this.pbRojo1.Name = "pbRojo1";
         this.pbRojo1.Size = new System.Drawing.Size(41, 41);
         this.pbRojo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pbRojo1.TabIndex = 10;
         this.pbRojo1.TabStop = false;
         // 
         // pbVerde1
         // 
         this.pbVerde1.Image = global::Autodromo.Properties.Resources.semaforo_verde;
         this.pbVerde1.Location = new System.Drawing.Point(791, 28);
         this.pbVerde1.Name = "pbVerde1";
         this.pbVerde1.Size = new System.Drawing.Size(41, 41);
         this.pbVerde1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pbVerde1.TabIndex = 9;
         this.pbVerde1.TabStop = false;
         // 
         // pbVerde2
         // 
         this.pbVerde2.Image = global::Autodromo.Properties.Resources.semaforo_verde;
         this.pbVerde2.Location = new System.Drawing.Point(791, 332);
         this.pbVerde2.Name = "pbVerde2";
         this.pbVerde2.Size = new System.Drawing.Size(41, 41);
         this.pbVerde2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pbVerde2.TabIndex = 14;
         this.pbVerde2.TabStop = false;
         // 
         // frmCarrera
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1172, 517);
         this.Controls.Add(this.pbAdelanto2);
         this.Controls.Add(this.pbAdelanto1);
         this.Controls.Add(this.btnPosicion);
         this.Controls.Add(this.btnFinalizar);
         this.Controls.Add(this.btnIniciar);
         this.Controls.Add(this.pbRojo2);
         this.Controls.Add(this.pbRojo1);
         this.Controls.Add(this.pbVerde1);
         this.Controls.Add(this.groupBox3);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.pbVerde2);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "frmCarrera";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Autodromo - Carrera";
         this.Load += new System.EventHandler(this.frmCarrera_Load);
         this.groupBox1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.dgvCorredor1)).EndInit();
         this.groupBox2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.dgvCorredor2)).EndInit();
         this.groupBox3.ResumeLayout(false);
         this.groupBox3.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pbAdelanto2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pbAdelanto1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pbRojo2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pbRojo1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pbVerde1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pbVerde2)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCorredor1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCorredor2;
        private System.Windows.Forms.Timer Milisegundos1;
        private System.Windows.Forms.Label lblTiempo1;
        private System.Windows.Forms.Label lblTiempo2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer Milisegundos2;
        private System.IO.Ports.SerialPort SerialPort1;
        private System.Windows.Forms.PictureBox pbVerde1;
        private System.Windows.Forms.PictureBox pbRojo1;
        private System.Windows.Forms.PictureBox pbRojo2;
        private System.Windows.Forms.PictureBox pbVerde2;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnPosicion;
        private System.Windows.Forms.PictureBox pbAdelanto1;
        private System.Windows.Forms.PictureBox pbAdelanto2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}