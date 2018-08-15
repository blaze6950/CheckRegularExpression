namespace CheckRegularExpression
{
    partial class CheckRegularExpression
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
            this.regularExpression = new System.Windows.Forms.TextBox();
            this.registerCheckBox = new System.Windows.Forms.CheckBox();
            this.multilineSearchCheckBox = new System.Windows.Forms.CheckBox();
            this.textGB = new System.Windows.Forms.GroupBox();
            this.text = new System.Windows.Forms.TextBox();
            this.matchesGB = new System.Windows.Forms.GroupBox();
            this.matchesListBox = new System.Windows.Forms.ListBox();
            this.regularExprissionGB = new System.Windows.Forms.GroupBox();
            this.check = new System.Windows.Forms.Button();
            this.textGB.SuspendLayout();
            this.matchesGB.SuspendLayout();
            this.regularExprissionGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // regularExpression
            // 
            this.regularExpression.Location = new System.Drawing.Point(6, 19);
            this.regularExpression.Name = "regularExpression";
            this.regularExpression.Size = new System.Drawing.Size(250, 20);
            this.regularExpression.TabIndex = 1;
            // 
            // registerCheckBox
            // 
            this.registerCheckBox.AutoSize = true;
            this.registerCheckBox.Location = new System.Drawing.Point(13, 65);
            this.registerCheckBox.Name = "registerCheckBox";
            this.registerCheckBox.Size = new System.Drawing.Size(120, 17);
            this.registerCheckBox.TabIndex = 2;
            this.registerCheckBox.Text = "С учетом регистра";
            this.registerCheckBox.UseVisualStyleBackColor = true;
            // 
            // multilineSearchCheckBox
            // 
            this.multilineSearchCheckBox.AutoSize = true;
            this.multilineSearchCheckBox.Location = new System.Drawing.Point(136, 65);
            this.multilineSearchCheckBox.Name = "multilineSearchCheckBox";
            this.multilineSearchCheckBox.Size = new System.Drawing.Size(139, 17);
            this.multilineSearchCheckBox.TabIndex = 3;
            this.multilineSearchCheckBox.Text = "Многострочный поиск";
            this.multilineSearchCheckBox.UseVisualStyleBackColor = true;
            // 
            // textGB
            // 
            this.textGB.Controls.Add(this.text);
            this.textGB.Location = new System.Drawing.Point(12, 122);
            this.textGB.Name = "textGB";
            this.textGB.Size = new System.Drawing.Size(262, 131);
            this.textGB.TabIndex = 4;
            this.textGB.TabStop = false;
            this.textGB.Text = "Текст";
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(7, 19);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(250, 106);
            this.text.TabIndex = 5;
            // 
            // matchesGB
            // 
            this.matchesGB.Controls.Add(this.matchesListBox);
            this.matchesGB.Location = new System.Drawing.Point(281, 12);
            this.matchesGB.Name = "matchesGB";
            this.matchesGB.Size = new System.Drawing.Size(238, 241);
            this.matchesGB.TabIndex = 5;
            this.matchesGB.TabStop = false;
            this.matchesGB.Text = "Совпадения";
            // 
            // matchesListBox
            // 
            this.matchesListBox.FormattingEnabled = true;
            this.matchesListBox.Location = new System.Drawing.Point(6, 20);
            this.matchesListBox.Name = "matchesListBox";
            this.matchesListBox.Size = new System.Drawing.Size(226, 212);
            this.matchesListBox.TabIndex = 0;
            // 
            // regularExprissionGB
            // 
            this.regularExprissionGB.Controls.Add(this.regularExpression);
            this.regularExprissionGB.Location = new System.Drawing.Point(13, 12);
            this.regularExprissionGB.Name = "regularExprissionGB";
            this.regularExprissionGB.Size = new System.Drawing.Size(262, 47);
            this.regularExprissionGB.TabIndex = 6;
            this.regularExprissionGB.TabStop = false;
            this.regularExprissionGB.Text = "Регулярное выражение";
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(13, 90);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(262, 26);
            this.check.TabIndex = 7;
            this.check.Text = "Проверить!";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // CheckRegularExpression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 265);
            this.Controls.Add(this.check);
            this.Controls.Add(this.regularExprissionGB);
            this.Controls.Add(this.matchesGB);
            this.Controls.Add(this.textGB);
            this.Controls.Add(this.multilineSearchCheckBox);
            this.Controls.Add(this.registerCheckBox);
            this.Name = "CheckRegularExpression";
            this.Text = "CheckRegularExpression";
            this.textGB.ResumeLayout(false);
            this.textGB.PerformLayout();
            this.matchesGB.ResumeLayout(false);
            this.regularExprissionGB.ResumeLayout(false);
            this.regularExprissionGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox regularExpression;
        private System.Windows.Forms.CheckBox registerCheckBox;
        private System.Windows.Forms.CheckBox multilineSearchCheckBox;
        private System.Windows.Forms.GroupBox textGB;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.GroupBox matchesGB;
        private System.Windows.Forms.ListBox matchesListBox;
        private System.Windows.Forms.GroupBox regularExprissionGB;
        private System.Windows.Forms.Button check;
    }
}

