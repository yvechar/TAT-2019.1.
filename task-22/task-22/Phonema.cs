using System;
using System.Linq;


namespace task_22
{
    internal class Phonema
    {

        public string args;
        public string Vowels = "aоуыиэяюёе";
        public string Yoted_Vowels = "яюёе";
        public string Consonants = "бвгджзйклмнпрстфхцчшщ";
        public string Ringings = "бвгджзйлмнр";
        public string Deafs = "кпстфхцчшщ";
        public string SoftHardMark = "ъь";
        //public string word;
        public Phonema(string args)
        {
            if (args.Contains("+"))
            {
                //args.Replace("+", String.Empty);
                this.args = args;

            }
            else
            {
                throw new FormatException("The wrong word! Please enter the word with the plus");

            }

        }

        public string ChangingVowelsLetters_1(string arg)
        {
            var Object = new Regulations();
            if (args.Contains(Yoted_Vowels))
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (Yoted_Vowels.Contains(args[i]) && i == 0)
                    { args = args.Replace(args[i].ToString(), Object.Vowels_2(args[i])); }
                    else if (Yoted_Vowels.Contains(args[i]) && Yoted_Vowels.Contains(args[i - 1]))
                    { args = args.Replace(args[i].ToString(), Object.Vowels_2(args[i])); }
                    else if (Yoted_Vowels.Contains(args[i]) && SoftHardMark.Contains(args[i - 1]))
                    { args = args.Replace(args[i].ToString(), Object.Vowels_2(args[i])); }
                }
            }
            else
            {
                for (int i = 0; i < args.Length; i++)
                { args = args.Replace(args[i].ToString(), Object.Vowels_1(args[i])); }
            }

            return arg;
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
            // args.Replace();
            return args;
        }

        public string CreatPhonema(string args)
        {
            this.args = args;
            ChangingVowelsLetters_1(args);
            VoicingConsonants(args);
            StunningConsonants(args);
            SoftHardMar_W(args);
            return this.args;
        }
    }
}
