using Devices;
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
    public partial class Report : Form
    {
        private List<IDevice> devices;
        public Report(List<IDevice> devices)
        {
            Loger.Message("open Report form");
            this.devices = devices;
            InitializeComponent();

            devicesListBox.DrawMode = DrawMode.OwnerDrawFixed;
            devicesListBox.DrawItem += Form1.listBox1_DrawItem;
            foreach (IDevice device in devices.Where((d) => d.GetType()?.GetProperty("type")?.GetValue(d)?.ToString() == Computer.type))
            {
                devicesListBox.Items.Add(device);
            }
        }

        private void devicesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            if (listBox == null)
                return;

            Computer computer = (Computer)listBox.SelectedItem;
            if (computer == null)
                return;

            float cost = computer.GetCost();
            cost += devices.First((d) => d.name == computer.cpu).GetCost();
            cost += devices.First((d) => d.name == computer.gpu).GetCost();
            cost += devices.First((d) => d.name == computer.hdd).GetCost();
            costLabel.Text = cost.ToString() + "$";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
