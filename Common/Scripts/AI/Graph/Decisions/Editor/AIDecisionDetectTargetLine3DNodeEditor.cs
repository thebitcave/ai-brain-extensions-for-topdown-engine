using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIDecisionDetectTargetLine3DNode))]
    public class AIDecisionDetectTargetLine3DNodeEditor : AIDecisionNodeEditor
    {
        private SerializedProperty _detectMethod;
        private SerializedProperty _rayWidth;
        private SerializedProperty _detectionDistance;
        private SerializedProperty _detectionOriginOffset;
        private SerializedProperty _targetLayer;
        private SerializedProperty _obstaclesLayer;
//        private SerializedProperty _referenceTransform;
        private SerializedProperty _forceAimToDetectionDirection;

        public override void OnBodyGUI()
        {
            base.OnBodyGUI();
            
            _detectMethod = serializedObject.FindProperty("detectMethod");
            _rayWidth = serializedObject.FindProperty("rayWidth");
            _detectionDistance = serializedObject.FindProperty("detectionDistance");
            _detectionOriginOffset = serializedObject.FindProperty("detectionOriginOffset");
            _targetLayer = serializedObject.FindProperty("targetLayer");
            _obstaclesLayer = serializedObject.FindProperty("obstaclesLayer");
 //           _referenceTransform = serializedObject.FindProperty("referenceTransform");
            _forceAimToDetectionDirection = serializedObject.FindProperty("forceAimToDetectionDirection");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 120;
            NodeEditorGUILayout.PropertyField(_detectMethod);
            NodeEditorGUILayout.PropertyField(_rayWidth);
            NodeEditorGUILayout.PropertyField(_detectionDistance);
            NodeEditorGUILayout.PropertyField(_detectionOriginOffset);
            NodeEditorGUILayout.PropertyField(_targetLayer);
            NodeEditorGUILayout.PropertyField(_obstaclesLayer);
  //          NodeEditorGUILayout.PropertyField(_referenceTransform);
            EditorGUIUtility.labelWidth = 250;
            NodeEditorGUILayout.PropertyField(_forceAimToDetectionDirection);
            
            EditorGUILayout.HelpBox(
                "Reference Transform property is hidden. You will have to manually add it once the generator has been executed or assign it at runtime.",
                MessageType.Warning);

            serializedObject.ApplyModifiedProperties();
        }
    }
}