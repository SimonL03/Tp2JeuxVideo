using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionRedGifts : MonoBehaviour
{
    [SerializeField] GameObject ZoneRedBowGift;
    [SerializeField] private InfosGifts _infosGifts;
    [SerializeField] private int _nbPoints;
    private Vector3 _positionSpot;
    // Start is called before the first frame update
    void Start()
    {
        _positionSpot = ZoneRedBowGift.transform.position;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "RedBowGift"){
                other.gameObject.transform.position = _positionSpot;
                ZoneRedBowGift.SetActive(false);
                _infosGifts.nbPointsGifts += _nbPoints;
            }
        
    }
}