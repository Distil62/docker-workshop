db.createUser(
	{
		user: '$DATABASE_USERNAME',
		pwd: "$DATABASE_PASSWORD",
		roles : [
			{
				role : "readWrite",
				db: "$DATABASE_NAME"
			}
		]
	}
)
db.initCollection.insert({name: "Hello, world !"})