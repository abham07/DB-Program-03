//-----------------------------------------------------------------------
// <copyright file="QueryClass.cs" company="LakeheadU">
//     Copyright ENGI-3675. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Assign_3
{
    using System.Collections.Generic;
    using System.Data;
    using Npgsql;

    /// <summary>
    /// A class library consisting of various functions which execute SQL queries and return certain values
    /// </summary>
    public class QueryClass
    {
        /// <summary>
        /// A function which establishes a connection to the database and executes SELECT query
        /// on the default 'randData' table
        /// </summary>
        /// <returns>Returns result from executed SQL query</returns>
        public static List<string> CountRows()
        {
            // Connection string to database
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Database=Assignment_3; IntegratedSecurity=true;");
            //// A list to store data retreived from executed query
            List<string> retData = new List<string>();

            // Open connection to database
            conn.Open();

            // Execute SQL query specified
            NpgsqlCommand cmd = new NpgsqlCommand("select * from randData", conn);
            //// Initiate reader to read results  
            IDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //// Add read results into list
                retData.Add(string.Format("{0}", reader[0]));
            }

            // Return read results            
            return retData;
        }

        /// <summary>
        /// A function which establishes a connection to the database and executes SELECT query
        /// on the indexed 'randData_Indexed' table
        /// </summary>
        /// <returns>Returns result from executed SQL query</returns>
        public static List<string> CountRows_Indexed()
        {
            // Connection string to database
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Database=Assignment_3; IntegratedSecurity=true;");
            //// A list to store data retreived from executed query
            List<string> retData = new List<string>();

            // Open connection to database
            conn.Open();

            // Execute SQL query specified
            NpgsqlCommand cmd = new NpgsqlCommand("select * from randData_indexed", conn);
            //// Initiate reader to read results
            IDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //// Add read results into list
                retData.Add(string.Format("{0}", reader[0]));
            }

            // Return read results
            return retData;
        }

        /// <summary>
        /// A function which establishes a connection to the database and executes SELECT-WHERE query
        /// on the default 'randData' table
        /// </summary>
        /// <returns>Returns result from executed SQL query</returns>
        public static List<string> CountSelectRows()
        {
            // Connection string to database
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Database=Assignment_3; IntegratedSecurity=true;");
            //// A list to store data retreived from executed query
            List<string> retData = new List<string>();

            // Open connection to database
            conn.Open();

            // Execute SQL query specified
            NpgsqlCommand cmd = new NpgsqlCommand("select * from randData where language='en'", conn);
            //// Initiate reader to read results  
            IDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //// Add read results into list
                retData.Add(string.Format("{0}", reader[0]));
            }

            // Return read results            
            return retData;
        }

        /// <summary>
        /// A function which establishes a connection to the database and executes SELECT-WHERE query
        /// on the indexed 'randData_Indexed' table
        /// </summary>
        /// <returns>Returns result from executed SQL query</returns>
        public static List<string> CountSelectRows_Indexed()
        {
            // Connection string to database
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Database=Assignment_3; IntegratedSecurity=true;");
            //// A list to store data retreived from executed query
            List<string> retData = new List<string>();

            // Open connection to database
            conn.Open();

            // Execute SQL query specified
            NpgsqlCommand cmd = new NpgsqlCommand("select * from randData_indexed where language='en'", conn);
            //// Initiate reader to read results
            IDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //// Add read results into list
                retData.Add(string.Format("{0}", reader[0]));
            }

            // Return read results
            return retData;
        }

        /// <summary>
        /// Query Plan for Normal table
        /// </summary>
        /// <returns>Return Query Plan for Normal</returns>
        public static List<string> QueryPlan()
        {
            // Connection string to database
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Database=Assignment_3; IntegratedSecurity=true;");
            //// A list to store data retreived from executed query
            List<string> retData = new List<string>();

            // Open connection to database
            conn.Open();

            // Execute SQL query specified
            NpgsqlCommand cmd = new NpgsqlCommand("explain analyze select * from randData where language='en';", conn);
            //// Initiate reader to read results
            IDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //// Add read results into list
                for (int i = 0; i < 10; i++)
                {
                    retData.Add(string.Format("{0}", reader[i]));
                }
            }

            // Return read results
            return retData;
        }

        /// <summary>
        /// Indexed Query Plan
        /// </summary>
        /// <returns>Return Query Plan for Indexed</returns>
        public static List<string> QueryPlan_Indexed()
        {
            // Connection string to database
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Database=Assignment_3; IntegratedSecurity=true;");
            //// A list to store data retreived from executed query
            List<string> retData = new List<string>();

            // Open connection to database
            conn.Open();

            // Execute SQL query specified
            NpgsqlCommand cmd = new NpgsqlCommand("explain analyze select * from randData_Indexed where language='en';", conn);
            //// Initiate reader to read results
            IDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //// Add read results into list
                for (int i = 0; i < 10; i++)
                {
                    retData.Add(string.Format("{0}", reader[i]));
                }
            }

            // Return read results
            return retData;
        }
    }
}
