namespace Solid_Principles.Models
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string GetInfo() => Name + " " + Author;
        public Book(string name, string author)
        {
            this.Name = name;
            this.Author = author;
        }
    }
}
