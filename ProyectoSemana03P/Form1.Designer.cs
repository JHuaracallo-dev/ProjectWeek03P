namespace ProyectoSemana03P
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnClose = new System.Windows.Forms.Button();
            this.TxtDNI = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnClean = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.GridClients = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridClients)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.BtnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            resources.ApplyResources(this.BtnClose, "btnClose");
            this.BtnClose.BackColor = System.Drawing.Color.Black;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Name = "btnClose";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDNI
            // 
            resources.ApplyResources(this.TxtDNI, "txtDNI");
            this.TxtDNI.Name = "txtDNI";
            // 
            // titleLabel
            // 
            resources.ApplyResources(this.titleLabel, "titleLabel");
            this.titleLabel.Name = "titleLabel";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtApellidos
            // 
            resources.ApplyResources(this.TxtApellidos, "txtApellidos");
            this.TxtApellidos.Name = "txtApellidos";
            // 
            // txtNombres
            // 
            resources.ApplyResources(this.TxtNombres, "txtNombres");
            this.TxtNombres.Name = "txtNombres";
            // 
            // txtEdad
            // 
            resources.ApplyResources(this.TxtEdad, "txtEdad");
            this.TxtEdad.Name = "txtEdad";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtCorreo
            // 
            resources.ApplyResources(this.TxtCorreo, "txtCorreo");
            this.TxtCorreo.Name = "txtCorreo";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // btnClean
            // 
            this.BtnClean.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.BtnClean, "btnClean");
            this.BtnClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClean.Name = "btnClean";
            this.BtnClean.UseVisualStyleBackColor = true;
            this.BtnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnAdd
            // 
            this.BtnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.BtnAdd, "btnAdd");
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.Name = "btnAdd";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.BtnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.BtnUpdate, "btnUpdate");
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnUpdate.Name = "btnUpdate";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.BtnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.BtnDelete, "btnDelete");
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnDelete.Name = "btnDelete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // GridClients
            // 
            this.GridClients.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridClients.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.GridClients, "GridClients");
            this.GridClients.Name = "GridClients";
            this.GridClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridClients_CellContentClick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.GridClients);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnClean);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNombres);
            this.Controls.Add(this.TxtApellidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.TxtDNI);
            this.Controls.Add(this.BtnClose);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GridClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.TextBox TxtDNI;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.DataGridView GridClients;
    }
}

