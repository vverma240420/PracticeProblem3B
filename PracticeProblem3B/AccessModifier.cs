using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem3B
{
    internal class AccessModifier
    {
        private int privateField;
        protected int protectedField;
        internal int internalField;
        protected internal int protectedInternalField;
        public int publicField;

        private void PrivateMethod()
        {
            Console.WriteLine("Private method");
        }

        protected void ProtectedMethod()
        {
            Console.WriteLine("Protected method");
        }

        internal void InternalMethod()
        {
            Console.WriteLine("Internal method");
        }

        protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine("Protected Internal method");
        }

        public void PublicMethod()
        {
            Console.WriteLine("Public method");
        }
    }
}
