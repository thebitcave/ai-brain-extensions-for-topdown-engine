﻿using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIDecisionDetectTargetRadius2DNode))]
    public class AIDecisionDetectTargetRadius2DNodeEditor : AIDecisionNodeEditor
    {
        private SerializedProperty _radius;
        private SerializedProperty _detectionOriginOffset;
        private SerializedProperty _targetLayer;
        private SerializedProperty _obstacleMask;
        
        public override void OnBodyGUI()
        {
            base.OnBodyGUI();
            
            _radius = serializedObject.FindProperty("radius");
            _detectionOriginOffset = serializedObject.FindProperty("detectionOriginOffset");
            _targetLayer = serializedObject.FindProperty("targetLayer");
            _obstacleMask = serializedObject.FindProperty("obstacleMask");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 120;
            NodeEditorGUILayout.PropertyField(_radius);
            NodeEditorGUILayout.PropertyField(_detectionOriginOffset);
            NodeEditorGUILayout.PropertyField(_targetLayer);
            NodeEditorGUILayout.PropertyField(_obstacleMask);
            serializedObject.ApplyModifiedProperties();
        }
    }
}