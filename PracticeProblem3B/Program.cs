using System;

namespace PracticeProblem3B
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* ParameterizedConstructor person = new ParameterizedConstructor("Vivek Verma", 23);
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            ParameterizedConstructor p = new ParameterizedConstructor();
            Console.WriteLine($"Name: {p.Name}, Age: {p.Age}"); */


            IPlayable player1 = new MusicPlayer();
            player1.Play();  

            IPlayable player2 = new VideoPlayer();
            player2.Play();  
            Console.ReadLine();
        }
    }
}