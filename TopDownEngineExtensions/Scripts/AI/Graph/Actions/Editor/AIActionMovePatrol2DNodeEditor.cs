using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionMovePatrol2DNode))]
    public class AIActionMovePatrol2DNodeEditor : AIActionNodeEditor
    {
        private SerializedProperty _changeDirectionOnObstacle;
        private SerializedProperty _obstaclesLayerMask;

        protected override void SerializeAdditionalProperties()
        {
            _changeDirectionOnObstacle = serializedObject.FindProperty("changeDirectionOnObstacle");
            _obstaclesLayerMask = serializedObject.FindProperty("obstaclesLayerMask");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 180;
            NodeEditorGUILayout.PropertyField(_changeDirectionOnObstacle);
            EditorGUIUtility.labelWidth = 140;
            NodeEditorGUILayout.PropertyField(_obstaclesLayerMask);
            serializedObject.ApplyModifiedProperties();
        }
    }
}