using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionInvertPatrolDirectionNode))]
    public class AIActionInvertPatrolDirectionNodeEditor : AIActionNodeEditor
    {
//        private SerializedProperty _movePatrol2D;
//        private SerializedProperty _movePatrol3D;

        protected override void SerializeAdditionalProperties()
        {
//            _movePatrol2D = serializedObject.FindProperty("movePatrol2D");
//            _movePatrol3D = serializedObject.FindProperty("movePatrol3D");

            serializedObject.Update();
//            NodeEditorGUILayout.PropertyField(_movePatrol2D);
//            NodeEditorGUILayout.PropertyField(_movePatrol3D);
            
            EditorGUILayout.HelpBox(
                "Move Patrol 2D and 3D properties are hidden. You will have to manually add them once the generator has been executed or assign them at runtime.",
                MessageType.Warning);

            serializedObject.ApplyModifiedProperties();
        }
    }
}