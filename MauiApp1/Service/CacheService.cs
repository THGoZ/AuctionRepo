using System.Collections.Generic;

namespace AuctionMobileApp.Service
{
    public class CacheService
    {
        private static readonly Dictionary<string, object> Cache = new();

        public static void AddOrUpdate(string key, object value)
        {
            if (Cache.ContainsKey(key))
                Cache[key] = value;
            else
                Cache.Add(key, value);
        }

        public static T Get<T>(string key)
        {
            if (Cache.ContainsKey(key) && Cache[key] is T value)
                return value;

            return default;
        }

        public static void Remove(string key)
        {
            if (Cache.ContainsKey(key))
                Cache.Remove(key);
        }

        public static void Clear()
        {
            Cache.Clear();
        }
    }
}

