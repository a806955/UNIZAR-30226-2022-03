using System;
using System.Collections.Generic;
using System.Text;

namespace UnoServer
{
    public class Card
    {
        //Todos los campos de los que consta una carta:
        public int id;
        public int valor;
        public string color;
        public string accion;

        public Card(int Id, int Valor, string Color, string Accion)
        {
            id = Id;
            valor = Valor;
            color = Color;
            accion = Accion;

        }
    }
}
