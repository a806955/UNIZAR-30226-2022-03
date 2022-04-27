using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace UnoServer
{
    public class CardDatabase
    {
        public static Stack<Card> cardList = new Stack<Card>();

        //Se declaran todas las cartas del mazo
        public CardDatabase()
        {
            /************************************* ROJAS ******************************************/
            cardList.Push(new Card(0, -1, "Rojo", "Intermision"));
            cardList.Push(new Card(1, -1, "Rojo", "Retorno"));
            cardList.Push(new Card(2, -1, "Rojo", "Toma dos"));
            cardList.Push(new Card(0, -1, "Rojo", "Intermision"));
            cardList.Push(new Card(1, -1, "Rojo", "Retorno"));
            cardList.Push(new Card(2, -1, "Rojo", "Toma dos"));

            cardList.Push(new Card(3, 0, "Rojo", "nada"));
            cardList.Push(new Card(4, 1, "Rojo", "nada"));
            cardList.Push(new Card(5, 2, "Rojo", "nada"));
            cardList.Push(new Card(6, 3, "Rojo", "nada"));
            cardList.Push(new Card(7, 4, "Rojo", "nada"));
            cardList.Push(new Card(8, 5, "Rojo", "nada"));
            cardList.Push(new Card(9, 6, "Rojo", "nada"));
            cardList.Push(new Card(10, 7, "Rojo", "nada"));
            cardList.Push(new Card(11, 8, "Rojo", "nada"));
            cardList.Push(new Card(12, 9, "Rojo", "nada"));
            cardList.Push(new Card(4, 1, "Rojo", "nada"));
            cardList.Push(new Card(5, 2, "Rojo", "nada"));
            cardList.Push(new Card(6, 3, "Rojo", "nada"));
            cardList.Push(new Card(7, 4, "Rojo", "nada"));
            cardList.Push(new Card(8, 5, "Rojo", "nada"));
            cardList.Push(new Card(9, 6, "Rojo", "nada"));
            cardList.Push(new Card(10, 7, "Rojo", "nada"));
            cardList.Push(new Card(11, 8, "Rojo", "nada"));
            cardList.Push(new Card(12, 9, "Rojo", "nada"));

            /**************************************************************************************/
            cardList.Push(new Card(13, -1, "Elige Color", "Elige Color"));
            cardList.Push(new Card(13, -1, "Elige Color", "Elige Color"));
            cardList.Push(new Card(13, -1, "Elige Color", "Elige Color"));
            cardList.Push(new Card(13, -1, "Elige Color", "Elige Color"));

            /********************************** AMARILLAS ******************************************/
            cardList.Push(new Card(14, -1, "Amarillo", "Intermision"));
            cardList.Push(new Card(15, -1, "Amarillo", "Retorno"));
            cardList.Push(new Card(16, -1, "Amarillo", "Toma dos"));
            cardList.Push(new Card(14, -1, "Amarillo", "Intermision"));
            cardList.Push(new Card(15, -1, "Amarillo", "Retorno"));
            cardList.Push(new Card(16, -1, "Amarillo", "Toma dos"));

            cardList.Push(new Card(17, 0, "Amarillo", "nada"));
            cardList.Push(new Card(18, 1, "Amarillo", "nada"));
            cardList.Push(new Card(19, 2, "Amarillo", "nada"));
            cardList.Push(new Card(20, 3, "Amarillo", "nada"));
            cardList.Push(new Card(21, 4, "Amarillo", "nada"));
            cardList.Push(new Card(22, 5, "Amarillo", "nada"));
            cardList.Push(new Card(23, 6, "Amarillo", "nada"));
            cardList.Push(new Card(24, 7, "Amarillo", "nada"));
            cardList.Push(new Card(25, 8, "Amarillo", "nada"));
            cardList.Push(new Card(26, 9, "Amarillo", "nada"));
            cardList.Push(new Card(18, 1, "Amarillo", "nada"));
            cardList.Push(new Card(19, 2, "Amarillo", "nada"));
            cardList.Push(new Card(20, 3, "Amarillo", "nada"));
            cardList.Push(new Card(21, 4, "Amarillo", "nada"));
            cardList.Push(new Card(22, 5, "Amarillo", "nada"));
            cardList.Push(new Card(23, 6, "Amarillo", "nada"));
            cardList.Push(new Card(24, 7, "Amarillo", "nada"));
            cardList.Push(new Card(25, 8, "Amarillo", "nada"));
            cardList.Push(new Card(26, 9, "Amarillo", "nada"));

            /**************************************************************************************/
            cardList.Push(new Card(27, -1, "4 colores", "4 colores"));
            cardList.Push(new Card(27, -1, "4 colores", "4 colores"));
            cardList.Push(new Card(27, -1, "4 colores", "4 colores"));
            cardList.Push(new Card(27, -1, "4 colores", "4 colores"));

            /********************************** VERDES ********************************************/
            cardList.Push(new Card(28, -1, "Verde", "Intermision"));
            cardList.Push(new Card(29, -1, "Verde", "Retorno"));
            cardList.Push(new Card(30, -1, "Verde", "Toma dos"));
            cardList.Push(new Card(28, -1, "Verde", "Intermision"));
            cardList.Push(new Card(29, -1, "Verde", "Retorno"));
            cardList.Push(new Card(30, -1, "Verde", "Toma dos"));

            cardList.Push(new Card(31, 0, "Verde", "nada"));
            cardList.Push(new Card(32, 1, "Verde", "nada"));
            cardList.Push(new Card(33, 2, "Verde", "nada"));
            cardList.Push(new Card(34, 3, "Verde", "nada"));
            cardList.Push(new Card(35, 4, "Verde", "nada"));
            cardList.Push(new Card(36, 5, "Verde", "nada"));
            cardList.Push(new Card(37, 6, "Verde", "nada"));
            cardList.Push(new Card(38, 7, "Verde", "nada"));
            cardList.Push(new Card(39, 8, "Verde", "nada"));
            cardList.Push(new Card(40, 9, "Verde", "nada"));
            cardList.Push(new Card(32, 1, "Verde", "nada"));
            cardList.Push(new Card(33, 2, "Verde", "nada"));
            cardList.Push(new Card(34, 3, "Verde", "nada"));
            cardList.Push(new Card(35, 4, "Verde", "nada"));
            cardList.Push(new Card(36, 5, "Verde", "nada"));
            cardList.Push(new Card(37, 6, "Verde", "nada"));
            cardList.Push(new Card(38, 7, "Verde", "nada"));
            cardList.Push(new Card(39, 8, "Verde", "nada"));
            cardList.Push(new Card(40, 9, "Verde", "nada"));

            /********************************** AZULES ********************************************/
            cardList.Push(new Card(42, -1, "Azul", "Intermision"));
            cardList.Push(new Card(43, -1, "Azul", "Retorno"));
            cardList.Push(new Card(44, -1, "Azul", "Toma dos"));
            cardList.Push(new Card(42, -1, "Azul", "Intermision"));
            cardList.Push(new Card(43, -1, "Azul", "Retorno"));
            cardList.Push(new Card(44, -1, "Azul", "Toma dos"));

            cardList.Push(new Card(45, 0, "Azul", "nada"));
            cardList.Push(new Card(46, 1, "Azul", "nada"));
            cardList.Push(new Card(47, 2, "Azul", "nada"));
            cardList.Push(new Card(48, 3, "Azul", "nada"));
            cardList.Push(new Card(49, 4, "Azul", "nada"));
            cardList.Push(new Card(50, 5, "Azul", "nada"));
            cardList.Push(new Card(51, 6, "Azul", "nada"));
            cardList.Push(new Card(52, 7, "Azul", "nada"));
            cardList.Push(new Card(53, 8, "Azul", "nada"));
            cardList.Push(new Card(54, 9, "Azul", "nada"));
            cardList.Push(new Card(46, 1, "Azul", "nada"));
            cardList.Push(new Card(47, 2, "Azul", "nada"));
            cardList.Push(new Card(48, 3, "Azul", "nada"));
            cardList.Push(new Card(49, 4, "Azul", "nada"));
            cardList.Push(new Card(50, 5, "Azul", "nada"));
            cardList.Push(new Card(51, 6, "Azul", "nada"));
            cardList.Push(new Card(52, 7, "Azul", "nada"));
            cardList.Push(new Card(53, 8, "Azul", "nada"));
            cardList.Push(new Card(54, 9, "Azul", "nada"));
        }

        public void Shuffle()
        {
            List<Card> list = cardList.ToList();
            ShuffleList(list);
            cardList = ToStack(list);
        }

        public static void ShuffleList(List<Card> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static Stack<Card> ToStack(List<Card> list)
        {
            Stack<Card> stack = new Stack<Card>();
            foreach (Card c in list)
                stack.Push(c);

            return stack;
        }

        public Card getNextCard()
        {
            return cardList.Pop();
        }

        public int getNextCardId()
        {
            Card c = cardList.Pop();
            return c.id;
        }

    }
}
