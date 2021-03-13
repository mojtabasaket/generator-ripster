using Template.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Template.Services.Utilities
{
    [Bean]
    [Scope(Common.Enums.ServiceLifetime.Singleton)]
    public class ReflectionUtilite
    {
        private readonly IServiceProvider _provider;
        public ReflectionUtilite(IServiceProvider provider)
        {
            _provider = provider;
        }

        public async Task<R> CallMethod<C, R>(string MethodName, object[] input)
        {
            ConstructorInfo Constructor = typeof(C).GetConstructor(new Type[] { typeof(IServiceProvider) });
            object ClassObject = Constructor.Invoke(new object[] { _provider });
            var method = typeof(C).GetMethod(MethodName, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
            var task = (Task)method.Invoke(ClassObject, input);
            await task.ConfigureAwait(false);

            var resultProperty = task.GetType().GetProperty("Result");
            return ((R)resultProperty.GetValue(task));
            //   return ((R)result);
        }
    }
}
