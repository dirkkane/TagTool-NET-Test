using System.Collections.Generic;
using System.IO;
using TagTool.Cache.HaloOnline;
using TagTool.Cache;
using TagTool.Common;
using TagTool.Shaders;
using TagTool.Tags.Definitions;

namespace TagTool.MtnDewIt.Shaders.RenderMethodDefinitions.Shaders
{
    public class shaders_decal_options_global_decal_options_render_method_option : RenderMethodData
    {
        public shaders_decal_options_global_decal_options_render_method_option(GameCache cache, GameCacheHaloOnline cacheContext, Stream stream) : base
        (
            cache,
            cacheContext,
            stream
        )
        {
            Cache = cache;
            CacheContext = cacheContext;
            Stream = stream;
            RenderMethod();
        }

        public override void RenderMethod()
        {
            var tag = Cache.TagCache.GetTag<RenderMethodOption>($@"shaders\decal_options\global_decal_options");
            var rmop = CacheContext.Deserialize<RenderMethodOption>(Stream, tag);
            rmop.Parameters = null;

            CacheContext.Serialize(Stream, tag, rmop);
        }
    }
}
