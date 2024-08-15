namespace GamingShop.Models
{
    public class GamesCatalog
    {
        private List<Game> _games;
        public GamesCatalog()
        {
            _games = new List<Game>();
        }
        public void addGame(int gameId, string gameName, string gameGenre, decimal gamePrice)
        {
            Game newGame = new Game(gameId, gameName, gameGenre, gamePrice);
            _games.Add(newGame);
        }
        public void removeGame(int gameId)
        {
            var gameToRemove = _games.Where(game => game.Id == gameId).ToArray();
            foreach (var game in gameToRemove)
            {
                _games.Remove(game);
            }
        }
        public void modifyGame(int gameId, string gameName, string gameGenre, decimal gamePrice)
        {
            var gameToModify = _games.FirstOrDefault(game => game.Id == gameId);

            if (gameToModify != null)
            {
                gameToModify.GameName = gameName;
                gameToModify.Genre = gameGenre;
                gameToModify.Price = gamePrice;
            }
        }
        public List<Game> getAllGames()
        {
            return _games;
        }
    }
}
