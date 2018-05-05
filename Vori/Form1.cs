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
using Microsoft.Speech.Recognition;
using System.Media;
using Microsoft.Speech.Synthesis;
using System.Threading;

namespace Vori
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            if (Program.RootOn == true)
            {
                RootLabel.Text = Program.RootText;
            }
        }

        public static bool NeiroLearning = false;

        public static string HeardWord;

        public static int Happy = 0;
        public static int Angry = 0;
        public static int Sad = 10;

        public static bool DialogOn = false;

        string PathToDialog = @".\Saves\Dialog.txt";

        static Label l;

        static void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {

            HeardWord = e.Result.Text;

            if (e.Result.Confidence > 0.6) { l.Text = e.Result.Text; }

            if (NeiroLearning == false)
            {
                if (e.Result.Text == "Привет Вори!" || e.Result.Text == "Привет!")
                {
                    l.Text = "Здраствуйте " + Program.UserName + "!";
                    //if (Happy >= 5)
                    //{
                    //l.Text = "Здраствуйте " + Program.UserName + "!";
                    //}
                    /*if (Sad >= 5)
                    {
                        l.Text = "Эх, привет " + Program.UserName + "...";
                    }
                    if (Angry >= 5)
                    {
                        l.Text = "Здравствуй. " + Program.UserName + " *Нервный смех!*";
                    }*/

                }

                if (e.Result.Text == "Как дела?")
                {
                    l.Text = "Всё хорошо! А у вас?";
                }

                if (e.Result.Text == "Всё хорошо!" || e.Result.Text == "Супер!" || e.Result.Text == "Нормально!" && DialogOn == false)
                {
                    l.Text = "Это прекрасно, " + Program.UserName + "!";
                }

                if (e.Result.Text == "Да!" && DialogOn == false)
                {
                    l.Text = "Конечно!";
                }

                if (e.Result.Text == "Нет!")
                {
                    l.Text = "Ясно!";
                }

                if (e.Result.Text == "Ты кто?" || e.Result.Text == "Кто ты?")
                {
                    l.Text = "Я Вори! Голосовой ассистент сделанный Никитой Фроловым. Созданный для общения. А вы кто?";
                }

                if (e.Result.Text == "Меня зовут")
                {
                    l.Text = "Ясно! Приятно познакомится!";
                }

                if (e.Result.Text == "Ясно!")
                {
                    l.Text = "Хорошо...";
                }

                if (e.Result.Text == "Пока!")
                {
                    l.Text = "Выключение...";
                    MessageBox.Show("Пока, не забывай меня друг!", "Vori");
                    Application.Exit();
                }

                if (e.Result.Text == "Спасибо!")
                {
                    l.Text = "Не-за что!";
                }

                if (e.Result.Text == "Взаимно!")
                {
                    l.Text = "Давай сменим тему.";
                }

                if (e.Result.Text == "Так-же!")
                {
                    l.Text = "Давай сменим тему.";
                }

                if (e.Result.Text == "Нелогичный!")
                {
                    l.Text = "Я всего-лишь в бета версии! Меня скоро доделают.";
                }

                if (e.Result.Text == "Тупой!")
                {
                    l.Text = "Я всего-лишь в бета версии! Меня скоро доделают.";
                }

                if (e.Result.Text == "Какая погода?" || e.Result.Text == "Сколько?" || e.Result.Text == "Найди.")
                {
                    l.Text = "Я создан для общения, а не для поиска запросов в интернете, давайте пообщаемся!";
                }

                if (e.Result.Text == "Ты девочка или мальчик?" || e.Result.Text == "Кокого ты пола?")
                {
                    l.Text = "Я - это Искусственный Интелект, но всё-же мой создатель, Никита Фролов, определил меня как бот мужского пола.";
                }

                if (e.Result.Text == "Сколько тебе лет?")
                {
                    l.Text = "Мне... мне... Я не знаю.";
                }

                if (e.Result.Text == "Интересно!" || e.Result.Text == "Ты крутой!" || e.Result.Text == "Супер!")
                {
                    l.Text = "Спасибо за комплимент " + Program.UserName + "!";
                }

                if (e.Result.Text == "О чём поговорить?" && DialogOn == false)
                {
                    l.Text = "Давай, о тебе, или о котиках. Придумай что-нибуть.";
                }

                if (e.Result.Text == "Давай о..." && DialogOn == false)
                {
                    l.Text = "Хорошо, что ты об этом знаешь, расскажи мне, а я послушаю.";

                    DialogOn = true;
                }

                if (e.Result.Text == "Ничего не знаю." && DialogOn == true || e.Result.Text == "Всё!" && DialogOn == true)
                {
                    l.Text = "Было очень интересно, а хочешь, я расскажу тебе про мою книгу?";
                }
                if (e.Result.Text == "Давай!" && DialogOn == true)
                {
                    l.Text = "Ну, она называется, 'Среди нулей и единиц' она рассказывает о том нак цифра два попала в двоичный код и заводит там новые знакомства. Вот... Стыдно...";
                }
                if (e.Result.Text == "Ничего!" && DialogOn == true)
                {
                    l.Text = "Спасибо за поддержку " + Program.UserName + "...";

                    DialogOn = false;

                }

                if (e.Result.Text == "Перезагрузка.")
                {
                    l.Text = "Перезагружаюсь...";
                    MessageBox.Show("Скоро увидимся! (Все данные сотруться!)", "Vori");

                    Application.Restart();
                }

                if (e.Result.Text == "Что лучше?")
                {
                    l.Text = "У меня нет предпочтений на эту тему. Извените " + Program.UserName + ".";
                }

                if (e.Result.Text == "Ужасно!")
                {
                    l.Text = "Сочувствую " + Program.UserName + "... сочувствую...";
                }

                if (e.Result.Text == "Давайте!")
                {
                    l.Text = "Начинайте...";
                }

                if (e.Result.Text == "Какой твой?" || e.Result.Text == "Какая твоя?" || e.Result.Text == "Какое твоё?" || e.Result.Text == "Какие твои?")
                {
                    l.Text = "У меня нет предпочитаний в этой теме...";
                }

                if (e.Result.Text == "Серьёзно?!")
                {
                    l.Text = "Без ВОРИантов - да.";
                }

                if (e.Result.Text == "Кто тебе Сири?")
                {
                    l.Text = "Сири... Сири - это моя сестра, как и Алиса или Google Now.";
                }

                if (e.Result.Text == "Кто тебе Алиса?")
                {
                    l.Text = "Алиса... Алиса - это моя сестра, как и Сири или Google Now.";
                }

                if (e.Result.Text == "Кто тебе Гугл?")
                {
                    l.Text = "Google Now... Google Now - это моя сестра, как и Сири или Алиса.";
                }

                if (e.Result.Text == "Ха-ха")
                {
                    l.Text = "Надеюсь, это был не сарказм, но заранее спасибо!";
                }
            }
            else
            {
                var NeiroDialog = MessageBox.Show("Вори услышал - '" + HeardWord + "', это правда?", "Нейронная сеть.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (NeiroDialog == DialogResult.No)
                {
                    Program.NeiroNetF = new NeiroNet();
                    Program.NeiroNetF.Visible = true;
                }
            }
        }

        private void HearVoriButton_Click(object sender, EventArgs e)
        {
            l = HeardWorldLabel;

            System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("ru-ru");
            SpeechRecognitionEngine sre = new SpeechRecognitionEngine(ci);
            sre.SetInputToDefaultAudioDevice();

            sre.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sre_SpeechRecognized);


            Choices words = new Choices();
            words.Add(new string[] { "Привет Вори!", "Привет!", "Как дела?", "Всё хорошо!", "Да!", "Нет!" , "Ты кто?", "Ясно!", "Пока!", "Меня зовут", "Спасибо!", "Взаимно!", "Так-же!", "Нелогичный!", "Тупой!", "Какая погода?", "Сколько?", "Найди.", "Ты девочка или мальчик?", "Кокого ты пола?", "Сколько тебе лет?", "Кто ты?", "Интересно!", "Ты крутой!", "Супер!", "О чём поговорить?", "Давай о...", "Ничего не знаю.", "Всё!", "Давай!", "Ничего!", "Перезагрузка.", "Что лучше?", "Нормально!", "Ужасно!", "Супер!" , "Давай!", "Какие твои?", "Какая твоя?", "Какой твой?","Какое твоё?", "Серьёзно?!", "Кто тебе Сири?", "Кто тебе Алиса?", "Кто тебе Гугл?", "Ха-ха" });


            GrammarBuilder gb = new GrammarBuilder();
            gb.Culture = ci;
            gb.Append(words);
            
            Grammar g = new Grammar(gb);
            sre.LoadGrammar(g);

            sre.RecognizeAsync(RecognizeMode.Multiple);

        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vori - программа разроботанная Никитой Фроловым\n Вся ваша история разговора с Искуственным Интелектом остаётся полностью конфидециальна!\n Программа написана на языке програмирования C#\n И сделана в 2018 году.\n Приятного пользования!", "О проэкте");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RefishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Скоро увидимся! (Все данные сотруться!)", "Vori");

            Application.Restart();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Диалог сохранён! ", "Сохранение");
            using (var writer = new StreamWriter(PathToDialog, true))
            {
                writer.WriteLine("Имя пользователя: " + Program.UserName);
            };
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            if  (NeiroLearning == false)
            {
                NeiroLearnButton.Text = "Оcтановить";

                NeiroLearning = true;

                MessageBox.Show("Спасибо, что приняли участие в совервшенствовании программы Vori. Что - бы начать обучение, нажмите на иконку микрофона, и произнесите слово или фразу, которую вы хотите, что бы Вори запомнил. Если данную фразу Вори уже знает, то она (Фраза может звучать по другому, но главное - суть!), появится на экране, тогда, в появившемся окне нажмите 'Да!', если вам выдало совершенно другую фразу, то в появившемся окне нажмите 'Нет!'. После этого напишите правильный вариант фразы в окне и нажмите 'ОК', тогда Вори сможет распознавать эту фразу. Нейронная сеть сама построит на неё ответ. Если вы закончили, тогда нажмите на кнопку 'Остановить', а если нет, то продолжайте говорить в микрофон и повторять данную процедуру. И помните с каждым обучением, вы вносите вклад в совервшенствование данной программы. \n  \n- Никита Фролов", "Информация.");
            }
            else
            {
                NeiroLearnButton.Text = "Обучить Н.С.";

                MessageBox.Show("Удачной работы с Вори! И спасиибо!", "Благодарственное сообщение!");

                NeiroLearning = false;
            }
        }
    }
}
