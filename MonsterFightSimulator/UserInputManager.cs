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
        public static string WaitForInput(string input, Regex regex, string failedMessage = "Given input is not within range. Try again...")
        {
            while (!regex.IsMatch(input))
            {
                Console.WriteLine(failedMessage);
                input = Console.ReadLine();
            }
            return input;
        }
    }
}
