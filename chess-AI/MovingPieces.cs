using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovingPieces : MonoBehaviour
{
    public GameObject[] Squares;
    Piece[] Pieces = new Piece[32];

    private void Start()
    {
        PieceType Pawn = new PieceType("pawn", 1);
        PieceType Knight = new PieceType("knight", 3);
        PieceType Bishop = new PieceType("bishop", 3);
        PieceType Rook = new PieceType("rook", 5);
        PieceType Queen = new PieceType("queen", 9);
        PieceType King = new PieceType("king", 200);
        
        //set values in the array

        for(int i = 0; i < 32; i++)
        {
            Pieces[i] = new Piece();
        }
        
        //set pawns

        for(int i = 0; i < 16; i++)
        {
            Pieces[i].type = Pawn;
        }

        //set knights

        for(int i = 16; i < 20; i++)
        {
            Pieces[i].type = Knight;
        }

        //set bishops

        for (int i = 20; i < 24; i++)
        {
            Pieces[i].type = Bishop;
        }

        //set rooks

        for (int i = 24; i < 28; i++)
        {
            Pieces[i].type = Rook;
        }

        //set queens

        for (int i = 28; i < 30; i++)
        {
            Pieces[i].type = Queen;
        }

        //set kings

        for (int i = 30; i < 32; i++)
        {
            Pieces[i].type = King;
        }

        //set pieces starting squares

        for (int i = 0; i < 8; i++)
        {
            Pieces[i].square = i + 9;
            Pieces[i].side = "black";
        }

        for (int i = 8; i < 16; i++)
        {
            Pieces[i].square = i + 41;
            Pieces[i].side = "white";
        }
    }
}

public class Piece
{
    public PieceType type;
    public string side;
    public int square;
}
public class PieceType
{
    public string tag;
    public int value;
    public PieceType(string tagString, int valueInt)
    {
        tag = tagString;
        value = valueInt;
    }
}
[System.Serializable]
public struct BoardSpot
{
    public GameObject Space;
}
