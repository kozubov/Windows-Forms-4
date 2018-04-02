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

//Задание 3
//Создайте Windows Forms приложение
//■ Добавьте на него текстовое поле с именем TopLevelMenu;
//■ Добавьте текстовое поле с именем SubItem;
//■ Добавьте кнопку «Добавить пункт меню»;
//■ Добавьте кнопку «Добавить подменю»;
//■ При нажатии на кнопку «Добавить пункт меню» должен
//добавляться пункт меню верхнего уровня, с именем указанным в поле TopLevelMenu;
//■ При нажатии на кнопку «Добавить подменю» в текущее
//меню должен добавляться подпункт меню с именем указанным в поле SubItem.

namespace WF_4_3
{
    public partial class Form1 : Form
    {
        MenuStrip m = new MenuStrip();
        ToolStripMenuItem TopMenu;
        bool control = false;
        public Form1()
        {
            InitializeComponent();
            Text = "Создание меню";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_AddMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox_AddMenuItem.Text != "")
            {
                TopMenu = (ToolStripMenuItem)m.Items.Add(textBox_AddMenuItem.Text);
                this.Controls.Add(m);
            }
            else
            {
                MessageBox.Show("Введите название пункта меню");
            }
        }

        private void button_AddMenuSubItem_Click(object sender, EventArgs e)
        {
            if (textBox_AddMenuSubItem.Text != "")
            {
                foreach (Control c in Controls)
                {
                    if (c.GetType() == typeof(MenuStrip))
                    {
                        foreach (var item in ((MenuStrip)c).Items)
                        {
                            TopMenu = (ToolStripMenuItem)item;
                            if (TopMenu.Text == textBox_AddMenuItem.Text)
                            {
                                //добавляем выпадающее меню для пункта
                                TopMenu.DropDownItems.Add(textBox_AddMenuSubItem.Text);
                                control = true;
                            }
                        }
                    }
                }
            }
            if (control == false)
            {
                MessageBox.Show("Меню не найдено");
            }
            control = false;
        }
    }
}
