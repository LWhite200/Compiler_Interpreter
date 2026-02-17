using Microsoft.VisualBasic;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Compiler
{
    internal class CreateFile
    {
     
        /*
        PH<reg>: push the contents of the register(i.e.A, X, or Y) onto the stack.
        PL<reg>: pop a value off the stack into the register.The program will terminate if this instruction is called when the stack is empty.
        AD: pop two values off the stack, and push the lowest bits of their sum onto the stack.
        ZE<reg>: set the register equal to zero.
        ST<reg>: set the register equal to one.
        DI<reg>: send the value of the register to the laser display board and exit.
        */


        public static void FileCreationMain()
        {
            Console.WriteLine("Input Number 0-255");
            string? n = Console.ReadLine();

            // Validate it is a valid number AND within range
            if (!int.TryParse(n, out int number) || number < 0 || number > 255)
            {
                Console.WriteLine("Invalid Input");
                return;
            }

            Console.WriteLine("Valid number: " + number);





        }
    }
}
