using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {

    public int Speed = 10;

    public Rigidbody2D Rigidbody2D;

    private void Update()
    {
        float direction = Input.GetAxis("Horizontal");
       
        Rigidbody2D.AddForce(new Vector2(direction * Speed, 0f));
    }
}
