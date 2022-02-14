using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayer : MonoBehaviour
{
    [SerializeField]
    private GameObject[] playerPieces;
    // Reseta o modelo do bloco quebrado
    public void ResetPlayerModel(){
        for(int i = 0; i < playerPieces.Length; i++){
            playerPieces[i].transform.localPosition = new Vector3(0.0f,0.0f,0.0f);
            playerPieces[i].transform.localRotation = Quaternion.identity;
        }
    }
}
