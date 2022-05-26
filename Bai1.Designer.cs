namespace task1Webserver
{
    partial class Bai1
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
            this.rtxb_HTML = new System.Windows.Forms.RichTextBox();
            this.txb_url = new System.Windows.Forms.TextBox();
            this.btn_get = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxb_HTML
            // 
            this.rtxb_HTML.Location = new System.Drawing.Point(47, 70);
            this.rtxb_HTML.Name = "rtxb_HTML";
            this.rtxb_HTML.Size = new System.Drawing.Size(645, 350);
            this.rtxb_HTML.TabIndex = 0;
            this.rtxb_HTML.Text = "";
            // 
            // txb_url
            // 
            this.txb_url.Location = new System.Drawing.Point(47, 27);
            this.txb_url.Name = "txb_url";
            this.txb_url.Size = new System.Drawing.Size(645, 20);
            this.txb_url.TabIndex = 1;
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(713, 24);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(75, 23);
            this.btn_get.TabIndex = 2;
            this.btn_get.Text = "GET";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.txb_url);
            this.Controls.Add(this.rtxb_HTML);
            this.Name = "Bai1";
            this.Text = "Bai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxb_HTML;
        private System.Windows.Forms.TextBox txb_url;
        private System.Windows.Forms.Button btn_get;
    }
}