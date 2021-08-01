
namespace GTAV_LanguageChanger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LangList = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CurrentLangLabel = new System.Windows.Forms.Label();
            this.CurrentLang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LangList
            // 
            this.LangList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LangList.FormattingEnabled = true;
            this.LangList.Location = new System.Drawing.Point(12, 62);
            this.LangList.Name = "LangList";
            this.LangList.Size = new System.Drawing.Size(207, 23);
            this.LangList.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Change language";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CurrentLangLabel
            // 
            this.CurrentLangLabel.AutoSize = true;
            this.CurrentLangLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CurrentLangLabel.Location = new System.Drawing.Point(12, 9);
            this.CurrentLangLabel.MaximumSize = new System.Drawing.Size(207, 0);
            this.CurrentLangLabel.MinimumSize = new System.Drawing.Size(207, 0);
            this.CurrentLangLabel.Name = "CurrentLangLabel";
            this.CurrentLangLabel.Size = new System.Drawing.Size(207, 20);
            this.CurrentLangLabel.TabIndex = 2;
            this.CurrentLangLabel.Text = "Current language:";
            this.CurrentLangLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentLang
            // 
            this.CurrentLang.AutoSize = true;
            this.CurrentLang.Location = new System.Drawing.Point(12, 44);
            this.CurrentLang.MaximumSize = new System.Drawing.Size(207, 0);
            this.CurrentLang.MinimumSize = new System.Drawing.Size(207, 0);
            this.CurrentLang.Name = "CurrentLang";
            this.CurrentLang.Size = new System.Drawing.Size(207, 15);
            this.CurrentLang.TabIndex = 3;
            this.CurrentLang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 119);
            this.Controls.Add(this.CurrentLang);
            this.Controls.Add(this.CurrentLangLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LangList);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(247, 158);
            this.MinimumSize = new System.Drawing.Size(247, 158);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "GTA V Language Switcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox LangList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label CurrentLangLabel;
        private System.Windows.Forms.Label CurrentLang;
    }
}

