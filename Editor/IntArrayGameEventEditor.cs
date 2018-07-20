using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(IntArrayGameEvent))]
public class IntArrayGameEventEditor : Editor {

    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();
        EditorGUILayout.HelpBox("This Game-Event passes along an array of integers", MessageType.Info, true);
        EditorGUILayout.HelpBox("The receiver of this event can potentially manipulate the array that has been sent", MessageType.Warning, true);
        IntArrayGameEvent e = (IntArrayGameEvent)target;

        GUI.enabled = Application.isPlaying;
        SerializedProperty debugArray = serializedObject.FindProperty("debugFloatArray");
        EditorGUILayout.PropertyField(debugArray, true);
        if (GUILayout.Button("Raise"))
        {
            e.Raise(e.debugFloatArray);
            e.DebugMessage();
        }
        serializedObject.ApplyModifiedProperties();
    }
}
