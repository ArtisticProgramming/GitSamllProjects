using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PayanTextNomalize
{
    public enum PersianLetter
    {
        /// <summary>
        /// ک
        /// </summary>
        kaf,
        /// <summary>
        /// و
        /// </summary>
        vav,
        /// <summary>
        /// ی
        /// </summary>
        Yea,
        /// <summary>
        /// ه
        /// </summary>
        He,
        /// <summary>
        /// ا
        /// </summary>
        Alef
    }
    public static class TextNormalization
    {
        public static string TranformToStandardForm(string input)
        {
            var output = input;
            output = Tranform_kaf_ToStandardForm(output);
            output = Tranform_vav_ToStandardForm(output);
            output = Tranform_Yea_ToStandardForm(output);
            output = Tranform_He_ToStandardForm(output);
            output = Tranform_Alef_ToStandardForm(output);
            return output;
        }

        public static string TranformToStandardForm(string input, PersianLetter persianLetter)
        {
            var output = input;
            switch (persianLetter)
            {
                case PersianLetter.kaf:
                    output = Tranform_kaf_ToStandardForm(input);
                    break;
                case PersianLetter.vav:
                    output = Tranform_vav_ToStandardForm(input);
                    break;
                case PersianLetter.Yea:
                    output = Tranform_Yea_ToStandardForm(input);
                    break;
                case PersianLetter.He:
                    output = Tranform_He_ToStandardForm(input);
                    break;
                case PersianLetter.Alef:
                    output = Tranform_Alef_ToStandardForm(input);
                    break;
                default:
                    break;
            }

            return output;
        }

        private static string Tranform_He_ToStandardForm(string input)
        {
            //ه
            var standardForm = '\u0647'.ToString();
            List<string> list = new List<string>();
            list.Add("\u0629");  // ة
            list.Add("\u06C1");  // ہ
            list.Add("\u06C2");  // ۂ
            list.Add("\u06C3");  // ۃ
            list.Add("\u06D5");  // ە

            Regex pattern = new Regex("[" + string.Join("", list) + "]");
            return pattern.Replace(input, standardForm);
        }

        private static string Tranform_Alef_ToStandardForm(string input)
        {
            //ا
            var standardForm = '\u0627'.ToString();
            List<string> list = new List<string>();
            list.Add("\u0622");  // آ
            list.Add("\u0623");  // أ
            list.Add("\u0625");  // إ
            list.Add("\u0671");  // ٱ
            list.Add("\u0672");  // ٲ
            list.Add("\u0673");  // ٳ
            list.Add("\u00675");  // ٵ

            Regex pattern = new Regex("[" + string.Join("", list) + "]");
            return pattern.Replace(input, standardForm);
        }

        private static string Tranform_Yea_ToStandardForm(string input)
        {
            //u06CC => ی
            var standardForm = '\u06CC'.ToString();
            List<string> list = new List<string>();
            list.Add("\u06CD");   //ۍ
            list.Add("\u06CE");   //ێ
            list.Add("\u06D0");   //ې
            list.Add("\u06D1");   //ۑ
            list.Add("\u0678");   //ٸ
            list.Add("\u064A");   //ى
            list.Add("\u0649");   //ي
            list.Add("\u063D");   //ؽ
            list.Add("\u063E");   //ؾ
            list.Add("\u063F");   //ؿ
            list.Add("\u0620");   //ؠ
            list.Add("\u0626");   //ئ

            Regex pattern = new Regex("[" + string.Join("", list) + "]");
            return pattern.Replace(input, standardForm);
        }

        private static string Tranform_vav_ToStandardForm(string input)
        {
            //u0648 --> و
            var standardForm = '\u0648'.ToString();
            List<string> list = new List<string>();
            list.Add("\u0624");  //ؤ   
            list.Add("\u06C5");  //ۅ
            list.Add("\u06C6");  //ۆ
            list.Add("\u06C7");  //ۇ
            list.Add("\u06C8");  //ۈ
            list.Add("\u06C9");  //ۉ
            list.Add("\u06CA");  //ۊ
            list.Add("\u06CB");  //ۋ
            list.Add("\u06CF");  //ۏ
            list.Add("\u0676");	 //ٶ
            list.Add("\u0677");	 //ٷ

            Regex pattern = new Regex("[" + string.Join("", list) + "]");
            return pattern.Replace(input, standardForm);
        }

        private static string Tranform_kaf_ToStandardForm(string input)
        {
            //u06A9 --> ک
            var standardForm = '\u06A9'.ToString();
            List<string> list = new List<string>();
            list.Add("\u06AC");     //  ==>  ڬ
            list.Add("\u06AD");     //  ==>  ڭ
            list.Add("\u06AE");     // ==>   ڮ 
            list.Add("\u063B");     // ==>   ڮ 
            list.Add("\u063C");     // ==>   ڮ 
            list.Add("\u0643");     // ==>   ك 

            Regex pattern = new Regex("[" + string.Join("", list) + "]");
            return pattern.Replace(input, standardForm);
        }
    }
}

//   \u0600	؀           
//   \u0601	؁           
//   \u0602	؂           
//   \u0603	؃           
//   \u0604	؄           
//   \u0605	؅            
//   \u0606	؆           
//   \u0607	؇           
//   \u0608	؈           
//   \u0609	؉           
//   \u060A	؊           
//   \u060B	؋           
//   \u060C	،           
//   \u060D	؍           
//   \u060E	؎           
//   \u060F	؏           
//   \u0610	ؐ           
//   \u0611	ؑ           
//   \u0612	ؒ           
//   \u0613	ؓ           
//   \u0614	ؔ           
//   \u0615	ؕ           
//   \u0616	ؖ            
//   \u0617	ؗ            
//   \u0618	ؘ            
//   \u0619	ؙ            
//   \u061A	ؚ            
//   \u061B	؛           
//   \u061C	؜            
//   \u061D	؝           
//   \u061E	؞           
//   \u061F	؟           
//   \u0620	ؠ           
//   \u0621	ء           
//------------------------------
//   \u0622	آ
//   \u0623	أ
//   \u0624	ؤ
//   \u0625	إ
//   \u0626	ئ
//   \u0627	ا
//   \u0628	ب
//   \u0629	ة
//   \u062A ت
//   \u062B ث
//   \u062C ج
//   \u062D	ح
//   \u062E	خ
//   \u062F	د
//   \u0630	ذ
//   \u0631	ر
//   \u0632	ز
//   \u0633	س
//   \u0634	ش
//   \u0635	ص
//   \u0636	ض
//   \u0637	ط
//   \u0638	ظ
//   \u0639	ع
//   \u063A غ
//   \u063B ػ
//   \u063C ؼ
//   \u063D	ؽ
//   \u063E	ؾ
//   \u063F	ؿ
//   \u0640	ـ
//   \u0641	ف
//   \u0642	ق
//   \u0643	ك
//   \u0644	ل
//   \u0645	م
//   \u0646	ن
//   \u0647	ه
//   \u0648	و
//   \u0649	ى
//   \u064A ي
//   \u064B	ً
//   \u064C	ٌ
//   \u064D	ٍ
//   \u064E	َ
//   \u064F	ُ
//   \u0650	ِ
//   \u0651	ّ
//   \u0652	ْ
//   \u0653	ٓ
//   \u0654	ٔ
//   \u0655	ٕ
//   \u0656	ٖ
//   \u0657	ٗ
//   \u0658	٘
//   \u0659	ٙ
//   \u065A	ٚ
//   \u065B	ٛ
//   \u065C	ٜ
//   \u065D	ٝ
//   \u065E	ٞ
//   \u065F	ٟ
//   \u0660	٠
//   \u0661	١
//   \u0662	٢
//   \u0663	٣
//   \u0664	٤
//   \u0665	٥
//   \u0666	٦
//   \u0667	٧
//   \u0668	٨
//   \u0669	٩
//   \u066A	٪
//   \u066B	٫
//   \u066C	٬
//   \u066D	٭
//   \u066E	ٮ
//   \u066F	ٯ
//   \u0670	ٰ
//   \u0671	ٱ
//   \u0672	ٲ
//   \u0673	ٳ
//   \u0674	ٴ
//   \u0675	ٵ
//   \u0676	ٶ
//   \u0677	ٷ
//   \u0678	ٸ
//   \u0679	ٹ
//   \u067A ٺ
//   \u067B ٻ
//   \u067C ټ
//   \u067D	ٽ
//   \u067E	پ
//   \u067F	ٿ
//   \u0680	ڀ
//   \u0681	ځ
//   \u0682	ڂ
//   \u0683	ڃ
//   \u0684	ڄ
//   \u0685	څ
//   \u0686	چ
//   \u0687	ڇ
//   \u0688	ڈ
//   \u0689	ډ
//   \u068A ڊ
//   \u068B ڋ
//   \u068C ڌ
//   \u068D	ڍ
//   \u068E	ڎ
//   \u068F	ڏ
//   \u0690	ڐ
//   \u0691	ڑ
//   \u0692	ڒ
//   \u0693	ړ
//   \u0694	ڔ
//   \u0695	ڕ
//   \u0696	ږ
//   \u0697	ڗ
//   \u0698	ژ
//   \u0699	ڙ
//   \u069A ښ
//   \u069B ڛ
//   \u069C ڜ
//   \u069D	ڝ
//   \u069E	ڞ
//   \u069F	ڟ
//   \u06A0 ڠ
//   \u06A1 ڡ
//   \u06A2 ڢ
//   \u06A3 ڣ
//   \u06A4 ڤ
//   \u06A5 ڥ
//   \u06A6 ڦ
//   \u06A7 ڧ
//   \u06A8 ڨ
//   \u06A9 ک
//   \u06AA ڪ
//   \u06AB ګ
//   \u06AC ڬ
//   \u06AD ڭ
//   \u06AE ڮ
//   \u06AF گ
//   \u06B0 ڰ
//   \u06B1 ڱ
//   \u06B2 ڲ
//   \u06B3 ڳ
//   \u06B4 ڴ
//   \u06B5 ڵ
//   \u06B6 ڶ
//   \u06B7 ڷ
//   \u06B8 ڸ
//   \u06B9 ڹ
//   \u06BA ں
//   \u06BB ڻ
//   \u06BC ڼ
//   \u06BD ڽ
//   \u06BE ھ
//   \u06BF ڿ
//   \u06C0 ۀ
//   \u06C1 ہ
//   \u06C2 ۂ
//   \u06C3 ۃ
//   \u06C4 ۄ
//   \u06C5 ۅ
//   \u06C6 ۆ
//   \u06C7 ۇ
//   \u06C8 ۈ
//   \u06C9 ۉ
//   \u06CA ۊ
//   \u06CB ۋ
//   \u06CC ی
//   \u06CD ۍ
//   \u06CE ێ
//   \u06CF ۏ
//   \u06D0	ې
//   \u06D1	ۑ
//   \u06D2	ے
//   \u06D3	ۓ
//   \u06D4	۔
//   \u06D5	ە
//   \u06D6	ۖ
//   \u06D7	ۗ
//   \u06D8	ۘ
//   \u06D9	ۙ
//   \u06DA	ۚ
//   \u06DB	ۛ
//   \u06DC	ۜ
//   \u06DD	۝
//   \u06DE	۞
//   \u06DF	۟
//   \u06E0	۠
//   \u06E1	ۡ
//   \u06E2	ۢ
//   \u06E3	ۣ
//   \u06E4	ۤ
//   \u06E5	ۥ
//   \u06E6	ۦ
//   \u06E7	ۧ
//   \u06E8	ۨ
//   \u06E9	۩
//   \u06EA	۪
//   \u06EB	۫
//   \u06EC	۬
//   \u06ED	ۭ
//   \u06EE ۮ
//   \u06EF	ۯ
//   \u06F0	۰
//   \u06F1	۱
//   \u06F2	۲
//   \u06F3	۳
//   \u06F4	۴
//   \u06F5	۵
//   \u06F6	۶
//   \u06F7	۷
//   \u06F8	۸
//   \u06F9	۹
//   \u06FA ۺ
//   \u06FB ۻ
//   \u06FC ۼ
//   \u06FD	۽
//   \u06FE	۾
//   \u06FF	ۿ
