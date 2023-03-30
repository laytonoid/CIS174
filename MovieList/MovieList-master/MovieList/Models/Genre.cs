namespace MovieList.Models
{
    public class Genre
    {
        public string GenreId { get; set; }
        public string Name { get; set; }
    }
    public class ToDo
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; } 
    }

}