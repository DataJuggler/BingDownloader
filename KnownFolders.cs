using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BingDownloader
{
    public enum KnownFolder
    {        
        Downloads
    }

    /// <summary>
    /// This class is a streamed down version of this, only needing the Downloads folder, I took the rest out.
    /// https://stackoverflow.com/questions/10667012/getting-downloads-folder-in-c
    /// </summary>
    public static class KnownFolders
    {
        private static readonly Dictionary<KnownFolder, Guid> _guids = new()
        {  
            [KnownFolder.Downloads] = new("374DE290-123F-4565-9164-39C4925E467B")
        };

        public static string GetPath(KnownFolder knownFolder)
        {
            return SHGetKnownFolderPath(_guids[knownFolder], 0);
        }

        [DllImport("shell32", CharSet = CharSet.Unicode, ExactSpelling = true, PreserveSig = false)]
        private static extern string SHGetKnownFolderPath(
            [MarshalAs(UnmanagedType.LPStruct)] Guid rfid, uint dwFlags,
            nint hToken = 0);
    }
}
