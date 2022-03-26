using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]



public class Card 
{
    public int id;
    public int valor;
    public string color;
    public string accion;
    public Sprite spriteImagen;

    public Card()
    {

    }

    public Card(int Id, int Valor, string Color, string Accion, Sprite SpriteImagen)
    {
        id = Id;
        valor = Valor;
        color = Color;
        accion = Accion;
        spriteImagen = SpriteImagen;

    }
}
