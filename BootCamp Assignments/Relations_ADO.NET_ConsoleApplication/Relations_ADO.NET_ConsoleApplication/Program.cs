using System.Data.SqlClient;

namespace Relations_ADO.NET_ConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ConnectionString = "Data Source=DESKTOP-6T7I45E\\SQLEXPRESS; Initial Catalog=Relations;Integrated Security=True";
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT s.std_Id, s.Name, r.Marks, a.Address FROM Tbl_Student s inner join Tbl_Result r on (s.std_Id = r.student_Id) inner join Tbl_Address a on (s.std_Id = a.student_Id)";
                    SqlCommand cmd = new SqlCommand(query,conn);
                    conn.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        Console.WriteLine("Id= " + sdr["std_Id"] + "\n" + "Name= " + sdr["Name"]
                            + "\n" + "Marks= " + sdr["Marks"] + "\n" + "Address= " + sdr["Address"]+"\n\n");
                    }
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}