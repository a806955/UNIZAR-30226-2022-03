﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UnoServer
{
    class ServerHandle
    {
        public static void WelcomeReceived(int _fromClient, Packet _packet)
        {
            int _clientIdCheck = _packet.ReadInt();
            string _username = _packet.ReadString();

            Console.WriteLine($"{Server.clients[_fromClient].tcp.socket.Client.RemoteEndPoint} connected successfully and is now player {_fromClient}.");
            if (_fromClient != _clientIdCheck)
            {
                Console.WriteLine($"Player \"{_username}\" (ID: {_fromClient}) has assumed the wrong client ID ({_clientIdCheck})!");
            }
            // TODO: send player into game
        }

        public static void CardRecieved(int _fromClient, Packet _packet)
        {
            int _clientIdCheck = _packet.ReadInt();
            int _numero = _packet.ReadInt();
            string _color = _packet.ReadString();

            Console.WriteLine($"Carta recibida, numero: \"{_numero} \" , color: \" {_color} \"");
            if (_fromClient != _clientIdCheck)
            {
                Console.WriteLine($"Player (ID: {_fromClient}) has assumed the wrong client ID ({_clientIdCheck})!");
            }
            // TODO: send player into game
        }
    }
}
