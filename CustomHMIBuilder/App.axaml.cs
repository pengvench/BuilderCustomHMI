using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using CustomHMIBuilder.MainWindows.Views;
using CustomHMIBuilder.SplashScreen.View;
using CustomHMIBuilder.SplashScreen.ViewModel;



namespace CustomHMIBuilder;

public class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override async void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            var splashWindow = new Splash();
            var splashViewModel = new SplashViewModel();

            splashWindow.DataContext = splashViewModel;
            desktop.MainWindow = splashWindow;

            var loadingMessages = new List<string>
            {
                "Пьем кофе",
                "Читаем википедию",
                "Гуглим код",
                "Открываем приложение"
            };

            double progressStep = 100.0 / (loadingMessages.Count * 3);
            
            try
            {
                foreach (var message in loadingMessages)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        splashViewModel.StartUpMessage = $"{message}{'.'.ToString().PadRight(i + 1, '.')}";
                        splashViewModel.ProgressValue += progressStep;
                        await Task.Delay(300, cancellationToken: splashViewModel.CancellationToken); 

                    }
                }
                splashViewModel.ProgressValue = 100;
            }
            catch (TaskCanceledException)
            {
                splashWindow.Close();
                return;
            }

            var mainWindow = new MainWindow();

            Thread.Sleep(500); 
            desktop.MainWindow = mainWindow;
            mainWindow.Show();
            splashWindow.Close();
            desktop.ShutdownMode = ShutdownMode.OnMainWindowClose;
        }

        base.OnFrameworkInitializationCompleted();
    }
}
