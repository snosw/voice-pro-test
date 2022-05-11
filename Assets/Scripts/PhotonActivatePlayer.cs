using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using Photon.Pun;

public class PhotonActivatePlayer : MonoBehaviour
{
    
    // [SerializeField] GameObject myCamera;
    [SerializeField] List<GameObject> ObjectsToInitialize = new List<GameObject>();

	PhotonView view;

    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();
        
        if(view.IsMine)
        { 
            foreach(GameObject go in ObjectsToInitialize)
            {
                go.SetActive(true);
            }
        }

    }

}
