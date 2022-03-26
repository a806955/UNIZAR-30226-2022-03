using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class controladorMenu : MonoBehaviourPunCallbacks
{
    [SerializeField] private InputField crearSalaInput;
    [SerializeField] private InputField entrarSalaInput;
    
    // Start is called before the first frame update
    void Start()
    {   
        PhotonNetwork.GameVersion = "0.1"; 
        PhotonNetwork.ConnectUsingSettings();
        Debug.Log("Se va a conectar al servidor"); 
    }

    //Conexexión con el servidor
    public override void OnConnectedToMaster()
    {
        Debug.Log("Genial! Te has conectado con el servidor");
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.Log("Error al conectar con el servidor");
    }

    public void crearSala()
    {
        PhotonNetwork.CreateRoom(crearSalaInput.text, new RoomOptions() {MaxPlayers = 4},  null); 
        Debug.Log("Se creo la sala " + crearSalaInput.text);
    }

    public void entrarSala()
    {
        PhotonNetwork.JoinRoom(entrarSalaInput.text,null);
        Debug.Log(" Has entrado a la sala " + entrarSalaInput.text);
    }

}
