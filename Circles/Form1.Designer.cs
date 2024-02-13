namespace Circles
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
            pictureBox1 = new PictureBox();
            GenerateCirclesButton = new Button();
            label1 = new Label();
            amountTextBox = new TextBox();
            outsideButton = new RadioButton();
            insideButton = new RadioButton();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(46, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(740, 740);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // GenerateCirclesButton
            // 
            GenerateCirclesButton.BackColor = SystemColors.Highlight;
            GenerateCirclesButton.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GenerateCirclesButton.Location = new Point(877, 437);
            GenerateCirclesButton.Name = "GenerateCirclesButton";
            GenerateCirclesButton.Size = new Size(433, 121);
            GenerateCirclesButton.TabIndex = 1;
            GenerateCirclesButton.Text = "GENERATE";
            GenerateCirclesButton.UseVisualStyleBackColor = false;
            GenerateCirclesButton.Click += GenerateCirclesButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(877, 151);
            label1.Name = "label1";
            label1.Size = new Size(150, 21);
            label1.TabIndex = 2;
            label1.Text = "Amount of Circles:";
            // 
            // amountTextBox
            // 
            amountTextBox.ForeColor = SystemColors.MenuText;
            amountTextBox.Location = new Point(877, 187);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(433, 23);
            amountTextBox.TabIndex = 3;
            // 
            // outsideButton
            // 
            outsideButton.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            outsideButton.Location = new Point(904, 320);
            outsideButton.Name = "outsideButton";
            outsideButton.Size = new Size(283, 30);
            outsideButton.TabIndex = 4;
            outsideButton.TabStop = true;
            outsideButton.Text = "Can only be outside the other";
            outsideButton.UseVisualStyleBackColor = true;
            // 
            // insideButton
            // 
            insideButton.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            insideButton.Location = new Point(904, 356);
            insideButton.Name = "insideButton";
            insideButton.Size = new Size(242, 30);
            insideButton.TabIndex = 8;
            insideButton.TabStop = true;
            insideButton.Text = "Can also be inside the other";
            insideButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(877, 275);
            label2.Name = "label2";
            label2.Size = new Size(220, 21);
            label2.TabIndex = 9;
            label2.Text = "Select one of the following:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1361, 807);
            Controls.Add(label2);
            Controls.Add(insideButton);
            Controls.Add(outsideButton);
            Controls.Add(amountTextBox);
            Controls.Add(label1);
            Controls.Add(GenerateCirclesButton);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button GenerateCirclesButton;
        private Label label1;
        private TextBox amountTextBox;
        private RadioButton outsideButton;
        private RadioButton insideButton;
        private Label label2;
    }
}
