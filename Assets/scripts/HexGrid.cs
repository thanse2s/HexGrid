using UnityEngine;
using UnityEngine.UI;

public class HexGrid:MonoBehaviour{

	public int width = 6; 
	public int height = 6;

	public HexCell cellPrefab;
	public Text cellLabelPrefab;

	HexCell[] cells;
	Canvas gridCanvas;
	HexMesh hexMesh;

	GridColor gridcolor;

	public Color defaultColor = Color.red;

	void Awake(){
		cells = new HexCell[height * width];
		gridCanvas = GetComponentInChildren<Canvas> ();
		hexMesh = GetComponentInChildren<HexMesh> ();
		gridcolor = new GridColor ();


		for(int i=0,z=0;z<height;z++){
			for (int x = 0; x < width; x++) {
				CreateCell (x, z, i++);
			}
		}
	}

	void Start(){
	
		hexMesh.Triangulate (cells);
	
	}

	void CreateCell(int x,int z,int i){
		Vector3 pos;
		pos.x = (x + z * 0.5f - z / 2) * (HexMetrics.innerRadius * 2f);
		pos.y = 0f;
		pos.z = z * (HexMetrics.outerRadius * 1.5f);
	
		HexCell cell = cells [i] = Instantiate<HexCell> (cellPrefab);
		cell.transform.SetParent (transform, false);
		cell.transform.localPosition = pos;
		cell.coordinates = HexCordinates.FromOffsetCordinates(x, z);
		cell.color=defaultColor;
		cell.cell_index = cell.coordinates.X + cell.coordinates.Z * width + cell.coordinates.Z / 2;
		gridcolor.setColor (cell);

		if (x > 0) {
			cell.SetNeighbor (HexDirection.W, cells [i - 1]);
		}
		if (z > 0) {
			if ((z & 1) == 0) {
				cell.SetNeighbor (HexDirection.SE, cells [i - width]);
				if (x > 0) {
					cell.SetNeighbor (HexDirection.SW, cells [i - width - 1]);
				}
			} else {
				cell.SetNeighbor(HexDirection.SW,cells[i-width]);
				if (x < width - 1) {
					cell.SetNeighbor (HexDirection.SE, cells [i - width + 1]);
				}
			}
		}



		Text label = Instantiate<Text> (cellLabelPrefab);
		label.rectTransform.SetParent (gridCanvas.transform, false);
		label.rectTransform.anchoredPosition =
			new Vector2 (pos.x, pos.z);
		label.text = cell.cell_index.ToString();

	}



	void ColorSet(HexCell cell){

		switch (cell.cell_index) {
		case 1:
			Debug.Log ("INDEX 1");
			break;
		default:
			Debug.Log ("DEFAULT");
			break;


		}
		
	
	}
}

