namespace SharanPranav_Assignment2_BAP
{
    partial class Welcome_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome_Form));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BottleCheckBox = new System.Windows.Forms.CheckBox();
            this.HaloFitnessPictureBox = new System.Windows.Forms.PictureBox();
            this.SessionsListBox = new System.Windows.Forms.ListBox();
            this.ProgramsListBox = new System.Windows.Forms.ListBox();
            this.OptionalUpgradesPanel = new System.Windows.Forms.Panel();
            this.NoUpgradesRadioButton = new System.Windows.Forms.RadioButton();
            this.MediumGroupRadioButton = new System.Windows.Forms.RadioButton();
            this.SmallGroupRadioButton = new System.Windows.Forms.RadioButton();
            this.OnetoOneGroupRadioButton = new System.Windows.Forms.RadioButton();
            this.NumberOfParticipantsTextBox = new System.Windows.Forms.TextBox();
            this.OptionalUpgradesLabel = new System.Windows.Forms.Label();
            this.NumberOfParticipantsLabel = new System.Windows.Forms.Label();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.NoOfSessionLabel = new System.Windows.Forms.Label();
            this.PricePerSessionLabel = new System.Windows.Forms.Label();
            this.ProgramsLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.BookButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.OutputGroupBox = new System.Windows.Forms.GroupBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.DisplayToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BookToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SummaryToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ClearToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ExitToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HaloFitnessPictureBox)).BeginInit();
            this.OptionalUpgradesPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.OutputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.ErrorLabel);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Controls.Add(this.HaloFitnessPictureBox);
            this.MainPanel.Controls.Add(this.SessionsListBox);
            this.MainPanel.Controls.Add(this.ProgramsListBox);
            this.MainPanel.Controls.Add(this.OptionalUpgradesPanel);
            this.MainPanel.Controls.Add(this.NumberOfParticipantsTextBox);
            this.MainPanel.Controls.Add(this.OptionalUpgradesLabel);
            this.MainPanel.Controls.Add(this.NumberOfParticipantsLabel);
            this.MainPanel.Controls.Add(this.DiscountLabel);
            this.MainPanel.Controls.Add(this.NoOfSessionLabel);
            this.MainPanel.Controls.Add(this.PricePerSessionLabel);
            this.MainPanel.Controls.Add(this.ProgramsLabel);
            this.MainPanel.Location = new System.Drawing.Point(12, 44);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1337, 326);
            this.MainPanel.TabIndex = 0;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(806, 102);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 16);
            this.ErrorLabel.TabIndex = 13;
            this.ErrorLabel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BottleCheckBox);
            this.panel2.Location = new System.Drawing.Point(1048, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 40);
            this.panel2.TabIndex = 12;
            // 
            // BottleCheckBox
            // 
            this.BottleCheckBox.AutoSize = true;
            this.BottleCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottleCheckBox.Location = new System.Drawing.Point(17, 6);
            this.BottleCheckBox.Name = "BottleCheckBox";
            this.BottleCheckBox.Size = new System.Drawing.Size(177, 24);
            this.BottleCheckBox.TabIndex = 11;
            this.BottleCheckBox.Text = "Personalised Bottle";
            this.BottleCheckBox.UseVisualStyleBackColor = true;
            this.BottleCheckBox.CheckedChanged += new System.EventHandler(this.BottleCheckBox_CheckedChanged);
            // 
            // HaloFitnessPictureBox
            // 
            this.HaloFitnessPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HaloFitnessPictureBox.ErrorImage = null;
            this.HaloFitnessPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("HaloFitnessPictureBox.Image")));
            this.HaloFitnessPictureBox.InitialImage = null;
            this.HaloFitnessPictureBox.Location = new System.Drawing.Point(834, 123);
            this.HaloFitnessPictureBox.Name = "HaloFitnessPictureBox";
            this.HaloFitnessPictureBox.Size = new System.Drawing.Size(188, 123);
            this.HaloFitnessPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HaloFitnessPictureBox.TabIndex = 10;
            this.HaloFitnessPictureBox.TabStop = false;
            // 
            // SessionsListBox
            // 
            this.SessionsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionsListBox.FormattingEnabled = true;
            this.SessionsListBox.ItemHeight = 20;
            this.SessionsListBox.Items.AddRange(new object[] {
            "1\t\t\t     0%",
            "3\t\t\t     5%",
            "5\t\t\t     10%",
            "7\t\t\t     15%",
            "10\t\t\t     20%",
            "12\t\t\t     30%"});
            this.SessionsListBox.Location = new System.Drawing.Point(451, 71);
            this.SessionsListBox.Name = "SessionsListBox";
            this.SessionsListBox.Size = new System.Drawing.Size(343, 144);
            this.SessionsListBox.TabIndex = 9;
            this.SessionsListBox.SelectedIndexChanged += new System.EventHandler(this.SessionsListBox_SelectedIndexChanged);
            // 
            // ProgramsListBox
            // 
            this.ProgramsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramsListBox.FormattingEnabled = true;
            this.ProgramsListBox.ItemHeight = 20;
            this.ProgramsListBox.Items.AddRange(new object[] {
            "Circuit Training\t\t\t€25",
            "Pilates\t\t\t\t€40",
            "High-Intensity Interval Training  \t€25",
            "Aerobics\t\t\t\t€25",
            "Fitness Boot Camp\t\t\t€20",
            "Weigh Training\t\t\t€25",
            "Agility\t\t\t                €50",
            "Yoga\t\t\t\t€35",
            "Speed Training\t\t                €45"});
            this.ProgramsListBox.Location = new System.Drawing.Point(15, 71);
            this.ProgramsListBox.Name = "ProgramsListBox";
            this.ProgramsListBox.Size = new System.Drawing.Size(406, 204);
            this.ProgramsListBox.TabIndex = 8;
            this.ProgramsListBox.SelectedIndexChanged += new System.EventHandler(this.ProgramsListBox_SelectedIndexChanged);
            // 
            // OptionalUpgradesPanel
            // 
            this.OptionalUpgradesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OptionalUpgradesPanel.Controls.Add(this.NoUpgradesRadioButton);
            this.OptionalUpgradesPanel.Controls.Add(this.MediumGroupRadioButton);
            this.OptionalUpgradesPanel.Controls.Add(this.SmallGroupRadioButton);
            this.OptionalUpgradesPanel.Controls.Add(this.OnetoOneGroupRadioButton);
            this.OptionalUpgradesPanel.Location = new System.Drawing.Point(1048, 71);
            this.OptionalUpgradesPanel.Name = "OptionalUpgradesPanel";
            this.OptionalUpgradesPanel.Size = new System.Drawing.Size(270, 175);
            this.OptionalUpgradesPanel.TabIndex = 7;
            // 
            // NoUpgradesRadioButton
            // 
            this.NoUpgradesRadioButton.AutoSize = true;
            this.NoUpgradesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoUpgradesRadioButton.Location = new System.Drawing.Point(18, 137);
            this.NoUpgradesRadioButton.Name = "NoUpgradesRadioButton";
            this.NoUpgradesRadioButton.Size = new System.Drawing.Size(128, 24);
            this.NoUpgradesRadioButton.TabIndex = 3;
            this.NoUpgradesRadioButton.TabStop = true;
            this.NoUpgradesRadioButton.Text = "No Upgrades";
            this.NoUpgradesRadioButton.UseVisualStyleBackColor = true;
            this.NoUpgradesRadioButton.Visible = false;
            this.NoUpgradesRadioButton.CheckedChanged += new System.EventHandler(this.NoUpgradesRadioButton_CheckedChanged);
            // 
            // MediumGroupRadioButton
            // 
            this.MediumGroupRadioButton.AutoSize = true;
            this.MediumGroupRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediumGroupRadioButton.Location = new System.Drawing.Point(18, 97);
            this.MediumGroupRadioButton.Name = "MediumGroupRadioButton";
            this.MediumGroupRadioButton.Size = new System.Drawing.Size(205, 24);
            this.MediumGroupRadioButton.TabIndex = 2;
            this.MediumGroupRadioButton.TabStop = true;
            this.MediumGroupRadioButton.Text = "Medium Group Training";
            this.MediumGroupRadioButton.UseVisualStyleBackColor = true;
            this.MediumGroupRadioButton.CheckedChanged += new System.EventHandler(this.MediumGroupRadioButton_CheckedChanged);
            // 
            // SmallGroupRadioButton
            // 
            this.SmallGroupRadioButton.AutoSize = true;
            this.SmallGroupRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmallGroupRadioButton.Location = new System.Drawing.Point(18, 55);
            this.SmallGroupRadioButton.Name = "SmallGroupRadioButton";
            this.SmallGroupRadioButton.Size = new System.Drawing.Size(188, 24);
            this.SmallGroupRadioButton.TabIndex = 1;
            this.SmallGroupRadioButton.TabStop = true;
            this.SmallGroupRadioButton.Text = "Small Group Training";
            this.SmallGroupRadioButton.UseVisualStyleBackColor = true;
            this.SmallGroupRadioButton.CheckedChanged += new System.EventHandler(this.SmallGroupRadioButton_CheckedChanged);
            // 
            // OnetoOneGroupRadioButton
            // 
            this.OnetoOneGroupRadioButton.AutoSize = true;
            this.OnetoOneGroupRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnetoOneGroupRadioButton.Location = new System.Drawing.Point(18, 12);
            this.OnetoOneGroupRadioButton.Name = "OnetoOneGroupRadioButton";
            this.OnetoOneGroupRadioButton.Size = new System.Drawing.Size(181, 24);
            this.OnetoOneGroupRadioButton.TabIndex = 0;
            this.OnetoOneGroupRadioButton.TabStop = true;
            this.OnetoOneGroupRadioButton.Text = "One to One Training";
            this.OnetoOneGroupRadioButton.UseVisualStyleBackColor = true;
            this.OnetoOneGroupRadioButton.CheckedChanged += new System.EventHandler(this.OnetoOneGroupRadioButton_CheckedChanged);
            // 
            // NumberOfParticipantsTextBox
            // 
            this.NumberOfParticipantsTextBox.Location = new System.Drawing.Point(858, 71);
            this.NumberOfParticipantsTextBox.Name = "NumberOfParticipantsTextBox";
            this.NumberOfParticipantsTextBox.Size = new System.Drawing.Size(143, 22);
            this.NumberOfParticipantsTextBox.TabIndex = 6;
            this.NumberOfParticipantsTextBox.TextChanged += new System.EventHandler(this.NumberOfParticipantsTextBox_TextChanged);
            // 
            // OptionalUpgradesLabel
            // 
            this.OptionalUpgradesLabel.AutoSize = true;
            this.OptionalUpgradesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionalUpgradesLabel.Location = new System.Drawing.Point(1079, 28);
            this.OptionalUpgradesLabel.Name = "OptionalUpgradesLabel";
            this.OptionalUpgradesLabel.Size = new System.Drawing.Size(165, 20);
            this.OptionalUpgradesLabel.TabIndex = 5;
            this.OptionalUpgradesLabel.Text = "Optional Upgrades";
            // 
            // NumberOfParticipantsLabel
            // 
            this.NumberOfParticipantsLabel.AutoSize = true;
            this.NumberOfParticipantsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfParticipantsLabel.Location = new System.Drawing.Point(830, 28);
            this.NumberOfParticipantsLabel.Name = "NumberOfParticipantsLabel";
            this.NumberOfParticipantsLabel.Size = new System.Drawing.Size(203, 20);
            this.NumberOfParticipantsLabel.TabIndex = 4;
            this.NumberOfParticipantsLabel.Text = "Number of Participants";
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.AutoSize = true;
            this.DiscountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountLabel.Location = new System.Drawing.Point(646, 28);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(148, 20);
            this.DiscountLabel.TabIndex = 3;
            this.DiscountLabel.Text = "Bundle Discount";
            // 
            // NoOfSessionLabel
            // 
            this.NoOfSessionLabel.AutoSize = true;
            this.NoOfSessionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoOfSessionLabel.Location = new System.Drawing.Point(447, 18);
            this.NoOfSessionLabel.Name = "NoOfSessionLabel";
            this.NoOfSessionLabel.Size = new System.Drawing.Size(102, 40);
            this.NoOfSessionLabel.TabIndex = 2;
            this.NoOfSessionLabel.Text = "Number of \r\nSessions";
            // 
            // PricePerSessionLabel
            // 
            this.PricePerSessionLabel.AutoSize = true;
            this.PricePerSessionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PricePerSessionLabel.Location = new System.Drawing.Point(327, 18);
            this.PricePerSessionLabel.Name = "PricePerSessionLabel";
            this.PricePerSessionLabel.Size = new System.Drawing.Size(94, 40);
            this.PricePerSessionLabel.TabIndex = 1;
            this.PricePerSessionLabel.Text = "Price Per \r\nSession";
            // 
            // ProgramsLabel
            // 
            this.ProgramsLabel.AutoSize = true;
            this.ProgramsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramsLabel.Location = new System.Drawing.Point(11, 18);
            this.ProgramsLabel.Name = "ProgramsLabel";
            this.ProgramsLabel.Size = new System.Drawing.Size(90, 20);
            this.ProgramsLabel.TabIndex = 0;
            this.ProgramsLabel.Text = "Programs";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.SummaryButton);
            this.panel1.Controls.Add(this.BookButton);
            this.panel1.Controls.Add(this.DisplayButton);
            this.panel1.Location = new System.Drawing.Point(1061, 389);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 311);
            this.panel1.TabIndex = 1;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Teal;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(78, 254);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(108, 34);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "&Exit";
            this.ExitToolTip.SetToolTip(this.ExitButton, "Click to Exit the Form");
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Teal;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(78, 199);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(108, 34);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "&Clear";
            this.ClearToolTip.SetToolTip(this.ClearButton, "Click to Clear the Form");
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SummaryButton
            // 
            this.SummaryButton.BackColor = System.Drawing.Color.Teal;
            this.SummaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryButton.Location = new System.Drawing.Point(78, 139);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(108, 34);
            this.SummaryButton.TabIndex = 2;
            this.SummaryButton.Text = "&Summary";
            this.SummaryToolTip.SetToolTip(this.SummaryButton, "Click to Display the Company Summary Details");
            this.SummaryButton.UseVisualStyleBackColor = false;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // BookButton
            // 
            this.BookButton.BackColor = System.Drawing.Color.Teal;
            this.BookButton.Enabled = false;
            this.BookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookButton.Location = new System.Drawing.Point(78, 80);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(108, 34);
            this.BookButton.TabIndex = 1;
            this.BookButton.Text = "&Book";
            this.BookToolTip.SetToolTip(this.BookButton, "Click to Confirm your Booking");
            this.BookButton.UseVisualStyleBackColor = false;
            this.BookButton.Click += new System.EventHandler(this.BookButton_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.BackColor = System.Drawing.Color.Teal;
            this.DisplayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayButton.Location = new System.Drawing.Point(78, 19);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(108, 34);
            this.DisplayButton.TabIndex = 0;
            this.DisplayButton.Text = "&Display";
            this.DisplayToolTip.SetToolTip(this.DisplayButton, "Click to Display the Booking Summary Details");
            this.DisplayButton.UseVisualStyleBackColor = false;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // OutputGroupBox
            // 
            this.OutputGroupBox.Controls.Add(this.OutputLabel);
            this.OutputGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputGroupBox.Location = new System.Drawing.Point(42, 404);
            this.OutputGroupBox.Name = "OutputGroupBox";
            this.OutputGroupBox.Size = new System.Drawing.Size(993, 274);
            this.OutputGroupBox.TabIndex = 2;
            this.OutputGroupBox.TabStop = false;
            this.OutputGroupBox.Text = "Booking Summary";
            this.OutputGroupBox.Visible = false;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(27, 44);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(0, 20);
            this.OutputLabel.TabIndex = 0;
            // 
            // DisplayToolTip
            // 
            this.DisplayToolTip.IsBalloon = true;
            this.DisplayToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.DisplayToolTip.ToolTipTitle = "Info";
            // 
            // BookToolTip
            // 
            this.BookToolTip.IsBalloon = true;
            this.BookToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.BookToolTip.ToolTipTitle = "Info";
            // 
            // SummaryToolTip
            // 
            this.SummaryToolTip.IsBalloon = true;
            this.SummaryToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.SummaryToolTip.ToolTipTitle = "Info";
            // 
            // ClearToolTip
            // 
            this.ClearToolTip.IsBalloon = true;
            this.ClearToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ClearToolTip.ToolTipTitle = "Info";
            // 
            // ExitToolTip
            // 
            this.ExitToolTip.IsBalloon = true;
            this.ExitToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ExitToolTip.ToolTipTitle = "Info";
            // 
            // Welcome_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 725);
            this.Controls.Add(this.OutputGroupBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Welcome_Form";
            this.Text = "Welcome to Halo Fitness";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HaloFitnessPictureBox)).EndInit();
            this.OptionalUpgradesPanel.ResumeLayout(false);
            this.OptionalUpgradesPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.OutputGroupBox.ResumeLayout(false);
            this.OutputGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label PricePerSessionLabel;
        private System.Windows.Forms.Label ProgramsLabel;
        private System.Windows.Forms.Label NoOfSessionLabel;
        private System.Windows.Forms.Label DiscountLabel;
        private System.Windows.Forms.Label OptionalUpgradesLabel;
        private System.Windows.Forms.Label NumberOfParticipantsLabel;
        private System.Windows.Forms.TextBox NumberOfParticipantsTextBox;
        private System.Windows.Forms.ListBox SessionsListBox;
        private System.Windows.Forms.ListBox ProgramsListBox;
        private System.Windows.Forms.Panel OptionalUpgradesPanel;
        private System.Windows.Forms.RadioButton MediumGroupRadioButton;
        private System.Windows.Forms.RadioButton SmallGroupRadioButton;
        private System.Windows.Forms.RadioButton OnetoOneGroupRadioButton;
        private System.Windows.Forms.PictureBox HaloFitnessPictureBox;
        private System.Windows.Forms.CheckBox BottleCheckBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SummaryButton;
        private System.Windows.Forms.Button BookButton;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton NoUpgradesRadioButton;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.GroupBox OutputGroupBox;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.ToolTip DisplayToolTip;
        private System.Windows.Forms.ToolTip BookToolTip;
        private System.Windows.Forms.ToolTip SummaryToolTip;
        private System.Windows.Forms.ToolTip ClearToolTip;
        private System.Windows.Forms.ToolTip ExitToolTip;
    }
}

