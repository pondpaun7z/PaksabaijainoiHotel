namespace PaksabaijainoiHotel
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
            this.totalRoom = new System.Windows.Forms.Label();
            this.backToCal = new System.Windows.Forms.Button();
            this.room4 = new System.Windows.Forms.Label();
            this.room3 = new System.Windows.Forms.Label();
            this.room2 = new System.Windows.Forms.Label();
            this.room1 = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.showRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(250, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 64);
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
            this.button2.Location = new System.Drawing.Point(12, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 54);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.back2Menu_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox1.Location = new System.Drawing.Point(238, 166);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.MaxLength = 1000000;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // showRoom
            // 
            this.showRoom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showRoom.BackgroundImage")));
            this.showRoom.Controls.Add(this.totalRoom);
            this.showRoom.Controls.Add(this.backToCal);
            this.showRoom.Controls.Add(this.room4);
            this.showRoom.Controls.Add(this.room3);
            this.showRoom.Controls.Add(this.room2);
            this.showRoom.Controls.Add(this.room1);
            this.showRoom.Controls.Add(this.cost);
            this.showRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showRoom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.showRoom.Location = new System.Drawing.Point(0, 0);
            this.showRoom.Name = "showRoom";
            this.showRoom.Size = new System.Drawing.Size(584, 401);
            this.showRoom.TabIndex = 3;
            // 
            // totalRoom
            // 
            this.totalRoom.AutoSize = true;
            this.totalRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.totalRoom.Location = new System.Drawing.Point(289, 328);
            this.totalRoom.Name = "totalRoom";
            this.totalRoom.Size = new System.Drawing.Size(60, 24);
            this.totalRoom.TabIndex = 8;
            this.totalRoom.Text = "label1";
            // 
            // backToCal
            // 
            this.backToCal.BackColor = System.Drawing.Color.Transparent;
            this.backToCal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToCal.FlatAppearance.BorderColor = System.Drawing.Color.LightCyan;
            this.backToCal.FlatAppearance.BorderSize = 0;
            this.backToCal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.backToCal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.backToCal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backToCal.ForeColor = System.Drawing.Color.Transparent;
            this.backToCal.Image = ((System.Drawing.Image)(resources.GetObject("backToCal.Image")));
            this.backToCal.Location = new System.Drawing.Point(10, 344);
            this.backToCal.Name = "backToCal";
            this.backToCal.Size = new System.Drawing.Size(90, 48);
            this.backToCal.TabIndex = 7;
            this.backToCal.UseVisualStyleBackColor = false;
            this.backToCal.Click += new System.EventHandler(this.backToCal_Click);
            // 
            // room4
            // 
            this.room4.AutoSize = true;
            this.room4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.room4.Location = new System.Drawing.Point(298, 288);
            this.room4.Name = "room4";
            this.room4.Size = new System.Drawing.Size(51, 20);
            this.room4.TabIndex = 6;
            this.room4.Text = "label4";
            // 
            // room3
            // 
            this.room3.AutoSize = true;
            this.room3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.room3.Location = new System.Drawing.Point(298, 246);
            this.room3.Name = "room3";
            this.room3.Size = new System.Drawing.Size(51, 20);
            this.room3.TabIndex = 5;
            this.room3.Text = "label4";
            // 
            // room2
            // 
            this.room2.AutoSize = true;
            this.room2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.room2.Location = new System.Drawing.Point(298, 206);
            this.room2.Name = "room2";
            this.room2.Size = new System.Drawing.Size(51, 20);
            this.room2.TabIndex = 4;
            this.room2.Text = "label4";
            // 
            // room1
            // 
            this.room1.AutoSize = true;
            this.room1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.room1.Location = new System.Drawing.Point(298, 155);
            this.room1.Name = "room1";
            this.room1.Size = new System.Drawing.Size(51, 20);
            this.room1.TabIndex = 3;
            this.room1.Text = "label4";
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cost.Location = new System.Drawing.Point(283, 70);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(60, 24);
            this.cost.TabIndex = 1;
            this.cost.Text = "label3";
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
            this.Text = "Paksabaijainoi Hotel";
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
        private System.Windows.Forms.Label room4;
        private System.Windows.Forms.Label room3;
        private System.Windows.Forms.Label room2;
        private System.Windows.Forms.Label room1;
        private System.Windows.Forms.Label cost;
        private System.Windows.Forms.Button backToCal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label totalRoom;
    }
}