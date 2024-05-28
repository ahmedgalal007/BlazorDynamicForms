using MudBlazor;
using System;

namespace FormsBuilder.Components.Grid;

public class RowContainer
{
    public RowContainer(int index )
    {
        Index = index;
        Name = "row_" + index.ToString("D2");
        RowCells = new List<RowCell>();
    }
    public int Index { get; set; }
    public string Name { get; set; }
    public List<RowCell> RowCells { get; set; }

    public void AddCell(int index=0)
    {
        if(GetRowCols() < 12)
            RowCells.Insert(index, RowCell.Create(this, 12 - GetRowCols() ));
    }

    public void UpdateCellCols(int cellIndex,int cahngeamount)
    {
        int newValue = GetRowCols() + cahngeamount;
        if (newValue < 1 || newValue > 12) return;
        RowCells[cellIndex].ChangeCols(cahngeamount);
    }

    public int GetRowCols()
    {
        return RowCells.Select(e => e.Cols).Sum();
    }

    public string UpdateName()
    {
        Name = "row_" + Index.ToString("D2");
        return Name;
    }

    public string GetIdentifier(int colIdx)
    {
        return Name + "_col_" + colIdx.ToString("D2");
    }
}
