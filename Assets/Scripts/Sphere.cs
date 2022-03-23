using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : BaseShape
{
    private Rigidbody _rigidBody;
    
    public float JumpForce { get; set; }

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
