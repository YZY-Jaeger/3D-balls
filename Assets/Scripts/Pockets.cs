using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pockets : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //override
    private void OnTriggerEnter(Collider other)
    {
        
        Vector3 corner = transform.position;
        other.gameObject.layer = LayerMask.NameToLayer("Exit Pocket");
        other.gameObject.GetComponent<Rigidbody>().AddForce( (corner - other.gameObject.transform.position)*2.0f, ForceMode.Impulse);
        Debug.Log("Enter, added force!");
    }
    //override
    private void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>().useGravity = true;
        other.gameObject.layer = LayerMask.NameToLayer("Default");
        Debug.Log("Left!");
    }
}
