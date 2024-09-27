namespace pryGestorContactosSaleski
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contactosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarContactosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarOModificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarContactosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraDeEstado = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuarioTS = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.barraDeEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(337, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contactosToolStripMenuItem
            // 
            this.contactosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarContactosToolStripMenuItem,
            this.eliminarOModificarToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.agregarContactosToolStripMenuItem});
            this.contactosToolStripMenuItem.Name = "contactosToolStripMenuItem";
            this.contactosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.contactosToolStripMenuItem.Text = "Contactos";
            // 
            // listarContactosToolStripMenuItem
            // 
            this.listarContactosToolStripMenuItem.Name = "listarContactosToolStripMenuItem";
            this.listarContactosToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.listarContactosToolStripMenuItem.Text = "Listar y Agregar Contactos";
            this.listarContactosToolStripMenuItem.Click += new System.EventHandler(this.listarContactosToolStripMenuItem_Click);
            // 
            // eliminarOModificarToolStripMenuItem
            // 
            this.eliminarOModificarToolStripMenuItem.Name = "eliminarOModificarToolStripMenuItem";
            this.eliminarOModificarToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.eliminarOModificarToolStripMenuItem.Text = "Eliminar o Modificar";
            this.eliminarOModificarToolStripMenuItem.Click += new System.EventHandler(this.eliminarOModificarToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porCategoriaToolStripMenuItem,
            this.porNombreToolStripMenuItem});
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // porCategoriaToolStripMenuItem
            // 
            this.porCategoriaToolStripMenuItem.Name = "porCategoriaToolStripMenuItem";
            this.porCategoriaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.porCategoriaToolStripMenuItem.Text = "Por categoria";
            this.porCategoriaToolStripMenuItem.Click += new System.EventHandler(this.porCategoriaToolStripMenuItem_Click);
            // 
            // porNombreToolStripMenuItem
            // 
            this.porNombreToolStripMenuItem.Name = "porNombreToolStripMenuItem";
            this.porNombreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porNombreToolStripMenuItem.Text = "Por Nombre";
            this.porNombreToolStripMenuItem.Click += new System.EventHandler(this.porNombreToolStripMenuItem_Click);
            // 
            // agregarContactosToolStripMenuItem
            // 
            this.agregarContactosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csvToolStripMenuItem});
            this.agregarContactosToolStripMenuItem.Name = "agregarContactosToolStripMenuItem";
            this.agregarContactosToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.agregarContactosToolStripMenuItem.Text = "Exportar";
            // 
            // csvToolStripMenuItem
            // 
            this.csvToolStripMenuItem.Name = "csvToolStripMenuItem";
            this.csvToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.csvToolStripMenuItem.Text = "Csv";
            this.csvToolStripMenuItem.Click += new System.EventHandler(this.csvToolStripMenuItem_Click);
            // 
            // barraDeEstado
            // 
            this.barraDeEstado.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barraDeEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblUsuarioTS});
            this.barraDeEstado.Location = new System.Drawing.Point(0, 287);
            this.barraDeEstado.Name = "barraDeEstado";
            this.barraDeEstado.Size = new System.Drawing.Size(337, 22);
            this.barraDeEstado.TabIndex = 22;
            this.barraDeEstado.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(31, 17);
            this.lblStatus.Text = "BD: ";
            // 
            // lblUsuarioTS
            // 
            this.lblUsuarioTS.Name = "lblUsuarioTS";
            this.lblUsuarioTS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUsuarioTS.Size = new System.Drawing.Size(0, 17);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(337, 309);
            this.Controls.Add(this.barraDeEstado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.barraDeEstado.ResumeLayout(false);
            this.barraDeEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contactosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarContactosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarContactosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarOModificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem csvToolStripMenuItem;
        private System.Windows.Forms.StatusStrip barraDeEstado;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuarioTS;
    }
}