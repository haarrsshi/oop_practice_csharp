public class UnitContent :  Content
{
    public int Progress{get;set;}
    private int TotalUnits;

    public UnitContent(int totalunits)
    {

        TotalUnits = totalunits;
    }
    public override void UpdateProgress()
    {
        Progress ++;
        if (Progress > TotalUnits)
            Progress = TotalUnits;
    }
    public override void ProgressInfo()
    {
        Console.WriteLine($"Your Progress is: {Progress} out of {TotalUnits}");
    }
}