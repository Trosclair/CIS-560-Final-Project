namespace CIS_560_Final_Project
{
    partial class uxVisitForm
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
            this.uxVisitListBox = new System.Windows.Forms.ListBox();
            this.uxVisitContainer = new System.Windows.Forms.GroupBox();
            this.uxAddButton = new System.Windows.Forms.Button();
            this.uxNameTextBox = new System.Windows.Forms.TextBox();
            this.uxIsActiveRadio = new System.Windows.Forms.RadioButton();
            this.uxAilmentNameTextBox = new System.Windows.Forms.TextBox();
            this.uxWeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.uxVetLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uxAilmentLabel = new System.Windows.Forms.Label();
            this.uxWeightLabel = new System.Windows.Forms.Label();
            this.uxAddVisitButton = new System.Windows.Forms.Button();
            this.uxAilmentNameListBox = new System.Windows.Forms.ListBox();
            this.uxVisitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxWeightNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // uxInstructionLabel
            // 
            this.uxInstructionLabel.AutoSize = true;
            this.uxInstructionLabel.Location = new System.Drawing.Point(219, 12);
            this.uxInstructionLabel.Name = "uxInstructionLabel";
            this.uxInstructionLabel.Size = new System.Drawing.Size(122, 13);
            this.uxInstructionLabel.TabIndex = 7;
            this.uxInstructionLabel.Text = "Click Visits to see details";
            // 
            // uxVisitListBox
            // 
            this.uxVisitListBox.FormattingEnabled = true;
            this.uxVisitListBox.Location = new System.Drawing.Point(219, 38);
            this.uxVisitListBox.Name = "uxVisitListBox";
            this.uxVisitListBox.Size = new System.Drawing.Size(409, 342);
            this.uxVisitListBox.TabIndex = 6;
            // 
            // uxVisitContainer
            // 
            this.uxVisitContainer.Controls.Add(this.uxAilmentNameListBox);
            this.uxVisitContainer.Controls.Add(this.uxAddButton);
            this.uxVisitContainer.Controls.Add(this.uxNameTextBox);
            this.uxVisitContainer.Controls.Add(this.uxIsActiveRadio);
            this.uxVisitContainer.Controls.Add(this.uxAilmentNameTextBox);
            this.uxVisitContainer.Controls.Add(this.uxWeightNumericUpDown);
            this.uxVisitContainer.Controls.Add(this.uxVetLabel);
            this.uxVisitContainer.Controls.Add(this.label3);
            this.uxVisitContainer.Controls.Add(this.uxAilmentLabel);
            this.uxVisitContainer.Controls.Add(this.uxWeightLabel);
            this.uxVisitContainer.Enabled = false;
            this.uxVisitContainer.Location = new System.Drawing.Point(12, 56);
            this.uxVisitContainer.Name = "uxVisitContainer";
            this.uxVisitContainer.Size = new System.Drawing.Size(200, 332);
            this.uxVisitContainer.TabIndex = 5;
            this.uxVisitContainer.TabStop = false;
            this.uxVisitContainer.Text = "Visit Details";
            // 
            // uxAddButton
            // 
            this.uxAddButton.Location = new System.Drawing.Point(110, 295);
            this.uxAddButton.Name = "uxAddButton";
            this.uxAddButton.Size = new System.Drawing.Size(75, 23);
            this.uxAddButton.TabIndex = 6;
            this.uxAddButton.Text = "Add";
            this.uxAddButton.UseVisualStyleBackColor = true;
            this.uxAddButton.Click += new System.EventHandler(this.UxAddButton_Click_1);
            // 
            // uxNameTextBox
            // 
            this.uxNameTextBox.Location = new System.Drawing.Point(85, 262);
            this.uxNameTextBox.Name = "uxNameTextBox";
            this.uxNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.uxNameTextBox.TabIndex = 5;
            // 
            // uxIsActiveRadio
            // 
            this.uxIsActiveRadio.AutoSize = true;
            this.uxIsActiveRadio.Location = new System.Drawing.Point(85, 236);
            this.uxIsActiveRadio.Name = "uxIsActiveRadio";
            this.uxIsActiveRadio.Size = new System.Drawing.Size(63, 17);
            this.uxIsActiveRadio.TabIndex = 4;
            this.uxIsActiveRadio.TabStop = true;
            this.uxIsActiveRadio.Text = "IsActive";
            this.uxIsActiveRadio.UseVisualStyleBackColor = true;
            this.uxIsActiveRadio.CheckedChanged += new System.EventHandler(this.UxIsActiveRadio_CheckedChanged);
            // 
            // uxAilmentNameTextBox
            // 
            this.uxAilmentNameTextBox.Enabled = false;
            this.uxAilmentNameTextBox.Location = new System.Drawing.Point(85, 210);
            this.uxAilmentNameTextBox.Name = "uxAilmentNameTextBox";
            this.uxAilmentNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.uxAilmentNameTextBox.TabIndex = 3;
            // 
            // uxWeightNumericUpDown
            // 
            this.uxWeightNumericUpDown.Location = new System.Drawing.Point(85, 18);
            this.uxWeightNumericUpDown.Name = "uxWeightNumericUpDown";
            this.uxWeightNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.uxWeightNumericUpDown.TabIndex = 2;
            // 
            // uxVetLabel
            // 
            this.uxVetLabel.AutoSize = true;
            this.uxVetLabel.Location = new System.Drawing.Point(7, 262);
            this.uxVetLabel.Name = "uxVetLabel";
            this.uxVetLabel.Size = new System.Drawing.Size(54, 13);
            this.uxVetLabel.TabIndex = 2;
            this.uxVetLabel.Text = "Vet Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // uxAilmentLabel
            // 
            this.uxAilmentLabel.AutoSize = true;
            this.uxAilmentLabel.Location = new System.Drawing.Point(7, 51);
            this.uxAilmentLabel.Name = "uxAilmentLabel";
            this.uxAilmentLabel.Size = new System.Drawing.Size(164, 13);
            this.uxAilmentLabel.TabIndex = 2;
            this.uxAilmentLabel.Text = "Ailment Name (Double Click One)";
            // 
            // uxWeightLabel
            // 
            this.uxWeightLabel.AutoSize = true;
            this.uxWeightLabel.Location = new System.Drawing.Point(7, 20);
            this.uxWeightLabel.Name = "uxWeightLabel";
            this.uxWeightLabel.Size = new System.Drawing.Size(41, 13);
            this.uxWeightLabel.TabIndex = 0;
            this.uxWeightLabel.Text = "Weight";
            // 
            // uxAddVisitButton
            // 
            this.uxAddVisitButton.Location = new System.Drawing.Point(12, 12);
            this.uxAddVisitButton.Name = "uxAddVisitButton";
            this.uxAddVisitButton.Size = new System.Drawing.Size(200, 37);
            this.uxAddVisitButton.TabIndex = 4;
            this.uxAddVisitButton.Text = "Add Visit";
            this.uxAddVisitButton.UseVisualStyleBackColor = true;
            this.uxAddVisitButton.Click += new System.EventHandler(this.UxAddVisitButton_Click);
            // 
            // uxAilmentNameListBox
            // 
            this.uxAilmentNameListBox.FormattingEnabled = true;
            this.uxAilmentNameListBox.Location = new System.Drawing.Point(10, 67);
            this.uxAilmentNameListBox.Name = "uxAilmentNameListBox";
            this.uxAilmentNameListBox.Size = new System.Drawing.Size(185, 134);
            this.uxAilmentNameListBox.TabIndex = 8;
            // 
            // uxVisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 400);
            this.Controls.Add(this.uxInstructionLabel);
            this.Controls.Add(this.uxVisitListBox);
            this.Controls.Add(this.uxVisitContainer);
            this.Controls.Add(this.uxAddVisitButton);
            this.Name = "uxVisitForm";
            this.Text = "Pets Visits";
            this.uxVisitContainer.ResumeLayout(false);
            this.uxVisitContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxWeightNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxInstructionLabel;
        private System.Windows.Forms.ListBox uxVisitListBox;
        private System.Windows.Forms.GroupBox uxVisitContainer;
        private System.Windows.Forms.Button uxAddButton;
        private System.Windows.Forms.TextBox uxNameTextBox;
        private System.Windows.Forms.RadioButton uxIsActiveRadio;
        private System.Windows.Forms.TextBox uxAilmentNameTextBox;
        private System.Windows.Forms.NumericUpDown uxWeightNumericUpDown;
        private System.Windows.Forms.Label uxVetLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label uxAilmentLabel;
        private System.Windows.Forms.Label uxWeightLabel;
        private System.Windows.Forms.Button uxAddVisitButton;
        private System.Windows.Forms.ListBox uxAilmentNameListBox;
    }
}