namespace Cake.RSyncCore
{
    public static class RSyncSettingsExtensions
    {
        public static RSyncSettings SetVerbose(this RSyncSettings settings, bool verbose = true)
        {
            settings.Verbose = verbose;
            return settings;
        }

        public static RSyncSettings SetQuiet(this RSyncSettings settings, bool quiet = true)
        {
            settings.Quiet = quiet;
            return settings;
        }

        public static RSyncSettings UseChecksums(this RSyncSettings settings, bool checksums = true)
        {
            settings.Checksum = checksums;
            return settings;
        }

        public static RSyncSettings ArchieveMode(this RSyncSettings settings, bool archive = true)
        {
            settings.Archive = archive;
            return settings;
        }

        public static RSyncSettings CopyRecursively(this RSyncSettings settings, bool recursive = true)
        {
            settings.Recursive = recursive;
            return settings;
        }

        public static RSyncSettings KeepHardLinks(this RSyncSettings settings, bool hardLinks = true)
        {
            settings.KeepHardLinks = hardLinks;
            return settings;
        }

        public static RSyncSettings PreservePermissions(this RSyncSettings settings, bool permissions = true)
        {
            settings.PreservePermissions = permissions;
            return settings;
        }

        public static RSyncSettings PreserveAcls(this RSyncSettings settings, bool acls = true)
        {
            settings.PreserveAcls = acls;
            return settings;
        }


        public static RSyncSettings PreserveXAttrs(this RSyncSettings settings, bool xattrs = true)
        {
            settings.PreserveXAttrs = xattrs;
            return settings;
        }

        public static RSyncSettings PreserveOwner(this RSyncSettings settings, bool owner = true)
        {
            settings.PreserveOwner = owner;
            return settings;
        }

        public static RSyncSettings PreserveGroup(this RSyncSettings settings, bool group = true)
        {
            settings.PreserveGroup = group;
            return settings;
        }

        public static RSyncSettings PreserveDevices(this RSyncSettings settings, bool devices = true)
        {
            settings.PreserveDevices = devices;
            return settings;
        }

        public static RSyncSettings PreserveSpecials(this RSyncSettings settings, bool specials = true)
        {
            settings.PreserveSpecials = specials;
            return settings;
        }

        public static RSyncSettings PreserveTimes(this RSyncSettings settings, bool times = true)
        {
            settings.PreserveTimes = times;
            return settings;
        }

        public static RSyncSettings DeleteExtraFiles(this RSyncSettings settings, bool delete = true)
        {
            settings.Delete = delete;
            return settings;
        }

        public static RSyncSettings Exclude(this RSyncSettings settings, string path)
        {
            settings.Excludes.Add(path);
            return settings;
        }
    }
}