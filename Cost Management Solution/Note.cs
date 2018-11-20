using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cost_Management_Solution
{
    class Note
    {
        private String id;
		private Double initiativeId;
		private String person;
		private String noteDate;
		private String description;
        private List<Note> noteList = new List<Note>();

        public string Id { get => id; set => id = value; }
        public Double InitiativeId { get => initiativeId; set => initiativeId = value; }
        public string Person { get => person; set => person = value; }
        public string NoteDate { get => noteDate; set => noteDate = value; }
        public string Description { get => description; set => description = value; }
        internal List<Note> NoteList { get => noteList; set => noteList = value; }

        public List<Note> getNotes(Double parmId)
		{
            OleDbConnection con = new OleDbConnection(Constants.DB_CON_STRING);
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM INITIATIVE_NOTES WHERE INITIATIVE_ID= ? ", con);
            cmd.Parameters.AddWithValue("?", parmId);
            con.Open();
            OleDbDataReader Reader = cmd.ExecuteReader();
			List<Note> results = new List<Note>();
			if (Reader.HasRows)
			{
				while (Reader.Read())
				{
					Note currentNote = new Note();
					currentNote.noteDate = Reader["NOTE_DATE"] ==null ? "" : Reader["NOTE_DATE"].ToString();
					currentNote.person = Reader["PERSON"] == null ? "" : Reader["PERSON"].ToString();
					currentNote.description = Reader["NOTE_DESC"] == null ? "" : Reader["NOTE_DESC"].ToString();
					results.Add(currentNote);
				}
			}
			return results;
		}
        public void loadNotes()
        {
            CostManagementForm mainForm = (CostManagementForm)Application.OpenForms[0];
            DataGridView notesTable = mainForm.noteGridView;
            List<Note> results = new List<Note>();
            foreach (DataGridViewRow row in notesTable.Rows)
            {
                    Note currentNote = new Note();
                    String noteDate = row.Cells["noteDate"].Value != null ? row.Cells["noteDate"].Value.ToString() : "";
                    String notePerson = row.Cells["notePerson"].Value != null ? row.Cells["notePerson"].Value.ToString() : "";
                    String noteDescription = row.Cells["noteDesc"].Value != null ? row.Cells["noteDesc"].Value.ToString() : "";

                    currentNote.initiativeId = Double.Parse(mainForm.InitiativeIdInput);
                    currentNote.noteDate = noteDate;
                    currentNote.person = notePerson;
                    currentNote.description = noteDescription;
                    results.Add(currentNote);
            }
            results.RemoveAt(results.Count-1);
            NoteList = results;
        }
        public void insertNotes()
        {
           
            foreach (Note note in NoteList)
            {
             
                OleDbConnection con = new OleDbConnection(Constants.DB_CON_STRING);
                OleDbCommand cmd = new OleDbCommand(Constants.DB.Insert.NOTES, con);
                cmd.Parameters.AddWithValue("@initiativeId", note.initiativeId);
                cmd.Parameters.AddWithValue("@noteDate", note.noteDate);
                cmd.Parameters.AddWithValue("@notePerson", note.noteDate);
                cmd.Parameters.AddWithValue("@noteDescription", note.noteDate);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
