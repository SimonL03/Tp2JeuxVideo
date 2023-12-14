using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionYellowGifts : MonoBehaviour
{

    [SerializeField] GameObject ZoneYellowBowGift;
    [SerializeField] private InfosGifts _infosGifts;
    [SerializeField] private int _nbPoints;
    private Vector3 _positionSpot;

    void Start()
    {
        _positionSpot = ZoneYellowBowGift.transform.position;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "YellowBowGift"){
                Debug.Log("weihsogf");
                other.gameObject.transform.position = _positionSpot;
                ZoneYellowBowGift.SetActive(false);
                _infosGifts.nbPointsGifts += _nbPoints;
            }   
    }
}
