using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoC_RestFull.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoC_RestFull.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FriendsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<FriendModel> Get()
        {
             var friends = new List<FriendModel>();

            friends.Add(new FriendModel { Id = 1, Nombre = "Jhon" });
            friends.Add(new FriendModel { Id = 2, Nombre = "Mary" });

            return friends;
        }
    }
}
