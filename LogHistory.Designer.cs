namespace WinFormsApp2
{
    partial class LogHistory
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
            logListText = new TextBox();
            closeButton = new Button();
            clearButton = new Button();
            SuspendLayout();
            // 
            // logListText
            // 
            logListText.Location = new Point(12, 12);
            logListText.Multiline = true;
            logListText.Name = "logListText";
            logListText.ReadOnly = true;
            logListText.ScrollBars = ScrollBars.Vertical;
            logListText.Size = new Size(443, 184);
            logListText.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(346, 202);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(109, 23);
            closeButton.TabIndex = 1;
            closeButton.Text = "Закрыть";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(231, 202);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(109, 23);
            clearButton.TabIndex = 2;
            clearButton.Text = "Очистить";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // LogHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 237);
            Controls.Add(clearButton);
            Controls.Add(closeButton);
            Controls.Add(logListText);
            MaximizeBox = false;
            Name = "LogHistory";
            Text = "LogHistory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox logListText;
        private Button closeButton;
        private Button clearButton;
    }
}