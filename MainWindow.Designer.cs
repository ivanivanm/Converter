namespace Converter
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
            components = new System.ComponentModel.Container();
            levaLabel = new Label();
            levaTextBox = new TextBox();
            euroTextBox = new TextBox();
            euroLabel = new Label();
            LevaEuroConvertButton = new Button();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            colorDialog1 = new ColorDialog();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // levaLabel
            // 
            levaLabel.AutoSize = true;
            levaLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
            levaLabel.Location = new Point(141, 52);
            levaLabel.Name = "levaLabel";
            levaLabel.Size = new Size(76, 45);
            levaLabel.TabIndex = 0;
            levaLabel.Text = "leva";
            // 
            // levaTextBox
            // 
            levaTextBox.Location = new Point(258, 65);
            levaTextBox.Name = "levaTextBox";
            levaTextBox.Size = new Size(186, 31);
            levaTextBox.TabIndex = 1;
            // 
            // euroTextBox
            // 
            euroTextBox.Location = new Point(674, 65);
            euroTextBox.Name = "euroTextBox";
            euroTextBox.Size = new Size(186, 31);
            euroTextBox.TabIndex = 2;
            // 
            // euroLabel
            // 
            euroLabel.AutoSize = true;
            euroLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
            euroLabel.Location = new Point(925, 53);
            euroLabel.Name = "euroLabel";
            euroLabel.Size = new Size(85, 45);
            euroLabel.TabIndex = 3;
            euroLabel.Text = "euro\r\n";
            // 
            // LevaEuroConvertButton
            // 
            LevaEuroConvertButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LevaEuroConvertButton.Location = new Point(495, 57);
            LevaEuroConvertButton.Name = "LevaEuroConvertButton";
            LevaEuroConvertButton.Size = new Size(127, 49);
            LevaEuroConvertButton.TabIndex = 4;
            LevaEuroConvertButton.Text = "convert";
            LevaEuroConvertButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(528, 188);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(552, 283);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(739, 209);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 7;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(1029, 181);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 29);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(470, 178);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(121, 29);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(404, 125);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 10;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 450);
            Controls.Add(button3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(LevaEuroConvertButton);
            Controls.Add(euroLabel);
            Controls.Add(euroTextBox);
            Controls.Add(levaTextBox);
            Controls.Add(levaLabel);
            Name = "MainWindow";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label levaLabel;
        private TextBox levaTextBox;
        private TextBox euroTextBox;
        private Label euroLabel;
        private Button LevaEuroConvertButton;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private ErrorProvider errorProvider1;
        private Button button3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private ColorDialog colorDialog1;
    }
}
