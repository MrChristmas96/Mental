using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
    public int loopCount;

    private static GM _instance;

    [SerializeField] private bool foundKey = false;

    public PickupController pickupController;

    [SerializeField] RoomGenerator roomGenerator;

    private void Awake()
    {
        pickupController = GetComponent<PickupController>();
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    public void PickedUp()
    {
        pickupController.PickedUp();
        foundKey = true;
    }

    public void loadScene(string name)
    {

        if (foundKey)
        {
            loopCount++;
            SceneManager.LoadScene(name + loopCount);
            foundKey = false;
        }
        else
        {
            Debug.Log("Door is Locked");
        }
        
    }
}
