using UnityEngine;
using XNode;

namespace CabinIcarus.IcSkillSystem.Expansion.Runtime.Builtin.Nodes
{
    public abstract class ACastRaycastHitNode:ACastNode
    {
        [SerializeField,Input(Node.ShowBackingValue.Always,Node.ConnectionType.Override,Node.TypeConstraint.Strict)]
        [Node.LabelAttribute("Use All")]
        private bool _all;
        
        protected bool UseAll => GetInputValue(nameof(_all), _all);
    }
}