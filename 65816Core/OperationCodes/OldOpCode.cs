using System;

namespace Core.OperationCodes
{
    [Obsolete("Don't use this. Old implementation")]
    internal class OldOpCode
    {
        /// <summary>
        /// The hex value representing this operation code
        /// </summary>
        public byte HexValue
        {
            get;
            private set;
        }

        /// <summary>
        /// The minimum size of this operation code in bytes
        /// </summary>
        public ushort MinimumByteSize
        {
            get;
            private set;
        }

        /// <summary>
        /// The minimum amount of clock cycles it takes to execute this instruction
        /// </summary>
        public ushort MinimumCycles
        {
            get;
            private set;
        }

        /// <summary>
        /// Hidden ctor
        /// </summary>
        private OldOpCode()
        {

        }

        /// <summary>
        /// Creates a new instance of this class
        /// </summary>
        public OldOpCode(byte hexValue, ushort minimumByteSize, ushort minimumCycles)
            : base()
        {
            HexValue = hexValue;
            MinimumByteSize = minimumByteSize;
            MinimumCycles = minimumCycles;
        }
    }
}
