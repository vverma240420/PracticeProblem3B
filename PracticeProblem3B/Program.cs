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


           /* IPlayable player1 = new MusicPlayer();
            player1.Play();  

            IPlayable player2 = new VideoPlayer();
            player2.Play();   */


            AccessModifier ac = new AccessModifier();
          //  ac.publicField = 10;                   // Accessible
            ac.ProtectedInternalMethod();         // Accessible
            ac.PublicMethod();                    // Accessible


            //ac.privateField
            // Not accessible
            // ac.protectedField                    // Not accessible
            // ac.internalField                     // Not accessible
           // ac.ProtectedMethod();                // Not accessible
            //ac.InternalMethod();                  // Not accessible
            Console.ReadLine();
        }
    }
}