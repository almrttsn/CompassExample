using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public enum Direction { North, East, South, West } //4 adet yön attık enum içine.
    public Direction Dir => _direction; //bunu editörden bulabilmek için bu şekilde tanıttık.

    [SerializeField] private Direction _direction; //editördeki sekme.

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MoveCodeInserter(((int)Direction.West));
            Debug.Log(Direction.West);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveCodeInserter(((int)Direction.East));
            Debug.Log(Direction.East);
        }
                                                        //enum'daki elemanların içlerinde sahip oldukları int değerlerini kullanarak PickMoveCode metodu ile
                                                        //objeyi hareket ettirdik.
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MoveCodeInserter(((int)Direction.South));
            Debug.Log(Direction.South);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            MoveCodeInserter(((int)Direction.North));
            Debug.Log(Direction.North);
        }

        ElementValuePicker();
    }
    private void MoveCodeInserter(int MoveCode)
    {
        if(MoveCode == 0)
        {
            transform.position = new Vector3(0, -5, 0);
        }

        if (MoveCode == 1)
        {
            transform.position = new Vector3(5, 0, 0);
        }
                                                            //enum'dan gelen int değerleri ile hareket tanımladık.
        if (MoveCode == 2)
        {
            transform.position = new Vector3(0, 5, 0);
        }

        if (MoveCode == 3)
        {
            transform.position = new Vector3(-5, 0, 0);
        }

    }

    private void ElementValuePicker()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(((int)_direction));       //enum'da seçili elemanın sahip olduğu int değerini yazdırdık. Editördeki sekmeye ulaştık.
        }
    }



}
