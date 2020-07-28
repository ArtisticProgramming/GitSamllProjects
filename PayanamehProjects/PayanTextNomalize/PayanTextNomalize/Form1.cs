using Lemmatizer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayanTextNomalize
{
    public partial class Form1 : Form
    {
        public string[] PersianStopWords { get; set; }
        public string[] PersianStopWords2 { get; set; }
        public string[] PersianAlphabets { get; set; }
        public Form1()
        {
            InitializeComponent();
            PersianStopWords = new string[] { "‏دیگران", "همچنان", "مدت", "چیز", "سایر", "جا", "طی",
                "کل", "کنونی", "بیرون", "مثلا", "کامل", "کاملا", "آنکه", "موارد", "واقعی", "امور",
                "اکنون", "بطور", "بخشی", "تحت", "چگونه", "عدم", "نوعی", "وضع",
                "مقابل", "کنار", "خویش", "نگاه", "درون", "زمانی", "بنابراین", "تو", "خیلی",
                "بزرگ", "خودش", "جز", "اینجا", "مختلف", "توسط", "نوع", "همچنین", "آنجا", "قبل",
                "جناح", "اینها", "طور", "شاید", "ایشان", "جهت", "طریق", "مانند", "پیدا", "ممکن",
                "کسانی", "جای", "کسی", "غیر", "بی", "قابل", "درباره", "جدید", "وقتی", "اخیر", "چرا",
                "بیش", "روی", "طرف", "جریان", "زیر", "آنچه", "البته", "فقط", "چیزی", "چون", "برابر",
                "هنوز", "بخش", "زمینه", "بین", "بدون", "استفاد", "همان", "نشان", "بسیاری", "بعد",
                "عمل", "روز", "اعلام", "چند", "آنان", "بلکه", "امروز", "تمام", "بیشتر", "آیا", "برخی",
                "علیه", "دیگری", "ویژه", "گذشته", "انجام", "حتی", "داده", "راه", "سوی", "ولی", "زمان", "حال",
                "تنها", "بسیار", "یعنی", "عنوان", "همین", "هبچ", "پیش", "وی", "یکی", "اینکه", "وجود", "شما",
                "پس", "چنین", "میان", "مورد", "چه", "اگر", "همه", "نه", "دیگر", "آنها", "باید", "هر",
                "او", "ما", "من", "تا", "نیز", "اما", "یک", "خود", "بر", "یا", "هم", "را", "این", "با",
                "آن", "برای", "و", "در", "به", "که", "از" ,
                "بقیه","همسر","دنبال","چقدر","والا","مخصوصا","کلی","اصلا","واقعا","دهه","الان",
                "کاملا","چرا","که","هیچ","کدام","هیچکدام",
                "باز","آقا","شما","او","تو","من","بعضی ","مثل","رسما","درکل","ما","یه","نفر","اسم","همراه","سری",
                "آدم","مورد","شامل","همیشه","راجع","راجعبه","اساسا","مجدد","نحوه"};

            PersianStopWords2 = new string[] { };



            PersianAlphabets = new string[] { "ا", "ب", "پ", "ت", "ث", "ج", "چ", "‌ح",
                                                "خ", "د", "ذ", "ر", "ز", "ژ", "س",
                                                "ش", "ص", "ض", "ط", "ظ", "ع", "غ",
                                                "ف", "ق", "ک", "گ", "ل", "م", "ن",
                                                "و", "ه", "ی" };

        }

        public string RemoveremoveExcitingWordsByPersianAlphabets()
        {
            for (int i = 0; i < PersianAlphabets.Length; i++)
            {
                PersianAlphabets[i] = PersianAlphabets[i] + PersianAlphabets[i] + PersianAlphabets[i];
            }
            // var sent = "عاللللللی";
            var sent = "heloo";
            var reg = @"^([a-zA-Z]){3,}*$";



            sent = StandardizaingExcitingWordsFromSentence(sent);
            return sent;
        }


        static string NormalizingText(string inputText)
        {
            //Normalize Text :
            string output = UsefulTextInfo.RefineAndNormalizedPersianWord(inputText, true);

            // Slang to Formal and Normalizer :
            try
            {
                output = UsefulTextInfo.NormalizeAndPreprocessing(output, false, true);
            }
            catch (Exception)
            {
            }
            return output;
        }

        static string steamingText(string inputText)
        {
            var output = (new StemmingTools()).LemmatizeText(inputText, 
                                        LevelOfLemmatizer.First, false);

            return output;
        }

        public static string removeExcitingWords(string input)
        {
            var spChar = '!';
            var chararr = input.ToCharArray();
            for (int i = 0; i < chararr.Length; i++)
            {
                if (chararr.Where(x => x == chararr[i]).Count() > 2 && chararr[i] != spChar)
                {
                    var locks = true;
                    while (locks)
                    {
                        var nextCharInx = i + 1; var twoNextCharInx = i + 2;
                        if (nextCharInx < chararr.Length && chararr[i] == chararr[nextCharInx])
                        {
                            if (twoNextCharInx < chararr.Length && chararr[i] == chararr[twoNextCharInx])
                            {
                                var b = i + 1;
                                while (chararr[i] == chararr[b])
                                {
                                    chararr[b] = spChar;
                                    b = b + 1;
                                    if (b >= chararr.Count())
                                    {
                                        locks = false;
                                        break;
                                    }
                                }
                            }
                            else
                                locks = false;
                        }
                        else
                            locks = false;
                    }
                }
            }
            return string.Join("", chararr).Replace(spChar.ToString(), "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sss = StandardizaingExcitingWordsFromSentence("بسیاااار عالی");
            // RemoveremoveExcitingWordsByPersianAlphabets();
            using (Model.Model1 db = new Model.Model1())
            {
                while (db.MemberComment_W.Where(x => x.PreProcessedBody == null).Any())
                {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();

                    var list = db.MemberComment_W.Where(x => x.PreProcessedBody == null).Take(1000);

                    foreach (var it in list)
                    {
                        //var it = db.MemberComment_W.FirstOrDefault(x => x.MemberCommentId == item.MemberCommentId);
                        //حدف کارکتر های زاید

                        //if (string.IsNullOrEmpty(it.Body))
                        //{
                        //    continue;
                        //}
                        ////1
                        //var output = TextNormalization.TranformToStandardForm(it.Body);
                        ////Remove Enter
                        ////output = output.Replace(System.Environment.NewLine, " ");
                        ////textBox2.Text = output;
                        //it.Body_After_Standardization = output;

                        ////2
                        //var cleanString = Regex.Replace(output, @"[^\u0622-\u064A\u0698\u06C1\u06C2\u06C3\u06CC\u06AF\u06BE\u0672\u067E\uFB8A\u06A9\u067E\u0686\u0686\u06AF\u200C\u200F  ]", " ");

                        ////Remove More than on space with space
                        //cleanString = Regex.Replace(cleanString, @"\s+", " ");
                        ////textBox3.Text = cleanString;

                        ////Standardizaing Exciting Words In Sentence
                        ////   cleanString = StandardizaingExcitingWordsFromSentence(cleanString);

                        //it.Body_After_Cleaning = cleanString;

                        ////3
                        //var stimmedText = NormalizeAndStemming(cleanString);
                        ////textBox4.Text = stimmedText;
                        //it.Body_After_Steaming = stimmedText;
                        var standard = StandardizaingExcitingWordsFromSentence(it.Body_After_RemovingStopWords);

                        ////4
                        //var TexsWithoutStopWords = RemovingStopWords(standard);
                        var TexsWithoutStopWords = RemovingStopWords2(standard);
                        ////textBox5.Text = TexsWithoutStopWords;
                        it.Body_After_RemovingStopWords = TexsWithoutStopWords;


                        it.PreProcessedBody = TexsWithoutStopWords;

                        // string input = "nsa";
                        // var unicodestring = textBox1.Text;
                        // var result = textBox1.Text.Select(t => string.Format("U+{0:X4} ", Convert.ToUInt16(t))).ToList();
                        // var Unicode = UTF8Encoding.Unicode;

                        //var ss = Unicode.GetBytes(unicodestring);
                        //    var output = NormalizeAndStemming(textBox1.Text);
                        // textBox2.Text = output.ToString();

                        //var charc = '\u06A9'.ToString();
                        //Regex pattern = new Regex("[\u06AC\u06AD\u06AE\u06AE]");
                        //var ss = pattern.Replace(textBox1.Text, charc);

                        //Regex.Replace(output, @"^[ ک ]", "");


                        //All arabic letter from u0600 to u06FF
                        // var cleanString = Regex.Replace(textBox1.Text, @"[^\u0600-\u06FF\uFB8A\u067E\u0686\u06AF\u200C\u200F  ]", "");
                        //textBox3.Text = cleanString.ToString();

                    }
                    db.SaveChanges();
                    stopwatch.Stop();
                    Thread.Sleep(1000);

                }

            }

            MessageBox.Show("Sucess", "text");
        }

        private string StandardizaingExcitingWordsFromSentence(string sentence)
        {
            var chars = new string[] { " " };
            var stringArray = sentence.Split(chars, StringSplitOptions.RemoveEmptyEntries).ToArray();
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = removeExcitingWords(stringArray[i]);
                if (i == 115)
                {

                }
            }
            var text = string.Join(" ", stringArray);
            return text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var s1 = ((int)' ').ToString("X4");
            var output = TextNormalization.TranformToStandardForm(textBox1.Text);
            //Remove Enter
            //output = output.Replace(System.Environment.NewLine, " ");
            textBox2.Text = output;

            //2


            var cleanString = CleanString(output);

            //Remove More than on space with space
            textBox3.Text = cleanString;

            //Standardizaing Exciting Words In Sentence
            cleanString = StandardizaingExcitingWordsFromSentence(cleanString);

            //3 Steamed 
            var Normalized = NormalizingText(cleanString);
            var steamedText = steamingText(Normalized);
            textBox4.Text = steamedText;

            //4
            //var PersianStopWordsCount = PersianStopWords.Count();
            var TexsWithoutStopWords = RemovingStopWords(steamedText);
            textBox5.Text = TexsWithoutStopWords;

        }

        private string CleanString(string output)
        {
            var cleanText = Regex.Replace(output,
                             @"[^\u0622-\u064A\ufef4\u0698\u06C1\u06CC" +
                             "\u06AF\u06BE\u067E\u06A9\u0686\u200C\u200F\u0020]",
                             " ");

            cleanText = Regex.Replace(cleanText, @"\s+", " ");

            return cleanText;
        }

        public string RemovingStopWords(string input)
        {
            var stopWordsCollection = PersianStopWords.Union(PersianAlphabets).Distinct().ToArray();
            return string.Join(" ", input.Split(' ').Where(w => !stopWordsCollection.Contains(w.TrimStart().TrimEnd())));
        }

        public string RemovingStopWords2(string input)
        {
            var stopWordsCollection = PersianStopWords2;
            return string.Join(" ", input.Split(' ').Where(w => !stopWordsCollection.Contains(w.TrimStart().TrimEnd())));
        }
    }
}

