namespace LibaryOfGames.Models
{
    public class Reviews
    {
        [key]
        public int Id { set; get; }

        public string GameName { set; get; }
        public string UserName { set; get; }
        public string review { set; get; }
        public int rating { set; get; }
    }
}
