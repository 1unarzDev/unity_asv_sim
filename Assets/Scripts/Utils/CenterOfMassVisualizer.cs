using UnityEngine;

namespace Sim.Utils {
    public class VisualizeCenterOfMass : MonoBehaviour {
        private IPhysicsBody body;
    
        private void OnDrawGizmos() {
            var rb = GetComponent<Rigidbody>();
            var ab = GetComponent<ArticulationBody>();
    
            if (rb != null) body = new RigidbodyAdapter(rb);
            else if (ab != null) body = new ArticulationBodyAdapter(ab);
            else throw new MissingComponentException($"{name} requires a Rigidbody or ArticulationBody!");

            Gizmos.color = Color.red;
            Gizmos.DrawSphere(transform.TransformPoint(body.centerOfMass), 0.05f);
        }
    }
}