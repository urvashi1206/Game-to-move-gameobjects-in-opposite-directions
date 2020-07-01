using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(
            new Vector2(5, 5),
            ForceMode2D.Impulse);
    }
}
