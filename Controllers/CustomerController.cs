﻿using LearnAPI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearnAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService service;

        public CustomerController(ICustomerService service)
        {
            this.service = service;

        }
        [HttpGet]
        public IActionResult Get()
        {

            var data = this.service.Getall();
            if (data == null)
            {
                return NotFound();

            }
            return Ok(data);
        }
    }

}