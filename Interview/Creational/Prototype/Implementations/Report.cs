using Interview.Creational.Prototype.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Creational.Prototype.Implementations
{
    public class Report : IDocumentPrototype
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Report(string title, string content)
        {
            Title = title;
            Content = content;
        }
        public Report(Report report)
        {
            this.Title = report.Title;
            this.Content = report.Content;
        }
        public IDocumentPrototype Clone()
        {
            return new Report(this);
        }

        public override string ToString()
        {
            return $"Report Title: {Title}\nContent: {Content}";
        }
    }
}
