namespace Autodromo.UI.Catalogos
{
    partial class frmCorredores
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCorredores));
         this.cbClub = new System.Windows.Forms.ComboBox();
         this.label25 = new System.Windows.Forms.Label();
         this.btnExaminar1 = new System.Windows.Forms.Button();
         this.pbFoto1 = new System.Windows.Forms.PictureBox();
         this.label8 = new System.Windows.Forms.Label();
         this.txtApMaterno = new System.Windows.Forms.TextBox();
         this.txtApPaterno = new System.Windows.Forms.TextBox();
         this.txtNombre = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.btnBuscar = new System.Windows.Forms.Button();
         this.btnAceptar = new System.Windows.Forms.Button();
         this.btnCancelar = new System.Windows.Forms.Button();
         this.fdFoto = new System.Windows.Forms.OpenFileDialog();
         this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
         ((System.ComponentModel.ISupportInitialize)(this.pbFoto1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
         this.SuspendLayout();
         // 
         // cbClub
         // 
         this.cbClub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cbClub.FormattingEnabled = true;
         this.cbClub.Location = new System.Drawing.Point(105, 121);
         this.cbClub.Name = "cbClub";
         this.cbClub.Size = new System.Drawing.Size(185, 21);
         this.cbClub.TabIndex = 25;
         // 
         // label25
         // 
         this.label25.AutoSize = true;
         this.label25.Location = new System.Drawing.Point(57, 124);
         this.label25.Name = "label25";
         this.label25.Size = new System.Drawing.Size(31, 13);
         this.label25.TabIndex = 24;
         this.label25.Text = "Club:";
         // 
         // btnExaminar1
         // 
         this.btnExaminar1.Location = new System.Drawing.Point(272, 160);
         this.btnExaminar1.Name = "btnExaminar1";
         this.btnExaminar1.Size = new System.Drawing.Size(75, 23);
         this.btnExaminar1.TabIndex = 23;
         this.btnExaminar1.Text = "Examinar";
         this.btnExaminar1.UseVisualStyleBackColor = true;
         this.btnExaminar1.Click += new System.EventHandler(this.btnExaminar1_Click);
         // 
         // pbFoto1
         // 
         this.pbFoto1.Location = new System.Drawing.Point(104, 160);
         this.pbFoto1.Name = "pbFoto1";
         this.pbFoto1.Size = new System.Drawing.Size(162, 137);
         this.pbFoto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pbFoto1.TabIndex = 22;
         this.pbFoto1.TabStop = false;
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(39, 160);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(59, 13);
         this.label8.TabIndex = 21;
         this.label8.Text = "Fotografía:";
         // 
         // txtApMaterno
         // 
         this.txtApMaterno.Location = new System.Drawing.Point(105, 86);
         this.txtApMaterno.MaxLength = 50;
         this.txtApMaterno.Name = "txtApMaterno";
         this.txtApMaterno.Size = new System.Drawing.Size(185, 20);
         this.txtApMaterno.TabIndex = 20;
         // 
         // txtApPaterno
         // 
         this.txtApPaterno.Location = new System.Drawing.Point(105, 50);
         this.txtApPaterno.MaxLength = 50;
         this.txtApPaterno.Name = "txtApPaterno";
         this.txtApPaterno.Size = new System.Drawing.Size(185, 20);
         this.txtApPaterno.TabIndex = 19;
         // 
         // txtNombre
         // 
         this.txtNombre.Location = new System.Drawing.Point(104, 13);
         this.txtNombre.MaxLength = 50;
         this.txtNombre.Name = "txtNombre";
         this.txtNombre.Size = new System.Drawing.Size(186, 20);
         this.txtNombre.TabIndex = 18;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(11, 50);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(87, 13);
         this.label4.TabIndex = 17;
         this.label4.Text = "Apellido Paterno:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(11, 89);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(89, 13);
         this.label3.TabIndex = 16;
         this.label3.Text = "Apellido Materno:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(51, 16);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(47, 13);
         this.label2.TabIndex = 15;
         this.label2.Text = "Nombre:";
         // 
         // btnBuscar
         // 
         this.btnBuscar.Location = new System.Drawing.Point(296, 12);
         this.btnBuscar.Name = "btnBuscar";
         this.btnBuscar.Size = new System.Drawing.Size(63, 34);
         this.btnBuscar.TabIndex = 14;
         this.btnBuscar.Text = "Buscar Corredor";
         this.btnBuscar.UseVisualStyleBackColor = true;
         this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
         // 
         // btnAceptar
         // 
         this.btnAceptar.Location = new System.Drawing.Point(211, 322);
         this.btnAceptar.Name = "btnAceptar";
         this.btnAceptar.Size = new System.Drawing.Size(75, 23);
         this.btnAceptar.TabIndex = 26;
         this.btnAceptar.Text = "Aceptar";
         this.btnAceptar.UseVisualStyleBackColor = true;
         this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
         // 
         // btnCancelar
         // 
         this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnCancelar.Location = new System.Drawing.Point(292, 322);
         this.btnCancelar.Name = "btnCancelar";
         this.btnCancelar.Size = new System.Drawing.Size(75, 23);
         this.btnCancelar.TabIndex = 27;
         this.btnCancelar.Text = "Cancelar";
         this.btnCancelar.UseVisualStyleBackColor = true;
         this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
         // 
         // fdFoto
         // 
         this.fdFoto.Filter = "Archivos de Imagen| *.png; *.jpg; *.bmp";
         this.fdFoto.InitialDirectory = "C:\\";
         // 
         // errorProv
         // 
         this.errorProv.ContainerControl = this;
         // 
         // frmCorredores
         // 
         this.AcceptButton = this.btnAceptar;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.btnCancelar;
         this.ClientSize = new System.Drawing.Size(379, 357);
         this.Controls.Add(this.btnCancelar);
         this.Controls.Add(this.btnAceptar);
         this.Controls.Add(this.cbClub);
         this.Controls.Add(this.label25);
         this.Controls.Add(this.btnExaminar1);
         this.Controls.Add(this.pbFoto1);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.txtApMaterno);
         this.Controls.Add(this.txtApPaterno);
         this.Controls.Add(this.txtNombre);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.btnBuscar);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "frmCorredores";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Autodromo - Corredores";
         this.Load += new System.EventHandler(this.frmCorredores_Load);
         ((System.ComponentModel.ISupportInitialize)(this.pbFoto1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbClub;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnExaminar1;
        private System.Windows.Forms.PictureBox pbFoto1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtApMaterno;
        private System.Windows.Forms.TextBox txtApPaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.OpenFileDialog fdFoto;
        private System.Windows.Forms.ErrorProvider errorProv;
    }
}