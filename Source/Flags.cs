// Create the flags class using Prorgam.cs as a template.
using System;

namespace microvm
{
    class Flags
    {
        public byte Zero { get; set; }
        public byte Carry { get; set; }
        public byte Overflow { get; set; }
        public byte Sign { get; set; }
        public byte Parity { get; set; }
        public Flags()
        {
            Zero = 0;
            Carry = 0;
            Overflow = 0;
            Sign = 0;
            Parity = 0;
        }
    }
}