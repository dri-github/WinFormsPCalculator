namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            deleteDevice = new Button();
            groupBox1 = new GroupBox();
            label40 = new Label();
            sortedComboBox = new ComboBox();
            devicesListBox = new ListBox();
            deviceName = new TextBox();
            addDevice = new Button();
            deviceType = new ComboBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            processorGroupBox = new GroupBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            memoryL3 = new TextBox();
            isMemoryL3 = new CheckBox();
            memoryL2 = new TextBox();
            isMemoryL2 = new CheckBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            manufacturerCPU = new ComboBox();
            label3 = new Label();
            memoryL1 = new TextBox();
            isMemoryL1 = new CheckBox();
            panel1 = new Panel();
            x64RadioButton = new RadioButton();
            x32RadioButton = new RadioButton();
            RISCRadioButton = new RadioButton();
            maxFrequencyCPU = new TextBox();
            frequencyCPU = new TextBox();
            coreCountCPU = new TextBox();
            modelCPU = new TextBox();
            seriesCPU = new TextBox();
            computerGroupBox = new GroupBox();
            label39 = new Label();
            label38 = new Label();
            sizeRAM = new TextBox();
            label34 = new Label();
            frequencyRAM = new TextBox();
            label16 = new Label();
            computerDate = new DateTimePicker();
            computerHDD = new ComboBox();
            computerGPU = new ComboBox();
            computerCPU = new ComboBox();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            computerType = new ComboBox();
            label26 = new Label();
            videocardGroupBox = new GroupBox();
            label17 = new Label();
            label19 = new Label();
            memorySizeGPU = new TextBox();
            directX11GPU = new CheckBox();
            label18 = new Label();
            label28 = new Label();
            label30 = new Label();
            label31 = new Label();
            manufacturerGPU = new ComboBox();
            label32 = new Label();
            frequencyGPU = new TextBox();
            modelGPU = new TextBox();
            seriesGPU = new TextBox();
            harddiskGroupBox = new GroupBox();
            interfaceHDD = new ComboBox();
            label37 = new Label();
            typeHDD = new ComboBox();
            label36 = new Label();
            label20 = new Label();
            label21 = new Label();
            memorySizeHDD = new TextBox();
            label27 = new Label();
            label29 = new Label();
            label33 = new Label();
            manufacturerHDD = new ComboBox();
            label35 = new Label();
            speedHDD = new TextBox();
            modelHDD = new TextBox();
            nullDateGroupBox = new GroupBox();
            label14 = new Label();
            label15 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            projectToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            reportToolStripMenuItem = new ToolStripMenuItem();
            logHistoryToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton3 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripContainer1 = new ToolStripContainer();
            statusStrip1 = new StatusStrip();
            lastEventLabel = new ToolStripStatusLabel();
            devicesCountLabel = new ToolStripStatusLabel();
            timeLabel = new ToolStripStatusLabel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            processorGroupBox.SuspendLayout();
            panel1.SuspendLayout();
            computerGroupBox.SuspendLayout();
            videocardGroupBox.SuspendLayout();
            harddiskGroupBox.SuspendLayout();
            nullDateGroupBox.SuspendLayout();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // deleteDevice
            // 
            deleteDevice.Location = new Point(77, 382);
            deleteDevice.Name = "deleteDevice";
            deleteDevice.Size = new Size(75, 23);
            deleteDevice.TabIndex = 1;
            deleteDevice.Text = "Удалить";
            deleteDevice.UseVisualStyleBackColor = true;
            deleteDevice.Click += deleteDevice_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label40);
            groupBox1.Controls.Add(sortedComboBox);
            groupBox1.Controls.Add(devicesListBox);
            groupBox1.Controls.Add(deleteDevice);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 411);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Список девайсов";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(28, 25);
            label40.Name = "label40";
            label40.Size = new Size(107, 15);
            label40.TabIndex = 8;
            label40.Text = "Отсортировать по";
            label40.TextAlign = ContentAlignment.TopRight;
            // 
            // sortedComboBox
            // 
            sortedComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            sortedComboBox.FormattingEnabled = true;
            sortedComboBox.Items.AddRange(new object[] { "Все" });
            sortedComboBox.Location = new Point(142, 22);
            sortedComboBox.Name = "sortedComboBox";
            sortedComboBox.Size = new Size(97, 23);
            sortedComboBox.TabIndex = 5;
            sortedComboBox.Tag = "";
            sortedComboBox.SelectedIndexChanged += sortedComboBox_SelectedIndexChanged;
            // 
            // devicesListBox
            // 
            devicesListBox.FormattingEnabled = true;
            devicesListBox.HorizontalScrollbar = true;
            devicesListBox.ItemHeight = 15;
            devicesListBox.Location = new Point(6, 52);
            devicesListBox.Name = "devicesListBox";
            devicesListBox.Size = new Size(233, 319);
            devicesListBox.TabIndex = 2;
            devicesListBox.SelectedValueChanged += devicesList_SelectedValueChanged;
            // 
            // deviceName
            // 
            deviceName.Location = new Point(55, 22);
            deviceName.Name = "deviceName";
            deviceName.Size = new Size(178, 23);
            deviceName.TabIndex = 2;
            deviceName.TextChanged += deviceName_TextChanged;
            // 
            // addDevice
            // 
            addDevice.Location = new Point(158, 50);
            addDevice.Name = "addDevice";
            addDevice.Size = new Size(75, 23);
            addDevice.TabIndex = 3;
            addDevice.Text = "Добавить";
            addDevice.UseVisualStyleBackColor = true;
            addDevice.Click += addDevice_Click;
            // 
            // deviceType
            // 
            deviceType.DisplayMember = "0";
            deviceType.DropDownStyle = ComboBoxStyle.DropDownList;
            deviceType.FormattingEnabled = true;
            deviceType.Location = new Point(55, 51);
            deviceType.Name = "deviceType";
            deviceType.Size = new Size(97, 23);
            deviceType.TabIndex = 4;
            deviceType.Tag = "";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(deviceName);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(addDevice);
            groupBox2.Controls.Add(deviceType);
            groupBox2.Location = new Point(254, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(245, 87);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Добавить новый девайс";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 7;
            label2.Text = "Тип";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 6;
            label1.Text = "Имя";
            // 
            // processorGroupBox
            // 
            processorGroupBox.Controls.Add(label13);
            processorGroupBox.Controls.Add(label12);
            processorGroupBox.Controls.Add(label11);
            processorGroupBox.Controls.Add(label10);
            processorGroupBox.Controls.Add(label9);
            processorGroupBox.Controls.Add(memoryL3);
            processorGroupBox.Controls.Add(isMemoryL3);
            processorGroupBox.Controls.Add(memoryL2);
            processorGroupBox.Controls.Add(isMemoryL2);
            processorGroupBox.Controls.Add(label8);
            processorGroupBox.Controls.Add(label7);
            processorGroupBox.Controls.Add(label6);
            processorGroupBox.Controls.Add(label5);
            processorGroupBox.Controls.Add(label4);
            processorGroupBox.Controls.Add(manufacturerCPU);
            processorGroupBox.Controls.Add(label3);
            processorGroupBox.Controls.Add(memoryL1);
            processorGroupBox.Controls.Add(isMemoryL1);
            processorGroupBox.Controls.Add(panel1);
            processorGroupBox.Controls.Add(maxFrequencyCPU);
            processorGroupBox.Controls.Add(frequencyCPU);
            processorGroupBox.Controls.Add(coreCountCPU);
            processorGroupBox.Controls.Add(modelCPU);
            processorGroupBox.Controls.Add(seriesCPU);
            processorGroupBox.Location = new Point(254, 96);
            processorGroupBox.Name = "processorGroupBox";
            processorGroupBox.Size = new Size(245, 318);
            processorGroupBox.TabIndex = 6;
            processorGroupBox.TabStop = false;
            processorGroupBox.Text = "Значения";
            processorGroupBox.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(199, 170);
            label13.Name = "label13";
            label13.Size = new Size(31, 15);
            label13.TabIndex = 30;
            label13.Text = "МГц";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(199, 141);
            label12.Name = "label12";
            label12.Size = new Size(31, 15);
            label12.TabIndex = 29;
            label12.Text = "МГц";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(199, 293);
            label11.Name = "label11";
            label11.Size = new Size(25, 15);
            label11.TabIndex = 28;
            label11.Text = "МБ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(199, 263);
            label10.Name = "label10";
            label10.Size = new Size(25, 15);
            label10.TabIndex = 27;
            label10.Text = "МБ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(199, 232);
            label9.Name = "label9";
            label9.Size = new Size(25, 15);
            label9.TabIndex = 26;
            label9.Text = "МБ";
            // 
            // memoryL3
            // 
            memoryL3.Location = new Point(80, 287);
            memoryL3.Name = "memoryL3";
            memoryL3.Size = new Size(113, 23);
            memoryL3.TabIndex = 25;
            memoryL3.TextAlign = HorizontalAlignment.Right;
            // 
            // isMemoryL3
            // 
            isMemoryL3.AutoSize = true;
            isMemoryL3.Location = new Point(9, 289);
            isMemoryL3.Name = "isMemoryL3";
            isMemoryL3.RightToLeft = RightToLeft.Yes;
            isMemoryL3.Size = new Size(65, 19);
            isMemoryL3.TabIndex = 24;
            isMemoryL3.Text = "Кэш L3";
            isMemoryL3.UseVisualStyleBackColor = true;
            isMemoryL3.CheckedChanged += L3_CheckedChanged;
            // 
            // memoryL2
            // 
            memoryL2.Location = new Point(80, 258);
            memoryL2.Name = "memoryL2";
            memoryL2.Size = new Size(113, 23);
            memoryL2.TabIndex = 23;
            memoryL2.TextAlign = HorizontalAlignment.Right;
            // 
            // isMemoryL2
            // 
            isMemoryL2.AutoSize = true;
            isMemoryL2.Location = new Point(9, 260);
            isMemoryL2.Name = "isMemoryL2";
            isMemoryL2.RightToLeft = RightToLeft.Yes;
            isMemoryL2.Size = new Size(65, 19);
            isMemoryL2.TabIndex = 22;
            isMemoryL2.Text = "Кэш L2";
            isMemoryL2.UseVisualStyleBackColor = true;
            isMemoryL2.CheckedChanged += L2_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 170);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 21;
            label8.Text = "Макс. частота";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 141);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 20;
            label7.Text = "Частота";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 112);
            label6.Name = "label6";
            label6.Size = new Size(100, 15);
            label6.TabIndex = 19;
            label6.Text = "Количество ядер";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 83);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 18;
            label5.Text = "Модель";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 54);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 17;
            label4.Text = "Серия";
            // 
            // manufacturerCPU
            // 
            manufacturerCPU.DropDownStyle = ComboBoxStyle.DropDownList;
            manufacturerCPU.FormattingEnabled = true;
            manufacturerCPU.Items.AddRange(new object[] { "Intel", "AMD" });
            manufacturerCPU.Location = new Point(133, 22);
            manufacturerCPU.Name = "manufacturerCPU";
            manufacturerCPU.Size = new Size(100, 23);
            manufacturerCPU.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 25);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 15;
            label3.Text = "Производитель";
            // 
            // memoryL1
            // 
            memoryL1.Location = new Point(80, 229);
            memoryL1.Name = "memoryL1";
            memoryL1.Size = new Size(113, 23);
            memoryL1.TabIndex = 14;
            memoryL1.TextAlign = HorizontalAlignment.Right;
            // 
            // isMemoryL1
            // 
            isMemoryL1.AutoSize = true;
            isMemoryL1.Location = new Point(9, 231);
            isMemoryL1.Name = "isMemoryL1";
            isMemoryL1.RightToLeft = RightToLeft.Yes;
            isMemoryL1.Size = new Size(65, 19);
            isMemoryL1.TabIndex = 13;
            isMemoryL1.Text = "Кэш L1";
            isMemoryL1.UseVisualStyleBackColor = true;
            isMemoryL1.CheckedChanged += L1_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(x64RadioButton);
            panel1.Controls.Add(x32RadioButton);
            panel1.Controls.Add(RISCRadioButton);
            panel1.Location = new Point(80, 196);
            panel1.Name = "panel1";
            panel1.Size = new Size(153, 27);
            panel1.TabIndex = 8;
            // 
            // x64RadioButton
            // 
            x64RadioButton.AutoSize = true;
            x64RadioButton.Location = new Point(107, 3);
            x64RadioButton.Name = "x64RadioButton";
            x64RadioButton.Size = new Size(43, 19);
            x64RadioButton.TabIndex = 16;
            x64RadioButton.TabStop = true;
            x64RadioButton.Text = "x64";
            x64RadioButton.UseVisualStyleBackColor = true;
            // 
            // x32RadioButton
            // 
            x32RadioButton.AutoSize = true;
            x32RadioButton.Location = new Point(58, 3);
            x32RadioButton.Name = "x32RadioButton";
            x32RadioButton.Size = new Size(43, 19);
            x32RadioButton.TabIndex = 15;
            x32RadioButton.TabStop = true;
            x32RadioButton.Text = "x32";
            x32RadioButton.UseVisualStyleBackColor = true;
            // 
            // RISCRadioButton
            // 
            RISCRadioButton.AutoSize = true;
            RISCRadioButton.Location = new Point(3, 3);
            RISCRadioButton.Name = "RISCRadioButton";
            RISCRadioButton.Size = new Size(49, 19);
            RISCRadioButton.TabIndex = 14;
            RISCRadioButton.TabStop = true;
            RISCRadioButton.Text = "RISC";
            RISCRadioButton.UseVisualStyleBackColor = true;
            // 
            // maxFrequencyCPU
            // 
            maxFrequencyCPU.Location = new Point(99, 167);
            maxFrequencyCPU.Name = "maxFrequencyCPU";
            maxFrequencyCPU.Size = new Size(94, 23);
            maxFrequencyCPU.TabIndex = 12;
            maxFrequencyCPU.TextAlign = HorizontalAlignment.Right;
            // 
            // frequencyCPU
            // 
            frequencyCPU.Location = new Point(99, 138);
            frequencyCPU.Name = "frequencyCPU";
            frequencyCPU.Size = new Size(94, 23);
            frequencyCPU.TabIndex = 11;
            frequencyCPU.TextAlign = HorizontalAlignment.Right;
            // 
            // coreCountCPU
            // 
            coreCountCPU.Location = new Point(133, 109);
            coreCountCPU.Name = "coreCountCPU";
            coreCountCPU.Size = new Size(100, 23);
            coreCountCPU.TabIndex = 10;
            // 
            // modelCPU
            // 
            modelCPU.Location = new Point(133, 80);
            modelCPU.Name = "modelCPU";
            modelCPU.Size = new Size(100, 23);
            modelCPU.TabIndex = 9;
            // 
            // seriesCPU
            // 
            seriesCPU.Location = new Point(133, 51);
            seriesCPU.Name = "seriesCPU";
            seriesCPU.Size = new Size(100, 23);
            seriesCPU.TabIndex = 8;
            // 
            // computerGroupBox
            // 
            computerGroupBox.Controls.Add(label39);
            computerGroupBox.Controls.Add(label38);
            computerGroupBox.Controls.Add(sizeRAM);
            computerGroupBox.Controls.Add(label34);
            computerGroupBox.Controls.Add(frequencyRAM);
            computerGroupBox.Controls.Add(label16);
            computerGroupBox.Controls.Add(computerDate);
            computerGroupBox.Controls.Add(computerHDD);
            computerGroupBox.Controls.Add(computerGPU);
            computerGroupBox.Controls.Add(computerCPU);
            computerGroupBox.Controls.Add(label22);
            computerGroupBox.Controls.Add(label23);
            computerGroupBox.Controls.Add(label24);
            computerGroupBox.Controls.Add(label25);
            computerGroupBox.Controls.Add(computerType);
            computerGroupBox.Controls.Add(label26);
            computerGroupBox.Location = new Point(254, 96);
            computerGroupBox.Name = "computerGroupBox";
            computerGroupBox.Size = new Size(245, 318);
            computerGroupBox.TabIndex = 32;
            computerGroupBox.TabStop = false;
            computerGroupBox.Text = "Значения";
            computerGroupBox.Visible = false;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(202, 170);
            label39.Name = "label39";
            label39.Size = new Size(31, 15);
            label39.TabIndex = 42;
            label39.Text = "МГц";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(202, 141);
            label38.Name = "label38";
            label38.Size = new Size(20, 15);
            label38.TabIndex = 41;
            label38.Text = "ГБ";
            // 
            // sizeRAM
            // 
            sizeRAM.Location = new Point(100, 138);
            sizeRAM.Name = "sizeRAM";
            sizeRAM.Size = new Size(96, 23);
            sizeRAM.TabIndex = 40;
            sizeRAM.TextAlign = HorizontalAlignment.Right;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(12, 170);
            label34.Name = "label34";
            label34.Size = new Size(50, 15);
            label34.TabIndex = 39;
            label34.Text = "Частота";
            // 
            // frequencyRAM
            // 
            frequencyRAM.Location = new Point(100, 165);
            frequencyRAM.Name = "frequencyRAM";
            frequencyRAM.Size = new Size(96, 23);
            frequencyRAM.TabIndex = 38;
            frequencyRAM.TextAlign = HorizontalAlignment.Right;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(12, 141);
            label16.Name = "label16";
            label16.Size = new Size(45, 15);
            label16.TabIndex = 37;
            label16.Text = "Объём";
            // 
            // computerDate
            // 
            computerDate.Location = new Point(12, 226);
            computerDate.Name = "computerDate";
            computerDate.Size = new Size(221, 23);
            computerDate.TabIndex = 35;
            // 
            // computerHDD
            // 
            computerHDD.DropDownStyle = ComboBoxStyle.DropDownList;
            computerHDD.FormattingEnabled = true;
            computerHDD.Location = new Point(133, 194);
            computerHDD.Name = "computerHDD";
            computerHDD.Size = new Size(100, 23);
            computerHDD.TabIndex = 34;
            // 
            // computerGPU
            // 
            computerGPU.DropDownStyle = ComboBoxStyle.DropDownList;
            computerGPU.FormattingEnabled = true;
            computerGPU.Location = new Point(133, 80);
            computerGPU.Name = "computerGPU";
            computerGPU.Size = new Size(100, 23);
            computerGPU.TabIndex = 32;
            // 
            // computerCPU
            // 
            computerCPU.DropDownStyle = ComboBoxStyle.DropDownList;
            computerCPU.FormattingEnabled = true;
            computerCPU.Location = new Point(133, 51);
            computerCPU.Name = "computerCPU";
            computerCPU.Size = new Size(100, 23);
            computerCPU.TabIndex = 31;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(12, 197);
            label22.Name = "label22";
            label22.Size = new Size(83, 15);
            label22.TabIndex = 20;
            label22.Text = "Жёсткий диск";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label23.Location = new Point(12, 112);
            label23.Name = "label23";
            label23.Size = new Size(37, 20);
            label23.TabIndex = 19;
            label23.Text = "ОЗУ";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(12, 83);
            label24.Name = "label24";
            label24.Size = new Size(70, 15);
            label24.TabIndex = 18;
            label24.Text = "Видеокарта";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(12, 54);
            label25.Name = "label25";
            label25.Size = new Size(69, 15);
            label25.TabIndex = 17;
            label25.Text = "Процессор";
            // 
            // computerType
            // 
            computerType.DropDownStyle = ComboBoxStyle.DropDownList;
            computerType.FormattingEnabled = true;
            computerType.Items.AddRange(new object[] { "Сервер", "Рабочая станция", "Ноутбук" });
            computerType.Location = new Point(133, 22);
            computerType.Name = "computerType";
            computerType.Size = new Size(100, 23);
            computerType.TabIndex = 16;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(12, 25);
            label26.Name = "label26";
            label26.Size = new Size(27, 15);
            label26.TabIndex = 15;
            label26.Text = "Тип";
            // 
            // videocardGroupBox
            // 
            videocardGroupBox.Controls.Add(label17);
            videocardGroupBox.Controls.Add(label19);
            videocardGroupBox.Controls.Add(memorySizeGPU);
            videocardGroupBox.Controls.Add(directX11GPU);
            videocardGroupBox.Controls.Add(label18);
            videocardGroupBox.Controls.Add(label28);
            videocardGroupBox.Controls.Add(label30);
            videocardGroupBox.Controls.Add(label31);
            videocardGroupBox.Controls.Add(manufacturerGPU);
            videocardGroupBox.Controls.Add(label32);
            videocardGroupBox.Controls.Add(frequencyGPU);
            videocardGroupBox.Controls.Add(modelGPU);
            videocardGroupBox.Controls.Add(seriesGPU);
            videocardGroupBox.Location = new Point(254, 96);
            videocardGroupBox.Name = "videocardGroupBox";
            videocardGroupBox.Size = new Size(245, 318);
            videocardGroupBox.TabIndex = 33;
            videocardGroupBox.TabStop = false;
            videocardGroupBox.Text = "Значения";
            videocardGroupBox.Visible = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(199, 141);
            label17.Name = "label17";
            label17.Size = new Size(20, 15);
            label17.TabIndex = 34;
            label17.Text = "ГБ";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(12, 141);
            label19.Name = "label19";
            label19.Size = new Size(88, 15);
            label19.TabIndex = 33;
            label19.Text = "Объём памяти";
            // 
            // memorySizeGPU
            // 
            memorySizeGPU.Location = new Point(106, 138);
            memorySizeGPU.Name = "memorySizeGPU";
            memorySizeGPU.Size = new Size(87, 23);
            memorySizeGPU.TabIndex = 32;
            memorySizeGPU.TextAlign = HorizontalAlignment.Right;
            // 
            // directX11GPU
            // 
            directX11GPU.AutoSize = true;
            directX11GPU.Location = new Point(12, 167);
            directX11GPU.Name = "directX11GPU";
            directX11GPU.RightToLeft = RightToLeft.Yes;
            directX11GPU.Size = new Size(144, 19);
            directX11GPU.TabIndex = 31;
            directX11GPU.Text = "Поддержка Direct X11";
            directX11GPU.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(199, 112);
            label18.Name = "label18";
            label18.Size = new Size(31, 15);
            label18.TabIndex = 29;
            label18.Text = "МГц";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(12, 112);
            label28.Name = "label28";
            label28.Size = new Size(50, 15);
            label28.TabIndex = 20;
            label28.Text = "Частота";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(12, 83);
            label30.Name = "label30";
            label30.Size = new Size(50, 15);
            label30.TabIndex = 18;
            label30.Text = "Модель";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(12, 54);
            label31.Name = "label31";
            label31.Size = new Size(41, 15);
            label31.TabIndex = 17;
            label31.Text = "Серия";
            // 
            // manufacturerGPU
            // 
            manufacturerGPU.DropDownStyle = ComboBoxStyle.DropDownList;
            manufacturerGPU.FormattingEnabled = true;
            manufacturerGPU.Items.AddRange(new object[] { "Nvidia", "AMD" });
            manufacturerGPU.Location = new Point(133, 22);
            manufacturerGPU.Name = "manufacturerGPU";
            manufacturerGPU.Size = new Size(100, 23);
            manufacturerGPU.TabIndex = 16;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(12, 25);
            label32.Name = "label32";
            label32.Size = new Size(92, 15);
            label32.TabIndex = 15;
            label32.Text = "Производитель";
            // 
            // frequencyGPU
            // 
            frequencyGPU.Location = new Point(106, 109);
            frequencyGPU.Name = "frequencyGPU";
            frequencyGPU.Size = new Size(87, 23);
            frequencyGPU.TabIndex = 11;
            frequencyGPU.TextAlign = HorizontalAlignment.Right;
            // 
            // modelGPU
            // 
            modelGPU.Location = new Point(133, 80);
            modelGPU.Name = "modelGPU";
            modelGPU.Size = new Size(100, 23);
            modelGPU.TabIndex = 9;
            // 
            // seriesGPU
            // 
            seriesGPU.Location = new Point(133, 51);
            seriesGPU.Name = "seriesGPU";
            seriesGPU.Size = new Size(100, 23);
            seriesGPU.TabIndex = 8;
            // 
            // harddiskGroupBox
            // 
            harddiskGroupBox.Controls.Add(interfaceHDD);
            harddiskGroupBox.Controls.Add(label37);
            harddiskGroupBox.Controls.Add(typeHDD);
            harddiskGroupBox.Controls.Add(label36);
            harddiskGroupBox.Controls.Add(label20);
            harddiskGroupBox.Controls.Add(label21);
            harddiskGroupBox.Controls.Add(memorySizeHDD);
            harddiskGroupBox.Controls.Add(label27);
            harddiskGroupBox.Controls.Add(label29);
            harddiskGroupBox.Controls.Add(label33);
            harddiskGroupBox.Controls.Add(manufacturerHDD);
            harddiskGroupBox.Controls.Add(label35);
            harddiskGroupBox.Controls.Add(speedHDD);
            harddiskGroupBox.Controls.Add(modelHDD);
            harddiskGroupBox.Location = new Point(254, 96);
            harddiskGroupBox.Name = "harddiskGroupBox";
            harddiskGroupBox.Size = new Size(245, 318);
            harddiskGroupBox.TabIndex = 34;
            harddiskGroupBox.TabStop = false;
            harddiskGroupBox.Text = "Значения";
            harddiskGroupBox.Visible = false;
            // 
            // interfaceHDD
            // 
            interfaceHDD.DropDownStyle = ComboBoxStyle.DropDownList;
            interfaceHDD.FormattingEnabled = true;
            interfaceHDD.Items.AddRange(new object[] { "SATA", "IDE" });
            interfaceHDD.Location = new Point(133, 109);
            interfaceHDD.Name = "interfaceHDD";
            interfaceHDD.Size = new Size(100, 23);
            interfaceHDD.TabIndex = 38;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(12, 112);
            label37.Name = "label37";
            label37.Size = new Size(69, 15);
            label37.TabIndex = 37;
            label37.Text = "Интерфейс";
            // 
            // typeHDD
            // 
            typeHDD.DropDownStyle = ComboBoxStyle.DropDownList;
            typeHDD.FormattingEnabled = true;
            typeHDD.Items.AddRange(new object[] { "HDD", "SSD", "NVMe" });
            typeHDD.Location = new Point(133, 51);
            typeHDD.Name = "typeHDD";
            typeHDD.Size = new Size(100, 23);
            typeHDD.TabIndex = 36;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(12, 54);
            label36.Name = "label36";
            label36.Size = new Size(27, 15);
            label36.TabIndex = 35;
            label36.Text = "Тип";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(199, 141);
            label20.Name = "label20";
            label20.Size = new Size(20, 15);
            label20.TabIndex = 34;
            label20.Text = "ГБ";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(12, 141);
            label21.Name = "label21";
            label21.Size = new Size(88, 15);
            label21.TabIndex = 33;
            label21.Text = "Объём памяти";
            // 
            // memorySizeHDD
            // 
            memorySizeHDD.Location = new Point(118, 138);
            memorySizeHDD.Name = "memorySizeHDD";
            memorySizeHDD.Size = new Size(75, 23);
            memorySizeHDD.TabIndex = 32;
            memorySizeHDD.TextAlign = HorizontalAlignment.Right;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(199, 170);
            label27.Name = "label27";
            label27.Size = new Size(36, 15);
            label27.TabIndex = 29;
            label27.Text = "МБ/с";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(12, 170);
            label29.Name = "label29";
            label29.Size = new Size(100, 15);
            label29.TabIndex = 20;
            label29.Text = "Скорость чтения";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(12, 83);
            label33.Name = "label33";
            label33.Size = new Size(50, 15);
            label33.TabIndex = 18;
            label33.Text = "Модель";
            // 
            // manufacturerHDD
            // 
            manufacturerHDD.DisplayMember = "0";
            manufacturerHDD.DropDownStyle = ComboBoxStyle.DropDownList;
            manufacturerHDD.FormattingEnabled = true;
            manufacturerHDD.Items.AddRange(new object[] { "Seagate", "Western", "Toshiba", "Samsung" });
            manufacturerHDD.Location = new Point(133, 22);
            manufacturerHDD.Name = "manufacturerHDD";
            manufacturerHDD.Size = new Size(100, 23);
            manufacturerHDD.TabIndex = 16;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(12, 25);
            label35.Name = "label35";
            label35.Size = new Size(92, 15);
            label35.TabIndex = 15;
            label35.Text = "Производитель";
            // 
            // speedHDD
            // 
            speedHDD.Location = new Point(118, 167);
            speedHDD.Name = "speedHDD";
            speedHDD.Size = new Size(75, 23);
            speedHDD.TabIndex = 11;
            speedHDD.TextAlign = HorizontalAlignment.Right;
            // 
            // modelHDD
            // 
            modelHDD.Location = new Point(133, 80);
            modelHDD.Name = "modelHDD";
            modelHDD.Size = new Size(100, 23);
            modelHDD.TabIndex = 9;
            // 
            // nullDateGroupBox
            // 
            nullDateGroupBox.Controls.Add(label14);
            nullDateGroupBox.Controls.Add(label15);
            nullDateGroupBox.Location = new Point(254, 96);
            nullDateGroupBox.Name = "nullDateGroupBox";
            nullDateGroupBox.Size = new Size(245, 318);
            nullDateGroupBox.TabIndex = 31;
            nullDateGroupBox.TabStop = false;
            nullDateGroupBox.Text = "Значения";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(74, 146);
            label14.Name = "label14";
            label14.Size = new Size(107, 15);
            label14.TabIndex = 30;
            label14.Text = "Девайс не выбран";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(68, 127);
            label15.Name = "label15";
            label15.Size = new Size(120, 15);
            label15.TabIndex = 29;
            label15.Text = "Данные отсутствуют";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, projectToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(552, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, saveAsToolStripMenuItem, openToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(112, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(112, 22);
            saveAsToolStripMenuItem.Text = "Save as";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(112, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(112, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // projectToolStripMenuItem
            // 
            projectToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchToolStripMenuItem, reportToolStripMenuItem, logHistoryToolStripMenuItem });
            projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            projectToolStripMenuItem.Size = new Size(56, 20);
            projectToolStripMenuItem.Text = "Project";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(132, 22);
            searchToolStripMenuItem.Text = "Search";
            searchToolStripMenuItem.Click += searchToolStripMenuItem_Click;
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new Size(132, 22);
            reportToolStripMenuItem.Text = "Report";
            reportToolStripMenuItem.Click += reportToolStripMenuItem_Click;
            // 
            // logHistoryToolStripMenuItem
            // 
            logHistoryToolStripMenuItem.Name = "logHistoryToolStripMenuItem";
            logHistoryToolStripMenuItem.Size = new Size(132, 22);
            logHistoryToolStripMenuItem.Text = "LogHistory";
            logHistoryToolStripMenuItem.Click += logHistoryToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton3, toolStripButton2, toolStripButton1, toolStripButton4 });
            toolStrip1.Location = new Point(7, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(104, 25);
            toolStrip1.TabIndex = 35;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = Properties.Resources._1960;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 22);
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources._10;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources._72;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = Properties.Resources._159;
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(23, 22);
            toolStripButton4.Text = "toolStripButton4";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(groupBox1);
            toolStripContainer1.ContentPanel.Controls.Add(groupBox2);
            toolStripContainer1.ContentPanel.Controls.Add(nullDateGroupBox);
            toolStripContainer1.ContentPanel.Controls.Add(processorGroupBox);
            toolStripContainer1.ContentPanel.Controls.Add(harddiskGroupBox);
            toolStripContainer1.ContentPanel.Controls.Add(computerGroupBox);
            toolStripContainer1.ContentPanel.Controls.Add(videocardGroupBox);
            toolStripContainer1.ContentPanel.Size = new Size(531, 420);
            toolStripContainer1.Location = new Point(12, 27);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(531, 445);
            toolStripContainer1.TabIndex = 36;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
            toolStripContainer1.TopToolStripPanel.Click += toolStripContainer1_TopToolStripPanel_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lastEventLabel, devicesCountLabel, timeLabel });
            statusStrip1.Location = new Point(0, 490);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(552, 24);
            statusStrip1.TabIndex = 37;
            statusStrip1.Text = "statusStrip1";
            // 
            // lastEventLabel
            // 
            lastEventLabel.BorderSides = ToolStripStatusLabelBorderSides.Right;
            lastEventLabel.Name = "lastEventLabel";
            lastEventLabel.Size = new Size(455, 19);
            lastEventLabel.Spring = true;
            lastEventLabel.Text = "none";
            lastEventLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // devicesCountLabel
            // 
            devicesCountLabel.BorderSides = ToolStripStatusLabelBorderSides.Right;
            devicesCountLabel.Name = "devicesCountLabel";
            devicesCountLabel.Size = new Size(17, 19);
            devicesCountLabel.Text = "0";
            devicesCountLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timeLabel
            // 
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(34, 19);
            timeLabel.Text = "00:00";
            timeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 514);
            Controls.Add(statusStrip1);
            Controls.Add(toolStripContainer1);
            Controls.Add(menuStrip1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "PC Builder";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            processorGroupBox.ResumeLayout(false);
            processorGroupBox.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            computerGroupBox.ResumeLayout(false);
            computerGroupBox.PerformLayout();
            videocardGroupBox.ResumeLayout(false);
            videocardGroupBox.PerformLayout();
            harddiskGroupBox.ResumeLayout(false);
            harddiskGroupBox.PerformLayout();
            nullDateGroupBox.ResumeLayout(false);
            nullDateGroupBox.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button deleteDevice;
        private GroupBox groupBox1;
        private TextBox deviceName;
        private Button addDevice;
        private ComboBox deviceType;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        private GroupBox processorGroupBox;
        private ListBox devicesListBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TextBox maxFrequencyCPU;
        private TextBox frequencyCPU;
        private TextBox coreCountCPU;
        private TextBox modelCPU;
        private TextBox seriesCPU;
        private RadioButton RISCRadioButton;
        private Panel panel1;
        private RadioButton x32RadioButton;
        private RadioButton x64RadioButton;
        private Label label3;
        private TextBox memoryL1;
        private CheckBox isMemoryL1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox manufacturerCPU;
        private Label label8;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox memoryL3;
        private CheckBox isMemoryL3;
        private TextBox memoryL2;
        private CheckBox isMemoryL2;
        private GroupBox nullDateGroupBox;
        private Label label14;
        private Label label15;
        private GroupBox computerGroupBox;
        private ComboBox computerGPU;
        private ComboBox computerCPU;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private ComboBox computerType;
        private Label label26;
        private DateTimePicker computerDate;
        private ComboBox computerHDD;
        private Label label16;
        private GroupBox videocardGroupBox;
        private Label label17;
        private Label label19;
        private TextBox memorySizeGPU;
        private CheckBox directX11GPU;
        private Label label18;
        private Label label28;
        private Label label30;
        private Label label31;
        private ComboBox manufacturerGPU;
        private Label label32;
        private TextBox frequencyGPU;
        private TextBox modelGPU;
        private TextBox seriesGPU;
        private GroupBox harddiskGroupBox;
        private Label label20;
        private Label label21;
        private TextBox memorySizeHDD;
        private Label label27;
        private Label label29;
        private Label label33;
        private ComboBox manufacturerHDD;
        private Label label35;
        private TextBox speedHDD;
        private TextBox modelHDD;
        private ComboBox interfaceHDD;
        private Label label37;
        private ComboBox typeHDD;
        private Label label36;
        private Label label39;
        private Label label38;
        private TextBox sizeRAM;
        private Label label34;
        private TextBox frequencyRAM;
        private Label label40;
        private ComboBox sortedComboBox;
        private ToolStripMenuItem projectToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem logHistoryToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripContainer toolStripContainer1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lastEventLabel;
        private ToolStripStatusLabel devicesCountLabel;
        private ToolStripStatusLabel timeLabel;
    }
}
