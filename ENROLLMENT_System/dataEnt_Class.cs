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
                var programNames = db.display_progname().Select(result => result.ProgramName).ToList();
                programNames.Insert(0, " ");

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
                var sectionNames = db.display_sectname().Select(result => new Section{ FullSectionName = result.FullSectionName}).ToList();

                sectionNames.Insert(0, new Section { FullSectionName = " " });

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
                var subjNames = db.display_subjname().Select(result => new SUBJECT{Sub_Code = result.Sub_Code}).ToList();

                subjNames.Insert(0, new SUBJECT { Sub_Code = " " });

                C_subject.DataSource = subjNames;
                C_subject.DisplayMember = "SubjectNames";
                C_subject.ValueMember = "Sub_Code";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Section names: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InitializeCheckedListBox()
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            foreach (string day in daysOfWeek)
            {
                SchedCheckList.Items.Add(day);
            }

            SchedCheckList.ItemCheck += SchedCheckList_ItemCheck;

            int rowIndex = 0; 
            List<string> selectedDaysForRow = GetSelectedDaysForRow(result, rowIndex);
            CheckItemsInSchedCheckList(selectedDaysForRow);
        }


        private void UpdateCheckedDays(string selectedDay, bool isChecked)
        {
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
                var suggestions = db.search_profname(C_Prof.Text).Select(result => $"{result.Prof_Fname} {result.Prof_Mname} {result.Prof_Lname}");

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
                    id = int.Parse(displayClass_GridView.CurrentRow.Cells[1].Value.ToString());
                    setProgname();
                    setProfname();
                    setSectionname();
                    setSubjname();
                    int rowIndex = e.RowIndex;
                    RetrieveDataByIndex(rowIndex);
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

                    id = row.Class_id;
                    C_code.Text = row.Class_Code;
                    C_classroom.Text = row.Class_Room;

                    int yearStart = row.YearStart.Value;
                    int yearEnd = row.YearEnd.Value;

                    DateTime startDate = new DateTime(yearStart, 1, 1);
                    DateTime endDate = new DateTime(yearEnd, 1, 1);

                    systart.Value = startDate;
                    syend.Value = endDate;

                    List<string> selectedDaysForRow = SplitByCapitalLetters(row.DaysOfWeek);

                    CheckItemsInSchedCheckList(selectedDaysForRow);

                    List<string> selectedTimeForRow = GetSelectedTime(result, rowIndex);

                }
                else
                {
                    Console.WriteLine("Row index out of range");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieve: " + ex.Message);
            }
        }

        private void CheckItemsInSchedCheckList(List<string> selectedDays)
        {
            for (int i = 0; i < SchedCheckList.Items.Count; i++)
            {
                SchedCheckList.SetItemCheckState(i, CheckState.Unchecked);
            }

            foreach (string selectedDay in selectedDays)
            {
                int index = SchedCheckList.FindStringExact(GetDayAbbreviationValue(selectedDay));

                if (index != ListBox.NoMatches)
                {
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
            var matches = Regex.Matches(input, "[A-Z][a-z]*");

            List<string> result = new List<string>();
            foreach (Match match in matches)
            {
                result.Add(match.Value);
            }
            return result;
        }


        private void SchedCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string selectedDay = SchedCheckList.Items[e.Index].ToString();
            bool isChecked = e.NewValue == CheckState.Checked;

            UpdateCheckedDays(selectedDay, isChecked);
        }

        private List<string> GetSelectedDaysForRow(List<ENROLLMENT_System.display_ClassContentResult> result, int rowIndex)
        {
            if (result != null && rowIndex >= 0 && rowIndex < result.Count)
            {
                var row = result[rowIndex];

                if (row != null && row.DaysOfWeek != null)
                {
                    string selectedDaysString = row.DaysOfWeek;

                    List<string> selectedDays = SplitByCapitalLetters(selectedDaysString);
                    return selectedDays;
                }
            }

            return new List<string>(); 
        }
        private List<string> GetSelectedTime(List<ENROLLMENT_System.display_ClassContentResult> result, int rowIndex)
        {
            if (result != null && rowIndex >= 0 && rowIndex < result.Count)
            {
                var row = result[rowIndex];

                if (row != null && row.SchedTime != null)
                {
                    List<string> splitTimeParts = SplitByDashnSlash(row.SchedTime);

                    return splitTimeParts;
                }
            }
            return new List<string>();
        }

        private List<string> SplitByDashnSlash(string input)
        {
            string[] timeParts = input.Split('-', '/');

            if (timeParts.Length >= 2)
            {
                List<string> formattedTimeParts = new List<string>();
                foreach (string part in timeParts)
                {
                    if (TryParseTime(part.Trim(), out string formattedTime))
                    {
                        formattedTimeParts.Add(formattedTime);
                    }
                    else
                    {
                        formattedTimeParts.Add("Invalid Time");
                    }
                }
                if (formattedTimeParts.Count >= 2)
                {
                    firstIn.Value = DateTime.Parse(formattedTimeParts[0]);
                    firstOut.Value = DateTime.Parse(formattedTimeParts[1]);
                    secIn.Value = DateTime.Parse(formattedTimeParts[2]);
                    secOut.Value = DateTime.Parse(formattedTimeParts[3]);
                    thirdIn.Value = DateTime.Parse(formattedTimeParts[4]);
                    thirdOut.Value = DateTime.Parse(formattedTimeParts[5]);
                }
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
                formattedTime = "Invalid Time";
                return false;
            }
        }
        //-------------------------------------------------------------------------------------------------------------
        private void setProgname()
        {
            try
            {
                int classId = int.Parse(displayClass_GridView.CurrentRow.Cells[1].Value.ToString());
                int rowIndex = displayClass_GridView.CurrentRow.Index; 

                int progId = GetProgIdForClass(classId, rowIndex);

                string programName = GetProgramName(progId);
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
                            return progId;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Row index out of range");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error progid: " + ex.Message);
                }
            }

            return 0;
        }
        private string GetProgramName(int progId)
        {
            try
            {
                using (var db = new DataClassEnrollmentDataContext())
                {
                    var result = db.select_progname(progId).SingleOrDefault();

                    if (result != null)
                    {
                        return result.ProgramName; 
                    }
                }
                return string.Empty; 
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
                int classId = int.Parse(displayClass_GridView.CurrentRow.Cells[1].Value.ToString());
                int rowIndex = displayClass_GridView.CurrentRow.Index; 

                int profId = GetProfIdForClass(classId, rowIndex);

                string profname = GetProfName(profId);

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
                            return profId;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Row index out of range");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error profid: " + ex.Message);
                }
            }

            return 0;
        }
        private string GetProfName(int profId)
        {
            try
            {
                using (var db = new DataClassEnrollmentDataContext())
                {
                    var result = db.select_ProffesorName(profId).SingleOrDefault();

                    if (result != null)
                    {
                        return result.FullProffesorName; 
                    }
                }
                return string.Empty; 
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
                int classId = int.Parse(displayClass_GridView.CurrentRow.Cells[1].Value.ToString());
                int rowIndex = displayClass_GridView.CurrentRow.Index; 

                int sectId = GetSectIdForClass(classId, rowIndex);

                string sectionName = GetSectionName(sectId);

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
                            return sectId;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Row index out of range");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error sectionid: " + ex.Message);
                }
            }

            return 0; 
        }
        private string GetSectionName(int sectId)
        {
            try
            {
                using (var db = new DataClassEnrollmentDataContext())
                {
                    var resultsec = db.select_sectname(sectId).SingleOrDefault();

                    if (resultsec != null)
                    {
                        return resultsec.FullSectionName; 
                    }
                }
                return string.Empty; 
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
                int classId = int.Parse(displayClass_GridView.CurrentRow.Cells[1].Value.ToString());
                int rowIndex = displayClass_GridView.CurrentRow.Index; 

                int subjId = GetSubjIdForClass(classId, rowIndex);

                string subjName = GetSubjName(subjId);

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
                            return subjId;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Row index out of range");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error subjid: " + ex.Message);
                }
            }

            return 0; 
        }
        private string GetSubjName(int subjId)
        {
            try
            {
                using (var db = new DataClassEnrollmentDataContext())
                {
                    var result = db.select_subname(subjId).SingleOrDefault();

                    if (result != null)
                    {
                        return result.Sub_Code; 
                    }
                }
                return string.Empty; 
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

        private void secondSched_Click(object sender, EventArgs e)
        {
            secIn.Enabled = true;
            secOut.Enabled = true;
        }

        private void thirdSched_Click(object sender, EventArgs e)
        {
            thirdIn.Enabled = true;
            thirdOut.Enabled = true;
        }

        private void updateClass_Click(object sender, EventArgs e)
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
            DateTime selectedDateTimeIn = firstIn.Value;
            DateTime selectedDateTimeOut = firstOut.Value;

            int yearstr = selecteddatestart.Year;
            int yearend = selecteddateEnd.Year;
            // Construct the schedTime string using the values from time pickers
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

            if ((secIn != null && secOut != null) && (thirdIn != null && thirdOut != null))
            {
                timepick = $"{first} / {second} / {third}";
            }
            else if (secIn != null && secOut != null)
            {
                timepick = $"{first} / {second}";
            }
            else
            {
                timepick = $"{first}";
            }


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
                    db.update_class(id, Classcode, Sched, timepick, yearstr, yearend, Classroom, resultProgId.Prog_id, resultSectId.Sect_id, resultSubjId.Sub_id, firstNonZeroId);
                    MessageBox.Show("Successfully Updated", "Message");
                    updateClass.Hide();
                    clear();
                    display();
                    savebtn.Show();
                }
            }
        }
    }
}
