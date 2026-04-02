namespace wgu_968.Forms
{
    partial class AddProductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.MinBox = new System.Windows.Forms.TextBox();
            this.MaxBox = new System.Windows.Forms.TextBox();
            this.PriceBox1 = new System.Windows.Forms.TextBox();
            this.InventoryBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.partPriceLA = new System.Windows.Forms.Label();
            this.partINVLA = new System.Windows.Forms.Label();
            this.partNameLA = new System.Windows.Forms.Label();
            this.partIDLA = new System.Windows.Forms.Label();
            this.partCancelbtn = new System.Windows.Forms.Button();
            this.partsavebtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.searchPartBtn = new System.Windows.Forms.Button();
            this.inputPartTextField = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvAddProduct = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Product";
            // 
            // MinBox
            // 
            this.MinBox.Location = new System.Drawing.Point(183, 344);
            this.MinBox.Name = "MinBox";
            this.MinBox.Size = new System.Drawing.Size(68, 20);
            this.MinBox.TabIndex = 49;
            // 
            // MaxBox
            // 
            this.MaxBox.Location = new System.Drawing.Point(72, 347);
            this.MaxBox.Name = "MaxBox";
            this.MaxBox.Size = new System.Drawing.Size(68, 20);
            this.MaxBox.TabIndex = 48;
            // 
            // PriceBox1
            // 
            this.PriceBox1.Location = new System.Drawing.Point(110, 318);
            this.PriceBox1.Name = "PriceBox1";
            this.PriceBox1.Size = new System.Drawing.Size(106, 20);
            this.PriceBox1.TabIndex = 46;
            // 
            // InventoryBox
            // 
            this.InventoryBox.Location = new System.Drawing.Point(110, 292);
            this.InventoryBox.Name = "InventoryBox";
            this.InventoryBox.Size = new System.Drawing.Size(106, 20);
            this.InventoryBox.TabIndex = 45;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(110, 262);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(106, 20);
            this.NameTextBox.TabIndex = 44;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 236);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(106, 20);
            this.textBox1.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(153, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Max";
            // 
            // partPriceLA
            // 
            this.partPriceLA.AutoSize = true;
            this.partPriceLA.Location = new System.Drawing.Point(39, 318);
            this.partPriceLA.Name = "partPriceLA";
            this.partPriceLA.Size = new System.Drawing.Size(34, 13);
            this.partPriceLA.TabIndex = 39;
            this.partPriceLA.Text = "Price ";
            // 
            // partINVLA
            // 
            this.partINVLA.AutoSize = true;
            this.partINVLA.Location = new System.Drawing.Point(39, 292);
            this.partINVLA.Name = "partINVLA";
            this.partINVLA.Size = new System.Drawing.Size(51, 13);
            this.partINVLA.TabIndex = 38;
            this.partINVLA.Text = "Inventory";
            // 
            // partNameLA
            // 
            this.partNameLA.AutoSize = true;
            this.partNameLA.Location = new System.Drawing.Point(39, 262);
            this.partNameLA.Name = "partNameLA";
            this.partNameLA.Size = new System.Drawing.Size(35, 13);
            this.partNameLA.TabIndex = 37;
            this.partNameLA.Text = "Name";
            // 
            // partIDLA
            // 
            this.partIDLA.AutoSize = true;
            this.partIDLA.Location = new System.Drawing.Point(39, 236);
            this.partIDLA.Name = "partIDLA";
            this.partIDLA.Size = new System.Drawing.Size(18, 13);
            this.partIDLA.TabIndex = 36;
            this.partIDLA.Text = "ID";
            // 
            // partCancelbtn
            // 
            this.partCancelbtn.Location = new System.Drawing.Point(831, 560);
            this.partCancelbtn.Name = "partCancelbtn";
            this.partCancelbtn.Size = new System.Drawing.Size(75, 31);
            this.partCancelbtn.TabIndex = 51;
            this.partCancelbtn.Text = "Cancel";
            this.partCancelbtn.UseVisualStyleBackColor = true;
            this.partCancelbtn.Click += new System.EventHandler(this.partCancelbtn_Click);
            // 
            // partsavebtn
            // 
            this.partsavebtn.Location = new System.Drawing.Point(754, 560);
            this.partsavebtn.Name = "partsavebtn";
            this.partsavebtn.Size = new System.Drawing.Size(71, 31);
            this.partsavebtn.TabIndex = 50;
            this.partsavebtn.Text = "Save";
            this.partsavebtn.UseVisualStyleBackColor = true;
            this.partsavebtn.Click += new System.EventHandler(this.partsavebtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(835, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 31);
            this.button1.TabIndex = 52;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchPartBtn
            // 
            this.searchPartBtn.Location = new System.Drawing.Point(652, 44);
            this.searchPartBtn.Name = "searchPartBtn";
            this.searchPartBtn.Size = new System.Drawing.Size(69, 23);
            this.searchPartBtn.TabIndex = 54;
            this.searchPartBtn.Text = "Search";
            this.searchPartBtn.UseVisualStyleBackColor = true;
            this.searchPartBtn.Click += new System.EventHandler(this.searchPartBtn_Click);
            // 
            // inputPartTextField
            // 
            this.inputPartTextField.Location = new System.Drawing.Point(727, 46);
            this.inputPartTextField.Name = "inputPartTextField";
            this.inputPartTextField.Size = new System.Drawing.Size(179, 20);
            this.inputPartTextField.TabIndex = 53;
            this.inputPartTextField.TextChanged += new System.EventHandler(this.inputPartTextField_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(858, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 31);
            this.button2.TabIndex = 55;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvAddProduct
            // 
            this.dgvAddProduct.AllowUserToAddRows = false;
            this.dgvAddProduct.AllowUserToDeleteRows = false;
            this.dgvAddProduct.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvAddProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddProduct.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvAddProduct.Location = new System.Drawing.Point(267, 82);
            this.dgvAddProduct.MultiSelect = false;
            this.dgvAddProduct.Name = "dgvAddProduct";
            this.dgvAddProduct.ReadOnly = true;
            this.dgvAddProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAddProduct.Size = new System.Drawing.Size(639, 179);
            this.dgvAddProduct.TabIndex = 56;
            this.dgvAddProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvAddProduct.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvAddProduct_DataBindingComplete);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(267, 318);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(639, 179);
            this.dataGridView2.TabIndex = 57;
            this.dataGridView2.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView2_DataBindingComplete);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "All candidate Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Parts Associated with this Product";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 628);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dgvAddProduct);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchPartBtn);
            this.Controls.Add(this.inputPartTextField);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.partCancelbtn);
            this.Controls.Add(this.partsavebtn);
            this.Controls.Add(this.MinBox);
            this.Controls.Add(this.MaxBox);
            this.Controls.Add(this.PriceBox1);
            this.Controls.Add(this.InventoryBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.partPriceLA);
            this.Controls.Add(this.partINVLA);
            this.Controls.Add(this.partNameLA);
            this.Controls.Add(this.partIDLA);
            this.Controls.Add(this.label1);
            this.Name = "AddProductForm";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MinBox;
        private System.Windows.Forms.TextBox MaxBox;
        private System.Windows.Forms.TextBox PriceBox1;
        private System.Windows.Forms.TextBox InventoryBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label partPriceLA;
        private System.Windows.Forms.Label partINVLA;
        private System.Windows.Forms.Label partNameLA;
        private System.Windows.Forms.Label partIDLA;
        private System.Windows.Forms.Button partCancelbtn;
        private System.Windows.Forms.Button partsavebtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button searchPartBtn;
        private System.Windows.Forms.TextBox inputPartTextField;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvAddProduct;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}