namespace Cappato.Carolina._2D
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaNoDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaAulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónPadresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sueldoDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sueldoNoDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recaudaciónPorAulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recaudaciónTotalDelJardínToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarDocentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarNoDocentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.generarDataToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.archivoToolStripMenuItem;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1117, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDocenteToolStripMenuItem,
            this.altaNoDocenteToolStripMenuItem,
            this.altaAlumnosToolStripMenuItem,
            this.altaAulaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // altaDocenteToolStripMenuItem
            // 
            this.altaDocenteToolStripMenuItem.Name = "altaDocenteToolStripMenuItem";
            this.altaDocenteToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.altaDocenteToolStripMenuItem.Text = "Alta docente";
            this.altaDocenteToolStripMenuItem.Click += new System.EventHandler(this.altaDocenteToolStripMenuItem_Click);
            // 
            // altaNoDocenteToolStripMenuItem
            // 
            this.altaNoDocenteToolStripMenuItem.Name = "altaNoDocenteToolStripMenuItem";
            this.altaNoDocenteToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.altaNoDocenteToolStripMenuItem.Text = "Alta no docente";
            this.altaNoDocenteToolStripMenuItem.Click += new System.EventHandler(this.altaNoDocenteToolStripMenuItem_Click);
            // 
            // altaAlumnosToolStripMenuItem
            // 
            this.altaAlumnosToolStripMenuItem.Name = "altaAlumnosToolStripMenuItem";
            this.altaAlumnosToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.altaAlumnosToolStripMenuItem.Text = "Alta alumnos";
            this.altaAlumnosToolStripMenuItem.Click += new System.EventHandler(this.altaAlumnosToolStripMenuItem_Click);
            // 
            // altaAulaToolStripMenuItem
            // 
            this.altaAulaToolStripMenuItem.Name = "altaAulaToolStripMenuItem";
            this.altaAulaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.altaAulaToolStripMenuItem.Text = "Alta aula";
            this.altaAulaToolStripMenuItem.Click += new System.EventHandler(this.altaAulaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaciónPadresToolStripMenuItem,
            this.sueldoDocenteToolStripMenuItem,
            this.sueldoNoDocenteToolStripMenuItem,
            this.recaudaciónPorAulaToolStripMenuItem,
            this.recaudaciónTotalDelJardínToolStripMenuItem});
            this.reportesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // informaciónPadresToolStripMenuItem
            // 
            this.informaciónPadresToolStripMenuItem.Name = "informaciónPadresToolStripMenuItem";
            this.informaciónPadresToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.informaciónPadresToolStripMenuItem.Text = "Información padres";
            // 
            // sueldoDocenteToolStripMenuItem
            // 
            this.sueldoDocenteToolStripMenuItem.Name = "sueldoDocenteToolStripMenuItem";
            this.sueldoDocenteToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.sueldoDocenteToolStripMenuItem.Text = "Sueldo docente";
            // 
            // sueldoNoDocenteToolStripMenuItem
            // 
            this.sueldoNoDocenteToolStripMenuItem.Name = "sueldoNoDocenteToolStripMenuItem";
            this.sueldoNoDocenteToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.sueldoNoDocenteToolStripMenuItem.Text = "Sueldo no docente";
            // 
            // recaudaciónPorAulaToolStripMenuItem
            // 
            this.recaudaciónPorAulaToolStripMenuItem.Name = "recaudaciónPorAulaToolStripMenuItem";
            this.recaudaciónPorAulaToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.recaudaciónPorAulaToolStripMenuItem.Text = "Recaudación por aula";
            // 
            // recaudaciónTotalDelJardínToolStripMenuItem
            // 
            this.recaudaciónTotalDelJardínToolStripMenuItem.Name = "recaudaciónTotalDelJardínToolStripMenuItem";
            this.recaudaciónTotalDelJardínToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.recaudaciónTotalDelJardínToolStripMenuItem.Text = "Recaudación total del jardín";
            // 
            // generarDataToolStripMenuItem
            // 
            this.generarDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarDocentesToolStripMenuItem,
            this.generarNoDocentesToolStripMenuItem,
            this.generarAlumnosToolStripMenuItem});
            this.generarDataToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarDataToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.generarDataToolStripMenuItem.Name = "generarDataToolStripMenuItem";
            this.generarDataToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.generarDataToolStripMenuItem.Text = "Generar data";
            // 
            // generarDocentesToolStripMenuItem
            // 
            this.generarDocentesToolStripMenuItem.Name = "generarDocentesToolStripMenuItem";
            this.generarDocentesToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.generarDocentesToolStripMenuItem.Text = "Docentes";
            this.generarDocentesToolStripMenuItem.Click += new System.EventHandler(this.generarDocentesToolStripMenuItem_Click);
            // 
            // generarNoDocentesToolStripMenuItem
            // 
            this.generarNoDocentesToolStripMenuItem.Name = "generarNoDocentesToolStripMenuItem";
            this.generarNoDocentesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generarNoDocentesToolStripMenuItem.Text = "No docentes";
            this.generarNoDocentesToolStripMenuItem.Click += new System.EventHandler(this.generarNoDocentesToolStripMenuItem_Click);
            // 
            // generarAlumnosToolStripMenuItem
            // 
            this.generarAlumnosToolStripMenuItem.Name = "generarAlumnosToolStripMenuItem";
            this.generarAlumnosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generarAlumnosToolStripMenuItem.Text = "Alumnos";
            this.generarAlumnosToolStripMenuItem.Click += new System.EventHandler(this.generarAlumnosToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1117, 570);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración \"Los pinochitos\"";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaNoDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaAulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónPadresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sueldoDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sueldoNoDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recaudaciónPorAulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recaudaciónTotalDelJardínToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarDocentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarNoDocentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarAlumnosToolStripMenuItem;
    }
}
