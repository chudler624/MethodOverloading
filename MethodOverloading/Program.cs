using MethodOverloading;

var answer = Methods.Add(1, 2);
Console.WriteLine(answer);


var answer2= Methods.Add(2.5m, 7.3m);
Console.WriteLine(answer2);


var answer3 = Methods.Add(2, 1, true);
Console.WriteLine(answer3);


var answer4 = Methods.Add(2, 1, false);
Console.WriteLine(answer4);