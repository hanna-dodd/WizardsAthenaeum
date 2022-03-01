using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BoardManager : MonoBehaviour {

    [Serializable]
    public class Count {

        public int minimum;
        public int maximum;

        public Count(int min, int max) {

            minimum = min;
            maximum = max;

        }

    }

    public int columns;
    public int rows;

    public Count shelfCount = new Count(5, 9);
    public Count scrollCount = new Count(1, 3);

    public GameObject exit;
    public GameObject[] floorTiles;
    public GameObject[] shelfTiles;
    public GameObject[] scrollTiles;
    public GameObject[] enemyTiles;
    public GameObject[] wallTiles;

    private Transform boardHolder;
    private List<Vector3> gridPositions = new List<Vector3>();

    void InitializeList() {

        gridPositions.Clear();

        for (int x = 1; x < columns - 1; x++) {

            for (int y = 1; y < rows - 1; y++) {

                gridPositions.Add(new Vector3(x, y, 0f));

            }

        }

    }

    void BoardSetup() {

        boardHolder = new GameObject("Board").transform;

        for (int x = -1; x < columns + 1; x++) {

            for (int y = -1; y < rows + 1; y++) {

                GameObject toInstantiate = floorTiles[Random.Range(0, floorTiles.Length)];

                if (x == -1 || x == columns || y == -1 || y == rows) {

                    toInstantiate = wallTiles[Random.Range(0, wallTiles.Length)];

                }

                GameObject instance = Instantiate(toInstantiate, new Vector3(x, y, 0f), Quaternion.identity) as GameObject;

                instance.transform.SetParent(boardHolder);

            }

        }

    }

    Vector3 RandomPosition() {

        int randomIndex = Random.Range(0, gridPositions.Count);
        Vector3 randomPosition = gridPositions[randomIndex];
        gridPositions.RemoveAt(randomIndex);

        return randomPosition;

    }

    void LayoutObjectAtRandom(GameObject[] tileArray, int minimum, int maximum) {

        int objectCount = Random.Range(minimum, maximum + 1);

        for (int i = 0; i < objectCount; i++) {

            Vector3 randomPosition = RandomPosition();
            GameObject tileChoice = tileArray[Random.Range(0, tileArray.Length)];
            Instantiate(tileChoice, randomPosition, Quaternion.identity);

        }

    }

    public void SetupScene(int level) {

        BoardSetup();
        InitializeList();
        LayoutObjectAtRandom(shelfTiles, shelfCount.minimum, shelfCount.maximum);
        LayoutObjectAtRandom(scrollTiles, scrollCount.minimum, scrollCount.maximum);
        int enemyCount = (int)Mathf.Log(level, 2f);
        LayoutObjectAtRandom(enemyTiles, enemyCount, enemyCount);
        Instantiate(exit, new Vector3(columns - 1, rows - 1, 0f), Quaternion.identity);

    }

}