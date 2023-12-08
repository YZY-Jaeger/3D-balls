using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CueStick : MonoBehaviour
{
    public GameObject ghost;
    public GameObject CueStickPrefab;
    public Rigidbody CueStick_Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }
    void FixedUpdate()
    {

        CueStickPrefab.GetComponent<Rigidbody>().MovePosition(ghost.transform.position);
        CueStickPrefab.GetComponent<Rigidbody>().MoveRotation(ghost.transform.rotation);
        OVRInput.FixedUpdate();
    }
    // Update is called once per frame
    void Update()
    {
        OVRInput.Update();
    }
}
