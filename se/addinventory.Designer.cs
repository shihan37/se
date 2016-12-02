namespace se
{
    partial class addinventory
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.ItemtextBox = new System.Windows.Forms.TextBox();
            this.PricetextBox = new System.Windows.Forms.TextBox();
            this.PurchaseTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RetireTimePicker = new System.Windows.Forms.DateTimePicker();
            this.savebutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Purchase Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Retire Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price($)";
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(145, 34);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(100, 22);
            this.IDtextBox.TabIndex = 5;
            this.IDtextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ItemtextBox
            // 
            this.ItemtextBox.Location = new System.Drawing.Point(145, 72);
            this.ItemtextBox.Name = "ItemtextBox";
            this.ItemtextBox.Size = new System.Drawing.Size(100, 22);
            this.ItemtextBox.TabIndex = 6;
            // 
            // PricetextBox
            // 
            this.PricetextBox.Location = new System.Drawing.Point(145, 184);
            this.PricetextBox.Name = "PricetextBox";
            this.PricetextBox.Size = new System.Drawing.Size(100, 22);
            this.PricetextBox.TabIndex = 7;
            // 
            // PurchaseTimePicker
            // 
            this.PurchaseTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PurchaseTimePicker.Location = new System.Drawing.Point(145, 109);
            this.PurchaseTimePicker.Name = "PurchaseTimePicker";
            this.PurchaseTimePicker.Size = new System.Drawing.Size(100, 22);
            this.PurchaseTimePicker.TabIndex = 8;
            // 
            // RetireTimePicker
            // 
            this.RetireTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RetireTimePicker.Location = new System.Drawing.Point(145, 148);
            this.RetireTimePicker.Name = "RetireTimePicker";
            this.RetireTimePicker.Size = new System.Drawing.Size(100, 22);
            this.RetireTimePicker.TabIndex = 9;
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(83, 262);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 10;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // addinventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 331);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.RetireTimePicker);
            this.Controls.Add(this.PurchaseTimePicker);
            this.Controls.Add(this.PricetextBox);
            this.Controls.Add(this.ItemtextBox);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addinventory";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.TextBox ItemtextBox;
        private System.Windows.Forms.TextBox PricetextBox;
        private System.Windows.Forms.DateTimePicker PurchaseTimePicker;
        private System.Windows.Forms.DateTimePicker RetireTimePicker;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button button1;
    }
}