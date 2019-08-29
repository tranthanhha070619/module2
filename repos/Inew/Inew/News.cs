using System;
using System.Collections.Generic;
using System.Text;
using Inew.Models;


namespace Inew
{
    public class News : INew
    {
        private int id;
        private string title;
        private string publishDate;
        private string author;
        private string content;
        protected double averageRate;
        public int[] RateList = new int[3];
        public NewsItem[] ArrayList = new NewsItem[100];

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string PublishDate { get => publishDate; set => publishDate = value; }
        public string Author { get => author; set => author = value; }
        public string Content { get => content; set => content = value; }
        public double AverageRate { get => averageRate; }
        public void Display()
        {
            foreach(var newsItem in ArrayList)
            Console.WriteLine("+  Id: {0}\t\t" +
                "Title{1}\t\t" +
                "PublishDate{2}\t\t" +
                "Author{3}\t\t" +
                "Content {4} \t\t" +
                "AverageRate{5} ", newsItem.Id, newsItem.Title, newsItem.PublishDate, newsItem.Author, newsItem.Content, newsItem.AverageRate);
        }
        public void Calculate()
        {
            var total = 0.0;
            for (int i = 0; i < RateList.Length; i++)
            {
                total += RateList[i];
            }
            averageRate = (double)(total / RateList.Length);
        }
        public void InsertNews(int index)
        {
            Calculate();
            var newsItem = new NewsItem()
            {
                Id = id,
                Author = author,
                Content = content,
                PublishDate = publishDate,
                Title = title,
                AverageRate = averageRate
            };
            ArrayList[index] = newsItem;
        }

    }
}
    

