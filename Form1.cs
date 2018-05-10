using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace 한글패치병합
{
    public partial class Form1 : Form
    {

        List<string_string> originSTR = new List<string_string>();
        List<string_string> modSTR = new List<string_string>();
        string orignSTRinJob;
        string modSTRinJob;
        string backupFilePath;
        string replaceFilePath;

        public Form1()
        {
            InitializeComponent();

            /*Set Column Width*/
            ColumnHeader header = new ColumnHeader();
            header.Text = "줄번호";
            header.Name = "col0";
            listView_origin.Columns.Add(header);
            ColumnHeader headerValue = new ColumnHeader();
            headerValue.Text = "문자열";
            headerValue.Name = "col0";
            listView_origin.Columns.Add(headerValue);
            listView_origin.Columns[0].Width = -2;
            listView_origin.Columns[1].Width = 2000;
            

            ColumnHeader header2 = new ColumnHeader();
            header2.Text = "줄번호";
            header2.Name = "col0";
            listView_mod.Columns.Add(header2);
            ColumnHeader headerValue2 = new ColumnHeader();
            headerValue2.Text = "문자열";
            headerValue2.Name = "col0";
            listView_mod.Columns.Add(headerValue2);
            listView_mod.Columns[0].Width = -2;
            listView_mod.Columns[1].Width = 2000;
        }
 
        private void Btn_openfile_Click(object sender, EventArgs e)
        {
            listView_origin.Items.Clear();
            originSTR.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "txt";
            ofd.Filter = "text files (*.txt)|*.txt";
            ofd.ShowDialog();
            
            if (ofd.FileName.Length > 0)
            {
                replaceFilePath = Btn_openfile.Text = ofd.FileName;
                backupFilePath = System.IO.Path.GetDirectoryName(ofd.FileName) 
                    + @"\Backup_"
                    + DateTime.Now.ToString("MMddHHmmss")
                    + "_" 
                    + System.IO.Path.GetFileName(ofd.FileName);
            }
            else
            {
                return;
            }
            string path = ofd.FileName;
            orignSTRinJob = System.IO.File.ReadAllText(path);
            string[] lines = Regex.Split(orignSTRinJob, "\r\n");
            int i = 1;
            foreach (string str in lines) {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = "" + i;
                lvi.SubItems.Add(str);
                listView_origin.Items.Add(lvi);
                i++;
                originSTR.Add(splitStrByEqual(str));
            }
        }

        private void Btn_openfile2_Click(object sender, EventArgs e)
        {
            listView_mod.Items.Clear();
            modSTR.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "txt";
            ofd.Filter = "text files (*.txt)|*.txt";
            ofd.ShowDialog();
            if (ofd.FileName.Length > 0)
            {
                Btn_openfile2.Text = ofd.FileName;
            }
            else
            {
                return;
            }
            string path = ofd.FileName;
            modSTRinJob = System.IO.File.ReadAllText(path);
            string[] lines = Regex.Split(modSTRinJob, "\r\n");
            int i = 1;
            foreach (string str in lines)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = "" + i;
                lvi.SubItems.Add(str);
                listView_mod.Items.Add(lvi);
                i++;
                modSTR.Add(splitStrByEqual(str));
            }
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            compare(originSTR, modSTR);
        }

        private void button_exe_Click(object sender, EventArgs e)
        {
            if (checkBox_backup.Checked)
            {
                if (backupFilePath.Length > 1)
                {
                    Console.WriteLine(backupFilePath);
                    System.IO.File.WriteAllText(backupFilePath, orignSTRinJob, Encoding.UTF8);
                }
                else
                {
                    Console.WriteLine("잘못된 경로");
                }
            }

            merge(originSTR, modSTR, checkBox_addlast.Checked);

            if (checkBox_addlast.Checked)
            {
                Console.WriteLine("sdf");
            }


        }

        public string_string splitStrByEqual(string oneLine)
        {
            string_string str = new string_string();
            string searching_str = "=";
            bool has = oneLine.Contains(searching_str);
            if (has)
            {
                string[] temp = oneLine.Split('=');
                str.left = temp[0];
                str.right = temp[1];
            }
            return str;
        }

        public void compare(List<string_string> origin, List<string_string> mod)
        {

            foreach (ListViewItem lvw in listView_origin.Items)
            {
                lvw.BackColor = Color.White;
            }
            foreach (ListViewItem lvw in listView_mod.Items)
            {
                lvw.BackColor = Color.White;
            }
            
            List<int> modedLine = new List<int>();
            int j = 0;
            foreach (string_string modLine in mod)
            {
                int i = 0;
                foreach (string_string originLine in origin)
                {
                    if (originLine.left == modLine.left && !String.IsNullOrEmpty(originLine.left))
                    {
                        System.Console.WriteLine(i + "\t" + originLine.left + "\t" + originLine.Right);
                        listView_origin.Items[i].BackColor = Color.Yellow;
                        listView_mod.Items[j].BackColor = Color.Yellow;
                    }
                    i++;
                }
                j++;
            }
        }

        public void merge(List<string_string> origin, List<string_string> mod, bool endchecked)
        {
            List<string_string> forMergeOrigin = origin;
            List<string_string> forMergeMod = mod;
            List<string> alreadyused = new List<string>();
            Console.WriteLine(forMergeMod.Count);
            string complete = "";

            if (endchecked)
            {
                List<int> removeEle = new List<int>();
                foreach (string_string modLine in forMergeMod)
                {
                    int i = 0;
                    if (!alreadyused.Contains(modLine.left))
                    foreach (string_string originLine in forMergeOrigin)
                    {
                        if (originLine.left == modLine.left && !String.IsNullOrEmpty(originLine.left))
                        {
                            removeEle.Add(i);
                            alreadyused.Add(modLine.left);
                        }
                        i++;
                    }
                }
                removeEle.Sort(delegate (int a, int b) {
                    return b.CompareTo(a);
                });
                foreach(int removing in removeEle)
                {
                    forMergeOrigin.RemoveAt(removing);          //여기에러
                }
                foreach (string_string modLine in forMergeMod)
                {
                    forMergeOrigin.Add(modLine);
                }
                foreach (string_string modLine in forMergeOrigin)
                {
                    if(!String.IsNullOrEmpty(modLine.left))
                    complete += modLine.left + "=" + modLine.right + "\r\n";
                }
                Console.WriteLine(complete);
                Console.WriteLine(replaceFilePath);
                try
                {
                    System.IO.File.WriteAllText(replaceFilePath, complete, Encoding.UTF8);
                    MessageBox.Show("병합 완료");
                    System.Diagnostics.Process.Start("Notepad.exe", replaceFilePath);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
            {
                int i = 0;
                List<int> removeEle = new List<int>();
                foreach (string_string modLine in forMergeMod)
                {
                    foreach (string_string originLine in forMergeOrigin)
                    {
                        if (originLine.left == modLine.left && !String.IsNullOrEmpty(originLine.left))
                        {
                            originLine.Right = modLine.Right;
                            removeEle.Add(i);
                        }
                    }
                    i++;
                }
                removeEle.Sort(delegate (int a, int b) {
                    return b.CompareTo(a);
                } );
                
                foreach(int removing in removeEle)
                {
                    forMergeMod.RemoveAt(removing);
                }
                Console.WriteLine(forMergeMod.Count);

                foreach(string_string modLine in forMergeMod)
                {
                    forMergeOrigin.Add(modLine);
                }

                foreach(string_string modLine in forMergeOrigin)
                {
                    if (!String.IsNullOrEmpty(modLine.left))
                        complete += modLine.left + "=" + modLine.right + "\r\n";
                }

                Console.WriteLine(complete);
                Console.WriteLine(replaceFilePath);
                try
                {
                    System.IO.File.WriteAllText(replaceFilePath, complete, Encoding.UTF8);
                    MessageBox.Show("병합 완료");
                    System.Diagnostics.Process.Start("Notepad.exe", replaceFilePath);
                }
                catch (Exception e){
                    MessageBox.Show(e.Message);
                }
                
            }
        }
        
    }
}
