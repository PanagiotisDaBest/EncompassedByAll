using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FruitTaskPanel : MonoBehaviour
{
    public GameObject DecativateFruitSpawner;

    [SerializeField]
    Task ownerTask;

    GameObject lastFirstSelectedGameObject;

    [SerializeField]
    GameObject Spawner;

    [SerializeField]
    GameObject Sword;

    public int finalCount;


    public void Show()
    {
        gameObject.SetActive(true);
        lastFirstSelectedGameObject = GameManager.Instance.EventSystem.firstSelectedGameObject;
        GameManager.Instance.EventSystem.firstSelectedGameObject = gameObject;

        Spawner.SetActive(true);

        
    }

    public void Update()
    {
        if (finalCount == 10)
        {
            Hide();
            ownerTask.SetAsResolved();
            Spawner.SetActive(false);
            Sword.SetActive(false);


        }
      

    }
    public void Hide()
    {
        gameObject.SetActive(false);
        GameManager.Instance.EventSystem.firstSelectedGameObject = lastFirstSelectedGameObject;

        Spawner.SetActive(false);
    }


}
