﻿// Licensed to the Mixcore Foundation under one or more agreements.
// The Mixcore Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.AspNetCore.Mvc;
using Mix.Cms.Lib;
using Mix.Cms.Lib.Controllers;
using Mix.Cms.Lib.Models.Cms;
using Mix.Cms.Lib.ViewModels.MixRelatedAttributeDatas;
using Mix.Domain.Core.ViewModels;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Mix.Cms.Api.RestFul.Controllers.v1
{
    [Produces("application/json")]
    [Route("api/v1/rest/{culture}/related-attribute-data/portal")]
    public class ApiRelatedAttributeDataPortalController :
        BaseRestApiController<MixCmsContext, MixRelatedAttributeData, FormViewModel>
    {
        // GET: api/v1/rest/{culture}/related-attribute-data
        [HttpGet]
        public override async Task<ActionResult<PaginationModel<FormViewModel>>> Get()
        {
            bool isStatus = Enum.TryParse(Request.Query["status"], out MixEnums.MixContentStatus status);
            int.TryParse(Request.Query["attributeSetId"], out int attributeSetId);
            bool isFromDate = DateTime.TryParse(Request.Query["fromDate"], out DateTime fromDate);
            bool isToDate = DateTime.TryParse(Request.Query["toDate"], out DateTime toDate);
            string parentType = Request.Query["parentType"];
            string parentId = Request.Query["parentId"];
            string attributeSetName = Request.Query["attributeSetName"];
            Expression<Func<MixRelatedAttributeData, bool>> predicate = model =>
                (!isStatus || model.Status == status.ToString())
                && (!isFromDate || model.CreatedDateTime >= fromDate)
                && (!isToDate || model.CreatedDateTime <= toDate)
                && (model.AttributeSetId == attributeSetId || model.AttributeSetName == attributeSetName)
                && (string.IsNullOrEmpty(parentId)
                 || (model.ParentId == parentId && model.ParentType == parentType.ToString())
                 );
                
                
            var getData = await base.GetListAsync(predicate);
            if (getData.IsSucceed)
            {
                return Ok(getData.Data);
            }
            else
            {
                return BadRequest(getData.Errors);
            }
        }
    }

}