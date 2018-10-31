using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern3
{
    class Account: Instagram
    {
        public string userName;


        private List<Observer> subscribers = new List<Observer>();
        private List<string> photos = new List<string>();

        public Account(string userName)
        {
            this.userName = userName;
        }

        public void AddAccount(Observer observer)
        {
            this.subscribers.Add(observer);
        }

        public void removeAccount(Observer observer)
        {
            this.subscribers.Remove(observer);
        }

        public void AddPhotos(string photo)
        {
            this.photos.Add(photo);
            notifyAllAccounts();
        }

        public void notifyAllAccounts()
        {
            foreach (var sub in subscribers)
            {
                sub.subscribe("New photo posted", this.userName);
            }
        }

        public void subscribe(string newpost, string userName)
        {
            Console.WriteLine(newpost, userName);
        }
    }
}
