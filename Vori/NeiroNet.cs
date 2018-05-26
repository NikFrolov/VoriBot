using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
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

            MessageBox.Show("Когда вы будите писать вопрос,то пишите егов ковычках и ставте полсе него знак припенания, а если - же это ключевое слово, то нажмите на кнопку 'Ключевое слово' и повторите действия, что и с фразой, только без знака припенания.", "Обратите внимание!");
        }

        public string Question;
        public string Answer;

        string PathToDialog = @".\NeiroSaves\Questions And Answers.txt";

        public bool KeyWord = false;

        private void NeiroLearnButton_Click(object sender, EventArgs e)
        {
            if (NeiroLearnTextBox.Text != " " || NeiroLearnTextBox.Text != "" || NeiroLearnTextBox.Text != "." || NeiroLearnTextBox.Text != "?" || NeiroLearnTextBox.Text != "!" || NeiroLearnTextBox.Text != ";" || NeiroLearnTextBox.Text != ":")
            {
                Question = NeiroLearnTextBox.Text;
                Answer = NeiroAnswerLabel.Text;

                using (var writer = new StreamWriter(PathToDialog, true))
                {
                    writer.WriteLine("if ( e.Result.Text == " + Question + " ) "+ writer.NewLine + "{ " + writer.NewLine + " l.Text = " + Answer + " ; " + writer.NewLine + "} " + writer.NewLine +"");
                };
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

        private void WrongLearnAnswerButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Хорошо, нажмите на кнопку 'Автоматически построить ответ' ещё раз, что бы перегенирировать ответ.", "Нейронная сеть");
        }

        private void BuildAnAnswerButton_Click(object sender, EventArgs e)
        {

        }
    }
}
