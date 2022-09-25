// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Person a = new Person(5000);
a.Account = 200;
a.Print();

class Person {
    int account;
// changed 123456
    public Person(int account){
        this.account = account;

    }
    public int Account
    {

        get { return account; } 
        set { account = value; }
    }

    internal void Print() =>  Console.WriteLine(account);

}