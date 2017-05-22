using UnityEngine;

[System.Serializable]
public struct HexCordinates{

	[SerializeField]
	private int x, z;

	public int X{ get {
			return x;
		}}
	public int Z{ get {
			return z;
		}}

	public HexCordinates(int x,int z){
		this.x = x;
		this.z = z;
	} 

	public static HexCordinates FromOffsetCordinates (int x,int z){
		return new HexCordinates(x - z / 2, z);

	}

	public int Y {
		get {
			return -X - Z;
		}
	}

	public override string ToString () {
		return "(" +
			X.ToString() + ", " + Y.ToString() + ", " + Z.ToString() + ")";
	}
	public string ToStringOnSeparateLines () {
		return X.ToString() + "\n" + Y.ToString() + "\n" + Z.ToString();
	}
}


