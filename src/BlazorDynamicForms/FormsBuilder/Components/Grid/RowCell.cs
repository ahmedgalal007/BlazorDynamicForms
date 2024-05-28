using MudBlazor;

namespace FormsBuilder.Components.Grid;

public class RowCell
{
    private RowCell()
    {

    }
    public int Cols { get; private set; } = 12;
    RowContainer Row { get; set; }
    //public string Place { get; set; }
    //public string Icon { get; init; }
    //public Color Color { get; init; }
    //public bool IsRotten { get; set; }
    //public bool IsPicked { get; set; }
    public static RowCell Create(RowContainer row, int cols)
    {
        return new() { Row = row, Cols = cols };
    }
    public void ChangeCols(int changeamount)
    {
        int newValue = Cols + changeamount;
        if (newValue < 1 || newValue > 12) return;
        Cols = newValue;
    }
}