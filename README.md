# What does this package do?
This package allows you to store your custom data in a NoSQL [MongoDB](https://www.mongodb.com/) database. 
Unlike most NoSQL databases, a MomgoDB server can be installed on almost any platform, your laptop or on a Cloud service like AWS, GCP or Azure. It avoids vendor lock in into any specific hosting platform.

# Setup procedure
Setup a MongoDB server either [locally on your laptop](https://www.mongodb.com/try/download/community) or you can use the MongoDB [free hosting plan to create an instance on AWS, GCP or Azure.](https://www.mongodb.com/cloud/atlas/register)  
Update `appsettings.json` file with the connection string to the above database
```json
{
	"MongoDbCredentials": {
	    "ConnectionString": "<mandatory> mongodb+srv://cluster0.fyu.mongodb.net/?authSource=%24external&authMechanism=MONGODB-X509&retryWrites=true&w=majority",
		"CertificateFilePathWithName": "<optional Certificate file path with name [pfx file]>",
	    "CertificatePassword": "<optional Certificate password>"
	  }
}
```
Install this package

Sample code
```csharp
var database = MongoDBClientConnection.GetDatabase("YouDatabaseName");
var collection = database.GetCollection<T>("YourCollectionName"); // of type T
```
For more examples on how to Insert, Modify your data, check the MongoDB official documentation: https://www.mongodb.com/docs/drivers/csharp/current/quick-reference/

# Want to sponsor?
This is a free package, but if you want to sponsor my open source work, here is [my GitHub profile](https://github.com/sponsors/prmeyn)
