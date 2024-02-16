using Realms;

namespace XamarinForms.LocationService.Services
{
    public static class RealmService
    {
        public static Realm GetRealm() => Realm.GetInstance();
    }
}
