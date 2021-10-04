/**
* @author Ivan Jakovljevic (ivan_jakovljevic@outlook.com)
* @since 7/31/2020
*/
namespace realworld.main.storage
{
    public class StorageSingleton
    {
        private static Storage storageInstance;

        public static Storage storageData()
        {
            if (storageInstance == null)
            {
                storageInstance = new Storage();
            }
            return storageInstance;
        }
    }
}
