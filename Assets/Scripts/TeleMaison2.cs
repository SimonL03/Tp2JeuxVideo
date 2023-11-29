using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleMaison2 : MonoBehaviour
{
      private LevelManager _levelManager;

    // Start is called before the first frame update
    void Start()
    {
        _levelManager = LevelManager.Instance;
    }

    private void OnTriggerStay(Collider other)
   {
    _levelManager.LoadMaison2();
   }
}
