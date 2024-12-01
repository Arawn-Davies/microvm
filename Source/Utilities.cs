// Create the Utilities class using Prorgam.cs as a template.
using System;

namespace microvm
{
    class Utilities
    {
        public static byte[] GetOperands(byte[] memory, int ip, int count)
        {
            byte[] operands = new byte[count];
            for (int i = 0; i < count; i++)
            {
                operands[i] = memory[ip + i];
            }
            return operands;
        }
    }
}