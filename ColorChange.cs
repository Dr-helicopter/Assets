 using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    // color Data
    public enum colors{
        PINK,
        BLUE,
        GREEN,
        YELLOW
    }
    public static readonly Dictionary<colors, Color> colorsData = new Dictionary<colors, Color>{
        {colors.PINK, new Color(1.0f,0.0f, 0.88f)},
        {colors.BLUE, new Color(0.0f,0.82f, 1.0f)},
        {colors.GREEN, new Color(0.0f, 1.0f ,0.2f)},
        {colors.YELLOW, new Color(1.0f, 0.88f, 0.0f)}
    };
    public static readonly Dictionary<colors, int> colorsLayerData = new Dictionary<colors, int>{
        {colors.BLUE, 10},
        {colors.PINK, 11},
        {colors.GREEN, 12},
        {colors.YELLOW, 13}
    };
    // end  color Data



    // attributes
    public Player player;
    public SpriteRenderer spriteRenderer;
    private static colors lastColor = colors.BLUE;
    private colors currentColor;
    // end attributes



    // mono cycle methods
    void Start(){
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
        currentColor = (colors)Enum.GetValues(typeof(colors)).GetValue(UnityEngine.Random.Range(0, 3));
        if (currentColor == lastColor)
            currentColor = colors.YELLOW;
        lastColor = currentColor; 
        spriteRenderer.color = colorsData[currentColor];
    }


    private void OnTriggerEnter2D(Collider2D  collision) {
        if (collision.gameObject.tag == "Player"){
            player.ChangeColor(currentColor);        
            Destroy(gameObject);
        }
    }
    //end  mono cycle methods



}
