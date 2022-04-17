
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
            this.btInput = new System.Windows.Forms.Button();
            this.tbInputMatrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelInputValues = new System.Windows.Forms.Panel();
            this.labelValue = new System.Windows.Forms.Label();
            this.panelInputValues.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(1072, 28);
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
            this.richTextBox.Location = new System.Drawing.Point(134, 380);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(2315, 1088);
            this.richTextBox.TabIndex = 3;
            this.richTextBox.Text = "";
            // 
            // btClearRichTextBox
            // 
            this.btClearRichTextBox.Location = new System.Drawing.Point(2313, 312);
            this.btClearRichTextBox.Name = "btClearRichTextBox";
            this.btClearRichTextBox.Size = new System.Drawing.Size(136, 48);
            this.btClearRichTextBox.TabIndex = 4;
            this.btClearRichTextBox.Text = "clear console";
            this.btClearRichTextBox.UseVisualStyleBackColor = true;
            this.btClearRichTextBox.Click += new System.EventHandler(this.btClearRichTextBox_Click);
            // 
            // btInput
            // 
            this.btInput.Location = new System.Drawing.Point(460, 298);
            this.btInput.Name = "btInput";
            this.btInput.Size = new System.Drawing.Size(136, 48);
            this.btInput.TabIndex = 5;
            this.btInput.Text = "Apply";
            this.btInput.UseVisualStyleBackColor = true;
            this.btInput.Click += new System.EventHandler(this.btInput_Click);
            // 
            // tbInputMatrice
            // 
            this.tbInputMatrice.Location = new System.Drawing.Point(294, 309);
            this.tbInputMatrice.Name = "tbInputMatrice";
            this.tbInputMatrice.Size = new System.Drawing.Size(160, 26);
            this.tbInputMatrice.TabIndex = 6;
            this.tbInputMatrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInputMatrice_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "veľkosť matice (x*x):";
            // 
            // panelInputValues
            // 
            this.panelInputValues.Controls.Add(this.labelValue);
            this.panelInputValues.Location = new System.Drawing.Point(1118, 679);
            this.panelInputValues.Name = "panelInputValues";
            this.panelInputValues.Size = new System.Drawing.Size(355, 173);
            this.panelInputValues.TabIndex = 8;
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(19, 74);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(61, 20);
            this.labelValue.TabIndex = 0;
            this.labelValue.Text = "Matrice";
            // 
            // Graphic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2586, 1575);
            this.Controls.Add(this.panelInputValues);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbInputMatrice);
            this.Controls.Add(this.btInput);
            this.Controls.Add(this.btClearRichTextBox);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.btTest);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Graphic";
            this.Text = "Gauss";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelInputValues.ResumeLayout(false);
            this.panelInputValues.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btTest;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button btClearRichTextBox;
        private System.Windows.Forms.Button btInput;
        private System.Windows.Forms.TextBox tbInputMatrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelInputValues;
        private System.Windows.Forms.Label labelValue;
    }
}

