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
                bool isMultipleOfThree = i != 0 && i % 3 == 0;
                bool isMultipleOfFive = i != 0 && i % 5 == 0;
                bool containsThree = i.ToString().Contains("3");

                if (containsThree)
                    sb.Append("lucky ");
                else if (isMultipleOfThree && isMultipleOfFive)
                    sb.Append("fizzbuzz ");
                else if (isMultipleOfThree)
                    sb.Append("fizz ");
                else if (isMultipleOfFive)
                    sb.Append("buzz ");
                else
                    sb.Append(i.ToString()).Append(" ");
            }

            return sb.ToString().Trim();
        }
    }
}
