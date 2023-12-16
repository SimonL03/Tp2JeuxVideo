using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerificationMiniJeuxTerminer : MonoBehaviour
{   
    [SerializeField] private InfosNiveau _infosNiveau;
    [SerializeField] private LevelManager _levelManager;

    // Update is called once per frame
    void Update()
    {
        if(_infosNiveau.nbMiniJeuxTerminer == 4){
            _levelManager.LoadScene("Fin");
        }
    }
}
