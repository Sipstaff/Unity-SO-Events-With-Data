using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(BasicGameEvent))]
public class BasicGameEventEditor : Editor
{
    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();
        EditorGUILayout.HelpBox("This Game-Event does not pass any data", MessageType.Info, true);
        BasicGameEvent e = (BasicGameEvent)target;

        GUI.enabled = Application.isPlaying;
        if(GUILayout.Button("Raise"))
        {
            e.Raise();
            e.DebugMessage();
        }
    }
}
