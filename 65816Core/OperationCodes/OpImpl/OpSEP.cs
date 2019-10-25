namespace Core.OperationCodes.OpImpl
{
    /// <summary>
    /// SEP - Reset Processor Status Bits
    /// </summary>
    internal class OpSEP : OperationCode
    {
        #region Constructor

        public OpSEP(byte hexValue) :
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
