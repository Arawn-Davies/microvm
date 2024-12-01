using Microsoft.Win32;
using System;

namespace microvm
{
    class VM
    {
        private Stack stack;
        private AddressSpace _addr;
        private Flags flags;
        private byte[] registers;
        private bool running;
        private int ip;
        public VM(int stackSize, byte[] exec, int memorySize)
        {
            stack = new Stack(256);
            flags = new Flags();
            _addr = new AddressSpace(exec, memorySize);
            ip = 0;
        }
        
        public void Run()
        {
            while (ip < _addr._memory.Length)
            {
                byte opcode = _addr._memory[ip++];
                byte[] operands = Utilities.GetOperands(_addr._memory, ip, 2);
                
                switch (opcode)
                {
                    // Create cases for each opcode in ISA class (NOP, HLT, PUSH, POP, etc.)
                    case ISA.NOP:
                        break;
                    case ISA.HLT:
                        running = false;
                        break;
                    case ISA.PUSH:
                        stack.Push(operands[0]);
                        break;
                    case ISA.POP:
                        stack.Pop();
                        break;
                    case ISA.MOV:
                        registers[operands[0]] = operands[1];
                        break;
                    case ISA.ADD:
                        registers[operands[0]] += operands[1];
                        break;
                    case ISA.SUB:
                        registers[operands[0]] -= operands[1];
                        break;
                    case ISA.MUL:
                        registers[operands[0]] *= operands[1];
                        break;
                    case ISA.DIV:
                        registers[operands[0]] /= operands[1];
                        break;
                    case ISA.AND:
                        registers[operands[0]] &= operands[1];
                        break;
                    case ISA.OR:
                        registers[operands[0]] |= operands[1];
                        break;
                    case ISA.XOR:
                        registers[operands[0]] ^= operands[1];
                        break;
                    case ISA.NOT:
                        registers[operands[0]] = (byte)~operands[0];
                        break;
                    case ISA.SHL:
                        registers[operands[0]] <<= operands[1];
                        break;
                    case ISA.SHR:
                        registers[operands[0]] >>= operands[1];
                        break;
                    case ISA.CMP:

                        break;
                    case ISA.JMP:
                        ip = operands[0];
                        break;
                    case ISA.JEQ:
                        if (flags.Zero) ip = operands[0];
                        break;
                    case ISA.JNE:
                        if (!flags.Zero) ip = operands[0];
                        break;
                    case ISA.JGT:
                        if (flags.Carry) ip = operands[0];
                        break;
                    case ISA.JLT:
                        if (!flags.Carry) ip = operands[0];
                        break;
                    case ISA.JGE:
                        if (flags.Zero || flags.Carry) ip = operands[0];
                        break;
                    case ISA.JLE: // Jump if less than or equal
                        if (flags.Zero || !flags.Carry) ip = operands[0];
                        break;
                    case ISA.CALL:
                        stack.Push((byte)(ip + 2));
                        ip = operands[0];
                        break;
                    case ISA.RET:
                        ip = stack.Pop();
                        break;
                    case ISA.INT:
                        // Interrupt handler
                        break;
                    default:
                        Console.WriteLine("Unknown opcode");
                        break;
                }
                ip += instruction.Length;
            }
        }
    }
}