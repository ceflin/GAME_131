using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(LevelCustomInspector))]
public class LevelCustomInspector : Editor
{
    //private void OnGUI()
    //{
    //    if (GUILayout.Button("Create Wall"))
    //    {
    //        string[] cubeGuids = AssetDatabase.FindAssets("wallBasePrefab");

    //        StringBuilder guidBuilder = new StringBuilder();
    //        foreach (string cubeGuid in cubeGuids)
    //        {
    //            guidBuilder.AppendLine(cubeGuid);
    //        }
    //        UnityEngine.MonoBehaviour.print(guidBuilder.ToString());

    //        if (cubeGuids.Length > 0)
    //        {
    //            string trueCubeGuid = cubeGuids[0];

    //            string assetPath = AssetDatabase.GUIDToAssetPath(trueCubeGuid);
    //            UnityEngine.MonoBehaviour.print(assetPath);


    //            GameObject cubeTemplate = AssetDatabase.LoadAssetAtPath(assetPath, typeof(GameObject)) as GameObject;

    //            GameObject newCube = GameObject.Instantiate(cubeTemplate);
    //            newCube.name = cubeTemplate.name;

    //            Vector3 newCubePos = newCube.transform.position;
    //            newCubePos.x = currentX;
    //            newCube.transform.position = newCubePos;

    //            currentX += 1f;
    //        }
    //    }
    //}
}
