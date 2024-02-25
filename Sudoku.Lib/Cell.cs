namespace Sudoku.Lib;

public class Cell
{
    public int Value { get; set; }
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

    public bool IsOneVisible { get; set; } = false;
    public bool IsTwoVisible { get; set; } = false;
    public bool IsThreeVisible { get; set; } = true;
    public bool IsFourVisible { get; set; } = false;
    public bool IsFiveVisible { get; set; } = true;
    public bool IsSixVisible { get; set; } = false;
    public bool IsSevenVisible { get; set; } = true;
    public bool IsEightVisible { get; set; } = true;
    public bool IsNineVisible { get; set; } = false;
}
