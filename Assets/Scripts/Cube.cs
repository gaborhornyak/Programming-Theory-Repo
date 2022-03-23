using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cube : BaseShape
{
    private Rigidbody _rigidBody;

    // ENCAPSULATION
    public float SpinForce { get; set; }

    // POLYMORPHISM
    public override void DoTrick()
    {
        // spin cube
        _rigidBody.AddForce(Vector3.up * SpinForce / 10, ForceMode.Impulse);
        _rigidBody.AddTorque(Vector3.up * SpinForce, ForceMode.Impulse);
    }

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
        // set default force
        SpinForce = 10.0f;
    }
}
