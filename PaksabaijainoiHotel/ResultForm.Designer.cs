namespace PaksabaijainoiHotel
{
    partial class ResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            this.cost = new System.Windows.Forms.Label();
            this.totalRoom = new System.Windows.Forms.Label();
            this.room4 = new System.Windows.Forms.Label();
            this.room3 = new System.Windows.Forms.Label();
            this.room2 = new System.Windows.Forms.Label();
            this.room1 = new System.Windows.Forms.Label();
            this.backToCal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cost.Location = new System.Drawing.Point(308, 70);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(60, 24);
            this.cost.TabIndex = 2;
            this.cost.Text = "label3";
            // 
            // totalRoom
            // 
            this.totalRoom.AutoSize = true;
            this.totalRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.totalRoom.Location = new System.Drawing.Point(299, 327);
            this.totalRoom.Name = "totalRoom";
            this.totalRoom.Size = new System.Drawing.Size(60, 24);
            this.totalRoom.TabIndex = 13;
            this.totalRoom.Text = "label1";
            // 
            // room4
            // 
            this.room4.AutoSize = true;
            this.room4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.room4.Location = new System.Drawing.Point(308, 287);
            this.room4.Name = "room4";
            this.room4.Size = new System.Drawing.Size(51, 20);
            this.room4.TabIndex = 12;
            this.room4.Text = "label4";
            // 
            // room3
            // 
            this.room3.AutoSize = true;
            this.room3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.room3.Location = new System.Drawing.Point(308, 245);
            this.room3.Name = "room3";
            this.room3.Size = new System.Drawing.Size(51, 20);
            this.room3.TabIndex = 11;
            this.room3.Text = "label4";
            // 
            // room2
            // 
            this.room2.AutoSize = true;
            this.room2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.room2.Location = new System.Drawing.Point(308, 205);
            this.room2.Name = "room2";
            this.room2.Size = new System.Drawing.Size(51, 20);
            this.room2.TabIndex = 10;
            this.room2.Text = "label4";
            // 
            // room1
            // 
            this.room1.AutoSize = true;
            this.room1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.room1.Location = new System.Drawing.Point(308, 154);
            this.room1.Name = "room1";
            this.room1.Size = new System.Drawing.Size(51, 20);
            this.room1.TabIndex = 9;
            this.room1.Text = "label4";
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
            this.backToCal.Location = new System.Drawing.Point(12, 341);
            this.backToCal.Name = "backToCal";
            this.backToCal.Size = new System.Drawing.Size(90, 48);
            this.backToCal.TabIndex = 14;
            this.backToCal.UseVisualStyleBackColor = false;
            this.backToCal.Click += new System.EventHandler(this.backToCal_Click);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 401);
            this.Controls.Add(this.backToCal);
            this.Controls.Add(this.totalRoom);
            this.Controls.Add(this.room4);
            this.Controls.Add(this.room3);
            this.Controls.Add(this.room2);
            this.Controls.Add(this.room1);
            this.Controls.Add(this.cost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paksabaijainoi Hotel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cost;
        private System.Windows.Forms.Label totalRoom;
        private System.Windows.Forms.Label room4;
        private System.Windows.Forms.Label room3;
        private System.Windows.Forms.Label room2;
        private System.Windows.Forms.Label room1;
        private System.Windows.Forms.Button backToCal;
    }
}