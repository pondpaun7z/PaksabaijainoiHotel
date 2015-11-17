namespace PaksabaijainoiHotel
{
    partial class StartProgramForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartProgramForm));
            this.menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.AllowDrop = true;
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu.FlatAppearance.BorderSize = 0;
            this.menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.menu.ForeColor = System.Drawing.Color.Transparent;
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.Location = new System.Drawing.Point(240, 331);
            this.menu.Margin = new System.Windows.Forms.Padding(0);
            this.menu.Name = "menu";
            this.menu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menu.Size = new System.Drawing.Size(122, 64);
            this.menu.TabIndex = 0;
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // StartProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 401);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartProgramForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "- ● พั ก ส บ า ย จ่ า ย น้ อ ย ● -";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button menu;
    }
}