using System.ComponentModel.DataAnnotations;

namespace EF_Library
{
    class Book
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Topic { get; set; }

        public Book() { }
        public Book(string title, string author, string topic)
        {
            Title = title;
            Author = author;
            Topic = topic;
        }
    }
}
