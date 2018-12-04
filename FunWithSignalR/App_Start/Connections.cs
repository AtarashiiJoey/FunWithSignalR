using FunWithSignalR.Models;

namespace FunWithSignalR
{
    public class Connections
    {
        public static void PutUsersOffline()
        {
            using (var db = new ZigChatContext())
            {
                foreach (var connection in db.Connections)
                    connection.IsOnline = false;

                db.SaveChanges();
            }
        }
    }
}
