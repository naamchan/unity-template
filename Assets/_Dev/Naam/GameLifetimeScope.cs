#nullable enable

using Microsoft.Extensions.Logging;
using VContainer;
using VContainer.Unity;
using ZLogger.Unity;

public class GameLifetimeScope : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        builder.Register<ILoggerFactory>((_) =>
        {
            return LoggerFactory.Create((config) =>
            {
                config.SetMinimumLevel(LogLevel.Debug);
                config.AddZLoggerUnityDebug();
            });
        }, Lifetime.Singleton);

        builder.Register<ILogger<TestView>>((container) =>
        {
            var loggerFactory = container.Resolve<ILoggerFactory>();
            return loggerFactory.CreateLogger<TestView>();
        }, Lifetime.Singleton);

        builder.RegisterEntryPoint<TestView>(Lifetime.Singleton);
    }
}
