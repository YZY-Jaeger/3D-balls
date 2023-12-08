using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_Ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        Vector3 corner = transform.position;
        other.gameObject.GetComponent<Rigidbody>().AddForce((corner - other.gameObject.transform.position) * -3.0f, ForceMode.Impulse);
        Debug.Log("Hit ball!");
    }
}
