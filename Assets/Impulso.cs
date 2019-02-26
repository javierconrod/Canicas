using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulso : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float potencia = 300;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(new Vector2(potencia,0), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
