namespace Workflow.WebApi.Controllers
{
    using Framework.Workflow.Generated.DTO;
    
    
    [Microsoft.AspNetCore.Mvc.ApiControllerAttribute()]
    [Microsoft.AspNetCore.Mvc.ApiVersionAttribute("1.0")]
    [Microsoft.AspNetCore.Mvc.RouteAttribute("workflowApi/v{version:apiVersion}/[controller]")]
    public partial class WorkflowLambdaController : Framework.DomainDriven.WebApiNetCore.ApiControllerBase<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService>>
    {
        
        /// <summary>
        /// Get WorkflowLambda (FullDTO) by identity
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetFullWorkflowLambda")]
        public virtual Framework.Workflow.Generated.DTO.WorkflowLambdaFullDTO GetFullWorkflowLambda([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] Framework.Workflow.Generated.DTO.WorkflowLambdaIdentityDTO workflowLambdaIdentity)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetFullWorkflowLambdaInternal(workflowLambdaIdentity, evaluateData));
        }
        
        /// <summary>
        /// Get WorkflowLambda (FullDTO) by name
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetFullWorkflowLambdaByName")]
        public virtual Framework.Workflow.Generated.DTO.WorkflowLambdaFullDTO GetFullWorkflowLambdaByName([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] string workflowLambdaName)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetFullWorkflowLambdaByNameInternal(workflowLambdaName, evaluateData));
        }
        
        protected virtual Framework.Workflow.Generated.DTO.WorkflowLambdaFullDTO GetFullWorkflowLambdaByNameInternal(string workflowLambdaName, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.IWorkflowLambdaBLL bll = evaluateData.Context.Logics.WorkflowLambdaFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            Framework.Workflow.Domain.Definition.WorkflowLambda domainObject = Framework.DomainDriven.BLL.DefaultDomainBLLBaseExtensions.GetByName(bll, workflowLambdaName, true, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.WorkflowLambda>(Framework.Transfering.ViewDTOType.FullDTO));
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToFullDTO(domainObject, evaluateData.MappingService);
        }
        
        protected virtual Framework.Workflow.Generated.DTO.WorkflowLambdaFullDTO GetFullWorkflowLambdaInternal(Framework.Workflow.Generated.DTO.WorkflowLambdaIdentityDTO workflowLambdaIdentity, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.IWorkflowLambdaBLL bll = evaluateData.Context.Logics.WorkflowLambdaFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            Framework.Workflow.Domain.Definition.WorkflowLambda domainObject = bll.GetById(workflowLambdaIdentity.Id, true, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.WorkflowLambda>(Framework.Transfering.ViewDTOType.FullDTO));
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToFullDTO(domainObject, evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get full list of WorkflowLambdas (FullDTO)
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetFullWorkflowLambdas")]
        public virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.WorkflowLambdaFullDTO> GetFullWorkflowLambdas()
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetFullWorkflowLambdasInternal(evaluateData));
        }
        
        /// <summary>
        /// Get WorkflowLambdas (FullDTO) by idents
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetFullWorkflowLambdasByIdents")]
        public virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.WorkflowLambdaFullDTO> GetFullWorkflowLambdasByIdents([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] Framework.Workflow.Generated.DTO.WorkflowLambdaIdentityDTO[] workflowLambdaIdents)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetFullWorkflowLambdasByIdentsInternal(workflowLambdaIdents, evaluateData));
        }
        
        protected virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.WorkflowLambdaFullDTO> GetFullWorkflowLambdasByIdentsInternal(Framework.Workflow.Generated.DTO.WorkflowLambdaIdentityDTO[] workflowLambdaIdents, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.IWorkflowLambdaBLL bll = evaluateData.Context.Logics.WorkflowLambdaFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToFullDTOList(bll.GetListByIdents(workflowLambdaIdents, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.WorkflowLambda>(Framework.Transfering.ViewDTOType.FullDTO)), evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get WorkflowLambdas (FullDTO) by filter (Framework.Workflow.Domain.WorkflowLambdaRootFilterModel)
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetFullWorkflowLambdasByRootFilter")]
        public virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.WorkflowLambdaFullDTO> GetFullWorkflowLambdasByRootFilter([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] Framework.Workflow.Generated.DTO.WorkflowLambdaRootFilterModelStrictDTO filter)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetFullWorkflowLambdasByRootFilterInternal(filter, evaluateData));
        }
        
        protected virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.WorkflowLambdaFullDTO> GetFullWorkflowLambdasByRootFilterInternal(Framework.Workflow.Generated.DTO.WorkflowLambdaRootFilterModelStrictDTO filter, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.IWorkflowLambdaBLL bll = evaluateData.Context.Logics.WorkflowLambdaFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            Framework.Workflow.Domain.WorkflowLambdaRootFilterModel typedFilter = filter.ToDomainObject(evaluateData.MappingService);
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToFullDTOList(bll.GetListBy(typedFilter, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.WorkflowLambda>(Framework.Transfering.ViewDTOType.FullDTO)), evaluateData.MappingService);
        }
        
        protected virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.WorkflowLambdaFullDTO> GetFullWorkflowLambdasInternal(Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.IWorkflowLambdaBLL bll = evaluateData.Context.Logics.WorkflowLambdaFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToFullDTOList(bll.GetFullList(evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.WorkflowLambda>(Framework.Transfering.ViewDTOType.FullDTO)), evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get WorkflowLambda (RichDTO) by identity
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetRichWorkflowLambda")]
        public virtual Framework.Workflow.Generated.DTO.WorkflowLambdaRichDTO GetRichWorkflowLambda([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] Framework.Workflow.Generated.DTO.WorkflowLambdaIdentityDTO workflowLambdaIdentity)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetRichWorkflowLambdaInternal(workflowLambdaIdentity, evaluateData));
        }
        
        /// <summary>
        /// Get WorkflowLambda (RichDTO) by name
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetRichWorkflowLambdaByName")]
        public virtual Framework.Workflow.Generated.DTO.WorkflowLambdaRichDTO GetRichWorkflowLambdaByName([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] string workflowLambdaName)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetRichWorkflowLambdaByNameInternal(workflowLambdaName, evaluateData));
        }
        
        protected virtual Framework.Workflow.Generated.DTO.WorkflowLambdaRichDTO GetRichWorkflowLambdaByNameInternal(string workflowLambdaName, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.IWorkflowLambdaBLL bll = evaluateData.Context.Logics.WorkflowLambdaFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            Framework.Workflow.Domain.Definition.WorkflowLambda domainObject = Framework.DomainDriven.BLL.DefaultDomainBLLBaseExtensions.GetByName(bll, workflowLambdaName, true, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.WorkflowLambda>(Framework.Transfering.ViewDTOType.FullDTO));
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToRichDTO(domainObject, evaluateData.MappingService);
        }
        
        protected virtual Framework.Workflow.Generated.DTO.WorkflowLambdaRichDTO GetRichWorkflowLambdaInternal(Framework.Workflow.Generated.DTO.WorkflowLambdaIdentityDTO workflowLambdaIdentity, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.IWorkflowLambdaBLL bll = evaluateData.Context.Logics.WorkflowLambdaFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            Framework.Workflow.Domain.Definition.WorkflowLambda domainObject = bll.GetById(workflowLambdaIdentity.Id, true, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.WorkflowLambda>(Framework.Transfering.ViewDTOType.FullDTO));
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToRichDTO(domainObject, evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get WorkflowLambda (SimpleDTO) by identity
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetSimpleWorkflowLambda")]
        public virtual Framework.Workflow.Generated.DTO.WorkflowLambdaSimpleDTO GetSimpleWorkflowLambda([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] Framework.Workflow.Generated.DTO.WorkflowLambdaIdentityDTO workflowLambdaIdentity)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetSimpleWorkflowLambdaInternal(workflowLambdaIdentity, evaluateData));
        }
        
        /// <summary>
        /// Get WorkflowLambda (SimpleDTO) by name
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetSimpleWorkflowLambdaByName")]
        public virtual Framework.Workflow.Generated.DTO.WorkflowLambdaSimpleDTO GetSimpleWorkflowLambdaByName([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] string workflowLambdaName)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetSimpleWorkflowLambdaByNameInternal(workflowLambdaName, evaluateData));
        }
        
        protected virtual Framework.Workflow.Generated.DTO.WorkflowLambdaSimpleDTO GetSimpleWorkflowLambdaByNameInternal(string workflowLambdaName, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.IWorkflowLambdaBLL bll = evaluateData.Context.Logics.WorkflowLambdaFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            Framework.Workflow.Domain.Definition.WorkflowLambda domainObject = Framework.DomainDriven.BLL.DefaultDomainBLLBaseExtensions.GetByName(bll, workflowLambdaName, true, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.WorkflowLambda>(Framework.Transfering.ViewDTOType.SimpleDTO));
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToSimpleDTO(domainObject, evaluateData.MappingService);
        }
        
        protected virtual Framework.Workflow.Generated.DTO.WorkflowLambdaSimpleDTO GetSimpleWorkflowLambdaInternal(Framework.Workflow.Generated.DTO.WorkflowLambdaIdentityDTO workflowLambdaIdentity, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.IWorkflowLambdaBLL bll = evaluateData.Context.Logics.WorkflowLambdaFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            Framework.Workflow.Domain.Definition.WorkflowLambda domainObject = bll.GetById(workflowLambdaIdentity.Id, true, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.WorkflowLambda>(Framework.Transfering.ViewDTOType.SimpleDTO));
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToSimpleDTO(domainObject, evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get full list of WorkflowLambdas (SimpleDTO)
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetSimpleWorkflowLambdas")]
        public virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.WorkflowLambdaSimpleDTO> GetSimpleWorkflowLambdas()
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetSimpleWorkflowLambdasInternal(evaluateData));
        }
        
        /// <summary>
        /// Get WorkflowLambdas (SimpleDTO) by idents
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetSimpleWorkflowLambdasByIdents")]
        public virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.WorkflowLambdaSimpleDTO> GetSimpleWorkflowLambdasByIdents([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] Framework.Workflow.Generated.DTO.WorkflowLambdaIdentityDTO[] workflowLambdaIdents)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetSimpleWorkflowLambdasByIdentsInternal(workflowLambdaIdents, evaluateData));
        }
        
        protected virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.WorkflowLambdaSimpleDTO> GetSimpleWorkflowLambdasByIdentsInternal(Framework.Workflow.Generated.DTO.WorkflowLambdaIdentityDTO[] workflowLambdaIdents, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.IWorkflowLambdaBLL bll = evaluateData.Context.Logics.WorkflowLambdaFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToSimpleDTOList(bll.GetListByIdents(workflowLambdaIdents, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.WorkflowLambda>(Framework.Transfering.ViewDTOType.SimpleDTO)), evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get WorkflowLambdas (SimpleDTO) by filter (Framework.Workflow.Domain.WorkflowLambdaRootFilterModel)
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetSimpleWorkflowLambdasByRootFilter")]
        public virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.WorkflowLambdaSimpleDTO> GetSimpleWorkflowLambdasByRootFilter([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] Framework.Workflow.Generated.DTO.WorkflowLambdaRootFilterModelStrictDTO filter)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetSimpleWorkflowLambdasByRootFilterInternal(filter, evaluateData));
        }
        
        protected virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.WorkflowLambdaSimpleDTO> GetSimpleWorkflowLambdasByRootFilterInternal(Framework.Workflow.Generated.DTO.WorkflowLambdaRootFilterModelStrictDTO filter, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.IWorkflowLambdaBLL bll = evaluateData.Context.Logics.WorkflowLambdaFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            Framework.Workflow.Domain.WorkflowLambdaRootFilterModel typedFilter = filter.ToDomainObject(evaluateData.MappingService);
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToSimpleDTOList(bll.GetListBy(typedFilter, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.WorkflowLambda>(Framework.Transfering.ViewDTOType.SimpleDTO)), evaluateData.MappingService);
        }
        
        protected virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.WorkflowLambdaSimpleDTO> GetSimpleWorkflowLambdasInternal(Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.IWorkflowLambdaBLL bll = evaluateData.Context.Logics.WorkflowLambdaFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToSimpleDTOList(bll.GetFullList(evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.WorkflowLambda>(Framework.Transfering.ViewDTOType.SimpleDTO)), evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get WorkflowLambda (VisualDTO) by identity
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetVisualWorkflowLambda")]
        public virtual Framework.Workflow.Generated.DTO.WorkflowLambdaVisualDTO GetVisualWorkflowLambda([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] Framework.Workflow.Generated.DTO.WorkflowLambdaIdentityDTO workflowLambdaIdentity)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetVisualWorkflowLambdaInternal(workflowLambdaIdentity, evaluateData));
        }
        
        /// <summary>
        /// Get WorkflowLambda (VisualDTO) by name
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetVisualWorkflowLambdaByName")]
        public virtual Framework.Workflow.Generated.DTO.WorkflowLambdaVisualDTO GetVisualWorkflowLambdaByName([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] string workflowLambdaName)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetVisualWorkflowLambdaByNameInternal(workflowLambdaName, evaluateData));
        }
        
        protected virtual Framework.Workflow.Generated.DTO.WorkflowLambdaVisualDTO GetVisualWorkflowLambdaByNameInternal(string workflowLambdaName, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.IWorkflowLambdaBLL bll = evaluateData.Context.Logics.WorkflowLambdaFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            Framework.Workflow.Domain.Definition.WorkflowLambda domainObject = Framework.DomainDriven.BLL.DefaultDomainBLLBaseExtensions.GetByName(bll, workflowLambdaName, true, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.WorkflowLambda>(Framework.Transfering.ViewDTOType.VisualDTO));
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToVisualDTO(domainObject, evaluateData.MappingService);
        }
        
        protected virtual Framework.Workflow.Generated.DTO.WorkflowLambdaVisualDTO GetVisualWorkflowLambdaInternal(Framework.Workflow.Generated.DTO.WorkflowLambdaIdentityDTO workflowLambdaIdentity, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.IWorkflowLambdaBLL bll = evaluateData.Context.Logics.WorkflowLambdaFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            Framework.Workflow.Domain.Definition.WorkflowLambda domainObject = bll.GetById(workflowLambdaIdentity.Id, true, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.WorkflowLambda>(Framework.Transfering.ViewDTOType.VisualDTO));
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToVisualDTO(domainObject, evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get full list of WorkflowLambdas (VisualDTO)
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetVisualWorkflowLambdas")]
        public virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.WorkflowLambdaVisualDTO> GetVisualWorkflowLambdas()
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetVisualWorkflowLambdasInternal(evaluateData));
        }
        
        /// <summary>
        /// Get WorkflowLambdas (VisualDTO) by idents
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetVisualWorkflowLambdasByIdents")]
        public virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.WorkflowLambdaVisualDTO> GetVisualWorkflowLambdasByIdents([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] Framework.Workflow.Generated.DTO.WorkflowLambdaIdentityDTO[] workflowLambdaIdents)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetVisualWorkflowLambdasByIdentsInternal(workflowLambdaIdents, evaluateData));
        }
        
        protected virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.WorkflowLambdaVisualDTO> GetVisualWorkflowLambdasByIdentsInternal(Framework.Workflow.Generated.DTO.WorkflowLambdaIdentityDTO[] workflowLambdaIdents, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.IWorkflowLambdaBLL bll = evaluateData.Context.Logics.WorkflowLambdaFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToVisualDTOList(bll.GetListByIdents(workflowLambdaIdents, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.WorkflowLambda>(Framework.Transfering.ViewDTOType.VisualDTO)), evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get WorkflowLambdas (VisualDTO) by filter (Framework.Workflow.Domain.WorkflowLambdaRootFilterModel)
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetVisualWorkflowLambdasByRootFilter")]
        public virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.WorkflowLambdaVisualDTO> GetVisualWorkflowLambdasByRootFilter([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] Framework.Workflow.Generated.DTO.WorkflowLambdaRootFilterModelStrictDTO filter)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetVisualWorkflowLambdasByRootFilterInternal(filter, evaluateData));
        }
        
        protected virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.WorkflowLambdaVisualDTO> GetVisualWorkflowLambdasByRootFilterInternal(Framework.Workflow.Generated.DTO.WorkflowLambdaRootFilterModelStrictDTO filter, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.IWorkflowLambdaBLL bll = evaluateData.Context.Logics.WorkflowLambdaFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            Framework.Workflow.Domain.WorkflowLambdaRootFilterModel typedFilter = filter.ToDomainObject(evaluateData.MappingService);
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToVisualDTOList(bll.GetListBy(typedFilter, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.WorkflowLambda>(Framework.Transfering.ViewDTOType.VisualDTO)), evaluateData.MappingService);
        }
        
        protected virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.WorkflowLambdaVisualDTO> GetVisualWorkflowLambdasInternal(Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.IWorkflowLambdaBLL bll = evaluateData.Context.Logics.WorkflowLambdaFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToVisualDTOList(bll.GetFullList(evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.WorkflowLambda>(Framework.Transfering.ViewDTOType.VisualDTO)), evaluateData.MappingService);
        }
        
        /// <summary>
        /// Remove WorkflowLambda
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("RemoveWorkflowLambda")]
        public virtual void RemoveWorkflowLambda([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] Framework.Workflow.Generated.DTO.WorkflowLambdaIdentityDTO workflowLambdaIdent)
        {
            this.Evaluate(Framework.DomainDriven.DBSessionMode.Write, evaluateData => this.RemoveWorkflowLambdaInternal(workflowLambdaIdent, evaluateData));
        }
        
        protected virtual void RemoveWorkflowLambdaInternal(Framework.Workflow.Generated.DTO.WorkflowLambdaIdentityDTO workflowLambdaIdent, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.IWorkflowLambdaBLL bll = evaluateData.Context.Logics.WorkflowLambdaFactory.Create(Framework.SecuritySystem.BLLSecurityMode.Edit);
            this.RemoveWorkflowLambdaInternal(workflowLambdaIdent, evaluateData, bll);
        }
        
        protected virtual void RemoveWorkflowLambdaInternal(Framework.Workflow.Generated.DTO.WorkflowLambdaIdentityDTO workflowLambdaIdent, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData, Framework.Workflow.BLL.IWorkflowLambdaBLL bll)
        {
            Framework.Workflow.Domain.Definition.WorkflowLambda domainObject = bll.GetById(workflowLambdaIdent.Id, true);
            bll.Remove(domainObject);
        }
        
        /// <summary>
        /// Save WorkflowLambdas
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("SaveWorkflowLambda")]
        public virtual Framework.Workflow.Generated.DTO.WorkflowLambdaIdentityDTO SaveWorkflowLambda([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] Framework.Workflow.Generated.DTO.WorkflowLambdaStrictDTO workflowLambdaStrict)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Write, evaluateData => this.SaveWorkflowLambdaInternal(workflowLambdaStrict, evaluateData));
        }
        
        protected virtual Framework.Workflow.Generated.DTO.WorkflowLambdaIdentityDTO SaveWorkflowLambdaInternal(Framework.Workflow.Generated.DTO.WorkflowLambdaStrictDTO workflowLambdaStrict, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.IWorkflowLambdaBLL bll = evaluateData.Context.Logics.WorkflowLambdaFactory.Create(Framework.SecuritySystem.BLLSecurityMode.Edit);
            return this.SaveWorkflowLambdaInternal(workflowLambdaStrict, evaluateData, bll);
        }
        
        protected virtual Framework.Workflow.Generated.DTO.WorkflowLambdaIdentityDTO SaveWorkflowLambdaInternal(Framework.Workflow.Generated.DTO.WorkflowLambdaStrictDTO workflowLambdaStrict, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData, Framework.Workflow.BLL.IWorkflowLambdaBLL bll)
        {
            Framework.Workflow.Domain.Definition.WorkflowLambda domainObject = bll.GetById(workflowLambdaStrict.Id, true);
            workflowLambdaStrict.MapToDomainObject(evaluateData.MappingService, domainObject);
            bll.Save(domainObject);
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToIdentityDTO(domainObject);
        }
    }
}
