namespace Core.OperationCodes.OpImpl
{
    /// <summary>
    /// No Operation
    /// </summary>
    internal class OpNOP : OperationCode
    {
        #region Constructor

        public OpNOP(byte hexValue) :
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
