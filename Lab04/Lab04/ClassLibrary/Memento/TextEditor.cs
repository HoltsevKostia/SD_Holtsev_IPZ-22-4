
namespace ClassLibrary.Memento
{
    public class TextEditor
    {
        private TextDocument _document;

        public TextEditor(string content)
        {
            _document = new TextDocument(content);
        }

        // Метод для збереження стану документа
        public TextDocumentMemento Save()
        {
            return _document.CreateMemento();
        }

        // Метод для відновлення документа до попереднього стану
        public void Undo(TextDocumentMemento memento)
        {
            _document.RestoreMemento(memento);
        }

        // Метод для редагування документа
        public void Edit(string newContent)
        {
            _document.Content = newContent;
        }

        public override string ToString()
        {
            return _document.ToString();
        }
    }
}
