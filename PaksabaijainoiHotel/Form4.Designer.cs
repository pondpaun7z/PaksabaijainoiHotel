﻿namespace PaksabaijainoiHotel
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.showRoom = new System.Windows.Forms.Panel();
            this.backToCal = new System.Windows.Forms.Button();
            this.room4 = new System.Windows.Forms.Label();
            this.room3 = new System.Windows.Forms.Label();
            this.room2 = new System.Windows.Forms.Label();
            this.room1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.showRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Goldenrod;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(246, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 55);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.calaulate_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(12, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 38);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.back2Menu_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(227, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 0;
            // 
            // showRoom
            // 
            this.showRoom.Controls.Add(this.backToCal);
            this.showRoom.Controls.Add(this.room4);
            this.showRoom.Controls.Add(this.room3);
            this.showRoom.Controls.Add(this.room2);
            this.showRoom.Controls.Add(this.room1);
            this.showRoom.Controls.Add(this.label3);
            this.showRoom.Controls.Add(this.cost);
            this.showRoom.Controls.Add(this.label2);
            this.showRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showRoom.Location = new System.Drawing.Point(0, 0);
            this.showRoom.Name = "showRoom";
            this.showRoom.Size = new System.Drawing.Size(584, 401);
            this.showRoom.TabIndex = 3;
            // 
            // backToCal
            // 
            this.backToCal.BackColor = System.Drawing.Color.Transparent;
            this.backToCal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToCal.ForeColor = System.Drawing.Color.Transparent;
            this.backToCal.Image = ((System.Drawing.Image)(resources.GetObject("backToCal.Image")));
            this.backToCal.Location = new System.Drawing.Point(496, 347);
            this.backToCal.Name = "backToCal";
            this.backToCal.Size = new System.Drawing.Size(76, 42);
            this.backToCal.TabIndex = 7;
            this.backToCal.UseVisualStyleBackColor = false;
            this.backToCal.Click += new System.EventHandler(this.backToCal_Click);
            // 
            // room4
            // 
            this.room4.AutoSize = true;
            this.room4.Location = new System.Drawing.Point(186, 256);
            this.room4.Name = "room4";
            this.room4.Size = new System.Drawing.Size(35, 13);
            this.room4.TabIndex = 6;
            this.room4.Text = "label4";
            // 
            // room3
            // 
            this.room3.AutoSize = true;
            this.room3.Location = new System.Drawing.Point(186, 219);
            this.room3.Name = "room3";
            this.room3.Size = new System.Drawing.Size(35, 13);
            this.room3.TabIndex = 5;
            this.room3.Text = "label4";
            // 
            // room2
            // 
            this.room2.AutoSize = true;
            this.room2.Location = new System.Drawing.Point(186, 177);
            this.room2.Name = "room2";
            this.room2.Size = new System.Drawing.Size(35, 13);
            this.room2.TabIndex = 4;
            this.room2.Text = "label4";
            // 
            // room1
            // 
            this.room1.AutoSize = true;
            this.room1.Location = new System.Drawing.Point(186, 131);
            this.room1.Name = "room1";
            this.room1.Size = new System.Drawing.Size(35, 13);
            this.room1.TabIndex = 3;
            this.room1.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Big Room";
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.Location = new System.Drawing.Point(183, 86);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(35, 13);
            this.cost.TabIndex = 1;
            this.cost.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Price";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 401);
            this.Controls.Add(this.showRoom);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.showRoom.ResumeLayout(false);
            this.showRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel showRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label room4;
        private System.Windows.Forms.Label room3;
        private System.Windows.Forms.Label room2;
        private System.Windows.Forms.Label room1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cost;
        private System.Windows.Forms.Button backToCal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}