namespace SensatoClient.Presenters
{
    using Models;

    public abstract class AbstractPresenter
    {
        public UserModel User { get; set; }

        protected abstract void SubscribeEvents();
    }
}