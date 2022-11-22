using EmployeeProjects.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EmployeeProjects.DAO
{
    public class EmployeeSqlDao : IEmployeeDao
    {
        private readonly string connectionString;

        public EmployeeSqlDao(string connString)
        {
            connectionString = connString;
        }

        public IList<Employee> GetAllEmployees()
        {
            IList<Employee> employees = new List<Employee>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string findEm = "SELECT * FROM employee";

                SqlCommand cmd = new SqlCommand(findEm, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                   Employee employee = CreateEmployeeFromReader(reader);
                    employees.Add(employee);
                }
            }

            return employees;
        }

        public IList<Employee> SearchEmployeesByName(string firstNameSearch, string lastNameSearch)
        {
            IList<Employee> employees = new List<Employee>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string myQuery = "SELECT * FROM employee WHERE first_name = @first_name AND last_name = @last_name";

                SqlCommand cmd = new SqlCommand(myQuery, conn);
                cmd.Parameters.AddWithValue("@first_name", firstNameSearch);
                cmd.Parameters.AddWithValue("@last_name", lastNameSearch);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employee employee = CreateEmployeeFromReader(reader);
                    employees.Add(employee);
                }


            }
            return employees;
        }

        public IList<Employee> GetEmployeesByProjectId(int projectId)
        {
            IList<Employee> employees = new List<Employee>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string myQuery = "SELECT first_name,last_name FROM employee JOIN project_employee ON employee.employee_id = project_employee.employee_id INNER JOIN project ON project.project_id = project_employee.project_id WHERE project.project_id = @project_id";

                SqlCommand cmd = new SqlCommand(myQuery, conn);
                cmd.Parameters.AddWithValue("@project_id", projectId);
           

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employee employee = CreateEmployeeFromReader(reader);
                    employees.Add(employee);
                }


            }
            return employees;
        }

        public void AddEmployeeToProject(int projectId, int employeeId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string myThing = "INSERT INTO project_employee (project_id, employee_id) VALUES ('@project_id', '@employee_id');";

                SqlCommand cmd = new SqlCommand(myThing, conn);
                cmd.Parameters.AddWithValue("@project_id", projectId);
                cmd.Parameters.AddWithValue("@employee_id", employeeId);

                cmd.ExecuteNonQuery();
                
            }

        }

        public void RemoveEmployeeFromProject(int projectId, int employeeId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string myThing = "DELETE FROM project_employee WHERE project_id = @project_id AND employee_id = @employee_id;";

                SqlCommand cmd = new SqlCommand(myThing, conn);
                cmd.Parameters.AddWithValue("@project_id", projectId);
                cmd.Parameters.AddWithValue("@employee_id", employeeId);

                cmd.ExecuteNonQuery();

            }

        }

        public IList<Employee> GetEmployeesWithoutProjects()
        {
            IList<Employee> employees = new List<Employee>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string myQuery = "SELECT first_name,last_name FROM employee JOIN project_employee ON employee.employee_id = project_employee.employee_id INNER JOIN project ON project.project_id = project_employee.project_id WHERE project.project_id = NULL";

                SqlCommand cmd = new SqlCommand(myQuery, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employee employee = CreateEmployeeFromReader(reader);
                    employees.Add(employee);
                }


            }
            return employees;
        }

        private Employee CreateEmployeeFromReader(SqlDataReader reader)
        {
            Employee employee = new Employee(); //new object to toss information into

            employee.EmployeeId = Convert.ToInt32(reader["employee_id"]);
            employee.DepartmentId = Convert.ToInt32(reader["department_id"]);
            employee.FirstName = Convert.ToString(reader["first_name"]);
            employee.LastName = Convert.ToString(reader["last_name"]);
            employee.BirthDate = Convert.ToDateTime(reader["birth_date"]);
            employee.HireDate = Convert.ToDateTime(reader["hire_date"]);

            return employee;
        }


    }
}
