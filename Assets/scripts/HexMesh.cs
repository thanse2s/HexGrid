﻿using UnityEngine;
using System.Collections.Generic;

[RequireComponent(typeof(MeshFilter),typeof(MeshRenderer))]
public class HexMesh:MonoBehaviour{

	Mesh hexMesh;
	List<Vector3> vertices;
	List<int>triangles;
	List<Color>colors; 

	void Awake(){
		GetComponent<MeshFilter> ().mesh = hexMesh = new Mesh ();
		hexMesh.name = "Hex Mesh";
		vertices = new List<Vector3> ();
		triangles = new List<int>();
		colors = new List<Color> ();
	}


	public void Triangulate (HexCell[] cells) {
		hexMesh.Clear();
		vertices.Clear();
		triangles.Clear();
		colors.Clear ();
		for (int i = 0; i < cells.Length; i++) {
			Triangulate(cells[i]);
		}
		hexMesh.vertices = vertices.ToArray();
		hexMesh.colors = colors.ToArray ();
		hexMesh.triangles = triangles.ToArray();
		hexMesh.RecalculateNormals();
	}


	void Triangulate (HexCell cell) {
		for (HexDirection d = HexDirection.NE; d <= HexDirection.NW; d++) {
			Triangulate(d, cell);
		}
	}

	void Triangulate(HexDirection direction, HexCell cell){
		Vector3 center = cell.transform.localPosition;

		Vector3 v1 = center + HexMetrics.GetFirstSolidCorner (direction);
		Vector3 v2 = center + HexMetrics.GetSecondSolidCorner (direction);

		AddTriangle (center, v1, v2);
		AddTriangleColor (cell.color);

		if (direction <= HexDirection.SE) {
			TriangulateConnection (direction, cell, v1, v2);
		}
	
	}

	void TriangulateConnection(HexDirection direction,HexCell cell,Vector3 v1,Vector3 v2){
	
		HexCell neigbour = cell.GetNeighbor (direction);
		if (neigbour == null) {
			return;
		}

		Vector3 bridge = HexMetrics.GetBridge (direction);
		Vector3 v3 = v1 + bridge;
		Vector3 v4 = v2 + bridge;

		AddQuad (v1, v2, v3, v4);
		AddQuadColor (cell.color, neigbour.color);

		HexCell nextNeigbour = cell.GetNeighbor (direction.Next ());
		if (direction<=HexDirection.E && nextNeigbour != null) {
			AddTriangle (v2, v4, v2+HexMetrics.GetBridge(direction.Next()));
			AddTriangleColor (cell.color, neigbour.color, neigbour.color);
		}
	
	
	}

	void AddTriangleColor(Color c1,Color c2,Color c3){
		colors.Add (c1);
		colors.Add (c2);
		colors.Add (c3);
	}

	void AddTriangleColor(Color c1){
		colors.Add (c1);
		colors.Add (c1);
		colors.Add (c1);
	}

	void AddTriangle (Vector3 v1, Vector3 v2, Vector3 v3) {
		int vertexIndex = vertices.Count;
		vertices.Add(v1);
		vertices.Add(v2);
		vertices.Add(v3);
		triangles.Add(vertexIndex);
		triangles.Add(vertexIndex + 1);
		triangles.Add(vertexIndex + 2);
	}

	void AddQuad(Vector3 v1,Vector3 v2,Vector3 v3,Vector3 v4){
		int vertexIndex = vertices.Count;
		vertices.Add (v1);
		vertices.Add (v2);
		vertices.Add (v3);
		vertices.Add (v4);
		triangles.Add (vertexIndex);
		triangles.Add (vertexIndex+2);
		triangles.Add (vertexIndex+1);
		triangles.Add (vertexIndex+1);
		triangles.Add (vertexIndex+2);
		triangles.Add (vertexIndex+3);
	}

	void AddQuadColor(Color c1,Color c2)
	{
		colors.Add (c1);
		colors.Add (c1);
		colors.Add (c2);
		colors.Add (c2);
	
	}


		
}

