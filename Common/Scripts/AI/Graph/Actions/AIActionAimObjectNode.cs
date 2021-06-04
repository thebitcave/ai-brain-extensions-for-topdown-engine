using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIActionAimObject"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/Aim Object")]
    public class AIActionAimObjectNode: AIActionNode
    {
        // gameObjectToAim is hidden from inspector as it cannot be easily assigned at generation time
//        public GameObject gameObjectToAim;

        public AIActionAimObject.Modes mode = AIActionAimObject.Modes.Movement;
        public AIActionAimObject.PossibleAxis axis = AIActionAimObject.PossibleAxis.Right;

        public bool interpolate = false;
//        [MMCondition("Interpolate", true)] 
        public float interpolateRate = 5f;

        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionAimObject>();
            action.Label = label;
  //          action.GameObjectToAim = gameObjectToAim;
            action.Mode = mode;
            action.Axis = axis;
            action.Interpolate = interpolate;
            action.InterpolateRate = interpolateRate;
            
            return action;
        }

    }
}