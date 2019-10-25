using System;
using Core.OperationCodes.OpImpl;

namespace Core.OperationCodes
{
    internal static class OpCodeFactory
    {
        public static OperationCode GetOpCode(byte hexValue)
        {
            switch (hexValue)
            {
                #region ADC - Add with Carry
                case 0x61:
                case 0x63:
                case 0x65:
                case 0x67:
                case 0x69:
                case 0x6D:
                case 0x6F:
                case 0x71:
                case 0x72:
                case 0x73:
                case 0x75:
                case 0x77:
                case 0x79:
                case 0x7D:
                case 0x7F:
                    return new OpADC(hexValue);
                #endregion
                #region AND - AND Accumulator with Memory
                case 0x21:
                case 0x23:
                case 0x25:
                case 0x27:
                case 0x29:
                case 0x2D:
                case 0x2F:
                case 0x31:
                case 0x32:
                case 0x33:
                case 0x35:
                case 0x37:
                case 0x39:
                case 0x3D:
                case 0x3F:
                    return new OpAND(hexValue);
                #endregion
                #region ASL - Arithmetic Shift Left
                case 0x06:
                case 0x0A:
                case 0x0E:
                case 0x16:
                case 0x1E:
                    return new OpASL(hexValue);
                #endregion
                #region Branches
                case 0x90:
                case 0xB0:
                case 0xF0:
                case 0x30:
                case 0xD0:
                case 0x10:
                case 0x80:
                case 0x82:
                case 0x50:
                case 0x70:
                    return new OpBranch(hexValue);
                #endregion
                #region BIT - Test Bits
                case 0x24:
                case 0x2C:
                case 0x34:
                case 0x3C:
                case 0x89:
                    return new OpBIT(hexValue);
                #endregion
                #region Clear Flag
                case 0x18:
                case 0xD8:
                case 0x58:
                case 0xB8:
                    return new OpClearFlag(hexValue);
                #endregion
                #region CMP - Compare Accumulator with Memory
                case 0xC1:
                case 0xC3:
                case 0xC5:
                case 0xC7:
                case 0xC9:
                case 0xCD:
                case 0xCF:
                case 0xD1:
                case 0xD2:
                case 0xD3:
                case 0xD5:
                case 0xD7:
                case 0xD9:
                case 0xDD:
                case 0xDF:
                case 0xE0:
                case 0xE4:
                case 0xEC:
                case 0xC0:
                case 0xC4:
                case 0xCC:
                    return new OpCMP(hexValue);
                #endregion
                #region DEC - Decrement
                case 0x3A:
                case 0xC6:
                case 0xCE:
                case 0xD6:
                case 0xDE:
                case 0xCA:
                case 0x88:
                    return new OpDEC(hexValue);
                #endregion
                #region EOR - Exclusive OR aka XOR
                case 0x41:
                case 0x43:
                case 0x45:
                case 0x47:
                case 0x49:
                case 0x4D:
                case 0x4F:
                case 0x51:
                case 0x52:
                case 0x53:
                case 0x55:
                case 0x57:
                case 0x59:
                case 0x5D:
                case 0x5F:
                    return new OpEOR(hexValue);
                #endregion
                #region INC - Increment
                case 0x1A:
                case 0xE6:
                case 0xEE:
                case 0xF6:
                case 0xFE:
                case 0xE8:
                case 0xC8:
                    return new OpINC(hexValue);
                #endregion
                #region Jumps
                case 0x4C:
                case 0x5C:
                case 0x6C:
                case 0x7C:
                case 0xDC:
                case 0x20:
                case 0x22:
                case 0xFC:
                    return new OpJump(hexValue);
                #endregion
                #region LDA - Load Accumulator from Memory
                case 0xA1:
                case 0xA3:
                case 0xA5:
                case 0xA7:
                case 0xA9:
                case 0xAD:
                case 0xAF:
                case 0xB1:
                case 0xB2:
                case 0xB3:
                case 0xB5:
                case 0xB7:
                case 0xB9:
                case 0xBD:
                case 0xBF:
                    return new OpLDA(hexValue);
                #endregion
                #region LD(X|Y) - Load Index Register (X|Y) from Memory
                case 0xA2:
                case 0xA6:
                case 0xAE:
                case 0xB6:
                case 0xBE:
                case 0xA0:
                case 0xA4:
                case 0xAC:
                case 0xB4:
                case 0xBC:
                    return new OpLDReg(hexValue);
                #endregion
                #region LSR - Logical Shift Memory or Accumulator Right
                case 0x46:
                case 0x4A:
                case 0x4E:
                case 0x56:
                case 0x5E:
                    return new OpLSR(hexValue);
                #endregion
                #region ORA - OR Accumulator with Memory
                case 0x01:
                case 0x03:
                case 0x05:
                case 0x07:
                case 0x09:
                case 0x0D:
                case 0x0F:
                case 0x11:
                case 0x12:
                case 0x13:
                case 0x15:
                case 0x17:
                case 0x19:
                case 0x1D:
                case 0x1F:
                    return new OpORA(hexValue);
                #endregion
                #region Pushes
                case 0xF4:
                case 0xD4:
                case 0x62:
                case 0x48:
                case 0x8B:
                case 0x0B:
                case 0x4B:
                case 0x08:
                case 0xDA:
                case 0x5A:
                    return new OpPush(hexValue);
                #endregion
                #region Pulls
                case 0x68:
                case 0xAB:
                case 0x2B:
                case 0x28:
                case 0xFA:
                case 0x7A:
                    return new OpPull(hexValue);
                #endregion
                #region RO(L|R) - Rotate Memory or Accumulator Left or Right
                case 0x26:
                case 0x2A:
                case 0x2E:
                case 0x36:
                case 0x3E:
                case 0x66:
                case 0x6A:
                case 0x6E:
                case 0x76:
                case 0x7E:
                    return new OpRotate(hexValue);
                #endregion
                #region Returns
                case 0x40:
                case 0x6B:
                case 0x60:
                    return new OpReturn(hexValue);
                #endregion
                #region SBC - Subtract with Borrow from Accumulator
                case 0xE1:
                case 0xE3:
                case 0xE5:
                case 0xE7:
                case 0xE9:
                case 0xED:
                case 0xEF:
                case 0xF1:
                case 0xF2:
                case 0xF3:
                case 0xF5:
                case 0xF7:
                case 0xF9:
                case 0xFD:
                case 0xFF:
                    return new OpSBC(hexValue);
                #endregion
                #region STA - Store Accumulator to Memory
                case 0x81:
                case 0x83:
                case 0x85:
                case 0x87:
                case 0x8D:
                case 0x8F:
                case 0x91:
                case 0x92:
                case 0x93:
                case 0x95:
                case 0x97:
                case 0x99:
                case 0x9D:
                case 0x9F:
                    return new OpSTA(hexValue);
                #endregion
                #region Store Index ((Register X|Y)|Zero) to Memory
                case 0x86:
                case 0x8E:
                case 0x96:
                case 0x84:
                case 0x8C:
                case 0x94:
                case 0x64:
                case 0x74:
                case 0x9C:
                case 0x9E:
                    return new OpStore(hexValue);
                #endregion
                #region Transfers
                case 0xAA:
                case 0xA8:
                case 0x5B:
                case 0x1B:
                case 0x7B:
                case 0x3B:
                case 0xBA:
                case 0x8A:
                case 0x9A:
                case 0x9B:
                case 0x98:
                case 0xBB:
                    return new OpTransfer(hexValue);
                #endregion
                #region Tests and (Re)Sets
                case 0x14:
                case 0x1C:
                case 0x04:
                case 0x0C:
                    return new OpTest(hexValue);
                #endregion
                #region STP - Stop Processor
                case 0xDB:
                    return new OpSTP(hexValue);
                #endregion
                #region Set Flag
                case 0x38:
                case 0xF8:
                case 0x78:
                    return new OpSetFlag(hexValue);
                #endregion
                #region REP - Reset Processor Status Bits
                case 0xC2:
                    return new OpREP(hexValue);
                #endregion
                #region SEP - Set Processor Status Bits
                case 0xE2:
                    return new OpSEP(hexValue);
                #endregion
                #region Block Move
                case 0x54:
                case 0x44:
                    return new OpBlockMove(hexValue);
                #endregion
                #region Different exchanges
                case 0xEB:
                case 0xFB:
                    return new OpExchange(hexValue);
                #endregion
                #region WAI - Wait for Interrupt
                case 0xCB:
                    return new OpWAI(hexValue);
                #endregion
                #region NOP - No Operation
                case 0xEA:
                    return new OpNOP(hexValue);
                #endregion
                #region Co-Processor Enable
                case 0x02:
                    return new OpCOP(hexValue);
                #endregion
                #region Break
                case 0x00:
                    return new OpBreak(hexValue);
                #endregion
                #region Reserved and Default case
                //Reserved
                case 0x42:
                default:
                    throw new ArgumentException(String.Format("{0} is not a valid operation code", hexValue));
                #endregion
            }
        }
    }
}
