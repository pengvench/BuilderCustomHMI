using ReactiveUI;
using System.Reactive;
using Avalonia.Controls;
using CustomHMIBuilder.Editor.View;
using CustomHMIBuilder.Editor.ViewModel;
using CustomHMIBuilder.Views;


namespace CustomHMIBuilder.ViewModels;

internal class MainWindowViewModel : ReactiveObject
{
    // public ReactiveCommand<Unit, Unit> OpenEditorCommand { get; }
    // private readonly Grid _mainGrid;
    //
    // public MainWindowViewModel(Grid mainGrid)
    // {
    //     _mainGrid = mainGrid;
    //     OpenEditorCommand = ReactiveCommand.Create(OpenEditorView);
    // }
    //
    // public void OpenEditorView()
    // {
    //     var _editorVM = new EditorVM();
    //     var _editorView = new EditorView()
    //     {
    //         DataContext = _editorVM
    //     };
    //     _mainGrid.Children.Add(_editorView);
    // }
}