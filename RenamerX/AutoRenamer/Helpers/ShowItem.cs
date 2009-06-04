using RenamerX;
using System.Collections.Generic;

public class ShowItem
{
    public string ShowName;
    public string ShowDirectory;
    public List<ShowInfo> ShowInfos = new List<ShowInfo>();

    public ShowItem(string showName, string showDirectory)
    {
        ShowName = showName;
        ShowDirectory = showDirectory;
    }

    public override string ToString()
    {
        return ShowName + ": " + ShowDirectory.Remove(0, ShowDirectory.LastIndexOf("\\") + 1);
    }
}