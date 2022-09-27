using System;
using Cake.Core;
using Cake.Core.Annotations;

namespace Cake.RSyncCore
{
    [CakeNamespaceImport("Cake.RSyncCore")]
    [CakeAliasCategory("RSync")]
    public static class RSyncAliases
    {
        [CakeMethodAlias]
        public static void RSync(this ICakeContext ctx, string source, string destination)
        {
            ctx.RSync(source, destination, new RSyncSettings());
        }

        [CakeMethodAlias]
        public static void RSync(this ICakeContext ctx, string source, string destination, RSyncSettings settings)
        {
            if (ctx.Environment.Platform.Family != PlatformFamily.Linux && 
                ctx.Environment.Platform.Family != PlatformFamily.OSX)
                throw new NotSupportedException("rsync is only supported on linux/mac");
            RSyncRunner runner = new RSyncRunner(ctx);
            runner.RunTool(source, destination, settings);
        }
    }
}