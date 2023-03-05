using System.Collections.Generic;
using DeviceDetectorNET.Class.Client;
using DeviceDetectorNET.Results.Client;

namespace DeviceDetectorNET.Parser.Client
{
    public class FeedReaderParser : AbstractClientParser<List<FeedReader>>
    {
        public FeedReaderParser()
        {
            FixtureFile = "regexes/client/feed_readers.yml";
            ParserName = "feed reader";
            regexList = GetRegexes();
        }
    }
}