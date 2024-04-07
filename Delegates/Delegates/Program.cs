using IntroductionDelegates;

Test test = new Test();
AddNum a = new AddNum(test.Add);

a(12, 15);

Name n = new Name(Test.NameofPerson);

string s = n("Rifat");
Console.WriteLine(s);







PrintDelegate PrintConsole = (string text) =>
{
    Console.WriteLine(text);
};


PrintDelegate PrintFile = text => File.AppendAllText("./logs.txt", text);

PrintConsole("Hello World");
PrintFile("This is Rifat from SpaceX");


static void ConnectToDB(PrintDelegate log)
{
    log("Hello I am There");
}

ConnectToDB(PrintFile);


delegate void PrintDelegate(string text);

