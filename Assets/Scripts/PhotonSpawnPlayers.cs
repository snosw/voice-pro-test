using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PhotonSpawnPlayers : MonoBehaviour
{
    
    public GameObject playerPrefab;

    public float spawnX;
    public float spawnY;
    public float spawnZ;

    private void Start(){
        Vector3 spawnPosition = new Vector3(spawnX, spawnY, spawnZ);
        PhotonNetwork.Instantiate(playerPrefab.name, spawnPosition, Quaternion.identity);
    }
}
