using Microsoft.EntityFrameworkCore;

namespace orderSorter.DatabaseMySQL
{
    public class MySqlCustomerRepository : MySqlConnection
    {

        void openConnection();

        void closeConnection();

    }
}