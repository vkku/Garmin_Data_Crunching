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


#if !defined(FIT_GPS_METADATA_MESG_HPP)
#define FIT_GPS_METADATA_MESG_HPP

#include "fit_mesg.hpp"

namespace fit
{

class GpsMetadataMesg : public Mesg
{
public:
    class FieldDefNum final
    {
    public:
       static const FIT_UINT8 Timestamp = 253;
       static const FIT_UINT8 TimestampMs = 0;
       static const FIT_UINT8 PositionLat = 1;
       static const FIT_UINT8 PositionLong = 2;
       static const FIT_UINT8 EnhancedAltitude = 3;
       static const FIT_UINT8 EnhancedSpeed = 4;
       static const FIT_UINT8 Heading = 5;
       static const FIT_UINT8 UtcTimestamp = 6;
       static const FIT_UINT8 Velocity = 7;
       static const FIT_UINT8 Invalid = FIT_FIELD_NUM_INVALID;
    };

    GpsMetadataMesg(void) : Mesg(Profile::MESG_GPS_METADATA)
    {
    }

    GpsMetadataMesg(const Mesg &mesg) : Mesg(mesg)
    {
    }

    ///////////////////////////////////////////////////////////////////////
    // Checks the validity of timestamp field
    // Returns FIT_TRUE if field is valid
    ///////////////////////////////////////////////////////////////////////
    FIT_BOOL IsTimestampValid() const
    {
        const Field* field = GetField(253);
        if( FIT_NULL == field )
        {
            return FIT_FALSE;
        }

        return field->IsValueValid();
    }

    ///////////////////////////////////////////////////////////////////////
    // Returns timestamp field
    // Units: s
    // Comment: Whole second part of the timestamp.
    ///////////////////////////////////////////////////////////////////////
    FIT_DATE_TIME GetTimestamp(void) const
    {
        return GetFieldUINT32Value(253, 0, FIT_SUBFIELD_INDEX_MAIN_FIELD);
    }

    ///////////////////////////////////////////////////////////////////////
    // Set timestamp field
    // Units: s
    // Comment: Whole second part of the timestamp.
    ///////////////////////////////////////////////////////////////////////
    void SetTimestamp(FIT_DATE_TIME timestamp)
    {
        SetFieldUINT32Value(253, timestamp, 0, FIT_SUBFIELD_INDEX_MAIN_FIELD);
    }

    ///////////////////////////////////////////////////////////////////////
    // Checks the validity of timestamp_ms field
    // Returns FIT_TRUE if field is valid
    ///////////////////////////////////////////////////////////////////////
    FIT_BOOL IsTimestampMsValid() const
    {
        const Field* field = GetField(0);
        if( FIT_NULL == field )
        {
            return FIT_FALSE;
        }

        return field->IsValueValid();
    }

    ///////////////////////////////////////////////////////////////////////
    // Returns timestamp_ms field
    // Units: ms
    // Comment: Millisecond part of the timestamp.
    ///////////////////////////////////////////////////////////////////////
    FIT_UINT16 GetTimestampMs(void) const
    {
        return GetFieldUINT16Value(0, 0, FIT_SUBFIELD_INDEX_MAIN_FIELD);
    }

    ///////////////////////////////////////////////////////////////////////
    // Set timestamp_ms field
    // Units: ms
    // Comment: Millisecond part of the timestamp.
    ///////////////////////////////////////////////////////////////////////
    void SetTimestampMs(FIT_UINT16 timestampMs)
    {
        SetFieldUINT16Value(0, timestampMs, 0, FIT_SUBFIELD_INDEX_MAIN_FIELD);
    }

    ///////////////////////////////////////////////////////////////////////
    // Checks the validity of position_lat field
    // Returns FIT_TRUE if field is valid
    ///////////////////////////////////////////////////////////////////////
    FIT_BOOL IsPositionLatValid() const
    {
        const Field* field = GetField(1);
        if( FIT_NULL == field )
        {
            return FIT_FALSE;
        }

        return field->IsValueValid();
    }

    ///////////////////////////////////////////////////////////////////////
    // Returns position_lat field
    // Units: semicircles
    ///////////////////////////////////////////////////////////////////////
    FIT_SINT32 GetPositionLat(void) const
    {
        return GetFieldSINT32Value(1, 0, FIT_SUBFIELD_INDEX_MAIN_FIELD);
    }

    ///////////////////////////////////////////////////////////////////////
    // Set position_lat field
    // Units: semicircles
    ///////////////////////////////////////////////////////////////////////
    void SetPositionLat(FIT_SINT32 positionLat)
    {
        SetFieldSINT32Value(1, positionLat, 0, FIT_SUBFIELD_INDEX_MAIN_FIELD);
    }

    ///////////////////////////////////////////////////////////////////////
    // Checks the validity of position_long field
    // Returns FIT_TRUE if field is valid
    ///////////////////////////////////////////////////////////////////////
    FIT_BOOL IsPositionLongValid() const
    {
        const Field* field = GetField(2);
        if( FIT_NULL == field )
        {
            return FIT_FALSE;
        }

        return field->IsValueValid();
    }

    ///////////////////////////////////////////////////////////////////////
    // Returns position_long field
    // Units: semicircles
    ///////////////////////////////////////////////////////////////////////
    FIT_SINT32 GetPositionLong(void) const
    {
        return GetFieldSINT32Value(2, 0, FIT_SUBFIELD_INDEX_MAIN_FIELD);
    }

    ///////////////////////////////////////////////////////////////////////
    // Set position_long field
    // Units: semicircles
    ///////////////////////////////////////////////////////////////////////
    void SetPositionLong(FIT_SINT32 positionLong)
    {
        SetFieldSINT32Value(2, positionLong, 0, FIT_SUBFIELD_INDEX_MAIN_FIELD);
    }

    ///////////////////////////////////////////////////////////////////////
    // Checks the validity of enhanced_altitude field
    // Returns FIT_TRUE if field is valid
    ///////////////////////////////////////////////////////////////////////
    FIT_BOOL IsEnhancedAltitudeValid() const
    {
        const Field* field = GetField(3);
        if( FIT_NULL == field )
        {
            return FIT_FALSE;
        }

        return field->IsValueValid();
    }

    ///////////////////////////////////////////////////////////////////////
    // Returns enhanced_altitude field
    // Units: m
    ///////////////////////////////////////////////////////////////////////
    FIT_FLOAT32 GetEnhancedAltitude(void) const
    {
        return GetFieldFLOAT32Value(3, 0, FIT_SUBFIELD_INDEX_MAIN_FIELD);
    }

    ///////////////////////////////////////////////////////////////////////
    // Set enhanced_altitude field
    // Units: m
    ///////////////////////////////////////////////////////////////////////
    void SetEnhancedAltitude(FIT_FLOAT32 enhancedAltitude)
    {
        SetFieldFLOAT32Value(3, enhancedAltitude, 0, FIT_SUBFIELD_INDEX_MAIN_FIELD);
    }

    ///////////////////////////////////////////////////////////////////////
    // Checks the validity of enhanced_speed field
    // Returns FIT_TRUE if field is valid
    ///////////////////////////////////////////////////////////////////////
    FIT_BOOL IsEnhancedSpeedValid() const
    {
        const Field* field = GetField(4);
        if( FIT_NULL == field )
        {
            return FIT_FALSE;
        }

        return field->IsValueValid();
    }

    ///////////////////////////////////////////////////////////////////////
    // Returns enhanced_speed field
    // Units: m/s
    ///////////////////////////////////////////////////////////////////////
    FIT_FLOAT32 GetEnhancedSpeed(void) const
    {
        return GetFieldFLOAT32Value(4, 0, FIT_SUBFIELD_INDEX_MAIN_FIELD);
    }

    ///////////////////////////////////////////////////////////////////////
    // Set enhanced_speed field
    // Units: m/s
    ///////////////////////////////////////////////////////////////////////
    void SetEnhancedSpeed(FIT_FLOAT32 enhancedSpeed)
    {
        SetFieldFLOAT32Value(4, enhancedSpeed, 0, FIT_SUBFIELD_INDEX_MAIN_FIELD);
    }

    ///////////////////////////////////////////////////////////////////////
    // Checks the validity of heading field
    // Returns FIT_TRUE if field is valid
    ///////////////////////////////////////////////////////////////////////
    FIT_BOOL IsHeadingValid() const
    {
        const Field* field = GetField(5);
        if( FIT_NULL == field )
        {
            return FIT_FALSE;
        }

        return field->IsValueValid();
    }

    ///////////////////////////////////////////////////////////////////////
    // Returns heading field
    // Units: degrees
    ///////////////////////////////////////////////////////////////////////
    FIT_FLOAT32 GetHeading(void) const
    {
        return GetFieldFLOAT32Value(5, 0, FIT_SUBFIELD_INDEX_MAIN_FIELD);
    }

    ///////////////////////////////////////////////////////////////////////
    // Set heading field
    // Units: degrees
    ///////////////////////////////////////////////////////////////////////
    void SetHeading(FIT_FLOAT32 heading)
    {
        SetFieldFLOAT32Value(5, heading, 0, FIT_SUBFIELD_INDEX_MAIN_FIELD);
    }

    ///////////////////////////////////////////////////////////////////////
    // Checks the validity of utc_timestamp field
    // Returns FIT_TRUE if field is valid
    ///////////////////////////////////////////////////////////////////////
    FIT_BOOL IsUtcTimestampValid() const
    {
        const Field* field = GetField(6);
        if( FIT_NULL == field )
        {
            return FIT_FALSE;
        }

        return field->IsValueValid();
    }

    ///////////////////////////////////////////////////////////////////////
    // Returns utc_timestamp field
    // Units: s
    // Comment: Used to correlate UTC to system time if the timestamp of the message is in system time.  This UTC time is derived from the GPS data.
    ///////////////////////////////////////////////////////////////////////
    FIT_DATE_TIME GetUtcTimestamp(void) const
    {
        return GetFieldUINT32Value(6, 0, FIT_SUBFIELD_INDEX_MAIN_FIELD);
    }

    ///////////////////////////////////////////////////////////////////////
    // Set utc_timestamp field
    // Units: s
    // Comment: Used to correlate UTC to system time if the timestamp of the message is in system time.  This UTC time is derived from the GPS data.
    ///////////////////////////////////////////////////////////////////////
    void SetUtcTimestamp(FIT_DATE_TIME utcTimestamp)
    {
        SetFieldUINT32Value(6, utcTimestamp, 0, FIT_SUBFIELD_INDEX_MAIN_FIELD);
    }

    ///////////////////////////////////////////////////////////////////////
    // Returns number of velocity
    ///////////////////////////////////////////////////////////////////////
    FIT_UINT8 GetNumVelocity(void) const
    {
        return GetFieldNumValues(7, FIT_SUBFIELD_INDEX_MAIN_FIELD);
    }

    ///////////////////////////////////////////////////////////////////////
    // Checks the validity of velocity field
    // Returns FIT_TRUE if field is valid
    ///////////////////////////////////////////////////////////////////////
    FIT_BOOL IsVelocityValid(FIT_UINT8 index) const
    {
        const Field* field = GetField(7);
        if( FIT_NULL == field )
        {
            return FIT_FALSE;
        }

        return field->IsValueValid(index);
    }

    ///////////////////////////////////////////////////////////////////////
    // Returns velocity field
    // Units: m/s
    // Comment: velocity[0] is lon velocity.  Velocity[1] is lat velocity.  Velocity[2] is altitude velocity.
    ///////////////////////////////////////////////////////////////////////
    FIT_FLOAT32 GetVelocity(FIT_UINT8 index) const
    {
        return GetFieldFLOAT32Value(7, index, FIT_SUBFIELD_INDEX_MAIN_FIELD);
    }

    ///////////////////////////////////////////////////////////////////////
    // Set velocity field
    // Units: m/s
    // Comment: velocity[0] is lon velocity.  Velocity[1] is lat velocity.  Velocity[2] is altitude velocity.
    ///////////////////////////////////////////////////////////////////////
    void SetVelocity(FIT_UINT8 index, FIT_FLOAT32 velocity)
    {
        SetFieldFLOAT32Value(7, velocity, index, FIT_SUBFIELD_INDEX_MAIN_FIELD);
    }

};

} // namespace fit

#endif // !defined(FIT_GPS_METADATA_MESG_HPP)
