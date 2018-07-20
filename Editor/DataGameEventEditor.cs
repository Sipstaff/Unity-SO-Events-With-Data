using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(DataGameEvent))]
public class DataGameEventEditor : Editor {

    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();
        EditorGUILayout.HelpBox("This Game-Event passes along a EventData struct.\n Modify EventData to your needs", MessageType.Info, true);
        DataGameEvent e = (DataGameEvent)target;

        GUI.enabled = Application.isPlaying;
        SerializedProperty debugEventData = serializedObject.FindProperty("debugEventData");
        EditorGUILayout.PropertyField(debugEventData, true);
        if (GUILayout.Button("Raise"))
        {
            e.Raise(e.debugEventData);
            e.DebugMessage();
        }     
        serializedObject.ApplyModifiedProperties();
    }
}
