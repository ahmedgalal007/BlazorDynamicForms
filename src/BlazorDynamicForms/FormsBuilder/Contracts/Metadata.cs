using FormsBuilder.Constants;
using MudBlazor;
using MudBlazor.Extensions;

public class MetaDataItem
{
    public MetaDataItem(string name, EnumValueTypes dataType, InputType inputType,  int cols = 12, bool required = false, string? format = "", string? value = "")
    {
        Name = name;
        DataType = dataType;
        InputType = inputType;
        Required = required;
        Cols = cols;
        Format = format;
        Value = value;
    }
    public string Name { get; set; } = string.Empty;
    public bool Required { get; set; } = false;
    public EnumValueTypes DataType { get; set; }
    public InputType InputType { get; set; }
    public int Cols { get; set; } = 12;
    public string? Value { get; set; } = string.Empty;
    public string Format { get; set; } = string.Empty;

    public int ValueAsInt
    {
        get { return !String.IsNullOrWhiteSpace(Value)? int.Parse(Value) : 0; }
        set { Value = value.ToString(); }
    }

    public DateTime? ValueAsDateTime
    {
        get { return !String.IsNullOrWhiteSpace(Value) ? DateTime.Parse(Value): null; }
        set { Value = value.ToString(); }
    }

    public override bool Equals(object o)
    {
        var other = o as PropertyValueType;
        return other?.Name == Name;
    }

    // Note: this is important too!
    public override int GetHashCode() => Name?.GetHashCode() ?? 0;

    // Implement this for the Pizza to display correctly in MudSelect
    public override string ToString() => Name;

    //public TimeSpan? ValueAsTimeSpane
    //{
    //    get { return Value as TimeSpan?; }
    //    set { Value = value; }
    //} 

    //public Boolean ValueAsBoolean
    //{
    //    get { return (Boolean)Value ? (Boolean)Value : false; }
    //    set { Value = value; }
    //}
    //public string ValueAsText {
    //    get { return (string)Value; }
    //    set { Value = value; }
    //}

}

public enum EnumValueTypes
{
    Number,
    DateTime,
    Boolean,
    Select,
    Option,
    Date,
    Time,
    TimeSpan,
    Text,
    Object,
    Null
}
