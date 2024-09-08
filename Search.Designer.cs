namespace WinFormsApp2
{
    partial class Search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            searchBox = new TextBox();
            label1 = new Label();
            searchedDevicesBox = new ListBox();
            typeSearchBox = new ComboBox();
            groupBox1 = new GroupBox();
            checkRAM = new CheckBox();
            checkProcessor = new CheckBox();
            groupBox2 = new GroupBox();
            eraseButton = new Button();
            applyButton = new Button();
            saveButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // searchBox
            // 
            searchBox.Location = new Point(12, 32);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(156, 23);
            searchBox.TabIndex = 0;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 1;
            label1.Text = "Поиск";
            // 
            // searchedDevicesBox
            // 
            searchedDevicesBox.FormattingEnabled = true;
            searchedDevicesBox.ItemHeight = 15;
            searchedDevicesBox.Location = new Point(6, 22);
            searchedDevicesBox.Name = "searchedDevicesBox";
            searchedDevicesBox.Size = new Size(250, 229);
            searchedDevicesBox.TabIndex = 2;
            // 
            // typeSearchBox
            // 
            typeSearchBox.DropDownStyle = ComboBoxStyle.DropDownList;
            typeSearchBox.FormattingEnabled = true;
            typeSearchBox.Items.AddRange(new object[] { "Имя", "Производитель", "Модель" });
            typeSearchBox.Location = new Point(174, 32);
            typeSearchBox.Name = "typeSearchBox";
            typeSearchBox.Size = new Size(103, 23);
            typeSearchBox.TabIndex = 4;
            typeSearchBox.SelectedIndexChanged += typeSearchBox_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkRAM);
            groupBox1.Controls.Add(checkProcessor);
            groupBox1.Location = new Point(12, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(265, 50);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Сортировка";
            // 
            // checkRAM
            // 
            checkRAM.AutoSize = true;
            checkRAM.Location = new Point(162, 24);
            checkRAM.Name = "checkRAM";
            checkRAM.RightToLeft = RightToLeft.Yes;
            checkRAM.Size = new Size(92, 19);
            checkRAM.TabIndex = 4;
            checkRAM.Text = "Размер ОЗУ";
            checkRAM.UseVisualStyleBackColor = true;
            checkRAM.CheckedChanged += checkRAM_CheckedChanged;
            // 
            // checkProcessor
            // 
            checkProcessor.AutoSize = true;
            checkProcessor.Location = new Point(6, 24);
            checkProcessor.Name = "checkProcessor";
            checkProcessor.RightToLeft = RightToLeft.Yes;
            checkProcessor.Size = new Size(144, 19);
            checkProcessor.TabIndex = 3;
            checkProcessor.Text = "Частота процесссора";
            checkProcessor.UseVisualStyleBackColor = true;
            checkProcessor.CheckedChanged += checkProcessor_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(eraseButton);
            groupBox2.Controls.Add(searchedDevicesBox);
            groupBox2.Location = new Point(12, 117);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(265, 292);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Результаты поиска";
            // 
            // eraseButton
            // 
            eraseButton.Location = new Point(84, 263);
            eraseButton.Name = "eraseButton";
            eraseButton.Size = new Size(86, 23);
            eraseButton.TabIndex = 9;
            eraseButton.Text = "Исключить";
            eraseButton.UseVisualStyleBackColor = true;
            eraseButton.Click += eraseButton_Click;
            // 
            // applyButton
            // 
            applyButton.Location = new Point(12, 415);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(124, 23);
            applyButton.TabIndex = 7;
            applyButton.Text = "Применить";
            applyButton.UseVisualStyleBackColor = true;
            applyButton.Click += applyButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(142, 415);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(135, 23);
            saveButton.TabIndex = 8;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 450);
            Controls.Add(saveButton);
            Controls.Add(applyButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(typeSearchBox);
            Controls.Add(label1);
            Controls.Add(searchBox);
            MaximizeBox = false;
            Name = "Search";
            Text = "Search";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchBox;
        private Label label1;
        private ListBox searchedDevicesBox;
        private ComboBox typeSearchBox;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox checkProcessor;
        private CheckBox checkRAM;
        private Button eraseButton;
        private Button applyButton;
        private Button saveButton;
    }
}