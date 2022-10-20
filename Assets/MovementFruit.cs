using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementFruit : MonoBehaviour
{
    [Header("Speed variables")]
    public float minimumXspeed;
    public float maximumXspeed;
    public float minimumYspeed;
    public float maximumXspeed;

    [Header("Fruit Life")]
    public float lifetime;

    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(
            Random.Range(minimumXspeed, maximumXspeed),
            Random.Range(minimumYspeed, maximumYspeed)
            );

        Destroy(gameObject, lifetime);
    }
}
