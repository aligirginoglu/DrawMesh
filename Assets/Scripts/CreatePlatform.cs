using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlatform : MonoBehaviour
{
    public Single manager;

    [Header("Platform")]
    [SerializeField] GameObject platform;
    private float instantiateTime;
    private float InstantiatePlatformTime;


    void Start()
    {
        manager = Single.Instance;
    }

   
    void Update()
    {
        //Platform Instantiate second
        if (manager.loseGameBool)
        {
            InstantiatePlatformTime += (Time.deltaTime / 1000);
            instantiateTime += Time.deltaTime;
            instantiateTime += InstantiatePlatformTime;
            if (instantiateTime >= 4)
            {
                Instantiate(platform);
                RandomPlatform();
                instantiateTime = 0;
            }
        }
        
    }

    //Platform Random Position
    private void RandomPlatform()
    {
        float random = Random.Range(-1 ,1.1f);
        platform.transform.position = new Vector3(random, platform.transform.position.y , platform.transform.position.z);
    }
}
