using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionRotateConeOfVision2DNode))]
    public class AIActionRotateConeOfVision2DNodeEditor : AIActionNodeEditor
    {
        private SerializedProperty _mode;
        private SerializedProperty _interpolate;
        private SerializedProperty _interpolateRate;

        protected override void SerializeAdditionalProperties()
        {
            _mode = serializedObject.FindProperty("mode");
            _interpolate = serializedObject.FindProperty("interpolate");
            _interpolateRate = serializedObject.FindProperty("interpolateRate");

            serializedObject.Update();
            NodeEditorGUILayout.PropertyField(_mode);
            NodeEditorGUILayout.PropertyField(_interpolate);
            if (_interpolate.boolValue)
            {
                NodeEditorGUILayout.PropertyField(_interpolateRate);
            }
            serializedObject.ApplyModifiedProperties();
        }
    }
}