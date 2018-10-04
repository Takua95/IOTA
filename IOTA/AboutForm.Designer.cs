namespace Test
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.label1 = new System.Windows.Forms.Label();
            this.Link = new System.Windows.Forms.LinkLabel();
            this.closeWindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "This program was built for the intention of \r\nmaking a bunch of grown ass adults " +
    "at college \r\nashamed of their lack of programming skills.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Link
            // 
            this.Link.Location = new System.Drawing.Point(12, 279);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(375, 15);
            this.Link.TabIndex = 2;
            this.Link.TabStop = true;
            this.Link.Text = "IOTA Website";
            this.Link.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // closeWindow
            // 
            this.closeWindow.Location = new System.Drawing.Point(308, 323);
            this.closeWindow.Name = "closeWindow";
            this.closeWindow.Size = new System.Drawing.Size(75, 23);
            this.closeWindow.TabIndex = 3;
            this.closeWindow.Text = "Close";
            this.closeWindow.UseVisualStyleBackColor = true;
            this.closeWindow.Click += new System.EventHandler(this.closeWindow_Click_1);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Test.Properties.Resources.IOTA3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(399, 361);
            this.Controls.Add(this.closeWindow);
            this.Controls.Add(this.Link);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Enabled = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel Link;
        private System.Windows.Forms.Button closeWindow;
    }
}