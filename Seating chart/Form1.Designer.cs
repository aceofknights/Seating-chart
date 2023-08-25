namespace Seating_chart
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
            seatingChartListBox = new ListBox();
            label2 = new Label();
            addKidTextBox = new TextBox();
            addKidButton = new Button();
            ShuffleButton = new Button();
            removeButton = new Button();
            specificKidTextBox = new TextBox();
            lockButton = new Button();
            specificSeatsTextBox = new TextBox();
            label1 = new Label();
            label3 = new Label();
            SaveButton = new Button();
            LoadButton = new Button();
            SuspendLayout();
            // 
            // seatingChartListBox
            // 
            seatingChartListBox.FormattingEnabled = true;
            seatingChartListBox.ItemHeight = 15;
            seatingChartListBox.Location = new Point(80, 142);
            seatingChartListBox.Name = "seatingChartListBox";
            seatingChartListBox.Size = new Size(496, 289);
            seatingChartListBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 48);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 6;
            label2.Text = "specific kid";
            // 
            // addKidTextBox
            // 
            addKidTextBox.Location = new Point(80, 2);
            addKidTextBox.Name = "addKidTextBox";
            addKidTextBox.Size = new Size(210, 23);
            addKidTextBox.TabIndex = 7;
            // 
            // addKidButton
            // 
            addKidButton.Location = new Point(3, 2);
            addKidButton.Name = "addKidButton";
            addKidButton.Size = new Size(75, 23);
            addKidButton.TabIndex = 8;
            addKidButton.Text = "addKidButton";
            addKidButton.UseVisualStyleBackColor = true;
            addKidButton.Click += addKidButton_Click;
            // 
            // ShuffleButton
            // 
            ShuffleButton.Location = new Point(446, 113);
            ShuffleButton.Name = "ShuffleButton";
            ShuffleButton.Size = new Size(75, 23);
            ShuffleButton.TabIndex = 9;
            ShuffleButton.Text = "ShuffleButton";
            ShuffleButton.UseVisualStyleBackColor = true;
            ShuffleButton.Click += ShuffleButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(-1, 408);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(75, 23);
            removeButton.TabIndex = 10;
            removeButton.Text = "removeButton";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // specificKidTextBox
            // 
            specificKidTextBox.Location = new Point(80, 80);
            specificKidTextBox.Name = "specificKidTextBox";
            specificKidTextBox.Size = new Size(100, 23);
            specificKidTextBox.TabIndex = 5;
            // 
            // lockButton
            // 
            lockButton.Location = new Point(186, 95);
            lockButton.Name = "lockButton";
            lockButton.Size = new Size(75, 23);
            lockButton.TabIndex = 11;
            lockButton.Text = "lockButton";
            lockButton.UseVisualStyleBackColor = true;
            lockButton.Click += lockButton_Click;
            // 
            // specificSeatsTextBox
            // 
            specificSeatsTextBox.Location = new Point(80, 109);
            specificSeatsTextBox.Name = "specificSeatsTextBox";
            specificSeatsTextBox.Size = new Size(100, 23);
            specificSeatsTextBox.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 83);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 13;
            label1.Text = "kid name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 112);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 14;
            label3.Text = "seat number";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(379, 2);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 15;
            SaveButton.Text = "SaveButton";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // LoadButton
            // 
            LoadButton.Location = new Point(460, 2);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(75, 23);
            LoadButton.TabIndex = 16;
            LoadButton.Text = "LoadButton";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 450);
            Controls.Add(LoadButton);
            Controls.Add(SaveButton);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(specificSeatsTextBox);
            Controls.Add(lockButton);
            Controls.Add(removeButton);
            Controls.Add(ShuffleButton);
            Controls.Add(addKidButton);
            Controls.Add(addKidTextBox);
            Controls.Add(label2);
            Controls.Add(specificKidTextBox);
            Controls.Add(seatingChartListBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox seatingChartListBox;
        private Label label2;
        private TextBox addKidTextBox;
        private Button addKidButton;
        private Button ShuffleButton;
        private Button removeButton;
        private TextBox specificKidTextBox;
        private Button lockButton;
        private TextBox specificSeatsTextBox;
        private Label label1;
        private Label label3;
        private Button SaveButton;
        private Button LoadButton;
    }
}