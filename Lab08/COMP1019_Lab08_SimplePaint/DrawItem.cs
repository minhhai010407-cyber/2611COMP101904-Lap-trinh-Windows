namespace COMP1019_Lab08_SimplePaint;

public class DrawItem
{
    public ToolMode Mode { get; set; }
    public Color Color { get; set; }
    public int Width { get; set; }
    public bool Fill { get; set; }
    public Point Start { get; set; }
    public Point End { get; set; }
    public List<Point> Points { get; set; } = new List<Point>();
}
