using UnityEngine;

public class GridColor:MonoBehaviour{

	public void setColor(HexCell cell){
		switch (cell.cell_index) {

		case 0:
			cell.color = Color.blue;
			break;
		case 1:
			cell.color = Color.yellow;
			break;
		case 2:
			cell.color = Color.yellow;
			break;
		case 3:
			cell.color = Color.yellow;
			break;
		case 4:
			cell.color = Color.blue;
			break;
		case 5:
			cell.color = Color.blue;
			break;
		case 6:
			cell.color = Color.yellow;
			break;
		case 9:
			cell.color = Color.yellow;
			break;
		case 11:
			ColorUtility.TryParseHtmlString("#663300",out cell.color);
			break;
		case 18:
			ColorUtility.TryParseHtmlString("#663300",out cell.color);
			break;
		case 19:
			ColorUtility.TryParseHtmlString("#663300",out cell.color);
			break;
		case 24:
			ColorUtility.TryParseHtmlString("#663300",out cell.color);
			break;
		case 25:
			ColorUtility.TryParseHtmlString("#663300",out cell.color);
			break;
		case 26:
			ColorUtility.TryParseHtmlString("#663300",out cell.color);
			break;
		case 30:
			ColorUtility.TryParseHtmlString("#663300",out cell.color);
			break;
		case 31:
			ColorUtility.TryParseHtmlString("#663300",out cell.color);
			break;
		case 32:
			ColorUtility.TryParseHtmlString("#663300",out cell.color);
			break;
		case 33:
			ColorUtility.TryParseHtmlString("#663300",out cell.color);
			break;
		case 34:
			ColorUtility.TryParseHtmlString("#663300",out cell.color);
			break;
		case 35:
			ColorUtility.TryParseHtmlString("#663300",out cell.color);
			break;
		default:
			cell.color = Color.green;
			break;


		}




	}


}