namespace linq_2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Task1Button = new System.Windows.Forms.Button();
            this.Task2Button = new System.Windows.Forms.Button();
            this.Task3Button = new System.Windows.Forms.Button();
            this.Task4Button = new System.Windows.Forms.Button();
            this.Task5Button = new System.Windows.Forms.Button();
            this.Task6Button = new System.Windows.Forms.Button();
            this.Task7Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 484);
            this.listBox1.TabIndex = 0;
            // 
            // Task1Button
            // 
            this.Task1Button.Location = new System.Drawing.Point(215, 125);
            this.Task1Button.Name = "Task1Button";
            this.Task1Button.Size = new System.Drawing.Size(126, 39);
            this.Task1Button.TabIndex = 1;
            this.Task1Button.Text = "Task1";
            this.Task1Button.UseVisualStyleBackColor = true;
            this.Task1Button.Click += new System.EventHandler(this.Task1Button_Click);
            // 
            // Task2Button
            // 
            this.Task2Button.Location = new System.Drawing.Point(215, 185);
            this.Task2Button.Name = "Task2Button";
            this.Task2Button.Size = new System.Drawing.Size(126, 39);
            this.Task2Button.TabIndex = 2;
            this.Task2Button.Text = "Task2";
            this.Task2Button.UseVisualStyleBackColor = true;
            this.Task2Button.Click += new System.EventHandler(this.Task2Button_Click);
            // 
            // Task3Button
            // 
            this.Task3Button.Location = new System.Drawing.Point(215, 241);
            this.Task3Button.Name = "Task3Button";
            this.Task3Button.Size = new System.Drawing.Size(126, 39);
            this.Task3Button.TabIndex = 3;
            this.Task3Button.Text = "Task3";
            this.Task3Button.UseVisualStyleBackColor = true;
            this.Task3Button.Click += new System.EventHandler(this.Task3Button_Click);
            // 
            // Task4Button
            // 
            this.Task4Button.Location = new System.Drawing.Point(215, 297);
            this.Task4Button.Name = "Task4Button";
            this.Task4Button.Size = new System.Drawing.Size(126, 39);
            this.Task4Button.TabIndex = 4;
            this.Task4Button.Text = "Task4";
            this.Task4Button.UseVisualStyleBackColor = true;
            this.Task4Button.Click += new System.EventHandler(this.Task4Button_Click);
            // 
            // Task5Button
            // 
            this.Task5Button.Location = new System.Drawing.Point(215, 351);
            this.Task5Button.Name = "Task5Button";
            this.Task5Button.Size = new System.Drawing.Size(126, 39);
            this.Task5Button.TabIndex = 5;
            this.Task5Button.Text = "Task5";
            this.Task5Button.UseVisualStyleBackColor = true;
            this.Task5Button.Click += new System.EventHandler(this.Task5Button_Click);
            // 
            // Task6Button
            // 
            this.Task6Button.Location = new System.Drawing.Point(215, 405);
            this.Task6Button.Name = "Task6Button";
            this.Task6Button.Size = new System.Drawing.Size(126, 39);
            this.Task6Button.TabIndex = 6;
            this.Task6Button.Text = "Task6";
            this.Task6Button.UseVisualStyleBackColor = true;
            this.Task6Button.Click += new System.EventHandler(this.Task6Button_Click);
            // 
            // Task7Button
            // 
            this.Task7Button.Location = new System.Drawing.Point(215, 460);
            this.Task7Button.Name = "Task7Button";
            this.Task7Button.Size = new System.Drawing.Size(126, 39);
            this.Task7Button.TabIndex = 7;
            this.Task7Button.Text = "Task7";
            this.Task7Button.UseVisualStyleBackColor = true;
            this.Task7Button.Click += new System.EventHandler(this.Task7Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 557);
            this.Controls.Add(this.Task7Button);
            this.Controls.Add(this.Task6Button);
            this.Controls.Add(this.Task5Button);
            this.Controls.Add(this.Task4Button);
            this.Controls.Add(this.Task3Button);
            this.Controls.Add(this.Task2Button);
            this.Controls.Add(this.Task1Button);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBox1;
        private Button Task1Button;
        private Button Task2Button;
        private Button Task3Button;
        private Button Task4Button;
        private Button Task5Button;
        private Button Task6Button;
        private Button Task7Button;
    }
}