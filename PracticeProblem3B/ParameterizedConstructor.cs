namespace PracticeProblem3B
{
    internal class ParameterizedConstructor
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Parameterized constructor
        public ParameterizedConstructor(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public ParameterizedConstructor()
        {
            Name = "Vivek Verma";
            Age = 24;
        }
    }
}
