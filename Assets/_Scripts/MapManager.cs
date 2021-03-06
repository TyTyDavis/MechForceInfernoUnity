using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapManager : MonoBehaviour
{
    [SerializeField]
    private Tilemap map;

    [SerializeField]
    private List<TileData> tileDatas;

    private Dictionary<TileBase, TileData> dataFromTiles;

    public GameObject cursor;

    // Start is called before the first frame update
    private void Awake()
    {
        dataFromTiles = new Dictionary<TileBase, TileData>();
        foreach (var tileData in tileDatas)
        {
            foreach (var tile in tileData.tiles)
            {
                dataFromTiles.Add(tile, tileData);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
            {   
                Vector2 cursorPosition = new Vector2(cursor.transform.position.x, cursor.transform.position.y);
                Vector3Int gridPosition = map.WorldToCell(cursorPosition);
                TileBase clickedTile = map.GetTile(gridPosition);

                bool walkable = dataFromTiles[clickedTile].walkable;
                print("tile" + clickedTile + "@" + cursorPosition + "walkbable: " + walkable);
        
            }
    }
}
