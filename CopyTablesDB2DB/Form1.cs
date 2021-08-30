using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using CopyTablesDB2DB.Functions;


namespace CopyTablesDB2DB
{
    public partial class Form1 : Form
    {    
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        /// <summary>
        /// 格式化字串   選擇輸入Table列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 2021/08/26  Chris Liao  Create  
        /// </history>
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;     //該值確定是否可以選擇多個檔案
            dialog.Title = "請選擇列表檔案";
            dialog.Filter = "文字檔(*.txt*)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file = dialog.FileName;
                inputUrl.Text = file;
            }            
        }

        /// <summary>
        /// 格式化字串   選擇產出路徑目錄
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 2021/08/26  Chris Liao  Create  
        /// </history>
        private void button2_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "選擇產出路徑";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "資料夾路徑不能為空", "提示");
                    return;
                }
                else
                {
                    outputUrl.Text = Path.Combine(dialog.SelectedPath, "OutputSQL.txt");
                }              
            }
        }

        /// <summary>
        /// 取代文字    選擇產出檔案目錄
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 2021/08/26  Chris Liao  Create  
        /// </history>
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "選擇目錄路徑";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "資料夾路徑不能為空", "提示");
                    return;
                }
                else
                {
                    ReplaceUrl.Text = dialog.SelectedPath;
                }
            }
        }

        /// <summary>
        /// 取代文字    產檔
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 2021/08/26  Chris Liao  Create  
        /// </history>
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                ReplaceText replaceFunc = new ReplaceText(ReplaceUrl.Text, SearchText.Text, TargetText.Text, Extension.Text);
                replaceFunc.Replace();
                MessageBox.Show("處理完成");
            }
            catch(Exception ex)
            {
                MessageBox.Show(string.Format("檔案{0}複製失敗，錯誤訊息:{1}", ex.Data["FileName"], ex.ToString()));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TextBox TB = new TextBox();
            TB.Name = "test";
            TB.Text = "new";
	        TB.Location = new Point(10, 10); 
	        TB.Size = new Size(40, 22); 
        }

        /// <summary>
        /// 格式化字串   產檔
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 2021/08/26  Chris Liao  Create  
        /// </history>
        private void GenerateSQL_Click(object sender, EventArgs e)
        {
            string[] paraList;
            string formatString = FormatString.Text;

            if (!string.IsNullOrEmpty(outputUrl.Text))
            {
                if (!Directory.Exists(outputUrl.Text.Substring(0, outputUrl.Text.LastIndexOf(Path.DirectorySeparatorChar))))
                {
                    MessageBox.Show("輸出路徑不存在", "提示");
                    return;
                }
            }
            else
            {
                MessageBox.Show("請選擇輸出路徑", "提示");
                return;
            }      

                     

            //檔案傳入列表作為參數
            if (!string.IsNullOrEmpty(inputUrl.Text))
            {
                if (!File.Exists(inputUrl.Text))
                {
                    MessageBox.Show("來源檔案不存在", "提示");
                    return;
                }              
                
                Encoding encoding = FileExtension.GetFileEncodeType(inputUrl.Text); //取得檔案編碼
                FileStream inputFile = new FileStream(inputUrl.Text, FileMode.Open);
                FileStream outputFile = new FileStream(outputUrl.Text, FileMode.Create);  //若檔案不存在則新增、存在則覆寫檔案。
                StreamReader inputReader = new StreamReader(inputFile, encoding);
                StreamWriter outputWriter = new StreamWriter(outputFile, encoding);

                try
                {
                    string lineText;
                    while ((lineText = inputReader.ReadLine()) != null)
                    {
                        string inputString = formatString;
                        inputString = inputString.Replace("{0}", lineText);                       
                        outputWriter.WriteLine(inputString);
                    }
                    MessageBox.Show("產出成功", "提示");
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    inputReader.Close();
                    outputWriter.Close();
                    inputFile.Close();
                    outputFile.Close();
                }         
            }                           
        }     
    }
}
