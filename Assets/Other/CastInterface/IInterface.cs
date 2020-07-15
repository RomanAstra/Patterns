using System;
using System.Collections.Generic;

namespace Other.CastInterface
{
    public interface IInterface
    {
        void Do(IAction action);
    }

    public interface IAction { }

    public sealed class Move : IAction { }
    
    public sealed class Rotation : IAction { }

    public abstract class DoAction<T> : IInterface where T : IAction
    {
        public void Do(IAction action)
        {
            Do((T) action);
        }

        protected abstract void Do(T action);
    }

    public sealed class MoveExecutor : DoAction<Move>
    {
        protected override void Do(Move action)
        {
            throw new System.NotImplementedException();
        }
    }

    public sealed class RotationExecutor : DoAction<Rotation>
    {
        protected override void Do(Rotation action)
        {
            throw new System.NotImplementedException();
        }
    }

    public sealed class Executor
    {
        private readonly Dictionary<Type, IInterface> _actionExecutors = new Dictionary<Type, IInterface>();

        public void AddActionExecutor<T>(DoAction<T> frameActionExecutor) where T : class, IAction
        {
            _actionExecutors.Add(typeof(T), frameActionExecutor);
        }

        private void ExecuteSpecific(IAction action)
        {
            _actionExecutors[action.GetType()].Do(action);
        }
    }
}
