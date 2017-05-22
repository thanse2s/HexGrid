using UnityEngine;

public class HexCell:MonoBehaviour{

	public HexCordinates coordinates;

	public int cell_index;

	public Color color;


	[SerializeField]
	HexCell[] neighbors;

	public HexCell GetNeighbor(HexDirection direction){
		return neighbors [(int)direction];
	}


	public void SetNeighbor (HexDirection direction,HexCell cell){
		neighbors [(int)direction] = cell;
		cell.neighbors [(int)direction.Opposite()] = this;
	}


}

