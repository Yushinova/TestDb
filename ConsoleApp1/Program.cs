using Microsoft.Data.Sqlite;
using System.Data;

var conectionstring = @"Data Source=gg.db;";

using var db = new SqliteConnection(conectionstring);
db.Open();
var command = new SqliteCommand()
{
    Connection = db,
    CommandText = "select * from table_persons"
};
using var result = command.ExecuteReader();
while (result.Read())
{
    Console.WriteLine(result.GetInt32("ID"));//мы можем указать наименование полей таблицы
    Console.WriteLine(result.GetString(1));
    Console.WriteLine(result.GetString(2));
    Console.WriteLine(result.GetDateTime(3).ToString("d"));
}