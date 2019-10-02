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


public class ActivityMesg extends Mesg implements MesgWithEvent {

    
    public static final int TimestampFieldNum = 253;
    
    public static final int TotalTimerTimeFieldNum = 0;
    
    public static final int NumSessionsFieldNum = 1;
    
    public static final int TypeFieldNum = 2;
    
    public static final int EventFieldNum = 3;
    
    public static final int EventTypeFieldNum = 4;
    
    public static final int LocalTimestampFieldNum = 5;
    
    public static final int EventGroupFieldNum = 6;
    

    protected static final  Mesg activityMesg;
    static {
        // activity
        activityMesg = new Mesg("activity", MesgNum.ACTIVITY);
        activityMesg.addField(new Field("timestamp", TimestampFieldNum, 134, 1, 0, "", false, Profile.Type.DATE_TIME));
        
        activityMesg.addField(new Field("total_timer_time", TotalTimerTimeFieldNum, 134, 1000, 0, "s", false, Profile.Type.UINT32));
        
        activityMesg.addField(new Field("num_sessions", NumSessionsFieldNum, 132, 1, 0, "", false, Profile.Type.UINT16));
        
        activityMesg.addField(new Field("type", TypeFieldNum, 0, 1, 0, "", false, Profile.Type.ACTIVITY));
        
        activityMesg.addField(new Field("event", EventFieldNum, 0, 1, 0, "", false, Profile.Type.EVENT));
        
        activityMesg.addField(new Field("event_type", EventTypeFieldNum, 0, 1, 0, "", false, Profile.Type.EVENT_TYPE));
        
        activityMesg.addField(new Field("local_timestamp", LocalTimestampFieldNum, 134, 1, 0, "", false, Profile.Type.LOCAL_DATE_TIME));
        
        activityMesg.addField(new Field("event_group", EventGroupFieldNum, 2, 1, 0, "", false, Profile.Type.UINT8));
        
    }

    public ActivityMesg() {
        super(Factory.createMesg(MesgNum.ACTIVITY));
    }

    public ActivityMesg(final Mesg mesg) {
        super(mesg);
    }


    /**
     * Get timestamp field
     *
     * @return timestamp
     */
    public DateTime getTimestamp() {
        return timestampToDateTime(getFieldLongValue(253, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD));
    }

    /**
     * Set timestamp field
     *
     * @param timestamp
     */
    public void setTimestamp(DateTime timestamp) {
        setFieldValue(253, 0, timestamp.getTimestamp(), Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Get total_timer_time field
     * Units: s
     * Comment: Exclude pauses
     *
     * @return total_timer_time
     */
    public Float getTotalTimerTime() {
        return getFieldFloatValue(0, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Set total_timer_time field
     * Units: s
     * Comment: Exclude pauses
     *
     * @param totalTimerTime
     */
    public void setTotalTimerTime(Float totalTimerTime) {
        setFieldValue(0, 0, totalTimerTime, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Get num_sessions field
     *
     * @return num_sessions
     */
    public Integer getNumSessions() {
        return getFieldIntegerValue(1, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Set num_sessions field
     *
     * @param numSessions
     */
    public void setNumSessions(Integer numSessions) {
        setFieldValue(1, 0, numSessions, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Get type field
     *
     * @return type
     */
    public Activity getType() {
        Short value = getFieldShortValue(2, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD);
        if (value == null) {
            return null;
        }
        return Activity.getByValue(value);
    }

    /**
     * Set type field
     *
     * @param type
     */
    public void setType(Activity type) {
        setFieldValue(2, 0, type.value, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Get event field
     *
     * @return event
     */
    public Event getEvent() {
        Short value = getFieldShortValue(3, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD);
        if (value == null) {
            return null;
        }
        return Event.getByValue(value);
    }

    /**
     * Set event field
     *
     * @param event
     */
    public void setEvent(Event event) {
        setFieldValue(3, 0, event.value, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Get event_type field
     *
     * @return event_type
     */
    public EventType getEventType() {
        Short value = getFieldShortValue(4, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD);
        if (value == null) {
            return null;
        }
        return EventType.getByValue(value);
    }

    /**
     * Set event_type field
     *
     * @param eventType
     */
    public void setEventType(EventType eventType) {
        setFieldValue(4, 0, eventType.value, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Get local_timestamp field
     * Comment: timestamp epoch expressed in local time, used to convert activity timestamps to local time 
     *
     * @return local_timestamp
     */
    public Long getLocalTimestamp() {
        return getFieldLongValue(5, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Set local_timestamp field
     * Comment: timestamp epoch expressed in local time, used to convert activity timestamps to local time 
     *
     * @param localTimestamp
     */
    public void setLocalTimestamp(Long localTimestamp) {
        setFieldValue(5, 0, localTimestamp, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Get event_group field
     *
     * @return event_group
     */
    public Short getEventGroup() {
        return getFieldShortValue(6, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Set event_group field
     *
     * @param eventGroup
     */
    public void setEventGroup(Short eventGroup) {
        setFieldValue(6, 0, eventGroup, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

}
