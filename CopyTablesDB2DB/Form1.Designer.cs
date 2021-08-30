using System.Collections.Generic;
using System.Windows.Forms;

namespace CopyTablesDB2DB
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {           
            this.TabPage = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.FormatString = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.GenerateSQL = new System.Windows.Forms.Button();
            this.outputUrl = new System.Windows.Forms.TextBox();
            this.inputUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Extension = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.TargetText = new System.Windows.Forms.TextBox();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ReplaceUrl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TabPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabPage
            // 
            this.TabPage.Controls.Add(this.tabPage1);
            this.TabPage.Controls.Add(this.tabPage2);
            this.TabPage.Location = new System.Drawing.Point(22, 13);
            this.TabPage.Name = "TabPage";
            this.TabPage.SelectedIndex = 0;
            this.TabPage.Size = new System.Drawing.Size(632, 448);
            this.TabPage.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.FormatString);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.GenerateSQL);
            this.tabPage1.Controls.Add(this.outputUrl);
            this.tabPage1.Controls.Add(this.inputUrl);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(624, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "格式化字串";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(14, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "格式化字串";
            // 
            // FormatString
            // 
            this.FormatString.Location = new System.Drawing.Point(143, 172);
            this.FormatString.Multiline = true;
            this.FormatString.Name = "FormatString";
            this.FormatString.Size = new System.Drawing.Size(357, 69);
            this.FormatString.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(517, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 28);
            this.button2.TabIndex = 20;
            this.button2.Text = "產出路徑";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(517, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 28);
            this.button3.TabIndex = 20;
            this.button3.Text = "選擇文件";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GenerateSQL
            // 
            this.GenerateSQL.Location = new System.Drawing.Point(245, 365);
            this.GenerateSQL.Name = "GenerateSQL";
            this.GenerateSQL.Size = new System.Drawing.Size(130, 38);
            this.GenerateSQL.TabIndex = 19;
            this.GenerateSQL.Text = "產生檔案";
            this.GenerateSQL.UseVisualStyleBackColor = true;
            this.GenerateSQL.Click += new System.EventHandler(this.GenerateSQL_Click);
            // 
            // outputUrl
            // 
            this.outputUrl.Location = new System.Drawing.Point(143, 111);
            this.outputUrl.Name = "outputUrl";
            this.outputUrl.Size = new System.Drawing.Size(357, 22);
            this.outputUrl.TabIndex = 13;
            // 
            // inputUrl
            // 
            this.inputUrl.Location = new System.Drawing.Point(143, 47);
            this.inputUrl.Name = "inputUrl";
            this.inputUrl.Size = new System.Drawing.Size(357, 22);
            this.inputUrl.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(24, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "輸出檔案";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(14, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "參數列表{0}";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Extension);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.TargetText);
            this.tabPage2.Controls.Add(this.SearchText);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.ReplaceUrl);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(624, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "取代文字";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Extension
            // 
            this.Extension.Location = new System.Drawing.Point(142, 122);
            this.Extension.Name = "Extension";
            this.Extension.Size = new System.Drawing.Size(146, 22);
            this.Extension.TabIndex = 9;
            this.Extension.Text = "*.sql*,*.txt*,*.xml*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(70, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "副檔名";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(251, 336);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 46);
            this.button4.TabIndex = 7;
            this.button4.Text = "執行";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // TargetText
            // 
            this.TargetText.Location = new System.Drawing.Point(142, 282);
            this.TargetText.Name = "TargetText";
            this.TargetText.Size = new System.Drawing.Size(360, 22);
            this.TargetText.TabIndex = 6;
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(142, 201);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(360, 22);
            this.SearchText.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(70, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "取代成";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(51, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "尋找目標";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "選取路徑";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReplaceUrl
            // 
            this.ReplaceUrl.Location = new System.Drawing.Point(142, 45);
            this.ReplaceUrl.Name = "ReplaceUrl";
            this.ReplaceUrl.Size = new System.Drawing.Size(360, 22);
            this.ReplaceUrl.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(51, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "目錄路徑";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 485);
            this.Controls.Add(this.TabPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "自製小工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabPage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
        
        private System.Windows.Forms.TabControl TabPage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button GenerateSQL;
        private System.Windows.Forms.TextBox outputUrl;
        private System.Windows.Forms.TextBox inputUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ReplaceUrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox TargetText;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Extension;
        private System.Windows.Forms.Label label8;


        /// <summary>
        /// 新增的Panel加入PanelList並修改列舉方便管理
        /// </summary>
        #region 自訂義變數區塊

        //private List<CheckBox> GenSqlPanel = new List<CheckBox>();
        private List<GroupBox> OptionPanel = new List<GroupBox>();

        #endregion
        private Label label3;
        private TextBox FormatString;



    }
}

