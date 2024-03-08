using System.Collections.Generic;
public class AOTGenericReferences : UnityEngine.MonoBehaviour
{

	// {{ AOT assemblies
	public static readonly IReadOnlyList<string> PatchedAOTAssemblyList = new List<string>
	{
		"UnityEngine.CoreModule.dll",
		"mscorlib.dll",
	};
	// }}

	// {{ constraint implement type
	// }} 

	// {{ AOT generic types
	// System.Action<int>
	// System.Collections.Generic.ArraySortHelper<int>
	// System.Collections.Generic.Comparer<int>
	// System.Collections.Generic.Dictionary.Enumerator<int,int>
	// System.Collections.Generic.Dictionary.KeyCollection.Enumerator<int,int>
	// System.Collections.Generic.Dictionary.KeyCollection<int,int>
	// System.Collections.Generic.Dictionary.ValueCollection.Enumerator<int,int>
	// System.Collections.Generic.Dictionary.ValueCollection<int,int>
	// System.Collections.Generic.Dictionary<int,int>
	// System.Collections.Generic.EqualityComparer<int>
	// System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<int,int>>
	// System.Collections.Generic.ICollection<int>
	// System.Collections.Generic.IComparer<int>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<int,int>>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Collections.Generic.IEnumerable<int>
	// System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<int,int>>
	// System.Collections.Generic.IEnumerator<int>
	// System.Collections.Generic.IEqualityComparer<int>
	// System.Collections.Generic.IList<int>
	// System.Collections.Generic.KeyValuePair<int,int>
	// System.Collections.Generic.KeyValuePair<object,object>
	// System.Collections.Generic.List.Enumerator<int>
	// System.Collections.Generic.List<int>
	// System.Collections.Generic.ObjectComparer<int>
	// System.Collections.Generic.ObjectEqualityComparer<int>
	// System.Collections.ObjectModel.ReadOnlyCollection<int>
	// System.Comparison<int>
	// System.Predicate<int>
	// }}

	public void RefMethods()
	{
		// object UnityEngine.GameObject.AddComponent<object>()
	}
}