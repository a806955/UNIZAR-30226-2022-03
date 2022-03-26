using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientSend : MonoBehaviour
{
    private static void SendTCPData(Packet _packet)
    {
        _packet.WriteLength();
        Client.instance.tcp.SendData(_packet);
    }

    #region Packets
    public static void WelcomeReceived()
    {
        using (Packet _packet = new Packet((int)ClientPackets.welcomeReceived))
        {
            _packet.Write(Client.instance.myId);
            _packet.Write(UIManager.instance.usernameField.text);

            SendTCPData(_packet);
        }
    }

    public static void SendCard()
    {
        using (Packet _packet = new Packet((int)ClientPackets.sendCard))
        {
            _packet.Write(Client.instance.myId);
            _packet.Write(2);
            _packet.Write("Rojo");

            SendTCPData(_packet);
        }
    }
    #endregion
}
