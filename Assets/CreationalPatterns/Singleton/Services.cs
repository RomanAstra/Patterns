using System;
using System.Threading;
using UnityEngine;


namespace Singleton
{
    public sealed class Services
    {
        #region Fields
        
        private static readonly Lazy<Services> _instance = 
            new Lazy<Services>(() => new Services(), LazyThreadSafetyMode.ExecutionAndPublication);

        #endregion


        #region ClassLifeCycles

        private Services()
        {
            Initialize();
        }

        #endregion
        
        
        #region Properties

        public static Services Instance => _instance.Value;
        
        #endregion
        
        
        #region Methods
        
        private void Initialize()
        {
        }

        public void Test()
        {
            Debug.Log(nameof(Services));
        }
        
        #endregion
    }
}
