using System;
using System.Collections.Generic;

using Automation.Utils.DatabaseUtils;
using Automation.Utils.DatabaseUtils.Interfaces;

using Framework.DomainDriven.DBGenerator;

using WorkflowSampleSystem.DbGenerate;
using WorkflowSampleSystem.IntegrationTests.__Support;
using WorkflowSampleSystem.IntegrationTests.__Support.TestData;

namespace WorkflowSampleSystem.IntegrationTests.Support.Utils
{
    public class WorkflowSampleSystemDatabaseUtil : BaseDatabaseUtil
    {
        public WorkflowSampleSystemDatabaseUtil(IDatabaseContext databaseContext)
                : base(databaseContext)
        {
        }

        protected override IEnumerable<string> TestServers => new List<string> { "." };

        public override void GenerateDatabases()
        {
            new DbGeneratorTest().GenerateAllDB(
                                                this.DatabaseContext.MainDatabase.DataSource,
                                                credential: UserCredential.Create(this.DatabaseContext.MainDatabase.UserId, this.DatabaseContext.MainDatabase.Password));
        }

        public override void CheckTestDatabase()
        {
            if (this.DatabaseContext.Server.TableRowCount(this.DatabaseContext.MainDatabase.DatabaseName, "Location") > 100)
            {
                throw new Exception("Location row count more than 100. Please ensure that you run tests in Test Environment. If you want to run tests in the environment, please delete all Location rows (Location table) manually and rerun tests.");
            }
        }

        public override void GenerateTestData() => new TestDataInitialize().TestData();

        public override void ExecuteInsertsForDatabases()
        {
            base.ExecuteInsertsForDatabases();

            CoreDatabaseUtil.ExecuteSqlFromFolder(this.DatabaseContext.MainDatabase.ConnectionString, @"__Support/Scripts/Authorization", this.DatabaseContext.MainDatabase.DatabaseName);
            CoreDatabaseUtil.ExecuteSqlFromFolder(this.DatabaseContext.MainDatabase.ConnectionString, @"__Support/Scripts/Configuration", this.DatabaseContext.MainDatabase.DatabaseName);
            CoreDatabaseUtil.ExecuteSqlFromFolder(this.DatabaseContext.MainDatabase.ConnectionString, @"__Support/Scripts/WorkflowSampleSystem", this.DatabaseContext.MainDatabase.DatabaseName);
            CoreDatabaseUtil.ExecuteSqlFromFolder(this.DatabaseContext.MainDatabase.ConnectionString, @"__Support/Scripts/Workflow", this.DatabaseContext.MainDatabase.DatabaseName);

            new BssFluentMigrator(this.DatabaseContext.MainDatabase.ConnectionString, typeof(InitNumberInDomainObjectEventMigration).Assembly).Migrate();
        }
    }
}
