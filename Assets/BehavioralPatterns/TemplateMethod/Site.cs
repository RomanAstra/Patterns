namespace TemplateMethod
{
    public abstract class Site
    {
        public void Draw()
        {
            DrawHeader();
            DrawBody();
            DrawFooter();
        }

        protected abstract void DrawHeader();
        protected abstract void DrawBody();
        protected abstract void DrawFooter();
    }
}
