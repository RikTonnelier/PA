public class KeyInBox
{
    public KeyInBox() {}

    public string SearchIterative(string folderPath)
    {
        List<string> folderList = new List<string>();
        string[] folders = Directory.GetDirectories(folderPath);
        for(int i = 0; i < folders.Length; i++)
        {
            folderList.Add(folders[i]);
        }

        while (folderList.Count != 0)
        {
            // Check for our file
            string[] files = Directory.GetFiles(folderList[0]);
            if (files.Length > 0)
            {
                return files[0];
            }

            // Add folders to the list
            folderList.AddRange(Directory.GetDirectories(folderList[0]));

            // Remove current folder from the list
            folderList.RemoveAt(0);
        }

        return "NOT FOUND";
    }

    public string SearchRecursive(string folderPath)
    {
        IEnumerable<string> items = Directory.EnumerateFileSystemEntries(folderPath);

        foreach (string item in items)
        {
            // Base case
            if (File.Exists(item))
            {
                return item;
            }

            // Recursive case
            else if (Directory.Exists(item))
            {
                string result = SearchRecursive(item);
                if(result != "NOT FOUND")
                {
                    return result;
                }
            }
        }

        return "NOT FOUND";
    }
}