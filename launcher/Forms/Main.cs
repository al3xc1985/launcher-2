using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;
using launcher.Server;

namespace launcher
{

    public partial class Main : Form
    {
        private static Main _instance;
        public static Main Instance => _instance;
        public string HtmlCode;
        public bool ClientRun = false;
        const int WsMinimizebox = 0x20000;
        const int CsDblclks = 0x8;

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.Style |= WsMinimizebox;
                cp.ClassStyle |= CsDblclks;
                return cp;
            }
        }
        public Main()
        {
            
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            _instance = this;
            UpdateStyles();

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            if (webBrowser1.DocumentTitle.Contains("superwow"))
            {
                webBrowser1.Show();
            }
            else
            {
                label2.Text = "Ops, error. \nIt is not possible to connect to the news server. \n Please check the efficiency of your network and try again later.";
                label2.Visible = true;
            }

    }



        private void Form1_Load(object sender, EventArgs e)
        {
            var sa = new ServerApi();
            sa.Start();

            if (File.Exists("wow.exe") & Directory.Exists("Data"))
            {
                if (File.Exists("realmlist.wtf"))
                {
                    if ((File.ReadAllText("realmlist.wtf") == "set realmlist wow.superwow.ru") | (File.ReadAllText("realmlist.wtf") == "set realmlist 212.12.14.82"))
                    {
                        linkLabel1.Text = "All ok! GL HF!";
                    }
                    else
                    {
                        linkLabel1.Text = "Wrong realmlist";
                        butPlay.Enabled = false;
                        var r1 = new Realmlist();
                        r1.Show(); // Shows Dialog1
                     }
                }
                else
                {
                    File.WriteAllText("realmlist.wtf", "set realmlist wow.superwow.ru");
                    butPlay.Enabled = true;
                    linkLabel1.Text = "Realmlist superwow.ru setup";
                }
            }
            else
            {
                linkLabel1.Text = "This no game directory :-(";
                butSetup.Enabled = false;
                butPlay.Enabled = false;
            }
        


            try
            {
                using (var client = new WebClient())
                {
                    HtmlCode = linkLabel1.Text + "\n" + client.DownloadString("http://superwow.ru/launcher/component.php");
                    HtmlCode = HtmlCode + "\n" + "Server latency " + ServerStatus.PingHost("wow.superwow.ru");
                }
            }
            catch
            {
                HtmlCode = linkLabel1.Text + "\n" + "Server Offline";

            }
            linkLabel1.Text = HtmlCode;
            butClose.Visible = true;
            butMin.Visible = true;
            butSetup.Visible = true;
            butPlay.Visible = true;
            label1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartGame();

        }

        public void StartGame()
        {
            APItext.Text = "CLIENT_RUN";
            linkLabel1.Text = "Game run";
            butClose.Enabled = false;
            butSetup.Enabled = false;
            butPlay.Enabled = false;
            WindowState = FormWindowState.Minimized;

            var myProcess = new Process
            {
                StartInfo =
                {
                    FileName = "wow.exe",
                    WindowStyle = ProcessWindowStyle.Normal
                },
                EnableRaisingEvents = true
            };

            // Start a process to print a file and raise an event when done.
            myProcess.Exited += myProcess_Exited;
            myProcess.Start();
         
        }


        // Handle Exited event and display process information. 
        public void myProcess_Exited(object sender, EventArgs e)
        {
            APItext.Text = "CLIENT_EXIT";
            WindowState = FormWindowState.Normal;
            Activate();
            linkLabel1.Text = "Game quit";
            butClose.Enabled = true;
            butSetup.Enabled = true;
            butPlay.Enabled = true;
        }


        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        public const int WmNclbuttondown = 0xA1;
        public const int HtCaption = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            ReleaseCapture();
            SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void butMin_Click(object sender, EventArgs e)
        {
            updateTimer.Stop();
            WindowState = FormWindowState.Minimized;
        }


        private void webBrowser1_NewWindow(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var webbrowser = (WebBrowser)sender;
            e.Cancel = true;
            Process.Start(webbrowser.StatusText);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start("https://superwow.ru/");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                using (var client = new WebClient())
                {
                    HtmlCode = client.DownloadString("https://superwow.ru/launcher/component.php");
                    HtmlCode = HtmlCode + "\n" + "Server latency " + ServerStatus.PingHost("wow.superwow.ru");
                }
            }
            catch
            {
                HtmlCode = "Server Offline";

            }
            linkLabel1.Text = HtmlCode;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            updateTimer.Enabled=true;
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            updateTimer.Enabled=false;

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Visible)
            {
                ShowInTaskbar = false;
                Hide();
            }
            else
            {
                ShowInTaskbar = true;
                Show();
            }
        }
        public void KillNotyfy()
        {
            //Cleanup so that the icon will be removed when the application is closed
  //          notifyIcon1.Visible = false;
        }


        private void butSetup_Click(object sender, EventArgs e)
        {
            var s1 = new Setting();
            s1.Show();

        }

      public string _APIupdate(string message)
        {

            if (message == "CLIENT_START") { StartGame(); return "CLIENT_RUN"; }
            //Thread.Sleep(50);
            message = APItext.Text;
            return message;
        }

        private void APItext_TextChanged(object sender, EventArgs e)
        {

        }

        private void APItext_Click(object sender, EventArgs e)
        {

        }
    }
}

