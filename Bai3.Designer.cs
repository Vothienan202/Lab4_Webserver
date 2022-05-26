namespace task1Webserver
{
    partial class Bai3
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
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.rtbx_HTML = new System.Windows.Forms.RichTextBox();
            this.btn_download = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(45, 28);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(559, 20);
            this.txtURL.TabIndex = 0;
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(45, 64);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(559, 20);
            this.txt_path.TabIndex = 1;
            // 
            // rtbx_HTML
            // 
            this.rtbx_HTML.Location = new System.Drawing.Point(45, 106);
            this.rtbx_HTML.Name = "rtbx_HTML";
            this.rtbx_HTML.Size = new System.Drawing.Size(682, 317);
            this.rtbx_HTML.TabIndex = 2;
            this.rtbx_HTML.Text = "";
            // 
            // btn_download
            // 
            this.btn_download.Location = new System.Drawing.Point(630, 28);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(97, 20);
            this.btn_download.TabIndex = 3;
            this.btn_download.Text = "DOWNLOAD";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.rtbx_HTML);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.txtURL);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.RichTextBox rtbx_HTML;
        private System.Windows.Forms.Button btn_download;
    }
}