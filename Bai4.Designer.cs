namespace task1Webserver
{
    partial class Bai4
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
            this.txt_URL = new System.Windows.Forms.TextBox();
            this.WebBrowser = new System.Windows.Forms.WebBrowser();
            this.btn_HOME = new System.Windows.Forms.Button();
            this.btn_BACK = new System.Windows.Forms.Button();
            this.btn_FORWARD = new System.Windows.Forms.Button();
            this.btn_REFRESH = new System.Windows.Forms.Button();
            this.btn_SOURCE = new System.Windows.Forms.Button();
            this.btn_SEARCH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_URL
            // 
            this.txt_URL.Location = new System.Drawing.Point(23, 12);
            this.txt_URL.Name = "txt_URL";
            this.txt_URL.Size = new System.Drawing.Size(614, 20);
            this.txt_URL.TabIndex = 0;
            // 
            // WebBrowser
            // 
            this.WebBrowser.Location = new System.Drawing.Point(23, 96);
            this.WebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowser.Name = "WebBrowser";
            this.WebBrowser.Size = new System.Drawing.Size(744, 328);
            this.WebBrowser.TabIndex = 1;
            // 
            // btn_HOME
            // 
            this.btn_HOME.Location = new System.Drawing.Point(23, 47);
            this.btn_HOME.Name = "btn_HOME";
            this.btn_HOME.Size = new System.Drawing.Size(75, 23);
            this.btn_HOME.TabIndex = 2;
            this.btn_HOME.Text = "HOME";
            this.btn_HOME.UseVisualStyleBackColor = true;
            this.btn_HOME.Click += new System.EventHandler(this.btn_HOME_Click);
            // 
            // btn_BACK
            // 
            this.btn_BACK.Location = new System.Drawing.Point(135, 47);
            this.btn_BACK.Name = "btn_BACK";
            this.btn_BACK.Size = new System.Drawing.Size(75, 23);
            this.btn_BACK.TabIndex = 3;
            this.btn_BACK.Text = "BACK";
            this.btn_BACK.UseVisualStyleBackColor = true;
            this.btn_BACK.Click += new System.EventHandler(this.btn_BACK_Click);
            // 
            // btn_FORWARD
            // 
            this.btn_FORWARD.Location = new System.Drawing.Point(259, 47);
            this.btn_FORWARD.Name = "btn_FORWARD";
            this.btn_FORWARD.Size = new System.Drawing.Size(75, 23);
            this.btn_FORWARD.TabIndex = 4;
            this.btn_FORWARD.Text = "FORWARD";
            this.btn_FORWARD.UseVisualStyleBackColor = true;
            this.btn_FORWARD.Click += new System.EventHandler(this.btn_FORWARD_Click);
            // 
            // btn_REFRESH
            // 
            this.btn_REFRESH.Location = new System.Drawing.Point(378, 47);
            this.btn_REFRESH.Name = "btn_REFRESH";
            this.btn_REFRESH.Size = new System.Drawing.Size(75, 23);
            this.btn_REFRESH.TabIndex = 5;
            this.btn_REFRESH.Text = "REFRESH";
            this.btn_REFRESH.UseVisualStyleBackColor = true;
            this.btn_REFRESH.Click += new System.EventHandler(this.btn_REFRESH_Click);
            // 
            // btn_SOURCE
            // 
            this.btn_SOURCE.Location = new System.Drawing.Point(492, 47);
            this.btn_SOURCE.Name = "btn_SOURCE";
            this.btn_SOURCE.Size = new System.Drawing.Size(130, 23);
            this.btn_SOURCE.TabIndex = 7;
            this.btn_SOURCE.Text = "VIEW SOURCE";
            this.btn_SOURCE.UseVisualStyleBackColor = true;
            this.btn_SOURCE.Click += new System.EventHandler(this.btn_SOURCE_Click);
            // 
            // btn_SEARCH
            // 
            this.btn_SEARCH.Location = new System.Drawing.Point(658, 12);
            this.btn_SEARCH.Name = "btn_SEARCH";
            this.btn_SEARCH.Size = new System.Drawing.Size(109, 23);
            this.btn_SEARCH.TabIndex = 8;
            this.btn_SEARCH.Text = "SEARCH";
            this.btn_SEARCH.UseVisualStyleBackColor = true;
            this.btn_SEARCH.Click += new System.EventHandler(this.btn_SEARCH_Click);
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_SEARCH);
            this.Controls.Add(this.btn_SOURCE);
            this.Controls.Add(this.btn_REFRESH);
            this.Controls.Add(this.btn_FORWARD);
            this.Controls.Add(this.btn_BACK);
            this.Controls.Add(this.btn_HOME);
            this.Controls.Add(this.WebBrowser);
            this.Controls.Add(this.txt_URL);
            this.Name = "Bai4";
            this.Text = "Bai4";
            this.Load += new System.EventHandler(this.Bai4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_URL;
        private System.Windows.Forms.WebBrowser WebBrowser;
        private System.Windows.Forms.Button btn_HOME;
        private System.Windows.Forms.Button btn_BACK;
        private System.Windows.Forms.Button btn_FORWARD;
        private System.Windows.Forms.Button btn_REFRESH;
        private System.Windows.Forms.Button btn_SOURCE;
        private System.Windows.Forms.Button btn_SEARCH;
    }
}