using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIDecisionGroundedNode))]
    public class AIDecisionGroundedNodeEditor : AIDecisionNodeEditor
    {
        private SerializedProperty _groundedBufferDelay;
        
        public override void OnBodyGUI()
        {
            base.OnBodyGUI();
            
            _groundedBufferDelay = serializedObject.FindProperty("groundedBufferDelay");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 120;
            NodeEditorGUILayout.PropertyField(_groundedBufferDelay);
            serializedObject.ApplyModifiedProperties();
        }
    }
}