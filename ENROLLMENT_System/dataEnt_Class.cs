using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.Linq;

namespace ENROLLMENT_System
{
    public partial class dataEnt_Class : Form
    {
        DataClassEnrollmentDataContext db = new DataClassEnrollmentDataContext();

        private StringBuilder checkedInitials = new StringBuilder();
        private List<string> selectedDays = new List<string>();

        AutoCompleteStringCollection autoCompleteData = new AutoCompleteStringCollection();

        private List<ENROLLMENT_System.display_ClassContentResult> result;
        private int rowIndex;
        int id;
        public class Section
        {
            public string FullSectionName { get; set; }
        }
        public class Professor
        {
            public int Prof_id { get; set; }
            public string Prof_Fname { get; set; }
            public string Prof_Lname { get; set; }
            public string Prof_Mname { get; set; }
        }
        public dataEnt_Class()
        {
            InitializeComponent();

            display();

            savebtn.Hide();

            systart.Format = DateTimePickerFormat.Custom;
            systart.CustomFormat = "yyyy";
            systart.ShowUpDown = true;
            syend.Format = DateTimePickerFormat.Custom;
            syend.CustomFormat = "yyyy";
            syend.ShowUpDown = true;

            secIn.Enabled = false;
            secOut.Enabled = false;
            thirdIn.Enabled = false;
            thirdOut.Enabled = false;

            systart.ValueChanged += dateTimePicker1_ValueChanged;
            systart.ValueChanged += (sender, e) => UpdateAllowedYears();

            timepicker();
            LoadProgramNames();
            LoadSectionname();
            LoadSubjName();

            InitializeCheckedListBox();


            C_Prof.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            C_Prof.AutoCompleteSource = AutoCompleteSource.CustomSource;

            FetchDataFromDatabase();

            C_Prof.AutoCompleteCustomSource = autoCompleteData;
        }
        private void UpdateAllowedYears()
        {
            int selectedYear = systart.Value.Year;
            syend.CustomFormat = "yyyy";
            syend.Value = new DateTime(selectedYear + 1, 1, 1);
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            UpdateAllowedYears();
        }
        private void timepicker()
        {
            firstIn.Format = DateTimePickerFormat.Time;
            firstIn.Value = DateTime.Today;
            firstIn.ShowUpDown = true;
            firstOut.Format = DateTimePickerFormat.Time;
            firstOut.Value = DateTime.Today;
            firstOut.ShowUpDown = true;

            //secondTime
            secIn.Format = DateTimePickerFormat.Time;
            secIn.Value = DateTime.Today;
            secIn.ShowUpDown = true;
            secOut.Format = DateTimePickerFormat.Time;
            secOut.Value = DateTime.Today;
            secOut.ShowUpDown = true;

            //thirdtime
            thirdIn.Format = DateTimePickerFormat.Time;
            thirdIn.Value = DateTime.Today;
            thirdIn.ShowUpDown = true;
            thirdOut.Format = DateTimePickerFormat.Time;
            thirdOut.Value = DateTime.Today;
            thirdOut.ShowUpDown = true;
        }
        private void LoadProgramNames()
        {
            try
            {
                var programNames = db.display_progname()
                                      .Select(result => result.ProgramName)
                                      .ToList();

                // Add a default item at the top
                programNames.Insert(0, " ");

                // Assuming Stud_Prog is the name of your ComboBox control
                C_program.DataSource = programNames;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading program names: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadSectionname()
        {
            try
            {
                // Assuming db.display_sectname() returns a list of objects with a property named FullSectionName
                var sectionNames = db.display_sectname()
                                      .Select(result => new Section
                                      {
                                          FullSectionName = result.FullSectionName
                                      })
                                      .ToList();

                // Add a default item at the top
                sectionNames.Insert(0, new Section { FullSectionName = " " });

                // Assuming C_section is the name of your ComboBox control
                C_section.DataSource = sectionNames;
                C_section.DisplayMember = "FullSectionName";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Section names: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadSubjName()
        {
            try
            {
                // Assuming db.display_sectname() returns a list of objects with a property named FullSectionName
                var subjNames = db.display_subjname()
                                      .Select(result => new SUBJECT
                                      {
                                          Sub_Code = result.Sub_Code
                                      })
                                      .ToList();

                // Add a default item at the top
                subjNames.Insert(0, new SUBJECT { Sub_Code = " " });

                // Assuming C_section is the name of your ComboBox control
                C_subject.DataSource = subjNames;
                // Assuming "SubjectNames" is a property in your SUBJECT class
                C_subject.DisplayMember = "SubjectNames";
                // Assuming "Sub_Code" is the value you want to retrieve
                C_subject.ValueMember = "Sub_Code";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Section names: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InitializeCheckedListBox()
        {
            // Days of the week
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            // Add full day names to the CheckedListBox
            foreach (string day in daysOfWeek)
            {
                SchedCheckList.Items.Add(day);
            }

            // Handle the ItemCheck event to update the checklist
            SchedCheckList.ItemCheck += SchedCheckList_ItemCheck;

            // Retrieve data from the database and set the initial state of the checklist
            // Provide an appropriate value for rowIndex based on your requirements
            int rowIndex = 0; // Change this to the desired row index
            List<string> selectedDaysForRow = GetSelectedDaysForRow(result, rowIndex);
            CheckItemsInSchedCheckList(selectedDaysForRow);
        }


        private void UpdateCheckedDays(string selectedDay, bool isChecked)
        {
            // Update the checked days list and initials string based on the current state
            if (isChecked)
            {
                selectedDays.Add(selectedDay);
                checkedInitials.Append(GetDayAbbreviation(selectedDay));
            }
            else
            {
                selectedDays.Remove(selectedDay);
                int indexOfDay = checkedInitials.ToString().IndexOf(GetDayAbbreviation(selectedDay));
                if (indexOfDay != -1)
                {
                    checkedInitials.Remove(indexOfDay, GetDayAbbreviation(selectedDay).Length);
                }
            }
        }

        private string GetDayAbbreviation(string day)
        {
            switch (day)
            {
                case "Monday":
                    return "M";
                case "Tuesday":
                    return "T";
                case "Wednesday":
                    return "W";
                case "Thursday":
                    return "Th";
                case "Friday":
                    return "F";
                case "Saturday":
                    return "S";
                case "Sunday":
                    return "Sn";
                default:
                    return string.Empty;
            }
        }

        private void FetchDataFromDatabase()
        {
            try
            {
                // Call the stored procedure to get suggestions based on the search key
                var suggestions = db.search_profname(C_Prof.Text)
                                    .Select(result => $"{result.Prof_Fname} {result.Prof_Mname} {result.Prof_Lname}");

                // Add suggestions to AutoCompleteStringCollection
                autoCompleteData.AddRange(suggestions.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching data from the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            string Classcode = C_code.Text;
            string Classroom = C_classroom.Text;
            string Sched = checkedInitials.ToString();
            string selectedprog = C_program.SelectedItem?.ToString();
            string selectedSection = C_section.SelectedItem?.ToString();
            string selectedsubj = C_program.SelectedItem?.ToString();
            bool isclscodeEmpty = string.IsNullOrWhiteSpace(C_code.Text);
            bool isclroomEmpty = string.IsNullOrWhiteSpace(C_classroom.Text);
            bool isprogramEmpty = string.IsNullOrWhiteSpace(selectedprog);
            bool isprofEmpty = string.IsNullOrWhiteSpace(C_Prof.Text);
            bool isSectionEmpty = string.IsNullOrWhiteSpace(selectedSection);
            bool isSubjEmpty = string.IsNullOrWhiteSpace(selectedsubj);


            if (isprofEmpty)
            {
                MessageBox.Show("Enter an Instructor name ", "Message");
                return;
            }

            DateTime selecteddatestart = systart.Value;
            DateTime selecteddateEnd = syend.Value;

            string DateTimeIn1 = firstIn.Value.ToString("hh:mm tt");
            string DateTimeOut1 = firstOut.Value.ToString("hh:mm tt");
            string DateTimeIn2 = secIn.Value.ToString("hh:mm tt");
            string DateTimeOut2 = secOut.Value.ToString("hh:mm tt");
            string DateTimeIn3 = thirdIn.Value.ToString("hh:mm tt");
            string DateTimeOut3 = thirdOut.Value.ToString("hh:mm tt");

            string first = DateTimeIn1 + " - " + DateTimeOut1;
            string second = DateTimeIn2 + " - " + DateTimeOut2;
            string third = DateTimeIn3 + " - " + DateTimeOut3;

            string timepick;

            if ((secIn.Enabled == true && secOut.Enabled == true) && (thirdIn.Enabled == true && thirdOut.Enabled == true))
            {
                timepick = $"{first} / {second} / {third}";
            }
            else if (secIn.Enabled == true && secOut.Enabled == true)
            {
                timepick = $"{first} / {second}";
            }
            else
            {
                timepick = $"{first}";
            }

            int yearstr = selecteddatestart.Year;
            int yearend = selecteddateEnd.Year;


            if (SchedCheckList.CheckedIndices.Count == 0)
            {
                MessageBox.Show("Please check the Schedule", "Error");
                return;
            }

            if (isclroomEmpty || isclscodeEmpty || isprofEmpty || isprogramEmpty || isSectionEmpty || isSubjEmpty)
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error");
                return;
            }

            string[] progNameParts = C_program.SelectedValue.ToString().Trim().Split(' ');
            string progname = progNameParts.ElementAtOrDefault(0) ?? string.Empty.Trim();
            string progtype = progNameParts.ElementAtOrDefault(1) ?? string.Empty.Trim();
            var resultProgId = db.select_progId(progname, progtype).SingleOrDefault();

            if (resultProgId == null)
            {
                MessageBox.Show("Error: No value for Program Found", "Error");
                return;
            }

            string[] SectionParts = C_section.Text.Trim().Split(' ');
            string Sectname = SectionParts.ElementAtOrDefault(0) ?? string.Empty;
            string Sectyear = SectionParts.ElementAtOrDefault(1) ?? string.Empty;
            string Sectblock = SectionParts.ElementAtOrDefault(2) ?? string.Empty;
            var resultSectId = db.select_SecId(Sectname, Sectyear, Sectblock).SingleOrDefault();

            if (resultSectId == null)
            {
                MessageBox.Show("Error: No value for Section Id Found", "Error");
                return;
            }

            string subcode = C_subject.SelectedValue.ToString().Trim();
            var resultSubjId = db.select_subjId(subcode).SingleOrDefault();

            if (resultSubjId == null)
            {
                MessageBox.Show("Error: No value for Subject Id Found", "Error");
                return;
            }

            string[] profNameParts = C_Prof.Text.Trim().Split(' ');
            string profFname = profNameParts.ElementAtOrDefault(0) ?? string.Empty;
            string profLname = profNameParts.ElementAtOrDefault(1) ?? string.Empty;
            string profMname = profNameParts.ElementAtOrDefault(2);

            var matchingCounts = new[]
            {
                db.check_Prof_exists(profFname, profLname, profMname).Select(result => result.MatchingCount).FirstOrDefault(),
                db.check_Prof_exists(profLname, profFname, profMname).Select(result => result.MatchingCount).FirstOrDefault(),
                db.check_Prof_exists(profFname, profMname, profLname).Select(result => result.MatchingCount).FirstOrDefault()
            };

            if (!matchingCounts.Any(count => count > 0))
            {
                MessageBox.Show("Professor does not exist");
                return;
            }

            var selectId = new[]
            {
                db.select_ProfId(profFname, profLname, profMname).Select(rs => rs.Prof_id).FirstOrDefault(),
                db.select_ProfId(profLname, profFname, profMname).Select(rs => rs.Prof_id).FirstOrDefault(),
                db.select_ProfId(profFname, profMname, profLname).Select(rs => rs.Prof_id).FirstOrDefault()
            };

            var firstNonZeroId = selectId.FirstOrDefault(id => id != 0);

            var matchingCountClass = db.check_class_exists(Classcode).Select(res => res.MatchingCount).FirstOrDefault();

            if (matchingCountClass.HasValue)
            {
                int matchingCountValue = matchingCountClass.Value;

                // Check if matchingCountValue is greater than zero
                if (matchingCountValue > 0)
                {
                    MessageBox.Show("Classcode already exists!");
                }
                else
                {
                    db.add_class(Classcode, Sched, timepick, yearstr, yearend, Classroom, resultProgId.Prog_id, resultSectId.Sect_id, resultSubjId.Sub_id, firstNonZeroId);
                    MessageBox.Show("Successfully Recorded", "Message");
                    clear();
                    display();
                }
            }
        }
        private void display()
        {
            displayClass_GridView.DataSource = db.display_class();
        }
        private void clear()
        {
            C_code.Text = "";
            C_classroom.Text = "";
            C_program.SelectedIndex = -1;
            C_Prof.Text = "";
            C_section.SelectedIndex = -1;
            C_subject.SelectedIndex = -1;
            systart.Value = DateTime.Now;
            syend.Value = DateTime.Now;

            for (int i = 0; i < SchedCheckList.Items.Count; i++)
            {
                SchedCheckList.SetItemChecked(i, false);
            }

            timepicker();
        }

        private void displayClass_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            timepicker();
            try
            {
                if (displayClass_GridView.Columns[e.ColumnIndex].Name == "Edit")
                {
                    savebtn.Hide();
                    updateClass.Show();
                    id = int.Parse(displayClass_GridView.CurrentRow.Cells[2].Value.ToString());
                    setProgname();
                    setProfname();
                    setSectionname();
                    setSubjname();
                    int rowIndex = e.RowIndex; // Get the selected row index
                    RetrieveDataByIndex(rowIndex);
                }
                else if (displayClass_GridView.Columns[e.ColumnIndex].Name == "Delete")
                {
                    // Retrieve the ID from the selected row
                    if (MessageBox.Show("Are you sure you want to delete this record? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        id = int.Parse(displayClass_GridView.CurrentRow.Cells[2].Value.ToString());
                        db.delete_class(id);
                        MessageBox.Show("Successfully Deleted", "DELETE");
                        display();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error datagrid: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void RetrieveDataByIndex(int rowIndex)
        {
            try
            {
                var result = db.display_ClassContent().ToList();

                if (result.Count > rowIndex)
                {
                    var row = result[rowIndex];

                    // Access columns by property name
                    id = row.Class_id;
                    C_code.Text = row.Class_Code;
                    C_classroom.Text = row.Class_Room;

                    int yearStart = row.YearStart.Value;
                    int yearEnd = row.YearEnd.Value;

                    // Create a new DateTime object with the extracted year
                    DateTime startDate = new DateTime(yearStart, 1, 1);
                    DateTime endDate = new DateTime(yearEnd, 1, 1);

                    // Set the value of the DateTimePicker
                    systart.Value = startDate;
                    syend.Value = endDate;

                    // Get the selected days for the current 
                    List<string> selectedDaysForRow = SplitByCapitalLetters(row.DaysOfWeek);

                    // Check items in the SchedCheckList based on selected days
                    CheckItemsInSchedCheckList(selectedDaysForRow);

                    // Get the selected time for the current row
                    List<string> selectedTimeForRow = GetSelectedTime(result, rowIndex);

                }
                else
                {
                    // Handle the case where the result set doesn't have enough rows
                    Console.WriteLine("Row index out of range");
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine("Error retrieve: " + ex.Message);
            }
        }

        private void CheckItemsInSchedCheckList(List<string> selectedDays)
        {
            // Uncheck all items first
            for (int i = 0; i < SchedCheckList.Items.Count; i++)
            {
                SchedCheckList.SetItemCheckState(i, CheckState.Unchecked);
            }

            // Check items based on selected days
            foreach (string selectedDay in selectedDays)
            {
                // Find the index of the selected day in the checklist
                int index = SchedCheckList.FindStringExact(GetDayAbbreviationValue(selectedDay));

                if (index != ListBox.NoMatches)
                {
                    // If the day is found, check the item
                    SchedCheckList.SetItemCheckState(index, CheckState.Checked);
                }
            }
        }
        private string GetDayAbbreviationValue(string day)
        {
            switch (day)
            {
                case "M":
                    return "Monday";
                case "T":
                    return "Tuesday";
                case "W":
                    return "Wednesday";
                case "Th":
                    return "Thursday";
                case "F":
                    return "Friday";
                case "S":
                    return "Saturday";
                case "Sn":
                    return "Sunday";
                default:
                    return string.Empty;
            }
        }

        private List<string> SplitByCapitalLetters(string input)
        {
            // Use a regular expression to split the string by capital letters
            var matches = Regex.Matches(input, "[A-Z][a-z]*");

            // Convert the matches to a list of strings
            List<string> result = new List<string>();
            foreach (Match match in matches)
            {
                result.Add(match.Value);
            }
            return result;
        }


        private void SchedCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Handle the ItemCheck event to update the checklist
            string selectedDay = SchedCheckList.Items[e.Index].ToString();
            bool isChecked = e.NewValue == CheckState.Checked;

            // Update the checked days list and initials string
            UpdateCheckedDays(selectedDay, isChecked);
        }

        private List<string> GetSelectedDaysForRow(List<ENROLLMENT_System.display_ClassContentResult> result, int rowIndex)
        {
            if (result != null && rowIndex >= 0 && rowIndex < result.Count)
            {
                var row = result[rowIndex];

                if (row != null && row.DaysOfWeek != null)
                {
                    // Access the 'DaysOfWeek' property from your data source
                    string selectedDaysString = row.DaysOfWeek; // Change 'DaysOfWeek' to the actual property name

                    // Split the string by capital letters
                    List<string> selectedDays = SplitByCapitalLetters(selectedDaysString);
                    return selectedDays;
                }
            }

            // Handle the case where 'result' is null, 'rowIndex' is out of range, or 'row' or 'row.DaysOfWeek' is null
            return new List<string>(); // or return null, depending on your requirements
        }
        private List<string> GetSelectedTime(List<ENROLLMENT_System.display_ClassContentResult> result, int rowIndex)
        {
            if (result != null && rowIndex >= 0 && rowIndex < result.Count)
            {
                var row = result[rowIndex];

                if (row != null && row.SchedTime != null)
                {
                    // Split the SchedTime value into parts using '-' and '/'
                    List<string> splitTimeParts = SplitByDashnSlash(row.SchedTime);

                    return splitTimeParts;
                }
            }

            return new List<string>();
        }

        private List<string> SplitByDashnSlash(string input)
        {
            // Split the schedTime into parts using the specified delimiters (dash and slash)
            string[] timeParts = input.Split('-', '/');

            // Ensure that there are at least 2 parts
            if (timeParts.Length >= 2)
            {
                // Convert the split values into time format 'hh:mm:tt'
                List<string> formattedTimeParts = new List<string>();
                foreach (string part in timeParts)
                {
                    if (TryParseTime(part.Trim(), out string formattedTime))
                    {
                        formattedTimeParts.Add(formattedTime);
                    }
                    else
                    {
                        // Handle invalid time format if needed
                        formattedTimeParts.Add("Invalid Time");
                    }
                }
                // Assign the formatted time values to specific textboxes (assuming you have textboxes named firstIn, firstOut, etc.)
                if (formattedTimeParts.Count >= 2)
                {
                    // Assuming DateTimePickers are used for firstIn, firstOut, secIn, secOut, thirdIn, thirdOut
                    firstIn.Value = DateTime.Parse(formattedTimeParts[0]);
                    firstOut.Value = DateTime.Parse(formattedTimeParts[1]);
                    secIn.Value = DateTime.Parse(formattedTimeParts[2]);
                    secOut.Value = DateTime.Parse(formattedTimeParts[3]);
                    thirdIn.Value = DateTime.Parse(formattedTimeParts[4]);
                    thirdOut.Value = DateTime.Parse(formattedTimeParts[5]);
                }

                // Display the timeParts array in a MessageBox
                MessageBox.Show("time: " + string.Join(", ", timeParts));

                return formattedTimeParts;
            }

            return new List<string>();
        }


        private bool TryParseTime(string input, out string formattedTime)
        {
            if (DateTime.TryParse(input, out DateTime parsedTime))
            {
                formattedTime = parsedTime.ToString("hh:mm tt");
                return true;
            }
            else
            {
                // Handle invalid time format
                formattedTime = "Invalid Time";
                return false;
            }
        }
        //-------------------------------------------------------------------------------------------------------------
        private void setProgname()
        {
            try
            {
                int classId = int.Parse(displayClass_GridView.CurrentRow.Cells[2].Value.ToString());
                int rowIndex = displayClass_GridView.CurrentRow.Index; // Assuming this is the correct way to get the row index

                // Assuming you have a method to get Prog_id for a student from your database
                int progId = GetProgIdForClass(classId, rowIndex);

                // Call the stored procedure to get the program name based on the Prog_id
                string programName = GetProgramName(progId);

                // Set the dropdown list value to the program name
                C_program.SelectedItem = programName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error progname: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetProgIdForClass(int classId, int rowIndex)
        {
            if (classId != 0)
            {
                try
                {
                    var result = db.display_ClassContent().ToList();

                    if (result.Count > rowIndex)
                    {
                        var row = result[rowIndex];

                        int progId = (int)row.Prog_id;
                        if (progId != 0)
                        {
                            // If you already have the Prog_id, no need to query it again
                            return progId;
                        }
                    }
                    else
                    {
                        // Handle the case where the result set doesn't have enough rows
                        Console.WriteLine("Row index out of range");
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    Console.WriteLine("Error progid: " + ex.Message);
                }
            }

            // Return a default value or handle the case where classId is 0
            return 0; // Change this default value accordingly
        }
        private string GetProgramName(int progId)
        {
            try
            {
                using (var db = new DataClassEnrollmentDataContext())
                {
                    // Assuming select_progname is a LINQ to SQL method mapped to the stored procedure
                    var result = db.select_progname(progId).SingleOrDefault();

                    // Ensure the result is not null before accessing properties
                    if (result != null)
                    {
                        return result.ProgramName; // Access the ProgramName property
                    }
                }
                return string.Empty; // Return an empty string if no result is found
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting program name: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        //-------------------------------------------------------SECTION ID-------------------------------------------------------
        private void setProfname()
        {
            try
            {
                int classId = int.Parse(displayClass_GridView.CurrentRow.Cells[2].Value.ToString());
                int rowIndex = displayClass_GridView.CurrentRow.Index; // Assuming this is the correct way to get the row index

                // Assuming you have a method to get Prog_id for a student from your database
                int profId = GetProfIdForClass(classId, rowIndex);

                // Call the stored procedure to get the program name based on the Prog_id
                string profname = GetProfName(profId);

                // Set the dropdown list value to the program name
                C_Prof.Text = profname;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error progname: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetProfIdForClass(int classId, int rowIndex)
        {
            if (classId != 0)
            {
                try
                {
                    var result = db.display_ClassContent().ToList();

                    if (result.Count > rowIndex)
                    {
                        var row = result[rowIndex];

                        int profId = (int)row.Prof_id;
                        if (profId != 0)
                        {
                            // If you already have the Prog_id, no need to query it again
                            return profId;
                        }
                    }
                    else
                    {
                        // Handle the case where the result set doesn't have enough rows
                        Console.WriteLine("Row index out of range");
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    Console.WriteLine("Error profid: " + ex.Message);
                }
            }

            // Return a default value or handle the case where classId is 0
            return 0; // Change this default value accordingly
        }
        private string GetProfName(int profId)
        {
            try
            {
                using (var db = new DataClassEnrollmentDataContext())
                {
                    // Assuming select_progname is a LINQ to SQL method mapped to the stored procedure
                    var result = db.select_ProffesorName(profId).SingleOrDefault();

                    // Ensure the result is not null before accessing properties
                    if (result != null)
                    {
                        return result.FullProffesorName; // Access the ProgramName property
                    }
                }
                return string.Empty; // Return an empty string if no result is found
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting program name: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }
        //-------------------------------------------------------SECTION ID-------------------------------------------------------
        private void setSectionname()
        {
            try
            {
                int classId = int.Parse(displayClass_GridView.CurrentRow.Cells[2].Value.ToString());
                int rowIndex = displayClass_GridView.CurrentRow.Index; // Assuming this is the correct way to get the row index

                // Assuming you have a method to get sect_id for a student from your database
                int sectId = GetSectIdForClass(classId, rowIndex);

                // Call the stored procedure to get the program name based on the sect_id
                string sectionName = GetSectionName(sectId);


                // Set the dropdown list value to the section name
                C_section.Text = sectionName;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sectionname: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int GetSectIdForClass(int classId, int rowIndex)
        {
            if (classId != 0)
            {
                try
                {
                    var result = db.display_ClassContent().ToList();

                    if (result.Count > rowIndex)
                    {
                        var row = result[rowIndex];

                        int sectId = (int)row.Sect_id;
                        if (sectId != 0)
                        {
                            // If you already have the sect_id, no need to query it again
                            return sectId;
                        }
                    }
                    else
                    {
                        // Handle the case where the result set doesn't have enough rows
                        Console.WriteLine("Row index out of range");
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    Console.WriteLine("Error sectionid: " + ex.Message);
                }
            }

            // Return a default value or handle the case where classId is 0
            return 0; // Change this default value accordingly
        }
        private string GetSectionName(int sectId)
        {
            try
            {
                using (var db = new DataClassEnrollmentDataContext())
                {
                    // Assuming select_progname is a LINQ to SQL method mapped to the stored procedure
                    var resultsec = db.select_sectname(sectId).SingleOrDefault();

                    // Ensure the result is not null before accessing properties
                    if (resultsec != null)
                    {
                        return resultsec.FullSectionName; // Access the ProgramName property
                    }
                }
                return string.Empty; // Return an empty string if no result is found
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting program name: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        //-------------------------------------------------------SUBJECT ID-------------------------------------------------------
        private void setSubjname()
        {
            try
            {
                int classId = int.Parse(displayClass_GridView.CurrentRow.Cells[2].Value.ToString());
                int rowIndex = displayClass_GridView.CurrentRow.Index; // Assuming this is the correct way to get the row index

                // Assuming you have a method to get Prog_id for a student from your database
                int subjId = GetSubjIdForClass(classId, rowIndex);

                // Call the stored procedure to get the program name based on the Prog_id
                string subjName = GetSubjName(subjId);

                // Set the dropdown list value to the program name
                C_subject.Text = subjName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error subjname: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int GetSubjIdForClass(int classId, int rowIndex)
        {
            if (classId != 0)
            {
                try
                {
                    var result = db.display_ClassContent().ToList();

                    if (result.Count > rowIndex)
                    {
                        var row = result[rowIndex];

                        int subjId = (int)row.Sub_id;
                        if (subjId != 0)
                        {
                            // If you already have the Prog_id, no need to query it again
                            return subjId;
                        }
                    }
                    else
                    {
                        // Handle the case where the result set doesn't have enough rows
                        Console.WriteLine("Row index out of range");
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    MessageBox.Show("Error subjid: " + ex.Message);
                }
            }

            // Return a default value or handle the case where classId is 0
            return 0; // Change this default value accordingly
        }
        private string GetSubjName(int subjId)
        {
            try
            {
                using (var db = new DataClassEnrollmentDataContext())
                {
                    // Assuming select_progname is a LINQ to SQL method mapped to the stored procedure
                    var result = db.select_subname(subjId).SingleOrDefault();

                    // Ensure the result is not null before accessing properties
                    if (result != null)
                    {
                        return result.Sub_Code; // Access the ProgramName property
                    }
                }
                return string.Empty; // Return an empty string if no result is found
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting program name: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        private void class_searchbar_TextChanged(object sender, EventArgs e)
        {
            bool issearchEmpty = string.IsNullOrWhiteSpace(class_searchbar.Text);
            if (issearchEmpty)
            {
                MessageBox.Show("Please input a value to search");
            }
            else
            {
                displayClass_GridView.DataSource = db.search_class(class_searchbar.Text);
            }
        }
    }
}
