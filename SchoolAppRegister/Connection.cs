using MySql.Data.MySqlClient;

namespace SchoolAppRegister
{
    internal class Connection
    {
        public MySqlConnection ConnectionToSQL()
        {
            string strConnection = "Server=localhost;Database=pi_school;Uid=root;Pwd=";
            MySqlConnection conn = new MySqlConnection(strConnection);
            return conn;
        }
    }
}
