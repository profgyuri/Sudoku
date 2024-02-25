namespace Sudoku.Lib;

using CommunityToolkit.Mvvm.ComponentModel;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty] private Cell[,] _board = new Cell[9, 9];

    public MainWindowViewModel()
    {
        Board = new Cell[9, 9]
        {
            { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 2, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 8, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 7, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 6, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 5, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 4, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 3, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 2, 0 }
        };
    }
}
