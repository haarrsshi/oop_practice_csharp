public class PercentContent :  Content
{
    public decimal Progress{get;set;} = 0.0m;
    public override void UpdateProgress()
    {
        Progress += 0.1m;
        if (Progress > 1.0m)
            Progress = 1.0m;
    }
    public override void ProgressInfo()
    {
        int PercentProgress = (int)(Progress * 100);
        Console.WriteLine($"Your Progress: {PercentProgress} % ");
    }
}