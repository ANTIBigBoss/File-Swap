using System; // Importing the System namespace for basic functionality
using System.IO; // Importing the System.IO namespace for input/output related functionality
using System.Windows.Forms; // Importing the System.Windows.Forms namespace for GUI (Windows Form) related functionality

namespace MGO2_File_Swap // Namespace for the program
{
    public partial class Form1 : Form // Declaring the main form class, which inherits from the Form class
    {
        public Form1() // Constructor for the Form1 class
        {
            InitializeComponent();

            // Add event handlers for the buttons here
            changeToModded.Click += ChangeToModded_Click; // Assigns the ChangeToModded_Click method to the changeToModded button's Click event
            saveButton.Click += SaveButton_Click; // Assigns the SaveButton_Click method to the saveButton's Click event
            loadButton.Click += LoadButton_Click; // Assigns the LoadButton_Click method to the loadButton's Click event
            changeToBackup.Click += ChangeToBackup_Click; // Assigns the ChangeToBackup_Click method to the changeToBackup button's Click event
            browseMainPath.Click += BrowseMainPath_Click; // Assigns the BrowseMainPath_Click method to the browseMainPath button's Click event
            browseModdedPath.Click += BrowseModdedPath_Click; // Assigns the BrowseModdedPath_Click method to the browseModdedPath button's Click event
            browseBackupPath.Click += BrowseBackupPath_Click; // Assigns the BrowseBackupPath_Click method to the browseBackupPath button's Click event
        }

        // Add methods to handle button clicks and other events here
        private void ChangeToModded_Click(object sender, EventArgs e) // Method to handle the changeToModded button's Click event
        {
            SwapFiles(mainPathString.Text, moddedPathString.Text, true); // Calls the SwapFiles method with the mainPathString and moddedPathString textboxes' Text properties as the first two parameters, and true as the third parameter
        }

        private void SaveButton_Click(object sender, EventArgs e) // Method to handle the saveButton's Click event
        {
            using (var saveFileDialog = new SaveFileDialog()) // Creates a new SaveFileDialouge for selecting a file to save
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"; // Sets the filter for the SaveFileDialog to only show .txt files and all files
                saveFileDialog.Title = "Save File Paths"; // Sets the title of the SaveFileDialog
                saveFileDialog.FileName = "ANTIFileSwap.txt"; // Sets the default file name of the SaveFileDialog

                if (saveFileDialog.ShowDialog() == DialogResult.OK) // If the user clicks the save button in the SaveFileDialog
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName)) // Creates a new StreamWriter for writing to the file
                    {
                        sw.WriteLine(mainPathString.Text); // Writes the mainPathString textbox's Text property to the file
                        sw.WriteLine(moddedPathString.Text); // Writes the moddedPathString textbox's Text property to the file
                        sw.WriteLine(backupPathString.Text); // Writes the backupPathString textbox's Text property to the file
                    }
                }
            }
        }

        private void LoadButton_Click(object sender, EventArgs e) // The same as saving above but for loading
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.Title = "Load File Paths";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                    {
                        mainPathString.Text = sr.ReadLine();
                        moddedPathString.Text = sr.ReadLine();
                        backupPathString.Text = sr.ReadLine();
                    }
                }
            }
        }

        // Logic for the different buttons in the GUI
        private void ChangeToBackup_Click(object sender, EventArgs e) // Method to handle the changeToBackup button's Click event
        {
            SwapFiles(mainPathString.Text, backupPathString.Text, false); // Calls the SwapFiles method with the mainPathString and backupPathString textboxes' Text properties as the first two parameters, and false as the third parameter
        }

        private void BrowseMainPath_Click(object sender, EventArgs e) // Method to handle the browseMainPath button's Click event
        {
            BrowseForFolder(mainPathString); // Calls the BrowseForFolder method with the mainPathString textbox as the parameter
        }

        private void BrowseModdedPath_Click(object sender, EventArgs e) // The same as above but for the moddedPathString textbox
        {
            BrowseForFolder(moddedPathString); // Calls the BrowseForFolder method with the moddedPathString textbox as the parameter
        }

        private void BrowseBackupPath_Click(object sender, EventArgs e) // The same as above but for the backupPathString textbox
        {
            BrowseForFolder(backupPathString); // Calls the BrowseForFolder method with the backupPathString textbox as the parameter
        }

        private void SwapFiles(string mainPath, string otherPath, bool isModded) // Method to swap the files between the main and other paths
        {
            if (isModded) // If the isModded parameter is true
            {
                ReplaceWithModdedFiles(otherPath, mainPath); // Calls the ReplaceWithModdedFiles method with the otherPath and mainPath parameters
            }
            else // If the isModded parameter isn't true
            {
                ReplaceWithBackupFiles(otherPath, mainPath); // Calls the ReplaceWithBackupFiles method with the otherPath and mainPath parameters
            }
        }

        private void BrowseForFolder(TextBox textBoxToUpdate) // Method to browse for a folder and update the text of a textbox with the path
        {
            using (var folderBrowserDialog = new FolderBrowserDialog()) // Creates a new FolderBrowserDialog for selecting a folder
            {
                DialogResult result = folderBrowserDialog.ShowDialog(); // Shows the FolderBrowserDialog and stores the result in the result variable

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath)) // If the user clicks the OK button and the SelectedPath property isn't null or empty
                {
                    textBoxToUpdate.Text = folderBrowserDialog.SelectedPath; // Sets the textbox's Text property to the SelectedPath property of the FolderBrowserDialog
                }
            }
        }

        // Function to replace the current files with the modded files
        private void ReplaceWithModdedFiles(string source, string destination) // Method to replace the current files with the modded files
        {
            Console.WriteLine("Replacing Current Files with Modded Files"); // Writes to the console
            DirectoryCopy(source, destination, true); // Calls the DirectoryCopy method with the source, destination, and true parameters
            Console.WriteLine("Current Files Replaced with modded ones"); // Writes to the console
        }

        // Function to replace the current files with the backup files
        private void ReplaceWithBackupFiles(string source, string destination) // Method to replace the current files with the backup files
        {
            Console.WriteLine("Replacing Current Files with Backup Files"); // Writes to the console
            DirectoryCopy(source, destination, true); // Calls the DirectoryCopy method with the source, destination, and true parameters
            Console.WriteLine("Current Files Replaced with Backup ones"); // Writes to the console
        }

        // DirectoryCopy method to copy directories with subdirectories and files
        // A method to copy the contents of one directory to another, including subdirectories if specified
        private void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Create a DirectoryInfo object representing the source directory
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            // Check if the source directory exists
            if (!dir.Exists)
            {
                // If the source directory does not exist, throw an exception with an error message
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            // Get an array of DirectoryInfo objects representing the subdirectories of the source directory
            DirectoryInfo[] dirs = dir.GetDirectories();

            // Check if the destination directory exists
            if (!Directory.Exists(destDirName))
            {
                // If the destination directory does not exist, create it
                Directory.CreateDirectory(destDirName);
            }

            // Get an array of FileInfo objects representing the files in the source directory
            FileInfo[] files = dir.GetFiles();
            // Iterate through each file in the source directory
            foreach (FileInfo file in files)
            {
                // Combine the destination directory path with the current file's name
                string tempPath = Path.Combine(destDirName, file.Name);
                // Copy the current file to the destination directory, overwriting if the file already exists
                file.CopyTo(tempPath, true);
            }

            // Check if subdirectories should be copied
            if (copySubDirs)
            {
                // Iterate through each subdirectory in the source directory
                foreach (DirectoryInfo subdir in dirs)
                {
                    // Combine the destination directory path with the current subdirectory's name
                    string tempPath = Path.Combine(destDirName, subdir.Name);
                    // Recursively call the DirectoryCopy method for the current subdirectory
                    DirectoryCopy(subdir.FullName, tempPath, copySubDirs);
                }
            }
        }
    }
}
