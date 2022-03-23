using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseShape : MonoBehaviour
{
    [SerializeField]
    private Color _color;

    public abstract void DoTrick();

    private void Awake()
    {
        gameObject.GetComponent<Renderer>().material.color = _color;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }


}
