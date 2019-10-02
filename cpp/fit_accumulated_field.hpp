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


#if !defined(FIT_ACCUMULATED_FIELD_HPP)
#define FIT_ACCUMULATED_FIELD_HPP

#include "fit.hpp"

namespace fit
{

class AccumulatedField
{
   public:
      FIT_UINT16 mesgNum;
      FIT_UINT8 destFieldNum; //Field# to accumulate into
      FIT_UINT32 lastValue;
      FIT_UINT32 accumulatedValue;

      AccumulatedField();
      AccumulatedField(const FIT_UINT16 newMesgNum, const FIT_UINT8 destFieldNum);
      FIT_UINT32 Accumulate(const FIT_UINT32 value, const FIT_UINT8 bits);
      FIT_UINT32 Set(FIT_UINT32 value);

   private:
};

} // namespace fit

#endif // defined(FIT_ACCUMULATED_FIELD_HPP)


