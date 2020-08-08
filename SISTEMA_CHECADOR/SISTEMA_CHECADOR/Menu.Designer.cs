namespace SISTEMA_CHECADOR
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cATALOGOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDePersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHECADORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cATALOGOSToolStripMenuItem,
            this.cHECADORToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cATALOGOSToolStripMenuItem
            // 
            this.cATALOGOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoDePersonalToolStripMenuItem,
            this.personalToolStripMenuItem});
            this.cATALOGOSToolStripMenuItem.Image = global::SISTEMA_CHECADOR.Properties.Resources.Catalog_36769;
            this.cATALOGOSToolStripMenuItem.Name = "cATALOGOSToolStripMenuItem";
            this.cATALOGOSToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.cATALOGOSToolStripMenuItem.Text = "CATALOGOS";
            this.cATALOGOSToolStripMenuItem.Click += new System.EventHandler(this.cATALOGOSToolStripMenuItem_Click_1);
            // 
            // tipoDePersonalToolStripMenuItem
            // 
            this.tipoDePersonalToolStripMenuItem.Image = global::SISTEMA_CHECADOR.Properties.Resources._1562688_computer_creative_drawing_pad_pen_ruler_technology_tools_107052;
            this.tipoDePersonalToolStripMenuItem.Name = "tipoDePersonalToolStripMenuItem";
            this.tipoDePersonalToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.tipoDePersonalToolStripMenuItem.Text = "Tipo de Personal";
            this.tipoDePersonalToolStripMenuItem.Click += new System.EventHandler(this.tipoDePersonalToolStripMenuItem_Click);
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.Image = global::SISTEMA_CHECADOR.Properties.Resources.Man_36749;
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.personalToolStripMenuItem.Text = "Personal";
            this.personalToolStripMenuItem.Click += new System.EventHandler(this.personalToolStripMenuItem_Click);
            // 
            // cHECADORToolStripMenuItem
            // 
            this.cHECADORToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checadasToolStripMenuItem});
            this.cHECADORToolStripMenuItem.Image = global::SISTEMA_CHECADOR.Properties.Resources.employee_account_business_time_clock_icon_124657;
            this.cHECADORToolStripMenuItem.Name = "cHECADORToolStripMenuItem";
            this.cHECADORToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.cHECADORToolStripMenuItem.Text = "CHECADOR";
            // 
            // checadasToolStripMenuItem
            // 
            this.checadasToolStripMenuItem.Image = global::SISTEMA_CHECADOR.Properties.Resources.organizer_calendar_clock_pencil_10047;
            this.checadasToolStripMenuItem.Name = "checadasToolStripMenuItem";
            this.checadasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checadasToolStripMenuItem.Text = "Checadas";
            this.checadasToolStripMenuItem.Click += new System.EventHandler(this.checadasToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SISTEMA_CHECADOR.Properties.Resources.LogoTecMM;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1350, 700);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem cATALOGOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDePersonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cHECADORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checadasToolStripMenuItem;
    }
}

