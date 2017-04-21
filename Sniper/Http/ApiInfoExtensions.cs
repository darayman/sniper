using System;


namespace Sniper.Http
{
    public static class ApiInfoExtensions
    {
        public static Uri GetPreviousPageUrl(this ApiInfo info)
        {
            Ensure.ArgumentNotNull(nameof(info), info);
            
            return info.Links.SafeGet(HttpKeys.Previous);
        }

        public static Uri GetNextPageUrl(this ApiInfo info)
        {
            Ensure.ArgumentNotNull(nameof(info), info);

            return info.Links.SafeGet(HttpKeys.Next);
        }

        public static Uri GetFirstPageUrl(this ApiInfo info)
        {
            Ensure.ArgumentNotNull(nameof(info), info);

            return info.Links.SafeGet(HttpKeys.First);
        }

        public static Uri GetLastPageUrl(this ApiInfo info)
        {
            Ensure.ArgumentNotNull(nameof(info), info);

            return info.Links.SafeGet(HttpKeys.Last);
        }
    }
}