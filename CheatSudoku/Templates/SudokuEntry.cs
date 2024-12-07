namespace CheatSudoku.Templates;

public class SudokuEntry : Entry
{
    /// <summary>
    /// Row, Column, and Block of entry in respect to Sudoku Grid.
    /// </summary>

    public static BindableProperty RowProperty = BindableProperty.Create(
            nameof(Row), typeof(int), typeof(SudokuEntry), 0);
    public int Row
    {
        get => (int)GetValue(RowProperty);
        set => SetValue(RowProperty, value);
    }

    public static BindableProperty ColProperty = BindableProperty.Create(
            nameof(Col), typeof(int), typeof(SudokuEntry), 0);
    public int Col
    {
        get => (int)GetValue(ColProperty);
        set => SetValue(ColProperty, value);
    }

    public static BindableProperty BlockProperty = BindableProperty.Create(
            nameof(Block), typeof(int), typeof(SudokuEntry), 0);
    public int Block
    {
        get => (int)GetValue(BlockProperty);
        set => SetValue(BlockProperty, value);
    }

    public SudokuEntry()
    {
    }
}