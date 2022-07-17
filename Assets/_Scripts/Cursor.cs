using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{

    public GameObject cursor;
    public CursorState State;
    public static event System.Action<CursorState> OnCursorStateChanged;
    
    //public Camera cam;
    public void UpdateCursorState(CursorState newState){
        //call GameManager.Instance.UpdateGameState in other objects to progress the game
        State = newState;

        switch (newState)
        {
            case CursorState.FreeMove:
                break;
            case CursorState.UnitSelect:
                break;
            default:
                break;         
           
        }

        OnCursorStateChanged?.Invoke(newState);
    }
    // Start is called before the first frame update
    void Start()
    {
        UpdateCursorState(CursorState.FreeMove);
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (State == CursorState.FreeMove)
        {
          Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
          cursor.transform.position = new Vector2(Mathf.Floor(mousePosition.x), Mathf.Floor(mousePosition.y));  
        }
    }
}

public enum CursorState {
    FreeMove,
    UnitSelect,
}