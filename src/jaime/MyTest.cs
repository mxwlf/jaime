using Microsoft.Extensions.Logging;

namespace mxwlf.net.Jaime
{
    public class MyTest : IMyTest
    {
        private readonly ILogger<MyTest> _logger;

        public MyTest(ILogger<MyTest> logger)
        {
            this._logger = logger;
        }
        public void Do()
        {
            this._logger.Log(LogLevel.Information, "yay I ran");
        }
    }
}