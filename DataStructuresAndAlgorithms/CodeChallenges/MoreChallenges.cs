using System.Text;

namespace CodeChallenges
{
    public class MoreChallenges
    {
        public int Compress(char[] chars)
        {

            var stringBuilder = new StringBuilder();
            int cont = 1;
            char charBefore = chars[0];

            if (chars.Length == 1) return chars.Length;

            for (int i = 1; i < chars.Length; i++)
            {
                if (charBefore != chars[i])
                {
                    if (cont == 1)
                        stringBuilder.Append(charBefore);
                    else
                        stringBuilder.Append($"{charBefore}{cont}");

                    cont = 1;
                    charBefore = chars[i];
                }
                else
                    cont++;
            }

            if(cont == 1)
                stringBuilder.Append(charBefore);
            else
                stringBuilder.Append($"{charBefore}{cont}");

            return stringBuilder.ToString().Length;
        }
    }
}
