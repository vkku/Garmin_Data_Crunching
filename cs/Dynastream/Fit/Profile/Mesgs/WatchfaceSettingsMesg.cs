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
    /// Implements the WatchfaceSettings profile message.
    /// </summary>
    public class WatchfaceSettingsMesg : Mesg
    {
        #region Fields
        static class LayoutSubfield
        {
            public static ushort DigitalLayout = 0;
            public static ushort AnalogLayout = 1;
            public static ushort Subfields = 2;
            public static ushort Active = Fit.SubfieldIndexActiveSubfield;
            public static ushort MainField = Fit.SubfieldIndexMainField;
        }
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="WatchfaceSettingsMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte MessageIndex = 254;
            public const byte Mode = 0;
            public const byte Layout = 1;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public WatchfaceSettingsMesg() : base(Profile.GetMesg(MesgNum.WatchfaceSettings))
        {
        }

        public WatchfaceSettingsMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the MessageIndex field</summary>
        /// <returns>Returns nullable ushort representing the MessageIndex field</returns>
        public ushort? GetMessageIndex()
        {
            Object val = GetFieldValue(254, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set MessageIndex field</summary>
        /// <param name="messageIndex_">Nullable field value to be set</param>
        public void SetMessageIndex(ushort? messageIndex_)
        {
            SetFieldValue(254, 0, messageIndex_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Mode field</summary>
        /// <returns>Returns nullable WatchfaceMode enum representing the Mode field</returns>
        public WatchfaceMode? GetMode()
        {
            object obj = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            WatchfaceMode? value = obj == null ? (WatchfaceMode?)null : (WatchfaceMode)obj;
            return value;
        }

        /// <summary>
        /// Set Mode field</summary>
        /// <param name="mode_">Nullable field value to be set</param>
        public void SetMode(WatchfaceMode? mode_)
        {
            SetFieldValue(0, 0, mode_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Layout field</summary>
        /// <returns>Returns nullable byte representing the Layout field</returns>
        public byte? GetLayout()
        {
            Object val = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set Layout field</summary>
        /// <param name="layout_">Nullable field value to be set</param>
        public void SetLayout(byte? layout_)
        {
            SetFieldValue(1, 0, layout_, Fit.SubfieldIndexMainField);
        }
        

        /// <summary>
        /// Retrieves the DigitalLayout subfield</summary>
        /// <returns>Nullable DigitalWatchfaceLayout enum representing the DigitalLayout subfield</returns>
        public DigitalWatchfaceLayout? GetDigitalLayout()
        {
            return (DigitalWatchfaceLayout?)GetFieldValue(1, 0, LayoutSubfield.DigitalLayout);
        }

        /// <summary>
        ///
        /// Set DigitalLayout subfield</summary>
        /// <param name="digitalLayout">Subfield value to be set</param>
        public void SetDigitalLayout(byte? digitalLayout)
        {
            SetFieldValue(1, 0, digitalLayout, LayoutSubfield.DigitalLayout);
        }

        /// <summary>
        /// Retrieves the AnalogLayout subfield</summary>
        /// <returns>Nullable AnalogWatchfaceLayout enum representing the AnalogLayout subfield</returns>
        public AnalogWatchfaceLayout? GetAnalogLayout()
        {
            return (AnalogWatchfaceLayout?)GetFieldValue(1, 0, LayoutSubfield.AnalogLayout);
        }

        /// <summary>
        ///
        /// Set AnalogLayout subfield</summary>
        /// <param name="analogLayout">Subfield value to be set</param>
        public void SetAnalogLayout(byte? analogLayout)
        {
            SetFieldValue(1, 0, analogLayout, LayoutSubfield.AnalogLayout);
        }
        #endregion // Methods
    } // Class
} // namespace
