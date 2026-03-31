namespace wgu_968.Forms
{
    partial class PartForm
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
            this.inHousebtn = new System.Windows.Forms.RadioButton();
            this.OutSourcedbtn = new System.Windows.Forms.RadioButton();
            this.partsavebtn = new System.Windows.Forms.Button();
            this.partCancelbtn = new System.Windows.Forms.Button();
            this.partIDLA = new System.Windows.Forms.Label();
            this.partNameLA = new System.Windows.Forms.Label();
            this.partINVLA = new System.Windows.Forms.Label();
            this.partPriceLA = new System.Windows.Forms.Label();
            this.Machine = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.machineTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inHousebtn
            // 
            this.inHousebtn.AutoSize = true;
            this.inHousebtn.Location = new System.Drawing.Point(70, 28);
            this.inHousebtn.Name = "inHousebtn";
            this.inHousebtn.Size = new System.Drawing.Size(68, 17);
            this.inHousebtn.TabIndex = 0;
            this.inHousebtn.TabStop = true;
            this.inHousebtn.Text = "In-House";
            this.inHousebtn.UseVisualStyleBackColor = true;
            this.inHousebtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // OutSourcedbtn
            // 
            this.OutSourcedbtn.AutoSize = true;
            this.OutSourcedbtn.Location = new System.Drawing.Point(180, 28);
            this.OutSourcedbtn.Name = "OutSourcedbtn";
            this.OutSourcedbtn.Size = new System.Drawing.Size(80, 17);
            this.OutSourcedbtn.TabIndex = 1;
            this.OutSourcedbtn.TabStop = true;
            this.OutSourcedbtn.Text = "Outsourced";
            this.OutSourcedbtn.UseVisualStyleBackColor = true;
            this.OutSourcedbtn.CheckedChanged += new System.EventHandler(this.OutSourcedbtn_CheckedChanged);
            // 
            // partsavebtn
            // 
            this.partsavebtn.Location = new System.Drawing.Point(180, 289);
            this.partsavebtn.Name = "partsavebtn";
            this.partsavebtn.Size = new System.Drawing.Size(71, 31);
            this.partsavebtn.TabIndex = 2;
            this.partsavebtn.Text = "Save";
            this.partsavebtn.UseVisualStyleBackColor = true;
            this.partsavebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // partCancelbtn
            // 
            this.partCancelbtn.Location = new System.Drawing.Point(257, 289);
            this.partCancelbtn.Name = "partCancelbtn";
            this.partCancelbtn.Size = new System.Drawing.Size(75, 31);
            this.partCancelbtn.TabIndex = 3;
            this.partCancelbtn.Text = "Cancel";
            this.partCancelbtn.UseVisualStyleBackColor = true;
            this.partCancelbtn.Click += new System.EventHandler(this.partCancelbtn_Click);
            // 
            // partIDLA
            // 
            this.partIDLA.AutoSize = true;
            this.partIDLA.Location = new System.Drawing.Point(80, 71);
            this.partIDLA.Name = "partIDLA";
            this.partIDLA.Size = new System.Drawing.Size(18, 13);
            this.partIDLA.TabIndex = 4;
            this.partIDLA.Text = "ID";
            this.partIDLA.Click += new System.EventHandler(this.label1_Click);
            // 
            // partNameLA
            // 
            this.partNameLA.AutoSize = true;
            this.partNameLA.Location = new System.Drawing.Point(80, 97);
            this.partNameLA.Name = "partNameLA";
            this.partNameLA.Size = new System.Drawing.Size(35, 13);
            this.partNameLA.TabIndex = 5;
            this.partNameLA.Text = "Name";
            // 
            // partINVLA
            // 
            this.partINVLA.AutoSize = true;
            this.partINVLA.Location = new System.Drawing.Point(80, 127);
            this.partINVLA.Name = "partINVLA";
            this.partINVLA.Size = new System.Drawing.Size(51, 13);
            this.partINVLA.TabIndex = 6;
            this.partINVLA.Text = "Inventory";
            // 
            // partPriceLA
            // 
            this.partPriceLA.AutoSize = true;
            this.partPriceLA.Location = new System.Drawing.Point(80, 153);
            this.partPriceLA.Name = "partPriceLA";
            this.partPriceLA.Size = new System.Drawing.Size(63, 13);
            this.partPriceLA.TabIndex = 7;
            this.partPriceLA.Text = "Price / Cost";
            // 
            // Machine
            // 
            this.Machine.AutoSize = true;
            this.Machine.Location = new System.Drawing.Point(80, 216);
            this.Machine.Name = "Machine";
            this.Machine.Size = new System.Drawing.Size(62, 13);
            this.Machine.TabIndex = 8;
            this.Machine.Text = "Machine ID";
            this.Machine.Click += new System.EventHandler(this.partMaxLA_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Min";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(151, 97);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 12;
            this.nameTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.Location = new System.Drawing.Point(151, 127);
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.inventoryTextBox.TabIndex = 13;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(151, 153);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 14;
            // 
            // machineTextBox
            // 
            this.machineTextBox.Location = new System.Drawing.Point(160, 213);
            this.machineTextBox.Name = "machineTextBox";
            this.machineTextBox.Size = new System.Drawing.Size(100, 20);
            this.machineTextBox.TabIndex = 15;
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(113, 182);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(62, 20);
            this.maxTextBox.TabIndex = 16;
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(224, 179);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(62, 20);
            this.minTextBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Add Part";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // PartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 351);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.machineTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.inventoryTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Machine);
            this.Controls.Add(this.partPriceLA);
            this.Controls.Add(this.partINVLA);
            this.Controls.Add(this.partNameLA);
            this.Controls.Add(this.partIDLA);
            this.Controls.Add(this.partCancelbtn);
            this.Controls.Add(this.partsavebtn);
            this.Controls.Add(this.OutSourcedbtn);
            this.Controls.Add(this.inHousebtn);
            this.Name = "PartForm";
            this.Text = "Part";
            this.Load += new System.EventHandler(this.Part_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton inHousebtn;
        private System.Windows.Forms.RadioButton OutSourcedbtn;
        private System.Windows.Forms.Button partsavebtn;
        private System.Windows.Forms.Button partCancelbtn;
        private System.Windows.Forms.Label partIDLA;
        private System.Windows.Forms.Label partNameLA;
        private System.Windows.Forms.Label partINVLA;
        private System.Windows.Forms.Label partPriceLA;
        private System.Windows.Forms.Label Machine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox inventoryTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox machineTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.Label label1;
    }
}