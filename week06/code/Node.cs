public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else if (value != Left.Data)
                Left.Insert(value);
        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else if(value != Right.Data)
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        // TODO Start Problem 2
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                return false;
            else if (value == Left.Data)
                return true;
            else 
               return Left.Contains(value);
        }
        else {
            // Insert to the right
            if (Right is null)
                return false;
            else if(value == Right.Data)
                return true;
            else
                return Right.Contains(value);
        }

    }

    public int GetHeight() {
        // TODO Start Problem 4
        if (Left == null && Right !=null) {
            int rightHeight = Right.GetHeight();
            return 1 + rightHeight;
        } else if (Right == null && Left != null){
            int leftHeight = Left.GetHeight();
            return 1 + leftHeight;
        } else if (Left == null && Right ==null) {
            return 1;
        }
        else {
            if (Left != null && Right != null){
                int rightHeight = Right.GetHeight();
                int leftHeight = Left.GetHeight();
                if (leftHeight > rightHeight)
                    return 1 + leftHeight; // Replace this line with the correct return statement(s)
                else
                    return 1 + rightHeight;
            }
            else
                return 1;
        }
    }
}
