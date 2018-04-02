using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Задание 1
//Разработать текстовый редактор, организовать открытие/сохранение текстовых файлов.
//■ В панели инструментов расположить кнопки(Открыть, сохранить, новый документ, копировать, вырезать, вставить,
//отменить, кнопка настройки редактора(цвет шрифта, цвет фона, шрифт)).
//■ Меню должно дублировать панель инструментов(+ выделить все, + сохранить как);
//■ В Заголовке окна находится полный путь к файлу;
//■ Организовать контекстное меню для окна редактора(Копировать, Вырезать, Вставить, Отменить).


namespace WF_4
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFile;
        SaveFileDialog saveFile;


        public Form1()
        {
            InitializeComponent();
            //открываем файл - присваиваем событие кнопкам
            ToolStripMenuItem_OpenFile.Click += Open_File;
            toolStripButton_OpenFile.Click += Open_File;
            //сохраняем файл - присваиваем событие кнопкам
            toolStripButton_SaveFile.Click += Save_File;
            ToolStripMenuItem_Save.Click += Save_File;
            //создаем файл - присваиваем событие кнопкам
            toolStripButton_NewDocument.Click += Create_File;
            ToolStripMenuItem_NewDocument.Click += Create_File;
            // сохранить как
            ToolStripMenuItem_SaveAs.Click += SaveAs_File;
            // выделить все
            ToolStripMenuItem_SelectAll.Click += SelectAll;
            // копировать - присваиваем событие кнопкам
            ToolStripMenuItem_CopyContext.Click += Copy;
            toolStripButton_Copy.Click += Copy;
            ToolStripMenuItem_Copy.Click += Copy;
            // вставить  - присваиваем событие кнопкам
            ToolStripMenuItem_Insert.Click += Paste;
            ToolStripMenuItem_InsertContext.Click += Paste;
            toolStripButton_Insert.Click += Paste;
            // вырезать  - присваиваем событие кнопкам
            toolStripButton_Cut.Click += Cut;
            ToolStripMenuItem_Cut.Click += Cut;
            ToolStripMenuItem_CutContext.Click += Cut;
            // отменить последнее действие
            toolStripButton_Cancel.Click += Undo;
            ToolStripMenuItem_Cancel.Click += Undo;
            ToolStripMenuItem_CancelContext.Click += Undo;
            // цвет фона
            ToolStripMenuItem_BgColor2.Click += BgColor;
            ToolStripMenuItem_BgColor.Click += BgColor;
            // цвет шрифта
            ToolStripMenuItem_FontColor2.Click += FontColor;
            ToolStripMenuItem_FontColor.Click += FontColor;
            // шрифт
            ToolStripMenuItem_Font2.Click += Font;
            ToolStripMenuItem_Font.Click += Font;
        }

        public void Open_File(object sender, EventArgs e)
        {
            openFile = new OpenFileDialog();
            openFile.Filter = "All Files(*.*)|*.*|Txt files(*.txt)|*.txt";
            openFile.FilterIndex = 2;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(openFile.FileName, Encoding.UTF8);
                textBox1.Clear();
                textBox1.ReadOnly = false;
                textBox1.Text = reader.ReadToEnd();
                reader.Close();
                this.Text = openFile.FileName;
            }
        }

        public void Save_File(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(openFile.FileName);
            writer.Write(textBox1.Text);
            writer.Close();
            MessageBox.Show($"Файл {Path.GetFileName(openFile.FileName)} сохранен");
        }

        public void Create_File(object sender, EventArgs e)
        {
            //1. Появляется возможность вводить текст. Потом его можно сохранить стандартной процедурой Сохранить/ Сохранить как
            
            // textBox1.ReadOnly = false;

            //2. Создаем документ - сохраняем название и потом вводим текст.
            openFile = new OpenFileDialog();
            saveFile = new SaveFileDialog();
            saveFile.Filter = "All Files(*.*)|*.*|Txt files(*.txt)|*.txt";
            saveFile.FilterIndex = 2;
            if (saveFile.ShowDialog() == DialogResult.OK)
                if (!File.Exists(saveFile.FileName))
                {
                    FileStream newfile = File.Create(saveFile.FileName);
                    textBox1.ReadOnly = false;
                    newfile.Close();
                    openFile.FileName = saveFile.FileName;
                    Text = $"Файл - {openFile.FileName}";
                    MessageBox.Show($"Новый файл {Path.GetFileName(openFile.FileName)} создан");
                }
        }
        public void SaveAs_File(object sender, EventArgs e)
        {
            openFile = new OpenFileDialog();
            saveFile = new SaveFileDialog();
            saveFile.Filter = "All Files(*.*)|*.*|Txt files(*.txt)|*.txt";
            saveFile.FilterIndex = 2;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFile.FileName, false, Encoding.UTF8);
                writer.Write(textBox1.Text);
                writer.Close();
                openFile.FileName = saveFile.FileName;
                Text = $"Файл - {saveFile.FileName}";
                MessageBox.Show($"Файл {Path.GetFileName(openFile.FileName)} сохранен");
            }
        }

        public void SelectAll(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.SelectAll();
            }
            else
            {
                MessageBox.Show("Пусто. Нечего выделять.");
            }
        }

        public void Copy(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {
                textBox1.Copy();
            }
        }

        public void Paste(object sender, EventArgs e)
        {
            textBox1.Paste();
        }
        public void Cut(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != "")
            {
                textBox1.Cut();
            }
        }

        public void Undo(object sender, EventArgs e)
        {
            if (textBox1.CanUndo == true)
            {
                textBox1.Undo();
                //Удаляем из буфера отмены текстового поля сведения относительно последней операции.
                textBox1.ClearUndo();
            }
        }

        public void BgColor(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = dialog.Color;
            }
        }
        public void FontColor(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = dialog.Color;
            }
        }
        public void Font(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = dialog.Font;
            }
        }
    }
}
