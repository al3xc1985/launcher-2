namespace launcher
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.butPlay = new System.Windows.Forms.Button();
            this.butMin = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.butSetup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.APItext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(12, 78);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(776, 424);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://superwow.ru/launcher", System.UriKind.Absolute);
            this.webBrowser1.Visible = false;
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.NewWindow += new System.ComponentModel.CancelEventHandler(this.webBrowser1_NewWindow);
            // 
            // butPlay
            // 
            this.butPlay.BackColor = System.Drawing.Color.Transparent;
            this.butPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butPlay.FlatAppearance.BorderSize = 0;
            this.butPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butPlay.Location = new System.Drawing.Point(566, 533);
            this.butPlay.Name = "butPlay";
            this.butPlay.Size = new System.Drawing.Size(222, 60);
            this.butPlay.TabIndex = 1;
            this.butPlay.UseVisualStyleBackColor = false;
            this.butPlay.Visible = false;
            this.butPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // butMin
            // 
            this.butMin.BackColor = System.Drawing.Color.Transparent;
            this.butMin.FlatAppearance.BorderSize = 0;
            this.butMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMin.Location = new System.Drawing.Point(713, 19);
            this.butMin.Name = "butMin";
            this.butMin.Size = new System.Drawing.Size(37, 38);
            this.butMin.TabIndex = 3;
            this.butMin.UseVisualStyleBackColor = false;
            this.butMin.Visible = false;
            this.butMin.Click += new System.EventHandler(this.butMin_Click);
            // 
            // butClose
            // 
            this.butClose.BackColor = System.Drawing.Color.Transparent;
            this.butClose.FlatAppearance.BorderSize = 0;
            this.butClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butClose.Location = new System.Drawing.Point(750, 19);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(37, 38);
            this.butClose.TabIndex = 4;
            this.butClose.UseVisualStyleBackColor = false;
            this.butClose.Visible = false;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // butSetup
            // 
            this.butSetup.BackColor = System.Drawing.Color.Transparent;
            this.butSetup.FlatAppearance.BorderSize = 0;
            this.butSetup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butSetup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSetup.Location = new System.Drawing.Point(676, 19);
            this.butSetup.Name = "butSetup";
            this.butSetup.Size = new System.Drawing.Size(37, 38);
            this.butSetup.TabIndex = 5;
            this.butSetup.UseVisualStyleBackColor = false;
            this.butSetup.Click += new System.EventHandler(this.butSetup_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 38);
            this.label1.TabIndex = 2;
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "SuperWoW Launcher";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.linkLabel1.Location = new System.Drawing.Point(12, 533);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(548, 58);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 300000;
            this.updateTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(775, 66);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wait... Load news!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // APItext
            // 
            this.APItext.AutoSize = true;
            this.APItext.Location = new System.Drawing.Point(362, 19);
            this.APItext.Name = "APItext";
            this.APItext.Size = new System.Drawing.Size(75, 13);
            this.APItext.TabIndex = 8;
            this.APItext.Text = "CLIENT_EXIT";
            this.APItext.Visible = false;
            this.APItext.TextChanged += new System.EventHandler(this.APItext_TextChanged);
            this.APItext.Click += new System.EventHandler(this.APItext_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::launcher.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.APItext);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.butMin);
            this.Controls.Add(this.butSetup);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butPlay);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperWoW Launcher";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button butPlay;
        private System.Windows.Forms.Button butMin;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Button butSetup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label APItext;
    }
}

