using System;
using System.Collections.Generic;


namespace ServiceLocator
{
    public static class ServiceLocator
    {
        private static readonly Dictionary<Type, object> _servicecontainer = 
            new Dictionary<Type, object>();

        public static void SetService<T>(T value) where T : class
        {
            var typeValue = value.GetType();
            if (!_servicecontainer.ContainsKey(typeValue))
            {
                _servicecontainer[typeValue] = value;
            }
        }
 
        public static T Resolve<T>()
        {
            return (T)_servicecontainer[typeof(T)];
        }
    }
}
