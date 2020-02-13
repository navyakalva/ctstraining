using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HandsOnADOExample
{
    class Program
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IOAS59H\SQLEXPRESS;
   Initial Catalog=PracticeDB;Persist Security Info=True;User ID=SA;Password=pass@word1");
        SqlCommand cmd = null;
        public void Add(int id,string name,int price,int stock)
        {
            try
            {
                cmd = new SqlCommand("Insert into product values(@id,@name,@price,@stock)", con);
                //passing values to parameters
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@stock", stock);
                con.Open();//open connection
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();//close connection
            }
        }
        public void GetProdById(string id)
        {
            try
            {
                cmd = new SqlCommand("select * from product where id=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)//ckecks rows existence
                {
                    dr.Read();//read only 1 record
                    Console.WriteLine("ID:{0} Name:{1} Price:{2} Stock:{3}",
                        dr["id"], dr["name"], dr["price"], dr["stock"]);
                }
                else
                    Console.WriteLine("Invalid project id");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void GetAllProducts()
        {
            try
            {
                cmd = new SqlCommand("select * from product ", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)//ckecks rows existence
                {
                    while (dr.Read())
                    {
                        Console.WriteLine("ID:{0} Name:{1} Price:{2} Stock:{3}",
                           dr["id"], dr["name"], dr["price"], dr["stock"]);
                    }
                    dr.Read();//read only 1 record

                }
                else
                    Console.WriteLine("table empty");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void delete(int id)
        {
            try
            {
                cmd = new SqlCommand("delete from product where id=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("row has deleted");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void update(int id,int price,int stock)
        {
            try
            {
                cmd = new SqlCommand("update product set price=@price,stock=@stock where id=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@stock", stock);
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("row has updated");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        

        static void Main(string[] args)
        {
            Program obj = new Program();
            // obj.Add(30,"accessories",23000,230);
            // obj.GetProdById("20");
            // obj.GetAllProducts();
            // obj.delete(20);
            obj.update(30, 10000, 100);
           
            Console.ReadKey();

        }
    }
}
