using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Single : Singleton<Single>
{
    [Header("Score")]
    [SerializeField] public int drawScore;
    [SerializeField] public int totalScore;
    [SerializeField] public TMP_Text scoreText;
    [SerializeField] public TMP_Text scoreEndText;

    [Header("Game")]
    [SerializeField] public GameObject losePanel;
    [SerializeField] public bool loseGameBool = true;

    public void TryAgainButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
