
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
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.btClearRichTextBox = new System.Windows.Forms.Button();
            this.btInput = new System.Windows.Forms.Button();
            this.tbInputMatrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelInputValues = new System.Windows.Forms.Panel();
            this.btCancedlInputData = new System.Windows.Forms.Button();
            this.btInsertInputData = new System.Windows.Forms.Button();
            this.tbInputData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDataInputValue = new System.Windows.Forms.Label();
            this.btInsertData = new System.Windows.Forms.Button();
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
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(125, 300);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(2324, 1156);
            this.richTextBox.TabIndex = 3;
            this.richTextBox.Text = "";
            // 
            // btClearRichTextBox
            // 
            this.btClearRichTextBox.Location = new System.Drawing.Point(2313, 237);
            this.btClearRichTextBox.Name = "btClearRichTextBox";
            this.btClearRichTextBox.Size = new System.Drawing.Size(136, 48);
            this.btClearRichTextBox.TabIndex = 4;
            this.btClearRichTextBox.Text = "clear console";
            this.btClearRichTextBox.UseVisualStyleBackColor = true;
            this.btClearRichTextBox.Click += new System.EventHandler(this.btClearRichTextBox_Click);
            // 
            // btInput
            // 
            this.btInput.Location = new System.Drawing.Point(461, 188);
            this.btInput.Name = "btInput";
            this.btInput.Size = new System.Drawing.Size(136, 48);
            this.btInput.TabIndex = 5;
            this.btInput.Text = "Apply";
            this.btInput.UseVisualStyleBackColor = true;
            this.btInput.Click += new System.EventHandler(this.btInput_Click);
            // 
            // tbInputMatrice
            // 
            this.tbInputMatrice.Location = new System.Drawing.Point(280, 199);
            this.tbInputMatrice.Name = "tbInputMatrice";
            this.tbInputMatrice.Size = new System.Drawing.Size(160, 26);
            this.tbInputMatrice.TabIndex = 6;
            this.tbInputMatrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInputMatrice_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "matrice size (x*x):";
            // 
            // panelInputValues
            // 
            this.panelInputValues.Controls.Add(this.btCancedlInputData);
            this.panelInputValues.Controls.Add(this.btInsertInputData);
            this.panelInputValues.Controls.Add(this.tbInputData);
            this.panelInputValues.Controls.Add(this.label3);
            this.panelInputValues.Controls.Add(this.labelDataInputValue);
            this.panelInputValues.Location = new System.Drawing.Point(1118, 679);
            this.panelInputValues.Name = "panelInputValues";
            this.panelInputValues.Size = new System.Drawing.Size(355, 159);
            this.panelInputValues.TabIndex = 8;
            // 
            // btCancedlInputData
            // 
            this.btCancedlInputData.Location = new System.Drawing.Point(248, 116);
            this.btCancedlInputData.Name = "btCancedlInputData";
            this.btCancedlInputData.Size = new System.Drawing.Size(75, 27);
            this.btCancedlInputData.TabIndex = 4;
            this.btCancedlInputData.Text = "Cancel";
            this.btCancedlInputData.UseVisualStyleBackColor = true;
            this.btCancedlInputData.Click += new System.EventHandler(this.btCancedlInputData_Click);
            // 
            // btInsertInputData
            // 
            this.btInsertInputData.Location = new System.Drawing.Point(248, 73);
            this.btInsertInputData.Name = "btInsertInputData";
            this.btInsertInputData.Size = new System.Drawing.Size(75, 27);
            this.btInsertInputData.TabIndex = 3;
            this.btInsertInputData.Text = "Insert";
            this.btInsertInputData.UseVisualStyleBackColor = true;
            this.btInsertInputData.Click += new System.EventHandler(this.btInsertInputData_Click);
            // 
            // tbInputData
            // 
            this.tbInputData.Location = new System.Drawing.Point(125, 74);
            this.tbInputData.Name = "tbInputData";
            this.tbInputData.Size = new System.Drawing.Size(100, 26);
            this.tbInputData.TabIndex = 2;
            this.tbInputData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInputData_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Data input";
            // 
            // labelDataInputValue
            // 
            this.labelDataInputValue.AutoSize = true;
            this.labelDataInputValue.Location = new System.Drawing.Point(19, 74);
            this.labelDataInputValue.Name = "labelDataInputValue";
            this.labelDataInputValue.Size = new System.Drawing.Size(61, 20);
            this.labelDataInputValue.TabIndex = 0;
            this.labelDataInputValue.Text = "Matrice";
            // 
            // btInsertData
            // 
            this.btInsertData.Location = new System.Drawing.Point(125, 246);
            this.btInsertData.Name = "btInsertData";
            this.btInsertData.Size = new System.Drawing.Size(136, 39);
            this.btInsertData.TabIndex = 9;
            this.btInsertData.Text = "Insert Data";
            this.btInsertData.UseVisualStyleBackColor = true;
            this.btInsertData.Click += new System.EventHandler(this.btInsertData_Click);
            // 
            // Graphic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2586, 1575);
            this.Controls.Add(this.btInsertData);
            this.Controls.Add(this.panelInputValues);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbInputMatrice);
            this.Controls.Add(this.btInput);
            this.Controls.Add(this.btClearRichTextBox);
            this.Controls.Add(this.richTextBox);
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
        private System.Windows.Forms.Button btClearRichTextBox;
        private System.Windows.Forms.Button btInput;
        private System.Windows.Forms.TextBox tbInputMatrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btInsertInputData;
        private System.Windows.Forms.TextBox tbInputData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btInsertData;
        private System.Windows.Forms.Button btCancedlInputData;
        public System.Windows.Forms.Panel panelInputValues;
        public System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label labelDataInputValue;
    }
}

