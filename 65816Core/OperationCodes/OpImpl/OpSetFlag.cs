namespace Core.OperationCodes.OpImpl
{
    /// <summary>
    /// Set (some flag)
    /// </summary>
    internal class OpSetFlag : OperationCode
    {
        #region Constructor

        public OpSetFlag(byte hexValue) :
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
