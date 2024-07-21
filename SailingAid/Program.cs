using System;
using System.Windows.Forms;
using System.Xml;

namespace XmlReaderGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize the GUI components
            Button loadButton = new Button();
            loadButton.Text = "Load Data";
            loadButton.Location = new System.Drawing.Point(10, 10);
            loadButton.Click += new EventHandler(LoadButton_Click);

            ListBox listBox = new ListBox();
            listBox.Name = "BooksListBox";
            listBox.Location = new System.Drawing.Point(10, 50);
            listBox.Size = new System.Drawing.Size(260, 200);

            this.Controls.Add(loadButton);
            this.Controls.Add(listBox);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            string filePath = "books.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            XmlNodeList bookNodes = doc.SelectNodes("/books/book");

            ListBox listBox = (ListBox)this.Controls["BooksListBox"];
            listBox.Items.Clear();

            foreach (XmlNode bookNode in bookNodes)
            {
                string id = bookNode.Attributes["id"].Value;
                string genre = bookNode.Attributes["genre"].Value;
                string title = bookNode["title"].InnerText;
                string author = bookNode["author"].InnerText;

                listBox.Items.Add($"ID: {id}, Genre: {genre}, Title: {title}, Author: {author}");
            }
        }
    }
}