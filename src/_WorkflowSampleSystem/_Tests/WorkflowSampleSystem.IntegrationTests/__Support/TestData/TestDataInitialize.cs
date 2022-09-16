using System;
using Automation.ServiceEnvironment;
using Microsoft.Extensions.DependencyInjection;

using WorkflowSampleSystem.BLL;
using WorkflowSampleSystem.Domain.Inline;
using WorkflowSampleSystem.IntegrationTests.__Support.TestData.Helpers;
using WorkflowSampleSystem.ServiceEnvironment;

namespace WorkflowSampleSystem.IntegrationTests.__Support.TestData
{
    public class TestDataInitialize : RootServiceProviderContainer<IWorkflowSampleSystemBLLContext>
    {
        public TestDataInitialize(IServiceProvider serviceProvider)
                : base(serviceProvider)
        {
        }

        private AuthHelper AuthHelper => this.RootServiceProvider.GetRequiredService<AuthHelper>();

        private DataHelper DataHelper => this.RootServiceProvider.GetRequiredService<DataHelper>();

        public void TestData()
        {
            this.RootServiceProvider.GetRequiredService<WorkflowSampleSystemInitializer>().Initialize();

            this.AuthHelper.AddCurrentUserToAdmin();

            this.AuthHelper.SetUserRole(DefaultConstants.NOTIFICATION_ADMIN, TestBusinessRole.SystemIntegration);
            this.AuthHelper.SetUserRole(DefaultConstants.INTEGRATION_USER, TestBusinessRole.SystemIntegration);

            this.DataHelper.SaveLocation(id: DefaultConstants.LOCATION_PARENT_ID, name: DefaultConstants.LOCATION_PARENT_NAME);

            this.DataHelper.SaveEmployee(
                id: DefaultConstants.EMPLOYEE_MY_ID,
                nameEng:
                    new Fio
                    {
                        FirstName = DefaultConstants.EMPLOYEE_MY_NAME,
                        LastName = DefaultConstants.EMPLOYEE_MY_NAME
                    },
                login: DefaultConstants.EMPLOYEE_MY_LOGIN,
                isObjectRequired: false);

            this.DataHelper.SaveHRDepartment(
                                             DefaultConstants.HRDEPARTMENT_PARENT_ID,
                                             DefaultConstants.HRDEPARTMENT_PARENT_NAME);
        }
    }
}
