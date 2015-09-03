using System;
using System.IO;
using System.Windows.Forms;

namespace launcher
{
    public partial class Realmlist : Form
    {
        public Realmlist()
        {
            InitializeComponent();
        }

        private void Dialog1_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists("realmlist.old"))
            {
                File.Delete("realmlist.old");
            }
            File.Move("realmlist.wtf", "realmlist.old");
            File.WriteAllText("realmlist.wtf", "set realmlist wow.superwow.ru");
            //Form1.label.Text = "Realmlist superwow.ru setup";
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
