using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Text;

public class LevelEditorWindow : EditorWindow
{
    private float value = 0f;

    [MenuItem("Tools/Level Creator/Show Level Editor")]
    private static void ShowLevelEditor()
    {
        LevelEditorWindow.ShowWindow();
    }
    private static LevelEditorWindow instance;

    public static void ShowWindow()
    {
        instance = EditorWindow.GetWindow<LevelEditorWindow>();
        instance.titleContent = new GUIContent("Level Editor");
    }

    private float currentX = 0f;

    private void OnGUI()
    {
        //Creates an instance of an obsticle
        if (GUILayout.Button("Create Wall"))
        {
            string[] cubeGuids = AssetDatabase.FindAssets("wallBasePrefab");

            StringBuilder guidBuilder = new StringBuilder();
            foreach (string cubeGuid in cubeGuids)
            {
                guidBuilder.AppendLine(cubeGuid);
            }
            UnityEngine.MonoBehaviour.print(guidBuilder.ToString());

            if (cubeGuids.Length > 0)
            {
                string trueCubeGuid = cubeGuids[0];

                string assetPath = AssetDatabase.GUIDToAssetPath(trueCubeGuid);
                UnityEngine.MonoBehaviour.print(assetPath);


                GameObject cubeTemplate = AssetDatabase.LoadAssetAtPath(assetPath, typeof(GameObject)) as GameObject;

                GameObject newCube = GameObject.Instantiate(cubeTemplate);
                newCube.name = cubeTemplate.name;

                Vector3 newCubePos = newCube.transform.position;
                newCubePos.x = currentX;
                newCube.transform.position = newCubePos;

                currentX += 1f;
            }
        }
        //Creates an instance of an obsticle with a track
        if (GUILayout.Button("Create Wall (with track)"))
        {
            string[] cubeGuids = AssetDatabase.FindAssets("wallBasePrefab 1");

            StringBuilder guidBuilder = new StringBuilder();
            foreach (string cubeGuid in cubeGuids)
            {
                guidBuilder.AppendLine(cubeGuid);
            }
            UnityEngine.MonoBehaviour.print(guidBuilder.ToString());

            if (cubeGuids.Length > 0)
            {
                string trueCubeGuid = cubeGuids[0];

                string assetPath = AssetDatabase.GUIDToAssetPath(trueCubeGuid);
                UnityEngine.MonoBehaviour.print(assetPath);


                GameObject cubeTemplate = AssetDatabase.LoadAssetAtPath(assetPath, typeof(GameObject)) as GameObject;

                GameObject newCube = GameObject.Instantiate(cubeTemplate);
                newCube.name = cubeTemplate.name;

                Vector3 newCubePos = newCube.transform.position;
                newCubePos.x = currentX;
                newCube.transform.position = newCubePos;

                currentX += 1f;
            }
        }

        // Create an instance of the target
        if (GUILayout.Button("Create Target"))
        {
            string[] cubeGuids = AssetDatabase.FindAssets("Target");

            StringBuilder guidBuilder = new StringBuilder();
            foreach (string cubeGuid in cubeGuids)
            {
                guidBuilder.AppendLine(cubeGuid);
            }
            UnityEngine.MonoBehaviour.print(guidBuilder.ToString());

            if (cubeGuids.Length > 0)
            {
                string trueCubeGuid = cubeGuids[0];

                string assetPath = AssetDatabase.GUIDToAssetPath(trueCubeGuid);
                UnityEngine.MonoBehaviour.print(assetPath);


                GameObject targetTemplate = AssetDatabase.LoadAssetAtPath(assetPath, typeof(GameObject)) as GameObject;

                GameObject newTarget = GameObject.Instantiate(targetTemplate);
                newTarget.name = targetTemplate.name;

                Vector3 newTargetPos = newTarget.transform.position;
                newTargetPos.x = currentX;
                newTarget.transform.position = newTargetPos;

                currentX += 1f;
            }
        }
        EditorGUILayout.LabelField("Use 'W''A''S''D', 'Q' and 'E', and the arrow keys to move and rotate selected objects.");
    }

}
