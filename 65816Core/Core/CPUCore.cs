using System;
using System.Threading;
using Core.Constants;
using Core.Logging;
using Core.Memory;

namespace Core
{
    public static class CPUCore
    {
        public static void Start(CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                int cpuCycles = CPUConstants.INTERRUPT_PERIOD;
                int programCounter = CPUConstants.INITIAL_PROGRAM_COUNTER;

                Logger.Log("Starting CPU core");
                MemoryBank b = new MemoryBank(0x00, 0xFF);
                while (true)
                {
                    //read opcode
                    //OpCode = Memory[programCounter++]
                    //decrement cpucycles with the time each opcode takes (sort of)
                    //cpuCycles -= OpCodes[OpCode]

                    if (cancellationToken.IsCancellationRequested)
                    {
                        Logger.Log("Cancellation requested, stopping...");
                        break;
                    }
                }

                Logger.Log("Stopped CPU core");
            }
            catch (Exception e)
            {
                Logger.Log(String.Format("Unhandled exception occurred:\n{0}", e.ToString()));
            }
        }
    }
}
