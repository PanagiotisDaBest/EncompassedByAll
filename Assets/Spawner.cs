using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   [Header("Target")]
    public GameObject prefab;

    [SerializeField]
    private FruitTaskPanel panel;


    [Header("Gameplay")]
    public float interval;
    public float minimumX;
    public float maximumX;
    public float y;
    public float z;

    [Header("Visuals")]
    public Sprite[] sprites;


    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", interval, interval);
    }

    private void Spawn()
        //Instantiate and position for the object
    {
        GameObject instance = Instantiate (prefab);
        instance.transform.position = new Vector3(Random.Range(minimumX,maximumX),y, z);
        instance.GetComponent<CuttableObjects>().cutPanel = panel;

        // sett a random sprite (can be used for later as of right now we use one sprite)
        Sprite randomSprite = sprites[Random.Range(0, sprites.Length)];
        instance.GetComponent<SpriteRenderer> ().sprite = randomSprite;
        
    }
}
