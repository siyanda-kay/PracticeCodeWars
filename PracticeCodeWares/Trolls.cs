using System.Text;
using System;

namespace PracticeCodeWares
{
    public class Trolls
    {
        public static string Disemvowel(string str)
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (str == null)
                return string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case 'a':
                    case 'A':
                    case 'e':
                    case 'E':
                    case 'o':
                    case 'O':
                    case 'i':
                    case 'I':
                    case 'u':
                    case 'U':
                        continue;
                }

                stringBuilder.Append(str[i]);
            }

            return stringBuilder.ToString();
        }
    }

}