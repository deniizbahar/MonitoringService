using System;

namespace Günlük { 
    public class ConfigChangedEventArgs : EventArgs
    {
        public ServiceConfigDto NewConfig { get; set; }
    }
}

