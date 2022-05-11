using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using Photon.Pun;

public class SoundInputVisualizer : MonoBehaviour
{
    
    // [SerializeField] GameObject indicator;
    [SerializeField] GameObject indicator;

    // // [SerializeField] GameObject parent;
    // [SerializeField] GameObject parent;

	PhotonView view;

    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();

        // indicator.transform.SetParent(parent.transform,false);
        // indicator.transform.localPosition = Vector3.zero;

        indicator.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        { 
            indicator.SetActive(true);
        }
        else if(Input.GetKeyUp(KeyCode.R))
        {
            indicator.SetActive(false);
        }
    }

}
