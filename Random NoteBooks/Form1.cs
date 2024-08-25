using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Random_NoteBooks
{
   

    public partial class Title : Form
    {
        private List<Note> savedNotes = new List<Note>();
        private readonly string notesFilePath = "notes.json";

        public Title()
        {
            InitializeComponent();
            LoadNotes();
        }

        private void SaveNotes()
        {
            var json = JsonConvert.SerializeObject(savedNotes, Formatting.Indented);
            File.WriteAllText(notesFilePath, json);
        }

        private void LoadNotes()
        {
            if (File.Exists(notesFilePath))
            {
                var json = File.ReadAllText(notesFilePath);
                savedNotes = JsonConvert.DeserializeObject<List<Note>>(json) ?? new List<Note>();
                comboBoxSaved.Items.Clear();
                comboBoxSaved.Items.AddRange(savedNotes.ToArray());
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            string content = textBoxInput.Text;

            if (!string.IsNullOrWhiteSpace(title) && !string.IsNullOrWhiteSpace(content))
            {
                var note = new Note { Title = title, Content = content };
                savedNotes.Add(note);
                comboBoxSaved.Items.Add(note); // Ini akan menampilkan judul di ComboBox
                SaveNotes();
                textBoxTitle.Clear(); // Kosongkan input judul setelah menyimpan
                textBoxInput.Clear(); // Kosongkan input teks setelah menyimpan
            }
            else
            {
                MessageBox.Show("Title and Text must be filled!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxOutput.Text))
            {
                Clipboard.SetText(textBoxOutput.Text);
                MessageBox.Show("Text Copied Successfully", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (comboBoxSaved.SelectedItem is Note selectedNote)
            {
                textBoxOutput.Text = selectedNote.Content;
            }
        }

        private void comboBoxSaved_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Title_Load(object sender, EventArgs e)
        {

        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}