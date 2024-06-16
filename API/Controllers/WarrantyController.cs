﻿using Bussiness.Services.WarrantyService;
using Data.Model.VoucherModel;
using Data.Model.WarrantyModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class WarrantyController: ControllerBase
    {
        private readonly IWarrantyService _warrantyService;
        public WarrantyController(IWarrantyService warrantyService)
        {
            _warrantyService = warrantyService;
        }
        [HttpPost("createWarranty")]
        public async Task<ActionResult> CreateVoucher(WarrantyCreateModel warranty)
        {
            string? token = Request.Headers["Authorization"].ToString().Split(" ")[1];
            var res = await _warrantyService.CreateWarranty(token, warranty);
            return StatusCode(res.Code, res);
        }
    }
}
