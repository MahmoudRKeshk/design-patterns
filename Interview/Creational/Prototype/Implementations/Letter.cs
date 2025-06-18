using Interview.Creational.Prototype.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Creational.Prototype.Implementations
{
    public class Letter : IDocumentPrototype
    {
        public string Recipient { get; set; }
        public string Body { get; set; }
        public IDocumentPrototype Clone()
        {
            return new Letter(this);
        }
        public Letter(string recipient, string body)
        {
            Recipient = recipient;
            Body = body;
        }
        public Letter(Letter letter)
        {
            this.Recipient = letter.Recipient;
            this.Body = letter.Body;
        }

        public override string ToString()
        {
            return $"Letter to: {Recipient}\nBody: {Body}";
        }
    }
}
