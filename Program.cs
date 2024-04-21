using System;

namespace HomeWork156
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1:Verilmiş ədədlər siyahısındaki ədədlərdən ən kiçiyini tapan metod:
            int[] number = { 10, 25, 32, 12, 43, 85 };
            int result = LitNumber(number);
            Console.WriteLine(result);
            #endregion

            #region Task 2: Verilmiş yazıda verilmiş chardan neçə ədəd olduğunu tapan metod:
            Console.Write("Zehmet olmasa sozu daxil edin: ");
            string word = Console.ReadLine();
            Console.WriteLine("Axtardiginiz ededi daxil edin");
            char wantedChar = Convert.ToChar(Console.ReadLine());
            var result1 = CharStr(word, wantedChar);
            Console.WriteLine(result1);
            #endregion

            #region Task 3: Verilmiş ədədlər siyahısında verilmiş ədədin yerləşdiyi indexi tapan metod, əgər həmin ədəd siyahıda yoxdursa 
            #region- 1 qaytarsın, varsa ilk yerləşdiyi indexi.

            int[] arr = { 10, 25, 32, 20, 45, 50 };
            var result3 = IndexOf(arr, 20);
            Console.WriteLine(result3);
            #endregion


            #endregion

            #region Task 4: Verilmiş yazını əksinə çevirən metod(misalçün metoda "salam" göndərsəniz metod geriyə "malas" return etməlidir)
            Console.WriteLine("Zehmet olmasa yazini daxil edin");
            string word1 = Console.ReadLine();
            var result4 = OpWord(word1);
            Console.WriteLine(result4);
            #endregion

            #region Task 5: Verilmiş yazıda rəqəm olub olmadığını tapan metod:

            Console.WriteLine("Zehmet olmasa yazini daxil edin");
            string word3 = Console.ReadLine();

            var result5 = IsDigit(word3);
            Console.WriteLine(result5);

            #endregion
        }

        static int LitNumber(int[] number)
        {
            #region
            int lit = number[0];
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] < lit)
                {
                    number[i] = lit;
                }
            }
            return lit;

            #endregion
        }


        static int CharStr(string word, char cr)
        {
            #region
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == cr)
                {
                    count++;
                }
            }
            return count;
            #endregion

        }


        static int IndexOf(int[] arr, int digit)
        {
            #region
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == digit)
                {
                    return i;
                }
            }
            return -1;
            #endregion
        }

        static string OpWord(string word)
        {
            #region
            string opStr = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                opStr = opStr + word[i];
            }
            return opStr;
            #endregion
        }

        static bool IsDigit(string word3)
        {
            #region
            char[] digit = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i = 0; i < word3.Length; i++)
            {
                for (int j = 0; j < digit.Length; j++)
                {
                    if (word3[i] == digit[j])
                    {
                        return true;
                    }
                }
            }
            return false;
            #endregion
        }

    }
}
