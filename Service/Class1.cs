namespace Service
{
    using System.Data.SQLite;



    public class Class1
    {
        using (var connection = new SQLiteConnection("C:\\mydatabase.db"))
{
    // Tạo database (nếu chưa tồn tại)
    connection.CreateIfNotExists();

    // Tạo table (nếu chưa tồn tại)
    string sql = "CREATE TABLE MyTable (Id INTEGER PRIMARY KEY, Name TEXT, Price REAL)";
    using (var command = new SQLiteCommand(sql, connection))
    {
        command.ExecuteNonQuery();
    }
}
    }
}