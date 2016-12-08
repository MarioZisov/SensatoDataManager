namespace SensatoClient.Presenters
{
    using Models;

    public abstract class AbstractPresenter
    {
        protected abstract void SubscribeEvents();
        public UserModel User { get; set; }
    }
}