namespace PersonalInformationApp
{
    partial class Form1
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
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.fathersNameTextBox = new System.Windows.Forms.TextBox();
            this.mothersNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLebel = new System.Windows.Forms.Label();
            this.lastNameLebel = new System.Windows.Forms.Label();
            this.fathersNameLebel = new System.Windows.Forms.Label();
            this.mothersNameLebel = new System.Windows.Forms.Label();
            this.addressLebel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.showInfoButton = new System.Windows.Forms.Button();
            this.nameButton = new System.Windows.Forms.Button();
            this.parrentButton = new System.Windows.Forms.Button();
            this.addressButton = new System.Windows.Forms.Button();
            this.personalInfoLebel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(167, 39);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(167, 66);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // fathersNameTextBox
            // 
            this.fathersNameTextBox.Location = new System.Drawing.Point(167, 93);
            this.fathersNameTextBox.Name = "fathersNameTextBox";
            this.fathersNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.fathersNameTextBox.TabIndex = 2;
            // 
            // mothersNameTextBox
            // 
            this.mothersNameTextBox.Location = new System.Drawing.Point(167, 120);
            this.mothersNameTextBox.Name = "mothersNameTextBox";
            this.mothersNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.mothersNameTextBox.TabIndex = 3;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(167, 147);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 4;
            // 
            // firstNameLebel
            // 
            this.firstNameLebel.AutoSize = true;
            this.firstNameLebel.Location = new System.Drawing.Point(77, 39);
            this.firstNameLebel.Name = "firstNameLebel";
            this.firstNameLebel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLebel.TabIndex = 5;
            this.firstNameLebel.Text = "First Name";
            // 
            // lastNameLebel
            // 
            this.lastNameLebel.AutoSize = true;
            this.lastNameLebel.Location = new System.Drawing.Point(77, 66);
            this.lastNameLebel.Name = "lastNameLebel";
            this.lastNameLebel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLebel.TabIndex = 6;
            this.lastNameLebel.Text = "Last Name";
            // 
            // fathersNameLebel
            // 
            this.fathersNameLebel.AutoSize = true;
            this.fathersNameLebel.Location = new System.Drawing.Point(77, 93);
            this.fathersNameLebel.Name = "fathersNameLebel";
            this.fathersNameLebel.Size = new System.Drawing.Size(75, 13);
            this.fathersNameLebel.TabIndex = 7;
            this.fathersNameLebel.Text = "Father\'s Name";
            // 
            // mothersNameLebel
            // 
            this.mothersNameLebel.AutoSize = true;
            this.mothersNameLebel.Location = new System.Drawing.Point(77, 120);
            this.mothersNameLebel.Name = "mothersNameLebel";
            this.mothersNameLebel.Size = new System.Drawing.Size(78, 13);
            this.mothersNameLebel.TabIndex = 8;
            this.mothersNameLebel.Text = "Mother\'s Name";
            // 
            // addressLebel
            // 
            this.addressLebel.AutoSize = true;
            this.addressLebel.Location = new System.Drawing.Point(77, 147);
            this.addressLebel.Name = "addressLebel";
            this.addressLebel.Size = new System.Drawing.Size(45, 13);
            this.addressLebel.TabIndex = 9;
            this.addressLebel.Text = "Address";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(77, 201);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // showInfoButton
            // 
            this.showInfoButton.Location = new System.Drawing.Point(167, 201);
            this.showInfoButton.Name = "showInfoButton";
            this.showInfoButton.Size = new System.Drawing.Size(148, 23);
            this.showInfoButton.TabIndex = 11;
            this.showInfoButton.Text = "Show All Information";
            this.showInfoButton.UseVisualStyleBackColor = true;
            this.showInfoButton.Click += new System.EventHandler(this.showInfoButton_Click);
            // 
            // nameButton
            // 
            this.nameButton.Location = new System.Drawing.Point(47, 249);
            this.nameButton.Name = "nameButton";
            this.nameButton.Size = new System.Drawing.Size(75, 23);
            this.nameButton.TabIndex = 12;
            this.nameButton.Text = "Name";
            this.nameButton.UseVisualStyleBackColor = true;
            this.nameButton.Click += new System.EventHandler(this.nameButton_Click);
            // 
            // parrentButton
            // 
            this.parrentButton.Location = new System.Drawing.Point(149, 249);
            this.parrentButton.Name = "parrentButton";
            this.parrentButton.Size = new System.Drawing.Size(92, 23);
            this.parrentButton.TabIndex = 13;
            this.parrentButton.Text = "Parrent\'s Name";
            this.parrentButton.UseVisualStyleBackColor = true;
            this.parrentButton.Click += new System.EventHandler(this.parrentButton_Click);
            // 
            // addressButton
            // 
            this.addressButton.Location = new System.Drawing.Point(271, 249);
            this.addressButton.Name = "addressButton";
            this.addressButton.Size = new System.Drawing.Size(75, 23);
            this.addressButton.TabIndex = 14;
            this.addressButton.Text = "Address";
            this.addressButton.UseVisualStyleBackColor = true;
            this.addressButton.Click += new System.EventHandler(this.addressButton_Click);
            // 
            // personalInfoLebel
            // 
            this.personalInfoLebel.AutoSize = true;
            this.personalInfoLebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.personalInfoLebel.Location = new System.Drawing.Point(99, 3);
            this.personalInfoLebel.Name = "personalInfoLebel";
            this.personalInfoLebel.Size = new System.Drawing.Size(163, 20);
            this.personalInfoLebel.TabIndex = 15;
            this.personalInfoLebel.Text = "Personal Information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 303);
            this.Controls.Add(this.personalInfoLebel);
            this.Controls.Add(this.addressButton);
            this.Controls.Add(this.parrentButton);
            this.Controls.Add(this.nameButton);
            this.Controls.Add(this.showInfoButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addressLebel);
            this.Controls.Add(this.mothersNameLebel);
            this.Controls.Add(this.fathersNameLebel);
            this.Controls.Add(this.lastNameLebel);
            this.Controls.Add(this.firstNameLebel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.mothersNameTextBox);
            this.Controls.Add(this.fathersNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Name = "Form1";
            this.Text = "Personal Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox fathersNameTextBox;
        private System.Windows.Forms.TextBox mothersNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label firstNameLebel;
        private System.Windows.Forms.Label lastNameLebel;
        private System.Windows.Forms.Label fathersNameLebel;
        private System.Windows.Forms.Label mothersNameLebel;
        private System.Windows.Forms.Label addressLebel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button showInfoButton;
        private System.Windows.Forms.Button nameButton;
        private System.Windows.Forms.Button parrentButton;
        private System.Windows.Forms.Button addressButton;
        private System.Windows.Forms.Label personalInfoLebel;
    }
}

