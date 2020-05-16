namespace Cappato.Carolina._2D
{
    partial class FrmAltas
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
            this.grpbxDatos = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDocentes = new System.Windows.Forms.ComboBox();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.lblColores = new System.Windows.Forms.Label();
            this.cmbColores = new System.Windows.Forms.ComboBox();
            this.btnGuardarAltas = new System.Windows.Forms.Button();
            this.btnCancelarAltas = new System.Windows.Forms.Button();
            this.dgvAlumnosAsignados = new System.Windows.Forms.DataGridView();
            this.legajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorSalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCuotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.femeninoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstAlumnosSinAula = new System.Windows.Forms.ListBox();
            this.lblAlumnosSinAula = new System.Windows.Forms.Label();
            this.lblAlumnosAsignados = new System.Windows.Forms.Label();
            this.grpbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxDatos
            // 
            this.grpbxDatos.Controls.Add(this.label2);
            this.grpbxDatos.Controls.Add(this.label1);
            this.grpbxDatos.Controls.Add(this.cmbDocentes);
            this.grpbxDatos.Controls.Add(this.cmbTurno);
            this.grpbxDatos.Controls.Add(this.lblColores);
            this.grpbxDatos.Controls.Add(this.cmbColores);
            this.grpbxDatos.Location = new System.Drawing.Point(9, 19);
            this.grpbxDatos.Name = "grpbxDatos";
            this.grpbxDatos.Size = new System.Drawing.Size(906, 106);
            this.grpbxDatos.TabIndex = 0;
            this.grpbxDatos.TabStop = false;
            this.grpbxDatos.Text = "Datos del aula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Docentes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Turno";
            // 
            // cmbDocentes
            // 
            this.cmbDocentes.FormattingEnabled = true;
            this.cmbDocentes.Location = new System.Drawing.Point(495, 42);
            this.cmbDocentes.Name = "cmbDocentes";
            this.cmbDocentes.Size = new System.Drawing.Size(150, 21);
            this.cmbDocentes.TabIndex = 3;
            // 
            // cmbTurno
            // 
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(264, 42);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(150, 21);
            this.cmbTurno.TabIndex = 2;
            this.cmbTurno.SelectedIndexChanged += new System.EventHandler(this.cmbTurno_SelectedIndexChanged);
            // 
            // lblColores
            // 
            this.lblColores.AutoSize = true;
            this.lblColores.Location = new System.Drawing.Point(28, 26);
            this.lblColores.Name = "lblColores";
            this.lblColores.Size = new System.Drawing.Size(71, 13);
            this.lblColores.TabIndex = 1;
            this.lblColores.Text = "Color del aula";
            // 
            // cmbColores
            // 
            this.cmbColores.Location = new System.Drawing.Point(21, 42);
            this.cmbColores.Name = "cmbColores";
            this.cmbColores.Size = new System.Drawing.Size(150, 21);
            this.cmbColores.TabIndex = 0;
            this.cmbColores.SelectedIndexChanged += new System.EventHandler(this.cmbColores_SelectedIndexChanged);
            // 
            // btnGuardarAltas
            // 
            this.btnGuardarAltas.Location = new System.Drawing.Point(755, 573);
            this.btnGuardarAltas.Name = "btnGuardarAltas";
            this.btnGuardarAltas.Size = new System.Drawing.Size(80, 30);
            this.btnGuardarAltas.TabIndex = 4;
            this.btnGuardarAltas.Text = "Guardar";
            this.btnGuardarAltas.UseVisualStyleBackColor = true;
            this.btnGuardarAltas.Click += new System.EventHandler(this.btnGuardarAltas_Click);
            // 
            // btnCancelarAltas
            // 
            this.btnCancelarAltas.Location = new System.Drawing.Point(841, 573);
            this.btnCancelarAltas.Name = "btnCancelarAltas";
            this.btnCancelarAltas.Size = new System.Drawing.Size(80, 30);
            this.btnCancelarAltas.TabIndex = 5;
            this.btnCancelarAltas.Text = "Cancelar";
            this.btnCancelarAltas.UseVisualStyleBackColor = true;
            this.btnCancelarAltas.Click += new System.EventHandler(this.btnCancelarAltas_Click);
            // 
            // dgvAlumnosAsignados
            // 
            this.dgvAlumnosAsignados.AllowUserToOrderColumns = true;
            this.dgvAlumnosAsignados.AutoGenerateColumns = false;
            this.dgvAlumnosAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnosAsignados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.legajoDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.dniDataGridViewTextBoxColumn,
            this.colorSalaDataGridViewTextBoxColumn,
            this.responsableDataGridViewTextBoxColumn,
            this.precioCuotaDataGridViewTextBoxColumn,
            this.femeninoDataGridViewCheckBoxColumn});
            this.dgvAlumnosAsignados.DataSource = this.alumnoBindingSource;
            this.dgvAlumnosAsignados.Location = new System.Drawing.Point(6, 6);
            this.dgvAlumnosAsignados.Name = "dgvAlumnosAsignados";
            this.dgvAlumnosAsignados.Size = new System.Drawing.Size(590, 413);
            this.dgvAlumnosAsignados.TabIndex = 1;
            // 
            // legajoDataGridViewTextBoxColumn
            // 
            this.legajoDataGridViewTextBoxColumn.DataPropertyName = "Legajo";
            this.legajoDataGridViewTextBoxColumn.HeaderText = "Legajo";
            this.legajoDataGridViewTextBoxColumn.Name = "legajoDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "Dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "Dni";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            // 
            // colorSalaDataGridViewTextBoxColumn
            // 
            this.colorSalaDataGridViewTextBoxColumn.DataPropertyName = "ColorSala";
            this.colorSalaDataGridViewTextBoxColumn.HeaderText = "ColorSala";
            this.colorSalaDataGridViewTextBoxColumn.Name = "colorSalaDataGridViewTextBoxColumn";
            // 
            // responsableDataGridViewTextBoxColumn
            // 
            this.responsableDataGridViewTextBoxColumn.DataPropertyName = "Responsable";
            this.responsableDataGridViewTextBoxColumn.HeaderText = "Responsable";
            this.responsableDataGridViewTextBoxColumn.Name = "responsableDataGridViewTextBoxColumn";
            // 
            // precioCuotaDataGridViewTextBoxColumn
            // 
            this.precioCuotaDataGridViewTextBoxColumn.DataPropertyName = "PrecioCuota";
            this.precioCuotaDataGridViewTextBoxColumn.HeaderText = "PrecioCuota";
            this.precioCuotaDataGridViewTextBoxColumn.Name = "precioCuotaDataGridViewTextBoxColumn";
            // 
            // femeninoDataGridViewCheckBoxColumn
            // 
            this.femeninoDataGridViewCheckBoxColumn.DataPropertyName = "Femenino";
            this.femeninoDataGridViewCheckBoxColumn.HeaderText = "Femenino";
            this.femeninoDataGridViewCheckBoxColumn.Name = "femeninoDataGridViewCheckBoxColumn";
            // 
            // alumnoBindingSource
            // 
            this.alumnoBindingSource.DataSource = typeof(Entidades.Alumno);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(15, 151);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstAlumnosSinAula);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvAlumnosAsignados);
            this.splitContainer1.Size = new System.Drawing.Size(899, 422);
            this.splitContainer1.SplitterDistance = 299;
            this.splitContainer1.TabIndex = 6;
            // 
            // lstAlumnosSinAula
            // 
            this.lstAlumnosSinAula.FormattingEnabled = true;
            this.lstAlumnosSinAula.Location = new System.Drawing.Point(3, 6);
            this.lstAlumnosSinAula.Name = "lstAlumnosSinAula";
            this.lstAlumnosSinAula.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstAlumnosSinAula.Size = new System.Drawing.Size(293, 407);
            this.lstAlumnosSinAula.TabIndex = 0;
            // 
            // lblAlumnosSinAula
            // 
            this.lblAlumnosSinAula.AutoSize = true;
            this.lblAlumnosSinAula.Location = new System.Drawing.Point(26, 133);
            this.lblAlumnosSinAula.Name = "lblAlumnosSinAula";
            this.lblAlumnosSinAula.Size = new System.Drawing.Size(89, 13);
            this.lblAlumnosSinAula.TabIndex = 7;
            this.lblAlumnosSinAula.Text = "Alumnos Sin Aula";
            // 
            // lblAlumnosAsignados
            // 
            this.lblAlumnosAsignados.AutoSize = true;
            this.lblAlumnosAsignados.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblAlumnosAsignados.Location = new System.Drawing.Point(345, 130);
            this.lblAlumnosAsignados.Name = "lblAlumnosAsignados";
            this.lblAlumnosAsignados.Size = new System.Drawing.Size(98, 13);
            this.lblAlumnosAsignados.TabIndex = 8;
            this.lblAlumnosAsignados.Text = "Alumnos asignados";
            // 
            // FrmAltas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 608);
            this.Controls.Add(this.lblAlumnosAsignados);
            this.Controls.Add(this.lblAlumnosSinAula);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnCancelarAltas);
            this.Controls.Add(this.btnGuardarAltas);
            this.Controls.Add(this.grpbxDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAltas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Altas";
            this.Load += new System.EventHandler(this.FrmAltas_Load);
            this.grpbxDatos.ResumeLayout(false);
            this.grpbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxDatos;
        private System.Windows.Forms.Label lblColores;
        private System.Windows.Forms.BindingSource alumnoBindingSource;
        private System.Windows.Forms.Button btnGuardarAltas;
        private System.Windows.Forms.Button btnCancelarAltas;
        private System.Windows.Forms.DataGridView dgvAlumnosAsignados;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorSalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCuotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn femeninoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cmbDocentes;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbColores;
        private System.Windows.Forms.ListBox lstAlumnosSinAula;
        private System.Windows.Forms.Label lblAlumnosSinAula;
        private System.Windows.Forms.Label lblAlumnosAsignados;
    }
}