namespace SISTEMA_CHECADOR
{
    partial class TipoPersonal
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTP = new System.Windows.Forms.TextBox();
            this.btnAddTP = new System.Windows.Forms.Button();
            this.btnUpdateTP = new System.Windows.Forms.Button();
            this.btnDeleteTP = new System.Windows.Forms.Button();
            this.dtgTP = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSend = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTP)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::SISTEMA_CHECADOR.Properties.Resources.Encabezado;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(559, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Añadir Tipo de Personal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de Personal: ";
            // 
            // txtTP
            // 
            this.txtTP.Location = new System.Drawing.Point(177, 144);
            this.txtTP.Name = "txtTP";
            this.txtTP.Size = new System.Drawing.Size(290, 20);
            this.txtTP.TabIndex = 3;
            // 
            // btnAddTP
            // 
            this.btnAddTP.Location = new System.Drawing.Point(473, 170);
            this.btnAddTP.Name = "btnAddTP";
            this.btnAddTP.Size = new System.Drawing.Size(75, 23);
            this.btnAddTP.TabIndex = 4;
            this.btnAddTP.Text = "Añadir";
            this.btnAddTP.UseVisualStyleBackColor = true;
            this.btnAddTP.Click += new System.EventHandler(this.btnAddTP_Click);
            // 
            // btnUpdateTP
            // 
            this.btnUpdateTP.Location = new System.Drawing.Point(473, 231);
            this.btnUpdateTP.Name = "btnUpdateTP";
            this.btnUpdateTP.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateTP.TabIndex = 5;
            this.btnUpdateTP.Text = "Modificar";
            this.btnUpdateTP.UseVisualStyleBackColor = true;
            this.btnUpdateTP.Click += new System.EventHandler(this.btnUpdateTP_Click);
            // 
            // btnDeleteTP
            // 
            this.btnDeleteTP.Location = new System.Drawing.Point(473, 291);
            this.btnDeleteTP.Name = "btnDeleteTP";
            this.btnDeleteTP.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTP.TabIndex = 6;
            this.btnDeleteTP.Text = "Eliminar";
            this.btnDeleteTP.UseVisualStyleBackColor = true;
            this.btnDeleteTP.Click += new System.EventHandler(this.btnDeleteTP_Click);
            // 
            // dtgTP
            // 
            this.dtgTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTP.Location = new System.Drawing.Point(12, 170);
            this.dtgTP.Name = "dtgTP";
            this.dtgTP.Size = new System.Drawing.Size(455, 144);
            this.dtgTP.TabIndex = 7;
            this.dtgTP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTP_CellContentClick);
            this.dtgTP.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTP_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Buscar: ";
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(177, 118);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(290, 20);
            this.txtSend.TabIndex = 9;
            this.txtSend.TextChanged += new System.EventHandler(this.txtSend_TextChanged);            
            // 
            // TipoPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(560, 326);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgTP);
            this.Controls.Add(this.btnDeleteTP);
            this.Controls.Add(this.btnUpdateTP);
            this.Controls.Add(this.btnAddTP);
            this.Controls.Add(this.txtTP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TipoPersonal";
            this.Text = "Tipo de Personal";
            this.Load += new System.EventHandler(this.TipoPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTP;
        private System.Windows.Forms.Button btnAddTP;
        private System.Windows.Forms.Button btnUpdateTP;
        private System.Windows.Forms.Button btnDeleteTP;
        private System.Windows.Forms.DataGridView dtgTP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSend;
    }
}