using System;
using Core.Logging;

namespace Core.Memory
{
    internal class MemoryBank
    {
        //1 bank = 64 kilobyte
        /// <summary>
        /// Actual memory
        /// </summary>
        private byte[] _ActualBytes = new byte[65536];

        /// <summary>
        /// The lowest address of this bank
        /// </summary>
        private readonly byte _LoAddr = 0x00;

        /// <summary>
        /// The highest address of this bank
        /// </summary>
        private readonly byte _HiAddr = 0x00;

        public MemoryBank(byte loAddr, byte hiAddr)
        {
            Logger.Log(String.Format("Creating memory bank from 0x{0:X} to 0x{1:X}", loAddr, hiAddr));
            _LoAddr = loAddr;
            _HiAddr = hiAddr;
        }
    }
}
