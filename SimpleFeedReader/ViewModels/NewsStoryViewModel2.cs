using System;

namespace SimpleFeedReader.ViewModels
{
    // <SnippetStarterViewModel>
//#nullable enable
    public class NewsStoryViewModel2
    {
        public NewsStoryViewModel2(DateTimeOffset published, string title, string uri) =>
            (Published, Title, Uri) = (published, title, uri);

        public DateTimeOffset Published { get; set; }
        public string Title { get; set; }
        public string Uri { get; set; }
    }
//#nullable restore
    // </SnippetStarterViewModel>
}
