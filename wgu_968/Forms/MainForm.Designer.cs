namespace wgu_968
{
    partial class mainForm
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
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.applicationTitle = new System.Windows.Forms.Label();
            this.partLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.inputPartTextField = new System.Windows.Forms.TextBox();
            this.searchPartBtn = new System.Windows.Forms.Button();
            this.addpartbtn = new System.Windows.Forms.Button();
            this.modifypartbtn = new System.Windows.Forms.Button();
            this.deletePartbtn = new System.Windows.Forms.Button();
            this.deleteProductsbtn = new System.Windows.Forms.Button();
            this.modifyProductbtn = new System.Windows.Forms.Button();
            this.addProductbtn = new System.Windows.Forms.Button();
            this.searchProductbtn = new System.Windows.Forms.Button();
            this.inputProductTextField = new System.Windows.Forms.TextBox();
            this.exitbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParts
            // 
            this.dgvParts.AllowUserToAddRows = false;
            this.dgvParts.AllowUserToResizeColumns = false;
            this.dgvParts.AllowUserToResizeRows = false;
            this.dgvParts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvParts.Location = new System.Drawing.Point(22, 67);
            this.dgvParts.MultiSelect = false;
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.ReadOnly = true;
            this.dgvParts.Size = new System.Drawing.Size(581, 286);
            this.dgvParts.TabIndex = 0;
            this.dgvParts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            this.dgvParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myBindingComplete);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(620, 67);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.Size = new System.Drawing.Size(604, 286);
            this.dgvProducts.TabIndex = 1;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            this.dgvProducts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dbc);
            // 
            // applicationTitle
            // 
            this.applicationTitle.AutoSize = true;
            this.applicationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationTitle.Location = new System.Drawing.Point(0, -1);
            this.applicationTitle.Name = "applicationTitle";
            this.applicationTitle.Size = new System.Drawing.Size(202, 17);
            this.applicationTitle.TabIndex = 2;
            this.applicationTitle.Text = "Inventory Management System";
            // 
            // partLabel
            // 
            this.partLabel.AutoSize = true;
            this.partLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partLabel.Location = new System.Drawing.Point(9, 47);
            this.partLabel.Name = "partLabel";
            this.partLabel.Size = new System.Drawing.Size(46, 17);
            this.partLabel.TabIndex = 3;
            this.partLabel.Text = "Parts";
            this.partLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.Location = new System.Drawing.Point(617, 47);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(72, 17);
            this.productLabel.TabIndex = 4;
            this.productLabel.Text = "Products";
            this.productLabel.Click += new System.EventHandler(this.Products_Click);
            // 
            // inputPartTextField
            // 
            this.inputPartTextField.Location = new System.Drawing.Point(478, 40);
            this.inputPartTextField.Name = "inputPartTextField";
            this.inputPartTextField.Size = new System.Drawing.Size(100, 20);
            this.inputPartTextField.TabIndex = 5;
            this.inputPartTextField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // searchPartBtn
            // 
            this.searchPartBtn.Location = new System.Drawing.Point(403, 38);
            this.searchPartBtn.Name = "searchPartBtn";
            this.searchPartBtn.Size = new System.Drawing.Size(69, 23);
            this.searchPartBtn.TabIndex = 6;
            this.searchPartBtn.Text = "Search";
            this.searchPartBtn.UseVisualStyleBackColor = true;
            this.searchPartBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // addpartbtn
            // 
            this.addpartbtn.Location = new System.Drawing.Point(376, 359);
            this.addpartbtn.Name = "addpartbtn";
            this.addpartbtn.Size = new System.Drawing.Size(57, 23);
            this.addpartbtn.TabIndex = 7;
            this.addpartbtn.Text = "Add";
            this.addpartbtn.UseVisualStyleBackColor = true;
            this.addpartbtn.Click += new System.EventHandler(this.addpartbtn_Click);
            // 
            // modifypartbtn
            // 
            this.modifypartbtn.Location = new System.Drawing.Point(451, 359);
            this.modifypartbtn.Name = "modifypartbtn";
            this.modifypartbtn.Size = new System.Drawing.Size(55, 23);
            this.modifypartbtn.TabIndex = 8;
            this.modifypartbtn.Text = "Modify";
            this.modifypartbtn.UseVisualStyleBackColor = true;
            this.modifypartbtn.Click += new System.EventHandler(this.modifypartbtn_Click);
            // 
            // deletePartbtn
            // 
            this.deletePartbtn.Location = new System.Drawing.Point(530, 359);
            this.deletePartbtn.Name = "deletePartbtn";
            this.deletePartbtn.Size = new System.Drawing.Size(52, 23);
            this.deletePartbtn.TabIndex = 9;
            this.deletePartbtn.Text = "Delete";
            this.deletePartbtn.UseVisualStyleBackColor = true;
            this.deletePartbtn.Click += new System.EventHandler(this.deletePartbtn_Click);
            // 
            // deleteProductsbtn
            // 
            this.deleteProductsbtn.Location = new System.Drawing.Point(1172, 359);
            this.deleteProductsbtn.Name = "deleteProductsbtn";
            this.deleteProductsbtn.Size = new System.Drawing.Size(52, 23);
            this.deleteProductsbtn.TabIndex = 12;
            this.deleteProductsbtn.Text = "Delete";
            this.deleteProductsbtn.UseVisualStyleBackColor = true;
            this.deleteProductsbtn.Click += new System.EventHandler(this.deleteProductsbtn_Click);
            // 
            // modifyProductbtn
            // 
            this.modifyProductbtn.Location = new System.Drawing.Point(1093, 359);
            this.modifyProductbtn.Name = "modifyProductbtn";
            this.modifyProductbtn.Size = new System.Drawing.Size(55, 23);
            this.modifyProductbtn.TabIndex = 11;
            this.modifyProductbtn.Text = "Modify";
            this.modifyProductbtn.UseVisualStyleBackColor = true;
            this.modifyProductbtn.Click += new System.EventHandler(this.modifyProductbtn_Click);
            // 
            // addProductbtn
            // 
            this.addProductbtn.Location = new System.Drawing.Point(1018, 359);
            this.addProductbtn.Name = "addProductbtn";
            this.addProductbtn.Size = new System.Drawing.Size(57, 23);
            this.addProductbtn.TabIndex = 10;
            this.addProductbtn.Text = "Add";
            this.addProductbtn.UseVisualStyleBackColor = true;
            this.addProductbtn.Click += new System.EventHandler(this.addProductbtn_Click);
            // 
            // searchProductbtn
            // 
            this.searchProductbtn.Location = new System.Drawing.Point(1049, 39);
            this.searchProductbtn.Name = "searchProductbtn";
            this.searchProductbtn.Size = new System.Drawing.Size(69, 23);
            this.searchProductbtn.TabIndex = 14;
            this.searchProductbtn.Text = "Search";
            this.searchProductbtn.UseVisualStyleBackColor = true;
            this.searchProductbtn.Click += new System.EventHandler(this.searchProductbtn_Click);
            // 
            // inputProductTextField
            // 
            this.inputProductTextField.Location = new System.Drawing.Point(1124, 41);
            this.inputProductTextField.Name = "inputProductTextField";
            this.inputProductTextField.Size = new System.Drawing.Size(100, 20);
            this.inputProductTextField.TabIndex = 13;
            this.inputProductTextField.TextChanged += new System.EventHandler(this.inputProductTextField_TextChanged);
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(1172, 411);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(52, 28);
            this.exitbtn.TabIndex = 15;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1284, 494);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.searchProductbtn);
            this.Controls.Add(this.inputProductTextField);
            this.Controls.Add(this.deleteProductsbtn);
            this.Controls.Add(this.modifyProductbtn);
            this.Controls.Add(this.addProductbtn);
            this.Controls.Add(this.deletePartbtn);
            this.Controls.Add(this.modifypartbtn);
            this.Controls.Add(this.addpartbtn);
            this.Controls.Add(this.searchPartBtn);
            this.Controls.Add(this.inputPartTextField);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.partLabel);
            this.Controls.Add(this.applicationTitle);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.dgvParts);
            this.Name = "mainForm";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label applicationTitle;
        private System.Windows.Forms.Label partLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.TextBox inputPartTextField;
        private System.Windows.Forms.Button searchPartBtn;
        private System.Windows.Forms.Button addpartbtn;
        private System.Windows.Forms.Button modifypartbtn;
        private System.Windows.Forms.Button deletePartbtn;
        private System.Windows.Forms.Button deleteProductsbtn;
        private System.Windows.Forms.Button modifyProductbtn;
        private System.Windows.Forms.Button addProductbtn;
        private System.Windows.Forms.Button searchProductbtn;
        private System.Windows.Forms.TextBox inputProductTextField;
        private System.Windows.Forms.Button exitbtn;
    }
}

