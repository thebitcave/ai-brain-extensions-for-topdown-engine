using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionMoveRandomly3DNode))]
    public class AIActionMoveRandomly3DNodeEditor : AIActionNodeEditor
    {
        private SerializedProperty _maximumDurationInADirection;
        private SerializedProperty _obstacleLayerMask;
        private SerializedProperty _obstaclesDetectionDistance;
        private SerializedProperty _obstaclesCheckFrequency;
        private SerializedProperty _minimumRandomDirection;
        private SerializedProperty _maximumRandomDirection;

        public override void OnBodyGUI()
        {
            base.OnBodyGUI();

            if (CollapseNodeOn) return;

            _maximumDurationInADirection = serializedObject.FindProperty("maximumDurationInADirection");
            _obstacleLayerMask = serializedObject.FindProperty("obstacleLayerMask");
            _obstaclesDetectionDistance = serializedObject.FindProperty("obstaclesDetectionDistance");
            _obstaclesCheckFrequency = serializedObject.FindProperty("obstaclesCheckFrequency");
            _minimumRandomDirection = serializedObject.FindProperty("minimumRandomDirection");
            _maximumRandomDirection = serializedObject.FindProperty("maximumRandomDirection");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 195;
            NodeEditorGUILayout.PropertyField(_maximumDurationInADirection);
            EditorGUIUtility.labelWidth = 160;
            NodeEditorGUILayout.PropertyField(_obstacleLayerMask);
            EditorGUIUtility.labelWidth = 170;
            NodeEditorGUILayout.PropertyField(_obstaclesDetectionDistance);
            NodeEditorGUILayout.PropertyField(_obstaclesCheckFrequency);
            NodeEditorGUILayout.PropertyField(_minimumRandomDirection);
            NodeEditorGUILayout.PropertyField(_maximumRandomDirection);
            serializedObject.ApplyModifiedProperties();
        }
    }
}