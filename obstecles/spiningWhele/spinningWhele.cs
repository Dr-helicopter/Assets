using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinningWhele : Obsticle{
    public Animator anim;

    [SerializeField]
    private float maxSpeed=1, minSpeed=1;

    protected override void Start() {
        base.Start();
        anim.SetFloat("Speed", Random.Range(minSpeed, maxSpeed) * (Random.Range(0, 2) == 0 ? -1 : 1));
    }
}
