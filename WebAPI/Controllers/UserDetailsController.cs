using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDetailsController : ControllerBase
    {
        private IUserDetailService _userDetailService;
        public UserDetailsController(IUserDetailService userDetailService)
        {
            _userDetailService = userDetailService;
        }
        [HttpGet("getbyid")]
        public IActionResult GetUserDetailById(int userId)
        {
            var result = _userDetailService.GetById(userId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("adduserdetail")]
        public IActionResult AddUserDetail(UserDetail userDetail)
        {
            var result = _userDetailService.Add(userDetail);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
    }
}