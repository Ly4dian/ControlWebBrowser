namespace ControlWebBrowser
{
    partial class ControlWebBrowser
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtCurrentUrl = new System.Windows.Forms.TextBox();
            this.txtCordinateUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoSlow = new System.Windows.Forms.RadioButton();
            this.rdoStandard = new System.Windows.Forms.RadioButton();
            this.rdoFast = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFavGood = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txtLoginUser = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnLogin.Location = new System.Drawing.Point(12, 29);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtCurrentUrl
            // 
            this.txtCurrentUrl.Location = new System.Drawing.Point(186, 3);
            this.txtCurrentUrl.Name = "txtCurrentUrl";
            this.txtCurrentUrl.Size = new System.Drawing.Size(564, 19);
            this.txtCurrentUrl.TabIndex = 2;
            // 
            // txtCordinateUrl
            // 
            this.txtCordinateUrl.BackColor = System.Drawing.SystemColors.Info;
            this.txtCordinateUrl.Location = new System.Drawing.Point(186, 28);
            this.txtCordinateUrl.Name = "txtCordinateUrl";
            this.txtCordinateUrl.Size = new System.Drawing.Size(626, 19);
            this.txtCordinateUrl.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "CurrentURL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "CordinateURL";
            // 
            // rdoSlow
            // 
            this.rdoSlow.AutoSize = true;
            this.rdoSlow.Location = new System.Drawing.Point(453, 63);
            this.rdoSlow.Name = "rdoSlow";
            this.rdoSlow.Size = new System.Drawing.Size(47, 16);
            this.rdoSlow.TabIndex = 7;
            this.rdoSlow.TabStop = true;
            this.rdoSlow.Text = "Slow";
            this.rdoSlow.UseVisualStyleBackColor = true;
            // 
            // rdoStandard
            // 
            this.rdoStandard.AutoSize = true;
            this.rdoStandard.Location = new System.Drawing.Point(506, 63);
            this.rdoStandard.Name = "rdoStandard";
            this.rdoStandard.Size = new System.Drawing.Size(68, 16);
            this.rdoStandard.TabIndex = 8;
            this.rdoStandard.TabStop = true;
            this.rdoStandard.Text = "Standard";
            this.rdoStandard.UseVisualStyleBackColor = true;
            // 
            // rdoFast
            // 
            this.rdoFast.AutoSize = true;
            this.rdoFast.Location = new System.Drawing.Point(580, 63);
            this.rdoFast.Name = "rdoFast";
            this.rdoFast.Size = new System.Drawing.Size(46, 16);
            this.rdoFast.TabIndex = 9;
            this.rdoFast.TabStop = true;
            this.rdoFast.Text = "Fast";
            this.rdoFast.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "Speed";
            // 
            // btnFavGood
            // 
            this.btnFavGood.BackColor = System.Drawing.Color.White;
            this.btnFavGood.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnFavGood.Location = new System.Drawing.Point(12, 54);
            this.btnFavGood.Name = "btnFavGood";
            this.btnFavGood.Size = new System.Drawing.Size(75, 23);
            this.btnFavGood.TabIndex = 11;
            this.btnFavGood.Text = "FavGood";
            this.btnFavGood.UseVisualStyleBackColor = false;
            this.btnFavGood.Click += new System.EventHandler(this.btnFavGood_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnStart.Location = new System.Drawing.Point(12, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 94);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(835, 527);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.webBrowser1_PreviewKeyDown);
            // 
            // txtLoginUser
            // 
            this.txtLoginUser.Location = new System.Drawing.Point(692, 61);
            this.txtLoginUser.Name = "txtLoginUser";
            this.txtLoginUser.ReadOnly = true;
            this.txtLoginUser.Size = new System.Drawing.Size(120, 19);
            this.txtLoginUser.TabIndex = 13;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSearch.Location = new System.Drawing.Point(756, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(657, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "User";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(47, 9);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 16);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "お気に入り";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(128, 9);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(52, 16);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "ふぁぼ";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Location = new System.Drawing.Point(395, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 35);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Location = new System.Drawing.Point(186, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 35);
            this.panel2.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "Macro";
            // 
            // ControlWebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(836, 621);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtLoginUser);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnFavGood);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdoFast);
            this.Controls.Add(this.rdoStandard);
            this.Controls.Add(this.rdoSlow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCordinateUrl);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.txtCurrentUrl);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "ControlWebBrowser";
            this.Text = "うぇありすたも忙しい";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlWebBrowser_MouseDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtCurrentUrl;
        private System.Windows.Forms.TextBox txtCordinateUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoSlow;
        private System.Windows.Forms.RadioButton rdoStandard;
        private System.Windows.Forms.RadioButton rdoFast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFavGood;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox txtLoginUser;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
    }
}

