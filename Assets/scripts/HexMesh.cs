using UnityEngine;
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
		Vector3 v1 = center + HexMetrics.GetFirstCorner (direction);
		Vector3 v2 = center + HexMetrics.GetSecondCorner (direction);
		for(int i=0;i<6;i++){
			

		
		

			HexCell prevNeigbor = cell.GetNeighbor (direction.Previous ()) ?? cell;
			HexCell neighbor = cell.GetNeighbor (direction) ?? cell;
			HexCell nextNeigbor = cell.GetNeighbor (direction.Next ()) ?? cell;


			AddTriangle(center,v1,v2);
			AddTriangleColor(cell.color,cell.color,cell.color);
		
		

		

		}
	}


	void AddTriangleColor(Color c1,Color c2,Color c3){
		colors.Add (c1);
		colors.Add (c2);
		colors.Add (c3);
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
		
}

