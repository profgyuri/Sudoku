namespace Sudoku.Lib;

public class Cell
{
    public int Value { get; set; }
    public bool IsValueVisible => Value != 0;
    public PencilMarks PencilMarks { get; set; } = new PencilMarks();

    public static implicit operator Cell(int value)
    {
        return new Cell { Value = value };
    }

    public static explicit operator int(Cell cell)
    {
        return cell.Value;
    }
}

public class PencilMarks
{
    public int[] Marks { get; set; } = new int[9];

    public bool IsOneVisible { get; set; }
    public bool IsTwoVisible { get; set; }
    public bool IsThreeVisible { get; set; }
    public bool IsFourVisible { get; set; }
    public bool IsFiveVisible { get; set; }
    public bool IsSixVisible { get; set; }
    public bool IsSevenVisible { get; set; }
    public bool IsEightVisible { get; set; }
    public bool IsNineVisible { get; set; }

    public void MakeAllInvisible()
    {
        IsOneVisible = false;
        IsTwoVisible = false;
        IsThreeVisible = false;
        IsFourVisible = false;
        IsFiveVisible = false;
        IsSixVisible = false;
        IsSevenVisible = false;
        IsEightVisible = false;
        IsNineVisible = false;
    }
}
