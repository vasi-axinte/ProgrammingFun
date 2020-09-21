using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    
    public class UsersController : ApiController
    {
        private Repository.UsersRepository _usersRepository;

        public UsersController()
        {
            _usersRepository = new Repository.UsersRepository();
        }

        [Route("api/User/Register")]
        [HttpPost]
        public void RegisterUser(AccountModel user)
        {
            _usersRepository.Register(user);
        }

        [Route("api/User/Login")]
        [HttpPost]
        public bool LoginUser(UserLoginCredentials user)
        {
           bool userExists = _usersRepository.Login(user);
           return userExists;
        }

        
    }
}