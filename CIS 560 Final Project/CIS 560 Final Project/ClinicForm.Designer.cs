namespace CIS_560_Final_Project
{
    partial class uxClinicForm
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
            this.uxInstructionLabel = new System.Windows.Forms.Label();
            this.uxClinicListBox = new System.Windows.Forms.ListBox();
            this.uxClinicContainer = new System.Windows.Forms.GroupBox();
            this.uxAddButton = new System.Windows.Forms.Button();
            this.uxClinicTextBox = new System.Windows.Forms.TextBox();
            this.uxClinicNameLabel = new System.Windows.Forms.Label();
            this.uxAddClinicButton = new System.Windows.Forms.Button();
            this.uxClinicContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxInstructionLabel
            // 
            this.uxInstructionLabel.AutoSize = true;
            this.uxInstructionLabel.Location = new System.Drawing.Point(176, 6);
            this.uxInstructionLabel.Name = "uxInstructionLabel";
            this.uxInstructionLabel.Size = new System.Drawing.Size(165, 13);
            this.uxInstructionLabel.TabIndex = 11;
            this.uxInstructionLabel.Text = "Click clinic name for list of owners";
            // 
            // uxClinicListBox
            // 
            this.uxClinicListBox.FormattingEnabled = true;
            this.uxClinicListBox.Location = new System.Drawing.Point(175, 25);
            this.uxClinicListBox.Name = "uxClinicListBox";
            this.uxClinicListBox.Size = new System.Drawing.Size(210, 121);
            this.uxClinicListBox.TabIndex = 10;
            // 
            // uxClinicContainer
            // 
            this.uxClinicContainer.Controls.Add(this.uxAddButton);
            this.uxClinicContainer.Controls.Add(this.uxClinicTextBox);
            this.uxClinicContainer.Controls.Add(this.uxClinicNameLabel);
            this.uxClinicContainer.Enabled = false;
            this.uxClinicContainer.Location = new System.Drawing.Point(11, 71);
            this.uxClinicContainer.Name = "uxClinicContainer";
            this.uxClinicContainer.Size = new System.Drawing.Size(158, 77);
            this.uxClinicContainer.TabIndex = 9;
            this.uxClinicContainer.TabStop = false;
            this.uxClinicContainer.Text = "New Clinic";
            // 
            // uxAddButton
            // 
            this.uxAddButton.Location = new System.Drawing.Point(73, 48);
            this.uxAddButton.Name = "uxAddButton";
            this.uxAddButton.Size = new System.Drawing.Size(75, 23);
            this.uxAddButton.TabIndex = 2;
            this.uxAddButton.Text = "Add";
            this.uxAddButton.UseVisualStyleBackColor = true;
            this.uxAddButton.Click += new System.EventHandler(this.UxAddButton_Click);
            // 
            // uxClinicTextBox
            // 
            this.uxClinicTextBox.Location = new System.Drawing.Point(48, 20);
            this.uxClinicTextBox.Name = "uxClinicTextBox";
            this.uxClinicTextBox.Size = new System.Drawing.Size(100, 20);
            this.uxClinicTextBox.TabIndex = 2;
            // 
            // uxClinicNameLabel
            // 
            this.uxClinicNameLabel.AutoSize = true;
            this.uxClinicNameLabel.Location = new System.Drawing.Point(7, 20);
            this.uxClinicNameLabel.Name = "uxClinicNameLabel";
            this.uxClinicNameLabel.Size = new System.Drawing.Size(35, 13);
            this.uxClinicNameLabel.TabIndex = 0;
            this.uxClinicNameLabel.Text = "Name";
            // 
            // uxAddClinicButton
            // 
            this.uxAddClinicButton.Location = new System.Drawing.Point(12, 12);
            this.uxAddClinicButton.Name = "uxAddClinicButton";
            this.uxAddClinicButton.Size = new System.Drawing.Size(157, 53);
            this.uxAddClinicButton.TabIndex = 8;
            this.uxAddClinicButton.Text = "Add Clinic";
            this.uxAddClinicButton.UseVisualStyleBackColor = true;
            this.uxAddClinicButton.Click += new System.EventHandler(this.UxAddClinicButton_Click);
            // 
            // uxClinicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 157);
            this.Controls.Add(this.uxInstructionLabel);
            this.Controls.Add(this.uxClinicListBox);
            this.Controls.Add(this.uxClinicContainer);
            this.Controls.Add(this.uxAddClinicButton);
            this.Name = "uxClinicForm";
            this.Text = "Vet Clinic";
            this.uxClinicContainer.ResumeLayout(false);
            this.uxClinicContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxInstructionLabel;
        private System.Windows.Forms.ListBox uxClinicListBox;
        private System.Windows.Forms.GroupBox uxClinicContainer;
        private System.Windows.Forms.Button uxAddButton;
        private System.Windows.Forms.TextBox uxClinicTextBox;
        private System.Windows.Forms.Label uxClinicNameLabel;
        private System.Windows.Forms.Button uxAddClinicButton;
    }
}

