using Lemmatizer;
using Parser;
using posTagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FerdosiDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = "سلام سیب absc @#423 33433 aa[[er[wepr[";
            .string cleanString = Regex.Replace(inputString, @"[^a-zA-Z0-9\-]", "");
            var match=  Regex.Match(inputString, @"^[a-zA-Z0-9\-]*?$");
            //using (DbModel.Model1 db= new DbModel.Model1())
            //{
            //    var MemberComments100 = db.MemberComments.Take(100).ToList();
            //    foreach (var item in MemberComments100)
            //    {
            //        var inputText = item.Body;
            //        string output = NormalizeAndStemming(inputText);
            //    }
            //}

        }

        static string NormalizeAndStemming(string inputText)
        {
            //Normalize Text :
            string output = UsefulTextInfo.RefineAndNormalizedPersianWord(inputText, true);

            //Tokenize Text :
            //List<string> tokens = Tokenizer.Tokenize(inputText);

            ////Tokenize & Sentence Splitter :
            //var sb = new StringBuilder();
            //List<List<string>> tokensOfSentences = Tokenizer.AdvancedSentenceSplitterAndTokenize(UsefulTextInfo.RefineAndNormalizedPersianWord(inputText), false);
            //foreach (List<string> sentence in tokensOfSentences)
            //    sb.AppendLine(sentence.Aggregate((cur, item) => cur + "|" + item));
            //output = sb.ToString();

            // Slang to Formal and Normalizer :
            output = UsefulTextInfo.NormalizeAndPreprocessing(output, false, true);

            //    // Stemmer :
            output = (new StemmingTools()).LemmatizeText(output, LevelOfLemmatizer.First, false);

            return output;

        }
    }

    



    //private static void Test(string inputText)
    //{
    //    //Normalize Text :
    //    string output = UsefulTextInfo.RefineAndNormalizedPersianWord(inputText, true);

    //    //Tokenize Text :
    //    List<string> tokens = Tokenizer.Tokenize(inputText);

    //    //Tokenize & Sentence Splitter :
    //    var sb = new StringBuilder();
    //    List<List<string>> tokensOfSentences = Tokenizer.AdvancedSentenceSplitterAndTokenize(UsefulTextInfo.RefineAndNormalizedPersianWord(inputText), false);
    //    foreach (List<string> sentence in tokensOfSentences)
    //        sb.AppendLine(sentence.Aggregate((cur, item) => cur + "|" + item));
    //    output =  sb.ToString();

    //    // Slang to Formal and Normalizer :
    //    output = UsefulTextInfo.NormalizeAndPreprocessing(inputText, false, true);


    //    // Stemmer :
    //    output = (new StemmingTools()).LemmatizeText(inputText, LevelOfLemmatizer.First, false);


    //    // POS Tagger :
    //    var p = PosTaggerAlgorithms.Run(inputText, PosTaggerAlgorithmList.ViterbiHMM, LevelOfPOS.Level1, true);
    //    output = Util.PharaseListToString(p, showTag: "POS.Level1");


    //    // Parser :
    //    string txt;
    //    string[] words, tags, tagsWithDetail;

    //    var obj = new Parser1();
    //    obj.Parse(inputText);
    //    obj.TransformInfo(out txt, out words, out tags, out tagsWithDetail);

    //    string textParsed = string.Empty;
    //    for (int i = 0; i < tags.Length; i++)
    //        textParsed += words[i] + " " + tags[i] + " ";
    //    textParsed = textParsed.Replace("SentenceSpliter", "").Replace("Delimeter", "").Replace("NP1", "NP").Replace("NP2", "NP");
    //    // TextParsed = TextParsed.Replace("MuchMany", "");
    //    output = Parser1.ReturnTextToFirstState(textParsed);
    //}
}
