using UnityEngine.UI;
using UnityEditor;

[CustomEditor(typeof(LoopHorizontalScrollRect), true)]
public class LoopHorizontalScrollRectInspector : Editor
{
	public override void OnInspectorGUI ()
	{
		LoopScrollRect scroll = (LoopScrollRect)target;
		LoopScrollRectInspector.LoopScrollRectOnInspectorGUI(scroll);
		LoopScrollRectInspector.ScrollRectOnInspectorGUI(scroll);

		// Stripped down to just the Vertical fields needed to be seen
		scroll.horizontalScrollbar = (Scrollbar)EditorGUILayout.ObjectField("Scrollbar", scroll.horizontalScrollbar, typeof(Scrollbar), true);
		scroll.horizontalScrollbarVisibility = (LoopScrollRect.ScrollbarVisibility)EditorGUILayout.EnumPopup("Scrollbar Visibility", (System.Enum)scroll.horizontalScrollbarVisibility);
		scroll.horizontalScrollbarSpacing = EditorGUILayout.FloatField("Scrollbar Spacing", scroll.horizontalScrollbarSpacing);

		LoopScrollRectInspector.ScrollScrolIndexEventGUI(serializedObject);
	}
}