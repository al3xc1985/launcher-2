using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace l.updater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = ExecutingHash.GetExecutingFileHash();
        }
        internal static class ExecutingHash
        {
            public static string GetExecutingFileHash()
            {
                return XXH(GetSelfBytes());
            }

            private static string XXH(string input)
            {

                byte[] originalBytes = ASCIIEncoding.Default.GetBytes(input);
                uint encodedBytes = xxHashSharp.xxHash.CalculateHash(originalBytes);

                return encodedBytes.ToString();
            }

            private static string GetSelfBytes()
            {
                string path = Application.ExecutablePath;

                FileStream running = File.OpenRead(path);

                byte[] exeBytes = new byte[running.Length];
                running.Read(exeBytes, 0, exeBytes.Length);

                running.Close();

                return exeBytes.ToString();
            }
        }
    }
}
