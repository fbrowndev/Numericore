using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handling all basic behaviour for the blocks
/// </summary>
public class Blocks : MonoBehaviour
{
    #region Block Variables
    [Header("Block Settings")]
    [SerializeField] private int _points;


    #endregion

    // Start is called before the first frame update
    void Start()
    {
        RandomPoints();
        Debug.Log(_points);
    }

    // Update is called once per frame
    void Update()
    {
        BlockMovmement();
    }

    #region Movement 
    //Needs to be configured for screen touches
    void BlockMovmement()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > -5)
        {
            transform.position += new Vector3(-1, 0, 0);
        } 
        else if(Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < 4)
        {
            transform.position += new Vector3(1,0,0);
        }
    }

    #endregion

    #region Block Logic
    void RandomPoints()
    {
        _points = Random.Range(2, 30);
    }

    #endregion
}