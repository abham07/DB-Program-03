//-----------------------------------------------------------------------
// <copyright file="UnitTest.cs" company="LakeheadU">
//     Copyright ENGI-3675. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Assign_3_Test
{
    using System;
    using System.Data;
    using Assign_3;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    
    /// <summary>
    /// A test class for Unit Test #1 which calls functions of the class library
    /// </summary>
    [TestClass]
    public class UnitTest
    {
        /// <summary>
        /// Unit test which calls two functions of class library and compares their row count values.
        /// It then prints both the row count as well as the execution time.
        /// </summary>
        [TestMethod]
        public void CountRowsTest()
        {
            DateTime timeBefore = DateTime.Now;
            
            // Storing row count for both tables into integer variables
            int i = QueryClass.CountRows().Count;
            int j = QueryClass.CountRows_Indexed().Count;

            DateTime timeAfter = DateTime.Now;
            TimeSpan execTime = timeAfter.Subtract(timeBefore);
            
            // Assert commands confirm unit test functionality
            Assert.IsTrue(i > 0);
            Assert.IsTrue(j > 0);
            Assert.AreEqual(i, j);

            // Converting integer to string values to print row count and execution time
            string myString = i.ToString();
            System.Diagnostics.Debug.Write("Execution of 1st Unit Test:\n");
            System.Diagnostics.Debug.Write("Row Count: " + i);
            System.Diagnostics.Debug.Write("\nExecution Time: " + execTime);
        }

        /// <summary>
        /// Unit test which calls two functions of class library and compares their row count values.
        /// It then prints both the row count as well as the execution time.
        /// </summary>
        [TestMethod]
        public void CountSelectRowsTest()
        {
            DateTime timeBefore = DateTime.Now;

            // Storing row count for both tables into integer variables
            int i = QueryClass.CountSelectRows().Count;
            int j = QueryClass.CountSelectRows_Indexed().Count;

            DateTime timeAfter = DateTime.Now;
            TimeSpan execTime = timeAfter.Subtract(timeBefore);

            // Assert commands confirm unit test functionality
            Assert.IsTrue(i > 0);
            Assert.IsTrue(j > 0);
            Assert.AreEqual(i, j);

            // Converting integer to string values to print row count and execution time
            string myString = i.ToString();
            System.Diagnostics.Debug.Write("Execution of 2nd Unit Test:\n");
            System.Diagnostics.Debug.Write("Row Count: " + i);
            System.Diagnostics.Debug.Write("\nExecution Time: " + execTime);
        }

        /// <summary>
        /// Unit test which calls two functions of class library and compares their execution times.
        /// It then prints the execution times for both queries.
        /// </summary>
        [TestMethod]
        public void CompareExecTimes()
        {
            // Saving current time normal table
            DateTime timeBeforeNormal = DateTime.Now;
            //// Executing SQL query
            int i = QueryClass.CountSelectRows().Count;
            //// Saving post-execution time for normal table
            DateTime timeAfterNormal = DateTime.Now;

            // Repeating above step for Indexed table
            DateTime timeBeforeIndexed = DateTime.Now;
            int j = QueryClass.CountSelectRows_Indexed().Count;
            DateTime timeAfterIndexed = DateTime.Now;
            
            // Calculating timespan for both Normal and Indexed tables
            TimeSpan execTimeNormal = timeAfterNormal.Subtract(timeBeforeNormal);
            TimeSpan execTimeIndexed = timeAfterIndexed.Subtract(timeBeforeIndexed);

            // Printing execution times to test explorer output
            System.Diagnostics.Debug.Write("Execution of 3rd Unit Test:\n");
            System.Diagnostics.Debug.Write("\nExecution Time for Normal Table: " + execTimeNormal);
            System.Diagnostics.Debug.Write("\nExecution Time for Indexed Table: " + execTimeIndexed);
        }

        /// <summary>
        /// Unit test which prints the Query Plan for both tables
        /// </summary>
        [TestMethod]
        public void QueryPlanTest()
        {
            System.Diagnostics.Debug.Write("Query Plan for Normal Table: \n" + QueryClass.QueryPlan());
            System.Diagnostics.Debug.Write("Query Plan for Normal Table: \n" + QueryClass.QueryPlan_Indexed());
        }
    }
}
