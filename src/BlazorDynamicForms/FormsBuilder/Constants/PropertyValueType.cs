using FormsBuilder.Components.Editors;
using FormsBuilder.Contracts;
using MudBlazor;

namespace FormsBuilder.Constants;

public class PropertyValueType
{
    public static Dictionary<string, PropertyValueType> getBaseTypes()
    {
        return new Dictionary<string, PropertyValueType>
        {
            ["Array"] = new() { Name = "Array", IsSingle = false, Icon = Icons.Material.Filled.DataArray , ComponentType = typeof(BaseGenerator),
                MetaData = new()
                {
                     new MetaDataItem("Required", EnumValueTypes.Boolean, InputType.Text,6, false),
                     new MetaDataItem("Minimum", EnumValueTypes.Number, InputType.Number,6),
                     new MetaDataItem("Maximum", EnumValueTypes.Number, InputType.Number,6),
                     new MetaDataItem("Option", EnumValueTypes.Object, InputType.Text,6),
                }
            },
            ["Number"] = new() { Name = "Number", IsSingle = true, Icon = Icons.Material.Filled.Numbers , ComponentType = typeof(BaseGenerator),
                MetaData = new()
                {
                     new MetaDataItem("Required", EnumValueTypes.Boolean, InputType.Text,6, false),
                     new MetaDataItem("Minimum", EnumValueTypes.Number, InputType.Number,6),
                     new MetaDataItem("Maximum", EnumValueTypes.Number, InputType.Number,6),
                     new MetaDataItem("Option", EnumValueTypes.Number, InputType.Text,6),
                }
            },
            ["Date"] = new() { Name = "Date", IsSingle = true, Icon = Icons.Material.Filled.DateRange , ComponentType = typeof(BaseGenerator),
                MetaData = new()
                {
                     new MetaDataItem("Required", EnumValueTypes.Boolean, InputType.Text,6, false),
                     new MetaDataItem("Minimum", EnumValueTypes.Date, InputType.Date,6,false,"yyyy-MM-dd"),
                     new MetaDataItem("Maximum", EnumValueTypes.Date, InputType.Date,6,false,"yyyy-MM-dd"),
                     new MetaDataItem("Option", EnumValueTypes.Date, InputType.Date,6,false,"yyyy-MM-dd"),
                }
            },
            ["DateTime"] = new() { Name = "DateTime", IsSingle = true, Icon = Icons.Material.Filled.MoreTime , ComponentType = typeof(BaseGenerator),
                MetaData = new()
                {
                     new MetaDataItem("Required", EnumValueTypes.Boolean, InputType.Text,6, false),
                     new MetaDataItem("Minimum", EnumValueTypes.DateTime, InputType.DateTimeLocal,6,false,"s"),
                     new MetaDataItem("Maximum", EnumValueTypes.DateTime, InputType.DateTimeLocal,6,false,"s"),
                     new MetaDataItem("Option", EnumValueTypes.DateTime, InputType.DateTimeLocal,6,false,"s"),
                }
            },
            ["Object"] = new() { Name = "Object", IsSingle = true, Icon = Icons.Material.Filled.DataObject , ComponentType = typeof(BaseGenerator),
                MetaData = new()
                {
                     new MetaDataItem("Required", EnumValueTypes.Boolean, InputType.Text,6, false),
                     new MetaDataItem("Option", EnumValueTypes.Object, InputType.Text,6),
                }
            },
            ["Time"] = new() { Name = "Time", IsSingle = true, Icon = Icons.Material.Filled.AccessTime , ComponentType = typeof(BaseGenerator),
                MetaData = new()
                {
                     new MetaDataItem("Required", EnumValueTypes.Boolean, InputType.Text,6, false),
                     new MetaDataItem("Minimum", EnumValueTypes.Time, InputType.Time,6,false,"hh:mm TT"),
                     new MetaDataItem("Maximum", EnumValueTypes.Time, InputType.Time,6,false,"hh:mm TT"),
                     new MetaDataItem("Option", EnumValueTypes.Time, InputType.Time,6,false,"hh:mm TT"),
                }
            },
            ["Text"] = new() { Name = "Text", IsSingle = true, Icon = Icons.Material.Filled.TextFields , ComponentType = typeof(BaseGenerator),
                MetaData = new()
                {
                     new MetaDataItem("Required", EnumValueTypes.Boolean, InputType.Text,6, false),
                     new MetaDataItem("Minimum", EnumValueTypes.Text, InputType.Number,6),
                     new MetaDataItem("Maximum", EnumValueTypes.Text, InputType.Number,6),
                     new MetaDataItem("Option", EnumValueTypes.Text, InputType.Text,6),
                }
            },
        };
    }
    public string Name { get; set; }
    public string Icon { get; set; }
    public bool IsSingle { get; set; }
    public Type ComponentType { get; set; }
    // public BaseGenerator Generator { get; set; }
    public List<MetaDataItem> MetaData { get; set; } = new();

    public Dictionary<string, object> GetParameters()
    {
        Dictionary<string, object> MyProperties = new();
        MyProperties["MetaDatas"] = MetaData;
        //foreach (var item in MetaData)
        //{
        //    MyProperties.Add(item.Name, item);
        //}
        return MyProperties;
    }


    //public static readonly Dictionary<string, Type> components = new()
    //{
    //    ["Array"] = typeof(BaseGenerator),
    //    ["Number"] = typeof(NumberGenerator),
    //    ["Text"] = typeof(TextGenerator),
    //    ["Date"] = typeof(DateGenerator),
    //    ["DateTime"] = typeof(DateTimeGenerator),
    //    ["Time"] = typeof(TimeGenerator),
    //    ["Object"] = typeof(ObjectGenerator),
    //};

    // Note: this is important so the MudSelect can compare pizzas
    public override bool Equals(object o)
    {
        var other = o as PropertyValueType;
        return other?.Name == Name;
    }

    // Note: this is important too!
    public override int GetHashCode() => Name?.GetHashCode() ?? 0;

    // Implement this for the Pizza to display correctly in MudSelect
    public override string ToString() => Name;
    //public static Dictionary<string, ComponentMetadata> components2 =
    //    new()
    //    {
    //        [nameof(ArrayGenerator)] = new ComponentMetadata()
    //        {
    //            Type = typeof(ArrayGenerator),
    //            Name = "Array",
    //            // Parameters = { [nameof(ArrayGenerator.WindowSeat)] = false }
    //        },
    //        [nameof(TextGenerator)] = new ComponentMetadata()
    //        {
    //            Type = typeof(TextGenerator),
    //            Name = "Text"
    //        },
    //        [nameof(NumberGenerator)] = new ComponentMetadata()
    //        {
    //            Type = typeof(NumberGenerator),
    //            Name = "Number"
    //        },
    //        [nameof(DateTimeGenerator)] = new ComponentMetadata()
    //        {
    //            Type = typeof(DateTimeGenerator),
    //            Name = "DateTime"
    //        },
    //        [nameof(DateGenerator)] = new ComponentMetadata()
    //        {
    //            Type = typeof(DateGenerator),
    //            Name = "Date"
    //        },
    //        [nameof(TimeGenerator)] = new ComponentMetadata()
    //        {
    //            Type = typeof(TimeGenerator),
    //            Name = "Time"
    //        },
    //        [nameof(ObjectGenerator)] = new ComponentMetadata()
    //        {
    //            Type = typeof(ObjectGenerator),
    //            Name = "Object"
    //        }
    //    };
}