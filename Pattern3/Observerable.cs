using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern3
{
    interface Observerable
    {
        void AddPhotos(String observer);
        void AddAccount(Observer observer);
        void removeAccount(Observer observer);
        void notifyAllAccounts();
    }
}
