using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
    public int loopCount;

    private static GM _instance;

    [SerializeField] private bool foundKey = false;


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

    public void PickedUp()
    {
        foundKey = true;
    }

    public void loadScene(string name)
    {
        if (foundKey)
        {
            loopCount++;
            SceneManager.LoadScene(name + loopCount);
        }
        else
        {
            Debug.Log("You need to find the key");
        }
        
    }
}
