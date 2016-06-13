using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;

namespace BeetrootUI
{
    public partial class mainForm : Form
    {

        string source, destination = @"C:\Users\rareshn\Music\br";
        int serverPort;

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            addToOutput("UI initialised.");
        }

        public void addToOutput(string info)
        {
            output_box.AppendText(info + "\n");
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            addToOutput("Showing folder select window.");
            folderSelector.ShowDialog();
            
            if (folderSelector.SelectedPath != "" && folderSelector.SelectedPath != null)
            {
                addToOutput("The folder selector returned " + folderSelector.SelectedPath);
                sortSongs(folderSelector.SelectedPath);
            }
            else
            {
                addToOutput("The folder selector returned nothing.");
            }
        }

        public void sortSongs(string folder)
        {

            addToOutput("Importing songs...");
            string[] fileArray = Directory.GetFiles(folder, "*.mp3", SearchOption.AllDirectories);

            foreach (string file in fileArray)
            {

                // Try and catch errors (to prevent stuff-ups)
                try
                {

                    //addToOutput("Selected song: " + file);

                    // Load song file into taglib
                    //addToOutput("Reading song metadata...");
                    TagLib.File songFile = TagLib.File.Create(file);

                    // Check if a composer tag exists
                    if (songFile.Tag.Performers != null)
                    {

                        // If a directory is not existent create it
                        if (!Directory.Exists(Path.Combine(destination, songFile.Tag.Performers[0])))
                        {
                            Directory.CreateDirectory(Path.Combine(destination, songFile.Tag.Performers[0]));
                            //addToOutput("Composer directory not found. Creating one...");
                        }

                        // Check if an album tag exists
                        if (songFile.Tag.Album != null)
                        {

                            // If a directory is not existent create it
                            if (!Directory.Exists(Path.Combine(destination, songFile.Tag.Performers[0], songFile.Tag.Album)))
                            {
                                Directory.CreateDirectory(Path.Combine(destination, songFile.Tag.Performers[0], songFile.Tag.Album));
                                //addToOutput("Album directory not found. Creating one...");
                            }

                            // Check if a title tag exists
                            if (songFile.Tag.Title != null)
                            {
                                // If it does, copy the file and change the name
                                System.IO.File.Copy(file, Path.Combine(destination, songFile.Tag.Performers[0], songFile.Tag.Album, songFile.Tag.Title + ".mp3"));
                            }
                            else
                            {
                                // Otherwise, just copy the file keeping the name
                                System.IO.File.Copy(file, Path.Combine(destination, songFile.Tag.Performers[0], songFile.Tag.Album, Path.GetFileName(file)));
                            }

                        }
                        else
                        {
                            addToOutput("Album tag not found. Will be put in 'unsorted'.");

                            // Create directory if it doesn't exist
                            if (!Directory.Exists(Path.Combine(destination, songFile.Tag.Performers[0], "unsorted")))
                                Directory.CreateDirectory(Path.Combine(destination, songFile.Tag.Performers[0], "unsorted"));

                            // Copy the file there
                            System.IO.File.Copy(file, Path.Combine(destination, songFile.Tag.Performers[0], "unsorted", Path.GetFileName(file)));

                        }



                    }
                    else
                    {

                        addToOutput("Composer tag not found. Will be put in 'unsorted'.");

                        // Create directory if it doesn't exist
                        if (!Directory.Exists(Path.Combine(destination, "unsorted")))
                            Directory.CreateDirectory(Path.Combine(destination, "unsorted"));

                        // Copy the file there
                        System.IO.File.Copy(file, Path.Combine(destination, "unsorted", Path.GetFileName(file)));

                    }
                }
                catch (Exception ex)
                {

                    addToOutput("Error - " + ex.Message);

                }

            }
        }
    }
}
