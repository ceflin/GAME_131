using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Level))]
public class LevelCustomInspector : Editor {

    private Level _myTarget;

    public int newRows;
    public int newCols;


    private void OnEnable()
    {
        _myTarget = (Level)this.target;
    }

    public override void OnInspectorGUI()
    {
        //_myTarget.rows = EditorGUILayout.IntField("Rows", _myTarget.rows);
        //_myTarget.cols = EditorGUILayout.IntField("Columns", _myTarget.cols);

        //_myTarget.totalTime = EditorGUILayout.FloatField("Current Level Time", _myTarget.totalTime);
        //_myTarget.gravity = EditorGUILayout.FloatField("Gravity Magnitude", _myTarget.gravity);

        //_myTarget.bmg = (AudioClip)EditorGUILayout.ObjectField("Background Music", _myTarget.bmg, typeof(AudioClip), true);
        //_myTarget.background = (Sprite)EditorGUILayout.ObjectField("Background Display", _myTarget.background, typeof(Sprite), false);


        //bool increaseColumnsByOne = GUILayout.Button("Add column");
        //if (increaseColumnsByOne)
        //{
        //    _myTarget.cols++;
        //}

        EditorGUILayout.LabelField("Level rows", _myTarget.rows.ToString());
        EditorGUILayout.LabelField("Level columns", _myTarget.cols.ToString());


        newRows = EditorGUILayout.IntField("New rows", newRows);
        newCols = EditorGUILayout.IntField("New columns", newCols);

        bool resizeLevel = GUILayout.Button("Resize level");
        if (resizeLevel)
        {
            _myTarget.rows = newRows;
            _myTarget.cols = newCols;
            newRows = 0;
            newCols = 0;
        }

        bool reset = GUILayout.Button("Reset");
        if (reset)
        {
            newRows = 0;
            newCols = 0;
        }


    }



}
