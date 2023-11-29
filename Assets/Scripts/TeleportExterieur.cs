using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TeleMaison1 : MonoBehaviour
{

    private LevelManager _levelManager;

    // Start is called before the first frame update
    void Start()
    {
        _levelManager = LevelManager.Instance;
    }

    private void OnTrigger(Collider other)
   {
    _levelManager.LoadExterieur();
   }

    
}
