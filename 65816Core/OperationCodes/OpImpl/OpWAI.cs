namespace Core.OperationCodes.OpImpl
{
    /// <summary>
    /// WAI - Wait for Interrupt
    /// </summary>
    internal class OpWAI : OperationCode
    {
        #region Constructor

        public OpWAI(byte hexValue) :
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
