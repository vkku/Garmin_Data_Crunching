#region Copyright
////////////////////////////////////////////////////////////////////////////////
// The following FIT Protocol software provided may be used with FIT protocol
// devices only and remains the copyrighted property of Garmin Canada Inc.
// The software is being provided on an "as-is" basis and as an accommodation,
// and therefore all warranties, representations, or guarantees of any kind
// (whether express, implied or statutory) including, without limitation,
// warranties of merchantability, non-infringement, or fitness for a particular
// purpose, are specifically disclaimed.
//
// Copyright 2019 Garmin Canada Inc.
////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 21.14Release
// Tag = production/akw/21.14.00-0-gee56166
////////////////////////////////////////////////////////////////////////////////

#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Linq;

namespace Dynastream.Fit
{
    /// <summary>
    /// Implements the MemoGlob profile message.
    /// </summary>
    public class MemoGlobMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="MemoGlobMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte PartIndex = 250;
            public const byte Memo = 0;
            public const byte MessageNumber = 1;
            public const byte MessageIndex = 2;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public MemoGlobMesg() : base(Profile.GetMesg(MesgNum.MemoGlob))
        {
        }

        public MemoGlobMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the PartIndex field
        /// Comment: Sequence number of memo blocks</summary>
        /// <returns>Returns nullable uint representing the PartIndex field</returns>
        public uint? GetPartIndex()
        {
            Object val = GetFieldValue(250, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set PartIndex field
        /// Comment: Sequence number of memo blocks</summary>
        /// <param name="partIndex_">Nullable field value to be set</param>
        public void SetPartIndex(uint? partIndex_)
        {
            SetFieldValue(250, 0, partIndex_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field Memo</returns>
        public int GetNumMemo()
        {
            return GetNumFieldValues(0, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the Memo field
        /// Comment: Block of utf8 bytes</summary>
        /// <param name="index">0 based index of Memo element to retrieve</param>
        /// <returns>Returns nullable byte representing the Memo field</returns>
        public byte? GetMemo(int index)
        {
            Object val = GetFieldValue(0, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set Memo field
        /// Comment: Block of utf8 bytes</summary>
        /// <param name="index">0 based index of memo</param>
        /// <param name="memo_">Nullable field value to be set</param>
        public void SetMemo(int index, byte? memo_)
        {
            SetFieldValue(0, index, memo_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the MessageNumber field
        /// Comment: Allows relating glob to another mesg  If used only required for first part of each memo_glob</summary>
        /// <returns>Returns nullable ushort representing the MessageNumber field</returns>
        public ushort? GetMessageNumber()
        {
            Object val = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set MessageNumber field
        /// Comment: Allows relating glob to another mesg  If used only required for first part of each memo_glob</summary>
        /// <param name="messageNumber_">Nullable field value to be set</param>
        public void SetMessageNumber(ushort? messageNumber_)
        {
            SetFieldValue(1, 0, messageNumber_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the MessageIndex field
        /// Comment: Index of external mesg</summary>
        /// <returns>Returns nullable ushort representing the MessageIndex field</returns>
        public ushort? GetMessageIndex()
        {
            Object val = GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set MessageIndex field
        /// Comment: Index of external mesg</summary>
        /// <param name="messageIndex_">Nullable field value to be set</param>
        public void SetMessageIndex(ushort? messageIndex_)
        {
            SetFieldValue(2, 0, messageIndex_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
