using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIDecisionDetectTargetRadius2DNode))]
    public class AIDecisionDetectTargetRadius2DNodeEditor : AIDecisionNodeEditor
    {
        private SerializedProperty _radius;
        private SerializedProperty _detectionOriginOffset;
        private SerializedProperty _targetLayer;
        private SerializedProperty _obstacleDetection;
        private SerializedProperty _obstacleMask;
        private SerializedProperty _obstaclesDetectionMode;
        private SerializedProperty _canTargetSelf;
        private SerializedProperty _targetCheckFrequency;
        private SerializedProperty _overlapMaximum;

        public override void OnBodyGUI()
        {
            base.OnBodyGUI();
            
            _radius = serializedObject.FindProperty("radius");
            _detectionOriginOffset = serializedObject.FindProperty("detectionOriginOffset");
            _targetLayer = serializedObject.FindProperty("targetLayer");
            _obstacleDetection = serializedObject.FindProperty("obstacleDetection");
            _obstacleMask = serializedObject.FindProperty("obstacleMask");
            _obstaclesDetectionMode = serializedObject.FindProperty("obstaclesDetectionMode");
            _canTargetSelf = serializedObject.FindProperty("canTargetSelf");
            _targetCheckFrequency = serializedObject.FindProperty("targetCheckFrequency");
            _overlapMaximum = serializedObject.FindProperty("overlapMaximum");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 160;
            NodeEditorGUILayout.PropertyField(_radius);
            NodeEditorGUILayout.PropertyField(_detectionOriginOffset);
            NodeEditorGUILayout.PropertyField(_targetLayer);
            NodeEditorGUILayout.PropertyField(_obstacleDetection);
            NodeEditorGUILayout.PropertyField(_obstacleMask);
            NodeEditorGUILayout.PropertyField(_obstaclesDetectionMode);
            NodeEditorGUILayout.PropertyField(_canTargetSelf);
            NodeEditorGUILayout.PropertyField(_targetCheckFrequency);
            NodeEditorGUILayout.PropertyField(_overlapMaximum);
            serializedObject.ApplyModifiedProperties();
        }
    }
}