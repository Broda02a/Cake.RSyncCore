using Cake.Core;
using Cake.Core.IO;

namespace Cake.RSyncCore
{
    public static class Extensions
    {
        internal static ProcessArgumentBuilder BuildForLinux(this RSyncSettings settings, string source,
            string destination)
        {
            ProcessArgumentBuilder args = new ProcessArgumentBuilder();
            args = settings.BuildLinuxArguments(args);
            args.AppendQuoted(source);
            args.AppendQuoted(destination);
            return args;
        }
    }
}