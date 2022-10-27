using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{

    [Header("Gameplay")]
    public GameObject cutPrefab;
    public float cutLifetime;

    private bool dragging;
    private Vector2 swipeStart;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            dragging = true;
            swipeStart = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        else if (Input.GetMouseButtonUp(0) && dragging)
        {
            Spawncut();
        }

        
    }

    private void Spawncut()
    {
        // identify where the swipe ends.

        dragging = false;
        Vector2 swipeEnd = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // spawn the cut object/prefab.
        GameObject cutInstance = Instantiate(cutPrefab, swipeStart, Quaternion.identity);
        cutInstance.GetComponent<LineRenderer>().SetPosition(0, swipeStart);
        cutInstance.GetComponent<LineRenderer>().SetPosition(1, swipeEnd);

        // adjusted edge collider.
        Vector2[] colliderPoints = new Vector2[2];
        colliderPoints[0] = Vector2.zero;
        colliderPoints[1] = swipeEnd - swipeStart;
        cutInstance.GetComponent<EdgeCollider2D>().points = colliderPoints;


        // Schedule for the destruction of the cut object.
        Destroy(cutInstance, cutLifetime);

        
    }
}
