namespace Reverse_All_Vowels_in_a_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "Amazon";
            Console.WriteLine(word);
            string word2 = ReverseAllVowelsInWord(word);
            Console.WriteLine(word2);

        }

        static string ReverseAllVowelsInWord(string s)
        {
            int i = 0;
            int j = s.Length - 1;

            s = s.ToLower();

            char[] chars = s.ToCharArray();

            while (i < j)
            {
                if (!IsVowel(chars[i]))
                {
                    i++;
                    continue;
                }

                if (!IsVowel(chars[j]))
                {
                    j--;
                    continue;
                }

                SwapElementValues(chars, i, j);

                i++;
                j--;
                
            }

            string t = new string(chars);
            return t;

        }
        static void SwapElementValues(char[] arr, int i, int j)
        {
            char temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        static bool IsVowel(char c)
        {
            return (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u');
        }
    }
}
