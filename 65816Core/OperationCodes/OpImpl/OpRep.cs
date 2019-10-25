namespace Core.OperationCodes.OpImpl
{
    /// <summary>
    /// REP - Reset Processor Status Bits
    /// </summary>
    internal class OpREP : OperationCode
    {
        #region Constructor

        public OpREP(byte hexValue) :
            base(hexValue)
        {

        }

        #endregion

        #region Methods

        public override void DoOperation()
        {

        }

        #endregion
    }
}
