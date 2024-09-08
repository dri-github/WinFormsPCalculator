using Devices;
using Diagnostic;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Search : Form
    {
        private List<IDevice> devices = new List<IDevice>();

        public Search(List<IDevice> devices)
        {
            Loger.Message("open Search form");
            this.devices = devices;
            InitializeComponent();

            typeSearchBox.SelectedIndex = 0;
            searchedDevicesBox.DrawMode = DrawMode.OwnerDrawFixed;
            searchedDevicesBox.DrawItem += new DrawItemEventHandler(Form1.listBox1_DrawItem);
        }

        private void eraseButton_Click(object sender, EventArgs e)
        {
            IDevice? device = searchedDevicesBox.SelectedItem as IDevice;
            if (device != null)
            {
                searchedDevicesBox.Items.Remove(device);
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            devices.Clear();
            foreach (IDevice device in searchedDevicesBox.Items)
            {
                devices.Add(device);
            }
            Loger.Message("apply sorted devices in main form");
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.FileName = ".xml";
                dialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                dialog.FilterIndex = 1;
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Form1.Save(dialog.FileName, searchedDevicesBox.Items.Cast<IDevice>().ToList());
                }
            }
            Loger.Message("saved sorted devices");
            Close();
        }

        private void sortBy<T>(ref List<IDevice> sortedList, Func<T, T, bool> sortedFunction) where T : class
        {
            int i = 0;
            while (++i < sortedList.Count)
            {
                T? first = sortedList[i - 1] as T;
                T? second = sortedList[i] as T;
                if (second == null)
                {
                    int j = i;
                    while (j < sortedList.Count && sortedList[(++j) < sortedList.Count ? j : 0] as Processor == null) ;
                    if (j >= sortedList.Count)
                        break;
                    (sortedList[j], sortedList[i]) = (sortedList[i], sortedList[j]);
                    i = 0;
                    continue;
                }

                if (first == null)
                    break;

                if (sortedFunction(first, second))
                {
                    (sortedList[i - 1], sortedList[i]) = (sortedList[i], sortedList[i - 1]);
                    i = 0;
                }
            }
        }

        private void checkProcessor_CheckedChanged(object sender, EventArgs e)
        {
            searchBox_TextChanged(null, null);
        }

        private void checkRAM_CheckedChanged(object sender, EventArgs e)
        {
            searchBox_TextChanged(null, null);
        }

        private float identifyValue(string text, string search)
        {
            float value = 0;
            int range = 0;
            int lenght = Math.Min(text.Length, search.Length);
            for (int i = 0; i < lenght; i++)
            {
                if (text[i] == search[i])
                {
                    range++;
                }
                else
                {
                    value += range / lenght;
                    range = 0;
                }
            }
            if (range > 0)
            {
                value += range / lenght;
            }

            return value;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            searchedDevicesBox.Items.Clear();
            List<IDevice> sortedList = new List<IDevice>();
            switch (typeSearchBox.Text)
            {
                case "Имя":
                    sortedList = devices.Where((i) => identifyValue(i.name.ToLower(), searchBox.Text.ToLower()) > 0.5f).ToList();
                    break;
                case "Производитель":
                    sortedList = devices.Where((i) => i as Processor != null && identifyValue(((Processor)i).manufacturer == 1 ? "AMD" : "Intel", searchBox.Text) > 0.5f).Cast<IDevice>().ToList();
                    break;
                case "Модель":
                    sortedList = devices.Where((i) => i as Processor != null && identifyValue(((Processor)i).model, searchBox.Text) > 0.5f).Cast<IDevice>().ToList();
                    break;
            }

            if (checkProcessor.Checked)
                sortBy<Processor>(ref sortedList, (first, second) => second.frequency > first.frequency);
            else if (checkRAM.Checked)
                sortBy<Computer>(ref sortedList, (first, second) => second.ramSize > first.ramSize);

            foreach (IDevice device in sortedList)
                searchedDevicesBox.Items.Add(device);
        }

        private void typeSearchBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchBox_TextChanged(null, null);
        }
    }
}
