namespace Autodromo
{
   partial class frmCambiarRuta
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambiarRuta));
         this.label1 = new System.Windows.Forms.Label();
         this.txtRuta = new System.Windows.Forms.TextBox();
         this.btnDialog = new System.Windows.Forms.Button();
         this.btnAceptar = new System.Windows.Forms.Button();
         this.btnCancelar = new System.Windows.Forms.Button();
         this.folder = new System.Windows.Forms.FolderBrowserDialog();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(38, 41);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(33, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Ruta:";
         // 
         // txtRuta
         // 
         this.txtRuta.Enabled = false;
         this.txtRuta.Location = new System.Drawing.Point(77, 38);
         this.txtRuta.Name = "txtRuta";
         this.txtRuta.Size = new System.Drawing.Size(297, 20);
         this.txtRuta.TabIndex = 1;
         // 
         // btnDialog
         // 
         this.btnDialog.AutoSize = true;
         this.btnDialog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.btnDialog.Location = new System.Drawing.Point(380, 36);
         this.btnDialog.Name = "btnDialog";
         this.btnDialog.Size = new System.Drawing.Size(26, 23);
         this.btnDialog.TabIndex = 2;
         this.btnDialog.Text = "...";
         this.btnDialog.UseVisualStyleBackColor = true;
         this.btnDialog.Click += new System.EventHandler(this.btnDialog_Click);
         // 
         // btnAceptar
         // 
         this.btnAceptar.Location = new System.Drawing.Point(136, 102);
         this.btnAceptar.Name = "btnAceptar";
         this.btnAceptar.Size = new System.Drawing.Size(75, 23);
         this.btnAceptar.TabIndex = 3;
         this.btnAceptar.Text = "&Aceptar";
         this.btnAceptar.UseVisualStyleBackColor = true;
         this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
         // 
         // btnCancelar
         // 
         this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnCancelar.Location = new System.Drawing.Point(243, 102);
         this.btnCancelar.Name = "btnCancelar";
         this.btnCancelar.Size = new System.Drawing.Size(75, 23);
         this.btnCancelar.TabIndex = 4;
         this.btnCancelar.Text = "&Cancelar";
         this.btnCancelar.UseVisualStyleBackColor = true;
         // 
         // frmCambiarRuta
         // 
         this.AcceptButton = this.btnAceptar;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.btnCancelar;
         this.ClientSize = new System.Drawing.Size(425, 149);
         this.Controls.Add(this.btnCancelar);
         this.Controls.Add(this.btnAceptar);
         this.Controls.Add(this.btnDialog);
         this.Controls.Add(this.txtRuta);
         this.Controls.Add(this.label1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "frmCambiarRuta";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Autodromo - Cambiar Ruta de Guardado de Imagenes";
         this.Load += new System.EventHandler(this.frmCambiarRuta_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtRuta;
      private System.Windows.Forms.Button btnDialog;
      private System.Windows.Forms.Button btnAceptar;
      private System.Windows.Forms.Button btnCancelar;
      private System.Windows.Forms.FolderBrowserDialog folder;
   }
}