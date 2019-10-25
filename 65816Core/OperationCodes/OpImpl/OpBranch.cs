namespace Core.OperationCodes.OpImpl
{
    /// <summary>
    /// Branch if (condition?)
    /// </summary>
    internal class OpBranch : OperationCode
    {
        #region Constructor

        public OpBranch(byte hexValue) :
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
