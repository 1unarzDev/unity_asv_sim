using UnityEngine;
using System.Collections.Generic;
using Sim.Actuators.Motors;
using UnityEngine.InputSystem;

namespace Sim.Controllers {
    public class OmniController {
        public InputAction moveAction;

        void OnEnable()
        {
            moveAction.Enable();
            moveAction.performed += OnMove;
        }

        void OnDisable()
        {
            moveAction.performed -= OnMove;
            moveAction.Disable();
        }

        void OnMove(InputAction.CallbackContext context)
        {
            // Check if the action was performed
            if (context.performed)
            {
                Debug.Log("Move action performed!");
                // You can also read the value if your jump action has a value type
                // float jumpValue = context.ReadValue<float>(); 
            }
        }
    }
}