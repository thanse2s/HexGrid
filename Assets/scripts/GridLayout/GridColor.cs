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


	public void setTestLayout(HexCell cell){
		switch (cell.cell_index) {

		//BLUE AREA
		case 0:
			cell.color = Color.blue;
			break;
		case 3:
			cell.color = Color.blue;
			break;
		case 8:
			cell.color = Color.blue;
			break;
		case 9:
			cell.color = Color.blue;
			break;
		case 15:
			cell.color = Color.blue;
			break;
		case 21:
			cell.color = Color.blue;
			break;
		case 22:
			cell.color = Color.blue;
			break;
		case 29:
			cell.color = Color.blue;
			break;
		case 30:
			cell.color = Color.blue;
			break;
		//YELLOWAREA
		case 1:
			cell.color = Color.yellow;
			break;
		case 10:
			cell.color = Color.yellow;
			break;
		case 16:
			cell.color = Color.yellow;
			break;
		case 13:
			cell.color = Color.yellow;
			break;
		case 14:
			cell.color = Color.yellow;
			break;
		case 19:
			cell.color = Color.yellow;
			break;
		case 26:
			cell.color = Color.yellow;
			break;
		//GREEN AREA
		case 4:
			cell.color = Color.green;
			break;
		case 11:
			cell.color = Color.green;
			break;
		case 7:
			cell.color = Color.green;
			break;
		case 12:
			cell.color = Color.green;
			break;
		case 17:
			cell.color = Color.green;
			break;
		case 18:
			cell.color = Color.green;
			break;
		case 25:
			cell.color = Color.green;
			break;
		case 31:
			cell.color = Color.green;
			break;
		case 32:
			cell.color = Color.green;
			break;
		case 33:
			cell.color = Color.green;
			break;
		//WHITE AREA
		default:
			cell.color = Color.white;
			break;


		}

	}


}