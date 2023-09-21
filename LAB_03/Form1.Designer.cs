namespace WindowsFormsApp5
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btn_Click = new System.Windows.Forms.Button();
            this.btn_gotoTask2 = new System.Windows.Forms.Button();
            this.btn_gotoTask3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(128, 116);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(364, 116);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(100, 96);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // btn_Click
            // 
            this.btn_Click.Location = new System.Drawing.Point(240, 247);
            this.btn_Click.Name = "btn_Click";
            this.btn_Click.Size = new System.Drawing.Size(75, 23);
            this.btn_Click.TabIndex = 2;
            this.btn_Click.Text = "Task 1";
            this.btn_Click.UseVisualStyleBackColor = true;
            this.btn_Click.Click += new System.EventHandler(this.btn_Click_Click);
            // 
            // btn_gotoTask2
            // 
            this.btn_gotoTask2.Location = new System.Drawing.Point(240, 290);
            this.btn_gotoTask2.Name = "btn_gotoTask2";
            this.btn_gotoTask2.Size = new System.Drawing.Size(75, 23);
            this.btn_gotoTask2.TabIndex = 3;
            this.btn_gotoTask2.Text = "go to task 2";
            this.btn_gotoTask2.UseVisualStyleBackColor = true;
            this.btn_gotoTask2.Click += new System.EventHandler(this.btn_gotoTask2_Click);
            // 
            // btn_gotoTask3
            // 
            this.btn_gotoTask3.Location = new System.Drawing.Point(240, 332);
            this.btn_gotoTask3.Name = "btn_gotoTask3";
            this.btn_gotoTask3.Size = new System.Drawing.Size(75, 23);
            this.btn_gotoTask3.TabIndex = 4;
            this.btn_gotoTask3.Text = "go to task 3";
            this.btn_gotoTask3.UseVisualStyleBackColor = true;
            this.btn_gotoTask3.Click += new System.EventHandler(this.btn_gotoTask3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.btn_gotoTask3);
            this.Controls.Add(this.btn_gotoTask2);
            this.Controls.Add(this.btn_Click);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button btn_Click;
        private System.Windows.Forms.Button btn_gotoTask2;
        private System.Windows.Forms.Button btn_gotoTask3;
    }
}

