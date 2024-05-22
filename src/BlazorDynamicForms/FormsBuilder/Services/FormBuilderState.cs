using System.Reflection.Metadata.Ecma335;

namespace FormsBuilder.Services;
public class FormBuilderState
{
	private readonly List<MetaDataItem> metaDatas = new();
	public FormBuilderState()
	{
			
	}

	public List<MetaDataItem> Metadatas => metaDatas;
}
