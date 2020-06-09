using System;

namespace XenaTech.CalPids.LKPApi.Contracts.V1.Responses
{
    public class LastKnownPositionResponse
    {
        public string ID { get; set; }
        public int CarNum { get; set; }
        public string Protocol { get; set; }
        public int Date { get; set; }
        public double Time { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Speed { get; set; }
        public string Bearing { get; set; }
        public string SatellitesInUse { get; set; }
        public string HDOP { get; set; }
        public DateTime DBTime { get; set; }
        public string Corridor { get; set; }
        public string MileMarker { get; set; }
        public double TrackPointNumber { get; set; }
        public string Direction { get; set; }
    }
}