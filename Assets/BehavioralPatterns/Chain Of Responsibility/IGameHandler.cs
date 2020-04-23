namespace ChainOfResponsibility
{
    public interface IGameHandler
    {
        void Handle();
        IGameHandler SetNext(IGameHandler nextHandler);
    }
}
