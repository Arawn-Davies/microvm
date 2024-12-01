using System;

namespace microvm
{
    public class AddressSpace
    {
        /// <summary>
        /// The size of the executable space in memory.
        /// </summary>
        public int execSize;

        /// <summary>
        /// Memory constructor.
        /// </summary>
        /// <param name="exec"></param>
        /// <param name="size"></param>
        public AddressSpace(byte[] exec, int size = 65536) 
        {
            // Initialize memory to either the given size or 64K, and load the program into memory.
            _memory = new byte[size];
            for (int i = 0; i < _memory.Length; i++)
            {
                _memory[i] = 0;
            }
            execSize = exec.Length;
            // Load the program into memory
            for (int i = 0; i < exec.Length; i++)
            {
                _memory[i] = exec[i];
            }
        }

        /// <summary>
        /// Memory space.
        /// </summary>
        public byte[] _memory; // 64K memory space


        /// <summary>
        /// Read a byte from memory.
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public byte ReadByte(ushort address) => _memory[address];

        /// <summary>
        /// Write a byte to memory.
        /// </summary>
        /// <param name="address"></param>
        /// <param name="value"></param>
        /// <exception cref="InvalidOperationException"></exception>
        public void WriteByte(ushort address, byte value)
        {
            // Check if the address is within the memory bounds and not within executable space
            if (address < execSize)
            {
                throw new InvalidOperationException("Cannot write to executable memory!");
            }
            // Write the value to memory
            _memory[address] = value;
        }

        /// <summary>
        /// Read a 16-bit value from memory.
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public ushort ReadWord(ushort address) =>
            (ushort)(_memory[address] | (_memory[address + 1] << 8));

        /// <summary>
        /// Write a 16-bit value to memory.
        /// </summary>
        /// <param name="address"></param>
        /// <param name="value"></param>
        /// <exception cref="InvalidOperationException"></exception>
        public void WriteWord(ushort address, ushort value)
        {
            // Check if the address is within the memory bounds and not within executable space
            if (address < execSize)
            {
                throw new InvalidOperationException("Cannot write to executable memory!");
            }
            // Write the value to memory
            _memory[address] = (byte)(value & 0xFF);
            _memory[address + 1] = (byte)(value >> 8);
        }
    }
}
