﻿namespace Converter
{
    partial class MainWindow
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
            levaLabel = new Label();
            levaTextBox = new TextBox();
            SuspendLayout();
            // 
            // levaLabel
            // 
            levaLabel.AutoSize = true;
            levaLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
            levaLabel.Location = new Point(163, 52);
            levaLabel.Name = "levaLabel";
            levaLabel.Size = new Size(76, 45);
            levaLabel.TabIndex = 0;
            levaLabel.Text = "leva";
            // 
            // levaTextBox
            // 
            levaTextBox.Location = new Point(351, 65);
            levaTextBox.Name = "levaTextBox";
            levaTextBox.Size = new Size(186, 31);
            levaTextBox.TabIndex = 1;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 450);
            Controls.Add(levaTextBox);
            Controls.Add(levaLabel);
            Name = "MainWindow";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label levaLabel;
        private TextBox levaTextBox;
    }
}
