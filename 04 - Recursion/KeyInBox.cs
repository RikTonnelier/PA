public class KeyInBox
{
    public string Algorithm1(string basefolder)
    {
        string path = "";

        List<string> list = new List<string>();
        list.Add(basefolder);

        while (list.Count > 0)
        {
            string folder = list.First();

            if (Directory.GetFiles(folder).Length > 0)
            {
                // Found key
                return folder;
            }
            else if (Directory.GetDirectories(folder).Length > 0)
            {
                // Found more boxes
                list.AddRange(Directory.GetDirectories(folder));
            }

            list.Remove(folder);
        }

        return path;
    }

    public string Algorithm2(string basefolder)
    {
        foreach (string item in Directory.EnumerateFileSystemEntries(basefolder))
        {
            if (Directory.Exists(item))
            {
                // Folder - box
                string value = Algorithm2(item);
                if (value != "")
                {
                    return value;
                }
            }
            else if (File.Exists(item))
            {
                // File - key
                return item;
            }
        }
        return "";
    }
}