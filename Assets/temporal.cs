using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ventilator : MonoBehaviour
{
    public float motor;
    public GameObject Sphere;
    public Wind viento;

    private void Update()
    {
        JointMotor motor = Sphere.GetComponent<HingeJoint>().motor;
        motor.targetVelocity = 90f;
    }
}
