using System.Text;

namespace FizzBuzz.EqualExperts
{
    public class FizzBuzz
    {
        public string Run(int startRange, int endRange)
        {
            if (startRange > endRange)
            {
                int temp = endRange;
                endRange = startRange;
                startRange = temp;
            }

            StringBuilder sb = new StringBuilder();
            for (var i = startRange; i <= endRange; i++)
            {
                if (i == 0)
                    sb.Append("0 ");
                else if (i % 15 == 0)
                    sb.Append("fizzbuzz ");
                else if (i % 3 == 0)
                    sb.Append("fizz ");
                else if (i % 5 == 0)
                    sb.Append("buzz ");
                else
                    sb.Append(i.ToString()).Append(" ");
            }

            return sb.ToString().Trim();
        }
    }
}
