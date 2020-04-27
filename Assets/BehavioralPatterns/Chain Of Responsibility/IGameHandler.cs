namespace ChainOfResponsibility
{
    public interface IGameHandler
    {
        void Handle(); //вернуть пришедший объект с некоторыми модификациями Handle(прихордит объект);
        IGameHandler SetNext(IGameHandler nextHandler);
    }
}
