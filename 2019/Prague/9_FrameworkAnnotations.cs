﻿using System.IO;

class FrameworkAnnotations
{
    void M(string path)
    {
//#nullable enable
        string dirName  = Path.GetDirectoryName(path);
        string fileName = Path.GetFileName(path);
        string fullPath = Path.GetFullPath(path);
        string pathRoot = Path.GetPathRoot(path);
        string relative = Path.GetRelativePath(@"C:\Temp", path);
#nullable disable

//#nullable enable
        Path.GetDirectoryName(null);
        Path.GetFileName(null);
        Path.GetFullPath(null);
        Path.GetPathRoot(null);
        Path.GetRelativePath(null, null);
#nullable disable
    }
}

// 38:30 - 2:30
// sample from Drew's talk
// you think there would be consistency here, a plan for null
