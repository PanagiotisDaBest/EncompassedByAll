using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitTask : Task
{
    [SerializeField]
    FruitTaskPanel gamePanel;

    protected override void OnStart()
    {

    }

    public override void OnInteract()
    {
        gamePanel.Show();

    }
}
