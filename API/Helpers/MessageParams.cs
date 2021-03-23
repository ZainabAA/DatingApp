namespace API.Helpers
{
    public class MessageParams : paginationParams
    {
        public string Username { get; set; }
        public string Container { get; set; } = "Unread";
    }
}