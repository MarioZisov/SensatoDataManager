using System;

namespace SensatoClient.Contracts
{
    public interface IView
    {
        void BringToFront();

        object Invoke(Delegate method);
    }
}
