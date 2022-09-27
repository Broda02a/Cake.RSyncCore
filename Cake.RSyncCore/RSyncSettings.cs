using System.Collections.Generic;
using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.RSyncCore
{
    public class RSyncSettings : ToolSettings
    {
        /// <summary>
        /// Increase verbosity
        /// </summary>
        public bool Verbose { get; set; }

        /// <summary>
        /// Suppress non-error messages
        /// </summary>
        public bool Quiet { get; set; }

        /// <summary>
        /// Skip based on checksum, not mod-time & size
        /// </summary>
        public bool Checksum { get; set; }

        /// <summary>
        /// Archive mode
        /// </summary>
        public bool Archive { get; set; }

        /// <summary>
        /// Recursive mode
        /// </summary>
        public bool Recursive { get; set; }

        /// <summary>
        /// Preserve hard links
        /// </summary>
        public bool KeepHardLinks { get; set; }

        /// <summary>
        /// Preserve permissions
        /// </summary>
        public bool PreservePermissions { get; set; }

        /// <summary>
        /// Preserve executability
        /// </summary>
        public bool PreserveExecutability { get; set; }

        /// <summary>
        /// Preserve acls
        /// </summary>
        public bool PreserveAcls { get; set; }

        /// <summary>
        /// Preserve xattrs
        /// </summary>
        public bool PreserveXAttrs { get; set; }

        /// <summary>
        /// Preserve owner
        /// </summary>
        public bool PreserveOwner { get; set; }

        /// <summary>
        /// Preserve group
        /// </summary>
        public bool PreserveGroup { get; set; }

        /// <summary>
        /// Preserve devices
        /// </summary>
        public bool PreserveDevices { get; set; }

        /// <summary>
        /// Preserve specials
        /// </summary>
        public bool PreserveSpecials { get; set; }

        /// <summary>
        /// Preserve times
        /// </summary>
        public bool PreserveTimes { get; set; }

        /// <summary>
        /// Delete extraneous files from dest dirs
        /// </summary>
        public bool Delete { get; set; }

        /// <summary>
        /// Exclude files matching pattern
        /// </summary>
        public List<string> Excludes { get; set; } = new List<string>();

        /// <summary>
        /// Applies the setting to the given argument builder.
        /// </summary>
        /// <param name="args">The args to modify</param>
        /// <returns>The args</returns>
        public ProcessArgumentBuilder BuildLinuxArguments(ProcessArgumentBuilder args)
        {
            if (Verbose)
            {
                args.Append("--verbose");
            }

            if (Quiet)
            {
                args.Append("--quiet");
            }

            if (Checksum)
            {
                args.Append("--checksum");
            }

            if (Archive)
            {
                args.Append("--archive");
            }

            if (Recursive)
            {
                args.Append("--recursive");
            }

            if (KeepHardLinks)
            {
                args.Append("--hard-links");
            }

            if (PreservePermissions)
            {
                args.Append("--perms");
            }

            if (PreserveExecutability)
            {
                args.Append("--executability");
            }

            if (PreserveAcls)
            {
                args.Append("--acls");
            }

            if (PreserveXAttrs)
            {
                args.Append("--xattrs");
            }

            if (PreserveOwner)
            {
                args.Append("--owner");
            }

            if (PreserveGroup)
            {
                args.Append("--group");
            }

            if (PreserveDevices)
            {
                args.Append("--devices");
            }

            if (PreserveSpecials)
            {
                args.Append("--specials");
            }

            if (PreserveTimes)
            {
                args.Append("--times");
            }

            if (Delete)
            {
                args.Append("--delete");
            }

            foreach (string exclude in Excludes)
            {
                args.AppendSwitchQuoted("--exclude", exclude);
            }

            return args;
        }
    }
}