﻿using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIDecisionGroundedNode))]
    public class AIDecisionGroundedNodeEditor : AIDecisionNodeEditor
    {
        private SerializedProperty _groundedBufferDelay;
        
        protected override void SerializeAdditionalProperties()
        {
            _groundedBufferDelay = serializedObject.FindProperty("groundedBufferDelay");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 160;
            NodeEditorGUILayout.PropertyField(_groundedBufferDelay);
            serializedObject.ApplyModifiedProperties();
        }
    }
}