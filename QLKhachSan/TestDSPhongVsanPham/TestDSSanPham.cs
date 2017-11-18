using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDSPhongVsanPham
{
    [TestClass()]
    public class TestDSSanPham : SqlDatabaseTestClass
    {

        public TestDSSanPham()
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_TestHTASanPhamTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestDSSanPham));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowDSSanPham;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueDSSanPham;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumDSSanPham;
            this.dbo_TestHTASanPhamTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_TestHTASanPhamTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowDSSanPham = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueDSSanPham = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            checksumDSSanPham = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            // 
            // dbo_TestHTASanPhamTest_TestAction
            // 
            dbo_TestHTASanPhamTest_TestAction.Conditions.Add(rowDSSanPham);
            dbo_TestHTASanPhamTest_TestAction.Conditions.Add(scalarValueDSSanPham);
            dbo_TestHTASanPhamTest_TestAction.Conditions.Add(checksumDSSanPham);
            resources.ApplyResources(dbo_TestHTASanPhamTest_TestAction, "dbo_TestHTASanPhamTest_TestAction");
            // 
            // rowDSSanPham
            // 
            rowDSSanPham.Enabled = true;
            rowDSSanPham.Name = "rowDSSanPham";
            rowDSSanPham.ResultSet = 1;
            rowDSSanPham.RowCount = 4;
            // 
            // scalarValueDSSanPham
            // 
            scalarValueDSSanPham.ColumnNumber = 1;
            scalarValueDSSanPham.Enabled = true;
            scalarValueDSSanPham.ExpectedValue = "00004";
            scalarValueDSSanPham.Name = "scalarValueDSSanPham";
            scalarValueDSSanPham.NullExpected = false;
            scalarValueDSSanPham.ResultSet = 1;
            scalarValueDSSanPham.RowNumber = 4;
            // 
            // checksumDSSanPham
            // 
            checksumDSSanPham.Checksum = "-139293017";
            checksumDSSanPham.Enabled = true;
            checksumDSSanPham.Name = "checksumDSSanPham";
            // 
            // dbo_TestHTASanPhamTestData
            // 
            this.dbo_TestHTASanPhamTestData.PosttestAction = null;
            this.dbo_TestHTASanPhamTestData.PretestAction = null;
            this.dbo_TestHTASanPhamTestData.TestAction = dbo_TestHTASanPhamTest_TestAction;
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
        public void dbo_TestHTASanPhamTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_TestHTASanPhamTestData;
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
        private SqlDatabaseTestActions dbo_TestHTASanPhamTestData;
    }
}
