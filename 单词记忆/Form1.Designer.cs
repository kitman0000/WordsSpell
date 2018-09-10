namespace 单词记忆
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LeftWordsLabel = new System.Windows.Forms.Label();
            this.ShowAnswerButton = new System.Windows.Forms.Button();
            this.DetailLabel = new System.Windows.Forms.Label();
            this.WordLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RememberButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(564, 389);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LeftWordsLabel);
            this.tabPage1.Controls.Add(this.ShowAnswerButton);
            this.tabPage1.Controls.Add(this.DetailLabel);
            this.tabPage1.Controls.Add(this.WordLabel);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.RememberButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(556, 363);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "未记忆";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tabPage1_PreviewKeyDown);
            // 
            // LeftWordsLabel
            // 
            this.LeftWordsLabel.AutoSize = true;
            this.LeftWordsLabel.Location = new System.Drawing.Point(6, 291);
            this.LeftWordsLabel.Name = "LeftWordsLabel";
            this.LeftWordsLabel.Size = new System.Drawing.Size(59, 12);
            this.LeftWordsLabel.TabIndex = 5;
            this.LeftWordsLabel.Text = "剩余单词:";
            // 
            // ShowAnswerButton
            // 
            this.ShowAnswerButton.Location = new System.Drawing.Point(213, 142);
            this.ShowAnswerButton.Name = "ShowAnswerButton";
            this.ShowAnswerButton.Size = new System.Drawing.Size(121, 24);
            this.ShowAnswerButton.TabIndex = 4;
            this.ShowAnswerButton.Text = "显示答案(空格)";
            this.ShowAnswerButton.UseVisualStyleBackColor = true;
            this.ShowAnswerButton.Click += new System.EventHandler(this.ShowAnswerButton_Click);
            // 
            // DetailLabel
            // 
            this.DetailLabel.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DetailLabel.Location = new System.Drawing.Point(8, 169);
            this.DetailLabel.Name = "DetailLabel";
            this.DetailLabel.Size = new System.Drawing.Size(542, 122);
            this.DetailLabel.TabIndex = 3;
            this.DetailLabel.Text = "label1";
            // 
            // WordLabel
            // 
            this.WordLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordLabel.Location = new System.Drawing.Point(3, 3);
            this.WordLabel.Name = "WordLabel";
            this.WordLabel.Size = new System.Drawing.Size(547, 96);
            this.WordLabel.TabIndex = 2;
            this.WordLabel.Text = "label1";
            this.WordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "不认识(W)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RememberButton
            // 
            this.RememberButton.Location = new System.Drawing.Point(0, 315);
            this.RememberButton.Name = "RememberButton";
            this.RememberButton.Size = new System.Drawing.Size(276, 47);
            this.RememberButton.TabIndex = 0;
            this.RememberButton.Text = "认识(回车)";
            this.RememberButton.UseVisualStyleBackColor = true;
            this.RememberButton.Click += new System.EventHandler(this.RememberButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.RefreshButton);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(556, 363);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "已记忆";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(3, 327);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(112, 33);
            this.RefreshButton.TabIndex = 1;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Location = new System.Drawing.Point(3, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(547, 319);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "单词";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "备注";
            this.columnHeader2.Width = 300;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 413);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label DetailLabel;
        private System.Windows.Forms.Label WordLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RememberButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ShowAnswerButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label LeftWordsLabel;
    }
}

