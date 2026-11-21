namespace DwgCodingLab
{
    partial class MainForm
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
            exportButton = new Button();
            SuspendLayout();
            // 
            // exportButton
            // 
            exportButton.Location = new Point(335, 198);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(75, 23);
            exportButton.TabIndex = 0;
            exportButton.Text = "出力";
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += exportButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exportButton);
            Name = "MainForm";
            Text = "DwgCodingLab";
            ResumeLayout(false);
        }

        #endregion

        private Button exportButton;
    }
}
