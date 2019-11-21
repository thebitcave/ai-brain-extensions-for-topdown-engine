using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionMoveTowardsTarget2DNode))]
    public class AIActionMoveTowardsTarget2DNodeEditor : AIActionNodeEditor
    {
        private SerializedProperty _minimumDistance;
        
        public override void OnBodyGUI()
        {
            base.OnBodyGUI();
            
            _minimumDistance = serializedObject.FindProperty("minimumDistance");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 180;
            NodeEditorGUILayout.PropertyField(_minimumDistance);
            serializedObject.ApplyModifiedProperties();
        }
    }
}