using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XenaTech.CalPids.LKPApi.Domain
{
    public class LKP
    {
        public string ID { get; set; }
        public int CarNum { get; set; }
    }
}


//[ID] [nvarchar] (50) NOT NULL,

// [CarNum] [int]
//NOT NULL,

// [Protocol] [nvarchar] (50) NOT NULL,

//  [Date] [int]
//NOT NULL,

//  [Time] [float]
//NOT NULL,

//  [Latitude] [float]
//NOT NULL,

//  [Longitude] [float]
//NOT NULL,

//  [Speed] [nvarchar] (50) NOT NULL,

//   [Bearing] [nvarchar] (50) NOT NULL,
//	[SatellitesInUse] [nvarchar] (50) NOT NULL,
 
//	 [HDOP] [nvarchar] (50) NOT NULL,
  
//	  [DBTime] [datetime2] (7) NOT NULL,
   
//	   [Corridor] [nvarchar] (50) NOT NULL,
	
//		[MileMarker] [nvarchar] (50) NOT NULL,
	 
//		 [TrackPointNumber] [float]
//NOT NULL,
	 
//		 [Direction] [nvarchar] (50) NOT NULL,
