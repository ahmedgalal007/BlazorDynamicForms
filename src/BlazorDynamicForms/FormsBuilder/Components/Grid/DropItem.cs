using MudBlazor;

namespace FormsBuilder.Components.Grid;


public class DropItem
{
    public string Icon { get; init; }
    RowCell Column { get; set; }
    public bool IsPicked { get; set; }
    public Color Color { get; init; }
    public string Identifier { get; set; }
}
