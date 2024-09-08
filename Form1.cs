using Devices;
using Diagnostic;
using Microsoft.VisualBasic.Logging;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private GroupBox currentGroupBox;
        static public Dictionary<string, (Type, Bitmap, GroupBox)> bitmapList;
        public List<IDevice> devices = new List<IDevice>();
        private object? oldSelectedItem = null;
        private string currentFile = "";
        private System.Threading.Timer timer;

        public static void onlyNumbers(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        void Form_KeyDown(object o, KeyEventArgs e)
        {
            // Ctrl + S   
            if (e.Control && e.KeyCode == Keys.S)
            {
                // Ctrl + Shift + S
                if (e.Shift)
                {
                    saveAsToolStripMenuItem_Click(new object(), new EventArgs());
                }
                else
                {
                    saveToolStripMenuItem_Click(new object(), new EventArgs());
                }
            }
        }

        private void listApllyComboBox(ComboBox comboBox, IEnumerable<IDevice> devices)
        {
            object? selectedItem = comboBox.SelectedItem;
            comboBox.Items.Clear();
            foreach (var item in devices)
                comboBox.Items.Add(item.name);
            comboBox.SelectedItem = selectedItem;
        }

        public Form1()
        {
            Loger.Message("start init main form");
            InitializeComponent();

            FormClosing += (object sender, FormClosingEventArgs e) => FileLoger.Save("logs.txt");

            KeyPreview = true;
            KeyDown += new KeyEventHandler(Form_KeyDown);

            currentGroupBox = nullDateGroupBox;
            bitmapList = new Dictionary<string, (Type, Bitmap, GroupBox)>
            {
                { Processor.type,   (typeof(Processor), new Bitmap(File.OpenRead(@"./res/processor.png")), processorGroupBox) },
                { VideoCard.type,   (typeof(VideoCard), new Bitmap(File.OpenRead(@"./res/videocard.png")), videocardGroupBox) },
                { Computer.type,    (typeof(Computer),  new Bitmap(File.OpenRead(@"./res/computer.png")),  computerGroupBox) },
                { HardDisk.type,    (typeof(HardDisk),  new Bitmap(File.OpenRead(@"./res/hard_disk.png")), harddiskGroupBox) }
            };

            deviceType.Items.Clear();
            foreach (var deviceT in bitmapList.Keys)
            {
                deviceType.Items.Add(deviceT);
                sortedComboBox.Items.Add(deviceT);
            }

            devicesListBox.DrawMode = DrawMode.OwnerDrawFixed;
            devicesListBox.DrawItem += new DrawItemEventHandler(listBox1_DrawItem);

            computerGroupBox.VisibleChanged += (object sender, EventArgs e) => listApllyComboBox(computerCPU, devices.Where((d) => d.GetType()?.GetProperty("type")?.GetValue(d)?.ToString() == Processor.type));
            computerGroupBox.VisibleChanged += (object sender, EventArgs e) => listApllyComboBox(computerGPU, devices.Where((d) => d.GetType()?.GetProperty("type")?.GetValue(d)?.ToString() == VideoCard.type));
            computerGroupBox.VisibleChanged += (object sender, EventArgs e) => listApllyComboBox(computerHDD, devices.Where((d) => d.GetType()?.GetProperty("type")?.GetValue(d)?.ToString() == HardDisk.type));
            computerCPU.DropDown += (object sender, EventArgs e) => listApllyComboBox(computerCPU, devices.Where((d) => d.GetType()?.GetProperty("type")?.GetValue(d)?.ToString() == Processor.type));
            computerGPU.DropDown += (object sender, EventArgs e) => listApllyComboBox(computerGPU, devices.Where((d) => d.GetType()?.GetProperty("type")?.GetValue(d)?.ToString() == VideoCard.type));
            computerHDD.DropDown += (object sender, EventArgs e) => listApllyComboBox(computerHDD, devices.Where((d) => d.GetType()?.GetProperty("type")?.GetValue(d)?.ToString() == HardDisk.type));

            manufacturerCPU.SelectedIndex = 0;
            manufacturerGPU.SelectedIndex = 0;
            manufacturerHDD.SelectedIndex = 0;
            typeHDD.SelectedIndex = 0;
            computerType.SelectedIndex = 0;
            deviceType.SelectedIndex = 0;
            sortedComboBox.SelectedIndex = 0;

            addDevice.Enabled = false;
            memoryL1.Enabled = false;
            memoryL2.Enabled = false;
            memoryL3.Enabled = false;

            // Processor
            coreCountCPU.KeyPress += onlyNumbers;
            frequencyCPU.KeyPress += onlyNumbers;
            maxFrequencyCPU.KeyPress += onlyNumbers;
            memoryL1.KeyPress += onlyNumbers;
            memoryL2.KeyPress += onlyNumbers;
            memoryL3.KeyPress += onlyNumbers;

            // Computer
            sizeRAM.KeyPress += onlyNumbers;
            frequencyRAM.KeyPress += onlyNumbers;

            // VideoCard
            frequencyGPU.KeyPress += onlyNumbers;
            memorySizeGPU.KeyPress += onlyNumbers;

            // HardDisk
            memorySizeHDD.KeyPress += onlyNumbers;
            speedHDD.KeyPress += onlyNumbers;

            timeLabel.Text = DateTime.Now.ToString();
            timer = new System.Threading.Timer(new TimerCallback(updateTime), null, 0, 1000);

            Loger.Message("finish init main form");
        }

        static public void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            ListBox request = (ListBox)sender;
            if (request.Items.Count == 0)
                return;

            if (e.Index < 0)
                return;

            IDevice? device = request.Items[e.Index] as IDevice;

            e.DrawBackground();
            e.DrawFocusRectangle();

            RectangleF bitmapRect = new RectangleF(0, e.Bounds.Y, 16, 16);
            Bitmap bitmap = new Bitmap(File.OpenRead(@"./res/computer.png"));
            if (device != null)
            {
                if (device.GetType()?.GetProperty("type")?.GetValue(device) is string type && bitmapList.ContainsKey(type))
                    bitmap = bitmapList[type].Item2;

                g.DrawImage(bitmap, bitmapRect);
                g.DrawString(device.name, request.Font, new SolidBrush(e.ForeColor), (float)e.Bounds.X + bitmapRect.Width, (float)e.Bounds.Y);
            }
        }

        private void deleteDevice_Click(object sender, EventArgs e)
        {
            if (devicesListBox.SelectedItem != null)
            {
                object? item = devicesListBox.SelectedItem;
                IDevice? device = item as IDevice;
                if (device != null)
                {
                    Loger.Message("delete device " + device.GetType()?.GetProperty("type")?.GetValue(device)?.ToString() + " with name \"" + device.name + "\"");
                    devices.Remove((IDevice)item);
                    devicesListBox.Items.Remove(item);
                    devicesCountLabel.Text = devices.Count.ToString();
                }
            }

            if (currentGroupBox != nullDateGroupBox)
            {
                currentGroupBox.Visible = false;
                currentGroupBox = nullDateGroupBox;
                currentGroupBox.Visible = true;
            }
        }

        private void addDevice_Click(object sender, EventArgs e)
        {
            string name = deviceName.Text;
            string type = deviceType.Text;
            IDevice? device = null;
            if (bitmapList.ContainsKey(type))
            {
                Type typeDevice = bitmapList[type].Item1;
                if (typeDevice != null)
                {
                    ConstructorInfo? constructorInfo = typeDevice.GetConstructor([typeof(string)]);
                    if (constructorInfo != null)
                    {
                        device = (IDevice)constructorInfo.Invoke([name]);
                    }
                }
            }

            deviceName.Clear();
            if (device != null)
            {
                Loger.Message("add device " + device.GetType()?.GetProperty("type")?.GetValue(device)?.ToString() + " with name \"" + device.name + "\"");
                devices.Add(device);
                devicesListBox.Items.Add(device);
                devicesCountLabel.Text = devices.Count.ToString();
            }
            else
                MessageBox.Show("Несуществующий тип добавляемого девайса");
        }

        private void devicesList_SelectedValueChanged(object sender, EventArgs e)
        {
            ListBox devicesListBox = (ListBox)sender;
            if (devicesListBox.SelectedItem == null)
            {
                currentGroupBox.Visible = false;
                currentGroupBox = nullDateGroupBox;
                currentGroupBox.Visible = true;
                return;
            }

            if (devicesListBox?.SelectedItem?.GetType()?.GetProperty("type")?.GetValue(devicesListBox.SelectedItem) is string type && bitmapList.ContainsKey(type))
            {
                if (currentGroupBox != nullDateGroupBox && oldSelectedItem != null)
                    ((IDevice)oldSelectedItem).Read(currentGroupBox);

                if (currentGroupBox != bitmapList[type].Item3)
                {
                    currentGroupBox.Visible = false;
                    currentGroupBox = bitmapList[type].Item3;
                    currentGroupBox.Visible = true;
                    Loger.Message("watch device " + type + " with name \"" + ((IDevice)devicesListBox.SelectedItem).name + "\"");
                    lastEventLabel.Text = "watch device " + type + " with name \"" + ((IDevice)devicesListBox.SelectedItem).name + "\"";
                }

                oldSelectedItem = devicesListBox.SelectedItem;
                ((IDevice)oldSelectedItem).Write(currentGroupBox);

                if (type == Processor.type)
                {
                    var results = new List<ValidationResult>();
                    var context = new ValidationContext((Processor)oldSelectedItem);
                    if (!Validator.TryValidateObject((Processor)oldSelectedItem, context, results, true))
                    {
                        Loger.Warning("current object is not valid");
                        MessageBox.Show("Серия процессора не соответствует требованиям", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                if (currentGroupBox != nullDateGroupBox)
                {
                    currentGroupBox.Visible = false;
                    currentGroupBox = nullDateGroupBox;
                    currentGroupBox.Visible = true;
                }
            }
        }

        private void deviceName_TextChanged(object sender, EventArgs e)
        {
            addDevice.Enabled = ((TextBox)sender).Text != "";
        }

        private void sortedComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sortedComboBox;

            devicesListBox.Items.Clear();
            if (bitmapList.ContainsKey(comboBox.Text))
            {
                foreach (IDevice device in devices.Where((e) => e.GetType()?.GetProperty("type")?.GetValue(e)?.ToString() == comboBox.Text).ToArray())
                    devicesListBox.Items.Add(device);
            }
            else
            {
                foreach (IDevice device in devices)
                    devicesListBox.Items.Add(device);
            }
            devicesCountLabel.Text = devicesListBox.Items.Count.ToString();
        }

        private void L1_CheckedChanged(object sender, EventArgs e)
        {
            memoryL1.Enabled = ((CheckBox)sender).Checked;
        }

        private void L2_CheckedChanged(object sender, EventArgs e)
        {
            memoryL2.Enabled = ((CheckBox)sender).Checked;
        }

        private void L3_CheckedChanged(object sender, EventArgs e)
        {
            memoryL3.Enabled = ((CheckBox)sender).Checked;
        }

        public static void Save(string fileName, List<IDevice> devices, ListBox? devicesListBox = null, GroupBox? groupBox = null)
        {
            if (devicesListBox != null && groupBox != null)
            {
                if (devicesListBox.SelectedItem != null)
                {
                    ((IDevice)devicesListBox.SelectedItem).Read(groupBox);
                }
            }

            Loger.Message("save devices in file \"" + fileName + "\"");
            try
            {
                XmlSerializeWrapper.Serialize(devices, fileName, [typeof(Processor), typeof(VideoCard), typeof(Computer), typeof(HardDisk)]);
            }
            catch
            {
                Loger.Error("error loading in file \"" + fileName + "\". May by file is bad");
                MessageBox.Show("Ошибка записи в файл \"" + fileName + "\". Возможно файл занят другим потоком", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentFile == "")
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                Save(currentFile, devices, devicesListBox, currentGroupBox);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.FileName = ".xml";
                dialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                dialog.FilterIndex = 1;
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    currentFile = dialog.FileName;
                    Save(currentFile, devices, devicesListBox, currentGroupBox);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                dialog.FilterIndex = 1;
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Loger.Message("loading devices from file \"" + dialog.FileName + "\"");
                    try
                    {
                        devices = XmlSerializeWrapper.Deserialize<List<IDevice>>(dialog.FileName, [typeof(Processor), typeof(VideoCard), typeof(Computer), typeof(HardDisk)]);
                        currentGroupBox.Visible = false;
                        currentGroupBox = nullDateGroupBox;
                        currentGroupBox.Visible = true;
                        currentFile = dialog.FileName;
                        devicesListBox.Items.Clear();
                        foreach (IDevice device in devices)
                            devicesListBox.Items.Add(device);
                        devicesCountLabel.Text = devices.Count.ToString();
                        timer = new System.Threading.Timer(new TimerCallback(updateTime), null, 0, 1000);
                    }
                    catch
                    {
                        Loger.Error("error loading in file \"" + dialog.FileName + "\". May by file hawe unreal type");
                        MessageBox.Show("Ошибка открытия файла \"" + dialog.FileName + "\". Возможно файл повреждён или не поддержуется приложением", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search(devices);
            search.FormClosing += sortedComboBox_SelectedIndexChanged;

            search.ShowDialog();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report report = new Report(devices);
            report.ShowDialog();
        }

        private void logHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogHistory logHistory = new LogHistory();
            logHistory.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            searchToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            reportToolStripMenuItem_Click(sender, e);
        }

        private void updateTime(object obj)
        {
            timeLabel.Text = DateTime.Now.ToString();
        }

        public static class XmlSerializeWrapper
        {
            public static void Serialize<T>(T obj, string filename, Type[]? types)
            {
                var formatter = new DataContractSerializer(typeof(T), types);

                using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    formatter.WriteObject(fs, obj);
                }
            }

            public static T Deserialize<T>(string filename, Type[]? types)
            {
                T obj;
                using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    var formatter = new DataContractSerializer(typeof(T), types);
                    obj = (T)formatter.ReadObject(fs);
                }

                return obj;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
