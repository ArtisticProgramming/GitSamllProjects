using NewLineRemover.XmlModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace NewLineRemover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            XmlManagment = new XmlManagment();


        }

        public long SqlNewNumberValue { get; set; }

        public XmlManagment XmlManagment { get; set; }

        private async void Form1_Load(object sender, EventArgs e)
        {


            var result = XmlManagment.Get(ConfigElements.IsActive, Modules.NewLineRemover);

            try
            {
                await WaitForItToWork();
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    string err = ex.InnerException.Message;
                }
            }


        }

        public static string LastText { get; set; }

        private void RemoveEnter()
        {
            var emptyLineCheckboxChecked = emptyLineCheckbox.Checked;
            var text = Clipboard.GetText();

            if (LastText == text)
                return;

            if (string.IsNullOrEmpty(text) == false)
            {
                text = text.Trim();
                var NewLine = Environment.NewLine;
                text = text.Replace(NewLine, " ");
                text = text.Replace(". ", "." + NewLine + (emptyLineCheckboxChecked ? NewLine : string.Empty));
                text = text.Replace(NewLine + " ", NewLine);
                text = text + (emptyLineCheckboxChecked ? NewLine + " " :string.Empty);
                textBox1.Text = text;
                if (string.IsNullOrEmpty(text) ==false)
                {
                    Clipboard.SetText(text);
                }
            }
            LastText = text;

        }

        async Task<bool> WaitForItToWork()
        {
            try
            {
                bool Checked = checkBox1.Checked;
                while (true)
                {
                    if (Checked)
                    {
                        RemoveEnter();
                    }
                    else
                    {
                        textBox1.Text = "!!!!!!!!!!!!!!APPLICATION IS INACTIVE!!!!!!!!!!!!!!";
                    }
                    Checked = checkBox1.Checked;
                    var sleepTime = Convert.ToInt32(textBox2.Text);
                    await Task.Delay(sleepTime); // arbitrary delay
                }
            }
            catch (Exception ex)
            {
                textBox1.Text = ex.ToString();
                throw ex;
            }
         
        }

        private async void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var Checked = checkBox1.Checked;
            if (Checked)
            {
                await WaitForItToWork();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                this.Hide();
                //notifyIcon1.BalloonTipTitle = "Minimize to Tray App";
                //notifyIcon1.BalloonTipText = "You have successfully minimized your form.";
                //notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                //notifyIcon1.ShowBalloonTip(100);
            }
        }

        private void notifyIcon1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sg_pullgit_Click(object sender, EventArgs e)
        {
            RunGitCommand();


            FindLastSqlScriptNumber();

        }

        private void FindLastSqlScriptNumber()
        {
            List<long> fileIds = new List<long>();
            var direc = Directory.GetFiles(sgPathTxt.Text);

            DirectoryInfo dirc = new DirectoryInfo(sgPathTxt.Text);
            foreach (var item in direc)
            {
                Regex regex = new Regex("\\d{4}.sql");
                var Matches = regex.Matches(item);
                foreach (var item2 in Matches)
                {
                    if (item2 != null)
                    {
                        fileIds.Add(Convert.ToInt32(item2.ToString().Replace(".sql", "")));
                    }
                }
            }
            if (fileIds.Any() == false)
            {
                Console.WriteLine("Opration Failed");
                Console.ReadLine();
                return;
            }

            var maxvalue = fileIds.Max();
            var sqlNewNumberValue = maxvalue + 1;
            SqlNewNumberValue = sqlNewNumberValue;
            sgLastSqlNumber.Text = string.Format("script_{0}.sql", sqlNewNumberValue.ToString());




            var lastFiles = dirc.GetFiles().OrderByDescending(x => x.LastWriteTime).Take(15);
            foreach (var item in lastFiles)
            {
                sgLastFiles.Text = sgLastFiles.Text + item.Name + Environment.NewLine;
            }


        }

        private void RunGitCommand()
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.CreateNoWindow = true;
            psi.RedirectStandardError = true;
            psi.RedirectStandardOutput = true;
            psi.FileName = "git.exe";
            psi.UseShellExecute = false;
            psi.WorkingDirectory = sgPathTxt.Text;
            psi.Arguments = "pull origin master";

            Process fetchProcess = new Process();
            fetchProcess.StartInfo = psi;
            fetchProcess.Start();
            string err = "";
            string stdout = "";
            //Both standard error and stdout are empty. But if argument is 
            // a git pull, then standard error and output are not empty.
            using (StreamReader myOutput = fetchProcess.StandardOutput)
            {
                stdout = myOutput.ReadToEnd();
            }
            using (StreamReader myError = fetchProcess.StandardError)
            {
                err = myError.ReadToEnd();
            }

            fetchProcess.WaitForExit();
            fetchProcess.Close();

            sg_stoutTxt.Text = stdout;
            sg_errTxt.Text = err;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(sgPathTxt.Text);
            }
            catch (Win32Exception win32Exception)
            {
                //The system cannot find the file specified...
                Console.WriteLine(win32Exception.Message);
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            FindLastSqlScriptNumber();

            var confirmResult = MessageBox.Show(string.Format("Are you sure to Genrate Sql File with this Name '{0}'?", sgLastSqlNumber.Text),
                                     "Genrate Sql Script",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (confirmResult == DialogResult.Yes)
            {
                GenrateSqlScript();
            }
            else
            {
                // If 'No', do something here.
            }
        }

        private void GenrateSqlScript()
        {
            var sqlScriptNumberSign = "#$ScriptNumber";
            var sqlBodySign = "#$Body";

            var currentDirc = Directory.GetCurrentDirectory();

            var templText = File.ReadAllText(currentDirc + @"\scriptTempl.sql");
            if (SqlNewNumberValue == 0)
            {
                throw new Exception("Sql Number Value is 0");
            }

            templText = templText.Replace(sqlScriptNumberSign, SqlNewNumberValue.ToString());
            var body = "------------Generated By Machine------------" + Environment.NewLine;

            body += GeneratSqlBody(templText, sqSec1.Text);
            body += GeneratSqlBody(templText, sqSec2.Text);
            body += GeneratSqlBody(templText, sqSec3.Text);
            body += GeneratSqlBody(templText, sqSec4.Text);
            body += GeneratSqlBody(templText, sqSec5.Text);
            body += GeneratSqlBody(templText, sqSec6.Text);
            body = body + Environment.NewLine;
            templText = templText.Replace(sqlBodySign, body);

            File.WriteAllText(sgPathTxt.Text + "\\" + sgLastSqlNumber.Text, templText);

            //try
            //{
            //    Process.Start(sgPathTxt.Text);
            //}
            //catch (Win32Exception win32Exception)
            //{
            //    //The system cannot find the file specified...
            //    Console.WriteLine(win32Exception.Message);
            //}
        }

        private string GeneratSqlBody(string templText, string sqlCommand)
        {
            var result = "";
            if (string.IsNullOrEmpty(sqlCommand) == false)
            {
                result = Environment.NewLine + @"EXEC(""" + Environment.NewLine + sqlCommand + @""")" + Environment.NewLine;
            }

            return result;

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
