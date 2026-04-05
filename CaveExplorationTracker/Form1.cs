using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CaveExplorationTracker
{
    public partial class Form1 : Form
    {
        // This list stores every cave object the user creates.
        // We use the base class type so the list can hold Cave,
        // IceCave, and CrystalCave objects together.
        private List<Cave> caveList = new List<Cave>();

        public Form1()
        {
            InitializeComponent();
            lstCaves.HorizontalScrollbar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add the cave type options into the combo box when the form loads.
            cmbCaveType.Items.Clear();
            cmbCaveType.Items.Add("Regular Cave");
            cmbCaveType.Items.Add("Ice Cave");
            cmbCaveType.Items.Add("Crystal Cave");

            // Set a default selection so the form is ready to use immediately.
            cmbCaveType.SelectedIndex = 0;

            // Update the special field so it matches the selected type.
            UpdateSpecialFieldUI();
        }

        private void btnAddCave_Click(object sender, EventArgs e)
        {
            double depth;
            double length;

            // Validate cave name input.
            if (string.IsNullOrWhiteSpace(txtCaveName.Text))
            {
                MessageBox.Show("Enter cave name.");
                return;
            }

            // Validate location input.
            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Enter location.");
                return;
            }

            // Validate depth input.
            if (!double.TryParse(txtDepth.Text, out depth) || depth < 0)
            {
                MessageBox.Show("Enter valid depth.");
                return;
            }

            // Validate length input.
            if (!double.TryParse(txtLength.Text, out length) || length < 0)
            {
                MessageBox.Show("Enter valid length.");
                return;
            }

            // Determine which cave type the user selected.
            string selectedType = cmbCaveType.SelectedItem.ToString();

            // This variable will hold whichever object gets created.
            Cave newCave;

            if (selectedType == "Regular Cave")
            {
                // Create a normal base-class Cave object.
                newCave = new Cave(
                    txtCaveName.Text,
                    txtLocation.Text,
                    depth,
                    length,
                    chkIsExplored.Checked
                );
            }
            else if (selectedType == "Ice Cave")
            {
                double iceThickness;

                // Ice Cave needs one extra numeric value.
                if (!double.TryParse(txtSpecialValue.Text, out iceThickness) || iceThickness < 0)
                {
                    MessageBox.Show("Enter valid ice thickness.");
                    return;
                }

                // Create an IceCave object.
                newCave = new IceCave(
                    txtCaveName.Text,
                    txtLocation.Text,
                    depth,
                    length,
                    chkIsExplored.Checked,
                    iceThickness
                );
            }
            else
            {
                int crystalCount;

                // Crystal Cave needs one extra integer value.
                if (!int.TryParse(txtSpecialValue.Text, out crystalCount) || crystalCount < 0)
                {
                    MessageBox.Show("Enter valid crystal count.");
                    return;
                }

                // Create a CrystalCave object.
                newCave = new CrystalCave(
                    txtCaveName.Text,
                    txtLocation.Text,
                    depth,
                    length,
                    chkIsExplored.Checked,
                    crystalCount
                );
            }

            // Add the new cave object into the list.
            caveList.Add(newCave);

            // Refresh the ListBox so it shows the newest data cleanly.
            RefreshCaveList();

            // Clear the inputs after adding.
            ClearInputs();
        }

        private void btnClearInputs_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            // Clear all shared input fields.
            txtCaveName.Clear();
            txtLocation.Clear();
            txtDepth.Clear();
            txtLength.Clear();
            txtSpecialValue.Clear();
            chkIsExplored.Checked = false;

            // Reset combo box to Regular Cave.
            cmbCaveType.SelectedIndex = 0;

            // Put the cursor back in the first textbox for better UX.
            txtCaveName.Focus();
        }

        private void btnLoadSamples_Click(object sender, EventArgs e)
        {
            // Clear current data before loading sample objects.
            caveList.Clear();
            lstCaves.Items.Clear();

            // Load a mix of base class and subclass objects
            // so you can demonstrate inheritance in the video.
            caveList.Add(new Cave("Crystal Hollow", "Kentucky", 450, 1200, true));
            caveList.Add(new IceCave("Frozen Echo", "Alaska", 600, 1500, false, 18.5));
            caveList.Add(new CrystalCave("Gemstone Vault", "Nevada", 300, 950, true, 240));
            caveList.Add(new IceCave("Glacier Tunnel", "Montana", 800, 2100, true, 25.0));
            caveList.Add(new CrystalCave("Shimmer Cavern", "Arizona", 520, 1750, false, 125));

            // Refresh the ListBox display.
            RefreshCaveList();
        }

        private void btnClearSelected_Click(object sender, EventArgs e)
        {
            // Check if the user selected a cave first.
            if (lstCaves.SelectedIndex != -1)
            {
                int selectedIndex = lstCaves.SelectedIndex;

                // Remove from the data list.
                caveList.RemoveAt(selectedIndex);

                // Refresh the ListBox so indexes stay lined up.
                RefreshCaveList();
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

        private void cmbCaveType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSpecialFieldUI();
        }

        private void UpdateSpecialFieldUI()
        {
            // Make sure something is selected before trying to use it.
            if (cmbCaveType.SelectedItem == null)
            {
                return;
            }

            string selectedType = cmbCaveType.SelectedItem.ToString();

            // Regular Cave does not need a special extra value.
            if (selectedType == "Regular Cave")
            {
                lblSpecialValue.Text = "Special Value:";
                txtSpecialValue.Enabled = false;
                txtSpecialValue.Clear();
            }
            else if (selectedType == "Ice Cave")
            {
                lblSpecialValue.Text = "Ice Thickness:";
                txtSpecialValue.Enabled = true;
                txtSpecialValue.Clear();
            }
            else if (selectedType == "Crystal Cave")
            {
                lblSpecialValue.Text = "Crystal Count:";
                txtSpecialValue.Enabled = true;
                txtSpecialValue.Clear();
            }
        }

        private void RefreshCaveList()
        {
            // Clear the visual list before rebuilding it.
            lstCaves.Items.Clear();

            // Show each object using the Display() method.
            foreach (Cave cave in caveList)
            {
                lstCaves.Items.Add(cave.Display());
            }
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            if (lstCaves.SelectedIndex != -1)
            {
                Cave selectedCave = caveList[lstCaves.SelectedIndex];
                MessageBox.Show(selectedCave.Display(), "Display()");
            }
            else
            {
                MessageBox.Show("Please select a cave first.");
            }
        }

        private void btnDisplayOne_Click(object sender, EventArgs e)
        {
            if (lstCaves.SelectedIndex != -1)
            {
                Cave selectedCave = caveList[lstCaves.SelectedIndex];
                MessageBox.Show(selectedCave.Display(1), "Display(1)");
            }
            else
            {
                MessageBox.Show("Please select a cave first.");
            }
        }

        private void btnDisplayTwo_Click(object sender, EventArgs e)
        {
            if (lstCaves.SelectedIndex != -1)
            {
                Cave selectedCave = caveList[lstCaves.SelectedIndex];
                MessageBox.Show(selectedCave.Display(2), "Display(2)");
            }
            else
            {
                MessageBox.Show("Please select a cave first.");
            }
        }

        private void btnShowSpecial_Click(object sender, EventArgs e)
        {
            if (lstCaves.SelectedIndex != -1)
            {
                Cave selectedCave = caveList[lstCaves.SelectedIndex];

                // If the selected object is an IceCave,
                // show the interface method and unique subclass method.
                if (selectedCave is IceCave iceCave)
                {
                    MessageBox.Show(
                        iceCave.GetExplorationTip() + Environment.NewLine + iceCave.MeasureIce(),
                        "Ice Cave Special"
                    );
                }
                // If the selected object is a CrystalCave,
                // show the interface method and unique subclass method.
                else if (selectedCave is CrystalCave crystalCave)
                {
                    MessageBox.Show(
                        crystalCave.GetExplorationTip() + Environment.NewLine + crystalCave.EvaluateCrystals(),
                        "Crystal Cave Special"
                    );
                }
                else
                {
                    MessageBox.Show("Regular Cave objects do not have a special subclass method.");
                }
            }
            else
            {
                MessageBox.Show("Please select a cave first.");
            }
        }
    }
}
