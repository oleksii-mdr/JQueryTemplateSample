namespace JQueryTemplateSample.Models.Container
{
    public class ContainerService
    {
        /// <summary>
        /// Returns lazily loaded Container
        /// </summary>
        public static IContainer Instance
        {
            get { return LazyLoadingContainerService.instance; }
        }

        #region Nested type: LazyLoadingContainerService

        internal class LazyLoadingContainerService
        {
            internal static readonly Container instance;

            static LazyLoadingContainerService()
            {
                instance = new Container();
                instance.Initialize();
            }
        }

        #endregion
    }
}