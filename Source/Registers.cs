// Create the registers class using Prorgam.cs as a template.
using System;

namespace microvm
{
    class Registers
    {
        #region registers
        /// <summary>
        /// Program Counter
        /// </summary>
        public byte PC;

        /// <summary>
        /// Stack Pointer
        /// </summary>
        public byte SP;

        /// <summary>
        /// Instruction Pointer
        /// </summary>
        public byte IP;

        /// <summary>
        /// Stack segment
        /// </summary>
        public byte SS;

        /// <summary>
        /// Lower-half of general purpose register A
        /// </summary>
        public byte AL;

        /// <summary>
        /// Upper-half of general purpose register A
        /// </summary>
        public byte AH;

        /// <summary>
        /// Lower-half of general purpose register B
        /// </summary>
        public byte BL;

        /// <summary>
        /// Upper-half of general purpose register B
        /// </summary>
        public byte BH;

        /// <summary>
        /// Lower-half of general purpose register C
        /// </summary>
        public byte CL;

        /// <summary>
        /// Upper-half of general purpose register C
        /// </summary>
        public byte CH;

        /// <summary>
        /// Lower-half of general purpose register D
        /// </summary>
        public byte DL;

        /// <summary>
        /// Upper-half of general purpose register D
        /// </summary>
        public byte DH;

        /// <summary>
        /// 32-bit general purpose register
        /// </summary>
        public Int32 X;

        /// <summary>
        /// 32-bit general purpose register
        /// </summary>
        public Int32 Y;
        #endregion

        public Registers()
        {
            PC = 0;
            SP = 0;
            IP = 0;
            SS = 0;
            AL = 0;
            AH = 0;
            BL = 0;
            BH = 0;
            CL = 0;
            CH = 0;
            DL = 0;
            DH = 0;
            X = 0;
            Y = 0;
        }
    }
}