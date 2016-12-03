namespace BaiTapLon
{
    partial class Form1
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
            this.lstHienThi = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstHienThi
            // 
            this.lstHienThi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstHienThi.FormattingEnabled = true;
            this.lstHienThi.ItemHeight = 24;
            this.lstHienThi.Location = new System.Drawing.Point(0, 0);
            this.lstHienThi.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lstHienThi.Name = "lstHienThi";
            this.lstHienThi.Size = new System.Drawing.Size(937, 340);
            this.lstHienThi.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 338);
            this.Controls.Add(this.lstHienThi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "School Bus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstHienThi;
    }
}

