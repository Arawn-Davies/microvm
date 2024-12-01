using System;

namespace microvm
{
    public class ISA
    {
        // No operation
        public const byte NOP = 0x00;
        // Halt the program
        public const byte HLT = 0x01;
        // Push a value onto the stack
        public const byte PUSH = 0x02;
        // Pop a value off the stack
        public const byte POP = 0x03;
        // Move a value from one register to another
        public const byte MOV = 0x04;
        // Load a value from memory into a register
        public const byte LOAD = 0x05;
        // Store a value from a register into memory
        public const byte STORE = 0x06;
        // Add two values
        public const byte ADD = 0x07;
        // Subtract two values
        public const byte SUB = 0x08;
        // Multiply two values
        public const byte MUL = 0x09;
        // Divide two values
        public const byte DIV = 0x0A;
        // Bitwise AND
        public const byte AND = 0x0B;
        // Bitwise OR
        public const byte OR = 0x0C;
        // Bitwise XOR
        public const byte XOR = 0x0D;
        // Bitwise NOT
        public const byte NOT = 0x0E;
        // Shift left
        public const byte SHL = 0x0F;
        // Shift right
        public const byte SHR = 0x10;
        // Compare two values
        public const byte CMP = 0x11;
        // Jump
        public const byte JMP = 0x12;
        // Jump if equal
        public const byte JEQ = 0x13;
        // Jump if not equal
        public const byte JNE = 0x14;
        // Jump if greater than
        public const byte JGT = 0x15;
        // Jump if less than
        public const byte JLT = 0x16;
        // Jump if greater than or equal
        public const byte JGE = 0x17;
        // Jump if less than or equal
        public const byte JLE = 0x18;
        // Call a subroutine
        public const byte CALL = 0x19;
        // Return from a subroutine
        public const byte RET = 0x20;
        // Interrupt
        public const byte INT = 0x22;
    }
}