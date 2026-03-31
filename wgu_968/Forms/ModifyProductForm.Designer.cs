namespace wgu_968.Forms
{
    partial class ModifyProductForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.searchPartBtn = new System.Windows.Forms.Button();
            this.inputPartTextField = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.partCancelbtn = new System.Windows.Forms.Button();
            this.partsavebtn = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.partPriceLA = new System.Windows.Forms.Label();
            this.partINVLA = new System.Windows.Forms.Label();
            this.partNameLA = new System.Windows.Forms.Label();
            this.partIDLA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 13);
            this.label3.TabIndex = 84;
            this.label3.Text = "Parts Associated with this Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "All candidate Parts";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(297, 323);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(398, 179);
            this.dataGridView2.TabIndex = 82;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(297, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(398, 179);
            this.dataGridView1.TabIndex = 81;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(625, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 31);
            this.button2.TabIndex = 80;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // searchPartBtn
            // 
            this.searchPartBtn.Location = new System.Drawing.Point(441, 52);
            this.searchPartBtn.Name = "searchPartBtn";
            this.searchPartBtn.Size = new System.Drawing.Size(69, 23);
            this.searchPartBtn.TabIndex = 79;
            this.searchPartBtn.Text = "Search";
            this.searchPartBtn.UseVisualStyleBackColor = true;
            // 
            // inputPartTextField
            // 
            this.inputPartTextField.Location = new System.Drawing.Point(516, 54);
            this.inputPartTextField.Name = "inputPartTextField";
            this.inputPartTextField.Size = new System.Drawing.Size(179, 20);
            this.inputPartTextField.TabIndex = 78;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(624, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 31);
            this.button1.TabIndex = 77;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // partCancelbtn
            // 
            this.partCancelbtn.Location = new System.Drawing.Point(620, 566);
            this.partCancelbtn.Name = "partCancelbtn";
            this.partCancelbtn.Size = new System.Drawing.Size(75, 31);
            this.partCancelbtn.TabIndex = 76;
            this.partCancelbtn.Text = "Cancel";
            this.partCancelbtn.UseVisualStyleBackColor = true;
            this.partCancelbtn.Click += new System.EventHandler(this.partCancelbtn_Click);
            // 
            // partsavebtn
            // 
            this.partsavebtn.Location = new System.Drawing.Point(543, 566);
            this.partsavebtn.Name = "partsavebtn";
            this.partsavebtn.Size = new System.Drawing.Size(71, 31);
            this.partsavebtn.TabIndex = 75;
            this.partsavebtn.Text = "Save";
            this.partsavebtn.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(192, 349);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(68, 20);
            this.textBox7.TabIndex = 74;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(81, 352);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(68, 20);
            this.textBox6.TabIndex = 73;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(119, 323);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(106, 20);
            this.textBox4.TabIndex = 71;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(119, 297);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(106, 20);
            this.textBox3.TabIndex = 70;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 267);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(106, 20);
            this.textBox2.TabIndex = 69;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 241);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 20);
            this.textBox1.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Max";
            // 
            // partPriceLA
            // 
            this.partPriceLA.AutoSize = true;
            this.partPriceLA.Location = new System.Drawing.Point(48, 323);
            this.partPriceLA.Name = "partPriceLA";
            this.partPriceLA.Size = new System.Drawing.Size(63, 13);
            this.partPriceLA.TabIndex = 64;
            this.partPriceLA.Text = "Price / Cost";
            // 
            // partINVLA
            // 
            this.partINVLA.AutoSize = true;
            this.partINVLA.Location = new System.Drawing.Point(48, 297);
            this.partINVLA.Name = "partINVLA";
            this.partINVLA.Size = new System.Drawing.Size(51, 13);
            this.partINVLA.TabIndex = 63;
            this.partINVLA.Text = "Inventory";
            // 
            // partNameLA
            // 
            this.partNameLA.AutoSize = true;
            this.partNameLA.Location = new System.Drawing.Point(48, 267);
            this.partNameLA.Name = "partNameLA";
            this.partNameLA.Size = new System.Drawing.Size(35, 13);
            this.partNameLA.TabIndex = 62;
            this.partNameLA.Text = "Name";
            // 
            // partIDLA
            // 
            this.partIDLA.AutoSize = true;
            this.partIDLA.Location = new System.Drawing.Point(48, 241);
            this.partIDLA.Name = "partIDLA";
            this.partIDLA.Size = new System.Drawing.Size(18, 13);
            this.partIDLA.TabIndex = 61;
            this.partIDLA.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "Modify Product";
            // 
            // ModifyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 623);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchPartBtn);
            this.Controls.Add(this.inputPartTextField);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.partCancelbtn);
            this.Controls.Add(this.partsavebtn);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.partPriceLA);
            this.Controls.Add(this.partINVLA);
            this.Controls.Add(this.partNameLA);
            this.Controls.Add(this.partIDLA);
            this.Controls.Add(this.label1);
            this.Name = "ModifyProductForm";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button searchPartBtn;
        private System.Windows.Forms.TextBox inputPartTextField;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button partCancelbtn;
        private System.Windows.Forms.Button partsavebtn;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label partPriceLA;
        private System.Windows.Forms.Label partINVLA;
        private System.Windows.Forms.Label partNameLA;
        private System.Windows.Forms.Label partIDLA;
        private System.Windows.Forms.Label label1;
    }
}