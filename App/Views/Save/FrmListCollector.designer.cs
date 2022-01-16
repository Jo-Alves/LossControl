namespace LossControl
{
    partial class FrmOptionsSave
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOptionsSave));
            this.dgvDatalostProductCollections = new System.Windows.Forms.DataGridView();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wheigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddListLossProductCollector = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.cbShowItem = new System.Windows.Forms.CheckBox();
            this.btnListtems = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatalostProductCollections)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatalostProductCollections
            // 
            this.dgvDatalostProductCollections.AllowUserToAddRows = false;
            this.dgvDatalostProductCollections.AllowUserToDeleteRows = false;
            this.dgvDatalostProductCollections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatalostProductCollections.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDatalostProductCollections.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatalostProductCollections.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatalostProductCollections.ColumnHeadersHeight = 35;
            this.dgvDatalostProductCollections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDatalostProductCollections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.edit,
            this.delete,
            this.id,
            this.product,
            this.wheigth,
            this.removalDate});
            this.dgvDatalostProductCollections.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvDatalostProductCollections.EnableHeadersVisualStyles = false;
            this.dgvDatalostProductCollections.Location = new System.Drawing.Point(21, 186);
            this.dgvDatalostProductCollections.MultiSelect = false;
            this.dgvDatalostProductCollections.Name = "dgvDatalostProductCollections";
            this.dgvDatalostProductCollections.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatalostProductCollections.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatalostProductCollections.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvDatalostProductCollections.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDatalostProductCollections.Size = new System.Drawing.Size(761, 351);
            this.dgvDatalostProductCollections.TabIndex = 8;
            this.dgvDatalostProductCollections.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatalostProductCollections_CellClick);
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.edit.HeaderText = "Editar";
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit.Width = 61;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.delete.HeaderText = "Excluir";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.Width = 66;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 49;
            // 
            // product
            // 
            this.product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Format = "N3";
            dataGridViewCellStyle2.NullValue = null;
            this.product.DefaultCellStyle = dataGridViewCellStyle2;
            this.product.HeaderText = "Produto";
            this.product.Name = "product";
            this.product.ReadOnly = true;
            // 
            // wheigth
            // 
            this.wheigth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wheigth.HeaderText = "Peso";
            this.wheigth.Name = "wheigth";
            this.wheigth.ReadOnly = true;
            this.wheigth.Width = 72;
            // 
            // removalDate
            // 
            this.removalDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.removalDate.HeaderText = "Data da remoção";
            this.removalDate.Name = "removalDate";
            this.removalDate.ReadOnly = true;
            this.removalDate.Width = 166;
            // 
            // btnAddListLossProductCollector
            // 
            this.btnAddListLossProductCollector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.btnAddListLossProductCollector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddListLossProductCollector.FlatAppearance.BorderSize = 0;
            this.btnAddListLossProductCollector.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(160)))));
            this.btnAddListLossProductCollector.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnAddListLossProductCollector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddListLossProductCollector.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddListLossProductCollector.ForeColor = System.Drawing.Color.White;
            this.btnAddListLossProductCollector.Location = new System.Drawing.Point(21, 29);
            this.btnAddListLossProductCollector.Name = "btnAddListLossProductCollector";
            this.btnAddListLossProductCollector.Size = new System.Drawing.Size(168, 42);
            this.btnAddListLossProductCollector.TabIndex = 7;
            this.btnAddListLossProductCollector.Text = "Novo";
            this.btnAddListLossProductCollector.UseVisualStyleBackColor = false;
            this.btnAddListLossProductCollector.Click += new System.EventHandler(this.btnAddListLossProductCollector_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtSearchProduct);
            this.groupBox1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 80);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(471, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchProduct.BackColor = System.Drawing.Color.White;
            this.txtSearchProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchProduct.Font = new System.Drawing.Font("Open Sans", 14F);
            this.txtSearchProduct.Location = new System.Drawing.Point(17, 34);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(448, 33);
            this.txtSearchProduct.TabIndex = 9;
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            // 
            // cbShowItem
            // 
            this.cbShowItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbShowItem.AutoSize = true;
            this.cbShowItem.ForeColor = System.Drawing.Color.Black;
            this.cbShowItem.Location = new System.Drawing.Point(570, 138);
            this.cbShowItem.Name = "cbShowItem";
            this.cbShowItem.Size = new System.Drawing.Size(197, 26);
            this.cbShowItem.TabIndex = 10;
            this.cbShowItem.Text = "Mostrar item por item";
            this.cbShowItem.UseVisualStyleBackColor = true;
            this.cbShowItem.CheckedChanged += new System.EventHandler(this.cbShowItem_CheckedChanged);
            // 
            // btnListtems
            // 
            this.btnListtems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.btnListtems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListtems.FlatAppearance.BorderSize = 0;
            this.btnListtems.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(160)))));
            this.btnListtems.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnListtems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListtems.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListtems.ForeColor = System.Drawing.Color.White;
            this.btnListtems.Location = new System.Drawing.Point(195, 29);
            this.btnListtems.Name = "btnListtems";
            this.btnListtems.Size = new System.Drawing.Size(168, 42);
            this.btnListtems.TabIndex = 11;
            this.btnListtems.Text = "Listar Itens";
            this.btnListtems.UseVisualStyleBackColor = false;
            this.btnListtems.Click += new System.EventHandler(this.btnListtems_Click);
            // 
            // FrmOptionsSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(817, 570);
            this.Controls.Add(this.btnListtems);
            this.Controls.Add(this.cbShowItem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDatalostProductCollections);
            this.Controls.Add(this.btnAddListLossProductCollector);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOptionsSave";
            this.Text = "FrmOptionsSave";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatalostProductCollections)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatalostProductCollections;
        private System.Windows.Forms.Button btnAddListLossProductCollector;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.CheckBox cbShowItem;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn wheigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn removalDate;
        private System.Windows.Forms.Button btnListtems;
    }
}