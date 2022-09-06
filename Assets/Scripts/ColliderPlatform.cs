using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderPlatform : MonoBehaviour
{
    public Single manager;
    private void Start()
    {
        manager = Single.Instance;
    }

    private void OnTriggerEnter(Collider other)
    {
        //Platform Destroy end position
        if (other.gameObject.tag == "Destroy")
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Lose Game
        if (collision.gameObject.name == "Drawing")
        {
            manager.losePanel.SetActive(true);
            manager.loseGameBool = false;

            manager.scoreEndText.text = "Score : " + manager.totalScore.ToString();
        }
    }

}
