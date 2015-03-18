namespace UglyTool
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
            this.searchText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchResultUsers = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressImage = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SearchResultGroups = new System.Windows.Forms.ListBox();
            this.itemProperties = new System.Windows.Forms.TextBox();
            this.itemMemberOf = new System.Windows.Forms.TextBox();
            this.itemMembers = new System.Windows.Forms.TextBox();
            this.searchGroupsWorker = new System.ComponentModel.BackgroundWorker();
            this.searchUsersWorker = new System.ComponentModel.BackgroundWorker();
            this.searchUserNameWorker = new System.ComponentModel.BackgroundWorker();
            this.groupSelectWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectDomain = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(18, 24);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(237, 20);
            this.searchText.TabIndex = 0;
            this.searchText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // searchResultUsers
            // 
            this.searchResultUsers.FormattingEnabled = true;
            this.searchResultUsers.Location = new System.Drawing.Point(19, 78);
            this.searchResultUsers.Name = "searchResultUsers";
            this.searchResultUsers.Size = new System.Drawing.Size(234, 108);
            this.searchResultUsers.TabIndex = 2;
            this.searchResultUsers.SelectedIndexChanged += new System.EventHandler(this.searchResultUsers_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Users Found";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Properties";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Member of:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Members:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.progressImage);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.SearchResultGroups);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.searchResultUsers);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchText);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 358);
            this.panel1.TabIndex = 10;
            // 
            // progressImage
            // 
            this.progressImage.Image = ((System.Drawing.Image)(resources.GetObject("progressImage.Image")));
            this.progressImage.Location = new System.Drawing.Point(264, 51);
            this.progressImage.Name = "progressImage";
            this.progressImage.Size = new System.Drawing.Size(48, 23);
            this.progressImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.progressImage.TabIndex = 8;
            this.progressImage.TabStop = false;
            this.progressImage.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 21);
            this.button1.TabIndex = 7;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Groups Found";
            // 
            // SearchResultGroups
            // 
            this.SearchResultGroups.FormattingEnabled = true;
            this.SearchResultGroups.Location = new System.Drawing.Point(16, 215);
            this.SearchResultGroups.Name = "SearchResultGroups";
            this.SearchResultGroups.Size = new System.Drawing.Size(296, 121);
            this.SearchResultGroups.TabIndex = 5;
            this.SearchResultGroups.SelectedIndexChanged += new System.EventHandler(this.SearchResultGroups_SelectedIndexChanged);
            // 
            // itemProperties
            // 
            this.itemProperties.Location = new System.Drawing.Point(346, 90);
            this.itemProperties.Multiline = true;
            this.itemProperties.Name = "itemProperties";
            this.itemProperties.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.itemProperties.Size = new System.Drawing.Size(306, 277);
            this.itemProperties.TabIndex = 11;
            // 
            // itemMemberOf
            // 
            this.itemMemberOf.Location = new System.Drawing.Point(15, 414);
            this.itemMemberOf.Multiline = true;
            this.itemMemberOf.Name = "itemMemberOf";
            this.itemMemberOf.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.itemMemberOf.Size = new System.Drawing.Size(321, 329);
            this.itemMemberOf.TabIndex = 12;
            // 
            // itemMembers
            // 
            this.itemMembers.Location = new System.Drawing.Point(357, 413);
            this.itemMembers.Multiline = true;
            this.itemMembers.Name = "itemMembers";
            this.itemMembers.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.itemMembers.Size = new System.Drawing.Size(300, 329);
            this.itemMembers.TabIndex = 13;
            // 
            // searchGroupsWorker
            // 
            this.searchGroupsWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.searchGroupsWorker_DoWork);
            this.searchGroupsWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.searchGroupsWorker_RunWorkerCompleted);
            // 
            // searchUsersWorker
            // 
            this.searchUsersWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.searchUsersWorker_DoWork);
            this.searchUsersWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.searchUsersWorker_RunWorkerCompleted);
            // 
            // searchUserNameWorker
            // 
            this.searchUserNameWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.searchUserNameWorker_DoWork);
            this.searchUserNameWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.searchUserNameWorker_RunWorkerCompleted);
            // 
            // groupSelectWorker
            // 
            this.groupSelectWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.groupSelectWorker_DoWork);
            this.groupSelectWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.groupSelectWorker_RunWorkerCompleted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectDomain);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Location = new System.Drawing.Point(361, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 59);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Domain";
            // 
            // selectDomain
            // 
            this.selectDomain.FormattingEnabled = true;
            this.selectDomain.Location = new System.Drawing.Point(7, 24);
            this.selectDomain.Name = "selectDomain";
            this.selectDomain.Size = new System.Drawing.Size(258, 21);
            this.selectDomain.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(602, 754);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(35, 13);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "About";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 773);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.itemMembers);
            this.Controls.Add(this.itemMemberOf);
            this.Controls.Add(this.itemProperties);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "UglyTool 1.3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox searchResultUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox SearchResultGroups;
        private System.Windows.Forms.TextBox itemProperties;
        private System.Windows.Forms.TextBox itemMemberOf;
        private System.Windows.Forms.TextBox itemMembers;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker searchGroupsWorker;
        private System.ComponentModel.BackgroundWorker searchUsersWorker;
        private System.ComponentModel.BackgroundWorker searchUserNameWorker;
        private System.Windows.Forms.PictureBox progressImage;
        private System.ComponentModel.BackgroundWorker groupSelectWorker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox selectDomain;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

