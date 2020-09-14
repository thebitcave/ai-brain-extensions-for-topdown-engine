using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionUnityEventsNode))]
    public class AIActionUnityEventsNodeEditor : AIActionNodeEditor
    {
//        private SerializedProperty _targetEvent;
        private SerializedProperty _onlyPlayWhenEnteringState;

        protected override void SerializeAdditionalProperties()
        {
//            _targetEvent = serializedObject.FindProperty("targetEvent");
            _onlyPlayWhenEnteringState = serializedObject.FindProperty("onlyPlayWhenEnteringState");

            serializedObject.Update();
//            NodeEditorGUILayout.PropertyField(_targetEvent);
            EditorGUIUtility.labelWidth = 175;
            NodeEditorGUILayout.PropertyField(_onlyPlayWhenEnteringState);
            serializedObject.ApplyModifiedProperties();
            EditorGUILayout.Space();
            EditorGUILayout.HelpBox(
                "Target Event property is hidden in this node. You will have to manually add it once the generator has been executed (this means you cannot use it with the AIBrainPluggable).",
                MessageType.Warning);
        }
    }
}