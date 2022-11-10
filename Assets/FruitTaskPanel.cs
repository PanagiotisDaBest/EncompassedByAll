using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FruitTaskPanel : MonoBehaviour
{
    [SerializeField]
    Task ownerTask;

    GameObject lastFirstSelectedGameObject;

    [SerializeField]
    GameObject Spawner;

    public int finalCount;


    public void Show()
    {
        gameObject.SetActive(true);
        lastFirstSelectedGameObject = GameManager.Instance.EventSystem.firstSelectedGameObject;
        GameManager.Instance.EventSystem.firstSelectedGameObject = gameObject;

        Spawner.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
        GameManager.Instance.EventSystem.firstSelectedGameObject = lastFirstSelectedGameObject;

        Spawner.SetActive(false);
    }


}
