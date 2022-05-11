using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using System.Linq;

public class PhotonDirectJoin : MonoBehaviourPunCallbacks
{

    public static int avatarId;

    // private void Start(){
    // }

    public void DirectCreateRoom(){
        PhotonNetwork.CreateRoom("metaplaza_demo");
    }

    public void DirectJoinRoom(){
        PhotonNetwork.JoinRoom("metaplaza_demo");
    }

    public override void OnJoinedRoom(){
        PhotonNetwork.LoadLevel("Playground");
        // PhotonNetwork.LoadLevel("SampleScene");
    }

}
