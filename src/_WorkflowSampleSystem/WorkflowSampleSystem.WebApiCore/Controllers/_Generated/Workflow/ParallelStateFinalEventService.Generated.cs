﻿namespace Workflow.WebApi.Controllers
{
    using Framework.Workflow.Generated.DTO;
    
    
    [Microsoft.AspNetCore.Mvc.ApiControllerAttribute()]
    [Microsoft.AspNetCore.Mvc.ApiVersionAttribute("1.0")]
    [Microsoft.AspNetCore.Mvc.RouteAttribute("workflowApi/v{version:apiVersion}/[controller]")]
    public partial class ParallelStateFinalEventController : Framework.DomainDriven.WebApiNetCore.ApiControllerBase<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService>>
    {
        
        /// <summary>
        /// Get ParallelStateFinalEvent (FullDTO) by identity
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetFullParallelStateFinalEvent")]
        public virtual Framework.Workflow.Generated.DTO.ParallelStateFinalEventFullDTO GetFullParallelStateFinalEvent([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] Framework.Workflow.Generated.DTO.ParallelStateFinalEventIdentityDTO parallelStateFinalEventIdentity)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetFullParallelStateFinalEventInternal(parallelStateFinalEventIdentity, evaluateData));
        }
        
        /// <summary>
        /// Get ParallelStateFinalEvent (FullDTO) by name
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetFullParallelStateFinalEventByName")]
        public virtual Framework.Workflow.Generated.DTO.ParallelStateFinalEventFullDTO GetFullParallelStateFinalEventByName([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] string parallelStateFinalEventName)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetFullParallelStateFinalEventByNameInternal(parallelStateFinalEventName, evaluateData));
        }
        
        protected virtual Framework.Workflow.Generated.DTO.ParallelStateFinalEventFullDTO GetFullParallelStateFinalEventByNameInternal(string parallelStateFinalEventName, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.IParallelStateFinalEventBLL bll = evaluateData.Context.Logics.ParallelStateFinalEventFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            Framework.Workflow.Domain.Definition.ParallelStateFinalEvent domainObject = Framework.DomainDriven.BLL.DefaultDomainBLLBaseExtensions.GetByName(bll, parallelStateFinalEventName, true, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.ParallelStateFinalEvent>(Framework.Transfering.ViewDTOType.FullDTO));
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToFullDTO(domainObject, evaluateData.MappingService);
        }
        
        protected virtual Framework.Workflow.Generated.DTO.ParallelStateFinalEventFullDTO GetFullParallelStateFinalEventInternal(Framework.Workflow.Generated.DTO.ParallelStateFinalEventIdentityDTO parallelStateFinalEventIdentity, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.IParallelStateFinalEventBLL bll = evaluateData.Context.Logics.ParallelStateFinalEventFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            Framework.Workflow.Domain.Definition.ParallelStateFinalEvent domainObject = bll.GetById(parallelStateFinalEventIdentity.Id, true, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.ParallelStateFinalEvent>(Framework.Transfering.ViewDTOType.FullDTO));
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToFullDTO(domainObject, evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get full list of ParallelStateFinalEvents (FullDTO)
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetFullParallelStateFinalEvents")]
        public virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.ParallelStateFinalEventFullDTO> GetFullParallelStateFinalEvents()
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetFullParallelStateFinalEventsInternal(evaluateData));
        }
        
        /// <summary>
        /// Get ParallelStateFinalEvents (FullDTO) by idents
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetFullParallelStateFinalEventsByIdents")]
        public virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.ParallelStateFinalEventFullDTO> GetFullParallelStateFinalEventsByIdents([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] Framework.Workflow.Generated.DTO.ParallelStateFinalEventIdentityDTO[] parallelStateFinalEventIdents)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetFullParallelStateFinalEventsByIdentsInternal(parallelStateFinalEventIdents, evaluateData));
        }
        
        protected virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.ParallelStateFinalEventFullDTO> GetFullParallelStateFinalEventsByIdentsInternal(Framework.Workflow.Generated.DTO.ParallelStateFinalEventIdentityDTO[] parallelStateFinalEventIdents, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.IParallelStateFinalEventBLL bll = evaluateData.Context.Logics.ParallelStateFinalEventFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToFullDTOList(bll.GetListByIdents(parallelStateFinalEventIdents, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.ParallelStateFinalEvent>(Framework.Transfering.ViewDTOType.FullDTO)), evaluateData.MappingService);
        }
        
        protected virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.ParallelStateFinalEventFullDTO> GetFullParallelStateFinalEventsInternal(Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.IParallelStateFinalEventBLL bll = evaluateData.Context.Logics.ParallelStateFinalEventFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToFullDTOList(bll.GetFullList(evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.ParallelStateFinalEvent>(Framework.Transfering.ViewDTOType.FullDTO)), evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get ParallelStateFinalEvent (RichDTO) by identity
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetRichParallelStateFinalEvent")]
        public virtual Framework.Workflow.Generated.DTO.ParallelStateFinalEventRichDTO GetRichParallelStateFinalEvent([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] Framework.Workflow.Generated.DTO.ParallelStateFinalEventIdentityDTO parallelStateFinalEventIdentity)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetRichParallelStateFinalEventInternal(parallelStateFinalEventIdentity, evaluateData));
        }
        
        /// <summary>
        /// Get ParallelStateFinalEvent (RichDTO) by name
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetRichParallelStateFinalEventByName")]
        public virtual Framework.Workflow.Generated.DTO.ParallelStateFinalEventRichDTO GetRichParallelStateFinalEventByName([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] string parallelStateFinalEventName)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetRichParallelStateFinalEventByNameInternal(parallelStateFinalEventName, evaluateData));
        }
        
        protected virtual Framework.Workflow.Generated.DTO.ParallelStateFinalEventRichDTO GetRichParallelStateFinalEventByNameInternal(string parallelStateFinalEventName, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.IParallelStateFinalEventBLL bll = evaluateData.Context.Logics.ParallelStateFinalEventFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            Framework.Workflow.Domain.Definition.ParallelStateFinalEvent domainObject = Framework.DomainDriven.BLL.DefaultDomainBLLBaseExtensions.GetByName(bll, parallelStateFinalEventName, true, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.ParallelStateFinalEvent>(Framework.Transfering.ViewDTOType.FullDTO));
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToRichDTO(domainObject, evaluateData.MappingService);
        }
        
        protected virtual Framework.Workflow.Generated.DTO.ParallelStateFinalEventRichDTO GetRichParallelStateFinalEventInternal(Framework.Workflow.Generated.DTO.ParallelStateFinalEventIdentityDTO parallelStateFinalEventIdentity, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.IParallelStateFinalEventBLL bll = evaluateData.Context.Logics.ParallelStateFinalEventFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            Framework.Workflow.Domain.Definition.ParallelStateFinalEvent domainObject = bll.GetById(parallelStateFinalEventIdentity.Id, true, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.ParallelStateFinalEvent>(Framework.Transfering.ViewDTOType.FullDTO));
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToRichDTO(domainObject, evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get ParallelStateFinalEvent (SimpleDTO) by identity
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetSimpleParallelStateFinalEvent")]
        public virtual Framework.Workflow.Generated.DTO.ParallelStateFinalEventSimpleDTO GetSimpleParallelStateFinalEvent([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] Framework.Workflow.Generated.DTO.ParallelStateFinalEventIdentityDTO parallelStateFinalEventIdentity)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetSimpleParallelStateFinalEventInternal(parallelStateFinalEventIdentity, evaluateData));
        }
        
        /// <summary>
        /// Get ParallelStateFinalEvent (SimpleDTO) by name
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetSimpleParallelStateFinalEventByName")]
        public virtual Framework.Workflow.Generated.DTO.ParallelStateFinalEventSimpleDTO GetSimpleParallelStateFinalEventByName([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] string parallelStateFinalEventName)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetSimpleParallelStateFinalEventByNameInternal(parallelStateFinalEventName, evaluateData));
        }
        
        protected virtual Framework.Workflow.Generated.DTO.ParallelStateFinalEventSimpleDTO GetSimpleParallelStateFinalEventByNameInternal(string parallelStateFinalEventName, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.IParallelStateFinalEventBLL bll = evaluateData.Context.Logics.ParallelStateFinalEventFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            Framework.Workflow.Domain.Definition.ParallelStateFinalEvent domainObject = Framework.DomainDriven.BLL.DefaultDomainBLLBaseExtensions.GetByName(bll, parallelStateFinalEventName, true, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.ParallelStateFinalEvent>(Framework.Transfering.ViewDTOType.SimpleDTO));
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToSimpleDTO(domainObject, evaluateData.MappingService);
        }
        
        protected virtual Framework.Workflow.Generated.DTO.ParallelStateFinalEventSimpleDTO GetSimpleParallelStateFinalEventInternal(Framework.Workflow.Generated.DTO.ParallelStateFinalEventIdentityDTO parallelStateFinalEventIdentity, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.IParallelStateFinalEventBLL bll = evaluateData.Context.Logics.ParallelStateFinalEventFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            Framework.Workflow.Domain.Definition.ParallelStateFinalEvent domainObject = bll.GetById(parallelStateFinalEventIdentity.Id, true, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.ParallelStateFinalEvent>(Framework.Transfering.ViewDTOType.SimpleDTO));
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToSimpleDTO(domainObject, evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get full list of ParallelStateFinalEvents (SimpleDTO)
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetSimpleParallelStateFinalEvents")]
        public virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.ParallelStateFinalEventSimpleDTO> GetSimpleParallelStateFinalEvents()
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetSimpleParallelStateFinalEventsInternal(evaluateData));
        }
        
        /// <summary>
        /// Get ParallelStateFinalEvents (SimpleDTO) by idents
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetSimpleParallelStateFinalEventsByIdents")]
        public virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.ParallelStateFinalEventSimpleDTO> GetSimpleParallelStateFinalEventsByIdents([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] Framework.Workflow.Generated.DTO.ParallelStateFinalEventIdentityDTO[] parallelStateFinalEventIdents)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetSimpleParallelStateFinalEventsByIdentsInternal(parallelStateFinalEventIdents, evaluateData));
        }
        
        protected virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.ParallelStateFinalEventSimpleDTO> GetSimpleParallelStateFinalEventsByIdentsInternal(Framework.Workflow.Generated.DTO.ParallelStateFinalEventIdentityDTO[] parallelStateFinalEventIdents, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.IParallelStateFinalEventBLL bll = evaluateData.Context.Logics.ParallelStateFinalEventFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToSimpleDTOList(bll.GetListByIdents(parallelStateFinalEventIdents, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.ParallelStateFinalEvent>(Framework.Transfering.ViewDTOType.SimpleDTO)), evaluateData.MappingService);
        }
        
        protected virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.ParallelStateFinalEventSimpleDTO> GetSimpleParallelStateFinalEventsInternal(Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.IParallelStateFinalEventBLL bll = evaluateData.Context.Logics.ParallelStateFinalEventFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToSimpleDTOList(bll.GetFullList(evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.ParallelStateFinalEvent>(Framework.Transfering.ViewDTOType.SimpleDTO)), evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get ParallelStateFinalEvent (VisualDTO) by identity
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetVisualParallelStateFinalEvent")]
        public virtual Framework.Workflow.Generated.DTO.ParallelStateFinalEventVisualDTO GetVisualParallelStateFinalEvent([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] Framework.Workflow.Generated.DTO.ParallelStateFinalEventIdentityDTO parallelStateFinalEventIdentity)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetVisualParallelStateFinalEventInternal(parallelStateFinalEventIdentity, evaluateData));
        }
        
        /// <summary>
        /// Get ParallelStateFinalEvent (VisualDTO) by name
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetVisualParallelStateFinalEventByName")]
        public virtual Framework.Workflow.Generated.DTO.ParallelStateFinalEventVisualDTO GetVisualParallelStateFinalEventByName([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] string parallelStateFinalEventName)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetVisualParallelStateFinalEventByNameInternal(parallelStateFinalEventName, evaluateData));
        }
        
        protected virtual Framework.Workflow.Generated.DTO.ParallelStateFinalEventVisualDTO GetVisualParallelStateFinalEventByNameInternal(string parallelStateFinalEventName, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.IParallelStateFinalEventBLL bll = evaluateData.Context.Logics.ParallelStateFinalEventFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            Framework.Workflow.Domain.Definition.ParallelStateFinalEvent domainObject = Framework.DomainDriven.BLL.DefaultDomainBLLBaseExtensions.GetByName(bll, parallelStateFinalEventName, true, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.ParallelStateFinalEvent>(Framework.Transfering.ViewDTOType.VisualDTO));
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToVisualDTO(domainObject, evaluateData.MappingService);
        }
        
        protected virtual Framework.Workflow.Generated.DTO.ParallelStateFinalEventVisualDTO GetVisualParallelStateFinalEventInternal(Framework.Workflow.Generated.DTO.ParallelStateFinalEventIdentityDTO parallelStateFinalEventIdentity, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.IParallelStateFinalEventBLL bll = evaluateData.Context.Logics.ParallelStateFinalEventFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            Framework.Workflow.Domain.Definition.ParallelStateFinalEvent domainObject = bll.GetById(parallelStateFinalEventIdentity.Id, true, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.ParallelStateFinalEvent>(Framework.Transfering.ViewDTOType.VisualDTO));
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToVisualDTO(domainObject, evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get full list of ParallelStateFinalEvents (VisualDTO)
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetVisualParallelStateFinalEvents")]
        public virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.ParallelStateFinalEventVisualDTO> GetVisualParallelStateFinalEvents()
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetVisualParallelStateFinalEventsInternal(evaluateData));
        }
        
        /// <summary>
        /// Get ParallelStateFinalEvents (VisualDTO) by idents
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetVisualParallelStateFinalEventsByIdents")]
        public virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.ParallelStateFinalEventVisualDTO> GetVisualParallelStateFinalEventsByIdents([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] Framework.Workflow.Generated.DTO.ParallelStateFinalEventIdentityDTO[] parallelStateFinalEventIdents)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetVisualParallelStateFinalEventsByIdentsInternal(parallelStateFinalEventIdents, evaluateData));
        }
        
        protected virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.ParallelStateFinalEventVisualDTO> GetVisualParallelStateFinalEventsByIdentsInternal(Framework.Workflow.Generated.DTO.ParallelStateFinalEventIdentityDTO[] parallelStateFinalEventIdents, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.IParallelStateFinalEventBLL bll = evaluateData.Context.Logics.ParallelStateFinalEventFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToVisualDTOList(bll.GetListByIdents(parallelStateFinalEventIdents, evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.ParallelStateFinalEvent>(Framework.Transfering.ViewDTOType.VisualDTO)), evaluateData.MappingService);
        }
        
        protected virtual System.Collections.Generic.IEnumerable<Framework.Workflow.Generated.DTO.ParallelStateFinalEventVisualDTO> GetVisualParallelStateFinalEventsInternal(Framework.DomainDriven.ServiceModel.Service.EvaluatedData<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Generated.DTO.IWorkflowDTOMappingService> evaluateData)
        {
            Framework.Workflow.BLL.IParallelStateFinalEventBLL bll = evaluateData.Context.Logics.ParallelStateFinalEventFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return Framework.Workflow.Generated.DTO.LambdaHelper.ToVisualDTOList(bll.GetFullList(evaluateData.Context.FetchService.GetContainer<Framework.Workflow.Domain.Definition.ParallelStateFinalEvent>(Framework.Transfering.ViewDTOType.VisualDTO)), evaluateData.MappingService);
        }
    }
}
