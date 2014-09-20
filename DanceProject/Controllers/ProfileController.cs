using System.Linq;

namespace DanceProject.Controllers
{
    using System.Web.Mvc;
    using Repository;
    using DomainLayer;

    public class ProfileController : Controller
    {
        private readonly IRepository<Profile> _repository;

        public ProfileController()
        {
            _repository = new GenericRepository<Profile>(new Context());
        }

        public ViewResult List()
        {
            return View(_repository.Find(p => true));
        }

        [HttpPost]
        public ActionResult AddProfile(Profile profile)
        {
            if (this._repository.Find(p => p.Name == profile.Name) != null)
            {
                this._repository.Add(profile);
            }
            return View("List", _repository.Find(p => true));
        }

        [HttpGet]
        public ActionResult DeleteProfile(int profile)
        {
            _repository.Delete(_repository.Find(p => p.Id == profile).First());
            return View("List", _repository.Find(p => true));
        }

        [HttpGet]
        public ActionResult UpdateProfile(Profile profile)
        {
            //_repository.Update(_repository.Find(p => p.Id == profile).First());
            return View("List", _repository.Find(p => true));
        }
    }
}
