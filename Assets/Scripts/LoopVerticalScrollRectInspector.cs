using UnityEngine.UI;
using UnityEditor;

[CustomEditor(typeof(LoopVerticalScrollRect), true)]
public class LoopVerticalScrollRectInspector : Editor
{
	public override void OnInspectorGUI ()
	{
		LoopScrollRect scroll = (LoopScrollRect)target;
		LoopScrollRectInspector.LoopScrollRectOnInspectorGUI(scroll);
		LoopScrollRectInspector.ScrollRectOnInspectorGUI(scroll);

		// Stripped down to just the Vertical fields needed to be seen
		scroll.verticalScrollbar = (Scrollbar)EditorGUILayout.ObjectField("Scrollbar", scroll.verticalScrollbar, typeof(Scrollbar), true);
		scroll.verticalScrollbarVisibility = (LoopScrollRect.ScrollbarVisibility)EditorGUILayout.EnumPopup("Scrollbar Visibility", (System.Enum)scroll.verticalScrollbarVisibility);
		scroll.verticalScrollbarSpacing = EditorGUILayout.FloatField("Scrollbar Spacing", scroll.verticalScrollbarSpacing);

		LoopScrollRectInspector.ScrollScrolIndexEventGUI(serializedObject);
	}
}