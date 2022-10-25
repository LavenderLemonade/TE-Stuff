using EmployeeProjects.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EmployeeProjects.DAO
{
    public class DepartmentSqlDao : IDepartmentDao
    {
        private readonly string connectionString;

        public DepartmentSqlDao(string connString)
        {
            connectionString = connString;
        }

        public Department GetDepartment(int departmentId)
        {
            Department dept = null;

            using (SqlConnection linkUp =  new SqlConnection(connectionString)) //this is where we start the connection
            {
                linkUp.Open(); //this is where we open the connection, where the data is gonna be store

                SqlCommand cmd = new SqlCommand("SELECT department_id, name FROM department WHERE department_id = @department_id", linkUp);
                cmd.Parameters.AddWithValue("@department_id", departmentId);

                SqlDataReader readerRabbit = cmd.ExecuteReader(); //it slams SQL with the query we just made 

                if (readerRabbit.Read())
                {
                    dept = CreateDepartmentFromReader(readerRabbit);
                }
            }

            return dept;

        }

        public IList<Department> GetAllDepartments()
        {
            IList<Department> departments = new List<Department>();

            using (SqlConnection linkUp = new SqlConnection(connectionString))
            {
                linkUp.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM department", linkUp);

                SqlDataReader readerRabbit = cmd.ExecuteReader();

                while (readerRabbit.Read())
                {
                    Department dept = CreateDepartmentFromReader(readerRabbit);
                    departments.Add(dept);
                }
            }

            return departments;

        }

        public void UpdateDepartment(Department updatedDepartment)
        {
            using (SqlConnection linkUp = new SqlConnection(connectionString))
            {
                linkUp.Open();

                SqlCommand cmd = new SqlCommand("UPDATE department SET name = @name WHERE department_id = @department_id", linkUp);
                cmd.Parameters.AddWithValue("@name", updatedDepartment.Name);
                cmd.Parameters.AddWithValue("@department_id", updatedDepartment.DepartmentId);

                cmd.ExecuteNonQuery();
            }
        }

        private Department CreateDepartmentFromReader(SqlDataReader reader)
        {
            Department dept = new Department(); //new object

            dept.DepartmentId = Convert.ToInt32(reader["department_id"]);
            dept.Name = Convert.ToString(reader["name"]);

            return dept;
        }


    }
}
