using System;
using System.Linq;

namespace task_22
{ 
    /// <summary>
    /// The class Phonema that build phonema of the word
    /// </summary>
    public class Phonema
    {
        public string args;
        public string Vowels = "aоуыиэяюёе";
        public string Yoted_Vowels = "яюёе";
        public string Consonants = "бвгджзйклмнпрстфхцчшщ";
        public string Ringings = "бвгджзйлмнр";
        public string Deafs = "кпстфхцчшщ";
        public string SoftHardMark = "ъь";

        public Phonema() { }

        public Phonema(string args)
        {
            if (args.Contains("+"))
            {

                this.args = args.Remove(args.IndexOf('+'));
            }
            else if (args.Contains("ё"))
            {
                this.args = args;
            }
            else 
            {
                throw new FormatException("The wrong word! Please enter the word with the plus");
            }
        }

        public void SetWord(string args)
        {
            args = args != null ? args.ToLower() : throw new NullReferenceException();
            foreach (var i in args)
            {
               if ((i >= 1072 && i <= 1103))
                {
                    this.args=args;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Incorrected input letter");
                }
            }
        }

        public string ReplaceOneLetter(string args, int index, string replaceLetter)
        {
            var string1 = args.Substring(0, index);
            var string2 = args.Substring(index, 1);
            var string3 = args.Substring(index + 1);
            string2 = string2.Replace(string2[0].ToString(), replaceLetter);
            return string1 + string2 + string3;
        }
        public string ChangingVowelsLetters(string arg)
        {
            var Object = new Regulations();
            if (args.Contains(Yoted_Vowels))
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (Yoted_Vowels.Contains(args[i]) && i == 0)
                    { args = args.Replace(args[i].ToString(), Object.Vowels(args[i])); }
                    else if (Yoted_Vowels.Contains(args[i]) && Yoted_Vowels.Contains(args[i - 1]))
                    { args = args.Replace(args[i].ToString(), Object.Vowels(args[i])); }
                    else if (Yoted_Vowels.Contains(args[i]) && SoftHardMark.Contains(args[i - 1]))
                    { args = args.Replace(args[i].ToString(), Object.Vowels(args[i])); }
                }
            }
            else
            {
                for (int i = 0; i < args.Length; i++)
                { args = args.Replace(args[i].ToString(), Object.Unstressed_Vowels(args[i])); }
            }

            return this.args=arg;
        }

        public string VoicingConsonants(string arg)
        {
            var Object = new Regulations();
            for (int i = 0; i < args.Length; i++)
            {
                if (Consonants.Contains(args[i]) && Ringings.Contains(args[i + 1]))
                { args = args.Replace(args[i].ToString(), Object.DeafsToRingings(args[i])); }
            }
            return args;
        }

        public string StunningConsonants(string arg)
        {
            var Object = new Regulations();
            for (int i = 0; i < args.Length; i++)
            {
                if (Deafs.Contains(args[i]) && i == args.Length)
                { args = args.Replace(args[i].ToString(), Object.DeafsToRingings(args[i])); }

                if (Deafs.Contains(args[i]) && Deafs.Contains(args[i + 1]))
                { args = args.Replace(args[i].ToString(), Object.DeafsToRingings(args[i])); }
            }
            return args;
        }

        public string SoftHardMar_W(string args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (SoftHardMark.Contains(args[i]) && i == args.Length)
                    args = args.Replace(args[i].ToString(), "'");
            }
            return args;
        }
        public string AlsoPhonemas(string args)
        {
             return args;
        }

        public string CreatPhonema(string args)
        {
            this.args = args;
            SetWord(args);
            ChangingVowelsLetters(args);
            VoicingConsonants(args);
            StunningConsonants(args);
            SoftHardMar_W(args);
            return this.args;
        }
    }
}
