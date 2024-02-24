using System.Threading;
using CustomHMIBuilder.ViewModels;
using ReactiveUI;

namespace CustomHMIBuilder.SplashScreen.ViewModel;

internal class SplashViewModel : ReactiveObject  
{
    
    private double _progressValue;
    public double ProgressValue
    {
        get => _progressValue;
        set => this.RaiseAndSetIfChanged(ref _progressValue, value);
    }
    
    private string? _startUpMessage;

    public string? StartUpMessage
    {
        get => _startUpMessage;
        set => this.RaiseAndSetIfChanged(ref _startUpMessage, value);
    }
    private readonly CancellationTokenSource _cts = new CancellationTokenSource();
    public CancellationToken CancellationToken => _cts.Token;
    public void Cancel()
    {
        _cts.Cancel();
    }
    
}