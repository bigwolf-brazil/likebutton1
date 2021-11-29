using System.Linq;
using BlazorApp.Repository;

namespace BlazorApp.Controllers
{
    public class HomeController : Controllers
    {
        public ActionResult Index()
        {
            var repository = new PostRepository();
            var post = repository.GetById(1);

            var model = new IndexViewModel
            {
                Post = post,
                PostLikes = post.PostLikes.Count(e => e.UserLike)
            };

            return View(model);
        }

        public ActionResult About ()
        {
            ViewBag.Message = "Your application description page";

            return View();
        }

        public ActionResult Contact ()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}