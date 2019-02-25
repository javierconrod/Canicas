using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poderoso : MonoBehaviour
{
    Rigidbody2D rb2d;
    public int poder = 500;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(Vector2.right*poder);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
