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
            
            if (CollapseNodeOn) return;

            _groundedBufferDelay = serializedObject.FindProperty("groundedBufferDelay");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 160;
            NodeEditorGUILayout.PropertyField(_groundedBufferDelay);
            serializedObject.ApplyModifiedProperties();
        }
    }
}