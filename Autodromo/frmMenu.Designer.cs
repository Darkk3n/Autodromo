namespace Autodromo.UI
{
   partial class frmMenu
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.eventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.nuevoEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.historialDeEventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.agregarOModificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.agregarOModificarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
         this.automovilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.agregarOModificarToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
         this.clubesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.agregarOModificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.categoriasDeAutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.agregarOModificarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
         this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.acercaDeAutodromoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.cambiarRutaDeGuardadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.menuStrip1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.eventoToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.clubesToolStripMenuItem,
            this.categoriasDeAutosToolStripMenuItem,
            this.ayudaToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(487, 24);
         this.menuStrip1.TabIndex = 0;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // archivoToolStripMenuItem
         // 
         this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarContraseñaToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.salirToolStripMenuItem1});
         this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
         this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
         this.archivoToolStripMenuItem.Text = "&Archivo";
         // 
         // cambiarContraseñaToolStripMenuItem
         // 
         this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
         this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
         this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
         this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
         // 
         // salirToolStripMenuItem
         // 
         this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
         this.salirToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
         this.salirToolStripMenuItem.Text = "Cerrar Sesión";
         this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
         // 
         // salirToolStripMenuItem1
         // 
         this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
         this.salirToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
         this.salirToolStripMenuItem1.Text = "Salir";
         this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
         // 
         // eventoToolStripMenuItem
         // 
         this.eventoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoEventoToolStripMenuItem,
            this.historialDeEventosToolStripMenuItem});
         this.eventoToolStripMenuItem.Name = "eventoToolStripMenuItem";
         this.eventoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
         this.eventoToolStripMenuItem.Text = "&Eventos";
         // 
         // nuevoEventoToolStripMenuItem
         // 
         this.nuevoEventoToolStripMenuItem.Name = "nuevoEventoToolStripMenuItem";
         this.nuevoEventoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this.nuevoEventoToolStripMenuItem.Text = "Agregar o Modificar";
         this.nuevoEventoToolStripMenuItem.Click += new System.EventHandler(this.nuevoEventoToolStripMenuItem_Click);
         // 
         // historialDeEventosToolStripMenuItem
         // 
         this.historialDeEventosToolStripMenuItem.Name = "historialDeEventosToolStripMenuItem";
         this.historialDeEventosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this.historialDeEventosToolStripMenuItem.Text = "&Historial de Eventos";
         this.historialDeEventosToolStripMenuItem.Click += new System.EventHandler(this.historialDeEventosToolStripMenuItem_Click);
         // 
         // usuariosToolStripMenuItem
         // 
         this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarOModificarToolStripMenuItem,
            this.automovilesToolStripMenuItem});
         this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
         this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
         this.usuariosToolStripMenuItem.Text = "&Competencia";
         // 
         // agregarOModificarToolStripMenuItem
         // 
         this.agregarOModificarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarOModificarToolStripMenuItem3});
         this.agregarOModificarToolStripMenuItem.Name = "agregarOModificarToolStripMenuItem";
         this.agregarOModificarToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
         this.agregarOModificarToolStripMenuItem.Text = "C&orredores";
         // 
         // agregarOModificarToolStripMenuItem3
         // 
         this.agregarOModificarToolStripMenuItem3.Name = "agregarOModificarToolStripMenuItem3";
         this.agregarOModificarToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
         this.agregarOModificarToolStripMenuItem3.Text = "Agregar o Modificar";
         this.agregarOModificarToolStripMenuItem3.Click += new System.EventHandler(this.agregarOModificarToolStripMenuItem3_Click);
         // 
         // automovilesToolStripMenuItem
         // 
         this.automovilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarOModificarToolStripMenuItem4});
         this.automovilesToolStripMenuItem.Name = "automovilesToolStripMenuItem";
         this.automovilesToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
         this.automovilesToolStripMenuItem.Text = "Automoviles";
         // 
         // agregarOModificarToolStripMenuItem4
         // 
         this.agregarOModificarToolStripMenuItem4.Name = "agregarOModificarToolStripMenuItem4";
         this.agregarOModificarToolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
         this.agregarOModificarToolStripMenuItem4.Text = "Agregar o Modificar";
         this.agregarOModificarToolStripMenuItem4.Click += new System.EventHandler(this.agregarOModificarToolStripMenuItem4_Click);
         // 
         // clubesToolStripMenuItem
         // 
         this.clubesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarOModificarToolStripMenuItem1});
         this.clubesToolStripMenuItem.Name = "clubesToolStripMenuItem";
         this.clubesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
         this.clubesToolStripMenuItem.Text = "C&lubes";
         // 
         // agregarOModificarToolStripMenuItem1
         // 
         this.agregarOModificarToolStripMenuItem1.Name = "agregarOModificarToolStripMenuItem1";
         this.agregarOModificarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
         this.agregarOModificarToolStripMenuItem1.Text = "Agregar o Modificar";
         this.agregarOModificarToolStripMenuItem1.Click += new System.EventHandler(this.agregarOModificarToolStripMenuItem1_Click);
         // 
         // categoriasDeAutosToolStripMenuItem
         // 
         this.categoriasDeAutosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarOModificarToolStripMenuItem2});
         this.categoriasDeAutosToolStripMenuItem.Name = "categoriasDeAutosToolStripMenuItem";
         this.categoriasDeAutosToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
         this.categoriasDeAutosToolStripMenuItem.Text = "Cate&gorias de Autos";
         // 
         // agregarOModificarToolStripMenuItem2
         // 
         this.agregarOModificarToolStripMenuItem2.Name = "agregarOModificarToolStripMenuItem2";
         this.agregarOModificarToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
         this.agregarOModificarToolStripMenuItem2.Text = "Agregar o Modificar";
         this.agregarOModificarToolStripMenuItem2.Click += new System.EventHandler(this.agregarOModificarToolStripMenuItem2_Click);
         // 
         // ayudaToolStripMenuItem
         // 
         this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeAutodromoToolStripMenuItem,
            this.cambiarRutaDeGuardadoToolStripMenuItem});
         this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
         this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
         this.ayudaToolStripMenuItem.Text = "A&yuda";
         // 
         // acercaDeAutodromoToolStripMenuItem
         // 
         this.acercaDeAutodromoToolStripMenuItem.Name = "acercaDeAutodromoToolStripMenuItem";
         this.acercaDeAutodromoToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
         this.acercaDeAutodromoToolStripMenuItem.Text = "Acerca de Autodromo";
         this.acercaDeAutodromoToolStripMenuItem.Click += new System.EventHandler(this.acercaDeAutodromoToolStripMenuItem_Click);
         // 
         // pictureBox1
         // 
         this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.pictureBox1.Image = global::Autodromo.Properties.Resources.Carrera;
         this.pictureBox1.Location = new System.Drawing.Point(0, 24);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(487, 237);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox1.TabIndex = 1;
         this.pictureBox1.TabStop = false;
         // 
         // cambiarRutaDeGuardadoToolStripMenuItem
         // 
         this.cambiarRutaDeGuardadoToolStripMenuItem.Name = "cambiarRutaDeGuardadoToolStripMenuItem";
         this.cambiarRutaDeGuardadoToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
         this.cambiarRutaDeGuardadoToolStripMenuItem.Text = "Cambiar Ruta de Guardado";
         this.cambiarRutaDeGuardadoToolStripMenuItem.Click += new System.EventHandler(this.cambiarRutaDeGuardadoToolStripMenuItem_Click);
         // 
         // frmMenu
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(487, 261);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.menuStrip1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MainMenuStrip = this.menuStrip1;
         this.MaximizeBox = false;
         this.Name = "frmMenu";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Autodromo - Menu Principal";
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.ToolStripMenuItem eventoToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem nuevoEventoToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem historialDeEventosToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem agregarOModificarToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem clubesToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem agregarOModificarToolStripMenuItem1;
      private System.Windows.Forms.ToolStripMenuItem categoriasDeAutosToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem agregarOModificarToolStripMenuItem2;
      private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem automovilesToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem agregarOModificarToolStripMenuItem3;
      private System.Windows.Forms.ToolStripMenuItem agregarOModificarToolStripMenuItem4;
      private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem acercaDeAutodromoToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem cambiarRutaDeGuardadoToolStripMenuItem;
   }
}