namespace TestAutomationFramework.Core.Utilities
{
    public static class RetryHelper
    {
        public static void Retry(Action action, int maxRetries = 3, int delayBetweenRetriesMs = 1000)
        {
            int retries = 0;
            while (true)
            {
                try
                {
                    action();
                    return;
                }
                catch
                {
                    if (++retries >= maxRetries)
                        throw;

                    Thread.Sleep(delayBetweenRetriesMs);
                }
            }
        }
    }
}
