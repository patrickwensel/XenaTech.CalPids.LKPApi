namespace XenaTech.CalPids.LKPApi.Contracts.V1
{
    public static class ApiRoutes
    {
        public const string Root = "api";

        public const string Version = "v1";

        public const string Base = Root + "/" + Version;

        public static class LastKnownPositions
        {
            public const string GetAll = Base + "/last-known-positions";
        }

        public static class TripLkps
        {
            public const string GetAll = Base + "/trip-lkps";
        }
    }
}