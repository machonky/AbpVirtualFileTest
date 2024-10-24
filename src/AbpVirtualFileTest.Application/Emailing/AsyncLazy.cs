using System;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace AbpVirtualFileTest.Emailing;

/// <summary>
///  from https://devblogs.microsoft.com/pfxteam/asynclazyt/
/// </summary>
/// <typeparam name="T"></typeparam>
public class AsyncLazy<T> : Lazy<Task<T>>
{
    public AsyncLazy(Func<T> valueFactory) :
        base(() => Task.Factory.StartNew(valueFactory))
    { }

    public AsyncLazy(Func<Task<T>> taskFactory) :
        base(() => Task.Factory.StartNew(() => taskFactory()).Unwrap())
    { }

    public TaskAwaiter<T> GetAwaiter() { return Value.GetAwaiter(); }
}
