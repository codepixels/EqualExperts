using System.Text;

namespace FizzBuzz.EqualExperts
{
    public class FizzBuzz
    {
        private static readonly string _fizz = "fizz", _buzz = "buzz", _lucky = "lucky", _integer = "integer";

        public string Run(int startRange, int endRange, bool includeReport = false)
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
                bool isMultipleOfFifteen = isMultipleOfThree && isMultipleOfFive;
                bool containsThree = i.ToString().Contains("3");

                if (containsThree)
                    sb.Append($"{_lucky} ");
                else if (isMultipleOfFifteen)
                    sb.Append($"{_fizz + _buzz} ");
                else if (isMultipleOfThree)
                    sb.Append($"{_fizz} ");
                else if (isMultipleOfFive)
                    sb.Append($"{_buzz} ");
                else
                    sb.Append($"{i.ToString()} ");
            }

            if (includeReport)
                sb.Append(GenerateReport(sb.ToString()));

            return sb.ToString().Trim();
        }

        private string GenerateReport(string input)
        {
            int fizzCount = 0, buzzCount = 0, fizzBuzzCount = 0, luckyCount = 0, integerCount = 0;
            var words = input.Trim().Split(' ');

            foreach(var word in words)
            {
                if (word.Equals(_fizz))
                    fizzCount++;
                if (word.Equals(_buzz))
                    buzzCount++;
                if (word.Equals(_fizz + _buzz))
                    fizzBuzzCount++;
                if (word.Equals(_lucky))
                    luckyCount++;
            }

            integerCount = words.Length - fizzCount - buzzCount - fizzBuzzCount - luckyCount;

            return $"{_fizz}: {fizzCount.ToString()} " +
                   $"{_buzz}: {buzzCount.ToString()} " +
                   $"{_fizz + _buzz}: {fizzBuzzCount.ToString()} " +
                   $"{_lucky}: {luckyCount.ToString()} " +
                   $"{_integer}: {integerCount.ToString()}";
        }
    }
}
