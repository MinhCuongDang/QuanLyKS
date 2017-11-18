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
    public class TestDSPhong : SqlDatabaseTestClass
    {

        public TestDSPhong()
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_TestHTAdsPhongTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestDSPhong));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowTestDSPhong;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueTestDSPhong;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumDsPhong;
            this.dbo_TestHTAdsPhongTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_TestHTAdsPhongTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowTestDSPhong = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueTestDSPhong = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            checksumDsPhong = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            // 
            // dbo_TestHTAdsPhongTest_TestAction
            // 
            dbo_TestHTAdsPhongTest_TestAction.Conditions.Add(rowTestDSPhong);
            dbo_TestHTAdsPhongTest_TestAction.Conditions.Add(scalarValueTestDSPhong);
            dbo_TestHTAdsPhongTest_TestAction.Conditions.Add(checksumDsPhong);
            resources.ApplyResources(dbo_TestHTAdsPhongTest_TestAction, "dbo_TestHTAdsPhongTest_TestAction");
            // 
            // rowTestDSPhong
            // 
            rowTestDSPhong.Enabled = true;
            rowTestDSPhong.Name = "rowTestDSPhong";
            rowTestDSPhong.ResultSet = 1;
            rowTestDSPhong.RowCount = 15;
            // 
            // scalarValueTestDSPhong
            // 
            scalarValueTestDSPhong.ColumnNumber = 3;
            scalarValueTestDSPhong.Enabled = true;
            scalarValueTestDSPhong.ExpectedValue = "1";
            scalarValueTestDSPhong.Name = "scalarValueTestDSPhong";
            scalarValueTestDSPhong.NullExpected = false;
            scalarValueTestDSPhong.ResultSet = 1;
            scalarValueTestDSPhong.RowNumber = 6;
            // 
            // dbo_TestHTAdsPhongTestData
            // 
            this.dbo_TestHTAdsPhongTestData.PosttestAction = null;
            this.dbo_TestHTAdsPhongTestData.PretestAction = null;
            this.dbo_TestHTAdsPhongTestData.TestAction = dbo_TestHTAdsPhongTest_TestAction;
            // 
            // checksumDsPhong
            // 
            checksumDsPhong.Checksum = "-742298941";
            checksumDsPhong.Enabled = true;
            checksumDsPhong.Name = "checksumDsPhong";
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
        public void dbo_TestHTAdsPhongTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_TestHTAdsPhongTestData;
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
        private SqlDatabaseTestActions dbo_TestHTAdsPhongTestData;
    }
}
