namespace ResourceSharing.Localization
{
    public class LocalizedResources
    {
        private static readonly AppResources _resources = new AppResources();

        public static AppResources Resources
        {
            get { return _resources; }
        }
    }
}