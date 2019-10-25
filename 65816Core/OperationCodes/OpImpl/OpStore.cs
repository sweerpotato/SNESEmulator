namespace Core.OperationCodes.OpImpl
{
    /// <summary>
    /// Store Index ((Register X|Y)|Zero) to Memory
    /// </summary>
    internal class OpStore : OperationCode
    {
        #region Constructor

        public OpStore(byte hexValue) :
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
