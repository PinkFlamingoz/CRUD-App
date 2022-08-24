namespace CRUD_App.View
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelSubTitle = new System.Windows.Forms.Label();
            this.iconPictureBoxTitle = new FontAwesome.Sharp.IconPictureBox();
            this.iconButtonMenuOpenClose = new FontAwesome.Sharp.IconButton();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButtonExit = new FontAwesome.Sharp.IconButton();
            this.iconButtonFindMe = new FontAwesome.Sharp.IconButton();
            this.iconButtonAnimals = new FontAwesome.Sharp.IconButton();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxTitle)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.panelTitle.Controls.Add(this.labelSubTitle);
            this.panelTitle.Controls.Add(this.iconPictureBoxTitle);
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(241, 95);
            this.panelTitle.TabIndex = 0;
            // 
            // labelSubTitle
            // 
            this.labelSubTitle.AutoSize = true;
            this.labelSubTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelSubTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.labelSubTitle.ForeColor = System.Drawing.Color.Coral;
            this.labelSubTitle.Location = new System.Drawing.Point(88, 49);
            this.labelSubTitle.Name = "labelSubTitle";
            this.labelSubTitle.Size = new System.Drawing.Size(146, 30);
            this.labelSubTitle.TabIndex = 7;
            this.labelSubTitle.Text = "A place with ❤️ and Care \r\nfor Animals!";
            this.labelSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconPictureBoxTitle
            // 
            this.iconPictureBoxTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.iconPictureBoxTitle.IconChar = FontAwesome.Sharp.IconChar.ShieldCat;
            this.iconPictureBoxTitle.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxTitle.IconSize = 70;
            this.iconPictureBoxTitle.Location = new System.Drawing.Point(12, 12);
            this.iconPictureBoxTitle.Name = "iconPictureBoxTitle";
            this.iconPictureBoxTitle.Size = new System.Drawing.Size(70, 70);
            this.iconPictureBoxTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBoxTitle.TabIndex = 6;
            this.iconPictureBoxTitle.TabStop = false;
            // 
            // iconButtonMenuOpenClose
            // 
            this.iconButtonMenuOpenClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonMenuOpenClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonMenuOpenClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.iconButtonMenuOpenClose.FlatAppearance.BorderSize = 0;
            this.iconButtonMenuOpenClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMenuOpenClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.iconButtonMenuOpenClose.ForeColor = System.Drawing.Color.White;
            this.iconButtonMenuOpenClose.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.iconButtonMenuOpenClose.IconColor = System.Drawing.Color.White;
            this.iconButtonMenuOpenClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMenuOpenClose.IconSize = 30;
            this.iconButtonMenuOpenClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMenuOpenClose.Location = new System.Drawing.Point(0, 95);
            this.iconButtonMenuOpenClose.Name = "iconButtonMenuOpenClose";
            this.iconButtonMenuOpenClose.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButtonMenuOpenClose.Size = new System.Drawing.Size(241, 48);
            this.iconButtonMenuOpenClose.TabIndex = 5;
            this.iconButtonMenuOpenClose.Tag = "Menu";
            this.iconButtonMenuOpenClose.Text = "   Menu";
            this.iconButtonMenuOpenClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMenuOpenClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMenuOpenClose.UseVisualStyleBackColor = true;
            this.iconButtonMenuOpenClose.Click += new System.EventHandler(this.iconButtonMenuOpenClose_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(207)))), ((int)(((byte)(180)))));
            this.labelTitle.Location = new System.Drawing.Point(80, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(161, 37);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Cat A Log";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.panelMenu.Controls.Add(this.iconButtonFindMe);
            this.panelMenu.Controls.Add(this.iconButtonAnimals);
            this.panelMenu.Controls.Add(this.iconButtonExit);
            this.panelMenu.Controls.Add(this.iconButtonMenuOpenClose);
            this.panelMenu.Controls.Add(this.panelTitle);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(241, 516);
            this.panelMenu.TabIndex = 2;
            // 
            // iconButtonExit
            // 
            this.iconButtonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonExit.FlatAppearance.BorderSize = 0;
            this.iconButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.iconButtonExit.ForeColor = System.Drawing.Color.White;
            this.iconButtonExit.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
            this.iconButtonExit.IconColor = System.Drawing.Color.White;
            this.iconButtonExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonExit.IconSize = 30;
            this.iconButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonExit.Location = new System.Drawing.Point(0, 468);
            this.iconButtonExit.Name = "iconButtonExit";
            this.iconButtonExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 15);
            this.iconButtonExit.Size = new System.Drawing.Size(241, 48);
            this.iconButtonExit.TabIndex = 5;
            this.iconButtonExit.Tag = "Exit";
            this.iconButtonExit.Text = "   Exit";
            this.iconButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonExit.UseVisualStyleBackColor = true;
            this.iconButtonExit.Click += new System.EventHandler(this.iconButtonExit_Click);
            // 
            // iconButtonFindMe
            // 
            this.iconButtonFindMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonFindMe.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonFindMe.FlatAppearance.BorderSize = 0;
            this.iconButtonFindMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonFindMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.iconButtonFindMe.ForeColor = System.Drawing.Color.White;
            this.iconButtonFindMe.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassLocation;
            this.iconButtonFindMe.IconColor = System.Drawing.Color.White;
            this.iconButtonFindMe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonFindMe.IconSize = 30;
            this.iconButtonFindMe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonFindMe.Location = new System.Drawing.Point(0, 191);
            this.iconButtonFindMe.Name = "iconButtonFindMe";
            this.iconButtonFindMe.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButtonFindMe.Size = new System.Drawing.Size(241, 48);
            this.iconButtonFindMe.TabIndex = 4;
            this.iconButtonFindMe.Tag = "Find Me";
            this.iconButtonFindMe.Text = "   Find Me";
            this.iconButtonFindMe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonFindMe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonFindMe.UseVisualStyleBackColor = true;
            this.iconButtonFindMe.Click += new System.EventHandler(this.iconButtonFindMe_Click);
            // 
            // iconButtonAnimals
            // 
            this.iconButtonAnimals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonAnimals.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonAnimals.FlatAppearance.BorderSize = 0;
            this.iconButtonAnimals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.iconButtonAnimals.ForeColor = System.Drawing.Color.White;
            this.iconButtonAnimals.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.iconButtonAnimals.IconColor = System.Drawing.Color.White;
            this.iconButtonAnimals.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAnimals.IconSize = 30;
            this.iconButtonAnimals.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAnimals.Location = new System.Drawing.Point(0, 143);
            this.iconButtonAnimals.Name = "iconButtonAnimals";
            this.iconButtonAnimals.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButtonAnimals.Size = new System.Drawing.Size(241, 48);
            this.iconButtonAnimals.TabIndex = 3;
            this.iconButtonAnimals.Tag = "Animals";
            this.iconButtonAnimals.Text = "   Animals";
            this.iconButtonAnimals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAnimals.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAnimals.UseVisualStyleBackColor = true;
            this.iconButtonAnimals.Click += new System.EventHandler(this.iconButtonAnimals_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 516);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainView";
            this.Text = "Cat A Log";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxTitle)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label labelTitle;
        private FontAwesome.Sharp.IconButton iconButtonFindMe;
        private FontAwesome.Sharp.IconButton iconButtonAnimals;
        private FontAwesome.Sharp.IconButton iconButtonExit;
        private FontAwesome.Sharp.IconButton iconButtonMenuOpenClose;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxTitle;
        private System.Windows.Forms.Label labelSubTitle;
    }
}