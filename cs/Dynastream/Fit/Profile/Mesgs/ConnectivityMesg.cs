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
    /// Implements the Connectivity profile message.
    /// </summary>
    public class ConnectivityMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="ConnectivityMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte BluetoothEnabled = 0;
            public const byte BluetoothLeEnabled = 1;
            public const byte AntEnabled = 2;
            public const byte Name = 3;
            public const byte LiveTrackingEnabled = 4;
            public const byte WeatherConditionsEnabled = 5;
            public const byte WeatherAlertsEnabled = 6;
            public const byte AutoActivityUploadEnabled = 7;
            public const byte CourseDownloadEnabled = 8;
            public const byte WorkoutDownloadEnabled = 9;
            public const byte GpsEphemerisDownloadEnabled = 10;
            public const byte IncidentDetectionEnabled = 11;
            public const byte GrouptrackEnabled = 12;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public ConnectivityMesg() : base(Profile.GetMesg(MesgNum.Connectivity))
        {
        }

        public ConnectivityMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the BluetoothEnabled field
        /// Comment: Use Bluetooth for connectivity features</summary>
        /// <returns>Returns nullable Bool enum representing the BluetoothEnabled field</returns>
        public Bool? GetBluetoothEnabled()
        {
            object obj = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set BluetoothEnabled field
        /// Comment: Use Bluetooth for connectivity features</summary>
        /// <param name="bluetoothEnabled_">Nullable field value to be set</param>
        public void SetBluetoothEnabled(Bool? bluetoothEnabled_)
        {
            SetFieldValue(0, 0, bluetoothEnabled_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the BluetoothLeEnabled field
        /// Comment: Use Bluetooth Low Energy for connectivity features</summary>
        /// <returns>Returns nullable Bool enum representing the BluetoothLeEnabled field</returns>
        public Bool? GetBluetoothLeEnabled()
        {
            object obj = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set BluetoothLeEnabled field
        /// Comment: Use Bluetooth Low Energy for connectivity features</summary>
        /// <param name="bluetoothLeEnabled_">Nullable field value to be set</param>
        public void SetBluetoothLeEnabled(Bool? bluetoothLeEnabled_)
        {
            SetFieldValue(1, 0, bluetoothLeEnabled_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the AntEnabled field
        /// Comment: Use ANT for connectivity features</summary>
        /// <returns>Returns nullable Bool enum representing the AntEnabled field</returns>
        public Bool? GetAntEnabled()
        {
            object obj = GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set AntEnabled field
        /// Comment: Use ANT for connectivity features</summary>
        /// <param name="antEnabled_">Nullable field value to be set</param>
        public void SetAntEnabled(Bool? antEnabled_)
        {
            SetFieldValue(2, 0, antEnabled_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Name field</summary>
        /// <returns>Returns byte[] representing the Name field</returns>
        public byte[] GetName()
        {
            byte[] data = (byte[])GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
            return data.Take(data.Length - 1).ToArray();
        }

        ///<summary>
        /// Retrieves the Name field</summary>
        /// <returns>Returns String representing the Name field</returns>
        public String GetNameAsString()
        {
            byte[] data = (byte[])GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
            return data != null ? Encoding.UTF8.GetString(data, 0, data.Length - 1) : null;
        }

        ///<summary>
        /// Set Name field</summary>
        /// <param name="name_"> field value to be set</param>
        public void SetName(String name_)
        {
            byte[] data = Encoding.UTF8.GetBytes(name_);
            byte[] zdata = new byte[data.Length + 1];
            data.CopyTo(zdata, 0);
            SetFieldValue(3, 0, zdata, Fit.SubfieldIndexMainField);
        }

        
        /// <summary>
        /// Set Name field</summary>
        /// <param name="name_">field value to be set</param>
        public void SetName(byte[] name_)
        {
            SetFieldValue(3, 0, name_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the LiveTrackingEnabled field</summary>
        /// <returns>Returns nullable Bool enum representing the LiveTrackingEnabled field</returns>
        public Bool? GetLiveTrackingEnabled()
        {
            object obj = GetFieldValue(4, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set LiveTrackingEnabled field</summary>
        /// <param name="liveTrackingEnabled_">Nullable field value to be set</param>
        public void SetLiveTrackingEnabled(Bool? liveTrackingEnabled_)
        {
            SetFieldValue(4, 0, liveTrackingEnabled_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the WeatherConditionsEnabled field</summary>
        /// <returns>Returns nullable Bool enum representing the WeatherConditionsEnabled field</returns>
        public Bool? GetWeatherConditionsEnabled()
        {
            object obj = GetFieldValue(5, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set WeatherConditionsEnabled field</summary>
        /// <param name="weatherConditionsEnabled_">Nullable field value to be set</param>
        public void SetWeatherConditionsEnabled(Bool? weatherConditionsEnabled_)
        {
            SetFieldValue(5, 0, weatherConditionsEnabled_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the WeatherAlertsEnabled field</summary>
        /// <returns>Returns nullable Bool enum representing the WeatherAlertsEnabled field</returns>
        public Bool? GetWeatherAlertsEnabled()
        {
            object obj = GetFieldValue(6, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set WeatherAlertsEnabled field</summary>
        /// <param name="weatherAlertsEnabled_">Nullable field value to be set</param>
        public void SetWeatherAlertsEnabled(Bool? weatherAlertsEnabled_)
        {
            SetFieldValue(6, 0, weatherAlertsEnabled_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the AutoActivityUploadEnabled field</summary>
        /// <returns>Returns nullable Bool enum representing the AutoActivityUploadEnabled field</returns>
        public Bool? GetAutoActivityUploadEnabled()
        {
            object obj = GetFieldValue(7, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set AutoActivityUploadEnabled field</summary>
        /// <param name="autoActivityUploadEnabled_">Nullable field value to be set</param>
        public void SetAutoActivityUploadEnabled(Bool? autoActivityUploadEnabled_)
        {
            SetFieldValue(7, 0, autoActivityUploadEnabled_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the CourseDownloadEnabled field</summary>
        /// <returns>Returns nullable Bool enum representing the CourseDownloadEnabled field</returns>
        public Bool? GetCourseDownloadEnabled()
        {
            object obj = GetFieldValue(8, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set CourseDownloadEnabled field</summary>
        /// <param name="courseDownloadEnabled_">Nullable field value to be set</param>
        public void SetCourseDownloadEnabled(Bool? courseDownloadEnabled_)
        {
            SetFieldValue(8, 0, courseDownloadEnabled_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the WorkoutDownloadEnabled field</summary>
        /// <returns>Returns nullable Bool enum representing the WorkoutDownloadEnabled field</returns>
        public Bool? GetWorkoutDownloadEnabled()
        {
            object obj = GetFieldValue(9, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set WorkoutDownloadEnabled field</summary>
        /// <param name="workoutDownloadEnabled_">Nullable field value to be set</param>
        public void SetWorkoutDownloadEnabled(Bool? workoutDownloadEnabled_)
        {
            SetFieldValue(9, 0, workoutDownloadEnabled_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the GpsEphemerisDownloadEnabled field</summary>
        /// <returns>Returns nullable Bool enum representing the GpsEphemerisDownloadEnabled field</returns>
        public Bool? GetGpsEphemerisDownloadEnabled()
        {
            object obj = GetFieldValue(10, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set GpsEphemerisDownloadEnabled field</summary>
        /// <param name="gpsEphemerisDownloadEnabled_">Nullable field value to be set</param>
        public void SetGpsEphemerisDownloadEnabled(Bool? gpsEphemerisDownloadEnabled_)
        {
            SetFieldValue(10, 0, gpsEphemerisDownloadEnabled_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the IncidentDetectionEnabled field</summary>
        /// <returns>Returns nullable Bool enum representing the IncidentDetectionEnabled field</returns>
        public Bool? GetIncidentDetectionEnabled()
        {
            object obj = GetFieldValue(11, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set IncidentDetectionEnabled field</summary>
        /// <param name="incidentDetectionEnabled_">Nullable field value to be set</param>
        public void SetIncidentDetectionEnabled(Bool? incidentDetectionEnabled_)
        {
            SetFieldValue(11, 0, incidentDetectionEnabled_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the GrouptrackEnabled field</summary>
        /// <returns>Returns nullable Bool enum representing the GrouptrackEnabled field</returns>
        public Bool? GetGrouptrackEnabled()
        {
            object obj = GetFieldValue(12, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set GrouptrackEnabled field</summary>
        /// <param name="grouptrackEnabled_">Nullable field value to be set</param>
        public void SetGrouptrackEnabled(Bool? grouptrackEnabled_)
        {
            SetFieldValue(12, 0, grouptrackEnabled_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
