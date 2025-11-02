using System;

namespace Problem_FormTemplateMethod
{
    class Program { static void Main(string[] args) { } }

    class TextStatement
    {
        public string Generate(string customerName)
        {
            string header = "Statement for " + customerName + "\n";
            string body = "Body text...\n";
            string footer = "Footer text";
            return header + body + footer;
        }
    }

    class HtmlStatement
    {
        public string Generate(string customerName)
        {
            string header = "<h1>Statement for " + customerName + "</h1>";
            string body = "<p>Body text...</p>";
            string footer = "<p>Footer text</p>";
            return header + body + footer;
        }
    }
}