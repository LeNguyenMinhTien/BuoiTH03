using System;

namespace Solution_FormTemplateMethod
{
    class Program { static void Main(string[] args) { } }

    abstract class Statement
    {
        public string Generate(string customerName)
        {
            string header = Header(customerName);
            string body = Body();
            string footer = Footer();
            return header + body + footer;
        }

        protected abstract string Header(string customerName);
        protected abstract string Body();
        protected abstract string Footer();
    }

    class TextStatement : Statement
    {
        protected override string Header(string c) { return "Statement for " + c + "\n"; }
        protected override string Body() { return "Body text...\n"; }
        protected override string Footer() { return "Footer text"; }
    }

    class HtmlStatement : Statement
    {
        protected override string Header(string c) { return "<h1>Statement for " + c + "</h1>"; }
        protected override string Body() { return "<p>Body text...</p>"; }
        protected override string Footer() { return "<p>Footer text</p>"; }
    }
}