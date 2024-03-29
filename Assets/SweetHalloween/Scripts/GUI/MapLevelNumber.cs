﻿using UnityEngine;
using System.Collections;

public class MapLevelNumber : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().sortingLayerID = 1;
        GetComponent<Renderer>().sortingOrder = 1;
        int num = int.Parse( transform.parent.name.Replace( "Level", "" ) );
        GetComponent<TextMesh>().text = "" + num;
        if( num >= 10 ) transform.position += Vector3.left * 0.1f;
        if( num == 1 || num == 11 ) transform.position += Vector3.right * 0.05f;

	}
	
	// Update is called once per frame
	void Update () {
        if( transform.parent.Find( "Lock" ).gameObject.activeSelf ) GetComponent<TextMesh>().color = new Color( 126, 67, 42 );

	}
}
