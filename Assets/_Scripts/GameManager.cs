using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameState State;
    public static event System.Action<GameState> OnGameStateChanged;

    void Awake(){
        Instance = this;
    }

    void Start(){
        UpdateGameState(GameState.GenerateGrid);
    }
    public void UpdateGameState(GameState newState){
        //call GameManager.Instance.UpdateGameState in other objects to progress the game
        State = newState;

        switch (newState)
        {
            case GameState.Menu:
                break;
            case GameState.GenerateGrid:
                UnitManager.Instance.SpawnMechs();
                break;
            case GameState.PlayerTurn:
                break;
            case GameState.FireTurn:
                break;
            case GameState.Victory:
                break;
            case GameState.Lose:
                break;
            default:
                break;         
           
        }

        OnGameStateChanged?.Invoke(newState);
    }

    private void HandleFireTurn(){

    }

    private void HandlePlayerTurn(){

    }
}

public enum GameState {
    Menu,
    GenerateGrid,
    PlayerTurn,
    FireTurn,
    Victory,
    Lose
}
