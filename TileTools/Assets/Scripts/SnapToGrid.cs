using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapToGrid : MonoBehaviour {

    public int columns = 10;
    public int rows = 10;
    public float gridSize = 2.08f;
    public Color gridColor;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnDrawGizmos()
    {

        Gizmos.color = gridColor;

        for (int x = 0; x <= columns; ++x)
        {
            Gizmos.DrawLine(new Vector3(x * gridSize, 0, transform.position.z),
                new Vector3(x * gridSize, rows * gridSize, transform.position.z));
        }

        for (int y = 0; y <= rows; ++y)
        {
            Gizmos.DrawLine(new Vector3(0, y * gridSize, transform.position.z),
                new Vector3(columns * gridSize, y * gridSize, transform.position.z));
        }

        //SpriteRenderer[] sprites = GameObject.FindObjectOfType<SpriteRenderer>();

        //for (int i = 0; i < sprites.Length; i++)
        //{
        //    SpriteRenderer currentSpriteRenderer = sprites[i];
        //    Sprite currentSprite = currentSpriteRenderer.sprite;

        //    Vector3 spiteCenterWorld = currentSpriteRenderer.transform.position + currentSprite.bounds.center;

        //    Vector3 spriteCenterGrid = new Vector3(
        //        Mathf.FloorToInt(spiteCenterWorld.x / gridSize),
        //        Mathf.FloorToInt(spiteCenterWorld.y / gridSize),
        //        currentSpriteRenderer.transform.position.z);

        //    currentSpriteRenderer.transform.position = transform.position + spriteCenterGrid * gridSize;
        //}
    }
}
