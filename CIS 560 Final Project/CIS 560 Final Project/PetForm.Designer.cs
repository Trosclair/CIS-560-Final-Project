namespace CIS_560_Final_Project
{
    partial class uxPetForm
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
            this.uxPetListBox = new System.Windows.Forms.ListBox();
            this.uxPetContainer = new System.Windows.Forms.GroupBox();
            this.uxAddButton = new System.Windows.Forms.Button();
            this.uxHourLabel = new System.Windows.Forms.Label();
            this.uxDayLabel = new System.Windows.Forms.Label();
            this.uxMonthLabel = new System.Windows.Forms.Label();
            this.uxYearLabel = new System.Windows.Forms.Label();
            this.uxBirthDateLabel = new System.Windows.Forms.Label();
            this.uxNameTextBox = new System.Windows.Forms.TextBox();
            this.uxNameLabel = new System.Windows.Forms.Label();
            this.uxBreedTextBox = new System.Windows.Forms.TextBox();
            this.uxBreedLabel = new System.Windows.Forms.Label();
            this.uxAddPetButton = new System.Windows.Forms.Button();
            this.uxYearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.uxMonthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.uxDayNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.uxHourNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.uxPetContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxYearNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxMonthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxDayNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxHourNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // uxInstructionLabel
            // 
            this.uxInstructionLabel.AutoSize = true;
            this.uxInstructionLabel.Location = new System.Drawing.Point(192, 12);
            this.uxInstructionLabel.Name = "uxInstructionLabel";
            this.uxInstructionLabel.Size = new System.Drawing.Size(112, 13);
            this.uxInstructionLabel.TabIndex = 7;
            this.uxInstructionLabel.Text = "Click Pet to view visits";
            // 
            // uxPetListBox
            // 
            this.uxPetListBox.FormattingEnabled = true;
            this.uxPetListBox.Location = new System.Drawing.Point(195, 38);
            this.uxPetListBox.Name = "uxPetListBox";
            this.uxPetListBox.Size = new System.Drawing.Size(313, 238);
            this.uxPetListBox.TabIndex = 6;
            // 
            // uxPetContainer
            // 
            this.uxPetContainer.Controls.Add(this.uxHourNumericUpDown);
            this.uxPetContainer.Controls.Add(this.uxDayNumericUpDown);
            this.uxPetContainer.Controls.Add(this.uxMonthNumericUpDown);
            this.uxPetContainer.Controls.Add(this.uxYearNumericUpDown);
            this.uxPetContainer.Controls.Add(this.uxAddButton);
            this.uxPetContainer.Controls.Add(this.uxHourLabel);
            this.uxPetContainer.Controls.Add(this.uxDayLabel);
            this.uxPetContainer.Controls.Add(this.uxMonthLabel);
            this.uxPetContainer.Controls.Add(this.uxYearLabel);
            this.uxPetContainer.Controls.Add(this.uxBirthDateLabel);
            this.uxPetContainer.Controls.Add(this.uxNameTextBox);
            this.uxPetContainer.Controls.Add(this.uxNameLabel);
            this.uxPetContainer.Controls.Add(this.uxBreedTextBox);
            this.uxPetContainer.Controls.Add(this.uxBreedLabel);
            this.uxPetContainer.Location = new System.Drawing.Point(12, 41);
            this.uxPetContainer.Name = "uxPetContainer";
            this.uxPetContainer.Size = new System.Drawing.Size(162, 277);
            this.uxPetContainer.TabIndex = 5;
            this.uxPetContainer.TabStop = false;
            this.uxPetContainer.Text = "Pet";
            // 
            // uxAddButton
            // 
            this.uxAddButton.Location = new System.Drawing.Point(72, 248);
            this.uxAddButton.Name = "uxAddButton";
            this.uxAddButton.Size = new System.Drawing.Size(75, 23);
            this.uxAddButton.TabIndex = 6;
            this.uxAddButton.Text = "Add";
            this.uxAddButton.UseVisualStyleBackColor = true;
            this.uxAddButton.Click += new System.EventHandler(this.UxAddButton_Click_1);
            // 
            // uxHourLabel
            // 
            this.uxHourLabel.AutoSize = true;
            this.uxHourLabel.Location = new System.Drawing.Point(6, 173);
            this.uxHourLabel.Name = "uxHourLabel";
            this.uxHourLabel.Size = new System.Drawing.Size(30, 13);
            this.uxHourLabel.TabIndex = 2;
            this.uxHourLabel.Text = "Hour";
            // 
            // uxDayLabel
            // 
            this.uxDayLabel.AutoSize = true;
            this.uxDayLabel.Location = new System.Drawing.Point(6, 147);
            this.uxDayLabel.Name = "uxDayLabel";
            this.uxDayLabel.Size = new System.Drawing.Size(26, 13);
            this.uxDayLabel.TabIndex = 3;
            this.uxDayLabel.Text = "Day";
            // 
            // uxMonthLabel
            // 
            this.uxMonthLabel.AutoSize = true;
            this.uxMonthLabel.Location = new System.Drawing.Point(6, 121);
            this.uxMonthLabel.Name = "uxMonthLabel";
            this.uxMonthLabel.Size = new System.Drawing.Size(37, 13);
            this.uxMonthLabel.TabIndex = 4;
            this.uxMonthLabel.Text = "Month";
            // 
            // uxYearLabel
            // 
            this.uxYearLabel.AutoSize = true;
            this.uxYearLabel.Location = new System.Drawing.Point(6, 95);
            this.uxYearLabel.Name = "uxYearLabel";
            this.uxYearLabel.Size = new System.Drawing.Size(29, 13);
            this.uxYearLabel.TabIndex = 2;
            this.uxYearLabel.Text = "Year";
            // 
            // uxBirthDateLabel
            // 
            this.uxBirthDateLabel.AutoSize = true;
            this.uxBirthDateLabel.Location = new System.Drawing.Point(6, 70);
            this.uxBirthDateLabel.Name = "uxBirthDateLabel";
            this.uxBirthDateLabel.Size = new System.Drawing.Size(54, 13);
            this.uxBirthDateLabel.TabIndex = 2;
            this.uxBirthDateLabel.Text = "BirthDate:";
            // 
            // uxNameTextBox
            // 
            this.uxNameTextBox.Location = new System.Drawing.Point(56, 48);
            this.uxNameTextBox.Name = "uxNameTextBox";
            this.uxNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.uxNameTextBox.TabIndex = 2;
            // 
            // uxNameLabel
            // 
            this.uxNameLabel.AutoSize = true;
            this.uxNameLabel.Location = new System.Drawing.Point(6, 45);
            this.uxNameLabel.Name = "uxNameLabel";
            this.uxNameLabel.Size = new System.Drawing.Size(35, 13);
            this.uxNameLabel.TabIndex = 2;
            this.uxNameLabel.Text = "Name";
            // 
            // uxBreedTextBox
            // 
            this.uxBreedTextBox.Location = new System.Drawing.Point(56, 19);
            this.uxBreedTextBox.Name = "uxBreedTextBox";
            this.uxBreedTextBox.Size = new System.Drawing.Size(100, 20);
            this.uxBreedTextBox.TabIndex = 2;
            // 
            // uxBreedLabel
            // 
            this.uxBreedLabel.AutoSize = true;
            this.uxBreedLabel.Location = new System.Drawing.Point(6, 16);
            this.uxBreedLabel.Name = "uxBreedLabel";
            this.uxBreedLabel.Size = new System.Drawing.Size(35, 13);
            this.uxBreedLabel.TabIndex = 3;
            this.uxBreedLabel.Text = "Breed";
            // 
            // uxAddPetButton
            // 
            this.uxAddPetButton.Location = new System.Drawing.Point(12, 12);
            this.uxAddPetButton.Name = "uxAddPetButton";
            this.uxAddPetButton.Size = new System.Drawing.Size(162, 23);
            this.uxAddPetButton.TabIndex = 4;
            this.uxAddPetButton.Text = "Add Pet";
            this.uxAddPetButton.UseVisualStyleBackColor = true;
            // 
            // uxYearNumericUpDown
            // 
            this.uxYearNumericUpDown.Location = new System.Drawing.Point(56, 93);
            this.uxYearNumericUpDown.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.uxYearNumericUpDown.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.uxYearNumericUpDown.Name = "uxYearNumericUpDown";
            this.uxYearNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.uxYearNumericUpDown.TabIndex = 7;
            this.uxYearNumericUpDown.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // uxMonthNumericUpDown
            // 
            this.uxMonthNumericUpDown.Location = new System.Drawing.Point(56, 119);
            this.uxMonthNumericUpDown.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.uxMonthNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxMonthNumericUpDown.Name = "uxMonthNumericUpDown";
            this.uxMonthNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.uxMonthNumericUpDown.TabIndex = 8;
            this.uxMonthNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // uxDayNumericUpDown
            // 
            this.uxDayNumericUpDown.Location = new System.Drawing.Point(56, 145);
            this.uxDayNumericUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.uxDayNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxDayNumericUpDown.Name = "uxDayNumericUpDown";
            this.uxDayNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.uxDayNumericUpDown.TabIndex = 9;
            this.uxDayNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // uxHourNumericUpDown
            // 
            this.uxHourNumericUpDown.Location = new System.Drawing.Point(56, 171);
            this.uxHourNumericUpDown.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.uxHourNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxHourNumericUpDown.Name = "uxHourNumericUpDown";
            this.uxHourNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.uxHourNumericUpDown.TabIndex = 10;
            this.uxHourNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // uxPetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 330);
            this.Controls.Add(this.uxInstructionLabel);
            this.Controls.Add(this.uxPetListBox);
            this.Controls.Add(this.uxPetContainer);
            this.Controls.Add(this.uxAddPetButton);
            this.Name = "uxPetForm";
            this.Text = "Owner\'s Pets";
            this.uxPetContainer.ResumeLayout(false);
            this.uxPetContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxYearNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxMonthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxDayNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxHourNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxInstructionLabel;
        private System.Windows.Forms.ListBox uxPetListBox;
        private System.Windows.Forms.GroupBox uxPetContainer;
        private System.Windows.Forms.Button uxAddButton;
        private System.Windows.Forms.Label uxHourLabel;
        private System.Windows.Forms.Label uxDayLabel;
        private System.Windows.Forms.Label uxMonthLabel;
        private System.Windows.Forms.Label uxYearLabel;
        private System.Windows.Forms.Label uxBirthDateLabel;
        private System.Windows.Forms.TextBox uxNameTextBox;
        private System.Windows.Forms.Label uxNameLabel;
        private System.Windows.Forms.TextBox uxBreedTextBox;
        private System.Windows.Forms.Label uxBreedLabel;
        private System.Windows.Forms.Button uxAddPetButton;
        private System.Windows.Forms.NumericUpDown uxHourNumericUpDown;
        private System.Windows.Forms.NumericUpDown uxDayNumericUpDown;
        private System.Windows.Forms.NumericUpDown uxMonthNumericUpDown;
        private System.Windows.Forms.NumericUpDown uxYearNumericUpDown;
    }
}