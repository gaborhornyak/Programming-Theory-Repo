using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : BaseShape
{
    [SerializeField]
    private ParticleSystem _particleSystem;

    public override void DoTrick()
    {
        _particleSystem.Play();
    }

    private void Start()
    {
        _particleSystem.Stop();
    }
}
