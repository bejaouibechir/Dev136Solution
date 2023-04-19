using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Routing;

namespace WebAppCRUD.Handlers
{
    public class SimpleHandler : IHttpHandler
    {

        public RequestContext Context { get; set; }

        string _connstring; 
        SqlConnection _connection;
        SqlCommand _command; 
        SqlDataReader _reader;
        List<Employee> _employees;

        public SimpleHandler(RequestContext context)
        {
            Context = context;
            _connstring = ConfigurationManager
                .ConnectionStrings["defaultconnection"].ConnectionString;
            _connection = new SqlConnection (_connstring);
        }



        public bool IsReusable => true;

        public void ProcessRequest(HttpContext context)
        {
            
            _command = new SqlCommand("select [empid],[lastname],[firstname]," +
                "[title] from [HR].[Employees]", _connection);
            _connection.Open();
            _reader = _command.ExecuteReader();
            _employees = new List<Employee>();
            Employee employee;
            while (_reader.Read())
            {
                employee = new Employee
                {
                    Id = int.Parse(_reader[0].ToString()),
                    FirstName = _reader[1].ToString(),
                    LastName = _reader[2].ToString(),
                    Title = _reader[3].ToString(),
                };
                _employees.Add(employee);
            }


            HttpResponse response = context.Response;

            string tableheader = @"<table class=""table"">
                                      <thead>
                                        <tr>
                                          <th scope=""col"">Id</th>
                                          <th scope=""col"">First name</th>
                                          <th scope=""col"">Last name</th>
                                          <th scope=""col"">Title</th>
                                        </tr><tbody>";

            string tablefooter = @" </tbody></table>";

            StringBuilder tablebody = new StringBuilder();
            
            foreach (var item in _employees)
            {
                tablebody.Append($@"<tr>
                                      <th scope=""row"">{item.Id}</th>
                                      <td>{item.FirstName}</td>
                                      <td>{item.LastName}</</td>
                                      <td>{item.Title}</td>
                                    </tr>");
            }

            string content = tableheader 
                + "\n" + tablebody.ToString()
                + "\n" + tablefooter; 

            response.Write(tableheader);
            response.Write(tablebody.ToString());
            response.Write(tablefooter);
        }
    }
}