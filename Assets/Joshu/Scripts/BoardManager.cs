using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    [SerializeField] private GameObject prefabTile;
    [SerializeField] private GameObject stageInner;
    [SerializeField] private GameObject stageOuter;
    [SerializeField] private GameObject stageThird;

    public int xSize, ySize;
    public GameObject[,] grid;
    public void Start()
    {
        CreateStage();
        //inner.GetComponent<SpriteRenderer>().color = UnityEngine.Color.blue;
    }

    private void CreateStage()
    {
        CreateStageItem(stageInner, 0, 0, UnityEngine.Color.red);
        CreateStageItem(stageOuter, 0, 0, UnityEngine.Color.blue);
        CreateStageItem(stageThird, 0, 0, UnityEngine.Color.yellow);
    }

    private void CreateStageItem(GameObject obj, int x, int y, UnityEngine.Color colour)
    {
        Vector2 stageStartPos = new Vector2(x, y);
        GameObject stageTile = Instantiate(obj);
        stageTile.transform.parent = this.transform;
        stageTile.transform.position = new Vector2(stageStartPos.x, stageStartPos.y);
        obj.GetComponent<SpriteRenderer>().color = colour;
    }

    private void ColorTile(int x, int y, Color color)
    {
        grid[x, y].GetComponent<SpriteRenderer>().color = color;
    }

    private Vector2 GetSize(GameObject tile)
    {
        return new Vector2(tile.GetComponent<SpriteRenderer>().bounds.size.x, tile.GetComponent<SpriteRenderer>().bounds.size.y);
    }

    private void CreateBoard(int width, int height)
    {
        grid = new GameObject[width, height];
        Vector2 startPos = this.transform.position;
        for (int x = 0; x < xSize; x++)
        {
            for (int y = 0; y < ySize; y++)
            {
                GameObject tile = Instantiate(prefabTile);
                tile.transform.parent = this.transform;
                tile.transform.position = new Vector2(startPos.x + (GetSize(prefabTile).x * x), startPos.y + (GetSize(prefabTile).y * y));
                grid[x, y] = tile;
            }
        }
    }

    public GameObject GetStageInner()
    {
        return stageInner;
    }

}
