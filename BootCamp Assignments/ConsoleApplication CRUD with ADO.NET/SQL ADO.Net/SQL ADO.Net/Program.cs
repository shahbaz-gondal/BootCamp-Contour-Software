using System.Data.SqlClient;
using System.Net.Http.Headers;

namespace SQL_ADO.Net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 'a' to add Date\nEnter 'u' to Update Data\nEnter 's' to Show All Data\nEnter 'd' to delete Data\nEnter 'e' to Exit");
            char c = Convert.ToChar(Console.ReadLine());
            CrudOperations op = new CrudOperations();
            while(c != 'e')
            {
                switch (c)
                {
                    case 'a':
                        op.Insert();
                        break;
                    case 'u':
                        op.Update();
                        break;
                    case 's':
                        op.GetAll();
                        break;
                    case 'd':
                        op.Delete();
                        break;
                }
                Console.WriteLine("\nEnter 'a' to add Date\nEnter 'u' to Update Data\nEnter 's' to Show All Data\nEnter 'd' to delete Data\nEnter 'e' to Exit");
                c = Convert.ToChar(Console.ReadLine());
            }
        }
    }
    public class CrudOperations
    {
        string cs = "Data Source=DESKTOP-6T7I45E\\SQLEXPRESS; Initial Catalog=RestaurantDb;Integrated Security=True";
        public void Insert()
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(cs))
                {

                    Console.WriteLine("Enter Name:");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Enter Email:");
                    string Email = Console.ReadLine();
                    Console.WriteLine("Enter Phone:");
                    string Phone = Console.ReadLine();
                    Console.WriteLine("Enter Menu:");
                    string Menu = Console.ReadLine();
                    Console.WriteLine("Enter BookingDate:");
                    string BookingDate = Console.ReadLine();
                    Console.WriteLine("Enter Dishes:");
                    string Dishes = Console.ReadLine();
                    Console.WriteLine("Enter Description:");
                    string Description = Console.ReadLine();
                    Console.WriteLine("Enter Total Price:");
                    string Price = Console.ReadLine();
                    string query = "insert into TablBookings values (@Name,@Email,@Phone,@Menu,@BookingDate,@Description,@Dishes,@Price)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Phone", Phone);
                    cmd.Parameters.AddWithValue("@Menu", Menu);
                    cmd.Parameters.AddWithValue("@BookingDate", BookingDate);
                    cmd.Parameters.AddWithValue("@Dishes", Dishes);
                    cmd.Parameters.AddWithValue("@Description", Description);
                    cmd.Parameters.AddWithValue("@Price", Price);
                    conn.Open();
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        Console.WriteLine("Data Inserted Successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Insertion Failed.");
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public void Delete()
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(cs))
                {
                    Console.WriteLine("Enter Id you want to Delete:");
                    int Id = Convert.ToInt32(Console.ReadLine());
                    string query = "delete from TablBookings where Id = @Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", Id);
                    conn.Open();
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        Console.WriteLine("Data Deleted Successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Data Deletion Failed.");
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public void Update()
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(cs))
                {
                    Console.WriteLine("Enter Id:");
                    int Id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Name:");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Enter Email:");
                    string Email = Console.ReadLine();
                    Console.WriteLine("Enter Phone:");
                    string Phone = Console.ReadLine();
                    Console.WriteLine("Enter Menu:");
                    string Menu = Console.ReadLine();
                    Console.WriteLine("Enter BookingDate:");
                    string BookingDate = Console.ReadLine();
                    Console.WriteLine("Enter Dishes:");
                    string Dishes = Console.ReadLine();
                    Console.WriteLine("Enter Description:");
                    string Description = Console.ReadLine();
                    Console.WriteLine("Enter Total Price:");
                    string Price = Console.ReadLine();
                    string query = "update TablBookings set Name = @Name,Email = @Email,Phone = @Phone,Menu = @Menu,BookingDate = @BookingDate,Description = @Description,Dishes = @Dishes,Price = @Price where Id = @Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Phone", Phone);
                    cmd.Parameters.AddWithValue("@Menu", Menu);
                    cmd.Parameters.AddWithValue("@BookingDate", BookingDate);
                    cmd.Parameters.AddWithValue("@Dishes", Dishes);
                    cmd.Parameters.AddWithValue("@Description", Description);
                    cmd.Parameters.AddWithValue("@Price", Price);
                    conn.Open();
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        Console.WriteLine("Data Updated Successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Updation Failed.");
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public void GetAll()
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(cs))
                {
                    string query = "select * from TablBookings";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        Console.WriteLine("Id= "+sdr["Id"]+"\n"+ "Name= " + sdr["Name"] + "\n"
                            + "Email= " + sdr["Email"] + "\n" + "Phone= " + sdr["Phone"] + "\n"
                            + "Menu= " + sdr["Menu"] + "\n" + "BookingDate= " + sdr["BookingDate"] + "\n"
                            + "Dishes= " + sdr["dishes"] + "\n" + "Description= " + sdr["Description"] + "\n"
                            + "Price= " + sdr["Price"]);
                    }
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}