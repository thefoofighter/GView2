/***********************************
 * GView
 * Ver: 2.0a
 * Developed by Cathal McNally
 * mcnallycathal@yahoo.ie
 * 14/05/2012
 * 
 * ********************************* 
 * VideoForm()
 * Displays the Video Player Form 
 * for playing Game Trailers
 * currently only *.mp4
 * TODO: Add other formats!
 *
 * *********************************/

using System;
using System.Xml;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GView
{
    public partial class MainForm : Form
    {
        #region Variables
        // xml document parser
        private XmlDocument doc = new XmlDocument();       
        // xml Nodes
        private XmlNode nameNode,yearNode,devNode,pubNode,engineNode,genreNode,modesNode,ratingNode,thoughtsNode;
        // forms
        AboutForm aboutFrm;
        VideoForm videoFrm;

        WebBrowser wb;
        // Create a list of folders that represent a game each.
        private List<String> addFolderArray;
        // set the programs current path
        private static string currentDir = Directory.GetCurrentDirectory();
        // set the paths for the default Image and XML templates;
        private string defaultImg = currentDir + "\\Data\\gameCover.gvi";
        private string defaultData = currentDir + "\\Data\\template.gvx";
        // strings, string Arrays.
        private string rootGameDir, newImageDir, tempVideoPath;
        private string initialDir = "C:/";
        private string[] videoDir, screenshotDir, xmlDir, imageDir;   
        // click counter for screen shots
        int clickCounter = 0;      
        #endregion
       
        public MainForm()
        {
            InitializeComponent();
            // Center form
            this.StartPosition = FormStartPosition.CenterScreen;
            // new List of folders as Strings
            addFolderArray = new List<string>();
            // Form Button states
            openBtn.Enabled = false;
            saveBtn.Enabled = false;           
            nextBtn.Enabled = false;
            previousBtn.Enabled = false;
            videoBtn.Enabled = false;
            editBtn.Enabled = false;
            // Hide image changing button, used in edit mode
            imageChangeBtn.Hide();
            // Menu Button states
            saveGameToolStripMenuItem.Enabled = false;
            editToolStripMenuItem.Enabled = false;
            nextToolStripMenuItem.Enabled = false;
            previousToolStripMenuItem.Enabled = false;
            openToolStripMenuItem.Enabled = false;
            // Enable the Screenshot Picture box
            screenBox.Enabled = false;            
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            // Tooltips
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this.locBtn, "Add a Game Directory");
            ToolTip.SetToolTip(this.editBtn, "Edit the game Data");
            ToolTip.SetToolTip(this.saveBtn, "Save the game Data");
            ToolTip.SetToolTip(this.previousBtn, "Select previous game");
            ToolTip.SetToolTip(this.nextBtn, "Select next game");
            ToolTip.SetToolTip(this.videoBtn, "View the game video");
            ToolTip.SetToolTip(this.openBtn, "Open the game folder");
            ToolTip.SetToolTip(this.exitBtn, "Exit GView");
            
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            // Open the directory of the currently selected game on gameList
            System.Diagnostics.Process.Start("explorer.exe", rootGameDir+"\\"+gameList.SelectedItem.ToString());
        }
       
        // Add Folder Dialog menu Button
        private void addFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addLocation();
        }

        // Add Folder main button
        private void locBtn_Click(object sender, EventArgs e)
        {
            addLocation();
        }

        // next game in the list
        private void nextBtn_Click(object sender, EventArgs e)
        {
            // Keep the selected item within gameList bounds
            if (gameList.SelectedIndex != gameList.Items.Count - 1)
                gameList.SelectedIndex = gameList.SelectedIndex + 1;
            // check for GView data
            gvCheck();
        }

        // previous game in the list
        private void previousBtn_Click(object sender, EventArgs e)
        {
            // Keep the selected item within gameList bounds
            if (gameList.SelectedIndex > 0)
                gameList.SelectedIndex = gameList.SelectedIndex - 1;
            // check for GView data
            gvCheck();
        }

        // next game in the list via menu
        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Keep the selected item within gameList bounds
            if (gameList.SelectedIndex != gameList.Items.Count - 1)
                gameList.SelectedIndex = gameList.SelectedIndex + 1;
            // check for GView data
            gvCheck();
        }

        // previous game in the list via menu
        private void previousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Keep the selected item within gameList bounds
            if (gameList.SelectedIndex > 0)
                gameList.SelectedIndex = gameList.SelectedIndex - 1;
            // check for GView data
            gvCheck();
        }

        // call edit via main form button
        private void editBtn_Click(object sender, EventArgs e)
        {
            editFunc();
        }

        // call save via main form button
        private void saveBtn_Click(object sender, EventArgs e)
        {
            saveFunc();         
        }

        // call edit via menu button
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editFunc();
        }

        // call save via menu button
        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFunc();
        }

        // preview the game when you select it from the list
        private void gameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // check for a GView data
            gvCheck();
        }

        // show the next image in the array if you click the picture box
        // If it gets to the last image it resets to the start
        private void screenBox_Click(object sender, EventArgs e)
        {
            if (clickCounter == screenshotDir.Length)
            {
                clickCounter = 0;
            }
            if (clickCounter < screenshotDir.Length)
            {
                screenBox.Load(screenshotDir[clickCounter]);
                clickCounter++;
            }
        }

        // create teh video form
        public void videoBtn_Click(object sender, EventArgs e)
        {
            videoFrm = new VideoForm();
            // set video forms Video path to the current games selected video path
            videoFrm.path = tempVideoPath;
            // show the video form
            videoFrm.Show();
        }

        // open the currently selected games directory
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", rootGameDir + "\\" + gameList.SelectedItem.ToString());
        }

        // terminate Via the main exit Button
        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Ask the user if they are sure
            DialogResult result1 = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                Environment.Exit(1);
            }
            else
                return;
        }

        // terminate via the Menu exit button
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ask the user if they are sure
            DialogResult result1 = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                Environment.Exit(1);
            }
            else
                return;
        }

        // gvCheck checks for game viewer images and xml data
        public void gvCheck()
        {          
            // Create a GView folder for the current game if one doesnt exist
            if (!System.IO.Directory.Exists(rootGameDir + "\\" + gameList.SelectedItem.ToString() + "\\GView"))
            {
                System.IO.Directory.CreateDirectory(rootGameDir + "\\" + gameList.SelectedItem.ToString() + "\\GView");
            }
            // path of the currently selected game cover image (.gvi only)
            imageDir = Directory.GetFiles(rootGameDir + "\\" + gameList.SelectedItem.ToString() + "\\GView", "*.gvi", SearchOption.AllDirectories);
            // path of the currently selected games xml data (.gvx only)
            xmlDir = Directory.GetFiles(rootGameDir + "\\" + gameList.SelectedItem.ToString() + "\\GView", "*.gvx", SearchOption.AllDirectories);
            // path of the currently selected games screenshots (.jpg only)
            // TODO: Add support for more image formats.
            screenshotDir = Directory.GetFiles(rootGameDir + "\\" + gameList.SelectedItem.ToString()+"\\GView", "*.jpg", SearchOption.AllDirectories);
            // path of the currently selected games video footage,trailer (.mp4 only)
            // TODO: Add suppoert for more video formats
            videoDir = Directory.GetFiles(rootGameDir + "\\" + gameList.SelectedItem.ToString() + "\\GView", "*.mp4", SearchOption.AllDirectories);

            // if there is a video present (.mp4)
            if (videoDir.Length == 1)
            {
                // set tempVideoPath to the current games video path
                tempVideoPath = videoDir[0];
                // for video to work the backslashes had to be switched to forward slashes
                tempVideoPath = tempVideoPath.Replace(@"\", "/");
            }
            else
            {
                // clear tempVideoPath to prevent the player playing the last games video
                tempVideoPath = "";
            }
            
            // IF Game data exists (Game data = .gvi + .gvx)
            if (imageDir.Length == 1 && xmlDir.Length == 1)
            {
                // load the current games cover image into the picture box
                imgPhoto.Load(imageDir[0]);
                // load the current games xml data into the xmlDoc parser
                doc.Load(xmlDir[0]);

                // If there are screenshots in the GView folder (.jpg)
                if (screenshotDir.Length >= 1)
                {
                    // load a default image (click me)
                    screenBox.Load(currentDir + "\\Data\\screenie_exists.jpg");
                    // allow mouse clicks be read
                    screenBox.Enabled = true;
                }
                // If no screenshots exist
                else if (screenshotDir.Length <= 0)
                {
                    // load a default hint image (put images in GView folder (.jpg))
                    screenBox.Load(currentDir + "\\Data\\screenie.jpg");
                    // disable the picturebox if it was enabled
                    screenBox.Enabled = false;
                }
            }
            // IF Game data is not present prompt to add new game Data
            else
            {
                DialogResult result = MessageBox.Show("Add a new game?", "No data detected", MessageBoxButtons.YesNo);

                // Load template image from Data to the screen picBox
                imgPhoto.Load(currentDir + "\\Data\\gameCover.gvi");
                // Load template xml data from Data to the screen Data fields
                doc.Load(currentDir + "\\Data\\template.gvx");
                // If there are screenshots in the GView folder (.jpg)
                 

                if (result == DialogResult.Yes)
                {
                    // provide a string for making a new GView folder for the current game
                    string emptyFolder = rootGameDir + "\\" + gameList.SelectedItem.ToString() + "\\GView";
                    // If Gview folder already exists dont create it
                    if (!System.IO.Directory.Exists(emptyFolder))
                    {
                        System.IO.Directory.CreateDirectory(emptyFolder);
                    }
                    // Copy template Image from the programs Data folder to the current games GView folder
                    System.IO.File.Copy(defaultImg, emptyFolder + "\\gameCover.gvi", true);
                    // Copy template xml from the programs Data folder to the current games GView folder
                    System.IO.File.Copy(defaultData, emptyFolder + "\\template.gvx", true);

                    // add the newly added image and xml to string arrays
                    string[] tempImageDir = Directory.GetFiles(rootGameDir + "\\" + gameList.SelectedItem.ToString(), "*.gvi", SearchOption.AllDirectories);
                    string[] tempXmlDir = Directory.GetFiles(rootGameDir + "\\" + gameList.SelectedItem.ToString(), "*.gvx", SearchOption.AllDirectories);

                    // Load them back into the program
                    imgPhoto.Load(tempImageDir[0]);
                    doc.Load(tempXmlDir[0]);

                    if (screenshotDir.Length >= 1)
                    {
                        // load a default image (click me)
                        screenBox.Load(currentDir + "\\Data\\screenie_exists.jpg");
                        // allow mouse clicks be read
                        screenBox.Enabled = true;
                    }
                    // If no screenshots exist
                    else if (screenshotDir.Length <= 0)
                    {
                        // load a default hint image (put images in GView folder (.jpg))
                        screenBox.Load(currentDir + "\\Data\\screenie.jpg");
                        // disable the picturebox if it was enabled
                        screenBox.Enabled = false;
                    }

                    editFunc();
                }
                else
                {
                    return;
                }   
            }

            // Set xml nodes to appropriate corresponding xml file nodes
            nameNode = doc.SelectSingleNode("//name/text()");
            yearNode = doc.SelectSingleNode("//year/text()");
            devNode = doc.SelectSingleNode("//developer/text()");
            pubNode = doc.SelectSingleNode("//publisher/text()");
            engineNode = doc.SelectSingleNode("//engine/text()");
            genreNode = doc.SelectSingleNode("//genre/text()");
            modesNode = doc.SelectSingleNode("//modes/text()");
            ratingNode = doc.SelectSingleNode("//personalRating/text()");
            thoughtsNode = doc.SelectSingleNode("//thoughts/text()");

            // Set each TextBox's Text value to the value imported by the xml nodes
            nameBox.Text = nameNode.Value;
            yearBox.Text = yearNode.Value;
            devBox.Text = devNode.Value;
            pubBox.Text = pubNode.Value;
            engineBox.Text = engineNode.Value;
            genreBox.Text = genreNode.Value;
            modeBox.Text = modesNode.Value;
            ratingBox.Text = ratingNode.Value;
            thoughtsBox.Text = thoughtsNode.Value;
        }

        // Add a base folder location (Games folder)
        private void addLocation()
        {
            // create a folder browser dialog
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                // properties
                dialog.Description = "Add Root Directory for Games";
                dialog.ShowNewFolderButton = false;
                dialog.RootFolder = Environment.SpecialFolder.MyComputer;

                // if OK
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // set root game directory to the selected path
                    rootGameDir = dialog.SelectedPath;
                    // update status bar
                    // TODO: add support for numerous root game Directories
                    StatusLabel.Text = "Dir: " + rootGameDir;

                    // populate an array of folders that are in the root Game Directory
                    string[] addFolder = Directory.GetDirectories(rootGameDir, "*", SearchOption.TopDirectoryOnly);

                    
                    foreach (string temp in addFolder)
                    {
                        // Replace the root Game Directory String and the backslash with ""
                        // This is used by the gameList to show the current games folder name, rather than the whole path 
                        string _temp = temp.Replace(rootGameDir + "\\", "");
                        // add all the folders to the List
                        addFolderArray.Add(_temp);
                    }
                    // set Listboxes data source to the folders in root Game Directory
                    gameList.DataSource = addFolderArray;
                    // Update gvCheck
                    gvCheck();

                    // Set main buttons states                  
                    locBtn.Enabled = false;
                    openBtn.Enabled = true;
                    nextBtn.Enabled = true;
                    previousBtn.Enabled = true;
                    videoBtn.Enabled = true;
                    editBtn.Enabled = true;

                    // set menu buttons States
                    addFolderToolStripMenuItem.Enabled = false;
                    editToolStripMenuItem.Enabled = true;
                    nextToolStripMenuItem.Enabled = true;
                    previousToolStripMenuItem.Enabled = true;
                    openToolStripMenuItem.Enabled = true;
                }
            }          
        }

        // Change the games cover image
        private void imageChangeBtn_Click(object sender, EventArgs e)
        {
            // open a file browser
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // set initial file directory to currently selected game
            openFileDialog.InitialDirectory = initialDir;
            // image filter (.jpg, .png, .bmp, .gvi)
            openFileDialog.Filter = "jpeg images |*.jpg|PNG images|*.png|Bitmap Images|*.bmp|Game Viewer Images|*.gvi";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {                   
                string[] tempImage = Directory.GetFiles(rootGameDir + "\\" + gameList.SelectedItem.ToString(), "*.gvi", SearchOption.AllDirectories);
                if (tempImage.Length == 1)
                {
                    // delete the current image you are replacing
                    System.IO.File.Delete(tempImage[0]);
                    // New image file name
                    newImageDir = openFileDialog.FileName;
                    // copy the new image from whereever to the current games GView folder and rename to gameCover.gvi
                    System.IO.File.Copy(newImageDir, rootGameDir + "\\" + gameList.SelectedItem.ToString() + "\\Gview\\gameCover.gvi", true);
                }
            }
            imageDir = Directory.GetFiles(rootGameDir + "\\" + gameList.SelectedItem.ToString() + "\\GView", "*.gvi", SearchOption.AllDirectories);
            if (imageDir.Length == 1)
            {
                imgPhoto.Load(imageDir[0]);
            }

        }

        // Save your XML data changes
        private void saveFunc()
        {
            // update the picturebox -> Not sure if this works ಠ_ಠ
            imgPhoto.Refresh();

            // set main button states
            editBtn.Enabled = true;            
            imageChangeBtn.Hide();
            saveBtn.Enabled = false;           
            nextBtn.Enabled = true;
            previousBtn.Enabled = true;

            // set menu button states
            editToolStripMenuItem.Enabled = true;
            saveGameToolStripMenuItem.Enabled = false;
            nextToolStripMenuItem.Enabled = true;
            previousToolStripMenuItem.Enabled = true;

            // set text box states
            nameBox.ReadOnly = true;
            yearBox.ReadOnly = true;
            devBox.ReadOnly = true;
            pubBox.ReadOnly = true;
            engineBox.ReadOnly = true;
            genreBox.ReadOnly = true;
            modeBox.ReadOnly = true;
            ratingBox.ReadOnly = true;
            thoughtsBox.ReadOnly = true;

            // prompt the user to make sure
            DialogResult result = MessageBox.Show("Are you Sure? Data will be rewritten!", "Save", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // set textbox states
                nameNode.Value = nameBox.Text;
                pubNode.Value = pubBox.Text;
                devNode.Value = devBox.Text;
                yearNode.Value = yearBox.Text;
                engineNode.Value = engineBox.Text;
                genreNode.Value = genreBox.Text;
                modesNode.Value = modeBox.Text;
                ratingNode.Value = ratingBox.Text;
                thoughtsNode.Value = thoughtsBox.Text;

                // get the name and path of the file you are saving to
                string[] tempXml = Directory.GetFiles(rootGameDir + "\\" + gameList.SelectedItem.ToString(), "*.gvx", SearchOption.AllDirectories);

                // save your xml edits
                doc.Save(tempXml[0]);
            }
            else
                return;
        }

        // Edit the Xml data, enable edit button for editing the image
        private void editFunc()
        {
            // show image edit button
            imageChangeBtn.Show();
            
            // set main button states
            saveBtn.Enabled = true;
            nextBtn.Enabled = false;
            previousBtn.Enabled = false;
            editBtn.Enabled = false;
            
            // set menu button states
            editToolStripMenuItem.Enabled = false;
            saveGameToolStripMenuItem.Enabled = true;
            nextToolStripMenuItem.Enabled = false;
            previousToolStripMenuItem.Enabled = false;

            // set textbox states
            nameBox.ReadOnly = false;
            yearBox.ReadOnly = false;
            devBox.ReadOnly = false;
            pubBox.ReadOnly = false;
            engineBox.ReadOnly = false;
            genreBox.ReadOnly = false;
            modeBox.ReadOnly = false;
            ratingBox.ReadOnly = false;
            thoughtsBox.ReadOnly = false;
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // new about form
            aboutFrm = new AboutForm();
            // show the about form
            aboutFrm.Show();
        }

        public void documentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // opens the pdf's current folder
            System.Diagnostics.Process.Start("explorer.exe", currentDir);
            // opens a pdf in adobe reader if its installed
            System.Diagnostics.Process.Start(currentDir + "\\" + "gviewDocumentation.pdf");
        }
    }
}
