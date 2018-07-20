using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GameObjectGameEvent))]
public class GameObjectGameEventEditor : Editor {

    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();
        EditorGUILayout.HelpBox("This Game-Event passes along a GameObject", MessageType.Info, true);
        EditorGUILayout.HelpBox("The receiver of this event can potentially manipulate the GameObject that has been sent", MessageType.Warning, true);
        GameObjectGameEvent e = (GameObjectGameEvent)target;

        GUI.enabled = Application.isPlaying;
        e.debugGameObject = (GameObject)EditorGUILayout.ObjectField("Debug Object", e.debugGameObject, typeof(GameObject), true);
        if (GUILayout.Button("Raise"))
        {
            e.Raise(e.debugGameObject);
            e.DebugMessage();
        }
    }
}
