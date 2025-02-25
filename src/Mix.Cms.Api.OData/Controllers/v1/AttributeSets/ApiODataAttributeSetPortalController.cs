﻿// Licensed to the Mixcore Foundation under one or more agreements.
// The Mixcore Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Mix.Cms.Lib.Models.Cms;
using Mix.Cms.Api.OData.ViewModels.MixAttributeSets;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Mix.Cms.Api.OData.Controllers.v1.OData.AttributeSets
{
    [Produces("application/json")]
    [Route("api/v1/odata/attribute-set/portal")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "SuperAdmin, Admin")]
    public class ApiODataAttributeSetPortalController :
        BaseApiODataController<MixCmsContext, MixAttributeSet>
    {
        public ApiODataAttributeSetPortalController(
            IMemoryCache memoryCache
            , Microsoft.AspNetCore.SignalR.IHubContext<Mix.Cms.Service.SignalR.Hubs.PortalHub> hubContext) : base(memoryCache, hubContext)
        {
        }

        #region Get

        // GET api/AttributeSets/id
        [EnableQuery]
        [HttpGet, HttpOptions]
        [Route("{id}")]
        [Route("by-name/{name}")]
        public async Task<ActionResult<ODataUpdateViewModel>> Details(string culture, int id, string name)
        {
            string msg = string.Empty;
            Expression<Func<MixAttributeSet, bool>> predicate = null;
            MixAttributeSet model = null;
            // Get Details if has id or else get default
            if (id > 0 || !string.IsNullOrEmpty(name))
            {
                predicate = m => m.Id == id || m.Name == name;
            }
            else
            {
                model = new MixAttributeSet()
                {
                    Priority = ODataUpdateViewModel.Repository.Max(p => p.Priority).Data + 1
                };
            }

            var portalResult = await base.GetSingleAsync<ODataUpdateViewModel>(id.ToString(), predicate, model);

            return Ok(portalResult.Data);
        }

        // GET api/attribute-sets/portal/count
        [AllowAnonymous]
        [EnableQuery]
        [Route("count")]
        [HttpGet, HttpOptions]
        public async System.Threading.Tasks.Task<ActionResult<int>> CountAsync()
        {
            return (await ODataUpdateViewModel.Repository.CountAsync()).Data;
        }

        // Save api/odata/{culture}/attribute-set/portal
        [HttpPost, HttpOptions]
        [Route("")]
        public async Task<ActionResult<ODataUpdateViewModel>> Save(string culture, [FromBody]ODataUpdateViewModel data)
        {
            var portalResult = await base.SaveAsync<ODataUpdateViewModel>(data, true);
            if (portalResult.IsSucceed)
            {
                return Ok(portalResult);
            }
            else
            {
                return BadRequest(portalResult);
            }
        }

        // Save api/odata/{culture}/attribute-set/portal/{id}
        [HttpPost, HttpOptions]
        [Route("{id}")]
        public async Task<ActionResult<ODataUpdateViewModel>> Save(string culture, int id, [FromBody]JObject data)
        {
            var portalResult = await base.SaveAsync<ODataUpdateViewModel>(data, p => p.Id == id);
            if (portalResult.IsSucceed)
            {
                return Ok(portalResult);
            }
            else
            {
                return BadRequest(portalResult);
            }
        }

        [HttpDelete, HttpOptions]
        [Route("{id}")]
        public async Task<ActionResult<ODataUpdateViewModel>> Delete(string culture, int id)
        {
            Expression<Func<MixAttributeSet, bool>> predicate = model => model.Id == id;

            // Get Details if has id or else get default

            var portalResult = await base.GetSingleAsync<ODataUpdateViewModel>(id.ToString(), predicate);

            var result = await base.DeleteAsync<ODataUpdateViewModel>(portalResult.Data, true);
            if (result.IsSucceed)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        // GET api/AttributeSets/id
        [EnableQuery(MaxExpansionDepth = 4)]
        [HttpGet, HttpOptions]
        public async Task<ActionResult<List<ODataUpdateViewModel>>> List(string culture, ODataQueryOptions<MixAttributeSet> queryOptions)
        {
            var result = await base.GetListAsync<ODataUpdateViewModel>(queryOptions);
            return Ok(result);
        }

        #endregion Get
    }
}