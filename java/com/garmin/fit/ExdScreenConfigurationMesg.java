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
import java.math.BigInteger;


public class ExdScreenConfigurationMesg extends Mesg {

    
    public static final int ScreenIndexFieldNum = 0;
    
    public static final int FieldCountFieldNum = 1;
    
    public static final int LayoutFieldNum = 2;
    
    public static final int ScreenEnabledFieldNum = 3;
    

    protected static final  Mesg exdScreenConfigurationMesg;
    static {
        // exd_screen_configuration
        exdScreenConfigurationMesg = new Mesg("exd_screen_configuration", MesgNum.EXD_SCREEN_CONFIGURATION);
        exdScreenConfigurationMesg.addField(new Field("screen_index", ScreenIndexFieldNum, 2, 1, 0, "", false, Profile.Type.UINT8));
        
        exdScreenConfigurationMesg.addField(new Field("field_count", FieldCountFieldNum, 2, 1, 0, "", false, Profile.Type.UINT8));
        
        exdScreenConfigurationMesg.addField(new Field("layout", LayoutFieldNum, 0, 1, 0, "", false, Profile.Type.EXD_LAYOUT));
        
        exdScreenConfigurationMesg.addField(new Field("screen_enabled", ScreenEnabledFieldNum, 0, 1, 0, "", false, Profile.Type.BOOL));
        
    }

    public ExdScreenConfigurationMesg() {
        super(Factory.createMesg(MesgNum.EXD_SCREEN_CONFIGURATION));
    }

    public ExdScreenConfigurationMesg(final Mesg mesg) {
        super(mesg);
    }


    /**
     * Get screen_index field
     *
     * @return screen_index
     */
    public Short getScreenIndex() {
        return getFieldShortValue(0, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Set screen_index field
     *
     * @param screenIndex
     */
    public void setScreenIndex(Short screenIndex) {
        setFieldValue(0, 0, screenIndex, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Get field_count field
     * Comment: number of fields in screen
     *
     * @return field_count
     */
    public Short getFieldCount() {
        return getFieldShortValue(1, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Set field_count field
     * Comment: number of fields in screen
     *
     * @param fieldCount
     */
    public void setFieldCount(Short fieldCount) {
        setFieldValue(1, 0, fieldCount, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Get layout field
     *
     * @return layout
     */
    public ExdLayout getLayout() {
        Short value = getFieldShortValue(2, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD);
        if (value == null) {
            return null;
        }
        return ExdLayout.getByValue(value);
    }

    /**
     * Set layout field
     *
     * @param layout
     */
    public void setLayout(ExdLayout layout) {
        setFieldValue(2, 0, layout.value, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Get screen_enabled field
     *
     * @return screen_enabled
     */
    public Bool getScreenEnabled() {
        Short value = getFieldShortValue(3, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD);
        if (value == null) {
            return null;
        }
        return Bool.getByValue(value);
    }

    /**
     * Set screen_enabled field
     *
     * @param screenEnabled
     */
    public void setScreenEnabled(Bool screenEnabled) {
        setFieldValue(3, 0, screenEnabled.value, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

}
