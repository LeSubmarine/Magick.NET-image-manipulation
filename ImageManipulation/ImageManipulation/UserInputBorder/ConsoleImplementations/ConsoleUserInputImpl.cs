using ImageManipulation.UserInputBorder.interfaces;
using System;

namespace ImageManipulation
{
    public class ConsoleUserInputImpl : UserInput
    {
        public T GetUserInput<T>(string question)
        {
            Console.WriteLine(question);
            string input = Console.ReadLine();
            return (T)Convert.ChangeType(input, typeof(T));
        }
    }
}