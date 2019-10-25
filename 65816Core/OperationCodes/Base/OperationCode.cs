namespace Core.OperationCodes.OpImpl
{
    internal abstract class OperationCode
    {
        #region Properties and Fields

        /// <summary>
        /// The hex value representing this operation code
        /// </summary>
        public byte HexValue
        {
            get;
            private set;
        }

        #endregion

        #region Constructor

        protected OperationCode(byte hexValue)
        {
            HexValue = hexValue;
        }

        #endregion

        #region Methods

        public abstract void DoOperation();

        #endregion
    }
}
