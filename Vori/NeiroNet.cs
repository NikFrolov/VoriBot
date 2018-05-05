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
    public partial class NeiroNet : Form
    {
        public NeiroNet()
        {
            InitializeComponent();

            MessageBox.Show("Когда вы будите писать вопрос, то ставте полсе него знак припенания, а если - же это ключевое слово, то нажмите на кнопку 'Ключевое слово'", "Обратите внимание!");
        }

        public string Question;

        public bool KeyWord = false;

        private void NeiroLearnButton_Click(object sender, EventArgs e)
        {
            if (NeiroLearnTextBox.Text != " " || NeiroLearnTextBox.Text != "" || NeiroLearnTextBox.Text != "." || NeiroLearnTextBox.Text != "?" || NeiroLearnTextBox.Text != "!" || NeiroLearnTextBox.Text != ";" || NeiroLearnTextBox.Text != ":")
            {
                Question = NeiroLearnTextBox.Text;
            }
        }

        private void KeyWordButton_Click(object sender, EventArgs e)
        {
            if (KeyWord == false)
            {
                KeyWordButton.Text = "|V| Ключевое слово";

                KeyWord = true;
            }
            else
            {
                KeyWordButton.Text = "|X| Ключевое слово";

                KeyWord = false;
            }
        }

        private void CancelNeiroLearnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
