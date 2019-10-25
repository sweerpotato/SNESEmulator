namespace Core.OperationCodes.OpImpl
{
    /// <summary>
    /// Load Index Register (X|Y) from Memory
    /// </summary>
    internal class OpLDReg : OperationCode
    {
        #region Constructor

        public OpLDReg(byte hexValue) :
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
