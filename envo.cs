using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class envo : MonoBehaviour
{
    public GameObject[] obsticles;
    public GameObject colorChange;

    public float dist = 5;

    ColorChange.colors lastColor;

    public void slide(Vector3 speed){
        foreach (Transform child in transform)
            child.position -= speed;
        dist -= speed.y;
        if (dist <= 0){
            Obsticle o = Instantiate(obsticles[UnityEngine.Random.Range(0, obsticles.Length)],transform.position , transform.rotation, transform).GetComponent<Obsticle>();
            Instantiate(colorChange,transform.position , transform.rotation, transform);
            o.setNext(this);
        }
    }
}
