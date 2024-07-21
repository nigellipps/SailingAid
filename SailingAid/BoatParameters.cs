using System;
using System.Xml;

namespace BoatParameters
{
    static class BoatParameters
    {
        static void LoadBoatParameters()
        {
            string filePath = "BoatParameters.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            XmlNodeList bookNodes = doc.SelectNodes("/books/book");

            foreach (XmlNode bookNode in bookNodes)
            {
                string id = bookNode.Attributes["id"].Value;
                string genre = bookNode.Attributes["genre"].Value;
                string title = bookNode["title"].InnerText;
                string author = bookNode["author"].InnerText;

                Console.WriteLine($"Book ID: {id}");
                Console.WriteLine($"Genre: {genre}");
                Console.WriteLine($"Title: {title}");
                Console.WriteLine($"Author: {author}");
                Console.WriteLine();
            }
        }
    }
}
