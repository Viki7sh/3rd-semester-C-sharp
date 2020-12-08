using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_3
{
    public class Options
    {
        public DirectoryOptions DirectoryOptions { get; set; }
        public ArchiveOptions ArchiveOptions { get; set; }
    }

    public class DirectoryOptions
    {
        public string SourceDirectory { get; set; }
        public string TargetDirectory { get; set; }
    }

    public class ArchiveOptions
    {
        public string ArchiveName { get; set; }
    }
}