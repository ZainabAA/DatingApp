namespace API.Helpers
{
    public class LikesParams : paginationParams
    {
        public int UserId { get; set; }
        public string Predicate { get; set; }
    }
}