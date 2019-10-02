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
    /// Implements the WorkoutSession profile message.
    /// </summary>
    public class WorkoutSessionMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="WorkoutSessionMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte MessageIndex = 254;
            public const byte Sport = 0;
            public const byte SubSport = 1;
            public const byte NumValidSteps = 2;
            public const byte FirstStepIndex = 3;
            public const byte PoolLength = 4;
            public const byte PoolLengthUnit = 5;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public WorkoutSessionMesg() : base(Profile.GetMesg(MesgNum.WorkoutSession))
        {
        }

        public WorkoutSessionMesg(Mesg mesg) : base(mesg)
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
        /// Retrieves the Sport field</summary>
        /// <returns>Returns nullable Sport enum representing the Sport field</returns>
        public Sport? GetSport()
        {
            object obj = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            Sport? value = obj == null ? (Sport?)null : (Sport)obj;
            return value;
        }

        /// <summary>
        /// Set Sport field</summary>
        /// <param name="sport_">Nullable field value to be set</param>
        public void SetSport(Sport? sport_)
        {
            SetFieldValue(0, 0, sport_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the SubSport field</summary>
        /// <returns>Returns nullable SubSport enum representing the SubSport field</returns>
        public SubSport? GetSubSport()
        {
            object obj = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            SubSport? value = obj == null ? (SubSport?)null : (SubSport)obj;
            return value;
        }

        /// <summary>
        /// Set SubSport field</summary>
        /// <param name="subSport_">Nullable field value to be set</param>
        public void SetSubSport(SubSport? subSport_)
        {
            SetFieldValue(1, 0, subSport_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the NumValidSteps field</summary>
        /// <returns>Returns nullable ushort representing the NumValidSteps field</returns>
        public ushort? GetNumValidSteps()
        {
            Object val = GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set NumValidSteps field</summary>
        /// <param name="numValidSteps_">Nullable field value to be set</param>
        public void SetNumValidSteps(ushort? numValidSteps_)
        {
            SetFieldValue(2, 0, numValidSteps_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the FirstStepIndex field</summary>
        /// <returns>Returns nullable ushort representing the FirstStepIndex field</returns>
        public ushort? GetFirstStepIndex()
        {
            Object val = GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set FirstStepIndex field</summary>
        /// <param name="firstStepIndex_">Nullable field value to be set</param>
        public void SetFirstStepIndex(ushort? firstStepIndex_)
        {
            SetFieldValue(3, 0, firstStepIndex_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the PoolLength field
        /// Units: m</summary>
        /// <returns>Returns nullable float representing the PoolLength field</returns>
        public float? GetPoolLength()
        {
            Object val = GetFieldValue(4, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set PoolLength field
        /// Units: m</summary>
        /// <param name="poolLength_">Nullable field value to be set</param>
        public void SetPoolLength(float? poolLength_)
        {
            SetFieldValue(4, 0, poolLength_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the PoolLengthUnit field</summary>
        /// <returns>Returns nullable DisplayMeasure enum representing the PoolLengthUnit field</returns>
        public DisplayMeasure? GetPoolLengthUnit()
        {
            object obj = GetFieldValue(5, 0, Fit.SubfieldIndexMainField);
            DisplayMeasure? value = obj == null ? (DisplayMeasure?)null : (DisplayMeasure)obj;
            return value;
        }

        /// <summary>
        /// Set PoolLengthUnit field</summary>
        /// <param name="poolLengthUnit_">Nullable field value to be set</param>
        public void SetPoolLengthUnit(DisplayMeasure? poolLengthUnit_)
        {
            SetFieldValue(5, 0, poolLengthUnit_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
