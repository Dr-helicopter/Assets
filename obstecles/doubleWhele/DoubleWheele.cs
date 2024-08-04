using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleWheele : Obsticle
{

    public Animator animIn;
    public Animator animOut;
    
    
    [SerializeField]
    private float maxSpeed=1, minSpeed=1;

    protected override void Start() {
        base.Start();
        float S =  Random.Range(minSpeed, maxSpeed) * (Random.Range(0, 2) == 0 ? -1 : 1);
        animIn.SetFloat("Speed",S);
        animOut.SetFloat("Speed",-S);
    }
}
