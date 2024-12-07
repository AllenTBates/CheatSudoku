using CheatSudoku.Templates;
using CommunityToolkit.Maui.Alerts;

namespace CheatSudoku;

public partial class MainPage : ContentPage
{
	Dictionary<int, List<int>> rows = new Dictionary<int, List<int>>();
	Dictionary<int, List<int>> cols = new Dictionary<int, List<int>>();
	Dictionary<int, List<int>> blocks = new Dictionary<int, List<int>>();

	public MainPage()
	{
		InitializeComponent();
	}

    private void GridUpdated(object sender, TextChangedEventArgs e)
    {
		if(e.NewTextValue == e.OldTextValue)
			return;

		//Make sure grid doesn't conflict with row, column, or block
        SudokuEntry se = (SudokuEntry)sender;
		if(se != null){
			int oldVal = -1;
			int newVal = -1;

			Int32.TryParse(e.OldTextValue, out oldVal);
			Int32.TryParse(e.NewTextValue, out newVal);

			Validate(rows, se, newVal);
			Validate(cols, se, newVal);
			Validate(blocks, se, newVal);
		}
    }

/// <summary>
/// Validates the new value against the given dictionary (i.e Rows, Columns, Blocks)
/// </summary>
/// <param name="dict">One of the three main dictionaries</param>
/// <param name="val">New value entered</param>
	private void Validate(Dictionary<int, List<int>> dict, SudokuEntry se, int val)
	{
			if(!dict.ContainsKey(se.Row))
				rows[se.Row].Add(val);
			else{
				if(rows[se.Row].Contains(val)){
					Toast.Make("No can do", CommunityToolkit.Maui.Core.ToastDuration.Short, 14);
				}
				else{
					rows[se.Row].Add(val);
				}
			}
	}
}