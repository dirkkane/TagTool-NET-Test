﻿using Newtonsoft.Json;
using System;
using TagTool.Cache.HaloOnline;
using TagTool.Cache;
using TagTool.Common;

namespace TagTool.MtnDewIt.JSON.Handlers
{
    public class RealEulerAngles2dHandler : JsonConverter<RealEulerAngles2d>
    {
        private GameCache Cache;
        private GameCacheHaloOnline CacheContext;

        public RealEulerAngles2dHandler(GameCache cache, GameCacheHaloOnline cacheContext)
        {
            Cache = cache;
            CacheContext = cacheContext;
        }

        public override void WriteJson(JsonWriter writer, RealEulerAngles2d value, JsonSerializer serializer)
        {
            writer.WriteValue($@"Yaw: {value.Yaw.Degrees}, Pitch: {value.Pitch.Degrees}");
        }

        public override RealEulerAngles2d ReadJson(JsonReader reader, Type objectType, RealEulerAngles2d existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var value = reader.Value.ToString();
            var valueArray = value
            .Replace("Yaw: ", "")
            .Replace("Pitch: ", "")
            .Split(',');

            var yaw = float.Parse(valueArray[0]);
            var pitch = float.Parse(valueArray[1]);

            return new RealEulerAngles2d(Angle.FromDegrees(yaw), Angle.FromDegrees(pitch));
        }
    }
}