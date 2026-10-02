# What does this package do?
This package allows you to store your custom data in a NoSQL [MongoDB](https://www.mongodb.com/) database. 
Unlike most NoSQL databases, a MongoDB server can be installed on almost any platform, your laptop or on a Cloud service like AWS, GCP or Azure. It avoids vendor lock-in into any specific hosting platform.

It is built on [MongoDbService](https://github.com/prmeyn/MongoDbService) and registers it with Umbraco automatically, so you can inject `MongoService` anywhere in your site.

# Requirements
- Umbraco 17
- .NET 10

# Setup procedure
1. Setup a MongoDB server either [locally on your laptop](https://www.mongodb.com/try/download/community) or you can use the MongoDB [free hosting plan to create an instance on AWS, GCP or Azure.](https://www.mongodb.com/cloud/atlas/register)  
2. Update `appsettings.json` file with the connection string to the above database
```json
{
	"MongoDbSettings": {
		"ConnectionString": "<mandatory> mongodb+srv://<user>:<password>@<cluster>.mongodb.net/?retryWrites=true&w=majority",
		"DatabaseName": "<optional, defaults to Untitled-MongoDbService>",
		"ConnectionRecordRetentionDays": 30
	}
}
```
3. Install this package

Sample code
```csharp
using MongoDB.Driver;
using MongoDbService;

public sealed class VehicleHandler
{
	private readonly IMongoCollection<Vehicle> _vehicleCollection;

	public VehicleHandler(MongoService mongoService)
	{
		_vehicleCollection = mongoService.Database.GetCollection<Vehicle>("YourCollectionName");
	}
}
```
For more examples on how to Insert, Modify your data, check the [MongoDbService documentation](https://github.com/prmeyn/MongoDbService) and the MongoDB official documentation: https://www.mongodb.com/docs/drivers/csharp/current/quick-reference/

# Upgrading from version 13
Version 17 is a breaking change:
- The configuration section is renamed from `MongoDbCredentials` to `MongoDbSettings`, and the database name now comes from `MongoDbSettings:DatabaseName`.
- `CertificateFilePathWithName` and `CertificatePassword` are no longer supported.
- The static `MongoDBClientConnection.GetDatabase("...")` is replaced by injecting `MongoService` and using `mongoService.Database`.
- MongoDbService writes a `ConnectionRecord` document each time the site connects. These are removed after `ConnectionRecordRetentionDays` (default 30).
- - - -
# Want to sponsor?
This is a free package, but if you want to sponsor my open source work, here is [my GitHub profile](https://github.com/sponsors/prmeyn)
