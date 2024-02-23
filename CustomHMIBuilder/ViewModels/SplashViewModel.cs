using ReactiveUI;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CustomHMIBuilder.ViewModels;

internal class SplashViewModel : ViewModelBase
{
    
    private double _progressValue;
    public double ProgressValue
    {
        get => _progressValue;
        set => this.RaiseAndSetIfChanged(ref _progressValue, value);
    }
    
    private string _startUpMessage = "Загрузка приложения...";

    public string StartUpMessage
    {
        get { return _startUpMessage; }
        set {
            this.RaiseAndSetIfChanged(ref _startUpMessage, value); 
        }
    }

    public CancellationTokenSource _cts = new CancellationTokenSource();
    public CancellationToken CancellationToken => _cts.Token;
    public void Cancel()
    {
        _cts.Cancel();
    }
    
}