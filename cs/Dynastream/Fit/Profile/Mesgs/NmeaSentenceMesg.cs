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
    /// Implements the NmeaSentence profile message.
    /// </summary>
    public class NmeaSentenceMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="NmeaSentenceMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte Timestamp = 253;
            public const byte TimestampMs = 0;
            public const byte Sentence = 1;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public NmeaSentenceMesg() : base(Profile.GetMesg(MesgNum.NmeaSentence))
        {
        }

        public NmeaSentenceMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the Timestamp field
        /// Units: s
        /// Comment: Timestamp message was output</summary>
        /// <returns>Returns DateTime representing the Timestamp field</returns>
        public DateTime GetTimestamp()
        {
            Object val = GetFieldValue(253, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return TimestampToDateTime(Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set Timestamp field
        /// Units: s
        /// Comment: Timestamp message was output</summary>
        /// <param name="timestamp_">Nullable field value to be set</param>
        public void SetTimestamp(DateTime timestamp_)
        {
            SetFieldValue(253, 0, timestamp_.GetTimeStamp(), Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the TimestampMs field
        /// Units: ms
        /// Comment: Fractional part of timestamp, added to timestamp</summary>
        /// <returns>Returns nullable ushort representing the TimestampMs field</returns>
        public ushort? GetTimestampMs()
        {
            Object val = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set TimestampMs field
        /// Units: ms
        /// Comment: Fractional part of timestamp, added to timestamp</summary>
        /// <param name="timestampMs_">Nullable field value to be set</param>
        public void SetTimestampMs(ushort? timestampMs_)
        {
            SetFieldValue(0, 0, timestampMs_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Sentence field
        /// Comment: NMEA sentence</summary>
        /// <returns>Returns byte[] representing the Sentence field</returns>
        public byte[] GetSentence()
        {
            byte[] data = (byte[])GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            return data.Take(data.Length - 1).ToArray();
        }

        ///<summary>
        /// Retrieves the Sentence field
        /// Comment: NMEA sentence</summary>
        /// <returns>Returns String representing the Sentence field</returns>
        public String GetSentenceAsString()
        {
            byte[] data = (byte[])GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            return data != null ? Encoding.UTF8.GetString(data, 0, data.Length - 1) : null;
        }

        ///<summary>
        /// Set Sentence field
        /// Comment: NMEA sentence</summary>
        /// <param name="sentence_"> field value to be set</param>
        public void SetSentence(String sentence_)
        {
            byte[] data = Encoding.UTF8.GetBytes(sentence_);
            byte[] zdata = new byte[data.Length + 1];
            data.CopyTo(zdata, 0);
            SetFieldValue(1, 0, zdata, Fit.SubfieldIndexMainField);
        }

        
        /// <summary>
        /// Set Sentence field
        /// Comment: NMEA sentence</summary>
        /// <param name="sentence_">field value to be set</param>
        public void SetSentence(byte[] sentence_)
        {
            SetFieldValue(1, 0, sentence_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
