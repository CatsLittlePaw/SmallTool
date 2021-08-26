using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CopyTablesDB2DB.Functions
{
    class ReplaceText
    {
        private string replaceUrl { get; set; }
        private string searchText { get; set; }
        private string targetText { get; set; }
        private List<string> extension { get; set; }
        public ReplaceText(string replaceUrl, string searchText, string targetText, string extension)
        {
            this.replaceUrl = replaceUrl;
            this.searchText = searchText;
            this.targetText = targetText;
            this.extension = new List<string>(extension.Replace("*", "").Split(','));            
        }

        public void Replace()
        {
            Replace(replaceUrl);
        }

        public void Replace(string path)
        {
            foreach (string node in Directory.GetDirectories(path))
            {
                if (!string.IsNullOrEmpty(node))
                {
                    Replace(node);
                }                
            }

            foreach (string file in Directory.GetFiles(path))
            {
                string ext = Path.GetExtension(file);
                if (extension.Contains(ext))
                {
                    Encoding encoding = FileExtension.GetFileEncodeType(file); //取得檔案編碼
                    FileStream fs = File.Open(file, FileMode.Open);
                    string tmpFileUrl = Path.Combine(file.Substring(0, file.LastIndexOf(Path.DirectorySeparatorChar)),string.Concat("temp", ext));
                    FileStream tmpFile = File.Open(tmpFileUrl, FileMode.Create);                    
                    StreamReader sr = new StreamReader(fs, encoding);
                    StreamWriter sw = new StreamWriter(tmpFile, encoding);

                    try
                    {                       
                        string lineText;
                        while ((lineText = sr.ReadLine()) != null)
                        {
                            sw.WriteLine(lineText.Replace(searchText, targetText));
                        }
                    }
                    catch(Exception ex)
                    {
                        ex.Data.Add("FileName", file.Substring(file.LastIndexOf(Path.DirectorySeparatorChar) + 1));
                        tmpFile.Close();
                        File.Delete(tmpFileUrl);
                        throw ex;
                    }
                    finally
                    {
                        sr.Close();
                        sw.Close();
                        fs.Close();                                                
                    }                    
                    File.Delete(file);
                    tmpFile.Close();
                    File.Move(tmpFileUrl, file);
                }
            }
        }
    }
}
