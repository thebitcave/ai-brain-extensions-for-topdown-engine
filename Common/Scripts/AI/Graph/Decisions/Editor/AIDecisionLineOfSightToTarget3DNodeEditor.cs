using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIDecisionLineOfSightToTarget3DNode))]
    public class AIDecisionLineOfSightToTarget3DNodeEditor : AIDecisionNodeEditor
    {
        private SerializedProperty _obstacleLayerMask;
        private SerializedProperty _lineOfSightOffset;
        
        protected override void SerializeAdditionalProperties()
        {
            _obstacleLayerMask = serializedObject.FindProperty("obstacleLayerMask");
            _lineOfSightOffset = serializedObject.FindProperty("lineOfSightOffset");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 120;
            NodeEditorGUILayout.PropertyField(_obstacleLayerMask);
            NodeEditorGUILayout.PropertyField(_lineOfSightOffset);
            serializedObject.ApplyModifiedProperties();
        }
    }
}