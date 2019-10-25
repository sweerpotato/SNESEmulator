namespace Core.OperationCodes.OpImpl
{
    /// <summary>
    /// Clear (some flag)
    /// </summary>
    internal class OpClearFlag : OperationCode
    {
        #region Constructor

        public OpClearFlag(byte hexValue) :
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
