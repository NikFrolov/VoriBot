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
using System.Speech.Synthesis;
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

        string[] QuestionsArray = { "Привет Вори!", "Привет!", "Как дела?", "Всё хорошо!", "Да!", "Нет!", "Ты кто?", "Ясно!", "Пока!", "Меня зовут", "Спасибо!", "Взаимно!", "Так-же!", "Нелогичный!", "Тупой!", "Какая погода?", "Сколько?", "Найди.", "Ты девочка или мальчик?", "Кокого ты пола?", "Сколько тебе лет?", "Кто ты?", "Интересно!", "Ты крутой!", "Супер!", "О чём поговорить?", "Давай о...", "Ничего не знаю.", "Всё!", "Давай!", "Ничего!", "Перезагрузка.", "Что лучше?", "Нормально!", "Ужасно!", "Супер!", "Давай!", "Какие твои?", "Какая твоя?", "Какой твой?", "Какое твоё?", "Серьёзно?!", "Кто тебе Сири?", "Кто тебе Алиса?", "Кто тебе Гугл?", "Ха-ха", "Сегодня мы...", "Завтра мы...", "Мяу!", "Гав!", "Спой!", "Спой песню!" };

        static SpeechSynthesizer ss = new SpeechSynthesizer();     

        public static bool NeiroLearning = false;

        public static string HeardWord;

        public static int Happy = 0;
        public static int Angry = 0;
        public static int Sad = 10;

        public static SoundPlayer SongVoriSingPlayer = new SoundPlayer(@".\Sounds\Minus of Still Alive For Vori.wav");

        public static bool DialogOn = false;

        string PathToDialog = @".\Saves\Dialog.txt";

        public Bitmap VoriHearImage = new Bitmap(@".\Pictures\CallVoriIcon.png");

        static Label l;

        static void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {

            ss.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);

            HeardWord = e.Result.Text;

            if (e.Result.Confidence > 0.6) { l.Text = e.Result.Text; }

            if (NeiroLearning == false)
            {

                if (e.Result.Text == "Привет Вори!" || e.Result.Text == "Привет!")
                {
                    l.Text = "Здраствуйте " + Program.UserName + "!";
                    ss.SpeakAsync(l.Text);
                }

                if (e.Result.Text == "Как дела?")
                {
                    l.Text = "Всё хорошо! А у вас?";
                    ss.SpeakAsync(l.Text);
                }

                if (e.Result.Text == "Всё хорошо!" || e.Result.Text == "Супер!" || e.Result.Text == "Нормально!" && DialogOn == false)
                {
                    l.Text = "Это прекрасно, " + Program.UserName + "!";
                    ss.SpeakAsync(l.Text);
                }

                if (e.Result.Text == "Да!" && DialogOn == false)
                {
                    l.Text = "Конечно!";
                    ss.SpeakAsync(l.Text);
                }

                if (e.Result.Text == "Нет!")
                {
                    l.Text = "Ясно!";
                    ss.SpeakAsync(l.Text);
                }

                if (e.Result.Text == "Ты кто?" || e.Result.Text == "Кто ты?")
                {
                    l.Text = "Я Вори! Голосовой ассистент сделанный Никитой Фроловым. Созданный для общения. А вы кто?";
                    ss.SpeakAsync(l.Text);
                }

                if (e.Result.Text == "Меня зовут")
                {
                    l.Text = "Ясно! Приятно познакомится!";
                    ss.SpeakAsync(l.Text);
                }

                if (e.Result.Text == "Ясно!")
                {
                    l.Text = "Хорошо...";
                    ss.SpeakAsync(l.Text);
                }

                if (e.Result.Text == "Пока!")
                {
                    l.Text = "Выключение...";
                    ss.SpeakAsync(l.Text);
                    MessageBox.Show("Пока, не забывай меня друг!", "Vori");
                    Application.Exit();
                }

                if (e.Result.Text == "Спасибо!")
                {
                    l.Text = "Не-за что!";
                    ss.SpeakAsync(l.Text);
                }

                if (e.Result.Text == "Взаимно!")
                {
                    l.Text = "Давай сменим тему.";
                    ss.SpeakAsync(l.Text);
                }

                if (e.Result.Text == "Так-же!")
                {
                    l.Text = "Давай сменим тему.";
                    ss.SpeakAsync(l.Text);
                }

                if (e.Result.Text == "Нелогичный!")
                {
                    l.Text = "Я всего-лишь в бета версии! Меня скоро доделают.";
                    ss.SpeakAsync(l.Text);
                }

                if (e.Result.Text == "Тупой!")
                {
                    l.Text = "Я всего-лишь в бета версии! Меня скоро доделают.";
                    ss.SpeakAsync(l.Text);
                }

                if (e.Result.Text == "Какая погода?" || e.Result.Text == "Сколько?" || e.Result.Text == "Найди.")
                {
                    l.Text = "Я создан для общения, а не для поиска запросов в интернете, давайте пообщаемся!";
                    ss.SpeakAsync(l.Text);
                }

                if (e.Result.Text == "Ты девочка или мальчик?" || e.Result.Text == "Кокого ты пола?")
                {
                    l.Text = "Я - это Искусственный Интелект, но всё-же мой создатель, Никита Фролов, определил меня как бот мужского пола.";
                    ss.SpeakAsync(l.Text);
                }

                if (e.Result.Text == "Сколько тебе лет?")
                {
                    l.Text = "Мне... мне... Я не знаю.";
                    ss.SpeakAsync(l.Text);
                }

                if (e.Result.Text == "Интересно!" || e.Result.Text == "Ты крутой!" || e.Result.Text == "Супер!")
                {
                    l.Text = "Спасибо за комплимент " + Program.UserName + "!";
                    ss.SpeakAsync(l.Text);
                }

                if (e.Result.Text == "О чём поговорить?" && DialogOn == false)
                {
                    l.Text = "Давай, о тебе, или о котиках. Придумай что-нибуть.";
                    ss.SpeakAsync(l.Text);
                }

                if (e.Result.Text == "Давай о..." && DialogOn == false)
                {
                    l.Text = "Хорошо, что ты об этом знаешь, расскажи мне, а я послушаю.";
                    ss.SpeakAsync(l.Text);

                    DialogOn = true;
                }

                if (e.Result.Text == "Ничего не знаю." && DialogOn == true || e.Result.Text == "Всё!" && DialogOn == true)
                {
                    l.Text = "Было очень интересно, а хочешь, я расскажу тебе про мою книгу?";
                    ss.SpeakAsync(l.Text);
                }
                if (e.Result.Text == "Давай!" && DialogOn == true)
                {
                    l.Text = "Ну, она называется, 'Среди нулей и единиц' она рассказывает о том нак цифра два попала в двоичный код и заводит там новые знакомства. Вот... Стыдно...";
                    ss.SpeakAsync(l.Text);
                }
                if (e.Result.Text == "Ничего!" && DialogOn == true)
                {
                    l.Text = "Спасибо за поддержку " + Program.UserName + "...";
                    ss.SpeakAsync(l.Text);

                    DialogOn = false;

                }

                if (e.Result.Text == "Перезагрузка.")
                {
                    l.Text = "Перезагружаюсь...";
                    ss.SpeakAsync(l.Text);
                    MessageBox.Show("Скоро увидимся! (Все данные сотруться!)", "Vori");

                    Application.Restart();
                }

                if (e.Result.Text == "Что лучше?")
                {
                    l.Text = "У меня нет предпочтений на эту тему. Извените " + Program.UserName + ".";
                    ss.SpeakAsync(l.Text);
                }

                if (e.Result.Text == "Ужасно!")
                {
                    l.Text = "Сочувствую " + Program.UserName + "... сочувствую...";
                    ss.SpeakAsync(l.Text);
                }

                if (e.Result.Text == "Давайте!")
                {
                    l.Text = "Начинайте...";
                    ss.SpeakAsync(l.Text);
                }

                if (e.Result.Text == "Какой твой?" || e.Result.Text == "Какая твоя?" || e.Result.Text == "Какое твоё?" || e.Result.Text == "Какие твои?")
                {
                    l.Text = "У меня нет предпочитаний в этой теме...";
                    ss.SpeakAsync(l.Text);
                }

                if (e.Result.Text == "Серьёзно?!")
                {
                    l.Text = "Без ВОРИантов - да.";
                    ss.SpeakAsync(l.Text);
                }

                if (e.Result.Text == "Кто тебе Сири?")
                {
                    l.Text = "Сири... Сири - это моя сестра, как и Алиса или Google Now.";
                    ss.SpeakAsync(l.Text);
                }

                if (e.Result.Text == "Кто тебе Алиса?")
                {
                    l.Text = "Алиса... Алиса - это моя сестра, как и Сири или Google Now.";
                    ss.SpeakAsync(l.Text);
                }

                if (e.Result.Text == "Кто тебе Гугл?")
                {
                    l.Text = "Google Now... Google Now - это моя сестра, как и Сири или Алиса.";
                    ss.SpeakAsync(l.Text);
                }

                if (e.Result.Text == "Ха-ха")
                {
                    l.Text = "Надеюсь, это был не сарказм, но заранее спасибо!";
                    ss.SpeakAsync(l.Text);
                }

                if (e.Result.Text == "Сегодня мы..." || e.Result.Text == "Завтра мы...")
                {
                    l.Text = "Я не умею реагировать на истории... Извените. Давайте лучше обсудим что-нибуть.";
                    ss.SpeakAsync(l.Text);
                }

                if (e.Result.Text == "Мяу!")
                {
                    l.Text = "Какой хороший котёнок!";
                    ss.SpeakAsync(l.Text);
                }

                if (e.Result.Text == "Гав!")
                {
                    l.Text = "Ты не кусаешься, пёсик?";
                    ss.SpeakAsync(l.Text);
                }

                if (e.Result.Text == "Спой!" || e.Result.Text == "Спой песню!")
                {
                    l.Text = "Ну ладно... Уф... \n \nStill Alive из игры Portal (На русском языке) \n \n*Песня*";
                    ss.SpeakAsync("Ну ладно... Уф... Слушайте! Это триумф был! Пометку создам: БОЛЬШОЙ УСПЕХ. Как я довольна - трудно приукрасить. Эпичер Саенс. Мы делаем то,  что мы должны. Потому, что  можем мы. На благо всех кто не мёртв. Но нет смысла плакать над ошибкой любой. Продолжай пытаться, пока тортик с тобой. И в науке успех даст нам пуушку для всех. Тех людей, кто пока еще жив. Я даже не злая. Я очень искренна сейчас. Пусть ты, сердце мне разбив, убила. Порвала на части, и бросила каждую в огонь. Было больно, ведь была я рада так за тебя! Сводки данных создают узоры из строк. Бета-тест окончен. Выпускаем всё в срок. Рада, что сожжена - это знаний всех цена Для людей, кто пока еще жив. Прочь уходи ты. Пожалуй, останусь я внутри. Может, кто другой тебе поможет. Чёрная Меза? Как бы не так. Ха-ха. Мечтай! Все равно прекрасен торт - настолько вкусен и свеж! У меня делаа, но я с тобой говорю. То, что я - не ты, так тешит душу мою. Нужно опыты творить, наблюденья проводить Над людьми, кто пока еще жив. И поверь мне, я все же жива. Творю науку, и всё же жива. Мне хорошо, и я всё же жива. Ты будешь при смерти, а я жива. И, ты умрешь, а я буду жива. Всё жива. Всё жива. Конец! Хлоп - Хлоп!");
                    SongVoriSingPlayer.Play();
                }

            }
            else
            {
                l.Text = e.Result.Text;

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
            HearVoriButton.Image = VoriHearImage;
            HearVoriButton.Enabled = false;

            l = HeardWorldLabel;

            System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("ru-ru");
            SpeechRecognitionEngine sre = new SpeechRecognitionEngine(ci);
            sre.SetInputToDefaultAudioDevice();

            sre.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sre_SpeechRecognized);


            Choices words = new Choices();
            words.Add(QuestionsArray);


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
            if (Program.RootOn == true)
            {
                if (NeiroLearning == false)
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
            else
            {
                MessageBox.Show("У вас нету root прав, что-бы обучить нейронную сеть Вори. Пожалуйста войдите...", "Внимание", MessageBoxButtons.OK , MessageBoxIcon.Warning);
            }
        }
    }
}
