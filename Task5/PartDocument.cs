namespace Classes
{
    public abstract class PartDocument
    {
        protected string content;
        public abstract string Content { get; set; }
        public abstract void Show();
    }
}
