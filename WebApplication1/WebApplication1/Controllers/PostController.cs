using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.models;

namespace WebApplication1.Controllers
{
    public class PostController : Controller
    {
        private readonly AppDBContext _dbContext;
        // IUser InjectDep = null;

        /*
                public UserController(IUser Iu)
                {
                    this.InjectDep = Iu;
                   // _dbContext = new AppContext();
                }
        */
        public PostController(AppDBContext dbContext)
        {
            this._dbContext = dbContext;
            // _dbContext = new AppContext();
        }

        [HttpGet]
        public IEnumerable<Posts> getall()
        {
            return _dbContext.posts.ToList();

            /*   List<Posts> List = new List<Posts>();

               Posts a = new Posts();

               a.body = "ssdddssssss";
               a.id = 1234;
               a.title = "Hello";



               Posts b = new Posts();

               a.body = "Assdalto";
               a.id = 4444;
               a.title = "word";


               List.Add(a);

               List.Add(b);



               Users p = new Users();

               p.id = 0598178584;

               p.name = "Kayal";
               p.email = "moha@gg";

               p.phone = "09312";
               p.date = "2010";

               p.GetSetPost = List;
               //  _dbContext.users.Add(new Users() { id = 1000, name = "ali", email = "ali@gmail.com", phone = "0098", date = "2021/09/23" ,});
               _dbContext.users.Add(p);
               _dbContext.SaveChanges();
            */
            // return us;
        }
    }
}
