namespace GamingShop.Models
{
    public class Game
    {
        private int _id;
        private string? _gameName;
        private string? _genre;
        private decimal _price;
        public int Id { get => _id; set => _id = value; }
        public string? GameName { get => _gameName; set => _gameName = value; }
        public string? Genre { get => _genre; set => _genre = value; }
        public decimal Price { get => _price; set => _price = value; }
        public Game(int id, string? gameName, string? genre, decimal price)
        {
            Id = id;
            GameName = gameName;
            Genre = genre;
            Price = price;
        }
    }
}
