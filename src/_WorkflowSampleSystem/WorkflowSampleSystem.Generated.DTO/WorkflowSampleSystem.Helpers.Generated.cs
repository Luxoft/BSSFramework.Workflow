﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorkflowSampleSystem.Generated.DTO
{
    
    
    #region 
	static
    public class LambdaHelper
    {
        
        public static WorkflowSampleSystem.Generated.DTO.BusinessUnitFullDTO ToFullDTO(this WorkflowSampleSystem.Domain.BusinessUnit domainObject, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService mappingService)
        {
            return new WorkflowSampleSystem.Generated.DTO.BusinessUnitFullDTO(mappingService, domainObject);
        }
        
        public static WorkflowSampleSystem.Generated.DTO.EmployeeFullDTO ToFullDTO(this WorkflowSampleSystem.Domain.Employee domainObject, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService mappingService)
        {
            return new WorkflowSampleSystem.Generated.DTO.EmployeeFullDTO(mappingService, domainObject);
        }
        
        public static WorkflowSampleSystem.Generated.DTO.HRDepartmentFullDTO ToFullDTO(this WorkflowSampleSystem.Domain.HRDepartment domainObject, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService mappingService)
        {
            return new WorkflowSampleSystem.Generated.DTO.HRDepartmentFullDTO(mappingService, domainObject);
        }
        
        public static WorkflowSampleSystem.Generated.DTO.LocationFullDTO ToFullDTO(this WorkflowSampleSystem.Domain.Location domainObject, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService mappingService)
        {
            return new WorkflowSampleSystem.Generated.DTO.LocationFullDTO(mappingService, domainObject);
        }
        
        public static System.Collections.Generic.List<WorkflowSampleSystem.Generated.DTO.BusinessUnitFullDTO> ToFullDTOList(this System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Domain.BusinessUnit> domainObjects, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService mappingService)
        {
            return Framework.Core.EnumerableExtensions.ToList(domainObjects, domainObject => WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToFullDTO(domainObject, mappingService));
        }
        
        public static System.Collections.Generic.List<WorkflowSampleSystem.Generated.DTO.EmployeeFullDTO> ToFullDTOList(this System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Domain.Employee> domainObjects, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService mappingService)
        {
            return Framework.Core.EnumerableExtensions.ToList(domainObjects, domainObject => WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToFullDTO(domainObject, mappingService));
        }
        
        public static System.Collections.Generic.List<WorkflowSampleSystem.Generated.DTO.HRDepartmentFullDTO> ToFullDTOList(this System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Domain.HRDepartment> domainObjects, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService mappingService)
        {
            return Framework.Core.EnumerableExtensions.ToList(domainObjects, domainObject => WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToFullDTO(domainObject, mappingService));
        }
        
        public static System.Collections.Generic.List<WorkflowSampleSystem.Generated.DTO.LocationFullDTO> ToFullDTOList(this System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Domain.Location> domainObjects, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService mappingService)
        {
            return Framework.Core.EnumerableExtensions.ToList(domainObjects, domainObject => WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToFullDTO(domainObject, mappingService));
        }
        
        public static WorkflowSampleSystem.Generated.DTO.BusinessUnitIdentityDTO ToIdentityDTO(this WorkflowSampleSystem.Domain.BusinessUnit domainObject)
        {
            return new WorkflowSampleSystem.Generated.DTO.BusinessUnitIdentityDTO(domainObject);
        }
        
        public static WorkflowSampleSystem.Generated.DTO.EmployeeIdentityDTO ToIdentityDTO(this WorkflowSampleSystem.Domain.Employee domainObject)
        {
            return new WorkflowSampleSystem.Generated.DTO.EmployeeIdentityDTO(domainObject);
        }
        
        public static WorkflowSampleSystem.Generated.DTO.HRDepartmentIdentityDTO ToIdentityDTO(this WorkflowSampleSystem.Domain.HRDepartment domainObject)
        {
            return new WorkflowSampleSystem.Generated.DTO.HRDepartmentIdentityDTO(domainObject);
        }
        
        public static WorkflowSampleSystem.Generated.DTO.LocationIdentityDTO ToIdentityDTO(this WorkflowSampleSystem.Domain.Location domainObject)
        {
            return new WorkflowSampleSystem.Generated.DTO.LocationIdentityDTO(domainObject);
        }
        
        public static System.Collections.Generic.List<WorkflowSampleSystem.Generated.DTO.BusinessUnitIdentityDTO> ToIdentityDTOList(this System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Domain.BusinessUnit> domainObjects)
        {
            return Framework.Core.EnumerableExtensions.ToList(domainObjects, domainObject => WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToIdentityDTO(domainObject));
        }
        
        public static System.Collections.Generic.List<WorkflowSampleSystem.Generated.DTO.EmployeeIdentityDTO> ToIdentityDTOList(this System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Domain.Employee> domainObjects)
        {
            return Framework.Core.EnumerableExtensions.ToList(domainObjects, domainObject => WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToIdentityDTO(domainObject));
        }
        
        public static System.Collections.Generic.List<WorkflowSampleSystem.Generated.DTO.HRDepartmentIdentityDTO> ToIdentityDTOList(this System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Domain.HRDepartment> domainObjects)
        {
            return Framework.Core.EnumerableExtensions.ToList(domainObjects, domainObject => WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToIdentityDTO(domainObject));
        }
        
        public static System.Collections.Generic.List<WorkflowSampleSystem.Generated.DTO.LocationIdentityDTO> ToIdentityDTOList(this System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Domain.Location> domainObjects)
        {
            return Framework.Core.EnumerableExtensions.ToList(domainObjects, domainObject => WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToIdentityDTO(domainObject));
        }
        
        public static WorkflowSampleSystem.Generated.DTO.BusinessUnitRichDTO ToRichDTO(this WorkflowSampleSystem.Domain.BusinessUnit domainObject, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService mappingService)
        {
            return new WorkflowSampleSystem.Generated.DTO.BusinessUnitRichDTO(mappingService, domainObject);
        }
        
        public static WorkflowSampleSystem.Generated.DTO.HRDepartmentRichDTO ToRichDTO(this WorkflowSampleSystem.Domain.HRDepartment domainObject, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService mappingService)
        {
            return new WorkflowSampleSystem.Generated.DTO.HRDepartmentRichDTO(mappingService, domainObject);
        }
        
        public static WorkflowSampleSystem.Generated.DTO.LocationRichDTO ToRichDTO(this WorkflowSampleSystem.Domain.Location domainObject, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService mappingService)
        {
            return new WorkflowSampleSystem.Generated.DTO.LocationRichDTO(mappingService, domainObject);
        }
        
        public static System.Collections.Generic.List<WorkflowSampleSystem.Generated.DTO.BusinessUnitRichDTO> ToRichDTOList(this System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Domain.BusinessUnit> domainObjects, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService mappingService)
        {
            return Framework.Core.EnumerableExtensions.ToList(domainObjects, domainObject => WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToRichDTO(domainObject, mappingService));
        }
        
        public static System.Collections.Generic.List<WorkflowSampleSystem.Generated.DTO.HRDepartmentRichDTO> ToRichDTOList(this System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Domain.HRDepartment> domainObjects, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService mappingService)
        {
            return Framework.Core.EnumerableExtensions.ToList(domainObjects, domainObject => WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToRichDTO(domainObject, mappingService));
        }
        
        public static System.Collections.Generic.List<WorkflowSampleSystem.Generated.DTO.LocationRichDTO> ToRichDTOList(this System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Domain.Location> domainObjects, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService mappingService)
        {
            return Framework.Core.EnumerableExtensions.ToList(domainObjects, domainObject => WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToRichDTO(domainObject, mappingService));
        }
        
        public static WorkflowSampleSystem.Generated.DTO.BusinessUnitSimpleDTO ToSimpleDTO(this WorkflowSampleSystem.Domain.BusinessUnit domainObject, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService mappingService)
        {
            return new WorkflowSampleSystem.Generated.DTO.BusinessUnitSimpleDTO(mappingService, domainObject);
        }
        
        public static WorkflowSampleSystem.Generated.DTO.EmployeeSimpleDTO ToSimpleDTO(this WorkflowSampleSystem.Domain.Employee domainObject, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService mappingService)
        {
            return new WorkflowSampleSystem.Generated.DTO.EmployeeSimpleDTO(mappingService, domainObject);
        }
        
        public static WorkflowSampleSystem.Generated.DTO.HRDepartmentSimpleDTO ToSimpleDTO(this WorkflowSampleSystem.Domain.HRDepartment domainObject, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService mappingService)
        {
            return new WorkflowSampleSystem.Generated.DTO.HRDepartmentSimpleDTO(mappingService, domainObject);
        }
        
        public static WorkflowSampleSystem.Generated.DTO.LocationSimpleDTO ToSimpleDTO(this WorkflowSampleSystem.Domain.Location domainObject, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService mappingService)
        {
            return new WorkflowSampleSystem.Generated.DTO.LocationSimpleDTO(mappingService, domainObject);
        }
        
        public static System.Collections.Generic.List<WorkflowSampleSystem.Generated.DTO.BusinessUnitSimpleDTO> ToSimpleDTOList(this System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Domain.BusinessUnit> domainObjects, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService mappingService)
        {
            return Framework.Core.EnumerableExtensions.ToList(domainObjects, domainObject => WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToSimpleDTO(domainObject, mappingService));
        }
        
        public static System.Collections.Generic.List<WorkflowSampleSystem.Generated.DTO.EmployeeSimpleDTO> ToSimpleDTOList(this System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Domain.Employee> domainObjects, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService mappingService)
        {
            return Framework.Core.EnumerableExtensions.ToList(domainObjects, domainObject => WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToSimpleDTO(domainObject, mappingService));
        }
        
        public static System.Collections.Generic.List<WorkflowSampleSystem.Generated.DTO.HRDepartmentSimpleDTO> ToSimpleDTOList(this System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Domain.HRDepartment> domainObjects, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService mappingService)
        {
            return Framework.Core.EnumerableExtensions.ToList(domainObjects, domainObject => WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToSimpleDTO(domainObject, mappingService));
        }
        
        public static System.Collections.Generic.List<WorkflowSampleSystem.Generated.DTO.LocationSimpleDTO> ToSimpleDTOList(this System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Domain.Location> domainObjects, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService mappingService)
        {
            return Framework.Core.EnumerableExtensions.ToList(domainObjects, domainObject => WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToSimpleDTO(domainObject, mappingService));
        }
        
        public static WorkflowSampleSystem.Generated.DTO.BusinessUnitVisualDTO ToVisualDTO(this WorkflowSampleSystem.Domain.BusinessUnit domainObject, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService mappingService)
        {
            return new WorkflowSampleSystem.Generated.DTO.BusinessUnitVisualDTO(mappingService, domainObject);
        }
        
        public static WorkflowSampleSystem.Generated.DTO.HRDepartmentVisualDTO ToVisualDTO(this WorkflowSampleSystem.Domain.HRDepartment domainObject, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService mappingService)
        {
            return new WorkflowSampleSystem.Generated.DTO.HRDepartmentVisualDTO(mappingService, domainObject);
        }
        
        public static WorkflowSampleSystem.Generated.DTO.LocationVisualDTO ToVisualDTO(this WorkflowSampleSystem.Domain.Location domainObject, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService mappingService)
        {
            return new WorkflowSampleSystem.Generated.DTO.LocationVisualDTO(mappingService, domainObject);
        }
        
        public static System.Collections.Generic.List<WorkflowSampleSystem.Generated.DTO.BusinessUnitVisualDTO> ToVisualDTOList(this System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Domain.BusinessUnit> domainObjects, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService mappingService)
        {
            return Framework.Core.EnumerableExtensions.ToList(domainObjects, domainObject => WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToVisualDTO(domainObject, mappingService));
        }
        
        public static System.Collections.Generic.List<WorkflowSampleSystem.Generated.DTO.HRDepartmentVisualDTO> ToVisualDTOList(this System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Domain.HRDepartment> domainObjects, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService mappingService)
        {
            return Framework.Core.EnumerableExtensions.ToList(domainObjects, domainObject => WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToVisualDTO(domainObject, mappingService));
        }
        
        public static System.Collections.Generic.List<WorkflowSampleSystem.Generated.DTO.LocationVisualDTO> ToVisualDTOList(this System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Domain.Location> domainObjects, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService mappingService)
        {
            return Framework.Core.EnumerableExtensions.ToList(domainObjects, domainObject => WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToVisualDTO(domainObject, mappingService));
        }
    }
    #endregion
}
