﻿using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public List<User> GetUsers()
        {
            var users = _userService.GetList();

            return users;
        }
        [HttpPost]
        public void AddUserPost()
        {
            User user = new User(); 
            user.birth_date = DateTime.Now;
            user.updated_time = DateTime.Now;
            user.mail_address = "savcicagri7@gmail.com";
            user.phone = "5301666822";
            user.phone_code = "+90";
            user.gender = "male";
            user.firstname = "Batı";
            user.lastname = "Savcı";
            user.is_mail_verified = true;
            user.is_active= true;
            user.is_phone_verified= true;
            user.created_time = DateTime.Now;
            user.identity_card_no = "12345678912";
            user.user_type = 1;
            user.password = "1";
            user.nationality = "Turkish";
            _userService.Add(user);
        }
    }
}
