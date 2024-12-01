using System;

namespace microvm
{
    public class Stack
    {
        /// <summary>
        /// Create a new stack with 256 16-bit values and a stack pointer that points to the top of the stack.
        /// </summary>
        public Stack(int stackSize)
        {
            _stack = new ushort[stackSize];
            _sp = 0xFF; // Stack pointer starts at the top of the stack
        }

        /// <summary>
        /// The stack
        /// </summary>
        private readonly ushort[] _stack;

        /// <summary>
        /// The stack pointer
        /// </summary>
        private byte _sp;

        /// <summary>
        /// Push a 16-bit value onto the stack.
        /// </summary>
        /// <param name="value"></param>
        /// <exception cref="StackOverflowException"></exception>
        public void Push(ushort value)
        {
            if (_sp == 0) throw new StackOverflowException("Stack overflow!");
            _stack[_sp--] = value;
        }

        /// <summary>
        /// Pop a 16-bit value from the stack.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public ushort Pop()
        {
            if (_sp == 0xFF) throw new InvalidOperationException("Stack underflow!");
            return _stack[++_sp];
        }
    }
}
