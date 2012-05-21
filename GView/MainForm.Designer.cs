using System.Windows.Forms;
namespace GView
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.imgPhoto = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imageChangeBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.thoughtsLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.devBox = new System.Windows.Forms.TextBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.thoughtsBox = new System.Windows.Forms.TextBox();
            this.modeBox = new System.Windows.Forms.TextBox();
            this.devlabel = new System.Windows.Forms.Label();
            this.genreBox = new System.Windows.Forms.TextBox();
            this.pubLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.modeLabel = new System.Windows.Forms.Label();
            this.engineLabel = new System.Windows.Forms.Label();
            this.pubBox = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.engineBox = new System.Windows.Forms.TextBox();
            this.ratingBox = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gameList = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.nextBtn = new System.Windows.Forms.Button();
            this.previousBtn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.videoBtn = new System.Windows.Forms.Button();
            this.openBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.editBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.locBtn = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.screenBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.status.SuspendLayout();
            this.menu.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screenBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPhoto
            // 
            this.imgPhoto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.imgPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPhoto.ErrorImage = null;
            this.imgPhoto.InitialImage = null;
            this.imgPhoto.Location = new System.Drawing.Point(3, 3);
            this.imgPhoto.Name = "imgPhoto";
            this.imgPhoto.Size = new System.Drawing.Size(252, 403);
            this.imgPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPhoto.TabIndex = 2;
            this.imgPhoto.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(70, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 415);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.imageChangeBtn);
            this.panel2.Controls.Add(this.imgPhoto);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 409);
            this.panel2.TabIndex = 0;
            // 
            // imageChangeBtn
            // 
            this.imageChangeBtn.Image = global::GView.Properties.Resources.zoom_in;
            this.imageChangeBtn.Location = new System.Drawing.Point(200, 354);
            this.imageChangeBtn.Name = "imageChangeBtn";
            this.imageChangeBtn.Size = new System.Drawing.Size(51, 49);
            this.imageChangeBtn.TabIndex = 3;
            this.imageChangeBtn.UseVisualStyleBackColor = true;
            this.imageChangeBtn.Click += new System.EventHandler(this.imageChangeBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.thoughtsLabel);
            this.panel3.Controls.Add(this.nameBox);
            this.panel3.Controls.Add(this.devBox);
            this.panel3.Controls.Add(this.genreLabel);
            this.panel3.Controls.Add(this.yearBox);
            this.panel3.Controls.Add(this.thoughtsBox);
            this.panel3.Controls.Add(this.modeBox);
            this.panel3.Controls.Add(this.devlabel);
            this.panel3.Controls.Add(this.genreBox);
            this.panel3.Controls.Add(this.pubLabel);
            this.panel3.Controls.Add(this.ratingLabel);
            this.panel3.Controls.Add(this.modeLabel);
            this.panel3.Controls.Add(this.engineLabel);
            this.panel3.Controls.Add(this.pubBox);
            this.panel3.Controls.Add(this.yearLabel);
            this.panel3.Controls.Add(this.engineBox);
            this.panel3.Controls.Add(this.ratingBox);
            this.panel3.Location = new System.Drawing.Point(340, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(719, 415);
            this.panel3.TabIndex = 26;
            // 
            // thoughtsLabel
            // 
            this.thoughtsLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.thoughtsLabel.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoughtsLabel.Location = new System.Drawing.Point(4, 311);
            this.thoughtsLabel.Name = "thoughtsLabel";
            this.thoughtsLabel.Size = new System.Drawing.Size(711, 41);
            this.thoughtsLabel.TabIndex = 25;
            this.thoughtsLabel.Text = "Thoughts :";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameBox.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.nameBox.ForeColor = System.Drawing.Color.Firebrick;
            this.nameBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nameBox.Location = new System.Drawing.Point(4, 4);
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.ReadOnly = true;
            this.nameBox.Size = new System.Drawing.Size(711, 51);
            this.nameBox.TabIndex = 12;
            this.nameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // devBox
            // 
            this.devBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.devBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.devBox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.devBox.Location = new System.Drawing.Point(200, 94);
            this.devBox.Name = "devBox";
            this.devBox.ReadOnly = true;
            this.devBox.Size = new System.Drawing.Size(515, 33);
            this.devBox.TabIndex = 16;
            this.devBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // genreLabel
            // 
            this.genreLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.genreLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.Location = new System.Drawing.Point(4, 202);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(192, 33);
            this.genreLabel.TabIndex = 19;
            this.genreLabel.Text = "Genre ";
            // 
            // yearBox
            // 
            this.yearBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.yearBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yearBox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.yearBox.Location = new System.Drawing.Point(200, 58);
            this.yearBox.Name = "yearBox";
            this.yearBox.ReadOnly = true;
            this.yearBox.Size = new System.Drawing.Size(515, 33);
            this.yearBox.TabIndex = 14;
            this.yearBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // thoughtsBox
            // 
            this.thoughtsBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.thoughtsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.thoughtsBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoughtsBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.thoughtsBox.Location = new System.Drawing.Point(4, 350);
            this.thoughtsBox.Multiline = true;
            this.thoughtsBox.Name = "thoughtsBox";
            this.thoughtsBox.ReadOnly = true;
            this.thoughtsBox.Size = new System.Drawing.Size(711, 61);
            this.thoughtsBox.TabIndex = 28;
            // 
            // modeBox
            // 
            this.modeBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.modeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modeBox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.modeBox.Location = new System.Drawing.Point(200, 238);
            this.modeBox.Name = "modeBox";
            this.modeBox.ReadOnly = true;
            this.modeBox.Size = new System.Drawing.Size(515, 33);
            this.modeBox.TabIndex = 24;
            this.modeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // devlabel
            // 
            this.devlabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.devlabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devlabel.Location = new System.Drawing.Point(4, 94);
            this.devlabel.Name = "devlabel";
            this.devlabel.Size = new System.Drawing.Size(192, 33);
            this.devlabel.TabIndex = 9;
            this.devlabel.Text = "Developer";
            // 
            // genreBox
            // 
            this.genreBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.genreBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.genreBox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.genreBox.Location = new System.Drawing.Point(200, 202);
            this.genreBox.Name = "genreBox";
            this.genreBox.ReadOnly = true;
            this.genreBox.Size = new System.Drawing.Size(515, 33);
            this.genreBox.TabIndex = 22;
            this.genreBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pubLabel
            // 
            this.pubLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pubLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pubLabel.Location = new System.Drawing.Point(4, 130);
            this.pubLabel.Name = "pubLabel";
            this.pubLabel.Size = new System.Drawing.Size(192, 33);
            this.pubLabel.TabIndex = 15;
            this.pubLabel.Text = "Publisher";
            // 
            // ratingLabel
            // 
            this.ratingLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ratingLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingLabel.Location = new System.Drawing.Point(4, 274);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(192, 33);
            this.ratingLabel.TabIndex = 23;
            this.ratingLabel.Text = "Personal Rating";
            // 
            // modeLabel
            // 
            this.modeLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.modeLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeLabel.Location = new System.Drawing.Point(4, 238);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(192, 33);
            this.modeLabel.TabIndex = 21;
            this.modeLabel.Text = "Modes";
            // 
            // engineLabel
            // 
            this.engineLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.engineLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engineLabel.Location = new System.Drawing.Point(4, 166);
            this.engineLabel.Name = "engineLabel";
            this.engineLabel.Size = new System.Drawing.Size(192, 33);
            this.engineLabel.TabIndex = 17;
            this.engineLabel.Text = "Engine";
            // 
            // pubBox
            // 
            this.pubBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pubBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pubBox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pubBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.pubBox.Location = new System.Drawing.Point(200, 130);
            this.pubBox.Name = "pubBox";
            this.pubBox.ReadOnly = true;
            this.pubBox.Size = new System.Drawing.Size(515, 33);
            this.pubBox.TabIndex = 18;
            this.pubBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yearLabel
            // 
            this.yearLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.yearLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(4, 58);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(192, 33);
            this.yearLabel.TabIndex = 11;
            this.yearLabel.Text = "Year";
            // 
            // engineBox
            // 
            this.engineBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.engineBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.engineBox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engineBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.engineBox.Location = new System.Drawing.Point(200, 166);
            this.engineBox.Name = "engineBox";
            this.engineBox.ReadOnly = true;
            this.engineBox.Size = new System.Drawing.Size(515, 33);
            this.engineBox.TabIndex = 20;
            this.engineBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ratingBox
            // 
            this.ratingBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ratingBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ratingBox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ratingBox.Location = new System.Drawing.Point(200, 274);
            this.ratingBox.Name = "ratingBox";
            this.ratingBox.ReadOnly = true;
            this.ratingBox.Size = new System.Drawing.Size(515, 33);
            this.ratingBox.TabIndex = 26;
            this.ratingBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.status.Location = new System.Drawing.Point(8, 891);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(1051, 22);
            this.status.TabIndex = 29;
            this.status.Text = "status";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.commandToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(8, 8);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1051, 24);
            this.menu.TabIndex = 30;
            this.menu.Text = "menu";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFolderToolStripMenuItem,
            this.saveGameToolStripMenuItem,
            this.editToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // addFolderToolStripMenuItem
            // 
            this.addFolderToolStripMenuItem.Name = "addFolderToolStripMenuItem";
            this.addFolderToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.addFolderToolStripMenuItem.Text = "Add Folder";
            this.addFolderToolStripMenuItem.Click += new System.EventHandler(this.addFolderToolStripMenuItem_Click);
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.saveGameToolStripMenuItem.Text = "Save Game";
            this.saveGameToolStripMenuItem.Click += new System.EventHandler(this.saveGameToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.editToolStripMenuItem.Text = "Edit Game";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // commandToolStripMenuItem
            // 
            this.commandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nextToolStripMenuItem,
            this.previousToolStripMenuItem,
            this.openToolStripMenuItem});
            this.commandToolStripMenuItem.Name = "commandToolStripMenuItem";
            this.commandToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.commandToolStripMenuItem.Text = "Command";
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.nextToolStripMenuItem.Text = "Next";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
            // 
            // previousToolStripMenuItem
            // 
            this.previousToolStripMenuItem.Name = "previousToolStripMenuItem";
            this.previousToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.previousToolStripMenuItem.Text = "Previous";
            this.previousToolStripMenuItem.Click += new System.EventHandler(this.previousToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentationToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.documentationToolStripMenuItem.Text = "Documentation";
            this.documentationToolStripMenuItem.Click += new System.EventHandler(this.documentationToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.gameList);
            this.panel4.Location = new System.Drawing.Point(8, 465);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(326, 413);
            this.panel4.TabIndex = 4;
            // 
            // gameList
            // 
            this.gameList.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gameList.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gameList.Location = new System.Drawing.Point(3, 3);
            this.gameList.Name = "gameList";
            this.gameList.Size = new System.Drawing.Size(320, 407);
            this.gameList.TabIndex = 0;
            this.gameList.SelectedIndexChanged += new System.EventHandler(this.gameList_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.nextBtn);
            this.panel5.Controls.Add(this.previousBtn);
            this.panel5.Location = new System.Drawing.Point(8, 191);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(56, 107);
            this.panel5.TabIndex = 38;
            // 
            // nextBtn
            // 
            this.nextBtn.Image = global::GView.Properties.Resources.next;
            this.nextBtn.Location = new System.Drawing.Point(2, 54);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(52, 51);
            this.nextBtn.TabIndex = 33;
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // previousBtn
            // 
            this.previousBtn.Image = global::GView.Properties.Resources.back;
            this.previousBtn.Location = new System.Drawing.Point(2, 2);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(52, 51);
            this.previousBtn.TabIndex = 34;
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.Controls.Add(this.videoBtn);
            this.panel6.Controls.Add(this.openBtn);
            this.panel6.Controls.Add(this.exitBtn);
            this.panel6.Location = new System.Drawing.Point(8, 301);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(56, 158);
            this.panel6.TabIndex = 39;
            // 
            // videoBtn
            // 
            this.videoBtn.Image = global::GView.Properties.Resources.computer;
            this.videoBtn.Location = new System.Drawing.Point(2, 2);
            this.videoBtn.Name = "videoBtn";
            this.videoBtn.Size = new System.Drawing.Size(52, 48);
            this.videoBtn.TabIndex = 35;
            this.videoBtn.UseVisualStyleBackColor = true;
            this.videoBtn.Click += new System.EventHandler(this.videoBtn_Click);
            // 
            // openBtn
            // 
            this.openBtn.Image = global::GView.Properties.Resources.accept;
            this.openBtn.Location = new System.Drawing.Point(2, 54);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(52, 48);
            this.openBtn.TabIndex = 27;
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Image = global::GView.Properties.Resources.delete;
            this.exitBtn.Location = new System.Drawing.Point(2, 105);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(52, 51);
            this.exitBtn.TabIndex = 36;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel7.Controls.Add(this.editBtn);
            this.panel7.Controls.Add(this.saveBtn);
            this.panel7.Controls.Add(this.locBtn);
            this.panel7.Location = new System.Drawing.Point(8, 44);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(56, 144);
            this.panel7.TabIndex = 40;
            // 
            // editBtn
            // 
            this.editBtn.Image = global::GView.Properties.Resources.page_process;
            this.editBtn.Location = new System.Drawing.Point(2, 48);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(52, 47);
            this.editBtn.TabIndex = 38;
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Image = global::GView.Properties.Resources.page_accept;
            this.saveBtn.Location = new System.Drawing.Point(2, 94);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(52, 48);
            this.saveBtn.TabIndex = 26;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // locBtn
            // 
            this.locBtn.Image = global::GView.Properties.Resources.home_search;
            this.locBtn.Location = new System.Drawing.Point(2, 2);
            this.locBtn.Name = "locBtn";
            this.locBtn.Size = new System.Drawing.Size(52, 47);
            this.locBtn.TabIndex = 37;
            this.locBtn.UseVisualStyleBackColor = true;
            this.locBtn.Click += new System.EventHandler(this.locBtn_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel8.Controls.Add(this.screenBox);
            this.panel8.Location = new System.Drawing.Point(340, 465);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(719, 413);
            this.panel8.TabIndex = 41;
            // 
            // screenBox
            // 
            this.screenBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.screenBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.screenBox.Location = new System.Drawing.Point(4, 4);
            this.screenBox.Name = "screenBox";
            this.screenBox.Size = new System.Drawing.Size(711, 406);
            this.screenBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.screenBox.TabIndex = 0;
            this.screenBox.TabStop = false;
            this.screenBox.Click += new System.EventHandler(this.screenBox_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1067, 921);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "G_View 2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.screenBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPhoto;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label thoughtsLabel;
        private TextBox nameBox;
        private TextBox devBox;
        private Label genreLabel;
        private TextBox yearBox;
        private TextBox thoughtsBox;
        private TextBox modeBox;
        private Label devlabel;
        private TextBox genreBox;
        private Label pubLabel;
        private Label ratingLabel;
        private Label modeLabel;
        private Label engineLabel;
        private TextBox pubBox;
        private Label yearLabel;
        private TextBox engineBox;
        private TextBox ratingBox;
        private Button openBtn;
        private Button saveBtn;
        private StatusStrip status;
        private MenuStrip menu;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem addFolderToolStripMenuItem;
        private ToolStripMenuItem saveGameToolStripMenuItem;
        private ToolStripMenuItem commandToolStripMenuItem;
        private ToolStripMenuItem nextToolStripMenuItem;
        private ToolStripMenuItem previousToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripStatusLabel StatusLabel;
        private Panel panel4;
        private Button nextBtn;
        private Button previousBtn;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private Button videoBtn;
        private Button exitBtn;
        private Button locBtn;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Button imageChangeBtn;
        private Button editBtn;
        private ToolStripMenuItem editToolStripMenuItem;
        private Panel panel8;
        private PictureBox screenBox;
        public ListBox gameList;
        private ToolStripMenuItem documentationToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem1;
    }
}

