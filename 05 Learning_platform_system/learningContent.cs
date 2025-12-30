public abstract class Content
{
    public string Title {get;set;}
    public abstract void UpdateProgress();
    public abstract void ProgressInfo();
}