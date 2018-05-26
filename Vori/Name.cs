using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vori
{
    public partial class NameForm : Form
    {
        int XWindow = 268;
        int YWindow = 184;

        public NameForm()
        {
            InitializeComponent();

            GRButton.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == " " || NameTextBox.Text == "" || NameTextBox.Text == "Vori" || NameTextBox.Text == "Вори")
            {

                MessageBox.Show("Введённое вами имя - некорректно!", "Предупреждение!");

            }
            else
            {
                if (NameTextBox.Text == "root")
                {
                    GRButton.Visible = true;

                    PasswordTextBox.Visible = true;

                    NameTextBox.Enabled = false;

                    ReadyButton.Visible = false;

                    this.Size = new Size(XWindow, YWindow);
                    this.MaximumSize = new Size(XWindow, YWindow);
                    this.MinimumSize = new Size(XWindow, YWindow);

                    MessageBox.Show("У вас нет права доступа к root правам! Введите пароль в нижнее поле!", "Ошибка!");
                }
                else
                {
                    Program.UserName = NameTextBox.Text;

                    this.Visible = false;
                    Program.VoriF = new MainForm();
                    Program.VoriF.Visible = true;
                }


            }
        }

        private void GRButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "6dx3aG5w5kMMgEBPLCdi")
            {
                Program.RootOn = true;

                

                MessageBox.Show("Root права были выданы вам...", "root");

                Program.UserName = "root";

                this.Visible = false;
                Program.VoriF = new MainForm();
                Program.VoriF.Visible = true;
            }
            else
            {

                MessageBox.Show("Root права не были активированы, и на время сеанса программы, у вас забирают имя \n и Вори не будет обращатся к вам по имени...", "Попытка взлома!!!");

                Program.UserName = "";

                this.Visible = false;
                Program.VoriF = new MainForm();
                Program.VoriF.Visible = true;
            }
        }
    }
}


