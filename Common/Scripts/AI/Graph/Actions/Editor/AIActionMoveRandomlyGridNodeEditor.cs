using MoreMountains.TopDownEngine;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionMoveRandomlyGridNode))]
    public class AIActionMoveRandomlyGridNodeEditor : AIActionNodeEditor
    {
        private SerializedProperty _mode;
        private SerializedProperty _maximumDurationInADirection;
        private SerializedProperty _obstacleLayerMask;
        private SerializedProperty _obstaclesDetectionDistance;
        private SerializedProperty _obstaclesCheckFrequency;
        private SerializedProperty _minimumRandomDirection;
        private SerializedProperty _maximumRandomDirection;
        private SerializedProperty _avoid180;

        protected override void SerializeAdditionalProperties()
        {
            _mode = serializedObject.FindProperty("mode");
            _maximumDurationInADirection = serializedObject.FindProperty("maximumDurationInADirection");
            _obstacleLayerMask = serializedObject.FindProperty("obstacleLayerMask");
            _obstaclesDetectionDistance = serializedObject.FindProperty("obstaclesDetectionDistance");
            _obstaclesCheckFrequency = serializedObject.FindProperty("obstaclesCheckFrequency");
            _minimumRandomDirection = serializedObject.FindProperty("minimumRandomDirection");
            _maximumRandomDirection = serializedObject.FindProperty("maximumRandomDirection");
            _avoid180 = serializedObject.FindProperty("avoid180");

            serializedObject.Update();
            NodeEditorGUILayout.PropertyField(_mode);
            NodeEditorGUILayout.PropertyField(_maximumDurationInADirection);
            NodeEditorGUILayout.PropertyField(_obstacleLayerMask);
            NodeEditorGUILayout.PropertyField(_obstaclesDetectionDistance);
            NodeEditorGUILayout.PropertyField(_obstaclesCheckFrequency);
            NodeEditorGUILayout.PropertyField(_minimumRandomDirection);
            NodeEditorGUILayout.PropertyField(_maximumRandomDirection);
            NodeEditorGUILayout.PropertyField(_avoid180);
            serializedObject.ApplyModifiedProperties();
        }
    }
}