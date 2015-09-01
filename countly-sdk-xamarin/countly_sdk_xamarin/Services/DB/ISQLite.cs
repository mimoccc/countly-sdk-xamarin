using SQLite;

namespace SmashIt
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}