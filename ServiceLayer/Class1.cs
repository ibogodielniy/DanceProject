namespace ServiceLayer
{
    using System.Collections.Generic;
    using DomainLayer;
    using Repository;
    using System.Reflection;
    using System.Linq;

    public class ProfileService
    {
        private IRepository<Profile> _profileRepository;

        public ProfileService(IRepository<Profile> profileRepository)
        {
            this._profileRepository = profileRepository;
        }

        public void AddProfile(Profile profile)
        {
            _profileRepository.Add(profile);
        }

        public void EditProfile(Profile profile)
        {
            if (_profileRepository.Find(repository => repository.Id == profile.Id) != null)
            {
                _profileRepository.Update(profile);
            }
        }

        public void RemoveProfile(Profile profile)
        {
            if (_profileRepository.Find(repository => repository.Id == profile.Id) != null)
            {
                _profileRepository.Delete(profile);
            }
        }

        public Profile GetProfile(string prop, PropertyInfo value)
        {
            PropertyInfo p = typeof(Profile).GetProperty(prop);
            return _profileRepository.Find(profile => profile.GetType().GetProperty(prop) == value).FirstOrDefault();
        }

        public IEnumerable<Profile> GetAllProfiles(string prop, PropertyInfo value)
        {
            PropertyInfo p = typeof(Profile).GetProperty(prop);
            return _profileRepository.Find(profile => profile.GetType().GetProperty(prop) == value);
        }

        public Profile GetProfile(int id)
        {
            return _profileRepository.Find(profile => profile.Id == id).First();
        }
    }
}
