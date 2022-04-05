using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
    public int loopCount;

    private static GM _instance;


    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void loadScene(string name)
    {
        loopCount++;
        SceneManager.LoadScene(name + loopCount);
    }
}
