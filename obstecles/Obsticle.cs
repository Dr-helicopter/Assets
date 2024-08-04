using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obsticle : MonoBehaviour
{
    public float dist;


    protected virtual void Start() {
        transform.position -= new Vector3(0, dist/2 , 0);
    }

    public void setNext(envo e){
        e.dist = dist;
    }
}
