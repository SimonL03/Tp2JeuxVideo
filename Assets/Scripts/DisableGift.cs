using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableGift : MonoBehaviour
{
    [SerializeField] private GameObject _gift;
    private Rigidbody _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other) {
         _rb.useGravity = false;
         _rb.detectCollisions = false;
    }
}
