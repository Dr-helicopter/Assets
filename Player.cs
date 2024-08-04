using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    // physics attributes
    [SerializeField]
    private float
    velocity,
    gravity,
    jumpSpeed;
    // end physics attributes
    


    // environment attributes
    [SerializeField]
    private float envoMiddle;
    public envo e;
    Vector3 middle;
    // end environment attributes



    // mono cycle methods
    private void Start() {
        middle = new Vector3(0, envoMiddle, 0);
    }
    // end  mono cycle methods




    // Jumping
    public InputAction jumpAction;

    private void OnEnable() {
        jumpAction.Enable();
        jumpAction.performed += Jump;
    }

    private void OnDisable() {
        jumpAction.Disable();
    }

    private void Jump(InputAction.CallbackContext context) {
        velocity = jumpSpeed;
    }
    // end Jumping



    // color attributes and methods
    public ColorChange.colors currentColor = ColorChange.colors.BLUE;
    public SpriteRenderer sprite; 
    public void ChangeColor(ColorChange.colors newColor) {
        currentColor = newColor;
        sprite.color = ColorChange.colorsData[newColor];
    }
    // end color attributes and methods


    
    private void FixedUpdate() {
        velocity -= gravity * Time.deltaTime;
         Vector3 velocityVector = new Vector3(0, velocity * Time.deltaTime, 0); 
        if (transform.position.y >= envoMiddle & velocity > 0){
            transform.position = middle;
            e.slide(velocityVector);            
        } else transform.position += velocityVector;
        
        
        

    }



    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.layer != ColorChange.colorsLayerData[currentColor])
            Destroy(gameObject);
    }



}
