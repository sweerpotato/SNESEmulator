namespace Core.Constants
{
    internal static class CPUConstants
    {
        /// <summary>
        /// The number of "CPU cycles" before we will have to check for interrupts
        /// </summary>
        public static readonly int INTERRUPT_PERIOD = 100;

        /// <summary>
        /// The initial value of the program counter
        /// </summary>
        public static readonly int INITIAL_PROGRAM_COUNTER = 1;
    }
}
