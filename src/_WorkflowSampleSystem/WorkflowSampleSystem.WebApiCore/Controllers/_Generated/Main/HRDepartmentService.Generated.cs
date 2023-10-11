namespace WorkflowSampleSystem.WebApiCore.Controllers.Main
{
    using WorkflowSampleSystem.Generated.DTO;
    
    
    [Microsoft.AspNetCore.Mvc.ApiControllerAttribute()]
    [Microsoft.AspNetCore.Mvc.ApiVersionAttribute("1.0")]
    [Microsoft.AspNetCore.Mvc.RouteAttribute("api/v{version:apiVersion}/[controller]")]
    public partial class HRDepartmentController : Framework.DomainDriven.WebApiNetCore.ApiControllerBase<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService>>
    {
        
        /// <summary>
        /// Get HRDepartment (FullDTO) by identity
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetFullHRDepartment")]
        public virtual WorkflowSampleSystem.Generated.DTO.HRDepartmentFullDTO GetFullHRDepartment([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] WorkflowSampleSystem.Generated.DTO.HRDepartmentIdentityDTO hRDepartmentIdentity)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetFullHRDepartmentInternal(hRDepartmentIdentity, evaluateData));
        }
        
        /// <summary>
        /// Get HRDepartment (FullDTO) by code
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetFullHRDepartmentByCode")]
        public virtual WorkflowSampleSystem.Generated.DTO.HRDepartmentFullDTO GetFullHRDepartmentByCode([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] string hRDepartmentCode)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetFullHRDepartmentByCodeInternal(hRDepartmentCode, evaluateData));
        }
        
        protected virtual WorkflowSampleSystem.Generated.DTO.HRDepartmentFullDTO GetFullHRDepartmentByCodeInternal(string hRDepartmentCode, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IHRDepartmentBLL bll = evaluateData.Context.Logics.HRDepartmentFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            WorkflowSampleSystem.Domain.HRDepartment domainObject = Framework.DomainDriven.BLL.DefaultDomainBLLBaseExtensions.GetByCode(bll, hRDepartmentCode, true, evaluateData.Context.FetchService.GetContainer<WorkflowSampleSystem.Domain.HRDepartment>(Framework.Transfering.ViewDTOType.FullDTO));
            return WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToFullDTO(domainObject, evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get HRDepartment (FullDTO) by name
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetFullHRDepartmentByName")]
        public virtual WorkflowSampleSystem.Generated.DTO.HRDepartmentFullDTO GetFullHRDepartmentByName([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] string hRDepartmentName)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetFullHRDepartmentByNameInternal(hRDepartmentName, evaluateData));
        }
        
        protected virtual WorkflowSampleSystem.Generated.DTO.HRDepartmentFullDTO GetFullHRDepartmentByNameInternal(string hRDepartmentName, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IHRDepartmentBLL bll = evaluateData.Context.Logics.HRDepartmentFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            WorkflowSampleSystem.Domain.HRDepartment domainObject = Framework.DomainDriven.BLL.DefaultDomainBLLBaseExtensions.GetByName(bll, hRDepartmentName, true, evaluateData.Context.FetchService.GetContainer<WorkflowSampleSystem.Domain.HRDepartment>(Framework.Transfering.ViewDTOType.FullDTO));
            return WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToFullDTO(domainObject, evaluateData.MappingService);
        }
        
        protected virtual WorkflowSampleSystem.Generated.DTO.HRDepartmentFullDTO GetFullHRDepartmentInternal(WorkflowSampleSystem.Generated.DTO.HRDepartmentIdentityDTO hRDepartmentIdentity, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IHRDepartmentBLL bll = evaluateData.Context.Logics.HRDepartmentFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            WorkflowSampleSystem.Domain.HRDepartment domainObject = bll.GetById(hRDepartmentIdentity.Id, true, evaluateData.Context.FetchService.GetContainer<WorkflowSampleSystem.Domain.HRDepartment>(Framework.Transfering.ViewDTOType.FullDTO));
            return WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToFullDTO(domainObject, evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get full list of HRDepartments (FullDTO)
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetFullHRDepartments")]
        public virtual System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Generated.DTO.HRDepartmentFullDTO> GetFullHRDepartments()
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetFullHRDepartmentsInternal(evaluateData));
        }
        
        /// <summary>
        /// Get HRDepartments (FullDTO) by idents
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetFullHRDepartmentsByIdents")]
        public virtual System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Generated.DTO.HRDepartmentFullDTO> GetFullHRDepartmentsByIdents([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] WorkflowSampleSystem.Generated.DTO.HRDepartmentIdentityDTO[] hRDepartmentIdents)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetFullHRDepartmentsByIdentsInternal(hRDepartmentIdents, evaluateData));
        }
        
        protected virtual System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Generated.DTO.HRDepartmentFullDTO> GetFullHRDepartmentsByIdentsInternal(WorkflowSampleSystem.Generated.DTO.HRDepartmentIdentityDTO[] hRDepartmentIdents, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IHRDepartmentBLL bll = evaluateData.Context.Logics.HRDepartmentFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToFullDTOList(bll.GetListByIdents(hRDepartmentIdents, evaluateData.Context.FetchService.GetContainer<WorkflowSampleSystem.Domain.HRDepartment>(Framework.Transfering.ViewDTOType.FullDTO)), evaluateData.MappingService);
        }
        
        protected virtual System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Generated.DTO.HRDepartmentFullDTO> GetFullHRDepartmentsInternal(Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IHRDepartmentBLL bll = evaluateData.Context.Logics.HRDepartmentFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToFullDTOList(bll.GetFullList(evaluateData.Context.FetchService.GetContainer<WorkflowSampleSystem.Domain.HRDepartment>(Framework.Transfering.ViewDTOType.FullDTO)), evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get HRDepartment (RichDTO) by identity
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetRichHRDepartment")]
        public virtual WorkflowSampleSystem.Generated.DTO.HRDepartmentRichDTO GetRichHRDepartment([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] WorkflowSampleSystem.Generated.DTO.HRDepartmentIdentityDTO hRDepartmentIdentity)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetRichHRDepartmentInternal(hRDepartmentIdentity, evaluateData));
        }
        
        /// <summary>
        /// Get HRDepartment (RichDTO) by code
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetRichHRDepartmentByCode")]
        public virtual WorkflowSampleSystem.Generated.DTO.HRDepartmentRichDTO GetRichHRDepartmentByCode([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] string hRDepartmentCode)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetRichHRDepartmentByCodeInternal(hRDepartmentCode, evaluateData));
        }
        
        protected virtual WorkflowSampleSystem.Generated.DTO.HRDepartmentRichDTO GetRichHRDepartmentByCodeInternal(string hRDepartmentCode, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IHRDepartmentBLL bll = evaluateData.Context.Logics.HRDepartmentFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            WorkflowSampleSystem.Domain.HRDepartment domainObject = Framework.DomainDriven.BLL.DefaultDomainBLLBaseExtensions.GetByCode(bll, hRDepartmentCode, true, evaluateData.Context.FetchService.GetContainer<WorkflowSampleSystem.Domain.HRDepartment>(Framework.Transfering.ViewDTOType.FullDTO));
            return WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToRichDTO(domainObject, evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get HRDepartment (RichDTO) by name
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetRichHRDepartmentByName")]
        public virtual WorkflowSampleSystem.Generated.DTO.HRDepartmentRichDTO GetRichHRDepartmentByName([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] string hRDepartmentName)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetRichHRDepartmentByNameInternal(hRDepartmentName, evaluateData));
        }
        
        protected virtual WorkflowSampleSystem.Generated.DTO.HRDepartmentRichDTO GetRichHRDepartmentByNameInternal(string hRDepartmentName, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IHRDepartmentBLL bll = evaluateData.Context.Logics.HRDepartmentFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            WorkflowSampleSystem.Domain.HRDepartment domainObject = Framework.DomainDriven.BLL.DefaultDomainBLLBaseExtensions.GetByName(bll, hRDepartmentName, true, evaluateData.Context.FetchService.GetContainer<WorkflowSampleSystem.Domain.HRDepartment>(Framework.Transfering.ViewDTOType.FullDTO));
            return WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToRichDTO(domainObject, evaluateData.MappingService);
        }
        
        protected virtual WorkflowSampleSystem.Generated.DTO.HRDepartmentRichDTO GetRichHRDepartmentInternal(WorkflowSampleSystem.Generated.DTO.HRDepartmentIdentityDTO hRDepartmentIdentity, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IHRDepartmentBLL bll = evaluateData.Context.Logics.HRDepartmentFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            WorkflowSampleSystem.Domain.HRDepartment domainObject = bll.GetById(hRDepartmentIdentity.Id, true, evaluateData.Context.FetchService.GetContainer<WorkflowSampleSystem.Domain.HRDepartment>(Framework.Transfering.ViewDTOType.FullDTO));
            return WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToRichDTO(domainObject, evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get HRDepartment (SimpleDTO) by identity
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetSimpleHRDepartment")]
        public virtual WorkflowSampleSystem.Generated.DTO.HRDepartmentSimpleDTO GetSimpleHRDepartment([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] WorkflowSampleSystem.Generated.DTO.HRDepartmentIdentityDTO hRDepartmentIdentity)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetSimpleHRDepartmentInternal(hRDepartmentIdentity, evaluateData));
        }
        
        /// <summary>
        /// Get HRDepartment (SimpleDTO) by code
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetSimpleHRDepartmentByCode")]
        public virtual WorkflowSampleSystem.Generated.DTO.HRDepartmentSimpleDTO GetSimpleHRDepartmentByCode([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] string hRDepartmentCode)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetSimpleHRDepartmentByCodeInternal(hRDepartmentCode, evaluateData));
        }
        
        protected virtual WorkflowSampleSystem.Generated.DTO.HRDepartmentSimpleDTO GetSimpleHRDepartmentByCodeInternal(string hRDepartmentCode, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IHRDepartmentBLL bll = evaluateData.Context.Logics.HRDepartmentFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            WorkflowSampleSystem.Domain.HRDepartment domainObject = Framework.DomainDriven.BLL.DefaultDomainBLLBaseExtensions.GetByCode(bll, hRDepartmentCode, true, evaluateData.Context.FetchService.GetContainer<WorkflowSampleSystem.Domain.HRDepartment>(Framework.Transfering.ViewDTOType.SimpleDTO));
            return WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToSimpleDTO(domainObject, evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get HRDepartment (SimpleDTO) by name
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetSimpleHRDepartmentByName")]
        public virtual WorkflowSampleSystem.Generated.DTO.HRDepartmentSimpleDTO GetSimpleHRDepartmentByName([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] string hRDepartmentName)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetSimpleHRDepartmentByNameInternal(hRDepartmentName, evaluateData));
        }
        
        protected virtual WorkflowSampleSystem.Generated.DTO.HRDepartmentSimpleDTO GetSimpleHRDepartmentByNameInternal(string hRDepartmentName, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IHRDepartmentBLL bll = evaluateData.Context.Logics.HRDepartmentFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            WorkflowSampleSystem.Domain.HRDepartment domainObject = Framework.DomainDriven.BLL.DefaultDomainBLLBaseExtensions.GetByName(bll, hRDepartmentName, true, evaluateData.Context.FetchService.GetContainer<WorkflowSampleSystem.Domain.HRDepartment>(Framework.Transfering.ViewDTOType.SimpleDTO));
            return WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToSimpleDTO(domainObject, evaluateData.MappingService);
        }
        
        protected virtual WorkflowSampleSystem.Generated.DTO.HRDepartmentSimpleDTO GetSimpleHRDepartmentInternal(WorkflowSampleSystem.Generated.DTO.HRDepartmentIdentityDTO hRDepartmentIdentity, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IHRDepartmentBLL bll = evaluateData.Context.Logics.HRDepartmentFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            WorkflowSampleSystem.Domain.HRDepartment domainObject = bll.GetById(hRDepartmentIdentity.Id, true, evaluateData.Context.FetchService.GetContainer<WorkflowSampleSystem.Domain.HRDepartment>(Framework.Transfering.ViewDTOType.SimpleDTO));
            return WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToSimpleDTO(domainObject, evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get full list of HRDepartments (SimpleDTO)
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetSimpleHRDepartments")]
        public virtual System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Generated.DTO.HRDepartmentSimpleDTO> GetSimpleHRDepartments()
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetSimpleHRDepartmentsInternal(evaluateData));
        }
        
        /// <summary>
        /// Get HRDepartments (SimpleDTO) by idents
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetSimpleHRDepartmentsByIdents")]
        public virtual System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Generated.DTO.HRDepartmentSimpleDTO> GetSimpleHRDepartmentsByIdents([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] WorkflowSampleSystem.Generated.DTO.HRDepartmentIdentityDTO[] hRDepartmentIdents)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetSimpleHRDepartmentsByIdentsInternal(hRDepartmentIdents, evaluateData));
        }
        
        protected virtual System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Generated.DTO.HRDepartmentSimpleDTO> GetSimpleHRDepartmentsByIdentsInternal(WorkflowSampleSystem.Generated.DTO.HRDepartmentIdentityDTO[] hRDepartmentIdents, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IHRDepartmentBLL bll = evaluateData.Context.Logics.HRDepartmentFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToSimpleDTOList(bll.GetListByIdents(hRDepartmentIdents, evaluateData.Context.FetchService.GetContainer<WorkflowSampleSystem.Domain.HRDepartment>(Framework.Transfering.ViewDTOType.SimpleDTO)), evaluateData.MappingService);
        }
        
        protected virtual System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Generated.DTO.HRDepartmentSimpleDTO> GetSimpleHRDepartmentsInternal(Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IHRDepartmentBLL bll = evaluateData.Context.Logics.HRDepartmentFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToSimpleDTOList(bll.GetFullList(evaluateData.Context.FetchService.GetContainer<WorkflowSampleSystem.Domain.HRDepartment>(Framework.Transfering.ViewDTOType.SimpleDTO)), evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get HRDepartment (VisualDTO) by identity
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetVisualHRDepartment")]
        public virtual WorkflowSampleSystem.Generated.DTO.HRDepartmentVisualDTO GetVisualHRDepartment([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] WorkflowSampleSystem.Generated.DTO.HRDepartmentIdentityDTO hRDepartmentIdentity)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetVisualHRDepartmentInternal(hRDepartmentIdentity, evaluateData));
        }
        
        /// <summary>
        /// Get HRDepartment (VisualDTO) by code
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetVisualHRDepartmentByCode")]
        public virtual WorkflowSampleSystem.Generated.DTO.HRDepartmentVisualDTO GetVisualHRDepartmentByCode([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] string hRDepartmentCode)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetVisualHRDepartmentByCodeInternal(hRDepartmentCode, evaluateData));
        }
        
        protected virtual WorkflowSampleSystem.Generated.DTO.HRDepartmentVisualDTO GetVisualHRDepartmentByCodeInternal(string hRDepartmentCode, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IHRDepartmentBLL bll = evaluateData.Context.Logics.HRDepartmentFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            WorkflowSampleSystem.Domain.HRDepartment domainObject = Framework.DomainDriven.BLL.DefaultDomainBLLBaseExtensions.GetByCode(bll, hRDepartmentCode, true, evaluateData.Context.FetchService.GetContainer<WorkflowSampleSystem.Domain.HRDepartment>(Framework.Transfering.ViewDTOType.VisualDTO));
            return WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToVisualDTO(domainObject, evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get HRDepartment (VisualDTO) by name
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetVisualHRDepartmentByName")]
        public virtual WorkflowSampleSystem.Generated.DTO.HRDepartmentVisualDTO GetVisualHRDepartmentByName([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] string hRDepartmentName)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetVisualHRDepartmentByNameInternal(hRDepartmentName, evaluateData));
        }
        
        protected virtual WorkflowSampleSystem.Generated.DTO.HRDepartmentVisualDTO GetVisualHRDepartmentByNameInternal(string hRDepartmentName, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IHRDepartmentBLL bll = evaluateData.Context.Logics.HRDepartmentFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            WorkflowSampleSystem.Domain.HRDepartment domainObject = Framework.DomainDriven.BLL.DefaultDomainBLLBaseExtensions.GetByName(bll, hRDepartmentName, true, evaluateData.Context.FetchService.GetContainer<WorkflowSampleSystem.Domain.HRDepartment>(Framework.Transfering.ViewDTOType.VisualDTO));
            return WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToVisualDTO(domainObject, evaluateData.MappingService);
        }
        
        protected virtual WorkflowSampleSystem.Generated.DTO.HRDepartmentVisualDTO GetVisualHRDepartmentInternal(WorkflowSampleSystem.Generated.DTO.HRDepartmentIdentityDTO hRDepartmentIdentity, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IHRDepartmentBLL bll = evaluateData.Context.Logics.HRDepartmentFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            WorkflowSampleSystem.Domain.HRDepartment domainObject = bll.GetById(hRDepartmentIdentity.Id, true, evaluateData.Context.FetchService.GetContainer<WorkflowSampleSystem.Domain.HRDepartment>(Framework.Transfering.ViewDTOType.VisualDTO));
            return WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToVisualDTO(domainObject, evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get full list of HRDepartments (VisualDTO)
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetVisualHRDepartments")]
        public virtual System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Generated.DTO.HRDepartmentVisualDTO> GetVisualHRDepartments()
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetVisualHRDepartmentsInternal(evaluateData));
        }
        
        /// <summary>
        /// Get HRDepartments (VisualDTO) by idents
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetVisualHRDepartmentsByIdents")]
        public virtual System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Generated.DTO.HRDepartmentVisualDTO> GetVisualHRDepartmentsByIdents([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] WorkflowSampleSystem.Generated.DTO.HRDepartmentIdentityDTO[] hRDepartmentIdents)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetVisualHRDepartmentsByIdentsInternal(hRDepartmentIdents, evaluateData));
        }
        
        protected virtual System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Generated.DTO.HRDepartmentVisualDTO> GetVisualHRDepartmentsByIdentsInternal(WorkflowSampleSystem.Generated.DTO.HRDepartmentIdentityDTO[] hRDepartmentIdents, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IHRDepartmentBLL bll = evaluateData.Context.Logics.HRDepartmentFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToVisualDTOList(bll.GetListByIdents(hRDepartmentIdents, evaluateData.Context.FetchService.GetContainer<WorkflowSampleSystem.Domain.HRDepartment>(Framework.Transfering.ViewDTOType.VisualDTO)), evaluateData.MappingService);
        }
        
        protected virtual System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Generated.DTO.HRDepartmentVisualDTO> GetVisualHRDepartmentsInternal(Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IHRDepartmentBLL bll = evaluateData.Context.Logics.HRDepartmentFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToVisualDTOList(bll.GetFullList(evaluateData.Context.FetchService.GetContainer<WorkflowSampleSystem.Domain.HRDepartment>(Framework.Transfering.ViewDTOType.VisualDTO)), evaluateData.MappingService);
        }
        
        /// <summary>
        /// Remove HRDepartment
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("RemoveHRDepartment")]
        public virtual void RemoveHRDepartment([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] WorkflowSampleSystem.Generated.DTO.HRDepartmentIdentityDTO hRDepartmentIdent)
        {
            this.Evaluate(Framework.DomainDriven.DBSessionMode.Write, evaluateData => this.RemoveHRDepartmentInternal(hRDepartmentIdent, evaluateData));
        }
        
        protected virtual void RemoveHRDepartmentInternal(WorkflowSampleSystem.Generated.DTO.HRDepartmentIdentityDTO hRDepartmentIdent, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IHRDepartmentBLL bll = evaluateData.Context.Logics.HRDepartmentFactory.Create(Framework.SecuritySystem.BLLSecurityMode.Edit);
            this.RemoveHRDepartmentInternal(hRDepartmentIdent, evaluateData, bll);
        }
        
        protected virtual void RemoveHRDepartmentInternal(WorkflowSampleSystem.Generated.DTO.HRDepartmentIdentityDTO hRDepartmentIdent, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData, WorkflowSampleSystem.BLL.IHRDepartmentBLL bll)
        {
            WorkflowSampleSystem.Domain.HRDepartment domainObject = bll.GetById(hRDepartmentIdent.Id, true);
            bll.Remove(domainObject);
        }
        
        /// <summary>
        /// Save HRDepartments
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("SaveHRDepartment")]
        public virtual WorkflowSampleSystem.Generated.DTO.HRDepartmentIdentityDTO SaveHRDepartment([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] WorkflowSampleSystem.Generated.DTO.HRDepartmentStrictDTO hRDepartmentStrict)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Write, evaluateData => this.SaveHRDepartmentInternal(hRDepartmentStrict, evaluateData));
        }
        
        protected virtual WorkflowSampleSystem.Generated.DTO.HRDepartmentIdentityDTO SaveHRDepartmentInternal(WorkflowSampleSystem.Generated.DTO.HRDepartmentStrictDTO hRDepartmentStrict, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IHRDepartmentBLL bll = evaluateData.Context.Logics.HRDepartmentFactory.Create(Framework.SecuritySystem.BLLSecurityMode.Edit);
            return this.SaveHRDepartmentInternal(hRDepartmentStrict, evaluateData, bll);
        }
        
        protected virtual WorkflowSampleSystem.Generated.DTO.HRDepartmentIdentityDTO SaveHRDepartmentInternal(WorkflowSampleSystem.Generated.DTO.HRDepartmentStrictDTO hRDepartmentStrict, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData, WorkflowSampleSystem.BLL.IHRDepartmentBLL bll)
        {
            WorkflowSampleSystem.Domain.HRDepartment domainObject = bll.GetById(hRDepartmentStrict.Id, true);
            hRDepartmentStrict.MapToDomainObject(evaluateData.MappingService, domainObject);
            bll.Save(domainObject);
            return WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToIdentityDTO(domainObject);
        }
    }
}
