﻿namespace WindowsFormsApp2
{
    partial class MainForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loginUserControl1 = new WindowsFormsApp2.LoginUserControl();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Старт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Onyx", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(645, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дякуємо за авторизацію. Щоб розпочати роботу натисніть старт";
            this.label1.Visible = false;
            // 
            // loginUserControl1
            // 
            this.loginUserControl1.Location = new System.Drawing.Point(208, 57);
            this.loginUserControl1.Name = "loginUserControl1";
            this.loginUserControl1.Size = new System.Drawing.Size(355, 327);
            this.loginUserControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.loginUserControl1);
            this.Name = "MainForm";
            this.Text = "Початкова сторінка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LoginUserControl loginUserControl1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}