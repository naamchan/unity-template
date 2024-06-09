#nullable enable

using Microsoft.Extensions.Logging;
using VContainer.Unity;

public class TestView : IStartable
{
    private ILogger<TestView> logger;

    public TestView(ILogger<TestView> logger)
    {
        this.logger = logger;
    }

    public void Start()
    {
        logger.LogDebug($"test");
    }
}

namespace System.Runtime.CompilerServices
{
}