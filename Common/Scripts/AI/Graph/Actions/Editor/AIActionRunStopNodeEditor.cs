using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using UnityEngine;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionRunStopNode))]
    public class AIActionRunStopNodeEditor : AIActionNodeEditor
    {
        private SerializedProperty _onlyRunOnce;

        protected override void SerializeAdditionalProperties()
        {
            _onlyRunOnce = serializedObject.FindProperty("onlyRunOnce");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 100;
            NodeEditorGUILayout.PropertyField(_onlyRunOnce);
            serializedObject.ApplyModifiedProperties();
        }
    }
}