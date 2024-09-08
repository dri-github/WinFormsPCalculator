namespace WinFormsApp2
{
    partial class Report
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
            devicesListBox = new ListBox();
            label3 = new Label();
            closeButton = new Button();
            costLabel = new Label();
            SuspendLayout();
            // 
            // devicesListBox
            // 
            devicesListBox.FormattingEnabled = true;
            devicesListBox.ItemHeight = 15;
            devicesListBox.Location = new Point(12, 12);
            devicesListBox.Name = "devicesListBox";
            devicesListBox.Size = new Size(246, 169);
            devicesListBox.TabIndex = 0;
            devicesListBox.SelectedIndexChanged += devicesListBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 193);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 6;
            label3.Text = "Стоимость покупки: ";
            // 
            // closeButton
            // 
            closeButton.Location = new Point(12, 218);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(246, 23);
            closeButton.TabIndex = 7;
            closeButton.Text = "Закрыть";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new Point(140, 193);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(22, 15);
            costLabel.TabIndex = 8;
            costLabel.Text = "---";
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 253);
            Controls.Add(costLabel);
            Controls.Add(closeButton);
            Controls.Add(label3);
            Controls.Add(devicesListBox);
            MaximizeBox = false;
            Name = "Report";
            Text = "Report";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox devicesListBox;
        private Label label3;
        private Button closeButton;
        private Label costLabel;
    }
}