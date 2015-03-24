/*
    Copyright (C) 2007-2010 Team MediaPortal
    http://www.team-mediaportal.com

    This file is part of MediaPortal 2

    MediaPortal 2 is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    MediaPortal 2 is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with MediaPortal 2.  If not, see <http://www.gnu.org/licenses/>.
*/

#pragma once

#ifndef __STREAM_PACKAGE_PACKET_RESPONSE_DEFINED
#define __STREAM_PACKAGE_PACKET_RESPONSE_DEFINED

#include "StreamPackageResponse.h"
#include "MediaPacket.h"

#define STREAM_PACKAGE_PACKET_RESPONSE_FLAG_NONE                      STREAM_PACKAGE_RESPONSE_FLAG_NONE

#define STREAM_PACKAGE_PACKET_RESPONSE_FLAG_LAST                      (STREAM_PACKAGE_RESPONSE_FLAG_LAST + 0)

class CStreamPackagePacketResponse : public CStreamPackageResponse
{
public:
  CStreamPackagePacketResponse(HRESULT *result);
  virtual ~CStreamPackagePacketResponse(void);

  /* get methods */

  // gets media packet
  // @return : media packet or NULL if not set
  virtual CMediaPacket *GetMediaPacket(void);

  /* set methods */

  /* other methods */

protected:
  // holds media packet
  CMediaPacket *mediaPacket;

  /* methods */

  // gets new instance of stream package error response
  // @return : new stream package error response instance or NULL if error
  virtual CStreamPackageResponse *CreatePackageResponse(void);

  // deeply clones current instance
  // @param item : the stream package error response instance to clone
  // @return : true if successful, false otherwise
  virtual bool InternalClone(CStreamPackageResponse *item);
};

#endif