using System;
using MonoTouch.UIKit;

namespace XamarinStoryboardTable
{
	public class RootTableSource : UITableViewSource
	{
		Chore[] tableItems;
		string cellIdentifier = "taskcell"; // set in the Storyboard

		public RootTableSource (Chore[] items)
		{
			tableItems = items;
		}

		public override int RowsInSection (UITableView tableview, int section)
		{
			return tableItems.Length;
		}

		public override UITableViewCell GetCell (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
		{
			// In Storyboard, dequeue will ALWAYS return a cell
			var cell = tableView.DequeueReusableCell (cellIdentifier);
			var choreRow = tableItems [indexPath.Row];
			cell.TextLabel.Text = choreRow.Name;

			if (choreRow.Done) {
				cell.Accessory = UITableViewCellAccessory.Checkmark;
			} else {
				cell.Accessory = UITableViewCellAccessory.None;
			}
			return cell;
		}

		public Chore GetItem(int id){
			return tableItems [id];
		}
	}
}

