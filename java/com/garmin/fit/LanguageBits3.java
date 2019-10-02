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

import java.util.HashMap;
import java.util.Map;

public class LanguageBits3 {
    public static final short BULGARIAN = 0x01;
    public static final short ROMANIAN = 0x02;
    public static final short CHINESE = 0x04;
    public static final short JAPANESE = 0x08;
    public static final short KOREAN = 0x10;
    public static final short TAIWANESE = 0x20;
    public static final short THAI = 0x40;
    public static final short HEBREW = 0x80;
    public static final short INVALID = Fit.UINT8Z_INVALID;

    private static final Map<Short, String> stringMap;

    static {
        stringMap = new HashMap<Short, String>();
        stringMap.put(BULGARIAN, "BULGARIAN");
        stringMap.put(ROMANIAN, "ROMANIAN");
        stringMap.put(CHINESE, "CHINESE");
        stringMap.put(JAPANESE, "JAPANESE");
        stringMap.put(KOREAN, "KOREAN");
        stringMap.put(TAIWANESE, "TAIWANESE");
        stringMap.put(THAI, "THAI");
        stringMap.put(HEBREW, "HEBREW");
    }


    /**
     * Retrieves the String Representation of the Value
     * @return The string representation of the value, or empty if unknown
     */
    public static String getStringFromValue( Short value ) {
        if( stringMap.containsKey( value ) ) {
            return stringMap.get( value );
        }

        return "";
    }

    /**
     * Retrieves a value given a string representation
     * @return The value or INVALID if unkwown
     */
    public static Short getValueFromString( String value ) {
        for( Map.Entry<Short, String> entry : stringMap.entrySet() ) {
            if( entry.getValue().equals( value ) ) {
                return entry.getKey();
            }
        }

        return INVALID;
    }

}
