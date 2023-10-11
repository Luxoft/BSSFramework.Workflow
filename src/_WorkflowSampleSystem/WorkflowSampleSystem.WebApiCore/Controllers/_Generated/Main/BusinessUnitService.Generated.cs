namespace WorkflowSampleSystem.WebApiCore.Controllers.Main
{
    using WorkflowSampleSystem.Generated.DTO;
    
    
    [Microsoft.AspNetCore.Mvc.ApiControllerAttribute()]
    [Microsoft.AspNetCore.Mvc.ApiVersionAttribute("1.0")]
    [Microsoft.AspNetCore.Mvc.RouteAttribute("api/v{version:apiVersion}/[controller]")]
    public partial class BusinessUnitController : Framework.DomainDriven.WebApiNetCore.ApiControllerBase<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService>>
    {
        
        /// <summary>
        /// Get BusinessUnit (FullDTO) by identity
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetFullBusinessUnit")]
        public virtual WorkflowSampleSystem.Generated.DTO.BusinessUnitFullDTO GetFullBusinessUnit([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] WorkflowSampleSystem.Generated.DTO.BusinessUnitIdentityDTO businessUnitIdentity)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetFullBusinessUnitInternal(businessUnitIdentity, evaluateData));
        }
        
        /// <summary>
        /// Get BusinessUnit (FullDTO) by name
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetFullBusinessUnitByName")]
        public virtual WorkflowSampleSystem.Generated.DTO.BusinessUnitFullDTO GetFullBusinessUnitByName([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] string businessUnitName)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetFullBusinessUnitByNameInternal(businessUnitName, evaluateData));
        }
        
        protected virtual WorkflowSampleSystem.Generated.DTO.BusinessUnitFullDTO GetFullBusinessUnitByNameInternal(string businessUnitName, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IBusinessUnitBLL bll = evaluateData.Context.Logics.BusinessUnitFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            WorkflowSampleSystem.Domain.BusinessUnit domainObject = Framework.DomainDriven.BLL.DefaultDomainBLLBaseExtensions.GetByName(bll, businessUnitName, true, evaluateData.Context.FetchService.GetContainer<WorkflowSampleSystem.Domain.BusinessUnit>(Framework.Transfering.ViewDTOType.FullDTO));
            return WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToFullDTO(domainObject, evaluateData.MappingService);
        }
        
        protected virtual WorkflowSampleSystem.Generated.DTO.BusinessUnitFullDTO GetFullBusinessUnitInternal(WorkflowSampleSystem.Generated.DTO.BusinessUnitIdentityDTO businessUnitIdentity, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IBusinessUnitBLL bll = evaluateData.Context.Logics.BusinessUnitFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            WorkflowSampleSystem.Domain.BusinessUnit domainObject = bll.GetById(businessUnitIdentity.Id, true, evaluateData.Context.FetchService.GetContainer<WorkflowSampleSystem.Domain.BusinessUnit>(Framework.Transfering.ViewDTOType.FullDTO));
            return WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToFullDTO(domainObject, evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get full list of BusinessUnits (FullDTO)
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetFullBusinessUnits")]
        public virtual System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Generated.DTO.BusinessUnitFullDTO> GetFullBusinessUnits()
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetFullBusinessUnitsInternal(evaluateData));
        }
        
        /// <summary>
        /// Get BusinessUnits (FullDTO) by idents
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetFullBusinessUnitsByIdents")]
        public virtual System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Generated.DTO.BusinessUnitFullDTO> GetFullBusinessUnitsByIdents([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] WorkflowSampleSystem.Generated.DTO.BusinessUnitIdentityDTO[] businessUnitIdents)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetFullBusinessUnitsByIdentsInternal(businessUnitIdents, evaluateData));
        }
        
        protected virtual System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Generated.DTO.BusinessUnitFullDTO> GetFullBusinessUnitsByIdentsInternal(WorkflowSampleSystem.Generated.DTO.BusinessUnitIdentityDTO[] businessUnitIdents, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IBusinessUnitBLL bll = evaluateData.Context.Logics.BusinessUnitFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToFullDTOList(bll.GetListByIdents(businessUnitIdents, evaluateData.Context.FetchService.GetContainer<WorkflowSampleSystem.Domain.BusinessUnit>(Framework.Transfering.ViewDTOType.FullDTO)), evaluateData.MappingService);
        }
        
        protected virtual System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Generated.DTO.BusinessUnitFullDTO> GetFullBusinessUnitsInternal(Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IBusinessUnitBLL bll = evaluateData.Context.Logics.BusinessUnitFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToFullDTOList(bll.GetFullList(evaluateData.Context.FetchService.GetContainer<WorkflowSampleSystem.Domain.BusinessUnit>(Framework.Transfering.ViewDTOType.FullDTO)), evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get BusinessUnit (RichDTO) by identity
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetRichBusinessUnit")]
        public virtual WorkflowSampleSystem.Generated.DTO.BusinessUnitRichDTO GetRichBusinessUnit([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] WorkflowSampleSystem.Generated.DTO.BusinessUnitIdentityDTO businessUnitIdentity)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetRichBusinessUnitInternal(businessUnitIdentity, evaluateData));
        }
        
        /// <summary>
        /// Get BusinessUnit (RichDTO) by name
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetRichBusinessUnitByName")]
        public virtual WorkflowSampleSystem.Generated.DTO.BusinessUnitRichDTO GetRichBusinessUnitByName([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] string businessUnitName)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetRichBusinessUnitByNameInternal(businessUnitName, evaluateData));
        }
        
        protected virtual WorkflowSampleSystem.Generated.DTO.BusinessUnitRichDTO GetRichBusinessUnitByNameInternal(string businessUnitName, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IBusinessUnitBLL bll = evaluateData.Context.Logics.BusinessUnitFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            WorkflowSampleSystem.Domain.BusinessUnit domainObject = Framework.DomainDriven.BLL.DefaultDomainBLLBaseExtensions.GetByName(bll, businessUnitName, true, evaluateData.Context.FetchService.GetContainer<WorkflowSampleSystem.Domain.BusinessUnit>(Framework.Transfering.ViewDTOType.FullDTO));
            return WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToRichDTO(domainObject, evaluateData.MappingService);
        }
        
        protected virtual WorkflowSampleSystem.Generated.DTO.BusinessUnitRichDTO GetRichBusinessUnitInternal(WorkflowSampleSystem.Generated.DTO.BusinessUnitIdentityDTO businessUnitIdentity, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IBusinessUnitBLL bll = evaluateData.Context.Logics.BusinessUnitFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            WorkflowSampleSystem.Domain.BusinessUnit domainObject = bll.GetById(businessUnitIdentity.Id, true, evaluateData.Context.FetchService.GetContainer<WorkflowSampleSystem.Domain.BusinessUnit>(Framework.Transfering.ViewDTOType.FullDTO));
            return WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToRichDTO(domainObject, evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get BusinessUnit (SimpleDTO) by identity
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetSimpleBusinessUnit")]
        public virtual WorkflowSampleSystem.Generated.DTO.BusinessUnitSimpleDTO GetSimpleBusinessUnit([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] WorkflowSampleSystem.Generated.DTO.BusinessUnitIdentityDTO businessUnitIdentity)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetSimpleBusinessUnitInternal(businessUnitIdentity, evaluateData));
        }
        
        /// <summary>
        /// Get BusinessUnit (SimpleDTO) by name
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetSimpleBusinessUnitByName")]
        public virtual WorkflowSampleSystem.Generated.DTO.BusinessUnitSimpleDTO GetSimpleBusinessUnitByName([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] string businessUnitName)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetSimpleBusinessUnitByNameInternal(businessUnitName, evaluateData));
        }
        
        protected virtual WorkflowSampleSystem.Generated.DTO.BusinessUnitSimpleDTO GetSimpleBusinessUnitByNameInternal(string businessUnitName, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IBusinessUnitBLL bll = evaluateData.Context.Logics.BusinessUnitFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            WorkflowSampleSystem.Domain.BusinessUnit domainObject = Framework.DomainDriven.BLL.DefaultDomainBLLBaseExtensions.GetByName(bll, businessUnitName, true, evaluateData.Context.FetchService.GetContainer<WorkflowSampleSystem.Domain.BusinessUnit>(Framework.Transfering.ViewDTOType.SimpleDTO));
            return WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToSimpleDTO(domainObject, evaluateData.MappingService);
        }
        
        protected virtual WorkflowSampleSystem.Generated.DTO.BusinessUnitSimpleDTO GetSimpleBusinessUnitInternal(WorkflowSampleSystem.Generated.DTO.BusinessUnitIdentityDTO businessUnitIdentity, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IBusinessUnitBLL bll = evaluateData.Context.Logics.BusinessUnitFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            WorkflowSampleSystem.Domain.BusinessUnit domainObject = bll.GetById(businessUnitIdentity.Id, true, evaluateData.Context.FetchService.GetContainer<WorkflowSampleSystem.Domain.BusinessUnit>(Framework.Transfering.ViewDTOType.SimpleDTO));
            return WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToSimpleDTO(domainObject, evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get full list of BusinessUnits (SimpleDTO)
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetSimpleBusinessUnits")]
        public virtual System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Generated.DTO.BusinessUnitSimpleDTO> GetSimpleBusinessUnits()
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetSimpleBusinessUnitsInternal(evaluateData));
        }
        
        /// <summary>
        /// Get BusinessUnits (SimpleDTO) by idents
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetSimpleBusinessUnitsByIdents")]
        public virtual System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Generated.DTO.BusinessUnitSimpleDTO> GetSimpleBusinessUnitsByIdents([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] WorkflowSampleSystem.Generated.DTO.BusinessUnitIdentityDTO[] businessUnitIdents)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetSimpleBusinessUnitsByIdentsInternal(businessUnitIdents, evaluateData));
        }
        
        protected virtual System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Generated.DTO.BusinessUnitSimpleDTO> GetSimpleBusinessUnitsByIdentsInternal(WorkflowSampleSystem.Generated.DTO.BusinessUnitIdentityDTO[] businessUnitIdents, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IBusinessUnitBLL bll = evaluateData.Context.Logics.BusinessUnitFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToSimpleDTOList(bll.GetListByIdents(businessUnitIdents, evaluateData.Context.FetchService.GetContainer<WorkflowSampleSystem.Domain.BusinessUnit>(Framework.Transfering.ViewDTOType.SimpleDTO)), evaluateData.MappingService);
        }
        
        protected virtual System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Generated.DTO.BusinessUnitSimpleDTO> GetSimpleBusinessUnitsInternal(Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IBusinessUnitBLL bll = evaluateData.Context.Logics.BusinessUnitFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToSimpleDTOList(bll.GetFullList(evaluateData.Context.FetchService.GetContainer<WorkflowSampleSystem.Domain.BusinessUnit>(Framework.Transfering.ViewDTOType.SimpleDTO)), evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get BusinessUnit (VisualDTO) by identity
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetVisualBusinessUnit")]
        public virtual WorkflowSampleSystem.Generated.DTO.BusinessUnitVisualDTO GetVisualBusinessUnit([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] WorkflowSampleSystem.Generated.DTO.BusinessUnitIdentityDTO businessUnitIdentity)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetVisualBusinessUnitInternal(businessUnitIdentity, evaluateData));
        }
        
        /// <summary>
        /// Get BusinessUnit (VisualDTO) by name
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetVisualBusinessUnitByName")]
        public virtual WorkflowSampleSystem.Generated.DTO.BusinessUnitVisualDTO GetVisualBusinessUnitByName([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] string businessUnitName)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetVisualBusinessUnitByNameInternal(businessUnitName, evaluateData));
        }
        
        protected virtual WorkflowSampleSystem.Generated.DTO.BusinessUnitVisualDTO GetVisualBusinessUnitByNameInternal(string businessUnitName, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IBusinessUnitBLL bll = evaluateData.Context.Logics.BusinessUnitFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            WorkflowSampleSystem.Domain.BusinessUnit domainObject = Framework.DomainDriven.BLL.DefaultDomainBLLBaseExtensions.GetByName(bll, businessUnitName, true, evaluateData.Context.FetchService.GetContainer<WorkflowSampleSystem.Domain.BusinessUnit>(Framework.Transfering.ViewDTOType.VisualDTO));
            return WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToVisualDTO(domainObject, evaluateData.MappingService);
        }
        
        protected virtual WorkflowSampleSystem.Generated.DTO.BusinessUnitVisualDTO GetVisualBusinessUnitInternal(WorkflowSampleSystem.Generated.DTO.BusinessUnitIdentityDTO businessUnitIdentity, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IBusinessUnitBLL bll = evaluateData.Context.Logics.BusinessUnitFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            WorkflowSampleSystem.Domain.BusinessUnit domainObject = bll.GetById(businessUnitIdentity.Id, true, evaluateData.Context.FetchService.GetContainer<WorkflowSampleSystem.Domain.BusinessUnit>(Framework.Transfering.ViewDTOType.VisualDTO));
            return WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToVisualDTO(domainObject, evaluateData.MappingService);
        }
        
        /// <summary>
        /// Get full list of BusinessUnits (VisualDTO)
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetVisualBusinessUnits")]
        public virtual System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Generated.DTO.BusinessUnitVisualDTO> GetVisualBusinessUnits()
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetVisualBusinessUnitsInternal(evaluateData));
        }
        
        /// <summary>
        /// Get BusinessUnits (VisualDTO) by idents
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("GetVisualBusinessUnitsByIdents")]
        public virtual System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Generated.DTO.BusinessUnitVisualDTO> GetVisualBusinessUnitsByIdents([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] WorkflowSampleSystem.Generated.DTO.BusinessUnitIdentityDTO[] businessUnitIdents)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Read, evaluateData => this.GetVisualBusinessUnitsByIdentsInternal(businessUnitIdents, evaluateData));
        }
        
        protected virtual System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Generated.DTO.BusinessUnitVisualDTO> GetVisualBusinessUnitsByIdentsInternal(WorkflowSampleSystem.Generated.DTO.BusinessUnitIdentityDTO[] businessUnitIdents, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IBusinessUnitBLL bll = evaluateData.Context.Logics.BusinessUnitFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToVisualDTOList(bll.GetListByIdents(businessUnitIdents, evaluateData.Context.FetchService.GetContainer<WorkflowSampleSystem.Domain.BusinessUnit>(Framework.Transfering.ViewDTOType.VisualDTO)), evaluateData.MappingService);
        }
        
        protected virtual System.Collections.Generic.IEnumerable<WorkflowSampleSystem.Generated.DTO.BusinessUnitVisualDTO> GetVisualBusinessUnitsInternal(Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IBusinessUnitBLL bll = evaluateData.Context.Logics.BusinessUnitFactory.Create(Framework.SecuritySystem.BLLSecurityMode.View);
            return WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToVisualDTOList(bll.GetFullList(evaluateData.Context.FetchService.GetContainer<WorkflowSampleSystem.Domain.BusinessUnit>(Framework.Transfering.ViewDTOType.VisualDTO)), evaluateData.MappingService);
        }
        
        /// <summary>
        /// Save BusinessUnits
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
        [Microsoft.AspNetCore.Mvc.RouteAttribute("SaveBusinessUnit")]
        public virtual WorkflowSampleSystem.Generated.DTO.BusinessUnitIdentityDTO SaveBusinessUnit([Microsoft.AspNetCore.Mvc.FromBodyAttribute()] WorkflowSampleSystem.Generated.DTO.BusinessUnitStrictDTO businessUnitStrict)
        {
            return this.Evaluate(Framework.DomainDriven.DBSessionMode.Write, evaluateData => this.SaveBusinessUnitInternal(businessUnitStrict, evaluateData));
        }
        
        protected virtual WorkflowSampleSystem.Generated.DTO.BusinessUnitIdentityDTO SaveBusinessUnitInternal(WorkflowSampleSystem.Generated.DTO.BusinessUnitStrictDTO businessUnitStrict, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData)
        {
            WorkflowSampleSystem.BLL.IBusinessUnitBLL bll = evaluateData.Context.Logics.BusinessUnitFactory.Create(Framework.SecuritySystem.BLLSecurityMode.Edit);
            return this.SaveBusinessUnitInternal(businessUnitStrict, evaluateData, bll);
        }
        
        protected virtual WorkflowSampleSystem.Generated.DTO.BusinessUnitIdentityDTO SaveBusinessUnitInternal(WorkflowSampleSystem.Generated.DTO.BusinessUnitStrictDTO businessUnitStrict, Framework.DomainDriven.ServiceModel.Service.EvaluatedData<WorkflowSampleSystem.BLL.IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Generated.DTO.IWorkflowSampleSystemDTOMappingService> evaluateData, WorkflowSampleSystem.BLL.IBusinessUnitBLL bll)
        {
            WorkflowSampleSystem.Domain.BusinessUnit domainObject = bll.GetById(businessUnitStrict.Id, true);
            businessUnitStrict.MapToDomainObject(evaluateData.MappingService, domainObject);
            bll.Save(domainObject);
            return WorkflowSampleSystem.Generated.DTO.LambdaHelper.ToIdentityDTO(domainObject);
        }
    }
}
