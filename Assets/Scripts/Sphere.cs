using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Sphere : BaseShape
{
    private Rigidbody _rigidBody;

    // ENCAPSULATION
    public float JumpForce { get; set; }

    // POLYMORPHISM
    public override void DoTrick()
    {
        // shoot sphere upwards
        _rigidBody.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
    }

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
        // set default force
        JumpForce = 4.0f;
    }
}
