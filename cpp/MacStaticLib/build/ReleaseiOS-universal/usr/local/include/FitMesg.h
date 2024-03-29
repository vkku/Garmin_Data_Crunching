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


#if !defined(FIT_MESG_H)
#define FIT_MESG_H

#include "fit.hpp"
#include "fit_mesg_definition.hpp"

@interface FitMesg : NSObject
- (FIT_UINT8) Write:(FILE *) file forMesg:(const fit::Mesg *)mesg;
- (FIT_UINT8) Write:(FILE *) file forMesg:(const fit::Mesg *)mesg withDef:(const fit::MesgDefinition *)mesgDef;
@end

#endif /* FIT_MESG_H */
