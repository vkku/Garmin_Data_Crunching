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


package com.garmin.fit;


public enum SourceType {
    ANT((short)0),
    ANTPLUS((short)1),
    BLUETOOTH((short)2),
    BLUETOOTH_LOW_ENERGY((short)3),
    WIFI((short)4),
    LOCAL((short)5),
    INVALID((short)255);

    protected short value;

    private SourceType(short value) {
        this.value = value;
    }

    public static SourceType getByValue(final Short value) {
        for (final SourceType type : SourceType.values()) {
            if (value == type.value)
                return type;
        }

        return SourceType.INVALID;
    }

    /**
     * Retrieves the String Representation of the Value
     * @return The string representation of the value
     */
    public static String getStringFromValue( SourceType value ) {
        return value.name();
    }

    public short getValue() {
        return value;
    }


}
