using EmployeeProjects.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EmployeeProjects.DAO
{
    public class ProjectSqlDao : IProjectDao
    {
        private readonly string connectionString;

        public ProjectSqlDao(string connString)
        {
            connectionString = connString;
        }

        public Project GetProject(int projectId)
        {
            Project project = null;

            using (SqlConnection linkUp = new SqlConnection(connectionString))
            {
                linkUp.Open();

                SqlCommand cmd = new SqlCommand("SELECT project_id, name, from_date, to_date FROM project WHERE project_id = @project_id", linkUp);
                cmd.Parameters.AddWithValue("@project_id", projectId);

                SqlDataReader readerRabbit = cmd.ExecuteReader();

                if (readerRabbit.Read())
                {
                    project = CreateProjectFromReader(readerRabbit);
                }
            }

            return project;
        }

        public IList<Project> GetAllProjects()
        {
            List<Project> projList = new List<Project>();

            using (SqlConnection linkUp = new SqlConnection(connectionString))
            {
                linkUp.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM project", linkUp);

                SqlDataReader readerRabbit = cmd.ExecuteReader();
                
                while (readerRabbit.Read())
                {
                    Project project = CreateProjectFromReader(readerRabbit);
                    projList.Add(project);
                }
            }

            return projList;
        }

        public Project CreateProject(Project newProject)
        {
            int projId;
            using (SqlConnection linkUp = new SqlConnection(connectionString))
            {
                linkUp.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO project (project_id, name, from_date, to_date) " + "OUTPUT INSERTED.project_id " + " VALUES (@project_id, @name, @from_date, @to_date);", linkUp);
                cmd.Parameters.AddWithValue("@project_id", newProject.ProjectId);
                cmd.Parameters.AddWithValue("@name", newProject.Name);
                cmd.Parameters.AddWithValue("@from_date", newProject.FromDate);
                cmd.Parameters.AddWithValue("@to_date", newProject.ToDate);

                projId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return GetProject(projId);

        }

        public void DeleteProject(int projectId)
        {
         
            using (SqlConnection linkUp = new SqlConnection(connectionString))
            {
                linkUp.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM project WHERE project_id = @project_id", linkUp);
                cmd.Parameters.AddWithValue("@project_id", projectId);

                cmd.ExecuteNonQuery();

                
            }
            
        }

        private Project CreateProjectFromReader(SqlDataReader reader)
        {
            Project project = new Project();

            project.ProjectId = Convert.ToInt32(reader["project_id"]);
            project.Name = Convert.ToString(reader["name"]);
            project.FromDate = Convert.ToDateTime(reader["from_date"]);
            project.ToDate = Convert.ToDateTime(reader["to_date"]);

            return project;
        }

    }
}
