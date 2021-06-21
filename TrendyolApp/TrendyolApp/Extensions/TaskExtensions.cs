using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TrendyolApp.Extensions
{
    public static class TaskExtensions
    {
        public async static void Await(this Task task,Action ContinueWith = null,Action<Exception> errorCallBack = null)
        {
            try
            {
                await task;
                ContinueWith?.Invoke();
            }
            catch (Exception ex)
            {

                errorCallBack?.Invoke(ex);
            }
        }
    }
}
