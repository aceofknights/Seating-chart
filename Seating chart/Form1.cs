namespace Seating_chart
{
    public partial class Form1 : Form
    {
        private List<string> kidsList = new List<string>();
        private int totalSeats = 0;
        public Form1()
        {
            InitializeComponent();
            addKidButton.Click += addKidButton_Click;
            ShuffleButton.Click += ShuffleButton_Click;
            removeButton.Click += removeButton_Click;
            lockButton.Click += lockButton_Click;
            SaveButton.Click += SaveButton_Click;
            LoadButton.Click += LoadButton_Click;
        }

        private void btnGenerateChart_Click(object sender, EventArgs e)
        {
            //int numberOfKids = (int)numberOfKidsNumericUpDown.Value;
            //totalSeats = numberOfKids;
            //kidsList.Clear();

            // Add kids' names to the list
            //for (int i = 1; i <= numberOfKids; i++)
            //{
            //kidsList.Add($"Kid {i}");
            //}

            // Add specific kids to specific seats (if any)
            if (!string.IsNullOrWhiteSpace(specificKidTextBox.Text))
            {
                string[] specificSeats = specificKidTextBox.Text.Split(',');
                for (int i = 0; i < specificSeats.Length && i < kidsList.Count; i++)
                {
                    int seatIndex = int.Parse(specificSeats[i]) - 1; // Subtract 1 to convert to zero-based index
                    if (seatIndex >= 0 && seatIndex < totalSeats)
                    {
                        kidsList[seatIndex] = $"Kid {i + 1} (Specific)";
                    }
                }
            }

            // Randomly assign remaining kids to seats
            Random random = new Random();
            for (int i = kidsList.Count - 1; i >= 0; i--)
            {
                if (kidsList[i] == $"Kid {i + 1}")
                {
                    int randomIndex = random.Next(i, totalSeats);
                    string temp = kidsList[i];
                    kidsList[i] = kidsList[randomIndex];
                    kidsList[randomIndex] = temp;
                }
            }

            // Display the seating chart
            UpdateSeatingChart();
        }
        private void UpdateSeatingChart()
        {
            seatingChartListBox.Items.Clear();
            //seatingChartListBox.Items.AddRange(kidsList.ToArray());
            for (int i = 0; i < kidsList.Count; i++)
            {
                string listItem = $"Seat {i + 1}: {kidsList[i]}";
                seatingChartListBox.Items.Add(listItem);
            }
            seatingChartListBox.ClearSelected(); // Clear the selection
        }

        private void addKidButton_Click(object sender, EventArgs e)
        {
            string kidName = addKidTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(kidName))
            {
                kidsList.Add(kidName);
                UpdateSeatingChart();

                addKidTextBox.Clear(); // Clear the text box for the next entry
                addKidTextBox.Focus(); // Set focus to the text box
            }
        }

        private void ShuffleButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            List<int> lockedSeatIndices = new List<int>();

            for (int i = 0; i < kidsList.Count; i++)
            {
                if (kidsList[i].Contains("(Locked)"))
                {
                    lockedSeatIndices.Add(i);
                }
            }

            List<string> unlockedSeats = kidsList.Where((item, index) => !lockedSeatIndices.Contains(index)).ToList();
            List<string> shuffledUnlockedSeats = unlockedSeats.OrderBy(item => random.Next()).ToList();

            int shuffledIndex = 0;
            List<string> shuffledKidsList = new List<string>(kidsList.Count);

            for (int i = 0; i < kidsList.Count; i++)
            {
                if (lockedSeatIndices.Contains(i))
                {
                    shuffledKidsList.Add(kidsList[i]);
                }
                else
                {
                    shuffledKidsList.Add(shuffledUnlockedSeats[shuffledIndex]);
                    shuffledIndex++;
                }
            }

            kidsList = shuffledKidsList;
            UpdateSeatingChart();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (seatingChartListBox.SelectedIndex >= 0)
            {
                kidsList.RemoveAt(seatingChartListBox.SelectedIndex);
                UpdateSeatingChart();
            }
        }

        private void lockButton_Click(object sender, EventArgs e)
        {
            string kidName = specificKidTextBox.Text.Trim();
            int seatNumber = int.Parse(specificSeatsTextBox.Text.Trim());

            if (!string.IsNullOrEmpty(kidName) && seatNumber >= 1 && seatNumber <= kidsList.Count)
            {
                kidsList[seatNumber - 1] = $"Seat {seatNumber}: {kidName} (Locked)";
                UpdateSeatingChart();
            }
        }

        private void Swap<T>(ref T first, ref T second)
        {
            T temp = first;
            first = second;
            second = temp;
        }
        //save method
        private void SaveKidsListToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (string kidName in kidsList)
                {
                    writer.WriteLine(kidName);
                }
            }
        }
        //loading method
        private void LoadKidsListFromFile(string fileName)
        {
            kidsList.Clear();
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    kidsList.Add(line);
                }
            }
            UpdateSeatingChart(); // Update the seating chart after loading
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SaveKidsListToFile(saveFileDialog.FileName);
                }
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadKidsListFromFile(openFileDialog.FileName);
                }
            }
        }
    }

}