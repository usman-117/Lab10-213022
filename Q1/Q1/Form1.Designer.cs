﻿namespace Q1
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
            listView1 = new ListView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.GridLines = true;
            listView1.Location = new Point(36, 41);
            listView1.Name = "listView1";
            listView1.Size = new Size(517, 335);
            listView1.TabIndex = 0;
            listView1.TileSize = new Size(1, 1);
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.SmallIcon;
            // 
            // button1
            // 
            button1.Location = new Point(27, 420);
            button1.Name = "button1";
            button1.Size = new Size(112, 62);
            button1.TabIndex = 1;
            button1.Text = "original employee";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(171, 420);
            button2.Name = "button2";
            button2.Size = new Size(112, 62);
            button2.TabIndex = 2;
            button2.Text = "Between 4000-6000";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(319, 420);
            button3.Name = "button3";
            button3.Size = new Size(112, 62);
            button3.TabIndex = 3;
            button3.Text = "order employee";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(464, 420);
            button4.Name = "button4";
            button4.Size = new Size(112, 62);
            button4.TabIndex = 4;
            button4.Text = "Unique";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 542);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}