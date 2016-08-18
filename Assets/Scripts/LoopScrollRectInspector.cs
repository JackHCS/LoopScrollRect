#if UNITY_EDITOR
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

[CustomEditor(typeof(LoopScrollRect), true)]
public class LoopScrollRectInspector : Editor
{
	public override void OnInspectorGUI ()
	{
		LoopScrollRect scroll = (LoopScrollRect)target;
		LoopScrollRectOnInspectorGUI(scroll);

		base.OnInspectorGUI ();
	}

	public static void LoopScrollRectOnInspectorGUI(LoopScrollRect scroll)
	{
		scroll.initInStart = EditorGUILayout.Toggle("Init in Start", scroll.initInStart);
		scroll.prefabPool = (MarchingBytes.EasyObjectPool)EditorGUILayout.ObjectField("Prefab Pool", scroll.prefabPool, typeof(MarchingBytes.EasyObjectPool), true);
		scroll.prefabPoolName = EditorGUILayout.TextField("Prefab Pool Name", scroll.prefabPoolName);
		scroll.totalCount = EditorGUILayout.IntField("Total Count", scroll.totalCount);
		scroll.threshold = Mathf.Max(10, EditorGUILayout.FloatField("Threshold", scroll.threshold));
		scroll.reverseDirection = EditorGUILayout.Toggle("Reverse Direction", scroll.reverseDirection);
		EditorGUILayout.BeginHorizontal();
		if (GUILayout.Button("Clear Cells"))
		{
			scroll.ClearCells();
		}
		if (GUILayout.Button("Refill Cells"))
		{
			scroll.RefillCells();
		}
		EditorGUILayout.EndHorizontal();
	}

	public static void ScrollRectOnInspectorGUI(LoopScrollRect scroll)
	{
		scroll.content = (RectTransform)EditorGUILayout.ObjectField("Content", scroll.content, typeof(RectTransform), true);
		scroll.movementType = (LoopScrollRect.MovementType)EditorGUILayout.EnumPopup("Movement Type", (System.Enum)scroll.movementType);
		scroll.elasticity = EditorGUILayout.FloatField("Elasticity", scroll.elasticity);
		scroll.inertia = EditorGUILayout.Toggle("Inertia", scroll.inertia);
		scroll.decelerationRate = EditorGUILayout.FloatField("Deceleration Rate", scroll.decelerationRate);
		scroll.scrollSensitivity = EditorGUILayout.FloatField("Scroll Sensitivity", scroll.scrollSensitivity);
		scroll.viewport = (RectTransform)EditorGUILayout.ObjectField("Viewport", scroll.viewport, typeof(RectTransform), true);
	}

	public static void ScrollScrolIndexEventGUI(SerializedObject serializedObject)
	{
		SerializedProperty onScrollCellIndex = serializedObject.FindProperty("onScrollCellIndex");
		EditorGUILayout.PropertyField(onScrollCellIndex);
		if(GUI.changed)
			serializedObject.ApplyModifiedProperties();
	}
}
#endif