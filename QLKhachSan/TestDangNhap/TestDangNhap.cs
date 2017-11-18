using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDangNhap
{
    [TestClass()]
    public class TestDangNhap : SqlDatabaseTestClass
    {

        public TestDangNhap()
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_TestDangNhapTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestDangNhap));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowDangNhap;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueDangNhap;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumDangNhap;
            this.dbo_TestDangNhapTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_TestDangNhapTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowDangNhap = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueDangNhap = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            checksumDangNhap = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            // 
            // dbo_TestDangNhapTest_TestAction
            // 
            dbo_TestDangNhapTest_TestAction.Conditions.Add(rowDangNhap);
            dbo_TestDangNhapTest_TestAction.Conditions.Add(scalarValueDangNhap);
            dbo_TestDangNhapTest_TestAction.Conditions.Add(checksumDangNhap);
            resources.ApplyResources(dbo_TestDangNhapTest_TestAction, "dbo_TestDangNhapTest_TestAction");
            // 
            // rowDangNhap
            // 
            rowDangNhap.Enabled = true;
            rowDangNhap.Name = "rowDangNhap";
            rowDangNhap.ResultSet = 1;
            rowDangNhap.RowCount = 3;
            // 
            // dbo_TestDangNhapTestData
            // 
            this.dbo_TestDangNhapTestData.PosttestAction = null;
            this.dbo_TestDangNhapTestData.PretestAction = null;
            this.dbo_TestDangNhapTestData.TestAction = dbo_TestDangNhapTest_TestAction;
            // 
            // scalarValueDangNhap
            // 
            scalarValueDangNhap.ColumnNumber = 2;
            scalarValueDangNhap.Enabled = true;
            scalarValueDangNhap.ExpectedValue = "123";
            scalarValueDangNhap.Name = "scalarValueDangNhap";
            scalarValueDangNhap.NullExpected = false;
            scalarValueDangNhap.ResultSet = 1;
            scalarValueDangNhap.RowNumber = 2;
            // 
            // checksumDangNhap
            // 
            checksumDangNhap.Checksum = "1206582501";
            checksumDangNhap.Enabled = true;
            checksumDangNhap.Name = "checksumDangNhap";
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
        public void dbo_TestDangNhapTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_TestDangNhapTestData;
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
        private SqlDatabaseTestActions dbo_TestDangNhapTestData;
    }
}
