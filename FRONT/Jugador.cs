using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]



public class Jugador 
{
    public int idJugador;
    public List<Card> cartasJugador = new List<Card>();
    public Sprite spriteImagen;

    public Jugador()
    {

    }

    public Jugador(int IdJugador, List<Card> CartasJugador, Sprite SpriteImagen)
    {
        idJugador = IdJugador;
        cartasJugador = CartasJugador; //se puede hacer esto?
        spriteImagen = SpriteImagen;

    }
}
