using System;
using System.Collections.Generic;

class InfoHdd
{
    public string NameDisk { get; }
    public decimal DiskSpace { get; }
    public decimal Total { get; }

    public InfoHdd(string namedisk, decimal space, decimal total)
    {
        NameDisk = namedisk;
        DiskSpace = space;
        Total = total;
    }
    
}

public class Folder
{
    public List<string> Files { get; set; } = new List<string>();
}

class Program
{
    public static void Main()
    {

    }

    Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();

    public void CreateFolder(string name)
    {
        Folders.Add(name, new Folder());
    }
}