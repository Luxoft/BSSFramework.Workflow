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
    
    
    public partial interface IWorkflowSampleSystemDTOMappingService : Framework.DomainDriven.IDTOMappingService<WorkflowSampleSystem.Domain.PersistentDomainObjectBase, System.Guid>
    {
        
        void MapAuditPersistentDomainObjectBase(WorkflowSampleSystem.Domain.AuditPersistentDomainObjectBase domainObject, WorkflowSampleSystem.Generated.DTO.BaseAuditPersistentDTO mappingObject);
        
        void MapBusinessUnit(WorkflowSampleSystem.Domain.BusinessUnit domainObject, WorkflowSampleSystem.Generated.DTO.BusinessUnitVisualDTO mappingObject);
        
        void MapBusinessUnit(WorkflowSampleSystem.Domain.BusinessUnit domainObject, WorkflowSampleSystem.Generated.DTO.BusinessUnitSimpleDTO mappingObject);
        
        void MapBusinessUnit(WorkflowSampleSystem.Domain.BusinessUnit domainObject, WorkflowSampleSystem.Generated.DTO.BusinessUnitFullDTO mappingObject);
        
        void MapBusinessUnit(WorkflowSampleSystem.Domain.BusinessUnit domainObject, WorkflowSampleSystem.Generated.DTO.BusinessUnitRichDTO mappingObject);
        
        void MapBusinessUnit(WorkflowSampleSystem.Generated.DTO.BusinessUnitStrictDTO mappingObject, WorkflowSampleSystem.Domain.BusinessUnit domainObject);
        
        void MapDomainObjectBase(WorkflowSampleSystem.Domain.DomainObjectBase domainObject, WorkflowSampleSystem.Generated.DTO.BaseAbstractDTO mappingObject);
        
        void MapEmployee(WorkflowSampleSystem.Domain.Employee domainObject, WorkflowSampleSystem.Generated.DTO.EmployeeSimpleDTO mappingObject);
        
        void MapEmployee(WorkflowSampleSystem.Domain.Employee domainObject, WorkflowSampleSystem.Generated.DTO.EmployeeFullDTO mappingObject);
        
        void MapEmployee(WorkflowSampleSystem.Generated.DTO.EmployeeStrictDTO mappingObject, WorkflowSampleSystem.Domain.Employee domainObject);
        
        void MapEmployee(WorkflowSampleSystem.Generated.DTO.EmployeeUpdateDTO mappingObject, WorkflowSampleSystem.Domain.Employee domainObject);
        
        void MapHRDepartment(WorkflowSampleSystem.Domain.HRDepartment domainObject, WorkflowSampleSystem.Generated.DTO.HRDepartmentVisualDTO mappingObject);
        
        void MapHRDepartment(WorkflowSampleSystem.Domain.HRDepartment domainObject, WorkflowSampleSystem.Generated.DTO.HRDepartmentSimpleDTO mappingObject);
        
        void MapHRDepartment(WorkflowSampleSystem.Domain.HRDepartment domainObject, WorkflowSampleSystem.Generated.DTO.HRDepartmentFullDTO mappingObject);
        
        void MapHRDepartment(WorkflowSampleSystem.Domain.HRDepartment domainObject, WorkflowSampleSystem.Generated.DTO.HRDepartmentRichDTO mappingObject);
        
        void MapHRDepartment(WorkflowSampleSystem.Generated.DTO.HRDepartmentStrictDTO mappingObject, WorkflowSampleSystem.Domain.HRDepartment domainObject);
        
        void MapLocation(WorkflowSampleSystem.Domain.Location domainObject, WorkflowSampleSystem.Generated.DTO.LocationVisualDTO mappingObject);
        
        void MapLocation(WorkflowSampleSystem.Domain.Location domainObject, WorkflowSampleSystem.Generated.DTO.LocationSimpleDTO mappingObject);
        
        void MapLocation(WorkflowSampleSystem.Domain.Location domainObject, WorkflowSampleSystem.Generated.DTO.LocationFullDTO mappingObject);
        
        void MapLocation(WorkflowSampleSystem.Domain.Location domainObject, WorkflowSampleSystem.Generated.DTO.LocationRichDTO mappingObject);
        
        void MapLocation(WorkflowSampleSystem.Generated.DTO.LocationStrictDTO mappingObject, WorkflowSampleSystem.Domain.Location domainObject);
        
        void MapPersistentDomainObjectBase(WorkflowSampleSystem.Domain.PersistentDomainObjectBase domainObject, WorkflowSampleSystem.Generated.DTO.BasePersistentDTO mappingObject);
        
        WorkflowSampleSystem.Domain.BusinessUnit ToBusinessUnit(WorkflowSampleSystem.Generated.DTO.BusinessUnitIdentityDTO businessUnitIdentityDTO);
        
        WorkflowSampleSystem.Domain.BusinessUnit ToBusinessUnit(WorkflowSampleSystem.Generated.DTO.BusinessUnitStrictDTO businessUnitStrictDTO);
        
        WorkflowSampleSystem.Domain.BusinessUnit ToBusinessUnit(WorkflowSampleSystem.Generated.DTO.BusinessUnitStrictDTO businessUnitStrictDTO, bool allowCreate);
        
        WorkflowSampleSystem.Domain.Employee ToEmployee(WorkflowSampleSystem.Generated.DTO.EmployeeIdentityDTO employeeIdentityDTO);
        
        WorkflowSampleSystem.Domain.Employee ToEmployee(WorkflowSampleSystem.Generated.DTO.EmployeeStrictDTO employeeStrictDTO);
        
        WorkflowSampleSystem.Domain.Employee ToEmployee(WorkflowSampleSystem.Generated.DTO.EmployeeStrictDTO employeeStrictDTO, bool allowCreate);
        
        WorkflowSampleSystem.Domain.Employee ToEmployee(WorkflowSampleSystem.Generated.DTO.EmployeeUpdateDTO employeeUpdateDTO);
        
        WorkflowSampleSystem.Domain.Employee ToEmployee(WorkflowSampleSystem.Generated.DTO.EmployeeUpdateDTO employeeUpdateDTO, bool allowCreate);
        
        WorkflowSampleSystem.Domain.HRDepartment ToHRDepartment(WorkflowSampleSystem.Generated.DTO.HRDepartmentIdentityDTO hRDepartmentIdentityDTO);
        
        WorkflowSampleSystem.Domain.HRDepartment ToHRDepartment(WorkflowSampleSystem.Generated.DTO.HRDepartmentStrictDTO hRDepartmentStrictDTO);
        
        WorkflowSampleSystem.Domain.HRDepartment ToHRDepartment(WorkflowSampleSystem.Generated.DTO.HRDepartmentStrictDTO hRDepartmentStrictDTO, bool allowCreate);
        
        WorkflowSampleSystem.Domain.Location ToLocation(WorkflowSampleSystem.Generated.DTO.LocationIdentityDTO locationIdentityDTO);
        
        WorkflowSampleSystem.Domain.Location ToLocation(WorkflowSampleSystem.Generated.DTO.LocationStrictDTO locationStrictDTO);
        
        WorkflowSampleSystem.Domain.Location ToLocation(WorkflowSampleSystem.Generated.DTO.LocationStrictDTO locationStrictDTO, bool allowCreate);
    }
    
    public abstract partial class WorkflowSampleSystemServerPrimitiveDTOMappingServiceBase : Framework.DomainDriven.DTOMappingService<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Domain.PersistentDomainObjectBase, WorkflowSampleSystem.Domain.AuditPersistentDomainObjectBase, System.Guid, long>, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService
    {
        
        protected WorkflowSampleSystemServerPrimitiveDTOMappingServiceBase(WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext context) : 
                base(context)
        {
        }
        
        public virtual void MapAuditPersistentDomainObjectBase(WorkflowSampleSystem.Domain.AuditPersistentDomainObjectBase domainObject, WorkflowSampleSystem.Generated.DTO.BaseAuditPersistentDTO mappingObject)
        {
            mappingObject.Active = domainObject.Active;
            mappingObject.CreateDate = domainObject.CreateDate;
            mappingObject.CreatedBy = domainObject.CreatedBy;
            mappingObject.ModifiedBy = domainObject.ModifiedBy;
            mappingObject.ModifyDate = domainObject.ModifyDate;
            mappingObject.Version = domainObject.Version;
        }
        
        public virtual void MapBusinessUnit(WorkflowSampleSystem.Domain.BusinessUnit domainObject, WorkflowSampleSystem.Generated.DTO.BusinessUnitVisualDTO mappingObject)
        {
            mappingObject.Name = domainObject.Name;
        }
        
        public virtual void MapBusinessUnit(WorkflowSampleSystem.Domain.BusinessUnit domainObject, WorkflowSampleSystem.Generated.DTO.BusinessUnitSimpleDTO mappingObject)
        {
            mappingObject.Name = domainObject.Name;
            mappingObject.Period = domainObject.Period;
        }
        
        public virtual void MapBusinessUnit(WorkflowSampleSystem.Domain.BusinessUnit domainObject, WorkflowSampleSystem.Generated.DTO.BusinessUnitFullDTO mappingObject)
        {
            if (!object.ReferenceEquals(domainObject.Parent, null))
            {
                mappingObject.Parent = WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToSimpleDTO(domainObject.Parent, this);
            }
            else
            {
                mappingObject.Parent = null;
            }
        }
        
        public virtual void MapBusinessUnit(WorkflowSampleSystem.Domain.BusinessUnit domainObject, WorkflowSampleSystem.Generated.DTO.BusinessUnitRichDTO mappingObject)
        {
            mappingObject.Children = WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToRichDTOList(domainObject.Children, this);
        }
        
        public virtual void MapBusinessUnit(WorkflowSampleSystem.Generated.DTO.BusinessUnitStrictDTO mappingObject, WorkflowSampleSystem.Domain.BusinessUnit domainObject)
        {
            domainObject.Version = this.VersionService.GetVersion(mappingObject.Version, domainObject);
            domainObject.Name = mappingObject.Name;
        }
        
        public virtual void MapDomainObjectBase(WorkflowSampleSystem.Domain.DomainObjectBase domainObject, WorkflowSampleSystem.Generated.DTO.BaseAbstractDTO mappingObject)
        {
        }
        
        public virtual void MapEmployee(WorkflowSampleSystem.Domain.Employee domainObject, WorkflowSampleSystem.Generated.DTO.EmployeeSimpleDTO mappingObject)
        {
            mappingObject.AccountName = domainObject.AccountName;
            mappingObject.Age = domainObject.Age;
            mappingObject.BirthDate = domainObject.BirthDate;
            mappingObject.CellPhone = domainObject.CellPhone;
            mappingObject.CoreBusinessUnitPeriod = domainObject.CoreBusinessUnitPeriod;
            mappingObject.DismissDate = domainObject.DismissDate;
            mappingObject.EducationDuration = domainObject.EducationDuration;
            mappingObject.Email = domainObject.Email;
            mappingObject.ExternalId = domainObject.ExternalId;
            mappingObject.HireDate = domainObject.HireDate;
            mappingObject.Interphone = domainObject.Interphone;
            mappingObject.IsCandidate = domainObject.IsCandidate;
            mappingObject.Landlinephone = domainObject.Landlinephone;
            mappingObject.LastActionDate = domainObject.LastActionDate;
            if (this.Context.SecurityService.GetSecurityProvider<WorkflowSampleSystem.Domain.Employee>(WorkflowSampleSystem.WorkflowSampleSystemSecurityOperationCode.EmployeeView).HasAccess(domainObject))
            {
                string resultLogin;
                resultLogin = domainObject.Login;
                mappingObject.Login = new Framework.Core.Just<string>(resultLogin);
            }
            else
            {
                mappingObject.Login = Framework.Core.Maybe<string>.Nothing;
            }
            mappingObject.MailAccountName = domainObject.MailAccountName;
            mappingObject.NameEng = domainObject.NameEng;
            mappingObject.NameNative = domainObject.NameNative;
            mappingObject.NameRussian = domainObject.NameRussian;
            mappingObject.NonValidateVirtualProp = domainObject.NonValidateVirtualProp;
            mappingObject.PersonalCellPhone = domainObject.PersonalCellPhone;
            mappingObject.Pin = domainObject.Pin;
            mappingObject.PlannedHireDate = domainObject.PlannedHireDate;
            mappingObject.ValidateVirtualProp = domainObject.ValidateVirtualProp;
            mappingObject.WorkPeriod = domainObject.WorkPeriod;
        }
        
        public virtual void MapEmployee(WorkflowSampleSystem.Domain.Employee domainObject, WorkflowSampleSystem.Generated.DTO.EmployeeFullDTO mappingObject)
        {
            if (!object.ReferenceEquals(domainObject.CoreBusinessUnit, null))
            {
                mappingObject.CoreBusinessUnit = WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToSimpleDTO(domainObject.CoreBusinessUnit, this);
            }
            else
            {
                mappingObject.CoreBusinessUnit = null;
            }
            if (!object.ReferenceEquals(domainObject.HRDepartment, null))
            {
                mappingObject.HRDepartment = WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToSimpleDTO(domainObject.HRDepartment, this);
            }
            else
            {
                mappingObject.HRDepartment = null;
            }
            if (!object.ReferenceEquals(domainObject.Location, null))
            {
                mappingObject.Location = WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToSimpleDTO(domainObject.Location, this);
            }
            else
            {
                mappingObject.Location = null;
            }
            if (!object.ReferenceEquals(domainObject.Ppm, null))
            {
                mappingObject.Ppm = WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToSimpleDTO(domainObject.Ppm, this);
            }
            else
            {
                mappingObject.Ppm = null;
            }
            if (!object.ReferenceEquals(domainObject.VacationApprover, null))
            {
                mappingObject.VacationApprover = WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToSimpleDTO(domainObject.VacationApprover, this);
            }
            else
            {
                mappingObject.VacationApprover = null;
            }
        }
        
        public virtual void MapEmployee(WorkflowSampleSystem.Generated.DTO.EmployeeStrictDTO mappingObject, WorkflowSampleSystem.Domain.Employee domainObject)
        {
            domainObject.Version = this.VersionService.GetVersion(mappingObject.Version, domainObject);
            domainObject.Age = mappingObject.Age;
            domainObject.BirthDate = mappingObject.BirthDate;
            domainObject.EducationDuration = mappingObject.EducationDuration;
            domainObject.Email = mappingObject.Email;
            domainObject.ExternalId = mappingObject.ExternalId;
            domainObject.Interphone = mappingObject.Interphone;
            domainObject.Landlinephone = mappingObject.Landlinephone;
            domainObject.LastActionDate = mappingObject.LastActionDate;
            domainObject.NameEng = mappingObject.NameEng;
            domainObject.NameNative = mappingObject.NameNative;
            domainObject.NameRussian = mappingObject.NameRussian;
            domainObject.NonValidateVirtualProp = mappingObject.NonValidateVirtualProp;
            domainObject.Pin = mappingObject.Pin;
            domainObject.PlannedHireDate = mappingObject.PlannedHireDate;
            if (!object.Equals(mappingObject.Ppm, default(WorkflowSampleSystem.Generated.DTO.EmployeeIdentityDTO)))
            {
                domainObject.Ppm = this.ToEmployee(mappingObject.Ppm);
            }
            else
            {
                domainObject.Ppm = null;
            }
            if (!object.Equals(mappingObject.VacationApprover, default(WorkflowSampleSystem.Generated.DTO.EmployeeIdentityDTO)))
            {
                domainObject.VacationApprover = this.ToEmployee(mappingObject.VacationApprover);
            }
            else
            {
                domainObject.VacationApprover = null;
            }
            domainObject.ValidateVirtualProp = mappingObject.ValidateVirtualProp;
            domainObject.WorkPeriod = mappingObject.WorkPeriod;
            Framework.Core.Just<string> justLogin = Framework.Core.PipeObjectExtensions.AsCast<Framework.Core.Just<string>>(mappingObject.Login);
            if (!object.ReferenceEquals(justLogin, null))
            {
                if (this.Context.SecurityService.GetSecurityProvider<WorkflowSampleSystem.Domain.Employee>(WorkflowSampleSystem.WorkflowSampleSystemSecurityOperationCode.EmployeeEdit).HasAccess(domainObject))
                {
                    domainObject.Login = justLogin.Value;
                }
                else
                {
                    throw new Framework.Exceptions.BusinessLogicException("Access for write to field \"Login\" denied");
                }
            }
        }
        
        public virtual void MapEmployee(WorkflowSampleSystem.Generated.DTO.EmployeeUpdateDTO mappingObject, WorkflowSampleSystem.Domain.Employee domainObject)
        {
            domainObject.Version = this.VersionService.GetVersion(mappingObject.Version, domainObject);
            Framework.Core.Just<int> justAge = Framework.Core.PipeObjectExtensions.AsCast<Framework.Core.Just<int>>(mappingObject.Age);
            if (!object.ReferenceEquals(justAge, null))
            {
                domainObject.Age = justAge.Value;
            }
            Framework.Core.Just<System.DateTime?> justBirthDate = Framework.Core.PipeObjectExtensions.AsCast<Framework.Core.Just<System.DateTime?>>(mappingObject.BirthDate);
            if (!object.ReferenceEquals(justBirthDate, null))
            {
                domainObject.BirthDate = justBirthDate.Value;
            }
            Framework.Core.Just<Framework.Core.Period> justEducationDuration = Framework.Core.PipeObjectExtensions.AsCast<Framework.Core.Just<Framework.Core.Period>>(mappingObject.EducationDuration);
            if (!object.ReferenceEquals(justEducationDuration, null))
            {
                domainObject.EducationDuration = justEducationDuration.Value;
            }
            Framework.Core.Just<string> justEmail = Framework.Core.PipeObjectExtensions.AsCast<Framework.Core.Just<string>>(mappingObject.Email);
            if (!object.ReferenceEquals(justEmail, null))
            {
                domainObject.Email = justEmail.Value;
            }
            Framework.Core.Just<long> justExternalId = Framework.Core.PipeObjectExtensions.AsCast<Framework.Core.Just<long>>(mappingObject.ExternalId);
            if (!object.ReferenceEquals(justExternalId, null))
            {
                domainObject.ExternalId = justExternalId.Value;
            }
            Framework.Core.Just<string> justInterphone = Framework.Core.PipeObjectExtensions.AsCast<Framework.Core.Just<string>>(mappingObject.Interphone);
            if (!object.ReferenceEquals(justInterphone, null))
            {
                domainObject.Interphone = justInterphone.Value;
            }
            Framework.Core.Just<string> justLandlinephone = Framework.Core.PipeObjectExtensions.AsCast<Framework.Core.Just<string>>(mappingObject.Landlinephone);
            if (!object.ReferenceEquals(justLandlinephone, null))
            {
                domainObject.Landlinephone = justLandlinephone.Value;
            }
            Framework.Core.Just<System.DateTime?> justLastActionDate = Framework.Core.PipeObjectExtensions.AsCast<Framework.Core.Just<System.DateTime?>>(mappingObject.LastActionDate);
            if (!object.ReferenceEquals(justLastActionDate, null))
            {
                domainObject.LastActionDate = justLastActionDate.Value;
            }
            Framework.Core.Just<string> justLogin = Framework.Core.PipeObjectExtensions.AsCast<Framework.Core.Just<string>>(mappingObject.Login);
            if (!object.ReferenceEquals(justLogin, null))
            {
                if (this.Context.SecurityService.GetSecurityProvider<WorkflowSampleSystem.Domain.Employee>(WorkflowSampleSystem.WorkflowSampleSystemSecurityOperationCode.EmployeeEdit).HasAccess(domainObject))
                {
                    domainObject.Login = justLogin.Value;
                }
                else
                {
                    throw new Framework.Exceptions.BusinessLogicException("Access for write to field \"Login\" denied");
                }
            }
            Framework.Core.Just<WorkflowSampleSystem.Domain.Inline.FioShort> justNameEng = Framework.Core.PipeObjectExtensions.AsCast<Framework.Core.Just<WorkflowSampleSystem.Domain.Inline.FioShort>>(mappingObject.NameEng);
            if (!object.ReferenceEquals(justNameEng, null))
            {
                domainObject.NameEng = justNameEng.Value;
            }
            Framework.Core.Just<WorkflowSampleSystem.Domain.Inline.Fio> justNameNative = Framework.Core.PipeObjectExtensions.AsCast<Framework.Core.Just<WorkflowSampleSystem.Domain.Inline.Fio>>(mappingObject.NameNative);
            if (!object.ReferenceEquals(justNameNative, null))
            {
                domainObject.NameNative = justNameNative.Value;
            }
            Framework.Core.Just<WorkflowSampleSystem.Domain.Inline.Fio> justNameRussian = Framework.Core.PipeObjectExtensions.AsCast<Framework.Core.Just<WorkflowSampleSystem.Domain.Inline.Fio>>(mappingObject.NameRussian);
            if (!object.ReferenceEquals(justNameRussian, null))
            {
                domainObject.NameRussian = justNameRussian.Value;
            }
            Framework.Core.Just<System.DateTime> justNonValidateVirtualProp = Framework.Core.PipeObjectExtensions.AsCast<Framework.Core.Just<System.DateTime>>(mappingObject.NonValidateVirtualProp);
            if (!object.ReferenceEquals(justNonValidateVirtualProp, null))
            {
                domainObject.NonValidateVirtualProp = justNonValidateVirtualProp.Value;
            }
            Framework.Core.Just<int?> justPin = Framework.Core.PipeObjectExtensions.AsCast<Framework.Core.Just<int?>>(mappingObject.Pin);
            if (!object.ReferenceEquals(justPin, null))
            {
                domainObject.Pin = justPin.Value;
            }
            Framework.Core.Just<System.DateTime?> justPlannedHireDate = Framework.Core.PipeObjectExtensions.AsCast<Framework.Core.Just<System.DateTime?>>(mappingObject.PlannedHireDate);
            if (!object.ReferenceEquals(justPlannedHireDate, null))
            {
                domainObject.PlannedHireDate = justPlannedHireDate.Value;
            }
            Framework.Core.Just<WorkflowSampleSystem.Generated.DTO.EmployeeIdentityDTO> justPpm = Framework.Core.PipeObjectExtensions.AsCast<Framework.Core.Just<WorkflowSampleSystem.Generated.DTO.EmployeeIdentityDTO>>(mappingObject.Ppm);
            if (!object.ReferenceEquals(justPpm, null))
            {
                if (!object.Equals(justPpm.Value, default(WorkflowSampleSystem.Generated.DTO.EmployeeIdentityDTO)))
                {
                    domainObject.Ppm = this.ToEmployee(justPpm.Value);
                }
                else
                {
                    domainObject.Ppm = null;
                }
            }
            Framework.Core.Just<WorkflowSampleSystem.Generated.DTO.EmployeeIdentityDTO> justVacationApprover = Framework.Core.PipeObjectExtensions.AsCast<Framework.Core.Just<WorkflowSampleSystem.Generated.DTO.EmployeeIdentityDTO>>(mappingObject.VacationApprover);
            if (!object.ReferenceEquals(justVacationApprover, null))
            {
                if (!object.Equals(justVacationApprover.Value, default(WorkflowSampleSystem.Generated.DTO.EmployeeIdentityDTO)))
                {
                    domainObject.VacationApprover = this.ToEmployee(justVacationApprover.Value);
                }
                else
                {
                    domainObject.VacationApprover = null;
                }
            }
            Framework.Core.Just<System.DateTime> justValidateVirtualProp = Framework.Core.PipeObjectExtensions.AsCast<Framework.Core.Just<System.DateTime>>(mappingObject.ValidateVirtualProp);
            if (!object.ReferenceEquals(justValidateVirtualProp, null))
            {
                domainObject.ValidateVirtualProp = justValidateVirtualProp.Value;
            }
            Framework.Core.Just<Framework.Core.Period> justWorkPeriod = Framework.Core.PipeObjectExtensions.AsCast<Framework.Core.Just<Framework.Core.Period>>(mappingObject.WorkPeriod);
            if (!object.ReferenceEquals(justWorkPeriod, null))
            {
                domainObject.WorkPeriod = justWorkPeriod.Value;
            }
        }
        
        public virtual void MapHRDepartment(WorkflowSampleSystem.Domain.HRDepartment domainObject, WorkflowSampleSystem.Generated.DTO.HRDepartmentVisualDTO mappingObject)
        {
            mappingObject.Name = domainObject.Name;
        }
        
        public virtual void MapHRDepartment(WorkflowSampleSystem.Domain.HRDepartment domainObject, WorkflowSampleSystem.Generated.DTO.HRDepartmentSimpleDTO mappingObject)
        {
            mappingObject.Code = domainObject.Code;
            mappingObject.CodeNative = domainObject.CodeNative;
            mappingObject.ExternalId = domainObject.ExternalId;
            mappingObject.IsLegal = domainObject.IsLegal;
            mappingObject.IsProduction = domainObject.IsProduction;
            mappingObject.Name = domainObject.Name;
            mappingObject.NameNative = domainObject.NameNative;
        }
        
        public virtual void MapHRDepartment(WorkflowSampleSystem.Domain.HRDepartment domainObject, WorkflowSampleSystem.Generated.DTO.HRDepartmentFullDTO mappingObject)
        {
            if (!object.ReferenceEquals(domainObject.Head, null))
            {
                mappingObject.Head = WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToSimpleDTO(domainObject.Head, this);
            }
            else
            {
                mappingObject.Head = null;
            }
            if (!object.ReferenceEquals(domainObject.Location, null))
            {
                mappingObject.Location = WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToSimpleDTO(domainObject.Location, this);
            }
            else
            {
                mappingObject.Location = null;
            }
            if (!object.ReferenceEquals(domainObject.Parent, null))
            {
                mappingObject.Parent = WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToSimpleDTO(domainObject.Parent, this);
            }
            else
            {
                mappingObject.Parent = null;
            }
        }
        
        public virtual void MapHRDepartment(WorkflowSampleSystem.Domain.HRDepartment domainObject, WorkflowSampleSystem.Generated.DTO.HRDepartmentRichDTO mappingObject)
        {
            mappingObject.Children = WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToRichDTOList(domainObject.Children, this);
        }
        
        public virtual void MapHRDepartment(WorkflowSampleSystem.Generated.DTO.HRDepartmentStrictDTO mappingObject, WorkflowSampleSystem.Domain.HRDepartment domainObject)
        {
            domainObject.Version = this.VersionService.GetVersion(mappingObject.Version, domainObject);
            domainObject.Active = mappingObject.Active;
            domainObject.Code = mappingObject.Code;
            domainObject.CodeNative = mappingObject.CodeNative;
            domainObject.ExternalId = mappingObject.ExternalId;
            if (!object.Equals(mappingObject.Head, default(WorkflowSampleSystem.Generated.DTO.EmployeeIdentityDTO)))
            {
                domainObject.Head = this.ToEmployee(mappingObject.Head);
            }
            else
            {
                domainObject.Head = null;
            }
            domainObject.IsLegal = mappingObject.IsLegal;
            domainObject.IsProduction = mappingObject.IsProduction;
            domainObject.Name = mappingObject.Name;
            domainObject.NameNative = mappingObject.NameNative;
            if (!object.Equals(mappingObject.Parent, default(WorkflowSampleSystem.Generated.DTO.HRDepartmentIdentityDTO)))
            {
                domainObject.Parent = this.ToHRDepartment(mappingObject.Parent);
            }
            else
            {
                domainObject.Parent = null;
            }
        }
        
        public virtual void MapLocation(WorkflowSampleSystem.Domain.Location domainObject, WorkflowSampleSystem.Generated.DTO.LocationVisualDTO mappingObject)
        {
            mappingObject.Name = domainObject.Name;
        }
        
        public virtual void MapLocation(WorkflowSampleSystem.Domain.Location domainObject, WorkflowSampleSystem.Generated.DTO.LocationSimpleDTO mappingObject)
        {
            mappingObject.Name = domainObject.Name;
        }
        
        public virtual void MapLocation(WorkflowSampleSystem.Domain.Location domainObject, WorkflowSampleSystem.Generated.DTO.LocationFullDTO mappingObject)
        {
            if (!object.ReferenceEquals(domainObject.Parent, null))
            {
                mappingObject.Parent = WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToSimpleDTO(domainObject.Parent, this);
            }
            else
            {
                mappingObject.Parent = null;
            }
        }
        
        public virtual void MapLocation(WorkflowSampleSystem.Domain.Location domainObject, WorkflowSampleSystem.Generated.DTO.LocationRichDTO mappingObject)
        {
            mappingObject.Children = WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToRichDTOList(domainObject.Children, this);
        }
        
        public virtual void MapLocation(WorkflowSampleSystem.Generated.DTO.LocationStrictDTO mappingObject, WorkflowSampleSystem.Domain.Location domainObject)
        {
            domainObject.Version = this.VersionService.GetVersion(mappingObject.Version, domainObject);
            domainObject.Active = mappingObject.Active;
            domainObject.Name = mappingObject.Name;
            if (!object.Equals(mappingObject.Parent, default(WorkflowSampleSystem.Generated.DTO.LocationIdentityDTO)))
            {
                domainObject.Parent = this.ToLocation(mappingObject.Parent);
            }
            else
            {
                domainObject.Parent = null;
            }
        }
        
        public virtual void MapPersistentDomainObjectBase(WorkflowSampleSystem.Domain.PersistentDomainObjectBase domainObject, WorkflowSampleSystem.Generated.DTO.BasePersistentDTO mappingObject)
        {
            mappingObject.Id = domainObject.Id;
        }
        
        protected virtual void MapToDomainObject<TMappingObject, TDomainObject>(TMappingObject mappingObject, TDomainObject domainObject)
            where TMappingObject : Framework.DomainDriven.IMappingObject<WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService, TDomainObject>
            where TDomainObject : WorkflowSampleSystem.Domain.DomainObjectBase
        {
            mappingObject.MapToDomainObject(this, domainObject);
        }
        
        public virtual WorkflowSampleSystem.Domain.BusinessUnit ToBusinessUnit(WorkflowSampleSystem.Generated.DTO.BusinessUnitIdentityDTO businessUnitIdentityDTO)
        {
            return this.GetById<WorkflowSampleSystem.Domain.BusinessUnit>(businessUnitIdentityDTO.Id);
        }
        
        public virtual WorkflowSampleSystem.Domain.BusinessUnit ToBusinessUnit(WorkflowSampleSystem.Generated.DTO.BusinessUnitStrictDTO businessUnitStrictDTO)
        {
            return this.ToDomainObject<WorkflowSampleSystem.Generated.DTO.BusinessUnitStrictDTO, WorkflowSampleSystem.Domain.BusinessUnit>(businessUnitStrictDTO);
        }
        
        public virtual WorkflowSampleSystem.Domain.BusinessUnit ToBusinessUnit(WorkflowSampleSystem.Generated.DTO.BusinessUnitStrictDTO businessUnitStrictDTO, bool allowCreate)
        {
            if (allowCreate)
            {
                return this.ToDomainObject(businessUnitStrictDTO, () => new WorkflowSampleSystem.Domain.BusinessUnit());
            }
            else
            {
                return this.ToBusinessUnit(businessUnitStrictDTO);
            }
        }
        
        protected virtual TDomainObject ToDomainObject<TMappingObject, TDomainObject>(TMappingObject mappingObject)
            where TMappingObject : Framework.DomainDriven.IMappingObject<WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService, TDomainObject, System.Guid>
            where TDomainObject : WorkflowSampleSystem.Domain.PersistentDomainObjectBase
        {
            TDomainObject domainObject = this.GetById<TDomainObject>(mappingObject.Id, Framework.DomainDriven.BLL.IdCheckMode.CheckAll);
            this.MapToDomainObject(mappingObject, domainObject);
            return domainObject;
        }
        
        protected virtual TDomainObject ToDomainObject<TMappingObject, TDomainObject>(TMappingObject mappingObject, System.Func<TDomainObject> createFunc)
            where TMappingObject : Framework.DomainDriven.IMappingObject<WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService, TDomainObject, System.Guid>
            where TDomainObject : WorkflowSampleSystem.Domain.PersistentDomainObjectBase
        {
            TDomainObject domainObject = this.GetByIdOrCreate<TDomainObject>(mappingObject.Id, createFunc);
            this.MapToDomainObject(mappingObject, domainObject);
            return domainObject;
        }
        
        protected virtual TDomainObject ToDomainObjectBase<TMappingObject, TDomainObject>(TMappingObject mappingObject)
            where TMappingObject : Framework.DomainDriven.IMappingObject<WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService, TDomainObject>
            where TDomainObject : WorkflowSampleSystem.Domain.DomainObjectBase, new ()
        {
            TDomainObject domainObject = new TDomainObject();
            this.MapToDomainObject(mappingObject, domainObject);
            return domainObject;
        }
        
        public virtual WorkflowSampleSystem.Domain.Employee ToEmployee(WorkflowSampleSystem.Generated.DTO.EmployeeIdentityDTO employeeIdentityDTO)
        {
            return this.GetById<WorkflowSampleSystem.Domain.Employee>(employeeIdentityDTO.Id);
        }
        
        public virtual WorkflowSampleSystem.Domain.Employee ToEmployee(WorkflowSampleSystem.Generated.DTO.EmployeeStrictDTO employeeStrictDTO)
        {
            return this.ToDomainObject<WorkflowSampleSystem.Generated.DTO.EmployeeStrictDTO, WorkflowSampleSystem.Domain.Employee>(employeeStrictDTO);
        }
        
        public virtual WorkflowSampleSystem.Domain.Employee ToEmployee(WorkflowSampleSystem.Generated.DTO.EmployeeStrictDTO employeeStrictDTO, bool allowCreate)
        {
            if (allowCreate)
            {
                return this.ToDomainObject(employeeStrictDTO, () => new WorkflowSampleSystem.Domain.Employee());
            }
            else
            {
                return this.ToEmployee(employeeStrictDTO);
            }
        }
        
        public virtual WorkflowSampleSystem.Domain.Employee ToEmployee(WorkflowSampleSystem.Generated.DTO.EmployeeUpdateDTO employeeUpdateDTO)
        {
            return this.ToDomainObject<WorkflowSampleSystem.Generated.DTO.EmployeeUpdateDTO, WorkflowSampleSystem.Domain.Employee>(employeeUpdateDTO);
        }
        
        public virtual WorkflowSampleSystem.Domain.Employee ToEmployee(WorkflowSampleSystem.Generated.DTO.EmployeeUpdateDTO employeeUpdateDTO, bool allowCreate)
        {
            if (allowCreate)
            {
                return this.ToDomainObject(employeeUpdateDTO, () => new WorkflowSampleSystem.Domain.Employee());
            }
            else
            {
                return this.ToEmployee(employeeUpdateDTO);
            }
        }
        
        public virtual WorkflowSampleSystem.Domain.HRDepartment ToHRDepartment(WorkflowSampleSystem.Generated.DTO.HRDepartmentIdentityDTO hRDepartmentIdentityDTO)
        {
            return this.GetById<WorkflowSampleSystem.Domain.HRDepartment>(hRDepartmentIdentityDTO.Id);
        }
        
        public virtual WorkflowSampleSystem.Domain.HRDepartment ToHRDepartment(WorkflowSampleSystem.Generated.DTO.HRDepartmentStrictDTO hRDepartmentStrictDTO)
        {
            return this.ToDomainObject<WorkflowSampleSystem.Generated.DTO.HRDepartmentStrictDTO, WorkflowSampleSystem.Domain.HRDepartment>(hRDepartmentStrictDTO);
        }
        
        public virtual WorkflowSampleSystem.Domain.HRDepartment ToHRDepartment(WorkflowSampleSystem.Generated.DTO.HRDepartmentStrictDTO hRDepartmentStrictDTO, bool allowCreate)
        {
            if (allowCreate)
            {
                return this.ToDomainObject(hRDepartmentStrictDTO, () => new WorkflowSampleSystem.Domain.HRDepartment());
            }
            else
            {
                return this.ToHRDepartment(hRDepartmentStrictDTO);
            }
        }
        
        public virtual WorkflowSampleSystem.Domain.Location ToLocation(WorkflowSampleSystem.Generated.DTO.LocationIdentityDTO locationIdentityDTO)
        {
            return this.GetById<WorkflowSampleSystem.Domain.Location>(locationIdentityDTO.Id);
        }
        
        public virtual WorkflowSampleSystem.Domain.Location ToLocation(WorkflowSampleSystem.Generated.DTO.LocationStrictDTO locationStrictDTO)
        {
            return this.ToDomainObject<WorkflowSampleSystem.Generated.DTO.LocationStrictDTO, WorkflowSampleSystem.Domain.Location>(locationStrictDTO);
        }
        
        public virtual WorkflowSampleSystem.Domain.Location ToLocation(WorkflowSampleSystem.Generated.DTO.LocationStrictDTO locationStrictDTO, bool allowCreate)
        {
            if (allowCreate)
            {
                return this.ToDomainObject(locationStrictDTO, () => new WorkflowSampleSystem.Domain.Location());
            }
            else
            {
                return this.ToLocation(locationStrictDTO);
            }
        }
    }
    
    public partial class WorkflowSampleSystemServerPrimitiveDTOMappingService : WorkflowSampleSystem.Generated.DTO.WorkflowSampleSystemServerPrimitiveDTOMappingServiceBase
    {
        
        public WorkflowSampleSystemServerPrimitiveDTOMappingService(WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext context) : 
                base(context)
        {
        }
    }
}