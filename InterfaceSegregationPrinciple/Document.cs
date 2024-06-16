using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregationPrinciple
{
    public class Document
    {
        public string Content { get; }

        public Document(string content)
        {
            Content = content;
        }
    }
}