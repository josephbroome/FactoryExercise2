
using FactoryPatternExercise2;
Console.WriteLine("What Databays type do you want to use, SQL, List or Mongo?");

string userDatabase= Console.ReadLine();

IDataAccess databasetype= DataAccessFactory.GetDataAccessType(userDatabase);

databasetype.LoadData();

databasetype.SaveData();

