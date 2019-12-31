using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionMovePatrol3DNode))]
    public class AIActionMovePatrol3DNodeEditor : AIActionNodeEditor
    {
        private SerializedProperty _changeDirectionOnObstacle;
        private SerializedProperty _obstacleDetectionDistance;
        private SerializedProperty _obstaclesCheckFrequency;
        private SerializedProperty _obstacleLayerMask;

        public override void OnBodyGUI()
        {
            base.OnBodyGUI();
            
            if (CollapseNodeOn) return;

            _changeDirectionOnObstacle = serializedObject.FindProperty("changeDirectionOnObstacle");
            _obstacleDetectionDistance = serializedObject.FindProperty("obstacleDetectionDistance");
            _obstaclesCheckFrequency = serializedObject.FindProperty("obstaclesCheckFrequency");
            _obstacleLayerMask = serializedObject.FindProperty("obstacleLayerMask");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 180;
            NodeEditorGUILayout.PropertyField(_changeDirectionOnObstacle);
            NodeEditorGUILayout.PropertyField(_obstacleDetectionDistance);
            NodeEditorGUILayout.PropertyField(_obstaclesCheckFrequency);
            EditorGUIUtility.labelWidth = 140;
            NodeEditorGUILayout.PropertyField(_obstacleLayerMask);
            serializedObject.ApplyModifiedProperties();
        }
    }
}