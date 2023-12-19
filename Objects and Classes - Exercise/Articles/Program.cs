using System;
using System.Collections.Generic;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(", ");
            Article article = new Article(data[0], data[1], data[2]);
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] newData = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);
                if (newData[0] == "Edit")
                {
                    article.Edit(newData[1]);
                }
                else if (newData[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(newData[1]);
                }
                else if (newData[0] == "Rename")
                {
                    article.Rename(newData[1]);
                }
            }
            Console.WriteLine(string.Join(' ', article));
        }
    }
    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public void Edit(string content) => this.Content = content;
        public void ChangeAuthor(string author) => this.Author = author;
        public void Rename(string title) => this.Title = title;
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
