namespace CaveExplorationTracker
{
    public partial class Form1 : Form
    {

        private List<Cave> caveList = new List<Cave>();
        public Form1()
        {
            InitializeComponent();
            lstCaves.HorizontalScrollbar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCave_Click(object sender, EventArgs e)
        {
            double depth;
            double length;

            if (string.IsNullOrWhiteSpace(txtCaveName.Text))
            {
                MessageBox.Show("Enter cave name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Enter location.");
                return;
            }

            if (!double.TryParse(txtDepth.Text, out depth) || depth < 0)
            {
                MessageBox.Show("Enter valid depth.");
                return;
            }

            if (!double.TryParse(txtLength.Text, out length) || length < 0)
            {
                MessageBox.Show("Enter valid length.");
                return;
            }

            Cave newCave = new Cave(
                txtCaveName.Text,
                txtLocation.Text,
                depth,
                length,
                chkIsExplored.Checked
            );

            caveList.Add(newCave);

            lstCaves.Items.Add(newCave.GetDisplayText());

            ClearInputs();
        }

        private void btnClearInputs_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtCaveName.Clear();
            txtLocation.Clear();
            txtDepth.Clear();
            txtLength.Clear();
            chkIsExplored.Checked = false;
        }

        private void btnLoadSamples_Click(object sender, EventArgs e)
        {
            caveList.Clear();
            lstCaves.Items.Clear();

            caveList.Add(new Cave("Crystal Hollow", "Kentucky", 450, 1200, true));
            caveList.Add(new Cave("Shadow Drop", "Tennessee", 680, 2100, false));
            caveList.Add(new Cave("Echo Cavern", "Missouri", 300, 980, true));
            caveList.Add(new Cave("Iron Mouth Cave", "Colorado", 950, 3400, false));
            caveList.Add(new Cave("Moonstone Caverns", "New Mexico", 520, 1750, true));

            foreach (Cave cave in caveList)
            {
                lstCaves.Items.Add(cave.GetDisplayText());
            }
        }

        private void btnClearSelected_Click(object sender, EventArgs e)
        {
            // Check if something is selected
            if (lstCaves.SelectedIndex != -1)
            {
                int selectedIndex = lstCaves.SelectedIndex;

                // Remove from the data list
                caveList.RemoveAt(selectedIndex);

                // Remove from the ListBox display
                lstCaves.Items.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("Please select a cave to remove.");
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete all caves?",
                "Confirm",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                caveList.Clear();
                lstCaves.Items.Clear();
            }
        }
    }
}
