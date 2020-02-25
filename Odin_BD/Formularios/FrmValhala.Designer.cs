namespace Odin_BD
{
    partial class FrmValhala
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmValhala));
            this.label1 = new System.Windows.Forms.Label();
            this.txtProcedimientoABuscar = new System.Windows.Forms.TextBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.btnRutaOrigen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRutaArchivoOrigen = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnCarga = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRutaArchivoDestino = new System.Windows.Forms.TextBox();
            this.btnRutaDestino = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbBaseCadenaConexion = new System.Windows.Forms.ComboBox();
            this.chkTipoGuarda = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Procedimiento :";
            // 
            // txtProcedimientoABuscar
            // 
            this.txtProcedimientoABuscar.Enabled = false;
            this.txtProcedimientoABuscar.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcedimientoABuscar.Location = new System.Drawing.Point(99, 235);
            this.txtProcedimientoABuscar.Multiline = true;
            this.txtProcedimientoABuscar.Name = "txtProcedimientoABuscar";
            this.txtProcedimientoABuscar.Size = new System.Drawing.Size(140, 28);
            this.txtProcedimientoABuscar.TabIndex = 1;
            this.txtProcedimientoABuscar.Text = "BloqueoCuenta";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Enabled = false;
            this.btnEjecutar.Location = new System.Drawing.Point(245, 235);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(54, 28);
            this.btnEjecutar.TabIndex = 3;
            this.btnEjecutar.Text = "Genera";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // btnRutaOrigen
            // 
            this.btnRutaOrigen.Location = new System.Drawing.Point(328, 134);
            this.btnRutaOrigen.Name = "btnRutaOrigen";
            this.btnRutaOrigen.Size = new System.Drawing.Size(28, 22);
            this.btnRutaOrigen.TabIndex = 6;
            this.btnRutaOrigen.Text = "...";
            this.btnRutaOrigen.UseVisualStyleBackColor = true;
            this.btnRutaOrigen.Click += new System.EventHandler(this.btnRutaOrigen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ruta Origen :";
            // 
            // txtRutaArchivoOrigen
            // 
            this.txtRutaArchivoOrigen.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaArchivoOrigen.HideSelection = false;
            this.txtRutaArchivoOrigen.Location = new System.Drawing.Point(95, 29);
            this.txtRutaArchivoOrigen.Multiline = true;
            this.txtRutaArchivoOrigen.Name = "txtRutaArchivoOrigen";
            this.txtRutaArchivoOrigen.Size = new System.Drawing.Size(219, 28);
            this.txtRutaArchivoOrigen.TabIndex = 8;
            this.txtRutaArchivoOrigen.Text = "D:\\Soft\\Odin.net\\Pruebas\\dev";
            this.txtRutaArchivoOrigen.UseSystemPasswordChar = true;
            this.txtRutaArchivoOrigen.TextChanged += new System.EventHandler(this.txtRutaArchivoOrigen_TextChanged);
            // 
            // btnCarga
            // 
            this.btnCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarga.Location = new System.Drawing.Point(96, 94);
            this.btnCarga.Name = "btnCarga";
            this.btnCarga.Size = new System.Drawing.Size(87, 22);
            this.btnCarga.TabIndex = 9;
            this.btnCarga.Text = "Generar";
            this.btnCarga.UseVisualStyleBackColor = true;
            this.btnCarga.Click += new System.EventHandler(this.btnCarga_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ruta Destino :";
            // 
            // txtRutaArchivoDestino
            // 
            this.txtRutaArchivoDestino.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaArchivoDestino.HideSelection = false;
            this.txtRutaArchivoDestino.Location = new System.Drawing.Point(96, 61);
            this.txtRutaArchivoDestino.Multiline = true;
            this.txtRutaArchivoDestino.Name = "txtRutaArchivoDestino";
            this.txtRutaArchivoDestino.Size = new System.Drawing.Size(219, 27);
            this.txtRutaArchivoDestino.TabIndex = 11;
            this.txtRutaArchivoDestino.Text = "D:\\Soft\\Odin.net\\Pruebas\\cal";
            this.txtRutaArchivoDestino.UseSystemPasswordChar = true;
            // 
            // btnRutaDestino
            // 
            this.btnRutaDestino.Location = new System.Drawing.Point(328, 163);
            this.btnRutaDestino.Name = "btnRutaDestino";
            this.btnRutaDestino.Size = new System.Drawing.Size(28, 22);
            this.btnRutaDestino.TabIndex = 12;
            this.btnRutaDestino.Text = "...";
            this.btnRutaDestino.UseVisualStyleBackColor = true;
            this.btnRutaDestino.Click += new System.EventHandler(this.btnRutaDestino_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmbBaseCadenaConexion);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 50);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BaseDatos";
            // 
            // CmbBaseCadenaConexion
            // 
            this.CmbBaseCadenaConexion.Font = new System.Drawing.Font("Book Antiqua", 11.25F);
            this.CmbBaseCadenaConexion.FormattingEnabled = true;
            this.CmbBaseCadenaConexion.Location = new System.Drawing.Point(15, 16);
            this.CmbBaseCadenaConexion.Name = "CmbBaseCadenaConexion";
            this.CmbBaseCadenaConexion.Size = new System.Drawing.Size(323, 28);
            this.CmbBaseCadenaConexion.TabIndex = 0;
            this.CmbBaseCadenaConexion.SelectedIndexChanged += new System.EventHandler(this.CmbBaseCadenaConexion_SelectedIndexChanged);
            // 
            // chkTipoGuarda
            // 
            this.chkTipoGuarda.Checked = true;
            this.chkTipoGuarda.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTipoGuarda.Location = new System.Drawing.Point(304, 239);
            this.chkTipoGuarda.Name = "chkTipoGuarda";
            this.chkTipoGuarda.Size = new System.Drawing.Size(60, 23);
            this.chkTipoGuarda.TabIndex = 14;
            this.chkTipoGuarda.Text = "Habilta";
            this.chkTipoGuarda.UseVisualStyleBackColor = true;
            this.chkTipoGuarda.CheckedChanged += new System.EventHandler(this.chkTipoGuarda_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRutaArchivoDestino);
            this.groupBox2.Controls.Add(this.btnCarga);
            this.groupBox2.Controls.Add(this.txtRutaArchivoOrigen);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.groupBox2.Location = new System.Drawing.Point(4, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 122);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GrupoBackup";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(368, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem1,
            this.modificaBDToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.archivoToolStripMenuItem.Text = "Configuración";
            // 
            // archivoToolStripMenuItem1
            // 
            this.archivoToolStripMenuItem1.Name = "archivoToolStripMenuItem1";
            this.archivoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.archivoToolStripMenuItem1.Text = "Archivo";
            this.archivoToolStripMenuItem1.Click += new System.EventHandler(this.archivoToolStripMenuItem1_Click);
            // 
            // modificaBDToolStripMenuItem
            // 
            this.modificaBDToolStripMenuItem.Name = "modificaBDToolStripMenuItem";
            this.modificaBDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificaBDToolStripMenuItem.Text = "Modifica BD";
            this.modificaBDToolStripMenuItem.Click += new System.EventHandler(this.modificaBDToolStripMenuItem_Click);
            // 
            // FrmValhala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(368, 274);
            this.Controls.Add(this.chkTipoGuarda);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRutaDestino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRutaOrigen);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.txtProcedimientoABuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmValhala";
            this.Text = "Valhala";
            this.Load += new System.EventHandler(this.FrmValhala_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProcedimientoABuscar;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnRutaOrigen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRutaArchivoOrigen;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnCarga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRutaArchivoDestino;
        private System.Windows.Forms.Button btnRutaDestino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CmbBaseCadenaConexion;
        private System.Windows.Forms.CheckBox chkTipoGuarda;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificaBDToolStripMenuItem;
    }
}

