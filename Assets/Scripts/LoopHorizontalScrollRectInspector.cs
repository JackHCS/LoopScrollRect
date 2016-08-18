using UnityEngine.UI;
using UnityEditor;

[CustomEditor(typeof(LoopHorizontalScrollRect), true)]
public class LoopHorizontalScrollRectInspector : Editor
{
	public override void OnInspectorGUI ()
	{
		LoopScrollRect scroll = (LoopScrollRect)target;
		LoopScrollRectInspector.LoopScrollRectStandardOnInspectorGUI(scroll);
		LoopScrollRectInspector.ScrollRectStandardOnInspectorGUI(scroll);

		// Stripped down to just the Vertical fields needed to be seen
		scroll.horizontalScrollbar = (Scrollbar)EditorGUILayout.ObjectField("Scrollbar", scroll.horizontalScrollbar, typeof(Scrollbar), true);
		scroll.horizontalScrollbarVisibility = (LoopScrollRect.ScrollbarVisibility)EditorGUILayout.EnumPopup("Scrollbar Visibility", (System.Enum)scroll.horizontalScrollbarVisibility);
		scroll.horizontalScrollbarSpacing = EditorGUILayout.FloatField("Scrollbar Spacing", scroll.horizontalScrollbarSpacing);
	}
}