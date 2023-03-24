using ChallangeApp;

User user1= new User("Adam", "haslo1");
User user2= new User("Zuza", "haslo2");
User user3= new User("Anka", "haslo3");
User user4= new User("Monika", "haslo4");


var name = user1.Login;

user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
Console.WriteLine(result);
var name1 = User.GameName;
var pi = Math.PI;



