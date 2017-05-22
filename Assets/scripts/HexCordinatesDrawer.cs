using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(HexCordinates))]
public class HexCordinatesDrawer:PropertyDrawer{

	public override void OnGUI(
		Rect position,
		SerializedProperty property,
		GUIContent label){

		HexCordinates cordinate = new HexCordinates (
			                          property.FindPropertyRelative ("x").intValue,
			                          property.FindPropertyRelative ("z").intValue
		                          );
		position = EditorGUI.PrefixLabel (position, label);
		GUI.Label (position, cordinate.ToString ());
	}


}

