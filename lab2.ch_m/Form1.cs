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

namespace lab2.ch_m
{
    public partial class Form1 : Form
    {
        private string dirName = "Q:\\2";
        private string message = "";
        string[] files;
        string[] folders;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if(Directory.Exists(dirName))
            {
                DirShow();
            }
        }

        public void DirShow()
        {
            if (Directory.GetParent(dirName) == null)
            {
                btnDirBack.Enabled = false;
            }
            else
            {
                btnDirBack.Enabled = true;
            }
            lvDir.Clear();
            files = Directory.GetFiles(dirName);
            folders = Directory.GetDirectories(dirName);
            foreach (string file in files)
            {
                string[] s = file.Split('\\');
                lvDir.Items.Add(s[s.Length - 1]);
            }
            foreach (string folder in folders)
            {
                string[] s = folder.Split('\\');
                lvDir.Items.Add(s[s.Length - 1]);
            }
            rtbConsole.Text += dirName + "\n";
        }

        private void DirChange(string dir)
        {
            try
            {
                if(!Directory.Exists(@dir))
                {
                    throw new DirException("Ошибка. Заданного каталога не существует.");
                }
                else
                {
                    dirName = @dir;
                    message = "Каталог успешно изменён.\n";
                }
            }
            catch
            {
                message = "Ошибка. Заданный каталог не существует.\n";
            }
            finally
            {
                rtbConsole.Text += message;
            }
        }

        private void DirBack()
        {
            try
            {
                if (Directory.GetParent(dirName) == null)
                {
                    throw new DirException("Ошибка. Это родительский каталог");
                }
                else
                {
                    dirName = Directory.GetParent(dirName).ToString();
                }
            }
            catch
            {
                message = "Ошибка. Это родительский каталог.\n";
            }
            finally
            {
                rtbConsole.Text += message;
                DirShow();
            }
        }

        private void Del(string target)
        {
            string[] filer;
            try
            {
                foreach (string file in files)
                {
                    filer = file.Split('\\');
                    if (filer[filer.Length - 1] == target) File.Delete(file);
                }
                foreach (string dir in folders)
                {
                    filer = dir.Split('\\');
                    if (filer[filer.Length - 1] == target) Directory.Delete(dir);
                }
            }
            catch
            {
                message = "Ошибка. Каталог не найден.\n";
            }
        }
        private bool DelMany(string target)
        {

            try
            {
                if (target.IndexOf("*") == 0 && target.LastIndexOf("*") == target.Length - 1)
                {
                    foreach(string file in files)
                    {
                        if (file.Contains(target.Split('*')[1])) File.Delete(file);
                    }
                    foreach (string dir in folders)
                    {
                        if (dir.Contains(target.Split('*')[1])) Directory.Delete(dir);
                    }
                    return true;
                }
                else if(target.IndexOf("*") == 0)
                {
                    foreach (string file in files)
                    {
                        if (file.EndsWith(target.Split('*')[1])) File.Delete(file);
                    }
                    foreach (string dir in folders)
                    {
                        if (dir.EndsWith(target.Split('*')[1])) Directory.Delete(dir);
                    }
                    return true;
                }
                else
                {
                    foreach (string file in files)
                    {
                        if (file.StartsWith(target.Split('*')[0])) File.Delete(file);
                    }
                    foreach (string dir in folders)
                    {
                        if (dir.StartsWith(target.Split('*')[0])) Directory.Delete(dir);
                    }
                    return true;
                }
            }
            catch
            {
                message = "Ошибка. Каталог не найден.\n";
                return true;
            }
        }
        
        private void btnInput_Click(object sender, EventArgs e)
        {
            message = "";
            rtbConsole.Text += tbInput.Text + "\n";
            string[] command = tbInput.Text.Split(' ');
            try
            {
                if (command[0] == "cd")
                {
                    try
                    {
                        if (command.Length != 2)
                        {
                            throw new ConsoleException("Синтаксическая ошибка.");
                        }
                        else if (command[1] == "..")
                        {
                            DirBack();
                        }
                        else
                        {
                            DirChange(command[1]);
                        }
                    }
                    catch
                    {
                        message = "Синтаксическая ошибка. Пример: cd *path*\n";
                        rtbConsole.Text += message;
                    }
                }

                else if (command[0] == "rm")
                {
                    try
                    {
                        if (command.Length != 2)
                        {
                            throw new ConsoleException("Синтаксическая ошибка.");
                        }
                        else if (!command[1].Contains("*"))
                        {
                            Del(command[1]);
                        }
                        else
                        {
                            DelMany(command[1]);
                        }
                    }
                    catch
                    {
                        message = "Синтаксическая ошибка. Воспользуйтесь коммандой help для вывода доступных комманд.\n";
                        rtbConsole.Text += message;
                    }
                }

                else if (command[0] == "")
                {
                    throw new ConsoleException("Введите команду");
                }

                else if(command[0] == "help")
                {
                    rtbConsole.Text += "cd .. - переход в родительский каталог\n";
                    rtbConsole.Text += "cd *path* - изменить каталог\n";
                    rtbConsole.Text += "rm *file/directory name* - удалить файл/директорию";


                }
                else
                {
                    throw new ConsoleException("Команда не распознана.");
                }
            }
            catch
            {
                message = "Команда не распознана. Воспользуйтесь командой help для получения списка доступных команд.\n";
                rtbConsole.Text += message;
            }
            finally
            {
                DirShow();
                tbInput.Clear();
            }
        }

        private void btnDirBack_Click(object sender, EventArgs e)
        {
            DirBack();
        }
    }
}
