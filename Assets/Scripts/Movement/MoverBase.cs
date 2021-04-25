using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MoverBase : MonoBehaviour
{
    public abstract void AddForce(Vector3 force);

    public abstract void AddTorque(Vector3 torque);

    public abstract void Stop();
}
