using Diagnostic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class LogHistory : Form
    {
        public LogHistory()
        {
            InitializeComponent();

            logListText.Text = "";
            foreach (Loger.Log log in Loger.logs)
                logListText.Text += (log.ToString() + "\r\n");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Loger.logs.Clear();
            logListText.Text = "";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            FileLoger.Save("logs.txt");
            Close();
        }
    }
}
