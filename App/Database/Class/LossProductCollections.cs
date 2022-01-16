using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class LossProductCollections
    {
        private int ID;
        private string PRODUCT;
        private decimal WHEIGTH; // peso
        private string REMOVAL_removal_date;

        public int id
        {
            get { return ID; }
            set { ID = value; }
        }

        public string product
        {
            get { return PRODUCT; }
            set { PRODUCT = value; }
        }

        public decimal wheigth
        {
            get { return WHEIGTH; }
            set { WHEIGTH = value; }
        }
        
        public string removal_date
        {
            get { return REMOVAL_removal_date; }
            set { REMOVAL_removal_date = value; }
        }

        string _sql;

        public void Save() 
        {
            if (id == 0)
            {
                _sql = "INSERT INTO lossProductCollections VALUES (@product, @wheigth, @removal_date)";
            }
            else
            {
                _sql = "UPDATE lossProductCollections SET wheigth = @wheigth WHERE id = @id";
            }

            using(var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    connection.Open();
                    var command = new SqlCommand(_sql, connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@product", product);
                    command.Parameters.AddWithValue("@removal_date", removal_date);
                    command.Parameters.AddWithValue("@wheigth", wheigth);
                    command.CommandText = _sql;

                    command.ExecuteNonQuery();

                }
                catch
                {
                    throw;
                }
            }
        }
        
        public void Delete(int id)
        {            
                _sql = "DELETE FROM lossProductCollections WHERE id = @id";

            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    connection.Open();
                    var command = new SqlCommand(_sql, connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandText = _sql;

                    command.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
            }
        }

        public DataTable FindAllByDateSumWheigth(string removal_date, string product)
        {
            _sql = string.IsNullOrEmpty(product) ?
                "SELECT product, SUM(wheigth) as wheigth, removal_date FROM lossProductCollections WHERE removal_date = @removal_date GROUP BY product, removal_date ORDER BY Product ASC"
                : $"SELECT product, SUM(wheigth) as wheigth, removal_date FROM lossProductCollections WHERE product LIKE '%{product}%' AND removal_date = @removal_date GROUP BY product, removal_date ORDER BY Product ASC";
            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                var adapter = new SqlDataAdapter(_sql, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@removal_date", removal_date);
                adapter.SelectCommand.CommandText = _sql;
                var table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public DataTable FindById(int id)
        {
            _sql = "SELECT * FROM lossProductCollections WHERE id = @id";

            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                var adapter = new SqlDataAdapter(_sql, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@id", id);
                adapter.SelectCommand.CommandText = _sql;
                var table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public DataTable FindAllByDate(string removal_date, string product)
        {
            _sql = string.IsNullOrEmpty(product) ?
            "SELECT * FROM lossProductCollections WHERE removal_date = @removal_date ORDER BY Product ASC" :
            $"SELECT * FROM lossProductCollections WHERE product LIKE  '%{product}%' AND removal_date = @removal_date ORDER BY Product ASC";
            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                var adapter = new SqlDataAdapter(_sql, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@removal_date", removal_date);
                adapter.SelectCommand.CommandText = _sql;
                var table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public DataTable FindBetween(string dateInitial, string dateEnd)
        {
            _sql = "SELECT product, removal_date, SUM(wheigth) A Swheigth FROM lossProductCollections WHERE CONVERT(DATE, removal_date, 103) BETWEEN CONVERT(DATE, @dateInitial, 103) AND CONVERT(removal_date, @dateEnd, 103) GROUP BY product, removal_date ORDER BY Product ASC";
            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                var adapter = new SqlDataAdapter(_sql, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@removal_date", removal_date);
                adapter.SelectCommand.Parameters.AddWithValue("@dateInitial", dateInitial);
                adapter.SelectCommand.Parameters.AddWithValue("@dateEnd", dateEnd);
                adapter.SelectCommand.CommandText = _sql;
                var table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }  
        
        public DataTable FindAllProduct()
        {
            _sql = "SELECT DISTINCT product FROM lossProductCollections ORDER BY Product ASC";
            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                var adapter = new SqlDataAdapter(_sql, connection);
                adapter.SelectCommand.CommandText = _sql;
                var table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
    }
}
