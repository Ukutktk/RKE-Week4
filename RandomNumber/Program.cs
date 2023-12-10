


Random rnd = new Random();

//Console.WriteLine(rnd);
int randomSum = 0;
int myRandomNum = rnd.Next(0, 10); //0-10

for(int i = 0; i < 12; i++)
{
    myRandomNum = rnd.Next(0, 10);
    randomSum = myRandomNum + randomSum;
    Console.WriteLine($"My random number is {myRandomNum}");
}

Console.WriteLine(randomSum);