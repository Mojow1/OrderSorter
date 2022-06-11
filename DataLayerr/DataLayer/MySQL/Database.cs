using System.Windows.Markup;
using MySql.Data.MySqlClient;
using orderSorter;
using orderSorter.Businesslogic.Interfaces;

namespace DataLayerr.DataLayer.MySQL;

// Constructor
public class Database
{
    
    // https://www.visual-paradigm.com/tutorials/how-to-model-relational-database-with-erd.jsp
    // https://circle.visual-paradigm.com/simple-order-system/
    // https://www.codeproject.com/Articles/43438/Connect-C-to-MySQL
    private MySqlConnection _connection;
    private string _server;
    private string _database;
    private string _uid;
    private string _password;

    public Database()
    {
        
        Initialize();
       
    }
    
    // Initialize connection
    public void Initialize()
    {
        _server = "localhost";
        _database = "ordersorter";
        _uid = "root";
        _password = "Leren-2021";
        string connectionString;

        connectionString = "SERVER=" + _server + ";" + "DATABASE=" +  _database + ";" + "UID=" + _uid + ";" 
                           + "PASSWORD=" + _password + ";";

        _connection = new MySqlConnection(connectionString);
    }

 
    
    
    // Open Connection
    public bool OpenConnection()
    {
        try
        {
            _connection.Open();
            return true;

        }
        catch (MySqlException e)
        {
            switch (e.Number)
            {
                case 0:
                   // MessageBox.Show("Cannot connect to server.  Contact administrator");
               
                    break;
                
                case 1045:
                    //MessageBox.Show();
                    break;
            }

            return false;
            

        }
        
    }
    
    
    // Close Connection
    private bool CloseConnection()
    {
        try
        {
            _connection.Close();
            return true;

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    
    
    // Add Order
    public void AddOrder(IOrder order)
    {
        try
        {
      
            if (OpenConnection() )
            {
                    
                string query = $"INSERT INTO orders2 (id, orderdate, allowedendtime, priority,  orderweight) VALUES(\"{order.Id}\", \"{order.OrderDate.ToString("yyyy-MM-dd HH:mm:ss")}\", \"{order.AllowedEndTime.ToString("yyyy-MM-dd HH:mm:ss")}\", \"{Convert.ToInt32(order.Priority)}\",  \"{order.OrderWeight}\")";

                MySqlCommand cmd = new MySqlCommand(query, _connection);

                // Execute command
                cmd.ExecuteNonQuery();
                
                //close connection
                CloseConnection();
            }
        }
        catch (MySqlException e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    
    
     // Fetch order using the order id
    public IOrder FetchOrder(int id)
    {
        try
        {
            if (OpenConnection())
            {
                string query = "SELECT FROM orders2 WHERE id=@i;";
                
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    
                    DateTime orderDate = reader.GetDateTime("orderdate");
                    DateTime allowedEndTime = reader.GetDateTime("allowedendtime");
                    int priority = reader.GetInt32("priority");
                    bool orderAccepted = reader.GetBoolean("orderAccepted");
                    int orderWeight = reader.GetInt32("orderweight");
                    List<IProduct> products = new List<IProduct>(); // nog fixen ophalen lijst producten

                    IOrder order = new Order(id, orderDate, allowedEndTime, Convert.ToBoolean(priority), orderAccepted, orderWeight, products);
                    return order;

                }
                reader.Close();
            }
            
            
        }
        catch (MySqlException e)
        {
            Console.WriteLine(e);
            throw;
        }
        CloseConnection();
        return null;
    }
    
    
    
    
    // Fetch all orders
    public List<IOrder> FetchAllOrders()
    {
        try
        {
            //List<IProduct> products = new List<IProduct>();

            List<IOrder> orders = new List<IOrder>();

            if (OpenConnection())
            {
     
                string query = "SELECT * FROM 'ordersorter'.'orders2'";
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    DateTime orderDate = reader.GetDateTime("orderdate");
                    DateTime allowedEndTime = reader.GetDateTime("allowedendtime");
                    int priority = reader.GetInt32("priority");
                    int orderWeight = reader.GetInt32("orderweight");
                    List<IProduct> products = new List<IProduct>(); // nog fixen ophalen lijst producten

                    IOrder order = new Order(id, orderDate, allowedEndTime, Convert.ToBoolean(priority),  orderWeight);
             
                    orders.Add(order);
        
                }
                // Close Data Reader
                reader.Close();
                
                // Close Connection
                CloseConnection();
                
                // return orders
                return orders;
            }

            else
            {
                return orders;
            }
            
        }
        catch (MySqlException e)
        {
            Console.WriteLine(e);
            throw;
        }

    }


    
    
}