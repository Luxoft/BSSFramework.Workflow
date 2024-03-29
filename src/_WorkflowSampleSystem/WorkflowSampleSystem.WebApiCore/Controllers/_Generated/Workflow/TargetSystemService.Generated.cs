﻿namespace Workflow.WebApi.Controllers
{
    using Framework.Workflow.Generated.DTO;
    
    
    [Microsoft.AspNetCore.Mvc.ApiControllerAttribute()]
    [Microsoft.AspNetCore.Mvc.ApiVersionAttribute("1.0")]
    [Microsoft.AspNetCore.Mvc.RouteAttribute("workflowApi/v{version:apiVersion}/[controller]")]
    public partial class TargetSystemController : Framework.DomainDriven.WebApiNetCore.ApiControllerBase<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService>>
    {
        
        /// <summary>
        /// Get TargetSystem (FullDTO) by identity
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetFullTargetSystem")]
        public virtual Framework.Workflow.Generated.DTO.TargetSystemFullDTO GetFullTargetSystem([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] Framework.Workflow.Generated.DTO.TargetSystemIdentityDTO targetSystemIdentity)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetFullTargetSystemInternal(targetSystemIdentity, evaluateData));
        }
        
        /// <summary>
        /// Get TargetSystem (FullDTO) by name
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetFullTargetSystemByName")]
        public virtual Framework.Workflow.Generated.DTO.TargetSystemFullDTO GetFullTargetSystemByName([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] string targetSystemName)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetFullTargetSystemByNameInternal(targetSystemName, evaluateData));
        }
        
        protected virtual Framework.Workflow.Generated.DTO.TargetSystemFullDTO GetFullTargetSystemByNameInternal(string targetSystemName, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.ITargetSystemBLL bll = evaluateData.Context.Logics.TargetSystemFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            Framework.Workflow.Domain.Definition.TargetSystem domainObject = Framework.DomainDriven.BLL.DefaultDomainBLLBaseExtensions.GetByName(bll, targetSystemName, true, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.TargetSystem>(Framework.Transfering.ViewDTOType.FullDTO));
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToFullDTO(domainObject, evaluateData.MappingService);
        }
        
        protected virtual Framework.Workflow.Generated.DTO.TargetSystemFullDTO GetFullTargetSystemInternal(Framework.Workflow.Generated.DTO.TargetSystemIdentityDTO targetSystemIdentity, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.ITargetSystemBLL bll = evaluateData.Context.Logics.TargetSystemFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            Framework.Workflow.Domain.Definition.TargetSystem domainObject = bll.GetById(targetSystemIdentity.Id, true, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.TargetSystem>(Framework.Transfering.ViewDTOType.FullDTO));
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToFullDTO(domainObject, evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get full list of TargetSystems (FullDTO)
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetFullTargetSystems")]
        public virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.TargetSystemFullDTO> GetFullTargetSystems()
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetFullTargetSystemsInternal(evaluateData));
        }
        
        /// <summary>
        /// Get TargetSystems (FullDTO) by idents
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetFullTargetSystemsByIdents")]
        public virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.TargetSystemFullDTO> GetFullTargetSystemsByIdents([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] Framework.Workflow.Generated.DTO.TargetSystemIdentityDTO[] targetSystemIdents)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetFullTargetSystemsByIdentsInternal(targetSystemIdents, evaluateData));
        }
        
        protected virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.TargetSystemFullDTO> GetFullTargetSystemsByIdentsInternal(Framework.Workflow.Generated.DTO.TargetSystemIdentityDTO[] targetSystemIdents, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.ITargetSystemBLL bll = evaluateData.Context.Logics.TargetSystemFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToFullDTOList(bll.GetListByIdents(targetSystemIdents, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.TargetSystem>(Framework.Transfering.ViewDTOType.FullDTO)), evaluateData.MappingService);
        }
        
        protected virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.TargetSystemFullDTO> GetFullTargetSystemsInternal(Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.ITargetSystemBLL bll = evaluateData.Context.Logics.TargetSystemFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToFullDTOList(bll.GetFullList(evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.TargetSystem>(Framework.Transfering.ViewDTOType.FullDTO)), evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get TargetSystem (RichDTO) by identity
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetRichTargetSystem")]
        public virtual Framework.Workflow.Generated.DTO.TargetSystemRichDTO GetRichTargetSystem([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] Framework.Workflow.Generated.DTO.TargetSystemIdentityDTO targetSystemIdentity)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetRichTargetSystemInternal(targetSystemIdentity, evaluateData));
        }
        
        /// <summary>
        /// Get TargetSystem (RichDTO) by name
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetRichTargetSystemByName")]
        public virtual Framework.Workflow.Generated.DTO.TargetSystemRichDTO GetRichTargetSystemByName([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] string targetSystemName)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetRichTargetSystemByNameInternal(targetSystemName, evaluateData));
        }
        
        protected virtual Framework.Workflow.Generated.DTO.TargetSystemRichDTO GetRichTargetSystemByNameInternal(string targetSystemName, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.ITargetSystemBLL bll = evaluateData.Context.Logics.TargetSystemFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            Framework.Workflow.Domain.Definition.TargetSystem domainObject = Framework.DomainDriven.BLL.DefaultDomainBLLBaseExtensions.GetByName(bll, targetSystemName, true, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.TargetSystem>(Framework.Transfering.ViewDTOType.FullDTO));
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToRichDTO(domainObject, evaluateData.MappingService);
        }
        
        protected virtual Framework.Workflow.Generated.DTO.TargetSystemRichDTO GetRichTargetSystemInternal(Framework.Workflow.Generated.DTO.TargetSystemIdentityDTO targetSystemIdentity, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.ITargetSystemBLL bll = evaluateData.Context.Logics.TargetSystemFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            Framework.Workflow.Domain.Definition.TargetSystem domainObject = bll.GetById(targetSystemIdentity.Id, true, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.TargetSystem>(Framework.Transfering.ViewDTOType.FullDTO));
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToRichDTO(domainObject, evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get TargetSystem (SimpleDTO) by identity
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetSimpleTargetSystem")]
        public virtual Framework.Workflow.Generated.DTO.TargetSystemSimpleDTO GetSimpleTargetSystem([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] Framework.Workflow.Generated.DTO.TargetSystemIdentityDTO targetSystemIdentity)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetSimpleTargetSystemInternal(targetSystemIdentity, evaluateData));
        }
        
        /// <summary>
        /// Get TargetSystem (SimpleDTO) by name
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetSimpleTargetSystemByName")]
        public virtual Framework.Workflow.Generated.DTO.TargetSystemSimpleDTO GetSimpleTargetSystemByName([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] string targetSystemName)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetSimpleTargetSystemByNameInternal(targetSystemName, evaluateData));
        }
        
        protected virtual Framework.Workflow.Generated.DTO.TargetSystemSimpleDTO GetSimpleTargetSystemByNameInternal(string targetSystemName, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.ITargetSystemBLL bll = evaluateData.Context.Logics.TargetSystemFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            Framework.Workflow.Domain.Definition.TargetSystem domainObject = Framework.DomainDriven.BLL.DefaultDomainBLLBaseExtensions.GetByName(bll, targetSystemName, true, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.TargetSystem>(Framework.Transfering.ViewDTOType.SimpleDTO));
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToSimpleDTO(domainObject, evaluateData.MappingService);
        }
        
        protected virtual Framework.Workflow.Generated.DTO.TargetSystemSimpleDTO GetSimpleTargetSystemInternal(Framework.Workflow.Generated.DTO.TargetSystemIdentityDTO targetSystemIdentity, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.ITargetSystemBLL bll = evaluateData.Context.Logics.TargetSystemFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            Framework.Workflow.Domain.Definition.TargetSystem domainObject = bll.GetById(targetSystemIdentity.Id, true, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.TargetSystem>(Framework.Transfering.ViewDTOType.SimpleDTO));
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToSimpleDTO(domainObject, evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get full list of TargetSystems (SimpleDTO)
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetSimpleTargetSystems")]
        public virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.TargetSystemSimpleDTO> GetSimpleTargetSystems()
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetSimpleTargetSystemsInternal(evaluateData));
        }
        
        /// <summary>
        /// Get TargetSystems (SimpleDTO) by idents
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetSimpleTargetSystemsByIdents")]
        public virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.TargetSystemSimpleDTO> GetSimpleTargetSystemsByIdents([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] Framework.Workflow.Generated.DTO.TargetSystemIdentityDTO[] targetSystemIdents)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetSimpleTargetSystemsByIdentsInternal(targetSystemIdents, evaluateData));
        }
        
        protected virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.TargetSystemSimpleDTO> GetSimpleTargetSystemsByIdentsInternal(Framework.Workflow.Generated.DTO.TargetSystemIdentityDTO[] targetSystemIdents, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.ITargetSystemBLL bll = evaluateData.Context.Logics.TargetSystemFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToSimpleDTOList(bll.GetListByIdents(targetSystemIdents, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.TargetSystem>(Framework.Transfering.ViewDTOType.SimpleDTO)), evaluateData.MappingService);
        }
        
        protected virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.TargetSystemSimpleDTO> GetSimpleTargetSystemsInternal(Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.ITargetSystemBLL bll = evaluateData.Context.Logics.TargetSystemFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToSimpleDTOList(bll.GetFullList(evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.TargetSystem>(Framework.Transfering.ViewDTOType.SimpleDTO)), evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get TargetSystem (VisualDTO) by identity
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetVisualTargetSystem")]
        public virtual Framework.Workflow.Generated.DTO.TargetSystemVisualDTO GetVisualTargetSystem([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] Framework.Workflow.Generated.DTO.TargetSystemIdentityDTO targetSystemIdentity)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetVisualTargetSystemInternal(targetSystemIdentity, evaluateData));
        }
        
        /// <summary>
        /// Get TargetSystem (VisualDTO) by name
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetVisualTargetSystemByName")]
        public virtual Framework.Workflow.Generated.DTO.TargetSystemVisualDTO GetVisualTargetSystemByName([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] string targetSystemName)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetVisualTargetSystemByNameInternal(targetSystemName, evaluateData));
        }
        
        protected virtual Framework.Workflow.Generated.DTO.TargetSystemVisualDTO GetVisualTargetSystemByNameInternal(string targetSystemName, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.ITargetSystemBLL bll = evaluateData.Context.Logics.TargetSystemFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            Framework.Workflow.Domain.Definition.TargetSystem domainObject = Framework.DomainDriven.BLL.DefaultDomainBLLBaseExtensions.GetByName(bll, targetSystemName, true, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.TargetSystem>(Framework.Transfering.ViewDTOType.VisualDTO));
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToVisualDTO(domainObject, evaluateData.MappingService);
        }
        
        protected virtual Framework.Workflow.Generated.DTO.TargetSystemVisualDTO GetVisualTargetSystemInternal(Framework.Workflow.Generated.DTO.TargetSystemIdentityDTO targetSystemIdentity, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.ITargetSystemBLL bll = evaluateData.Context.Logics.TargetSystemFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            Framework.Workflow.Domain.Definition.TargetSystem domainObject = bll.GetById(targetSystemIdentity.Id, true, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.TargetSystem>(Framework.Transfering.ViewDTOType.VisualDTO));
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToVisualDTO(domainObject, evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get full list of TargetSystems (VisualDTO)
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetVisualTargetSystems")]
        public virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.TargetSystemVisualDTO> GetVisualTargetSystems()
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetVisualTargetSystemsInternal(evaluateData));
        }
        
        /// <summary>
        /// Get TargetSystems (VisualDTO) by idents
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetVisualTargetSystemsByIdents")]
        public virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.TargetSystemVisualDTO> GetVisualTargetSystemsByIdents([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] Framework.Workflow.Generated.DTO.TargetSystemIdentityDTO[] targetSystemIdents)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetVisualTargetSystemsByIdentsInternal(targetSystemIdents, evaluateData));
        }
        
        protected virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.TargetSystemVisualDTO> GetVisualTargetSystemsByIdentsInternal(Framework.Workflow.Generated.DTO.TargetSystemIdentityDTO[] targetSystemIdents, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.ITargetSystemBLL bll = evaluateData.Context.Logics.TargetSystemFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToVisualDTOList(bll.GetListByIdents(targetSystemIdents, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.TargetSystem>(Framework.Transfering.ViewDTOType.VisualDTO)), evaluateData.MappingService);
        }
        
        protected virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.TargetSystemVisualDTO> GetVisualTargetSystemsInternal(Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.ITargetSystemBLL bll = evaluateData.Context.Logics.TargetSystemFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToVisualDTOList(bll.GetFullList(evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.TargetSystem>(Framework.Transfering.ViewDTOType.VisualDTO)), evaluateData.MappingService);
        }
    }
}
