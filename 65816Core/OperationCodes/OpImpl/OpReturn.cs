namespace Core.OperationCodes.OpImpl
{
    /// <summary>
    /// Different returns
    /// </summary>
    internal class OpReturn : OperationCode
    {
        #region Constructor

        public OpReturn(byte hexValue) :
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
