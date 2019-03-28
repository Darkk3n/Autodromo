namespace Autodromo.UI.Catalogos
{ 
    partial class frmAutomoviles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutomoviles));
            this.txtModelo = new System.Windows.Forms.MaskedTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btnBuscarImgAuto1 = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscarAuto1 = new System.Windows.Forms.Button();
            this.pbAuto1 = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtCilindrada = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.cbMotor = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.fdFoto = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.cbClubes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAuto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(88, 69);
            this.txtModelo.Mask = "0000";
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(151, 20);
            this.txtModelo.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(37, 72);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(45, 13);
            this.label23.TabIndex = 31;
            this.label23.Text = "Modelo:";
            // 
            // btnBuscarImgAuto1
            // 
            this.btnBuscarImgAuto1.Location = new System.Drawing.Point(278, 210);
            this.btnBuscarImgAuto1.Name = "btnBuscarImgAuto1";
            this.btnBuscarImgAuto1.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarImgAuto1.TabIndex = 11;
            this.btnBuscarImgAuto1.Text = "Examinar";
            this.btnBuscarImgAuto1.UseVisualStyleBackColor = true;
            this.btnBuscarImgAuto1.Click += new System.EventHandler(this.btnBuscarImgAuto1_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(88, 13);
            this.txtNum.Mask = "0000";
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(151, 20);
            this.txtNum.TabIndex = 1;
            // 
            // btnBuscarAuto1
            // 
            this.btnBuscarAuto1.Location = new System.Drawing.Point(278, 11);
            this.btnBuscarAuto1.Name = "btnBuscarAuto1";
            this.btnBuscarAuto1.Size = new System.Drawing.Size(75, 35);
            this.btnBuscarAuto1.TabIndex = 10;
            this.btnBuscarAuto1.Text = "Buscar Automovil";
            this.btnBuscarAuto1.UseVisualStyleBackColor = true;
            this.btnBuscarAuto1.Click += new System.EventHandler(this.btnBuscarAuto1_Click);
            // 
            // pbAuto1
            // 
            this.pbAuto1.Location = new System.Drawing.Point(88, 210);
            this.pbAuto1.Name = "pbAuto1";
            this.pbAuto1.Size = new System.Drawing.Size(151, 137);
            this.pbAuto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAuto1.TabIndex = 29;
            this.pbAuto1.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(22, 215);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 13);
            this.label21.TabIndex = 27;
            this.label21.Text = "Fotografía:";
            // 
            // txtCilindrada
            // 
            this.txtCilindrada.Location = new System.Drawing.Point(88, 97);
            this.txtCilindrada.MaxLength = 10;
            this.txtCilindrada.Name = "txtCilindrada";
            this.txtCilindrada.Size = new System.Drawing.Size(151, 20);
            this.txtCilindrada.TabIndex = 4;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(88, 39);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(151, 20);
            this.txtMarca.TabIndex = 2;
            // 
            // cbMotor
            // 
            this.cbMotor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMotor.FormattingEnabled = true;
            this.cbMotor.Items.AddRange(new object[] {
            "--SELECCIONE--",
            "Aspirado",
            "Turbo"});
            this.cbMotor.Location = new System.Drawing.Point(88, 123);
            this.cbMotor.Name = "cbMotor";
            this.cbMotor.Size = new System.Drawing.Size(151, 21);
            this.cbMotor.TabIndex = 5;
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(88, 150);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(151, 21);
            this.cbCategoria.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 153);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Categoria:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Tipo de Motor:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Cilindrada:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Marca:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Número:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(164, 364);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(278, 364);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // fdFoto
            // 
            this.fdFoto.Filter = "Archivos de Imagen| *.png; *.jpg; *.bmp";
            this.fdFoto.Title = "Seleccionar Archivo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Club:";
            // 
            // cbClubes
            // 
            this.cbClubes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClubes.FormattingEnabled = true;
            this.cbClubes.Location = new System.Drawing.Point(88, 180);
            this.cbClubes.Name = "cbClubes";
            this.cbClubes.Size = new System.Drawing.Size(151, 21);
            this.cbClubes.TabIndex = 7;
            // 
            // frmAutomoviles
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(365, 402);
            this.Controls.Add(this.cbClubes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.btnBuscarImgAuto1);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnBuscarAuto1);
            this.Controls.Add(this.pbAuto1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtCilindrada);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.cbMotor);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAutomoviles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autodromo - Automoviles";
            this.Load += new System.EventHandler(this.frmAutomoviles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAuto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtModelo;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnBuscarImgAuto1;
        private System.Windows.Forms.MaskedTextBox txtNum;
        private System.Windows.Forms.Button btnBuscarAuto1;
        private System.Windows.Forms.PictureBox pbAuto1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtCilindrada;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.ComboBox cbMotor;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider errorProv;
        private System.Windows.Forms.OpenFileDialog fdFoto;
        private System.Windows.Forms.ComboBox cbClubes;
        private System.Windows.Forms.Label label1;
    }
}