namespace task1Webserver
{
    partial class Bai2
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
            this.rtbx_HTML = new System.Windows.Forms.RichTextBox();
            this.txt_targetURL = new System.Windows.Forms.TextBox();
            this.txt_content = new System.Windows.Forms.TextBox();
            this.btn_POST = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbx_HTML
            // 
            this.rtbx_HTML.Location = new System.Drawing.Point(28, 115);
            this.rtbx_HTML.Name = "rtbx_HTML";
            this.rtbx_HTML.Size = new System.Drawing.Size(656, 312);
            this.rtbx_HTML.TabIndex = 0;
            this.rtbx_HTML.Text = "";
            // 
            // txt_targetURL
            // 
            this.txt_targetURL.Location = new System.Drawing.Point(28, 23);
            this.txt_targetURL.Name = "txt_targetURL";
            this.txt_targetURL.Size = new System.Drawing.Size(656, 20);
            this.txt_targetURL.TabIndex = 1;
            this.txt_targetURL.Text = "http://www.contoso.com/PostAccepter.aspx";
            // 
            // txt_content
            // 
            this.txt_content.Location = new System.Drawing.Point(28, 65);
            this.txt_content.Name = "txt_content";
            this.txt_content.Size = new System.Drawing.Size(656, 20);
            this.txt_content.TabIndex = 2;
            // 
            // btn_POST
            // 
            this.btn_POST.Location = new System.Drawing.Point(710, 23);
            this.btn_POST.Name = "btn_POST";
            this.btn_POST.Size = new System.Drawing.Size(75, 23);
            this.btn_POST.TabIndex = 3;
            this.btn_POST.Text = "POST";
            this.btn_POST.UseVisualStyleBackColor = true;
            this.btn_POST.Click += new System.EventHandler(this.btn_POST_Click);
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_POST);
            this.Controls.Add(this.txt_content);
            this.Controls.Add(this.txt_targetURL);
            this.Controls.Add(this.rtbx_HTML);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbx_HTML;
        private System.Windows.Forms.TextBox txt_targetURL;
        private System.Windows.Forms.TextBox txt_content;
        private System.Windows.Forms.Button btn_POST;
    }
}