namespace Core.Registry
{
    /// <summary>
    /// Processor register, also known as the P Register
    /// </summary>
    internal static class PRegister
    {
        /// <summary>
        /// The Negative flag
        /// </summary>
        public static bool NFlag = false;

        /// <summary>
        /// The Overflow flag
        /// </summary>
        public static bool VFlag = false;

        /// <summary>
        /// Accumulator register size. <see langword="false"/>=16-bit, <see langword="true"/>=8-bit 
        /// </summary>
        public static bool MFlag = false;

        /// <summary>
        /// Accumulator register size. <see langword="false"/>=16-bit, <see langword="true"/>=8-bit 
        /// </summary>
        public static bool XFlag = false;

        /// <summary>
        /// The Decimal flag
        /// </summary>
        public static bool DFlag = false;

        /// <summary>
        /// The IRQ disable flag
        /// </summary>
        public static bool IFlag = false;

        /// <summary>
        /// The Zero flag
        /// </summary>
        public static bool ZFlag = false;

        /// <summary>
        /// The Carry flag
        /// </summary>
        public static bool CFlag = false;

        /// <summary>
        /// The Emulation mode flag. Unused
        /// </summary>
        //private static bool EFlag = false;

        /// <summary>
        /// The Break flag, used by emulation mode. Unused
        /// </summary>
        //private static bool BFlag = false;
    }
}
