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
    public class TestBangGia : SqlDatabaseTestClass
    {

        public TestBangGia()
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_testKhoTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestBangGia));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowBangGia;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumBangGia;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueBangGia;
            this.dbo_testKhoTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_testKhoTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowBangGia = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            checksumBangGia = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            scalarValueBangGia = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            // 
            // dbo_testKhoTest_TestAction
            // 
            dbo_testKhoTest_TestAction.Conditions.Add(rowBangGia);
            dbo_testKhoTest_TestAction.Conditions.Add(checksumBangGia);
            dbo_testKhoTest_TestAction.Conditions.Add(scalarValueBangGia);
            resources.ApplyResources(dbo_testKhoTest_TestAction, "dbo_testKhoTest_TestAction");
            // 
            // rowBangGia
            // 
            rowBangGia.Enabled = true;
            rowBangGia.Name = "rowBangGia";
            rowBangGia.ResultSet = 1;
            rowBangGia.RowCount = 8;
            // 
            // dbo_testKhoTestData
            // 
            this.dbo_testKhoTestData.PosttestAction = null;
            this.dbo_testKhoTestData.PretestAction = null;
            this.dbo_testKhoTestData.TestAction = dbo_testKhoTest_TestAction;
            // 
            // checksumBangGia
            // 
            checksumBangGia.Checksum = "-1755929144";
            checksumBangGia.Enabled = true;
            checksumBangGia.Name = "checksumBangGia";
            // 
            // scalarValueBangGia
            // 
            scalarValueBangGia.ColumnNumber = 2;
            scalarValueBangGia.Enabled = true;
            scalarValueBangGia.ExpectedValue = "2";
            scalarValueBangGia.Name = "scalarValueBangGia";
            scalarValueBangGia.NullExpected = false;
            scalarValueBangGia.ResultSet = 1;
            scalarValueBangGia.RowNumber = 2;
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
        public void dbo_testKhoTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_testKhoTestData;
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
        private SqlDatabaseTestActions dbo_testKhoTestData;
    }
}
