using System.Collections.Generic;
using Cake.Core;
using Cake.Core.Diagnostics;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.RSyncCore
{
    /// <summary>
    /// RSync Tool Runner
    /// </summary>
    public class RSyncRunner : Tool<RSyncSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <c>RSyncRunner</c> class.
        /// </summary>
        /// <param name="fileSystem">The file system.</param>
        /// <param name="environment">The environment.</param>
        /// <param name="processRunner">The process runner.</param>
        /// <param name="tools">The tool locator.</param>
        /// <param name="log">The log.</param>
        public RSyncRunner(IFileSystem fileSystem, ICakeEnvironment environment, IProcessRunner processRunner,
            IToolLocator tools, ICakeLog log)
            : base(fileSystem, environment, processRunner, tools)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <c>RSyncRunner</c> class.
        /// </summary>
        /// <param name="ctx">The context.</param>
        public RSyncRunner(ICakeContext ctx)
            : this(ctx.FileSystem, ctx.Environment, ctx.ProcessRunner, ctx.Tools, ctx.Log)
        {
        }

        /// <summary>
        /// The rsync tool name
        /// </summary>
        /// <returns></returns>
        protected override string GetToolName()
        {
            return "RSyncCore";
        }

        /// <summary>
        /// The rsync tool names
        /// </summary>
        /// <returns></returns>
        protected override IEnumerable<string> GetToolExecutableNames()
        {
            yield return "rsync";
        }

        /// <summary>
        /// Runs the RSync tool
        /// </summary>
        /// <param name="source">The source</param>
        /// <param name="destination">The destination</param>
        /// <param name="settings">The settings to use</param>
        public void RunTool(string source, string destination, RSyncSettings settings)
        {
            Run(settings, settings.BuildForLinux(source, destination));
        }
    }
}