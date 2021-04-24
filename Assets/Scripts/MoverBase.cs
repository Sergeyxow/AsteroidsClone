using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MoverBase : MonoBehaviour
{
    public abstract void AddForce(Vector2 force);

    public abstract void AddTorque(Vector2 torque);
}
