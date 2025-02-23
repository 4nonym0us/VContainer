using System;
using System.Collections.Generic;

namespace VContainer
{
    public interface IRegistration
    {
        Type ImplementationType { get; }
        IReadOnlyList<Type> InterfaceTypes { get; }
        Lifetime Lifetime { get; }
        int ExecutionOrder { get; }

        object SpawnInstance(IObjectResolver resolver);
    }
}
