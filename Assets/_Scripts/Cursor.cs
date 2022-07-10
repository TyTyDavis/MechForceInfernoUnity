using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{

    public GameObject cursor;
 
    //public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
             
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            
        cursor.transform.position = new Vector2(Mathf.Floor(mousePosition.x), Mathf.Floor(mousePosition.y));
    }
}
