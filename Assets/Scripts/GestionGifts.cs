using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionGifts : MonoBehaviour
{
    [SerializeField] private InfosNiveau _infoNiveau;
    [SerializeField] private InfosGifts _infosGifts;
    [SerializeField] GameObject _texteVictoire;
    [SerializeField] GameObject _texteObjective;
    private bool _hasRun;

    void Start(){
        _infosGifts.nbPointsGifts = 0;
        _hasRun = true;
    }
    void LateUpdate(){
        CheckWinGifts();
    }
    public void CheckWinGifts(){
        if(_infosGifts.nbPointsGifts >= 10 && _hasRun == true){
            _hasRun = false;
            Debug.Log("hi");
            _infoNiveau.nbMiniJeuxTerminer++;
            _infoNiveau.giftTerminer +=1;
            _texteObjective.SetActive(false);
            _texteVictoire.SetActive(true);
        }
    }
}
