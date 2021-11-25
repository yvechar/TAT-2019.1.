namespace task_22
{
    /// <summary>
    /// Class Regulations has rules by which we make a phonema
    /// </summary>
    internal class Regulations
    {
        public Regulations()
        { }
        /// <summary>
        /// Rules for unstressed vowels 
        /// </summary>
        /// <param name="letter"> letter that comes from the class Phonema</param>
        /// <returns></returns>
        public string Vowels_1(char letter)
        {
            switch (letter)
            {
                case 'ю':
                    return "у";

                case 'я':
                    return "а";

                case 'е':
                    return "э";

                case 'ё':
                    return "о";

                case 'о':
                    return "а";

            }
            return " ";
        }
        /// <summary>
        /// Rules for vowels that are 
        /// at the beginning of ,
        /// the word after vowels ,
        /// after a hard and soft mark
        /// </summary>
        /// <param name="letter"> letter that comes from the class Phonema</param>
        /// <returns></returns>
        public string Vowels_2(char letter)
        {
            switch (letter)
            {
                case 'ю':
                    return "йю";

                case 'я':
                    return "йа";

                case 'е':
                    return "йэ";

                case 'ё':
                    return "йо";


            }
            return " Vowels_2 :)";
        }
        /// <summary>
        /// Ruls for stunning consonants
        /// </summary>
        /// <param name="letter">letter that comes from the class Phonema</param>
        /// <returns></returns>
        public string RingingsToDeafs(char letter)
        {
            switch (letter)
            {
                case 'б':
                    return "п";

                case 'д':
                    return "т";

                case 'г':
                    return "к";

                case 'з':
                    return "с";

                case 'ж':
                    return "ш";

            }
            return " RingingsToDeafs :)";
        }
        /// <summary>
        /// Rules for voicing consonants
        /// </summary>
        /// <param name="letter">letter that comes from the class Phonema</param>
        /// <returns></returns>
        public string DeafsToRingings(char letter)
        {
            switch (letter)
            {
                case 'п':
                    return "б";

                case 'т':
                    return "д";

                case 'с':
                    return "з";

                    //default:

            }
            return "DeafsToRingings :)";
        }
    }
}