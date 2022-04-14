using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public enum Direction { North = 10, East, South, West } //4 adet yön attık enum içine.
    public Direction Dir => _direction; //bunu editörden bulabilmek için bu şekilde tanıttık.

    [SerializeField] private Direction _direction; //editördeki sekme.

    private int _moveCode = ((int)Direction.North);

    public int MoveCode
    {
        get
        {
            return _moveCode;
        }
        set
        {
            if(value > 9)
            {
                _moveCode = value - 5;
            }
            else
            {
                _moveCode = value;
            }
        }
    }

    private void Start()
    {
        Debug.Log("MoveCode is " + MoveCode);
        Debug.Log("_moveCode is " + _moveCode);
        Debug.Log(this._moveCode);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MoveCodeInserter((Direction.West));
            Debug.Log(Direction.West);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveCodeInserter((Direction.East));
            Debug.Log(Direction.East);
        }
                                                        //enum'daki elemanların içlerinde sahip oldukları int değerlerini kullanarak PickMoveCode metodu ile
                                                        //objeyi hareket ettirdik.
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            MoveCodeInserter((Direction.South));
            Debug.Log(Direction.South);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MoveCodeInserter((Direction.North));
            Debug.Log(Direction.North);
        }

        ElementValuePicker();
    }
    private void MoveCodeInserter(Direction _givenDirection)
    {
        switch (_givenDirection)
        {
            case Direction.North:
                transform.position = new Vector3(0, 5, 0);
                break;
            case Direction.East:
                transform.position = new Vector3(5, 0, 0);
                break;
            case Direction.South:                                   //enum'dan gelen int değerleri ile hareket tanımladık.
                transform.position = new Vector3(0, -5, 0);
                break;
            case Direction.West:
                transform.position = new Vector3(-5, 0, 0);
                break;
            default:
                break;
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
