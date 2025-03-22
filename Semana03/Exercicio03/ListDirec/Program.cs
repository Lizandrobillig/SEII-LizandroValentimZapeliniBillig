using System.IO;

string path = "//home/lizandro/Downloads/";

string[] files = Directory.GetFiles(path);
foreach (string file in files)
    Console.WriteLine(file);

