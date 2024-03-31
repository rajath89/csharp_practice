using System.Reflection.Metadata.Ecma335;
using System.Text;

public class TextEditor
{
    private string? Text {get; set;}
    private Stack<Action> undoStack = new Stack<Action>();
    private Stack<Action> redoStack = new Stack<Action>();

    public string? CurrentText {get => Text;}

    public void AppendText(string newText)
    {
        Action undo = () => Text = Text.Substring(0, Text.Length - newText.Length);
        Action redo = () => Text += newText;

        Text += newText;
        undoStack.Push(undo);
        //redoStack.Clear();
        redoStack.Push(redo);
    }

    public void Undo()
    {
        if (undoStack.Count > 0)
        {
            Action undo = undoStack.Pop();
            undo();
            //redoStack.Push(() => AppendText(GetUndoneText(redoStack.Pop())));
        }
    }

    public void Redo()
    {
        if (redoStack.Count > 0)
        {
            Action redo = redoStack.Pop();
            redo();
            //undoStack.Push(() => Text = Text.Substring(0, Text.Length - GetRedoneText(redo).Length));
            // Action redo = redoStack.Pop();
            // string redoneText = GetRedoneText(redo); // Get the redone text before applying redo action
            // redo(); // Apply the redo action
            // undoStack.Push(() => AppendText(redoneText)); // Push a new undo action that adds the redone text
        }
    }

    public void ExRedo()
    {
        if (redoStack.Count > 0)
        {
            Action redo = redoStack.Pop();
            redo();
            string? currText = Text;
        }
    }

    private string GetUndoneText(Action undo)
    {
        // Create a string builder to capture the text modifications
        StringBuilder sb = new StringBuilder(Text);

        // Undo the action and capture the changes in the string builder
        undo();
        string undoneText = !string.IsNullOrEmpty(Text) ? Text : sb.ToString(); // sb now contains the text before undo

        // Redo the action to restore the original text
        // Action redo = () => Text = sb.ToString();
        // redo();

        return undoneText;
    }

    private string GetRedoneText(Action redo)
    {
        // // Create a temporary string builder to capture the redone text
        // var stringBuilder = new StringBuilder();
        
        // // Invoke the redo action to apply the text
        // redo();
        
        // // Append the redone text to the string builder
        // stringBuilder.Append(Text);
        
        // // Return the captured redone text
        // return stringBuilder.ToString();

                // Capture the current text
        string initialText = Text;

        // Redo the action to get the redone text
        redo();
        string redoneText = Text.Substring(initialText.Length);

        // Undo the action to revert back to the initial text
        Action undo = () => Text = initialText;
        undo();

        return redoneText;
    }
}
