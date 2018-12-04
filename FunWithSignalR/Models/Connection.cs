namespace FunWithSignalR.Models
{
    public class Connection
    {
        public int Id { get; set; }
        public string ConnectionId { get; set; }
        public string UserName { get; set; }
        public bool IsOnline { get; set; }
    }
}
