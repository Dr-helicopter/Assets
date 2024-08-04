using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cross : Obsticle
{
    public Animator animR;

    public Animator animL;

    [SerializeField]
    private float maxSpeed=1, minSpeed=1;

    protected override void Start() {
        base.Start();
        int oriantation = Random.Range(1, 4);
        float S =  Random.Range(minSpeed, maxSpeed);
        switch (oriantation)
        {
            case 1 : 
                animR.SetFloat("Speed",-S);
                Destroy(animL.gameObject);
                break;
            case 2 : 
                animL.SetFloat("Speed",S);
                Destroy(animR.gameObject);
                break;
            case 3 : 
                animR.SetFloat("Speed",-S * 1);
                animL.SetFloat("Speed",S * 1);
                break;
        }
    }


}
