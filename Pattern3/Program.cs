using System;

namespace Pattern3
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account("Sun123");
            Account acc2 = new Account("Sky777");

            acc1.AddAccount(acc2);
            acc2.AddAccount(acc1);

            acc1.AddPhotos("Mountain");
            acc1.AddPhotos("Lake");
            acc1.AddPhotos("Park");

            acc2.AddPhotos("Elephant");
            acc2.AddPhotos("Flower");
            acc2.AddPhotos("Vacation");
        }
    }
}
