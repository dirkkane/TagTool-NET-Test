﻿using Newtonsoft.Json;
using System;
using TagTool.Cache.HaloOnline;
using TagTool.Cache;
using TagTool.Common;

namespace TagTool.MtnDewIt.JSON.Handlers
{
    public class BoundsHandler : JsonConverter<IBounds>
    {
        private GameCache Cache;
        private GameCacheHaloOnline CacheContext;

        public BoundsHandler(GameCache cache, GameCacheHaloOnline cacheContext)
        {
            Cache = cache;
            CacheContext = cacheContext;
        }

        public override void WriteJson(JsonWriter writer, IBounds value, JsonSerializer serializer)
        {
            var lower = value.GetType().GetProperty("Lower").GetValue(value);
            var upper = value.GetType().GetProperty("Upper").GetValue(value);

            if (lower.GetType() == typeof(Angle) && upper.GetType() == typeof(Angle))
            {
                var lowerValue = (Angle)lower;
                var upperValue = (Angle)upper;

                writer.WriteValue($@"Lower: Degrees: {lowerValue.Degrees}, Upper: Degrees: {upperValue.Degrees}");
            }
            else 
            {
                writer.WriteValue($@"Lower: {lower}, Upper: {upper}");
            }
        }

        public override IBounds ReadJson(JsonReader reader, Type objectType, IBounds existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            return new Bounds<byte>();
        }
    }
}