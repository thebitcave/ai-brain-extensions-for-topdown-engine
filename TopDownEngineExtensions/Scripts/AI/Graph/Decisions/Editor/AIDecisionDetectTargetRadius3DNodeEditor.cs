using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIDecisionDetectTargetRadius3DNode))]
    public class AIDecisionDetectTargetRadius3DNodeEditor : AIDecisionNodeEditor
    {
        private SerializedProperty _radius;
        private SerializedProperty _detectionOriginOffset;
        private SerializedProperty _targetLayerMask;
        private SerializedProperty _obstacleMask;
        private SerializedProperty _targetCheckFrequency;
        
        public override void OnBodyGUI()
        {
            base.OnBodyGUI();
            
            _radius = serializedObject.FindProperty("radius");
            _detectionOriginOffset = serializedObject.FindProperty("detectionOriginOffset");
            _targetLayerMask = serializedObject.FindProperty("targetLayerMask");
            _obstacleMask = serializedObject.FindProperty("obstacleMask");
            _targetCheckFrequency = serializedObject.FindProperty("targetCheckFrequency");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 150;
            NodeEditorGUILayout.PropertyField(_radius);
            NodeEditorGUILayout.PropertyField(_detectionOriginOffset);
            NodeEditorGUILayout.PropertyField(_targetLayerMask);
            NodeEditorGUILayout.PropertyField(_obstacleMask);
            NodeEditorGUILayout.PropertyField(_targetCheckFrequency);
            serializedObject.ApplyModifiedProperties();
        }
    }
}