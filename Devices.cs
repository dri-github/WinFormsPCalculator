using System.Drawing;
using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

public static class ControlExtension
{
    public static Control ItemByName(this Control.ControlCollection ctrl, string name)
    {
        return ctrl[ctrl.IndexOfKey(name)];
    }
}

namespace Devices
{
    [XmlInclude(typeof(Processor))]
    [XmlInclude(typeof(VideoCard))]
    [XmlInclude(typeof(Computer))]
    [XmlInclude(typeof(HardDisk))]
    public interface IDevice
    {
        public string name { get; protected set; }
        static public string? type { get; }

        public abstract float GetCost();
        public abstract void Read(GroupBox groupBox);
        public abstract void Write(GroupBox groupBox);
    }

    [Serializable]
    [XmlRoot(Namespace = "NetW")]
    [XmlType("processor")]
    public class Processor : IDevice
    {
        public string name { get; set; }
        static public string type { get { return "Процессор"; } }

        public int manufacturer { get; set; }
        public string series { get; set; }
        [Required(AllowEmptyStrings = false)]
        [RegularExpression(@"^\d{4}[A-F]{2}$")]
        public string model { get; set; }
        public uint coreCount { get; set; }
        public uint frequency { get; set; }
        public uint maxFrequency { get; set; }
        public string architecture { get; set; }
        public CatcheL catcheL1 {  get; set; }
        public CatcheL catcheL2 {  get; set; }
        public CatcheL catcheL3 {  get; set; }

        [Serializable]
        public struct CatcheL
        {
            public bool active;
            public uint size;
        }

        private Processor() { }
        public Processor(string name)
        {
            this.name = name;
            architecture = "";
        }

        public float GetCost()
        {
            float points = (coreCount * frequency + (maxFrequency - frequency)) / 200;
            points += (catcheL1.active ? catcheL1.size : 0);
            points += (catcheL2.active ? (catcheL2.size * 1.5f) : 0);
            points += (catcheL3.active ? (catcheL3.size * 2f) : 0);
            return points;
        }

        public void Read(GroupBox groupBox)
        {
            var controls = groupBox.Controls;

            manufacturer = ((ComboBox)controls.ItemByName("manufacturerCPU")).SelectedIndex;
            series = controls.ItemByName("seriesCPU").Text;
            model = controls.ItemByName("modelCPU").Text;
            coreCount = Convert.ToUInt32(controls.ItemByName("coreCountCPU").Text);
            frequency = Convert.ToUInt32(controls.ItemByName("frequencyCPU").Text);
            maxFrequency = Convert.ToUInt32(controls.ItemByName("maxFrequencyCPU").Text);

            foreach (RadioButton rbutton in ((Panel)controls.ItemByName("panel1")).Controls)
            {
                if (rbutton.Checked == true)
                {
                    architecture = rbutton.Text;
                    break;
                }
            }

            catcheL1 = new CatcheL { active = ((CheckBox)controls.ItemByName("isMemoryL1")).Checked, size = Convert.ToUInt32(controls.ItemByName("memoryL1").Text) };
            catcheL2 = new CatcheL { active = ((CheckBox)controls.ItemByName("isMemoryL2")).Checked, size = Convert.ToUInt32(controls.ItemByName("memoryL2").Text) };
            catcheL3 = new CatcheL { active = ((CheckBox)controls.ItemByName("isMemoryL3")).Checked, size = Convert.ToUInt32(controls.ItemByName("memoryL3").Text) };
        }

        public void Write(GroupBox groupBox)
        {
            var controls = groupBox.Controls;

            ((ComboBox)controls.ItemByName("manufacturerCPU")).SelectedIndex = manufacturer;
            controls.ItemByName("seriesCPU").Text = series;
            controls.ItemByName("modelCPU").Text = model;
            controls.ItemByName("coreCountCPU").Text = coreCount.ToString();
            controls.ItemByName("frequencyCPU").Text = frequency.ToString();
            controls.ItemByName("maxFrequencyCPU").Text = maxFrequency.ToString();

            foreach (RadioButton rbutton in ((Panel)controls.ItemByName("panel1")).Controls)
            {
                if (rbutton.Text == architecture || architecture == "")
                {
                    rbutton.Checked = true;
                    break;
                }
            }

            ((CheckBox)controls.ItemByName("isMemoryL1")).Checked = catcheL1.active; controls.ItemByName("memoryL1").Text = catcheL1.size.ToString();
            ((CheckBox)controls.ItemByName("isMemoryL2")).Checked = catcheL2.active; controls.ItemByName("memoryL2").Text = catcheL2.size.ToString();
            ((CheckBox)controls.ItemByName("isMemoryL3")).Checked = catcheL3.active; controls.ItemByName("memoryL3").Text = catcheL3.size.ToString();
        }
    }

    [Serializable]
    [XmlRoot(Namespace = "NetW")]
    [XmlType("videocard")]
    public class VideoCard : IDevice
    {
        public string name { get; set; }
        static public string type { get { return "Видеокарта"; } }

        public int manufacturer { get; set; }
        public string series { get; set; }
        public string model { get; set; }
        public uint frequency { get; set; }
        public uint memorySize { get; set; }
        public bool isDirectX11 { get; set; }

        private VideoCard() { }
        public VideoCard(string name)
        {
            this.name = name;
        }

        public float GetCost()
        {
            return frequency / 10 + memorySize / 256 * 4;
        }

        public void Read(GroupBox groupBox)
        {
            var controls = groupBox.Controls;

            manufacturer = ((ComboBox)controls.ItemByName("manufacturerGPU")).SelectedIndex;
            series = controls.ItemByName("seriesGPU").Text;
            model = controls.ItemByName("modelGPU").Text;
            frequency = Convert.ToUInt32(controls.ItemByName("frequencyGPU").Text);
            memorySize = Convert.ToUInt32(controls.ItemByName("memorySizeGPU").Text);
            isDirectX11 = ((CheckBox)controls.ItemByName("directX11GPU")).Checked;
        }

        public void Write(GroupBox groupBox)
        {
            var controls = groupBox.Controls;

            ((ComboBox)controls.ItemByName("manufacturerGPU")).SelectedIndex = manufacturer;
            controls.ItemByName("seriesGPU").Text = series;
            controls.ItemByName("modelGPU").Text = model;
            controls.ItemByName("frequencyGPU").Text = frequency.ToString();
            controls.ItemByName("memorySizeGPU").Text = memorySize.ToString();
            ((CheckBox)controls.ItemByName("directX11GPU")).Checked = isDirectX11;
        }
    }

    [Serializable]
    [XmlRoot(Namespace = "NetW")]
    [XmlType("computer")]
    public class Computer : IDevice
    {
        public string name { get; set; }
        static public string type { get { return "Компьютер"; } }

        public int computerType { get; set; }
        public string? cpu { get; set; }
        public string? gpu { get; set; }
        public uint ramSize {  get; set; }
        public uint ramFrequency {  get; set; }
        public string? hdd { get; set; }
        public DateTime date { get; set; }

        private Computer() { }
        public Computer(string name)
        {
            this.name = name;
            date = new DateTime();
        }

        public float GetCost()
        {
            return ramFrequency * ramSize / 200;
        }

        public void Read(GroupBox groupBox)
        {
            var controls = groupBox.Controls;

            computerType = ((ComboBox)controls.ItemByName("computerType")).SelectedIndex;
            cpu = ((ComboBox)controls.ItemByName("computerCPU")).SelectedItem?.ToString();
            gpu = ((ComboBox)controls.ItemByName("computerGPU")).SelectedItem?.ToString();
            ramSize = Convert.ToUInt32(controls.ItemByName("sizeRAM").Text);
            ramFrequency = Convert.ToUInt32(controls.ItemByName("frequencyRAM").Text);
            hdd = ((ComboBox)controls.ItemByName("computerHDD")).SelectedItem?.ToString();
            date = ((DateTimePicker)controls.ItemByName("computerDate")).Value;
        }

        public void Write(GroupBox groupBox)
        {
            var controls = groupBox.Controls;

            ((ComboBox)controls.ItemByName("computerType")).SelectedIndex = computerType;
            ((ComboBox)controls.ItemByName("computerCPU")).SelectedItem = cpu;
            ((ComboBox)controls.ItemByName("computerGPU")).SelectedItem = gpu;
            controls.ItemByName("sizeRAM").Text = ramSize.ToString();
            controls.ItemByName("frequencyRAM").Text = ramFrequency.ToString();
            ((ComboBox)controls.ItemByName("computerHDD")).SelectedItem = hdd;
            if (date != new DateTime())
                ((DateTimePicker)controls.ItemByName("computerDate")).Value = date;
        }
    }

    [Serializable]
    [XmlRoot(Namespace = "NetW")]
    [XmlType("harddisk")]
    public class HardDisk : IDevice
    {
        public string name { get; set; }
        static public string type { get { return "Жёсткий диск"; } }

        public int manufacturer { get; set; }
        public int typeDisk { get; set; }
        public string model { get; set; }
        public int connectInterface { get; set; }
        public uint memorySize { get; set; }
        public uint speed { get; set; }

        private HardDisk() { }
        public HardDisk(string name)
        {
            this.name = name;
        }

        public float GetCost()
        {
            return memorySize * speed / 80 * (typeDisk == 1 ? 1.5f : 1);
        }

        public void Read(GroupBox groupBox)
        {
            var controls = groupBox.Controls;

            manufacturer = ((ComboBox)controls.ItemByName("manufacturerHDD")).SelectedIndex;
            typeDisk = ((ComboBox)controls.ItemByName("typeHDD")).SelectedIndex;
            model = controls.ItemByName("modelHDD").Text;
            connectInterface = ((ComboBox)controls.ItemByName("interfaceHDD")).SelectedIndex;
            memorySize = Convert.ToUInt32(controls.ItemByName("memorySizeHDD").Text);
            speed = Convert.ToUInt32(controls.ItemByName("speedHDD").Text);
        }

        public void Write(GroupBox groupBox)
        {
            var controls = groupBox.Controls;

            ((ComboBox)controls.ItemByName("manufacturerHDD")).SelectedIndex = manufacturer;
            ((ComboBox)controls.ItemByName("typeHDD")).SelectedIndex = typeDisk;
            controls.ItemByName("modelHDD").Text = model;
            ((ComboBox)controls.ItemByName("interfaceHDD")).SelectedIndex = connectInterface;
            controls.ItemByName("memorySizeHDD").Text = memorySize.ToString();
            controls.ItemByName("speedHDD").Text = speed.ToString();
        }
    }
}
