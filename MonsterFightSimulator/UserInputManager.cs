using System.Text.RegularExpressions;

namespace MonsterFightSimulator
{
    public static class UserInputManager
    {
        /// <summary>
        /// Waits until a matching input was found.
        /// </summary>
        /// <param name="input">The string to check</param>
        /// <param name="regex">The regex to match</param>
        /// <param name="failedMessage">The message to show if the input did not match.</param>
        /// <returns>The matching user input</returns>
        public static string WaitForInput(string input, Regex regex, string failedMessage = "Given input has the wrong format. Try again...")
        {
            while (!regex.IsMatch(input))
            {
                Console.WriteLine(failedMessage);
                input = Console.ReadLine();
            }
            return input;
        }
        
        public static float CheckValues(float min, float max, Regex regex = null)
        {
            if (regex == null)
                regex = new Regex("^[1-9]{1}[0-9]*$");
            float value = 0;
            while (true)
            {
                if (float.TryParse(UserInputManager.WaitForInput(Console.ReadLine(), regex), out float value2))
                {
                    value = value2;
                }
                if (value >= min && value <= max)
                    break;
                Console.WriteLine("The value is not within range. Try again...");
            }
            return value;
        }
    }
}
