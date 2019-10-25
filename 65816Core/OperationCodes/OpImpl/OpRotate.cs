namespace Core.OperationCodes.OpImpl
{
    /// <summary>
    /// RO(L|R) - Rotate Memory or Accumulator Left or Right
    /// </summary>
    internal class OpRotate : OperationCode
    {
        #region Constructor

        public OpRotate(byte hexValue) :
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
