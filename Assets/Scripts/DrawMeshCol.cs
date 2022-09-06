using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawMeshCol : MonoBehaviour
{
    public Single manager;
    private void Start()
    {
        manager = Single.Instance;  
    }

    private void OnTriggerEnter(Collider other)
    {
        //DrawMesh Trigger Score+ 
        if (other.gameObject.name == "Drawing")
        {
            if (manager.loseGameBool)
            {
                manager.totalScore += manager.drawScore;
                manager.scoreText.text = manager.totalScore.ToString();
            }

            
        }
    }
}
