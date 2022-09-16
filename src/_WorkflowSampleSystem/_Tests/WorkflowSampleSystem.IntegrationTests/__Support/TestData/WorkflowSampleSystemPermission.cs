﻿using System;
using System.Collections.Generic;

using Automation.ServiceEnvironment;
using Automation.Utils;

using WorkflowSampleSystem.Generated.DTO;

namespace WorkflowSampleSystem.IntegrationTests.__Support.TestData
{
    public class WorkflowSampleSystemPermission : IPermissionDefinition
    {
        public WorkflowSampleSystemPermission()
        {
        }

        public WorkflowSampleSystemPermission(TestBusinessRole role)
        {
            this.Role = role;
        }

        public WorkflowSampleSystemPermission(
            TestBusinessRole role,
            BusinessUnitIdentityDTO? businessUnit,
            LocationIdentityDTO? location)
        {
            this.Role = role;
            this.BusinessUnit = businessUnit;
            this.Location = location;
        }

        public TestBusinessRole Role { get; set; }

        public BusinessUnitIdentityDTO? BusinessUnit { get; set; }

        public LocationIdentityDTO? Location { get; set; }

        public IEnumerable<Tuple<string, Guid>> GetEntities()
        {
            if (this.BusinessUnit != null)
            {
                yield return Tuple.Create(DefaultConstants.ENTITY_TYPE_FINANCIAL_BUSINESS_UNIT_NAME, ((BusinessUnitIdentityDTO)this.BusinessUnit).Id);
            }

            if (this.Location != null)
            {
                yield return Tuple.Create(DefaultConstants.ENTITY_TYPE_LOCATION_NAME, ((LocationIdentityDTO)this.Location).Id);
            }
        }

        public string GetRoleName()
        {
            return this.Role.GetRoleName();
        }
    }
}
