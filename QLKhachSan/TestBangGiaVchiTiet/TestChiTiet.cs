using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestBangGiaVchiTiet
{
    [TestClass()]
    public class TestChiTiet : SqlDatabaseTestClass
    {

        public TestChiTiet()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_testChiTietTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestChiTiet));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountChiTiet;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumChiTiet;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueChiTiet;
            this.dbo_testChiTietTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_testChiTietTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountChiTiet = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            checksumChiTiet = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            scalarValueChiTiet = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            // 
            // dbo_testChiTietTest_TestAction
            // 
            dbo_testChiTietTest_TestAction.Conditions.Add(rowCountChiTiet);
            dbo_testChiTietTest_TestAction.Conditions.Add(checksumChiTiet);
            dbo_testChiTietTest_TestAction.Conditions.Add(scalarValueChiTiet);
            resources.ApplyResources(dbo_testChiTietTest_TestAction, "dbo_testChiTietTest_TestAction");
            // 
            // rowCountChiTiet
            // 
            rowCountChiTiet.Enabled = true;
            rowCountChiTiet.Name = "rowCountChiTiet";
            rowCountChiTiet.ResultSet = 1;
            rowCountChiTiet.RowCount = 4;
            // 
            // dbo_testChiTietTestData
            // 
            this.dbo_testChiTietTestData.PosttestAction = null;
            this.dbo_testChiTietTestData.PretestAction = null;
            this.dbo_testChiTietTestData.TestAction = dbo_testChiTietTest_TestAction;
            // 
            // checksumChiTiet
            // 
            checksumChiTiet.Checksum = "-1620219034";
            checksumChiTiet.Enabled = true;
            checksumChiTiet.Name = "checksumChiTiet";
            // 
            // scalarValueChiTiet
            // 
            scalarValueChiTiet.ColumnNumber = 4;
            scalarValueChiTiet.Enabled = true;
            scalarValueChiTiet.ExpectedValue = "1700000";
            scalarValueChiTiet.Name = "scalarValueChiTiet";
            scalarValueChiTiet.NullExpected = false;
            scalarValueChiTiet.ResultSet = 1;
            scalarValueChiTiet.RowNumber = 4;
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion


        [TestMethod()]
        public void dbo_testChiTietTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_testChiTietTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            // Execute the test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
            SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            // Execute the post-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
            SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
        }
        private SqlDatabaseTestActions dbo_testChiTietTestData;
    }
}
