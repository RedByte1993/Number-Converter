namespace NumberConverter
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox_CurrentBase = new System.Windows.Forms.TextBox();
            this.TextBox_Number = new System.Windows.Forms.TextBox();
            this.TextBox_ConvertedToBase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RichTextBox_Output = new System.Windows.Forms.RichTextBox();
            this.Button_Convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox_CurrentBase
            // 
            this.TextBox_CurrentBase.Location = new System.Drawing.Point(124, 39);
            this.TextBox_CurrentBase.Name = "TextBox_CurrentBase";
            this.TextBox_CurrentBase.Size = new System.Drawing.Size(234, 20);
            this.TextBox_CurrentBase.TabIndex = 0;
            // 
            // TextBox_Number
            // 
            this.TextBox_Number.Location = new System.Drawing.Point(124, 7);
            this.TextBox_Number.Name = "TextBox_Number";
            this.TextBox_Number.Size = new System.Drawing.Size(234, 20);
            this.TextBox_Number.TabIndex = 2;
            // 
            // TextBox_ConvertedToBase
            // 
            this.TextBox_ConvertedToBase.Location = new System.Drawing.Point(124, 75);
            this.TextBox_ConvertedToBase.Name = "TextBox_ConvertedToBase";
            this.TextBox_ConvertedToBase.Size = new System.Drawing.Size(234, 20);
            this.TextBox_ConvertedToBase.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Current base:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Converted to base:";
            // 
            // RichTextBox_Output
            // 
            this.RichTextBox_Output.Location = new System.Drawing.Point(17, 139);
            this.RichTextBox_Output.Name = "RichTextBox_Output";
            this.RichTextBox_Output.Size = new System.Drawing.Size(447, 133);
            this.RichTextBox_Output.TabIndex = 7;
            this.RichTextBox_Output.Text = "";
            // 
            // Button_Convert
            // 
            this.Button_Convert.Location = new System.Drawing.Point(363, 99);
            this.Button_Convert.Name = "Button_Convert";
            this.Button_Convert.Size = new System.Drawing.Size(101, 34);
            this.Button_Convert.TabIndex = 8;
            this.Button_Convert.Text = "Convert";
            this.Button_Convert.UseVisualStyleBackColor = true;
            this.Button_Convert.Click += new System.EventHandler(this.Button_Convert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 284);
            this.Controls.Add(this.Button_Convert);
            this.Controls.Add(this.RichTextBox_Output);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_ConvertedToBase);
            this.Controls.Add(this.TextBox_Number);
            this.Controls.Add(this.TextBox_CurrentBase);
            this.MaximumSize = new System.Drawing.Size(492, 323);
            this.MinimumSize = new System.Drawing.Size(492, 323);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_CurrentBase;
        private System.Windows.Forms.TextBox TextBox_Number;
        private System.Windows.Forms.TextBox TextBox_ConvertedToBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox RichTextBox_Output;
        private System.Windows.Forms.Button Button_Convert;
    }
}

