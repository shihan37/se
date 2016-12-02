namespace se
{
    partial class inventory
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
            this.tracking_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Remove_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tracking_button
            // 
            this.tracking_button.Location = new System.Drawing.Point(84, 63);
            this.tracking_button.Name = "tracking_button";
            this.tracking_button.Size = new System.Drawing.Size(145, 23);
            this.tracking_button.TabIndex = 0;
            this.tracking_button.Text = "Tracking Inventory";
            this.tracking_button.UseVisualStyleBackColor = true;
            this.tracking_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add New Inventory";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Remove_button
            // 
            this.Remove_button.Location = new System.Drawing.Point(84, 176);
            this.Remove_button.Name = "Remove_button";
            this.Remove_button.Size = new System.Drawing.Size(145, 23);
            this.Remove_button.TabIndex = 2;
            this.Remove_button.Text = "Remove Inventory";
            this.Remove_button.UseVisualStyleBackColor = true;
            this.Remove_button.Click += new System.EventHandler(this.Remove_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Remove_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tracking_button);
            this.Name = "inventory";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tracking_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Remove_button;
        private System.Windows.Forms.Button button1;
    }
}