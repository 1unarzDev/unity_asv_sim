using UnityEngine;
using System.Collections.Generic;
using Sim.Actuators.Motors;
using UnityEngine.InputSystem;

namespace Sim.Controllers
{
    public abstract class ControllerBase : MonoBehaviour
    {
        [SerializeField] protected List<Thruster> thrusters;

    }
}

