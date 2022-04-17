
namespace Gauss_Jordan_Elimination
{
    partial class Graphic
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btTest = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.btClearRichTextBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(1049, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gauss-jordan elimination";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(702, 156);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 1;
            // 
            // btTest
            // 
            this.btTest.Location = new System.Drawing.Point(338, 148);
            this.btTest.Name = "btTest";
            this.btTest.Size = new System.Drawing.Size(89, 34);
            this.btTest.TabIndex = 2;
            this.btTest.Text = "test1";
            this.btTest.UseVisualStyleBackColor = true;
            this.btTest.Click += new System.EventHandler(this.btTest_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(134, 412);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(2315, 1056);
            this.richTextBox.TabIndex = 3;
            this.richTextBox.Text = "";
            // 
            // btClearRichTextBox
            // 
            this.btClearRichTextBox.Location = new System.Drawing.Point(2313, 342);
            this.btClearRichTextBox.Name = "btClearRichTextBox";
            this.btClearRichTextBox.Size = new System.Drawing.Size(136, 48);
            this.btClearRichTextBox.TabIndex = 4;
            this.btClearRichTextBox.Text = "clear console";
            this.btClearRichTextBox.UseVisualStyleBackColor = true;
            this.btClearRichTextBox.Click += new System.EventHandler(this.btClearRichTextBox_Click);
            // 
            // Graphic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2586, 1575);
            this.Controls.Add(this.btClearRichTextBox);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.btTest);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Graphic";
            this.Text = "Gauss";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btTest;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button btClearRichTextBox;
    }
}

