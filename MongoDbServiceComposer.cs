using MongoDbService;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;

namespace UmbracoExternalStorageWithMongoDB
{
	public sealed class MongoDbServiceComposer : IComposer
	{
		public void Compose(IUmbracoBuilder builder) => builder.Services.AddMongoDbServices();
	}
}
