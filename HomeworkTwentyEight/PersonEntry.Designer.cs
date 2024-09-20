
namespace HomeworkTwentyEight
{
    partial class PersonEntry
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.isActive = new System.Windows.Forms.CheckBox();
            this.isActiveLabel = new System.Windows.Forms.Label();
            this.addressesList = new System.Windows.Forms.ListBox();
            this.addressesLabel = new System.Windows.Forms.Label();
            this.addAddressButton = new System.Windows.Forms.Button();
            this.saveRecordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(52, 49);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(193, 40);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(251, 46);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(466, 48);
            this.firstNameText.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(52, 125);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(191, 40);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last Name";
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(251, 122);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(466, 48);
            this.lastNameText.TabIndex = 1;
            // 
            // isActive
            // 
            this.isActive.AutoSize = true;
            this.isActive.Location = new System.Drawing.Point(251, 204);
            this.isActive.Name = "isActive";
            this.isActive.Size = new System.Drawing.Size(22, 21);
            this.isActive.TabIndex = 2;
            this.isActive.UseVisualStyleBackColor = true;
            // 
            // isActiveLabel
            // 
            this.isActiveLabel.AutoSize = true;
            this.isActiveLabel.Location = new System.Drawing.Point(52, 193);
            this.isActiveLabel.Name = "isActiveLabel";
            this.isActiveLabel.Size = new System.Drawing.Size(115, 40);
            this.isActiveLabel.TabIndex = 0;
            this.isActiveLabel.Text = "Active";
            // 
            // addressesList
            // 
            this.addressesList.FormattingEnabled = true;
            this.addressesList.ItemHeight = 40;
            this.addressesList.Location = new System.Drawing.Point(59, 335);
            this.addressesList.Name = "addressesList";
            this.addressesList.Size = new System.Drawing.Size(658, 284);
            this.addressesList.TabIndex = 3;
            // 
            // addressesLabel
            // 
            this.addressesLabel.AutoSize = true;
            this.addressesLabel.Location = new System.Drawing.Point(52, 280);
            this.addressesLabel.Name = "addressesLabel";
            this.addressesLabel.Size = new System.Drawing.Size(167, 40);
            this.addressesLabel.TabIndex = 0;
            this.addressesLabel.Text = "Adresses";
            // 
            // addAddressButton
            // 
            this.addAddressButton.Location = new System.Drawing.Point(557, 267);
            this.addAddressButton.Name = "addAddressButton";
            this.addAddressButton.Size = new System.Drawing.Size(160, 53);
            this.addAddressButton.TabIndex = 4;
            this.addAddressButton.Text = "Add";
            this.addAddressButton.UseVisualStyleBackColor = true;
            // 
            // saveRecordButton
            // 
            this.saveRecordButton.Location = new System.Drawing.Point(285, 642);
            this.saveRecordButton.Name = "saveRecordButton";
            this.saveRecordButton.Size = new System.Drawing.Size(160, 53);
            this.saveRecordButton.TabIndex = 4;
            this.saveRecordButton.Text = "Save";
            this.saveRecordButton.UseVisualStyleBackColor = true;
            // 
            // PersonEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 716);
            this.Controls.Add(this.saveRecordButton);
            this.Controls.Add(this.addAddressButton);
            this.Controls.Add(this.addressesList);
            this.Controls.Add(this.isActive);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.addressesLabel);
            this.Controls.Add(this.isActiveLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "PersonEntry";
            this.Text = "Person Entry Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.CheckBox isActive;
        private System.Windows.Forms.Label isActiveLabel;
        private System.Windows.Forms.ListBox addressesList;
        private System.Windows.Forms.Label addressesLabel;
        private System.Windows.Forms.Button addAddressButton;
        private System.Windows.Forms.Button saveRecordButton;
    }
}

