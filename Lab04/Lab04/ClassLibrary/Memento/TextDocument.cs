
namespace ClassLibrary.Memento
{
    public class TextDocument
    {
        public string Content { get; set; }

        public TextDocument(string content)
        {
            Content = content;
        }

        // Метод для створення знімка стану документа
        public TextDocumentMemento CreateMemento()
        {
            return new TextDocumentMemento(Content);
        }

        // Метод для відновлення документа з знімка
        public void RestoreMemento(TextDocumentMemento memento)
        {
            Content = memento.Content;
        }

        public override string ToString()
        {
            return Content;
        }
    }
}
