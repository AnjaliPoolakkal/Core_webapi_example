using Member.Data.Interface;
using Member.Data.Model;
using Member.Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : Controller
    {
        private IMember members = new MembersRepository();

        [HttpGet]
        public ActionResult<IEnumerable<Members>> GetAllMembers()
        {
            return members.GetAllMember();
        }
        [HttpGet]
        public ActionResult<Members> GetMemberById(int id)
        {
            return members.GetMember(id);
        }
    }
}
