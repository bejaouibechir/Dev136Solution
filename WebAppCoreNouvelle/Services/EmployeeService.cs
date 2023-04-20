using System.Data.SqlClient;
using System.Diagnostics;

namespace WebAppCoreNouvelle.Services
{
    public class EmployeeService : IEmployeeService
    {
        string _connectionstring;
        SqlConnection _connection;
        SqlDataReader _reader;
        SqlCommand _command;
        List<Employee> _employees;

        public EmployeeService()
        {
            _connectionstring = "Data Source=PC2023\\PC2023;Initial Catalog=TSQL;Integrated Security=True";
            _connection = new SqlConnection(_connectionstring);
        }

        public List<Employee> ProcessData()
        {
            try
            {
                _employees = new List<Employee>();
                _command = new SqlCommand("SELECT [empid],[lastname],[firstname]" +
                    " ,[title] FROM [HR].[Employees]", _connection);
                _connection.Open();
                _reader = _command.ExecuteReader();
                Employee temp;
                while (_reader.Read())
                {
                    temp = new Employee
                    {
                        Id = int.Parse(_reader[0].ToString()),
                        LastName = _reader[1].ToString(),
                        FirstName = _reader[2].ToString(),
                        Title = _reader[3].ToString()
                    };
                    _employees.Add(temp);
                }

                return _employees;
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                _command.Dispose();
                _reader.Dispose();
                _connection.Close();
            }

        }


    }
    public class Employee
    {
        public int Id { get; set; }

#pragma warning disable 8618
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
    }
}
