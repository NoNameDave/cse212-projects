public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value == Data) {
            return; // Ignore duplicate values
        }

        if (value < Data) {
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        } else {
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        if (value == Data) {
            return true;
        }
        if (value < Data) {
            return Left != null && Left.Contains(value);
        } else {
            return Right != null && Right.Contains(value);
        }
    }

    public int GetHeight() {
        int leftHeight = Left?.GetHeight() ?? 0;
        int rightHeight = Right?.GetHeight() ?? 0;
        int height = 1 + Math.Max(leftHeight, rightHeight);
        Console.WriteLine($"Node {Data} height: {height} (left: {leftHeight}, right: {rightHeight})");
        return height;
    }
}