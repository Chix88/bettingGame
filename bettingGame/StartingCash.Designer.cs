﻿namespace bettingGame
{
    partial class StartingCash
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
            this.button1 = new System.Windows.Forms.Button();
            this.mikeCash = new System.Windows.Forms.TextBox();
            this.johnLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.johnCash = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kimCash = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mikeCash
            // 
            this.mikeCash.Location = new System.Drawing.Point(341, 50);
            this.mikeCash.Name = "mikeCash";
            this.mikeCash.Size = new System.Drawing.Size(100, 20);
            this.mikeCash.TabIndex = 1;
            // 
            // johnLabel
            // 
            this.johnLabel.AutoSize = true;
            this.johnLabel.Location = new System.Drawing.Point(252, 53);
            this.johnLabel.Name = "johnLabel";
            this.johnLabel.Size = new System.Drawing.Size(30, 13);
            this.johnLabel.TabIndex = 2;
            this.johnLabel.Text = "Mike";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "John";
            // 
            // johnCash
            // 
            this.johnCash.Location = new System.Drawing.Point(341, 98);
            this.johnCash.Name = "johnCash";
            this.johnCash.Size = new System.Drawing.Size(100, 20);
            this.johnCash.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "John";
            // 
            // kimCash
            // 
            this.kimCash.Location = new System.Drawing.Point(341, 142);
            this.kimCash.Name = "kimCash";
            this.kimCash.Size = new System.Drawing.Size(100, 20);
            this.kimCash.TabIndex = 1;
            // 
            // StartingCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 250);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kimCash);
            this.Controls.Add(this.johnLabel);
            this.Controls.Add(this.johnCash);
            this.Controls.Add(this.mikeCash);
            this.Controls.Add(this.button1);
            this.Name = "StartingCash";
            this.Text = "StartingCash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox mikeCash;
        private System.Windows.Forms.Label johnLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox johnCash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kimCash;
    }
}