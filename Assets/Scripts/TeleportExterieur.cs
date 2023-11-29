using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TeleportExterieur : MonoBehaviour
{

    private LevelManager _levelManager;

    // Start is called before the first frame update
    void Start()
    {
        _levelManager = LevelManager.Instance;
    }

    private void OnTriggerStay(Collider other)
   {
    _levelManager.LoadExterieur();
   }

    
}
