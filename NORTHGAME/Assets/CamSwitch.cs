using UnityEngine;

public class CamSwitch : MonoBehaviour {

    public Camera FpsCam;
    public Camera TpsCam;
    bool fpsCam = true;

    // Use this for initialization
    void Start () {
        FpsCam.enabled = fpsCam;
        TpsCam.enabled = !fpsCam;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            fpsCam = !fpsCam;
            FpsCam.enabled = fpsCam;
            TpsCam.enabled = !fpsCam;
        }
    }
        
        //end o class
    }
