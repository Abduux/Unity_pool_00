using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class square : MonoBehaviour
{
    public SpriteRenderer Square;
    void Start()
    {
        Square = gameObject.GetComponent<SpriteRenderer>();
    }
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Square.color = Color.red;
          //  print("Change Color");
        }
        else
        Square.color = Color.white;
    }
}
