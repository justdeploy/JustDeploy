using Common.Logging;
using StructureMap;

namespace JustDeploy.DI
{
	public static class DiContainer
	{
		private static ILog _logger;
		public static ILog Logger
		{
			get
			{
				return _logger ?? (_logger = LogManager.GetCurrentClassLogger());
			}
		}

		public static void Init()
		{
			Logger.Debug("Initializing Dependencies");
			ObjectFactory.Initialize(x => x.AddRegistry<DiRegistry>());
			Logger.Debug("Initializing Dependencies... Done");
		}
	}
}
