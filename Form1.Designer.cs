namespace MGO2_File_Swap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainPathString = new System.Windows.Forms.TextBox();
            this.backupPathString = new System.Windows.Forms.TextBox();
            this.moddedPathString = new System.Windows.Forms.TextBox();
            this.changeToModded = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.changeToBackup = new System.Windows.Forms.Button();
            this.browseMainPath = new System.Windows.Forms.Button();
            this.browseModdedPath = new System.Windows.Forms.Button();
            this.browseBackupPath = new System.Windows.Forms.Button();
            this.mainPathTitle = new System.Windows.Forms.Label();
            this.moddedPathTitle = new System.Windows.Forms.Label();
            this.backupPathTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainPathString
            // 
            this.mainPathString.Location = new System.Drawing.Point(12, 95);
            this.mainPathString.Name = "mainPathString";
            this.mainPathString.ReadOnly = true;
            this.mainPathString.Size = new System.Drawing.Size(316, 23);
            this.mainPathString.TabIndex = 3;
            // 
            // backupPathString
            // 
            this.backupPathString.Location = new System.Drawing.Point(419, 447);
            this.backupPathString.Name = "backupPathString";
            this.backupPathString.ReadOnly = true;
            this.backupPathString.Size = new System.Drawing.Size(316, 23);
            this.backupPathString.TabIndex = 4;
            // 
            // moddedPathString
            // 
            this.moddedPathString.Location = new System.Drawing.Point(12, 447);
            this.moddedPathString.Name = "moddedPathString";
            this.moddedPathString.ReadOnly = true;
            this.moddedPathString.Size = new System.Drawing.Size(316, 23);
            this.moddedPathString.TabIndex = 5;
            // 
            // changeToModded
            // 
            this.changeToModded.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeToModded.Location = new System.Drawing.Point(454, 12);
            this.changeToModded.Name = "changeToModded";
            this.changeToModded.Size = new System.Drawing.Size(146, 61);
            this.changeToModded.TabIndex = 6;
            this.changeToModded.Text = "Change Main to Modded";
            this.changeToModded.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(661, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(146, 61);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadButton.Location = new System.Drawing.Point(661, 95);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(146, 61);
            this.loadButton.TabIndex = 8;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            // 
            // changeToBackup
            // 
            this.changeToBackup.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeToBackup.Location = new System.Drawing.Point(454, 95);
            this.changeToBackup.Name = "changeToBackup";
            this.changeToBackup.Size = new System.Drawing.Size(146, 61);
            this.changeToBackup.TabIndex = 9;
            this.changeToBackup.Text = "Change Main to Backup";
            this.changeToBackup.UseVisualStyleBackColor = true;
            // 
            // browseMainPath
            // 
            this.browseMainPath.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.browseMainPath.Location = new System.Drawing.Point(334, 95);
            this.browseMainPath.Name = "browseMainPath";
            this.browseMainPath.Size = new System.Drawing.Size(60, 23);
            this.browseMainPath.TabIndex = 10;
            this.browseMainPath.Text = "Browse";
            this.browseMainPath.UseVisualStyleBackColor = true;
            // 
            // browseModdedPath
            // 
            this.browseModdedPath.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.browseModdedPath.Location = new System.Drawing.Point(334, 445);
            this.browseModdedPath.Name = "browseModdedPath";
            this.browseModdedPath.Size = new System.Drawing.Size(60, 23);
            this.browseModdedPath.TabIndex = 11;
            this.browseModdedPath.Text = "Browse";
            this.browseModdedPath.UseVisualStyleBackColor = true;
            // 
            // browseBackupPath
            // 
            this.browseBackupPath.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.browseBackupPath.Location = new System.Drawing.Point(741, 447);
            this.browseBackupPath.Name = "browseBackupPath";
            this.browseBackupPath.Size = new System.Drawing.Size(60, 23);
            this.browseBackupPath.TabIndex = 12;
            this.browseBackupPath.Text = "Browse";
            this.browseBackupPath.UseVisualStyleBackColor = true;
            // 
            // mainPathTitle
            // 
            this.mainPathTitle.AutoSize = true;
            this.mainPathTitle.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.mainPathTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.mainPathTitle.Location = new System.Drawing.Point(91, 47);
            this.mainPathTitle.Name = "mainPathTitle";
            this.mainPathTitle.Size = new System.Drawing.Size(183, 26);
            this.mainPathTitle.TabIndex = 13;
            this.mainPathTitle.Text = "Main File Path MGO2";
            // 
            // moddedPathTitle
            // 
            this.moddedPathTitle.AutoSize = true;
            this.moddedPathTitle.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.moddedPathTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.moddedPathTitle.Location = new System.Drawing.Point(91, 399);
            this.moddedPathTitle.Name = "moddedPathTitle";
            this.moddedPathTitle.Size = new System.Drawing.Size(211, 26);
            this.moddedPathTitle.TabIndex = 14;
            this.moddedPathTitle.Text = "Modded File Path MGO2";
            // 
            // backupPathTitle
            // 
            this.backupPathTitle.AutoSize = true;
            this.backupPathTitle.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.backupPathTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.backupPathTitle.Location = new System.Drawing.Point(483, 399);
            this.backupPathTitle.Name = "backupPathTitle";
            this.backupPathTitle.Size = new System.Drawing.Size(206, 26);
            this.backupPathTitle.TabIndex = 15;
            this.backupPathTitle.Text = "Backup File Path MGO2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(819, 517);
            this.Controls.Add(this.backupPathTitle);
            this.Controls.Add(this.moddedPathTitle);
            this.Controls.Add(this.mainPathTitle);
            this.Controls.Add(this.browseBackupPath);
            this.Controls.Add(this.browseModdedPath);
            this.Controls.Add(this.browseMainPath);
            this.Controls.Add(this.changeToBackup);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.changeToModded);
            this.Controls.Add(this.moddedPathString);
            this.Controls.Add(this.backupPathString);
            this.Controls.Add(this.mainPathString);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "ANTIBigBoss\' MGO2 File Swapper"; // This is the title of the program
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox mainPathString;// This shows file path of Main directory
        private TextBox backupPathString;// This shows file path of Modded directory
        private TextBox moddedPathString;// This shows file path of Backup directory
        private Button changeToModded; // This buttton will let you change the files in the main directory to the files in the modded directory
        private Button saveButton; // This Button will let you save your settings in a txt file
        private Button loadButton; // This Button will let you load your settings from a txt file
        private Button changeToBackup; // This Button will let you change the files in the main directory to the files in the backup directory
        private Button browseMainPath; // This Button will let you browse for the main directory
        private Button browseModdedPath; // This Button will let you browse for the modded directory
        private Button browseBackupPath; // This Button will let you browse for the backup directory
        private Label mainPathTitle; // This title will show up above the mainPathString
        private Label moddedPathTitle; // This title will show up above the moddedPathString
        private Label backupPathTitle; // This title will show up above the backupPathString
    }
}