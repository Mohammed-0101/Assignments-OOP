using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 01 — Theoretical Questions
            #region Q1 Overloading, Overriding, and Binding
            //a)  What is the difference between Method Overloading and Method Overriding?
            /* Method Overloading:
             *      1- Same method name with different parameters.
             *      2- Usually occurs within the same class.
             *      3- Does not require inheritance.	
             *      4- Uses different numbers, types, or orders of parameters.	
             *      5- Associated with compile-time polymorphism.
             */
            /* Method Overriding:
            *       1- Same method name and parameter signature in a derived class.
                    2- Occurs between a base class and a derived class.
                    3- Requires inheritance.
                    4- Uses virtual in the base class and override in the derived class.
                    5- Associated with runtime polymorphism.
            */
            //b)  What is the difference between Static Binding and Dynamic Binding?
            /* Static Binding:
             *      1- Method selection is determined at compile time.	
                    2- Commonly associated with method overloading.	
                    3- Uses compile-time type information.	
                    4- Generally has less runtime dispatch overhead.	
             */
            /* Dynamic Binding:
             *      1- Method selection is determined at runtime.
             *      2- Commonly associated with method overriding.
             *      3- Uses the actual object's runtime type for virtual dispatch.
             *      4- May involve additional runtime dispatch overhead.
             */
            #endregion

            #region Q2 Sealed Classes and Methods
            //a)  What is the purpose of the sealed keyword when applied to a class?
            /*The sealed keyword prevents a class from being inherited by another class.
             */
            //b)  What is the difference between a sealed class and a sealed method?
            /* Sealed Class:
             *      1- Prevents inheritance of the entire class.
             *      2- Declared using sealed class.
             *      3- No class can derive from it.
             *      4-Can contain ordinary methods.
             */
            /* Sealed Method:
             *      1- Prevents further overriding of a specific method.
             *      2- Declared using sealed override.
             *      3- A derived class can inherit the method but cannot override it again.
             *      4- Must override an inherited virtual method.
             * 
             */
            //c)  Can a sealed method be overridden? Why?
            /* No. A sealed method cannot be overridden again in a derived class.
             * he sealed keyword prevents further overriding, 
             * ensuring that the implementation remains unchanged through subsequent inheritance.
             */
            #endregion

        }
    }
}
