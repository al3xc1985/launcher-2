using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace launcher
{
    public partial class Setting : Form
    {
        int _charIndex = 0;
        public bool   MShouldRun = true;
        private const string Config = "FORTHEHORDE";


        readonly string _text = "░░░░░░░░░▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄░░░░░░░░\n       ▄▀░░░░░░░░░░░░▄░░░░░░░▀▄\n░░░░░░░█░░▄░░░░▄░░░░░░░░░░░░░░█░░░░░░\n       █░░░░░░░░░░░░▄█▄▄░░▄░░░█░▄▄▄\n▄▄▄▄▄░░█░░░░░░▀░░░░▀█░░▀▄░░░░░█▀▀░██░\n██▄▀██▄█░░░▄░░░░░░░██░░░░▀▀▀▀▀░░░░██\n ▀██▄▀██░░░░░░░░▀░██▀░░░░░░░░░░░░░▀██\n░░░▀████░▀░░░░▄░░░██░░░▄█░░░░▄░▄█░░██\n    ▀█░░░░▄░░░░░██░░░░▄░░░▄░░▄░░░██\n░░░░░░▄█▄░░░░░░░░░░░▀▄░░▀▀▀▀▀▀▀▀░░▄▀░\n     █▀▀█████████▀▀▀▀████████████▀\n░░░░░████▀░░███▀░░░░░░▀███░░▀██▀░░░░░\n" +
        "Meow.  \n     Tnx for playng in WoW here.\nLauncher version is " +
                Application.ProductVersion + "\nMade by Unicorn Magic and C#\n" +
                "Vote us!\n"
            + "███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀\n██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼\n██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀\n██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼\n███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄\n███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼\n██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼\n██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼\n██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼\n███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄";
        public Setting()
        {
            InitializeComponent();
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
            foreach (var page in tabControl1.TabPages.Cast<TabPage>())
            {
                page.CausesValidation = true;
                page.Validating += new CancelEventHandler(OnTabPageValidating);
            }
            tabControl1.SelectedIndexChanged += new EventHandler(tabControl1_SelectedIndexChanged);
        }

        private void Setting_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            SaveConfig(GetBytes(Config));
            Stop();
        }

        public void OnTabPageValidating(object sender, CancelEventArgs e)
        {
            var page = sender as TabPage;
            if (page == null)
                return;
             
        }
        void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabAbout)
            {
                _charIndex = 0;
                MShouldRun = true;
                richTextBox1.Text = string.Empty;
                var t = new Thread(new ThreadStart(this.TypewriteText));
                t.Start();
            }
            else
                Stop();
        }
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }


        private void TypewriteText()
        {

            label2.Text = _text.Length.ToString();
            while (MShouldRun && (_charIndex < _text.Length))
            {


                Thread.Sleep(30);
                if (!MShouldRun)
                    break;
                try {
                    richTextBox1.Invoke(new Action(() =>
                    {
                        if (_charIndex < 452) { richTextBox1.AppendText(_text.Substring(0, 451).ToString()); _charIndex = 451; }
                        if ((_charIndex < _text.Length - 1) & (_charIndex > _text.Length - 377)) { richTextBox1.AppendText(_text.Substring(_text.Length - 377, 377).ToString()); ; _charIndex = _text.Length - 1; }
                        richTextBox1.AppendText(_text[_charIndex].ToString());
                    }));
                }
                catch { break; }
                _charIndex++;
            }
            
        }
        public void Stop()
        {
            MShouldRun = false;
            //thread.Join();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text,
                e.Index == tabControl1.SelectedIndex ? new Font(tabControl1.Font, FontStyle.Bold) : tabControl1.Font,
                Brushes.Black,
                new PointF(e.Bounds.X + 3, e.Bounds.Y + 3));
        }

        protected bool SaveConfig( byte[] Data, string FileName = "config.bin", bool Default = false )
        {
            try
            {
                // Create a new stream to write to the file
                var writer = new BinaryWriter(File.OpenWrite(FileName));

                // Writer raw data                
                writer.Write(Data);
                writer.Flush();
                writer.Close();
            }
            catch
            {
                //...
                return false;
            }

            return true;
        }
        static byte[] GetBytes(string str)
        {
            var bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        static string GetString(byte[] bytes)
        {
            var chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }
        private void Setting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var login = new Login();
            login.Show();
        }
    }
}
