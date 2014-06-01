namespace statistic_footbol2
{
    partial class FormNastr
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
            this.checkTeam = new System.Windows.Forms.CheckBox();
            this.checkField = new System.Windows.Forms.CheckBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkTeam
            // 
            this.checkTeam.AutoSize = true;
            this.checkTeam.Checked = true;
            this.checkTeam.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkTeam.Location = new System.Drawing.Point(40, 57);
            this.checkTeam.Name = "checkTeam";
            this.checkTeam.Size = new System.Drawing.Size(298, 17);
            this.checkTeam.TabIndex = 0;
            this.checkTeam.Text = "Собирать статистику по владению мячем командами";
            this.checkTeam.UseVisualStyleBackColor = true;
            // 
            // checkField
            // 
            this.checkField.AutoSize = true;
            this.checkField.Checked = true;
            this.checkField.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkField.Location = new System.Drawing.Point(40, 94);
            this.checkField.Name = "checkField";
            this.checkField.Size = new System.Drawing.Size(279, 17);
            this.checkField.TabIndex = 1;
            this.checkField.Text = "Собирать статистику по владению мячем на поле";
            this.checkField.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(246, 147);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Сохранить";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormNastr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 189);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.checkField);
            this.Controls.Add(this.checkTeam);
            this.Name = "FormNastr";
            this.Text = "Настройки статистики";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkTeam;
        private System.Windows.Forms.CheckBox checkField;
        private System.Windows.Forms.Button buttonClose;
    }
}