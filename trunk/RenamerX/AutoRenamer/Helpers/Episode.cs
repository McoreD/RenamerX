using System.Xml;

public class Episode
{
    public string EpisodeNumber;
    public string SeasonEpisodeNumber;
    public string Title;

    public Episode(string episodeNumber, string seasonEpisodeNumber, string title)
    {
        EpisodeNumber = episodeNumber;
        SeasonEpisodeNumber = seasonEpisodeNumber;
        Title = title;
    }

    public Episode(XmlNode xmlNode)
    {
        XmlNode node;
        node = xmlNode.SelectSingleNode("seasonnum");
        if (node != null)
        {
            EpisodeNumber = node.InnerText;
        }
        node = xmlNode.SelectSingleNode("epnum");
        if (node != null)
        {
            SeasonEpisodeNumber = node.InnerText;
        }
        node = xmlNode.SelectSingleNode("title");
        if (node != null)
        {
            Title = node.InnerText;
        }
    }
}