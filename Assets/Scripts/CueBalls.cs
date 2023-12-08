using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CueBalls : MonoBehaviour
{
    public GameObject CueBall_default;
    public Material BallMat;

    private void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = transform.position;
        ////////////////////////////////////////////////////////////////////////////////////
        GameObject ball1 = Instantiate(CueBall_default, spawnPosition +new Vector3(0.0f, 0.04f, 0.0f), Quaternion.identity);
        BallMat = Resources.Load<Material>("Material/Pool Ball Skins/Materials/Ball 1");
        ball1.GetComponent<Renderer>().material = BallMat;
        ///////////////////////////////////////////////////////////////////////////////
        GameObject ball2 = Instantiate(CueBall_default, spawnPosition + new Vector3(0.029f, 0.0f, 0.029f), Quaternion.identity);
        BallMat = Resources.Load<Material>("Material/Pool Ball Skins/Materials/Ball 2");
        ball2.GetComponent<Renderer>().material = BallMat;

        GameObject ball3 = Instantiate(CueBall_default, spawnPosition + new Vector3(-0.029f, 0.0f, 0.029f), Quaternion.identity);
        BallMat = Resources.Load<Material>("Material/Pool Ball Skins/Materials/Ball 3");
        ball3.GetComponent<Renderer>().material = BallMat;

        GameObject ball4 = Instantiate(CueBall_default, spawnPosition +new Vector3(-0.029f, 0.0f, -0.029f), Quaternion.identity);
        BallMat = Resources.Load<Material>("Material/Pool Ball Skins/Materials/Ball 4");
        ball4.GetComponent<Renderer>().material = BallMat;

        GameObject ball5 = Instantiate(CueBall_default, spawnPosition + new Vector3(0.029f, 0.0f, -0.029f), Quaternion.identity);
        BallMat = Resources.Load<Material>("Material/Pool Ball Skins/Materials/Ball 5");
        ball5.GetComponent<Renderer>().material = BallMat;
        //////////////////////////////////////////////////////////////////////////////////
        GameObject ball6 = Instantiate(CueBall_default, spawnPosition + new Vector3(0.058f, -0.046f, 0.058f), Quaternion.identity);
        BallMat = Resources.Load<Material>("Material/Pool Ball Skins/Materials/Ball 6");
        ball6.GetComponent<Renderer>().material = BallMat;

        GameObject ball7 = Instantiate(CueBall_default, spawnPosition + new Vector3(0.0f, -0.046f, 0.058f), Quaternion.identity);
        BallMat = Resources.Load<Material>("Material/Pool Ball Skins/Materials/Ball 7");
        ball7.GetComponent<Renderer>().material = BallMat;

        GameObject ball8 = Instantiate(CueBall_default, spawnPosition + new Vector3(-0.058f, -0.046f, 0.058f), Quaternion.identity);
        BallMat = Resources.Load<Material>("Material/Pool Ball Skins/Materials/Ball 8");
        ball8.GetComponent<Renderer>().material = BallMat;

        GameObject ball9 = Instantiate(CueBall_default, spawnPosition + new Vector3(-0.058f, -0.046f, 0.0f), Quaternion.identity);
        BallMat = Resources.Load<Material>("Material/Pool Ball Skins/Materials/Ball 9");
        ball9.GetComponent<Renderer>().material = BallMat;

        GameObject ball10 = Instantiate(CueBall_default, spawnPosition + new Vector3(0, -0.046f, 0.0f), Quaternion.identity);
        BallMat = Resources.Load<Material>("Material/Pool Ball Skins/Materials/Ball 10");
        ball10.GetComponent<Renderer>().material = BallMat;

        GameObject ball11 = Instantiate(CueBall_default, spawnPosition + new Vector3(0.058f, -0.046f, 0.0f), Quaternion.identity);
        BallMat = Resources.Load<Material>("Material/Pool Ball Skins/Materials/Ball 11");
        ball11.GetComponent<Renderer>().material = BallMat;

        GameObject ball12 = Instantiate(CueBall_default, spawnPosition + new Vector3(0.058f, -0.046f, -0.058f), Quaternion.identity);
        BallMat = Resources.Load<Material>("Material/Pool Ball Skins/Materials/Ball 12");
        ball12.GetComponent<Renderer>().material = BallMat;

        GameObject ball13 = Instantiate(CueBall_default, spawnPosition + new Vector3(0, -0.046f, -0.058f), Quaternion.identity);
        BallMat = Resources.Load<Material>("Material/Pool Ball Skins/Materials/Ball 13");
        ball13.GetComponent<Renderer>().material = BallMat;

        GameObject ball14 = Instantiate(CueBall_default, spawnPosition + new Vector3(-0.058f, -0.046f, -0.058f), Quaternion.identity);
        BallMat = Resources.Load<Material>("Material/Pool Ball Skins/Materials/Ball 14");
        ball14.GetComponent<Renderer>().material = BallMat;
        /////////////////////////////////////////////////////////
        GameObject ball15 = Instantiate(CueBall_default, spawnPosition + new Vector3(0, -0.105f, 0), Quaternion.identity);
        BallMat = Resources.Load<Material>("Material/Pool Ball Skins/Materials/Ball 15");
        ball15.GetComponent<Renderer>().material = BallMat;
        /////////////////////////////////////////////////
        GameObject cueball = Instantiate(CueBall_default, spawnPosition + new Vector3(0, -0.02f, -0.3f), Quaternion.identity);
        BallMat = Resources.Load<Material>("Material/Pool Ball Skins/Materials/BallCue");
        cueball.GetComponent<Renderer>().material = BallMat;
        //////////////////////////////////////////////////
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
